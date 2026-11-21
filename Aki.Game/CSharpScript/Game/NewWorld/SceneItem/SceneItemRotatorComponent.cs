using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006246 RID: 25158
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemRotatorComponent : EntityComponent
	{
		// Token: 0x0603CAD4 RID: 248532 RVA: 0x01167E3C File Offset: 0x0116603C
		protected unsafe override bool OnInitData(IEntityArgs args = null)
		{
			RotatorComponent2 rotatorComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemRotatorComponent>() as RotatorComponent2;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.StateRotationConfigMap = new Dictionary<int, IStateRotationConfig>();
			foreach (IStateRotationConfig stateRotationConfig in rotatorComponent.Config)
			{
				int tagIdByName = GameplayTagUtils.GetTagIdByName(stateRotationConfig.State);
				if (tagIdByName == 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SceneItemRotatorComponent] 配置出错，找不到" + stateRotationConfig.State + "对应的状态Id";
					string item = "PbDataId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				List<IRotationConfig> list = (stateRotationConfig.RotationConfig != null && stateRotationConfig.RotationConfig.Count > 0) ? stateRotationConfig.RotationConfig : null;
				List<IKeyRotatorConfig> list2 = (stateRotationConfig.KeyRotatorConfig != null && stateRotationConfig.KeyRotatorConfig.Count > 0) ? stateRotationConfig.KeyRotatorConfig : null;
				if (list != null && list2 != null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[SceneItemRotatorComponent] 该状态同时存在两种旋转配置列表，配置有误，跳过该状态的配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item2 = "PbDataId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("State", stateRotationConfig.State);
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else if (list == null && list2 == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SceneItem;
					ELogAuthor author3 = ELogAuthor.ZYL;
					string message3 = "[SceneItemRotatorComponent] 该状态的旋转配置列表为空，跳过该状态的配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item3 = "PbDataId";
					CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
					ptr2 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("State", stateRotationConfig.State);
					instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					this.StateRotationConfigMap[tagIdByName] = stateRotationConfig;
				}
			}
			return true;
		}

		// Token: 0x0603CAD5 RID: 248533 RVA: 0x011680B0 File Offset: 0x011662B0
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SceneItemRotatorComponent] 实体缺少SceneItemActorComponent";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (this.ActorComp.Owner == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SceneItemRotatorComponent] 实体的SceneItemActorComponent.Owner不可用";
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (base.Entity.GameBudgetConfig.GroupName == FNameUtil.GetDynamicFName("MoveSceneItemEntity"))
			{
				this.NeedTickOutside = true;
			}
			this.UeMoveComp = (this.ActorComp.Owner.GetComponentByClass(UKuroSceneItemMoveComponent.StaticClass()) as UKuroSceneItemMoveComponent);
			UKuroSceneItemMoveComponent ueMoveComp = this.UeMoveComp;
			if (ueMoveComp == null || !ueMoveComp.IsValid())
			{
				AActor owner = this.ActorComp.Owner;
				TSubclassOf<UActorComponent> @class = UKuroSceneItemMoveComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				this.UeMoveComp = (owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroSceneItemMoveComponent);
				UKuroSceneItemMoveComponent ueMoveComp2 = this.UeMoveComp;
				if (ueMoveComp2 == null || !ueMoveComp2.IsValid())
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SceneItem;
					ELogAuthor author3 = ELogAuthor.ZYL;
					string message3 = "[SceneItemRotatorComponent] 实体Actor缺少KuroSceneItemMoveComponent，且动态创建失败";
					string item3 = "PbDataId";
					CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return false;
				}
				this.UeMoveComp.Kuro_SetGravityDirect(this.ActorComp.ActorGravityDirectProxy.ToUeVectorOld());
				this.UeMoveComp.SetTickingMoveEnable(false);
				if (this.NeedTickOutside)
				{
					this.UeMoveComp.SetKuroOnlyTickOutside(true);
				}
			}
			this.StateComp = base.Entity.GetComponent<SceneItemStateComponent>();
			if (this.StateComp == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[SceneItemRotatorComponent] 实体缺少SceneItemStateComponent";
				string item4 = "PbDataId";
				CreatureDataComponent creatureDataComp4 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>(item4, (creatureDataComp4 != null) ? new int?(creatureDataComp4.GetPbDataId()) : null);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			this.TagComp = base.Entity.GetComponent<LevelTagComponent>();
			if (this.TagComp == null)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.SceneItem;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[SceneItemRotatorComponent] 实体缺少LevelTagComponent";
				string item5 = "PbDataId";
				CreatureDataComponent creatureDataComp5 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>(item5, (creatureDataComp5 != null) ? new int?(creatureDataComp5.GetPbDataId()) : null);
				instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
				return false;
			}
			this.UeTickComp = base.Entity.GetComponent<UeSceneItemMoveTickManagerComponent>();
			if (this.UeTickComp == null)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.SceneItem;
				ELogAuthor author6 = ELogAuthor.ZYL;
				string message6 = "[SceneItemRotatorComponent] 实体缺少UeSceneItemMoveTickManagerComponent";
				string item6 = "PbDataId";
				CreatureDataComponent creatureDataComp6 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>(item6, (creatureDataComp6 != null) ? new int?(creatureDataComp6.GetPbDataId()) : null);
				instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
				return false;
			}
			return true;
		}

		// Token: 0x0603CAD6 RID: 248534 RVA: 0x0116840C File Offset: 0x0116660C
		protected override void OnActivate()
		{
			this.IsAllCurvesLoaded = false;
			this.IsAllActorsLoaded = false;
			this.IsRotationDataInit = false;
			this.SetAndLoadCurves();
			this.SetAndLoadActors();
			if (!this.IsRotationDataInit && this.IsAllCurvesLoaded && this.IsAllActorsLoaded)
			{
				this.InitRotationData();
			}
		}

		// Token: 0x0603CAD7 RID: 248535 RVA: 0x01168458 File Offset: 0x01166658
		protected override void OnTick(float delta)
		{
			if (this.NeedTickOutside)
			{
				UeSceneItemMoveTickManagerComponent ueTickComp = this.UeTickComp;
				if (ueTickComp == null)
				{
					return;
				}
				ueTickComp.TickMovement(delta, false);
			}
		}

		// Token: 0x0603CAD8 RID: 248536 RVA: 0x01168474 File Offset: 0x01166674
		[NullableContext(1)]
		protected override void OnDisable(string reason)
		{
			this.IsAllActorsLoaded = false;
			this.IsRotationDataInit = false;
			this.CurStateTagId = 0;
			this.PauseRotateStateId = 0;
			UKuroSceneItemMoveComponent ueMoveComp = this.UeMoveComp;
			if (ueMoveComp != null && ueMoveComp.IsRotating())
			{
				this.UeMoveComp.StopRotate(EKuroSceneItemStopRotateMethod.KeepCurrent, true);
			}
		}

		// Token: 0x0603CAD9 RID: 248537 RVA: 0x011684B4 File Offset: 0x011666B4
		protected override void OnEnable()
		{
			if (!this.IsAllActorsLoaded)
			{
				this.SetAndLoadActors();
			}
			if (!this.IsRotationDataInit && this.IsAllCurvesLoaded && this.IsAllActorsLoaded)
			{
				this.InitRotationData();
			}
		}

		// Token: 0x0603CADA RID: 248538 RVA: 0x011684E4 File Offset: 0x011666E4
		private void SetAndLoadCurves()
		{
			this.IsAllCurvesLoaded = true;
			foreach (KeyValuePair<int, IStateRotationConfig> keyValuePair in this.StateRotationConfigMap)
			{
				int num;
				IStateRotationConfig stateRotationConfig;
				keyValuePair.Deconstruct(out num, out stateRotationConfig);
				IStateRotationConfig stateRotationConfig2 = stateRotationConfig;
				List<IRotationConfig> list = (stateRotationConfig2.RotationConfig != null && stateRotationConfig2.RotationConfig.Count > 0) ? stateRotationConfig2.RotationConfig : null;
				List<IKeyRotatorConfig> list2 = (stateRotationConfig2.KeyRotatorConfig != null && stateRotationConfig2.KeyRotatorConfig.Count > 0) ? stateRotationConfig2.KeyRotatorConfig : null;
				IEnumerable<ICommonRotationConfig> enumerable;
				if (list != null)
				{
					enumerable = list;
				}
				else
				{
					enumerable = list2;
				}
				if (enumerable != null)
				{
					foreach (ICommonRotationConfig commonRotationConfig in enumerable)
					{
						if (!string.IsNullOrEmpty(commonRotationConfig.Curve))
						{
							if (this.CurveMap == null)
							{
								this.CurveMap = new Dictionary<string, UCurveFloat>();
							}
							if (!this.CurveMap.ContainsKey(commonRotationConfig.Curve))
							{
								UCurveFloat loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>(commonRotationConfig.Curve);
								if (loadedAsset != null)
								{
									this.CurveMap[commonRotationConfig.Curve] = loadedAsset;
								}
								else
								{
									this.CurveMap[commonRotationConfig.Curve] = null;
									this.IsAllCurvesLoaded = false;
								}
							}
						}
					}
				}
			}
			if (!this.IsAllCurvesLoaded)
			{
				if (this.LoadCurveHandleMap == null)
				{
					this.LoadCurveHandleMap = new Dictionary<string, int>();
				}
				foreach (KeyValuePair<string, UCurveFloat> keyValuePair2 in this.CurveMap)
				{
					string text;
					UCurveFloat ucurveFloat;
					keyValuePair2.Deconstruct(out text, out ucurveFloat);
					string text2 = text;
					if (ucurveFloat == null)
					{
						int value = ResourceSystem.Instance.LoadAsync<UCurveFloat>(text2, new Action<UCurveFloat, string>(this.SetupSingleCurve), 100, "js_undefined");
						this.LoadCurveHandleMap[text2] = value;
					}
				}
			}
		}

		// Token: 0x0603CADB RID: 248539 RVA: 0x01168720 File Offset: 0x01166920
		private void SetAndLoadActors()
		{
			this.IsAllActorsLoaded = false;
			foreach (IStateRotationConfig stateRotationConfig in this.StateRotationConfigMap.Values)
			{
				string key = stateRotationConfig.RotatePoint ?? "";
				if (this.RotatePointMap == null)
				{
					this.RotatePointMap = new Dictionary<string, AActor>();
				}
				if (!this.RotatePointMap.ContainsKey(key))
				{
					this.RotatePointMap[key] = null;
				}
			}
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.SetupAllActors)))
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.SetupAllActors));
			}
			if (this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				this.SetupAllActors();
			}
		}

		// Token: 0x0603CADC RID: 248540 RVA: 0x0116880C File Offset: 0x01166A0C
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.SetupAllActors)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.SetupAllActors));
			}
			if (this.LoadCurveHandleMap != null)
			{
				foreach (KeyValuePair<string, int> keyValuePair in this.LoadCurveHandleMap)
				{
					string text;
					int num;
					keyValuePair.Deconstruct(out text, out num);
					int num2 = num;
					if (num2 != 0)
					{
						ResourceSystem.Instance.CancelAsyncLoad(num2);
					}
				}
			}
			return true;
		}

		// Token: 0x0603CADD RID: 248541 RVA: 0x01168908 File Offset: 0x01166B08
		[NullableContext(1)]
		private unsafe void SetupSingleCurve([Nullable(2)] UCurveFloat asset, string path)
		{
			this.LoadCurveHandleMap.Remove(path);
			if (asset == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SceneItemRotatorComponent] 曲线加载失败，请检查实体配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurvePath", path);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.CurveMap[path] = asset;
			if (this.LoadCurveHandleMap.Count > 0)
			{
				return;
			}
			foreach (KeyValuePair<string, UCurveFloat> keyValuePair in this.CurveMap)
			{
				string text;
				UCurveFloat ucurveFloat;
				keyValuePair.Deconstruct(out text, out ucurveFloat);
				if (ucurveFloat == null)
				{
					return;
				}
			}
			this.IsAllCurvesLoaded = true;
			if (this.IsAllActorsLoaded)
			{
				this.InitRotationData();
			}
		}

		// Token: 0x0603CADE RID: 248542 RVA: 0x01168A20 File Offset: 0x01166C20
		private unsafe void SetupAllActors()
		{
			AActor interactionMainActor = this.ActorComp.GetInteractionMainActor();
			if (interactionMainActor == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SceneItemRotatorComponent] 找不到对应的场景交互物MainActor，请检查实体配置和预制体";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (KeyValuePair<string, AActor> keyValuePair in (this.RotatePointMap ?? new Dictionary<string, AActor>()))
			{
				string text;
				AActor aactor;
				keyValuePair.Deconstruct(out text, out aactor);
				string text2 = text;
				AActor aactor2;
				if (!(text2 == ""))
				{
					SceneItemActorComponent actorComp = this.ActorComp;
					aactor2 = ((actorComp != null) ? actorComp.GetActorInSceneInteraction(text2) : null);
				}
				else
				{
					aactor2 = interactionMainActor;
				}
				AActor aactor3 = aactor2;
				if (aactor3 == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[SceneItemRotatorComponent] 找不到对应的旋转Actor，请检查实体配置和预制体";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorKey", text2);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item2 = "PbDataId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.RotatePointMap[text2] = aactor3;
			}
			if (this.ActorBornRotationMap == null)
			{
				this.ActorBornRotationMap = new Dictionary<string, Rotator>();
				foreach (KeyValuePair<string, AActor> keyValuePair in (this.RotatePointMap ?? new Dictionary<string, AActor>()))
				{
					string text;
					AActor aactor;
					keyValuePair.Deconstruct(out text, out aactor);
					string key = text;
					AActor aactor4 = aactor;
					this.ActorBornRotationMap[key] = Rotator.Create(aactor4.RootComponent.D_GetRelativeTransform().Rotator());
				}
			}
			this.IsAllActorsLoaded = true;
			if (this.IsAllCurvesLoaded)
			{
				this.InitRotationData();
			}
		}

		// Token: 0x0603CADF RID: 248543 RVA: 0x01168C4C File Offset: 0x01166E4C
		private void InitRotationData()
		{
			if (this.IsRotationDataInit)
			{
				return;
			}
			if (!this.IsAllCurvesLoaded || !this.IsAllActorsLoaded)
			{
				return;
			}
			int newStateId = 0;
			foreach (KeyValuePair<int, IStateRotationConfig> keyValuePair in this.StateRotationConfigMap)
			{
				int num;
				IStateRotationConfig stateRotationConfig;
				keyValuePair.Deconstruct(out num, out stateRotationConfig);
				int num2 = num;
				if (this.TagComp.HasTag(num2))
				{
					newStateId = num2;
					break;
				}
			}
			if (!EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			this.IsRotationDataInit = true;
			this.SwitchToState(newStateId, true);
		}

		// Token: 0x0603CAE0 RID: 248544 RVA: 0x01168D28 File Offset: 0x01166F28
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			if (!this.IsRotationDataInit)
			{
				return;
			}
			this.SwitchToState(stateId, false);
		}

		// Token: 0x0603CAE1 RID: 248545 RVA: 0x01168D3C File Offset: 0x01166F3C
		private unsafe void SwitchToState(int newStateId, bool isInit)
		{
			if (!this.IsRotationDataInit)
			{
				return;
			}
			if (!isInit && this.CurStateTagId == newStateId)
			{
				return;
			}
			IStateRotationConfig stateRotationConfig;
			this.StateRotationConfigMap.TryGetValue(this.CurStateTagId, out stateRotationConfig);
			IStateRotationConfig stateRotationConfig2;
			this.StateRotationConfigMap.TryGetValue(newStateId, out stateRotationConfig2);
			if (stateRotationConfig != null && stateRotationConfig.KeepLastRotation.GetValueOrDefault() && stateRotationConfig2 == null && this.UeMoveComp.IsRotating())
			{
				this.PauseRotateStateId = this.CurStateTagId;
				this.CurStateTagId = newStateId;
				this.UeMoveComp.SetTickingRotateEnable(false);
				return;
			}
			if (stateRotationConfig2 != null && stateRotationConfig2.KeepLastRotation.GetValueOrDefault() && newStateId == this.PauseRotateStateId && stateRotationConfig == null && !this.UeMoveComp.IsRotating())
			{
				this.PauseRotateStateId = 0;
				this.CurStateTagId = newStateId;
				this.UeMoveComp.SetTickingRotateEnable(true);
				return;
			}
			bool flag = newStateId != 0 && this.StateRotationConfigMap.ContainsKey(newStateId);
			if (this.UeMoveComp.IsRotating())
			{
				this.UeMoveComp.StopRotate(EKuroSceneItemStopRotateMethod.KeepCurrent, !flag);
			}
			this.CurStateTagId = newStateId;
			if (flag && !this.UeMoveComp.IsRotating())
			{
				IStateRotationConfig stateRotationConfig3 = this.StateRotationConfigMap[newStateId];
				AActor aactor = (!string.IsNullOrEmpty(stateRotationConfig3.RotatePoint)) ? this.RotatePointMap.GetValueOrDefault(stateRotationConfig3.RotatePoint) : this.ActorComp.GetInteractionMainActor();
				if (!this.UeMoveComp.InitRotationData(aactor, stateRotationConfig3.IsLoop))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SceneItemRotatorComponent] 初始化旋转数据失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("StateId", newStateId);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "PbDataId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				Rotator inB = this.ActorBornRotationMap[stateRotationConfig3.RotatePoint ?? ""];
				Rotator inR = Rotator.Create(aactor.RootComponent.D_GetRelativeTransform().Rotator());
				List<IRotationConfig> rotationConfig = stateRotationConfig3.RotationConfig;
				List<IRotationConfig> list = (rotationConfig != null && rotationConfig.Count > 0) ? stateRotationConfig3.RotationConfig : null;
				List<IKeyRotatorConfig> keyRotatorConfig = stateRotationConfig3.KeyRotatorConfig;
				List<IKeyRotatorConfig> list2 = (keyRotatorConfig != null && keyRotatorConfig.Count > 0) ? stateRotationConfig3.KeyRotatorConfig : null;
				int? num = (list != null) ? new int?(list.Count) : ((list2 != null) ? new int?(list2.Count) : null);
				if (num == null)
				{
					return;
				}
				int num2 = 0;
				for (;;)
				{
					int num3 = num2;
					int? num4 = num;
					if (!(num3 < num4.GetValueOrDefault() & num4 != null))
					{
						break;
					}
					ICommonRotationConfig commonRotationConfig = null;
					Rotator rotator = Rotator.Create();
					FRotator frotator;
					if (list != null)
					{
						IRotationConfig rotationConfig2 = list[num2];
						commonRotationConfig = rotationConfig2;
						Vector vector = Vector.Create((double)rotationConfig2.Axis.X.GetValueOrDefault(), (double)rotationConfig2.Axis.Y.GetValueOrDefault(), (double)rotationConfig2.Axis.Z.GetValueOrDefault());
						Rotator rotator2 = rotator;
						frotator = UKismetMathLibrary.D_RotatorFromAxisAndAngle(vector.ToUeVector(false), rotationConfig2.Angle);
						rotator2.FromUeRotator(frotator);
					}
					else if (list2 != null)
					{
						IKeyRotatorConfig keyRotatorConfig2 = list2[num2];
						commonRotationConfig = keyRotatorConfig2;
						rotator.Set(keyRotatorConfig2.KeyRotator.Y.GetValueOrDefault(), keyRotatorConfig2.KeyRotator.Z.GetValueOrDefault(), keyRotatorConfig2.KeyRotator.X.GetValueOrDefault());
					}
					UCurveFloat rotateCurve = (!string.IsNullOrEmpty(commonRotationConfig.Curve)) ? this.CurveMap.GetValueOrDefault(commonRotationConfig.Curve) : null;
					Rotator rotator3 = null;
					Rotator rotator4 = null;
					if (commonRotationConfig.Type == ERotationType.Relative)
					{
						rotator3 = Rotator.Create(inR);
						Rotator inB2 = rotator;
						rotator4 = Rotator.Create(rotator3).AdditionEqual(inB2);
						inR = rotator4;
					}
					else if (commonRotationConfig.Type == ERotationType.Absolute)
					{
						rotator3 = Rotator.Create(inR);
						rotator4 = Rotator.Create(rotator).AdditionEqual(inB);
						inR = rotator4;
					}
					if (rotator3 == null || rotator4 == null)
					{
						goto IL_450;
					}
					UKuroSceneItemMoveComponent ueMoveComp = this.UeMoveComp;
					frotator = rotator3.ToUeRotator();
					FRotator frotator2 = rotator4.ToUeRotator();
					if (!ueMoveComp.AddRotationStep(frotator, frotator2, commonRotationConfig.Time, commonRotationConfig.Cd.GetValueOrDefault(), rotateCurve))
					{
						goto IL_450;
					}
					IL_4EA:
					num2++;
					continue;
					IL_450:
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[SceneItemRotatorComponent] 添加旋转步骤失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("StateId", newStateId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("StepIndex", num2);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
					string item2 = "PbDataId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					goto IL_4EA;
				}
				if (!this.UeMoveComp.StartRotate())
				{
					return;
				}
				this.UeMoveComp.OnRotateStopCallback.Add(new Action(this.OnRotateStop));
			}
		}

		// Token: 0x0603CAE2 RID: 248546 RVA: 0x0116927F File Offset: 0x0116747F
		private void OnRotateStop()
		{
			UKuroSceneItemMoveComponent ueMoveComp = this.UeMoveComp;
			if (ueMoveComp != null)
			{
				ueMoveComp.OnRotateStopCallback.Remove(new Action(this.OnRotateStop));
			}
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnSceneItemRotateStopped);
		}

		// Token: 0x0603CAE3 RID: 248547 RVA: 0x011692BC File Offset: 0x011674BC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemRotatorComponent sceneItemRotatorComponent = (SceneItemRotatorComponent)componentTemplate;
			if (sceneItemRotatorComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.UeTickComp == null)
			{
				this.UeTickComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UeTickComp), "UeTickComp"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.UeMoveComp == null)
			{
				this.UeMoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UeMoveComp), "UeMoveComp"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.StateRotationConfigMap == null)
			{
				this.StateRotationConfigMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateRotationConfigMap), "StateRotationConfigMap"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.CurveMap == null)
			{
				this.CurveMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurveMap), "CurveMap"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.RotatePointMap == null)
			{
				this.RotatePointMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RotatePointMap), "RotatePointMap"))
			{
				return false;
			}
			if (sceneItemRotatorComponent.LoadCurveHandleMap == null)
			{
				this.LoadCurveHandleMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LoadCurveHandleMap), "LoadCurveHandleMap"))
			{
				return false;
			}
			this.IsAllCurvesLoaded = sceneItemRotatorComponent.IsAllCurvesLoaded;
			this.IsAllActorsLoaded = sceneItemRotatorComponent.IsAllActorsLoaded;
			this.IsRotationDataInit = sceneItemRotatorComponent.IsRotationDataInit;
			this.CurStateTagId = sceneItemRotatorComponent.CurStateTagId;
			if (sceneItemRotatorComponent.ActorBornRotationMap == null)
			{
				this.ActorBornRotationMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorBornRotationMap), "ActorBornRotationMap"))
			{
				return false;
			}
			this.PauseRotateStateId = sceneItemRotatorComponent.PauseRotateStateId;
			this.NeedTickOutside = sceneItemRotatorComponent.NeedTickOutside;
			return true;
		}

		// Token: 0x170072C4 RID: 29380
		// (get) Token: 0x0603CAE4 RID: 248548 RVA: 0x011694FD File Offset: 0x011676FD
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C5 RID: 29381
		// (get) Token: 0x0603CAE5 RID: 248549 RVA: 0x01169500 File Offset: 0x01167700
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C6 RID: 29382
		// (get) Token: 0x0603CAE6 RID: 248550 RVA: 0x01169503 File Offset: 0x01167703
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C7 RID: 29383
		// (get) Token: 0x0603CAE7 RID: 248551 RVA: 0x01169506 File Offset: 0x01167706
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C8 RID: 29384
		// (get) Token: 0x0603CAE8 RID: 248552 RVA: 0x01169509 File Offset: 0x01167709
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C9 RID: 29385
		// (get) Token: 0x0603CAE9 RID: 248553 RVA: 0x0116950C File Offset: 0x0116770C
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202B3 RID: 131763
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040202B4 RID: 131764
		private SceneItemActorComponent ActorComp;

		// Token: 0x040202B5 RID: 131765
		private SceneItemStateComponent StateComp;

		// Token: 0x040202B6 RID: 131766
		private LevelTagComponent TagComp;

		// Token: 0x040202B7 RID: 131767
		private UeSceneItemMoveTickManagerComponent UeTickComp;

		// Token: 0x040202B8 RID: 131768
		private UKuroSceneItemMoveComponent UeMoveComp;

		// Token: 0x040202B9 RID: 131769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IStateRotationConfig> StateRotationConfigMap;

		// Token: 0x040202BA RID: 131770
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Dictionary<string, UCurveFloat> CurveMap;

		// Token: 0x040202BB RID: 131771
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Dictionary<string, AActor> RotatePointMap;

		// Token: 0x040202BC RID: 131772
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, int> LoadCurveHandleMap;

		// Token: 0x040202BD RID: 131773
		private bool IsAllCurvesLoaded;

		// Token: 0x040202BE RID: 131774
		private bool IsAllActorsLoaded;

		// Token: 0x040202BF RID: 131775
		private bool IsRotationDataInit;

		// Token: 0x040202C0 RID: 131776
		private int CurStateTagId;

		// Token: 0x040202C1 RID: 131777
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, Rotator> ActorBornRotationMap;

		// Token: 0x040202C2 RID: 131778
		private int PauseRotateStateId;

		// Token: 0x040202C3 RID: 131779
		private bool NeedTickOutside;
	}
}
