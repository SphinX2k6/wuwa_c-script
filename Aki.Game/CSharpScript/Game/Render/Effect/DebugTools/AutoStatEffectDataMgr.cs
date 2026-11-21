using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.DebugTools
{
	// Token: 0x0200351E RID: 13598
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoStatEffectDataMgr : IStaticVariableResetter
	{
		// Token: 0x060229F8 RID: 141816 RVA: 0x009DA165 File Offset: 0x009D8365
		static AutoStatEffectDataMgr()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AutoStatEffectDataMgr.CreateStaticDefaultValue), new Action(AutoStatEffectDataMgr.ResetStaticDefaultValue));
		}

		// Token: 0x060229F9 RID: 141817 RVA: 0x009DA1A0 File Offset: 0x009D83A0
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

		// Token: 0x060229FA RID: 141818 RVA: 0x009DA1F5 File Offset: 0x009D83F5
		public static double GetMicrosecond()
		{
			if (Platform.Instance.IsWindowsPlatform())
			{
				return KuroTime.GetCycles64() * 0.1;
			}
			return KuroTime.GetCycles64();
		}

		// Token: 0x060229FB RID: 141819 RVA: 0x009DA218 File Offset: 0x009D8418
		private AutoStatEffectDataMgr()
		{
			this.TickId = -1;
		}

		// Token: 0x060229FC RID: 141820 RVA: 0x009DA228 File Offset: 0x009D8428
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

		// Token: 0x060229FD RID: 141821 RVA: 0x009DA2D8 File Offset: 0x009D84D8
		public void Play(int inStartIndex = 0, int inEndIndex = -1)
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.ZJF, "shipping 包或test 包", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060229FE RID: 141822 RVA: 0x009DA31C File Offset: 0x009D851C
		public void PlayWithTrace()
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.ZJF, "shipping 包或test 包", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060229FF RID: 141823 RVA: 0x009DA345 File Offset: 0x009D8545
		private void Tick(float delayTime)
		{
			this.UpdateState(delayTime);
		}

		// Token: 0x06022A00 RID: 141824 RVA: 0x009DA350 File Offset: 0x009D8550
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

		// Token: 0x06022A01 RID: 141825 RVA: 0x009DA3D2 File Offset: 0x009D85D2
		private void ChangeState(EPlayEffectState state)
		{
			this.State = state;
			this.StateTime = 0f;
		}

		// Token: 0x06022A02 RID: 141826 RVA: 0x009DA3E8 File Offset: 0x009D85E8
		private void TickCurrent(double deltaMillionSeconds)
		{
			if (!EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				return;
			}
			double num = PerformanceController.Instance.ConsumeTickTime("NiagaraDebugTick");
			this.EffectStats[this.EffectStats.Count - 1].UpdateTimeArray.Add(num * 1000.0);
		}

		// Token: 0x06022A03 RID: 141827 RVA: 0x009DA448 File Offset: 0x009D8648
		private void StopCurrent()
		{
			if (EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle, "[AutoStatEffectDataMgr.StopCurrent]", true, null);
				this.EffectHandle = 0;
			}
			this.EffectStats[this.EffectStats.Count - 1].OnStop((double)this.StateTime);
		}

		// Token: 0x06022A04 RID: 141828 RVA: 0x009DA4B4 File Offset: 0x009D86B4
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

		// Token: 0x06022A05 RID: 141829 RVA: 0x009DA728 File Offset: 0x009D8928
		public static void CreateStaticDefaultValue()
		{
			AutoStatEffectDataMgr.SpawnEffectStat = null;
			AutoStatEffectDataMgr.UpdateEffectStat = null;
			AutoStatEffectDataMgr._Instance = null;
		}

		// Token: 0x06022A06 RID: 141830 RVA: 0x009DA73C File Offset: 0x009D893C
		public static void ResetStaticDefaultValue()
		{
			AutoStatEffectDataMgr.SpawnEffectStat = null;
			AutoStatEffectDataMgr.UpdateEffectStat = null;
			AutoStatEffectDataMgr._Instance = null;
		}

		// Token: 0x040132CD RID: 78541
		public int TickId;

		// Token: 0x040132CE RID: 78542
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> BasePaths;

		// Token: 0x040132CF RID: 78543
		private int EffectHandle;

		// Token: 0x040132D0 RID: 78544
		private float StateTime;

		// Token: 0x040132D1 RID: 78545
		private EPlayEffectState State;

		// Token: 0x040132D2 RID: 78546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<EffectStatData> EffectStats;

		// Token: 0x040132D3 RID: 78547
		private int EffectPlayTime;

		// Token: 0x040132D4 RID: 78548
		private string CurrentEffectPath;

		// Token: 0x040132D5 RID: 78549
		private bool IsOpenStatTrace;

		// Token: 0x040132D6 RID: 78550
		private static readonly int EffectMaxPlayTime = 1;

		// Token: 0x040132D7 RID: 78551
		private static readonly float EffectMaxLoopTime = 5000f;

		// Token: 0x040132D8 RID: 78552
		private static readonly float EffectWaitingTime = 1000f;

		// Token: 0x040132D9 RID: 78553
		private static Stat SpawnEffectStat;

		// Token: 0x040132DA RID: 78554
		private static Stat UpdateEffectStat;

		// Token: 0x040132DB RID: 78555
		private static AutoStatEffectDataMgr _Instance;

		// Token: 0x040132DC RID: 78556
		[Nullable(1)]
		private const string EFFECT_PATHS_DA_PATH = "/Game/Aki/Render/RuntimeBP/Effect/Debug/DA_EffectPaths.DA_EffectPaths";
	}
}
