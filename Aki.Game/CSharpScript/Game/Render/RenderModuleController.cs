using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003501 RID: 13569
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RenderModuleController : ControllerBase
	{
		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x0602283A RID: 141370 RVA: 0x009CBC71 File Offset: 0x009C9E71
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0602283B RID: 141371 RVA: 0x009CBC74 File Offset: 0x009C9E74
		public FTransformDouble? GetKuroCurrentUiSceneTransform()
		{
			return this.UiSceneOffsetTransform;
		}

		// Token: 0x0602283C RID: 141372 RVA: 0x009CBC7C File Offset: 0x009C9E7C
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

		// Token: 0x0602283D RID: 141373 RVA: 0x009CBCCA File Offset: 0x009C9ECA
		public void SetKuroUiSceneLoadOffset(FVectorDouble offset)
		{
			this.KuroUiSceneLoadOffset = offset;
		}

		// Token: 0x0602283E RID: 141374 RVA: 0x009CBCD3 File Offset: 0x009C9ED3
		public void ResetKuroUiSceneLoadOffset()
		{
			this.KuroUiSceneLoadOffset = new FVectorDouble(150000.0, 150000.0, 150000.0);
		}

		// Token: 0x0602283F RID: 141375 RVA: 0x009CBCFC File Offset: 0x009C9EFC
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

		// Token: 0x06022840 RID: 141376 RVA: 0x009CBD98 File Offset: 0x009C9F98
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
			EventSystem.Instance.Emit(EEventName.WorldPartitionDataLayerStateUpdated);
		}

		// Token: 0x06022841 RID: 141377 RVA: 0x009CBEAC File Offset: 0x009CA0AC
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

		// Token: 0x06022842 RID: 141378 RVA: 0x009CC0F4 File Offset: 0x009CA2F4
		public bool IsWorldPartitionDataLayerEnable(string dataLayerName)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.IsWorldPartitionDataLayerEnable(GlobalData.World, FNameUtil.GetDynamicFName(dataLayerName) ?? FName.NAME_None) || (ModelManager.Instance.IsInit && RenderModuleModel.Instance.IsDependenciesNotMatchDataLayer(dataLayerName));
		}

		// Token: 0x06022843 RID: 141379 RVA: 0x009CC146 File Offset: 0x009CA346
		public void AddBattleReference(FVectorDouble location)
		{
			RenderModuleModel.Instance.AddBattleReference(location);
		}

		// Token: 0x06022844 RID: 141380 RVA: 0x009CC153 File Offset: 0x009CA353
		public void DecBattleReference()
		{
			RenderModuleModel.Instance.DecBattleReference();
		}

		// Token: 0x06022845 RID: 141381 RVA: 0x009CC15F File Offset: 0x009CA35F
		public EWuYinQuState GetCurrentKeyState(string actorKey)
		{
			return RenderModuleModel.Instance.GetCurrentKeyState(actorKey);
		}

		// Token: 0x06022846 RID: 141382 RVA: 0x009CC16C File Offset: 0x009CA36C
		public bool GetIdleClearAtmosphere(string actorKey)
		{
			return RenderModuleModel.Instance.GetIdleClearAtmosphere(actorKey);
		}

		// Token: 0x06022847 RID: 141383 RVA: 0x009CC179 File Offset: 0x009CA379
		public void SetBattleState(string key, EWuYinQuState state, bool instantTransition = false)
		{
			if (ModelManager.Instance.IsInit)
			{
				RenderModuleModel.Instance.SetBattleState(key, state, instantTransition);
			}
		}

		// Token: 0x06022848 RID: 141384 RVA: 0x009CC194 File Offset: 0x009CA394
		public TArray<string> GetWuYinQuBattleDebugInfo()
		{
			return RenderModuleModel.Instance.GetWuYinQuBattleDebugInfo();
		}

		// Token: 0x06022849 RID: 141385 RVA: 0x009CC1A0 File Offset: 0x009CA3A0
		public EWuYinQuState GetBattleState(string key)
		{
			return RenderModuleModel.Instance.GetBattleState(key);
		}

		// Token: 0x0602284A RID: 141386 RVA: 0x009CC1AD File Offset: 0x009CA3AD
		[NullableContext(2)]
		public string GetCurrentBattleKey()
		{
			return RenderModuleModel.Instance.GetCurrentBattleKey();
		}

		// Token: 0x0602284B RID: 141387 RVA: 0x009CC1B9 File Offset: 0x009CA3B9
		public void AddWuYinQuBattleActorWaiting(WuYinQuBattleActor actor)
		{
			if (this.WaitingForAddWuYinQuBattleActors == null)
			{
				this.WaitingForAddWuYinQuBattleActors = new List<WuYinQuBattleActor>();
			}
			this.WaitingForAddWuYinQuBattleActors.Add(actor);
		}

		// Token: 0x0602284C RID: 141388 RVA: 0x009CC1DA File Offset: 0x009CA3DA
		public bool AddWuYinQuBattleActor(WuYinQuBattleActor actor)
		{
			return ModelManager.Instance.IsInit && RenderModuleModel.Instance.AddWuYinQuBattleActor(actor);
		}

		// Token: 0x0602284D RID: 141389 RVA: 0x009CC1F5 File Offset: 0x009CA3F5
		public bool RemoveWuYinQuBattleActor(WuYinQuBattleActor actor)
		{
			return ModelManager.Instance.IsInit && RenderModuleModel.Instance.RemoveWuYinQuBattleActor(actor);
		}

		// Token: 0x0602284E RID: 141390 RVA: 0x009CC210 File Offset: 0x009CA410
		public void AddTickableObject(IRenderModuleTickableObject obj)
		{
			RenderModuleModel.Instance.AddTickableObject(obj);
		}

		// Token: 0x0602284F RID: 141391 RVA: 0x009CC21D File Offset: 0x009CA41D
		public void RemoveTickableObject(IRenderModuleTickableObject obj)
		{
			if (ModelManager.Instance.IsInit)
			{
				RenderModuleModel.Instance.RemoveTickableObject(obj);
			}
		}

		// Token: 0x06022850 RID: 141392 RVA: 0x009CC236 File Offset: 0x009CA436
		public void AddCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			RenderModuleModel.Instance.AddCharRenderShell(charRenderingComponent);
		}

		// Token: 0x06022851 RID: 141393 RVA: 0x009CC243 File Offset: 0x009CA443
		public bool RemoveCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			return ModelManager.Instance.IsInit && RenderModuleModel.Instance.RemoveCharRenderShell(charRenderingComponent);
		}

		// Token: 0x06022852 RID: 141394 RVA: 0x009CC25E File Offset: 0x009CA45E
		public int GetRainIntensity()
		{
			return (int)RenderModuleModel.Instance.GetRainIntensity();
		}

		// Token: 0x06022853 RID: 141395 RVA: 0x009CC26B File Offset: 0x009CA46B
		public int GetSnowIntensity()
		{
			return (int)RenderModuleModel.Instance.GetSnowIntensity();
		}

		// Token: 0x06022854 RID: 141396 RVA: 0x009CC278 File Offset: 0x009CA478
		public bool IsRuntime()
		{
			return this.Inited;
		}

		// Token: 0x06022855 RID: 141397 RVA: 0x009CC280 File Offset: 0x009CA480
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

		// Token: 0x06022856 RID: 141398 RVA: 0x009CC329 File Offset: 0x009CA529
		private void OnBossFight(int entityId)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.GlobalGIRenderQuality 1", null);
		}

		// Token: 0x06022857 RID: 141399 RVA: 0x009CC33B File Offset: 0x009CA53B
		private void BattleStateChanged(bool isGameInBattle)
		{
			if (!isGameInBattle)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.GlobalGIRenderQuality 0", null);
			}
		}

		// Token: 0x06022858 RID: 141400 RVA: 0x009CC350 File Offset: 0x009CA550
		protected override bool OnClear()
		{
			this.Inited = false;
			EventSystem.Instance.Remove<int>(EEventName.OnBossFight, new Action<int>(this.OnBossFight));
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.BattleStateChanged));
			return true;
		}

		// Token: 0x06022859 RID: 141401 RVA: 0x009CC39D File Offset: 0x009CA59D
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0602285A RID: 141402 RVA: 0x009CC3A0 File Offset: 0x009CA5A0
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

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x0602285B RID: 141403 RVA: 0x009CC454 File Offset: 0x009CA654
		public static RenderModuleController Instance
		{
			get
			{
				return RenderModuleController._Instance;
			}
		}

		// Token: 0x0602285C RID: 141404 RVA: 0x009CC45B File Offset: 0x009CA65B
		public static RenderModuleController GetOrCreateInstance()
		{
			if (RenderModuleController._Instance == null)
			{
				RenderModuleController.CreateInstance();
			}
			return RenderModuleController._Instance;
		}

		// Token: 0x0602285D RID: 141405 RVA: 0x009CC46F File Offset: 0x009CA66F
		public static bool CreateInstance()
		{
			if (RenderModuleController._Instance != null)
			{
				return true;
			}
			RenderModuleController._Instance = new RenderModuleController();
			return true;
		}

		// Token: 0x0602285E RID: 141406 RVA: 0x009CC485 File Offset: 0x009CA685
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602285F RID: 141407 RVA: 0x009CC487 File Offset: 0x009CA687
		public static void ResetStaticDefaultValue()
		{
			RenderModuleController._Instance = null;
		}

		// Token: 0x06022860 RID: 141408 RVA: 0x009CC48F File Offset: 0x009CA68F
		static RenderModuleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderModuleController.CreateStaticDefaultValue), new Action(RenderModuleController.ResetStaticDefaultValue));
		}

		// Token: 0x04013151 RID: 78161
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

		// Token: 0x04013152 RID: 78162
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

		// Token: 0x04013153 RID: 78163
		private bool Inited;

		// Token: 0x04013154 RID: 78164
		private const bool TickInPrePhysics = false;

		// Token: 0x04013155 RID: 78165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<WuYinQuBattleActor> WaitingForAddWuYinQuBattleActors;

		// Token: 0x04013156 RID: 78166
		public bool IsGamePaused;

		// Token: 0x04013157 RID: 78167
		public float GlobalTimeDilation = 1f;

		// Token: 0x04013158 RID: 78168
		public bool DebugNewUiSceneWorkflow = true;

		// Token: 0x04013159 RID: 78169
		public FVectorDouble? DebugUiSceneLoadOffset;

		// Token: 0x0401315A RID: 78170
		public FTransformDouble? UiSceneOffsetTransform;

		// Token: 0x0401315B RID: 78171
		public bool DebugStartShowingUiSceneRendering;

		// Token: 0x0401315C RID: 78172
		public bool DebugInUiSceneRendering;

		// Token: 0x0401315D RID: 78173
		public bool IsDynamicOffset;

		// Token: 0x0401315E RID: 78174
		private FVectorDouble KuroUiSceneLoadOffset = new FVectorDouble(150000.0, 150000.0, 150000.0);

		// Token: 0x0401315F RID: 78175
		[Nullable(2)]
		private static RenderModuleController _Instance;
	}
}
