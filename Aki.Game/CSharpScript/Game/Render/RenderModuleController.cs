using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D8 RID: 17880
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RenderModuleController : ControllerBase
	{
		// Token: 0x170075A9 RID: 30121
		// (get) Token: 0x0602E146 RID: 188742 RVA: 0x00A9F5A1 File Offset: 0x00A9D7A1
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0602E147 RID: 188743 RVA: 0x00A9F5A4 File Offset: 0x00A9D7A4
		public FTransformDouble? GetKuroCurrentUiSceneTransform()
		{
			return this.UiSceneOffsetTransform;
		}

		// Token: 0x0602E148 RID: 188744 RVA: 0x00A9F5AC File Offset: 0x00A9D7AC
		public FVectorDouble GetKuroUiSceneLoadOffset()
		{
			if (this.IsDynamicOffset)
			{
				AActor myRoleTriggerOrUndefined = RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined();
				if (myRoleTriggerOrUndefined != null && myRoleTriggerOrUndefined.IsValid())
				{
					FVectorDouble result = myRoleTriggerOrUndefined.D_K2_GetActorLocation();
					result.Z += 50000.0;
					return result;
				}
			}
			return this.KuroUiSceneLoadOffset;
		}

		// Token: 0x0602E149 RID: 188745 RVA: 0x00A9F5FA File Offset: 0x00A9D7FA
		public void SetKuroUiSceneLoadOffset(FVectorDouble offset)
		{
			this.KuroUiSceneLoadOffset = offset;
		}

		// Token: 0x0602E14A RID: 188746 RVA: 0x00A9F603 File Offset: 0x00A9D803
		public void ResetKuroUiSceneLoadOffset()
		{
			this.KuroUiSceneLoadOffset = new FVectorDouble(150000.0, 150000.0, 150000.0);
		}

		// Token: 0x0602E14B RID: 188747 RVA: 0x00A9F62C File Offset: 0x00A9D82C
		private bool CheckDataLayerDependenciesMatch(string dataLayerName)
		{
			HashSet<string> hashSet;
			this.hardCodeDataLayerDependencies.TryGetValue(dataLayerName, out hashSet);
			bool flag = true;
			if (hashSet != null && hashSet.Count > 0)
			{
				foreach (string key in hashSet)
				{
					flag = (flag && UKuroRenderingRuntimeBPPluginBPLibrary.IsWorldPartitionDataLayerEnable(GlobalData.World, FNameUtil.GetDynamicFName(key) ?? FName.NAME_None));
					if (!flag)
					{
						break;
					}
				}
			}
			return flag;
		}

		// Token: 0x0602E14C RID: 188748 RVA: 0x00A9F6C8 File Offset: 0x00A9D8C8
		public unsafe void SetWorldPartitionDataLayerState(string dataLayerName, bool isEnable, bool bKeepLoadIfDisable = false)
		{
			if (isEnable && !this.CheckDataLayerDependenciesMatch(dataLayerName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SetWorldPartitionDataLayerState]激活DataLayer前，发现依赖不满足，停止激活DataLayer，并加进DependenciesNotMatchDataLayerSet中";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dataLayerName", dataLayerName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				RenderModuleModel.Instance.AddDependenciesNotMatchDataLayer(dataLayerName);
				return;
			}
			if (ModelManager.Instance.IsInit && RenderModuleModel.Instance.IsDependenciesNotMatchDataLayer(dataLayerName))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.World;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SetWorldPartitionDataLayerState]激活/停用DataLayer时，发现其在DependenciesNotMatchDataLayerSet中，移除";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dataLayerName", dataLayerName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isEnable", isEnable);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				RenderModuleModel.Instance.RemoveDependenciesNotMatchDataLayer(dataLayerName);
			}
			EDataLayerState newState = isEnable ? EDataLayerState.Activated : (bKeepLoadIfDisable ? EDataLayerState.Loaded : EDataLayerState.Unloaded);
			UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState2(GlobalData.World, FNameUtil.GetDynamicFName(dataLayerName) ?? FName.NAME_None, newState);
			this.AfterSetWorldPartitionDataLayerState(dataLayerName, isEnable, bKeepLoadIfDisable);
		}

		// Token: 0x0602E14D RID: 188749 RVA: 0x00A9F7D0 File Offset: 0x00A9D9D0
		private unsafe void AfterSetWorldPartitionDataLayerState(string dataLayerName, bool isEnable, bool bKeepLoadIfDisable)
		{
			EDataLayerState newState = isEnable ? EDataLayerState.Activated : (bKeepLoadIfDisable ? EDataLayerState.Loaded : EDataLayerState.Unloaded);
			HashSet<string> hashSet;
			this.hardCodeReversedDataLayerDependencies.TryGetValue(dataLayerName, out hashSet);
			if (isEnable)
			{
				if (hashSet == null || hashSet.Count == 0)
				{
					return;
				}
				foreach (string text in hashSet)
				{
					if (ModelManager.Instance.IsInit && RenderModuleModel.Instance.IsDependenciesNotMatchDataLayer(text) && this.CheckDataLayerDependenciesMatch(text))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.World;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "[SetWorldPartitionDataLayerState]激活DataLayer后，发现有本该激活的RelatedDataLayer依赖都已满足，激活relatedDataLayer";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dataLayerName", dataLayerName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("relatedDataLayer", text);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						RenderModuleModel.Instance.RemoveDependenciesNotMatchDataLayer(text);
						UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState2(GlobalData.World, FNameUtil.GetDynamicFName(text) ?? FName.NAME_None, newState);
					}
				}
				return;
			}
			else
			{
				if (hashSet == null || hashSet.Count == 0)
				{
					return;
				}
				foreach (string text2 in hashSet)
				{
					if (UKuroRenderingRuntimeBPPluginBPLibrary.IsWorldPartitionDataLayerEnable(GlobalData.World, FNameUtil.GetDynamicFName(text2) ?? FName.NAME_None))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.World;
						ELogAuthor author2 = ELogAuthor.ZYL;
						string message2 = "[SetWorldPartitionDataLayerState]停用DataLayer后，发现有已激活的RelatedDataLayer依赖当前DataLayer，停用RelatedDataLayer";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("dataLayerName", dataLayerName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("relatedDataLayer", text2);
						instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						if (ModelManager.Instance.IsInit)
						{
							RenderModuleModel.Instance.AddDependenciesNotMatchDataLayer(text2);
						}
						UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState2(GlobalData.World, FNameUtil.GetDynamicFName(text2) ?? FName.NAME_None, newState);
					}
				}
				return;
			}
		}

		// Token: 0x0602E14E RID: 188750 RVA: 0x00A9FA18 File Offset: 0x00A9DC18
		public bool IsWorldPartitionDataLayerEnable(string dataLayerName)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.IsWorldPartitionDataLayerEnable(GlobalData.World, FNameUtil.GetDynamicFName(dataLayerName) ?? FName.NAME_None) || (ModelManager.Instance.IsInit && RenderModuleModel.Instance.IsDependenciesNotMatchDataLayer(dataLayerName));
		}

		// Token: 0x0602E14F RID: 188751 RVA: 0x00A9FA6A File Offset: 0x00A9DC6A
		public void AddBattleReference(FVectorDouble location)
		{
			RenderModuleModel.Instance.AddBattleReference(location);
		}

		// Token: 0x0602E150 RID: 188752 RVA: 0x00A9FA77 File Offset: 0x00A9DC77
		public void DecBattleReference()
		{
			RenderModuleModel.Instance.DecBattleReference();
		}

		// Token: 0x0602E151 RID: 188753 RVA: 0x00A9FA83 File Offset: 0x00A9DC83
		public EWuYinQuState GetCurrentKeyState(string actorKey)
		{
			return RenderModuleModel.Instance.GetCurrentKeyState(actorKey);
		}

		// Token: 0x0602E152 RID: 188754 RVA: 0x00A9FA90 File Offset: 0x00A9DC90
		public bool GetIdleClearAtmosphere(string actorKey)
		{
			return RenderModuleModel.Instance.GetIdleClearAtmosphere(actorKey);
		}

		// Token: 0x0602E153 RID: 188755 RVA: 0x00A9FA9D File Offset: 0x00A9DC9D
		public void SetBattleState(string key, EWuYinQuState state, bool instantTransition = false)
		{
			if (ModelManager.Instance.IsInit)
			{
				RenderModuleModel.Instance.SetBattleState(key, state, instantTransition);
			}
		}

		// Token: 0x0602E154 RID: 188756 RVA: 0x00A9FAB8 File Offset: 0x00A9DCB8
		public TArray<string> GetWuYinQuBattleDebugInfo()
		{
			return RenderModuleModel.Instance.GetWuYinQuBattleDebugInfo();
		}

		// Token: 0x0602E155 RID: 188757 RVA: 0x00A9FAC4 File Offset: 0x00A9DCC4
		public EWuYinQuState GetBattleState(string key)
		{
			return RenderModuleModel.Instance.GetBattleState(key);
		}

		// Token: 0x0602E156 RID: 188758 RVA: 0x00A9FAD1 File Offset: 0x00A9DCD1
		[NullableContext(2)]
		public string GetCurrentBattleKey()
		{
			return RenderModuleModel.Instance.GetCurrentBattleKey();
		}

		// Token: 0x0602E157 RID: 188759 RVA: 0x00A9FADD File Offset: 0x00A9DCDD
		public void AddWuYinQuBattleActorWaiting(WuYinQuBattleActor actor)
		{
			if (this.WaitingForAddWuYinQuBattleActors == null)
			{
				this.WaitingForAddWuYinQuBattleActors = new List<WuYinQuBattleActor>();
			}
			this.WaitingForAddWuYinQuBattleActors.Add(actor);
		}

		// Token: 0x0602E158 RID: 188760 RVA: 0x00A9FAFE File Offset: 0x00A9DCFE
		public bool AddWuYinQuBattleActor(WuYinQuBattleActor actor)
		{
			return ModelManager.Instance.IsInit && RenderModuleModel.Instance.AddWuYinQuBattleActor(actor);
		}

		// Token: 0x0602E159 RID: 188761 RVA: 0x00A9FB19 File Offset: 0x00A9DD19
		public bool RemoveWuYinQuBattleActor(WuYinQuBattleActor actor)
		{
			return ModelManager.Instance.IsInit && RenderModuleModel.Instance.RemoveWuYinQuBattleActor(actor);
		}

		// Token: 0x0602E15A RID: 188762 RVA: 0x00A9FB34 File Offset: 0x00A9DD34
		public void AddTickableObject(IRenderModuleTickableObject obj)
		{
			RenderModuleModel.Instance.AddTickableObject(obj);
		}

		// Token: 0x0602E15B RID: 188763 RVA: 0x00A9FB41 File Offset: 0x00A9DD41
		public void RemoveTickableObject(IRenderModuleTickableObject obj)
		{
			if (ModelManager.Instance.IsInit)
			{
				RenderModuleModel.Instance.RemoveTickableObject(obj);
			}
		}

		// Token: 0x0602E15C RID: 188764 RVA: 0x00A9FB5A File Offset: 0x00A9DD5A
		public void AddCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			RenderModuleModel.Instance.AddCharRenderShell(charRenderingComponent);
		}

		// Token: 0x0602E15D RID: 188765 RVA: 0x00A9FB67 File Offset: 0x00A9DD67
		public bool RemoveCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			return ModelManager.Instance.IsInit && RenderModuleModel.Instance.RemoveCharRenderShell(charRenderingComponent);
		}

		// Token: 0x0602E15E RID: 188766 RVA: 0x00A9FB82 File Offset: 0x00A9DD82
		public int GetRainIntensity()
		{
			return (int)RenderModuleModel.Instance.GetRainIntensity();
		}

		// Token: 0x0602E15F RID: 188767 RVA: 0x00A9FB8F File Offset: 0x00A9DD8F
		public int GetSnowIntensity()
		{
			return (int)RenderModuleModel.Instance.GetSnowIntensity();
		}

		// Token: 0x0602E160 RID: 188768 RVA: 0x00A9FB9C File Offset: 0x00A9DD9C
		public bool IsRuntime()
		{
			return this.Inited;
		}

		// Token: 0x0602E161 RID: 188769 RVA: 0x00A9FBA4 File Offset: 0x00A9DDA4
		protected override bool OnInit()
		{
			RenderStats.Init();
			this.DebugUiSceneLoadOffset = new FVectorDouble?(new FVectorDouble());
			this.UiSceneOffsetTransform = new FTransformDouble?(new FTransformDouble());
			this.Inited = true;
			EventSystem.Instance.Add<int>(EEventName.OnBossFight, new Action<int>(this.OnBossFight));
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.BattleStateChanged));
			TickSystem.Instance.Add(new Action<float>(this.DoTick), "RenderModuleController", ETickingGroup.TG_EndPhysics, true, 0, false);
			if (UKuroStaticLibrary.IsLowMemoryDevice())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.UseUnloadCache false", null);
			}
			return true;
		}

		// Token: 0x0602E162 RID: 188770 RVA: 0x00A9FC4D File Offset: 0x00A9DE4D
		private void OnBossFight(int entityId)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.GlobalGIRenderQuality 1", null);
		}

		// Token: 0x0602E163 RID: 188771 RVA: 0x00A9FC5F File Offset: 0x00A9DE5F
		private void BattleStateChanged(bool isGameInBattle)
		{
			if (!isGameInBattle)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.GlobalGIRenderQuality 0", null);
			}
		}

		// Token: 0x0602E164 RID: 188772 RVA: 0x00A9FC74 File Offset: 0x00A9DE74
		protected override bool OnClear()
		{
			this.Inited = false;
			EventSystem.Instance.Remove<int>(EEventName.OnBossFight, new Action<int>(this.OnBossFight));
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.BattleStateChanged));
			return true;
		}

		// Token: 0x0602E165 RID: 188773 RVA: 0x00A9FCC1 File Offset: 0x00A9DEC1
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0602E166 RID: 188774 RVA: 0x00A9FCC4 File Offset: 0x00A9DEC4
		private void DoTick(float delta)
		{
			if (!this.Inited)
			{
				return;
			}
			this.IsGamePaused = MathUtils.Instance.IsNearlyEqual((double)this.GlobalTimeDilation, 0.0, null);
			if (this.WaitingForAddWuYinQuBattleActors != null && this.WaitingForAddWuYinQuBattleActors.Count != 0)
			{
				foreach (WuYinQuBattleActor actor in this.WaitingForAddWuYinQuBattleActors)
				{
					this.AddWuYinQuBattleActor(actor);
				}
				this.WaitingForAddWuYinQuBattleActors = new List<WuYinQuBattleActor>();
			}
			RenderModuleModel.Instance.Tick(delta);
		}

		// Token: 0x170075AA RID: 30122
		// (get) Token: 0x0602E167 RID: 188775 RVA: 0x00A9FD78 File Offset: 0x00A9DF78
		public static RenderModuleController Instance
		{
			get
			{
				return RenderModuleController._Instance;
			}
		}

		// Token: 0x0602E168 RID: 188776 RVA: 0x00A9FD7F File Offset: 0x00A9DF7F
		public static RenderModuleController GetOrCreateInstance()
		{
			if (RenderModuleController._Instance == null)
			{
				RenderModuleController.CreateInstance();
			}
			return RenderModuleController._Instance;
		}

		// Token: 0x0602E169 RID: 188777 RVA: 0x00A9FD93 File Offset: 0x00A9DF93
		public static bool CreateInstance()
		{
			if (RenderModuleController._Instance != null)
			{
				return true;
			}
			RenderModuleController._Instance = new RenderModuleController();
			return true;
		}

		// Token: 0x0602E16A RID: 188778 RVA: 0x00A9FDA9 File Offset: 0x00A9DFA9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E16B RID: 188779 RVA: 0x00A9FDAB File Offset: 0x00A9DFAB
		public static void ResetStaticDefaultValue()
		{
			RenderModuleController._Instance = null;
		}

		// Token: 0x0602E16C RID: 188780 RVA: 0x00A9FDB3 File Offset: 0x00A9DFB3
		static RenderModuleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderModuleController.CreateStaticDefaultValue), new Action(RenderModuleController.ResetStaticDefaultValue));
		}

		// Token: 0x04018B13 RID: 101139
		private readonly Dictionary<string, HashSet<string>> hardCodeDataLayerDependencies = new Dictionary<string, HashSet<string>>
		{
			{
				"DataLayerRuntime_DLTask_30FGL03",
				new HashSet<string>
				{
					"DataLayerRuntime_DLTask_30FGL02"
				}
			},
			{
				"DataLayerRuntime_DLTask_30FGL04",
				new HashSet<string>
				{
					"DataLayerRuntime_DLTask_30FGL02"
				}
			},
			{
				"DataLayerRuntime_DLTask_30FGL05",
				new HashSet<string>
				{
					"DataLayerRuntime_DLTask_30FGL02"
				}
			}
		};

		// Token: 0x04018B14 RID: 101140
		private readonly Dictionary<string, HashSet<string>> hardCodeReversedDataLayerDependencies = new Dictionary<string, HashSet<string>>
		{
			{
				"DataLayerRuntime_DLTask_30FGL02",
				new HashSet<string>
				{
					"DataLayerRuntime_DLTask_30FGL03",
					"DataLayerRuntime_DLTask_30FGL04",
					"DataLayerRuntime_DLTask_30FGL05"
				}
			}
		};

		// Token: 0x04018B15 RID: 101141
		private bool Inited;

		// Token: 0x04018B16 RID: 101142
		private const bool TickInPrePhysics = false;

		// Token: 0x04018B17 RID: 101143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<WuYinQuBattleActor> WaitingForAddWuYinQuBattleActors;

		// Token: 0x04018B18 RID: 101144
		public bool IsGamePaused;

		// Token: 0x04018B19 RID: 101145
		public float GlobalTimeDilation = 1f;

		// Token: 0x04018B1A RID: 101146
		public bool DebugNewUiSceneWorkflow = true;

		// Token: 0x04018B1B RID: 101147
		public FVectorDouble? DebugUiSceneLoadOffset;

		// Token: 0x04018B1C RID: 101148
		public FTransformDouble? UiSceneOffsetTransform;

		// Token: 0x04018B1D RID: 101149
		public bool DebugStartShowingUiSceneRendering;

		// Token: 0x04018B1E RID: 101150
		public bool DebugInUiSceneRendering;

		// Token: 0x04018B1F RID: 101151
		public bool IsDynamicOffset;

		// Token: 0x04018B20 RID: 101152
		private FVectorDouble KuroUiSceneLoadOffset = new FVectorDouble(150000.0, 150000.0, 150000.0);

		// Token: 0x04018B21 RID: 101153
		[Nullable(2)]
		private static RenderModuleController _Instance;
	}
}
