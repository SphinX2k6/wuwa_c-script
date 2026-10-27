using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Debug;
using CSharpScript.Core.Common;
using CSharpScript.Game.Effect;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.DebugTools
{
	// Token: 0x020045F5 RID: 17909
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoStatEffectDataMgr : IStaticVariableResetter
	{
		// Token: 0x0602E303 RID: 189187 RVA: 0x00AAD9C9 File Offset: 0x00AABBC9
		static AutoStatEffectDataMgr()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AutoStatEffectDataMgr.CreateStaticDefaultValue), new Action(AutoStatEffectDataMgr.ResetStaticDefaultValue));
		}

		// Token: 0x0602E304 RID: 189188 RVA: 0x00AADA04 File Offset: 0x00AABC04
		[NullableContext(1)]
		public static AutoStatEffectDataMgr Get()
		{
			if (AutoStatEffectDataMgr._Instance == null)
			{
				AutoStatEffectDataMgr._Instance = new AutoStatEffectDataMgr();
				AutoStatEffectDataMgr.SpawnEffectStat = Stat.Create("AutoStatEffectDataMgr:SpawnEffect", "", "");
				AutoStatEffectDataMgr.UpdateEffectStat = Stat.Create("AutoStatEffectDataMgr:UpdateEffect", "", "");
			}
			return AutoStatEffectDataMgr._Instance;
		}

		// Token: 0x0602E305 RID: 189189 RVA: 0x00AADA59 File Offset: 0x00AABC59
		public static double GetMicrosecond()
		{
			if (Platform.Instance.IsWindowsPlatform())
			{
				return KuroTime.GetCycles64() * 0.1;
			}
			return KuroTime.GetCycles64();
		}

		// Token: 0x0602E306 RID: 189190 RVA: 0x00AADA7C File Offset: 0x00AABC7C
		private AutoStatEffectDataMgr()
		{
			this.TickId = -1;
		}

		// Token: 0x0602E307 RID: 189191 RVA: 0x00AADA8C File Offset: 0x00AABC8C
		private void Reset()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			if (EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle, "[AutoStatEffectDataMgr.Reset]", false, null);
				this.EffectHandle = 0;
			}
			this.EffectStats = new List<EffectStatData>();
			this.StateTime = 0f;
			this.State = EPlayEffectState.Waiting;
			this.EffectPlayTime = 0;
			this.IsOpenStatTrace = false;
			this.CurrentEffectPath = null;
			EffectGlobal.Instance.AllowEffectInPool = false;
			EffectGlobal.Instance.AllowEffectOutPool = false;
		}

		// Token: 0x0602E308 RID: 189192 RVA: 0x00AADB3C File Offset: 0x00AABD3C
		public void Play(int inStartIndex = 0, int inEndIndex = -1)
		{
			if (!Info.Instance.IsBuildDevelopmentOrDebug)
			{
				Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.ZJF, "shipping 包或test 包", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Reset();
			ResourceSystem.Instance.LoadAsync<PDA_EffectPaths_C>("/Game/Aki/Render/RuntimeBP/Effect/Debug/DA_EffectPaths.DA_EffectPaths", delegate([Nullable(2)] PDA_EffectPaths_C result, string _)
			{
				TArray<string> basePaths = result.BasePaths;
				int num = 0;
				if (inStartIndex > 0 && inStartIndex < basePaths.Num() - 1)
				{
					num = inStartIndex;
				}
				int num2 = basePaths.Num() - 1;
				if (inEndIndex != -1 && inEndIndex < basePaths.Num())
				{
					num2 = inEndIndex;
				}
				this.BasePaths = new List<string>();
				for (int i = num; i <= num2; i++)
				{
					this.BasePaths.Add(basePaths.Get(i));
				}
				this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "PlayEffectOneByOne", ETickingGroup.TG_PrePhysics, false, 0, false).Id;
			}, 100, "js_undefined");
		}

		// Token: 0x0602E309 RID: 189193 RVA: 0x00AADBB8 File Offset: 0x00AABDB8
		public void PlayWithTrace()
		{
			if (!Info.Instance.IsBuildDevelopmentOrDebug)
			{
				Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.ZJF, "shipping 包或test 包", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Reset();
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Stat NamedEvents", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Trace.Start", null);
			this.IsOpenStatTrace = true;
			this.BasePaths = new List<string>();
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "PlayEffectOneByOne", ETickingGroup.TG_PrePhysics, false, 0, false).Id;
		}

		// Token: 0x0602E30A RID: 189194 RVA: 0x00AADC50 File Offset: 0x00AABE50
		private void Tick(float delayTime)
		{
			this.UpdateState(delayTime);
		}

		// Token: 0x0602E30B RID: 189195 RVA: 0x00AADC5C File Offset: 0x00AABE5C
		private void UpdateState(float deltaMillionSeconds)
		{
			this.StateTime += deltaMillionSeconds;
			EPlayEffectState state = this.State;
			if (state != EPlayEffectState.Playing)
			{
				if (state != EPlayEffectState.Waiting)
				{
					return;
				}
				if (this.StateTime >= AutoStatEffectDataMgr.EffectWaitingTime)
				{
					this.PlayNext();
					this.ChangeState(EPlayEffectState.Playing);
					this.TickCurrent((double)deltaMillionSeconds);
				}
				return;
			}
			else
			{
				if (!EffectSystem.Instance.IsValid(this.EffectHandle) || this.StateTime >= AutoStatEffectDataMgr.EffectMaxLoopTime)
				{
					this.StopCurrent();
					this.ChangeState(EPlayEffectState.Waiting);
					return;
				}
				this.TickCurrent((double)deltaMillionSeconds);
				return;
			}
		}

		// Token: 0x0602E30C RID: 189196 RVA: 0x00AADCDE File Offset: 0x00AABEDE
		private void ChangeState(EPlayEffectState state)
		{
			this.State = state;
			this.StateTime = 0f;
		}

		// Token: 0x0602E30D RID: 189197 RVA: 0x00AADCF4 File Offset: 0x00AABEF4
		private void TickCurrent(double deltaMillionSeconds)
		{
			if (!EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				return;
			}
			double num = PerformanceController.Instance.ConsumeTickTime("NiagaraDebugTick");
			this.EffectStats[this.EffectStats.Count - 1].UpdateTimeArray.Add(num * 1000.0);
		}

		// Token: 0x0602E30E RID: 189198 RVA: 0x00AADD54 File Offset: 0x00AABF54
		private void StopCurrent()
		{
			if (EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle, "[AutoStatEffectDataMgr.StopCurrent]", true, null);
				this.EffectHandle = 0;
			}
			this.EffectStats[this.EffectStats.Count - 1].OnStop((double)this.StateTime);
		}

		// Token: 0x0602E30F RID: 189199 RVA: 0x00AADDC0 File Offset: 0x00AABFC0
		private void PlayNext()
		{
			if (this.BasePaths.Count == 0)
			{
				if (this.TickId != -1)
				{
					TickSystem.Instance.Remove(this.TickId);
					this.TickId = -1;
				}
				List<string> list = new List<string>();
				foreach (EffectStatData effectStatData in this.EffectStats)
				{
					list.Add(effectStatData.ToCsv());
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendFormatted(UKismetSystemLibrary.GetProjectSavedDirectory());
				defaultInterpolatedStringHandler.AppendLiteral("Profiling/");
				defaultInterpolatedStringHandler.AppendFormatted<long>(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
				defaultInterpolatedStringHandler.AppendLiteral("_EffectStats.csv");
				string fileName = defaultInterpolatedStringHandler.ToStringAndClear();
				bool value = UKuroStaticLibrary.SaveStringToFile(EffectStatData.CsvHeader + string.Join("\n", list), fileName, false);
				this.EffectStats.Clear();
				if (this.IsOpenStatTrace)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Trace.Stop", null);
				}
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[保存特效统计信息:");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(value);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					text
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			this.EffectPlayTime++;
			if (this.CurrentEffectPath == null || this.EffectPlayTime > AutoStatEffectDataMgr.EffectMaxPlayTime)
			{
				this.CurrentEffectPath = this.BasePaths[this.BasePaths.Count - 1];
				this.BasePaths.RemoveAt(this.BasePaths.Count - 1);
				this.EffectPlayTime = 1;
			}
			double microsecond = AutoStatEffectDataMgr.GetMicrosecond();
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(baseCharacter.D_GetTransform());
			this.EffectHandle = instance.SpawnEffect(world, ftransformDouble, this.CurrentEffectPath, "[AutoStatEffectDataMgr.PlayNext]", null, EEffectType.Scene, delegate(int h)
			{
				EffectSystem.Instance.DebugUpdate(h, true);
			}, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				return;
			}
			double microsecond2 = AutoStatEffectDataMgr.GetMicrosecond();
			this.EffectStats.Add(new EffectStatData(this.CurrentEffectPath, microsecond2 - microsecond));
		}

		// Token: 0x0602E310 RID: 189200 RVA: 0x00AAE034 File Offset: 0x00AAC234
		public static void CreateStaticDefaultValue()
		{
			AutoStatEffectDataMgr.SpawnEffectStat = null;
			AutoStatEffectDataMgr.UpdateEffectStat = null;
			AutoStatEffectDataMgr._Instance = null;
		}

		// Token: 0x0602E311 RID: 189201 RVA: 0x00AAE048 File Offset: 0x00AAC248
		public static void ResetStaticDefaultValue()
		{
			AutoStatEffectDataMgr.SpawnEffectStat = null;
			AutoStatEffectDataMgr.UpdateEffectStat = null;
			AutoStatEffectDataMgr._Instance = null;
		}

		// Token: 0x04018C8E RID: 101518
		public int TickId;

		// Token: 0x04018C8F RID: 101519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> BasePaths;

		// Token: 0x04018C90 RID: 101520
		private int EffectHandle;

		// Token: 0x04018C91 RID: 101521
		private float StateTime;

		// Token: 0x04018C92 RID: 101522
		private EPlayEffectState State;

		// Token: 0x04018C93 RID: 101523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<EffectStatData> EffectStats;

		// Token: 0x04018C94 RID: 101524
		private int EffectPlayTime;

		// Token: 0x04018C95 RID: 101525
		private string CurrentEffectPath;

		// Token: 0x04018C96 RID: 101526
		private bool IsOpenStatTrace;

		// Token: 0x04018C97 RID: 101527
		private static readonly int EffectMaxPlayTime = 1;

		// Token: 0x04018C98 RID: 101528
		private static readonly float EffectMaxLoopTime = 5000f;

		// Token: 0x04018C99 RID: 101529
		private static readonly float EffectWaitingTime = 1000f;

		// Token: 0x04018C9A RID: 101530
		private static Stat SpawnEffectStat;

		// Token: 0x04018C9B RID: 101531
		private static Stat UpdateEffectStat;

		// Token: 0x04018C9C RID: 101532
		private static AutoStatEffectDataMgr _Instance;

		// Token: 0x04018C9D RID: 101533
		[Nullable(1)]
		private const string EFFECT_PATHS_DA_PATH = "/Game/Aki/Render/RuntimeBP/Effect/Debug/DA_EffectPaths.DA_EffectPaths";
	}
}
