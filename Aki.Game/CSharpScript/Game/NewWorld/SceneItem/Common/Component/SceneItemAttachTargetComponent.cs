using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062CB RID: 25291
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemAttachTargetComponent : EntityComponent
	{
		// Token: 0x1700739D RID: 29597
		// (get) Token: 0x0603D11C RID: 250140 RVA: 0x01192649 File Offset: 0x01190849
		[Nullable(1)]
		public override Type[] Dependencies
		{
			[NullableContext(1)]
			get
			{
				return new Type[]
				{
					typeof(SceneItemActorComponent),
					typeof(CreatureDataComponent)
				};
			}
		}

		// Token: 0x0603D11D RID: 250141 RVA: 0x0119266C File Offset: 0x0119086C
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData createEntityData = (args != null) ? args.GetP1<CreateEntityData>() : null;
			object obj = (createEntityData != null) ? createEntityData.GetParam<SceneItemAttachTargetComponent>() : null;
			this.Config = (obj as AttachTargetComponent);
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (!this.IsSpecialRuleSwordRailAttachRule())
			{
				AttachTargetComponent config = this.Config;
				if (((config != null) ? config.AttachTarget : null) == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.YZH;
					string message = "[SceneItemAttachTargetComponent]附加目标配置无效，请联系对应策划检查配置";
					string item = "PbDataId:";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return true;
				}
			}
			this.AttachParam = new SceneItemDynamicAttachTargetComponent.AttachParam();
			EAttachRuleType? eattachRuleType = this.Config.PosRule;
			if (eattachRuleType != null)
			{
				switch (eattachRuleType.GetValueOrDefault())
				{
				case EAttachRuleType.Absolute:
					this.AttachParam.PosAbsolute = true;
					this.AttachParam.PosAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.CalcUseCurrentRelation;
					goto IL_128;
				case EAttachRuleType.AlignTarget:
					this.AttachParam.PosAbsolute = false;
					this.AttachParam.PosAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.UseZeroRelativeTransform;
					goto IL_128;
				}
			}
			this.AttachParam.PosAbsolute = false;
			this.AttachParam.PosAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.CalcUseInitialRelation;
			IL_128:
			eattachRuleType = this.Config.RotRule;
			if (eattachRuleType != null)
			{
				switch (eattachRuleType.GetValueOrDefault())
				{
				case EAttachRuleType.Absolute:
					this.AttachParam.RotAbsolute = true;
					this.AttachParam.RotAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.CalcUseCurrentRelation;
					goto IL_1A8;
				case EAttachRuleType.AlignTarget:
					this.AttachParam.RotAbsolute = false;
					this.AttachParam.RotAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.UseZeroRelativeTransform;
					goto IL_1A8;
				}
			}
			this.AttachParam.RotAbsolute = false;
			this.AttachParam.RotAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.CalcUseInitialRelation;
			IL_1A8:
			IAttachTarget attachTarget = this.Config.AttachTarget;
			EAttachType? eattachType = (attachTarget != null) ? new EAttachType?(attachTarget.Type) : null;
			if (eattachType != null)
			{
				EAttachType valueOrDefault = eattachType.GetValueOrDefault();
				if (valueOrDefault != EAttachType.Actor)
				{
					if (valueOrDefault == EAttachType.Entity)
					{
						IEntityAttachTarget entityAttachTarget = this.Config.AttachTarget as IEntityAttachTarget;
						this.TargetPbDataId = new int?(entityAttachTarget.EntityId);
						this.TargetAttachPoint = entityAttachTarget.AttachPoint;
						if (entityAttachTarget.PosOffset != null)
						{
							this.AttachParam.PosAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.UseZeroRelativeTransform;
							this.AttachParam.PosAttachOffset = Vector.Create((double)entityAttachTarget.PosOffset.X.GetValueOrDefault(), (double)entityAttachTarget.PosOffset.Y.GetValueOrDefault(), (double)entityAttachTarget.PosOffset.Z.GetValueOrDefault());
						}
					}
				}
				else
				{
					string[] array = (this.Config.AttachTarget as IActorAttachTarget).ActorRef.PathName.Split('.', StringSplitOptions.None);
					if (array.Length < 3)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.SceneItem;
						ELogAuthor author2 = ELogAuthor.ZYL;
						string message2 = "[SceneItemAttachTargetComponent] Invalid ActorRefConfig";
						string item2 = "PbDataId:";
						CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return false;
					}
					this.TargetActorRef = array[1] + "." + array[2];
				}
			}
			return true;
		}

		// Token: 0x0603D11E RID: 250142 RVA: 0x0119299C File Offset: 0x01190B9C
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[SceneItemAttachTargetComponent] Invalid ActorComp";
				string item = "PbDataId:";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (this.IsOnMoveWithSplineEndAttachTiming())
			{
				this.MoveComp = base.Entity.GetComponent<SceneItemMoveComponent>();
				if (this.MoveComp == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.YZH;
					string message2 = "[SceneItemAttachTargetComponent] Invalid MoveComp";
					string item2 = "PbDataId:";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return false;
				}
			}
			if (this.IsSpecialRuleSwordRailAttachRule())
			{
				return true;
			}
			this.DynamicAttachComp = base.Entity.GetComponent<SceneItemDynamicAttachTargetComponent>();
			if (this.DynamicAttachComp == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.YZH;
				string message3 = "[SceneItemAttachTargetComponent] Invalid DynamicAttachComp";
				string item3 = "PbDataId:";
				CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			return true;
		}

		// Token: 0x0603D11F RID: 250143 RVA: 0x01192AE8 File Offset: 0x01190CE8
		protected override void OnActivate()
		{
			if (this.IsOnMoveWithSplineEndAttachTiming())
			{
				this.RegisterSplineMoveEndEvents();
				return;
			}
			this.HandleAttachByRule();
		}

		// Token: 0x0603D120 RID: 250144 RVA: 0x01192AFF File Offset: 0x01190CFF
		protected override bool OnEnd()
		{
			if (this.IsSpecialRuleSwordRailAttached)
			{
				this.DetachBySpecialRuleSwordRail();
			}
			else if (this.DynamicAttachComp != null)
			{
				this.HandleTargetDetach();
			}
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			return true;
		}

		// Token: 0x0603D121 RID: 250145 RVA: 0x01192B2C File Offset: 0x01190D2C
		private bool IsOnMoveWithSplineEndAttachTiming()
		{
			AttachTargetComponent config = this.Config;
			if (config == null)
			{
				return false;
			}
			IAttachTiming attachTiming = config.AttachTiming;
			return ((attachTiming != null) ? new EAttachTimingType?(attachTiming.Type) : null).GetValueOrDefault() == EAttachTimingType.OnMoveWithSplineEnd;
		}

		// Token: 0x0603D122 RID: 250146 RVA: 0x01192B70 File Offset: 0x01190D70
		private bool IsSpecialRuleSwordRailAttachRule()
		{
			AttachTargetComponent config = this.Config;
			if (config == null || config.PosRule.GetValueOrDefault() != EAttachRuleType.SpecialRuleSwordRail)
			{
				AttachTargetComponent config2 = this.Config;
				return config2 != null && config2.RotRule.GetValueOrDefault() == EAttachRuleType.SpecialRuleSwordRail;
			}
			return true;
		}

		// Token: 0x0603D123 RID: 250147 RVA: 0x01192BBA File Offset: 0x01190DBA
		private IOnMoveWithSplineEndAttachTiming GetOnMoveWithSplineEndAttachTiming()
		{
			if (!this.IsOnMoveWithSplineEndAttachTiming())
			{
				return null;
			}
			AttachTargetComponent config = this.Config;
			return ((config != null) ? config.AttachTiming : null) as IOnMoveWithSplineEndAttachTiming;
		}

		// Token: 0x0603D124 RID: 250148 RVA: 0x01192BE0 File Offset: 0x01190DE0
		private unsafe void RegisterSplineMoveEndEvents()
		{
			IOnMoveWithSplineEndAttachTiming onMoveWithSplineEndAttachTiming = this.GetOnMoveWithSplineEndAttachTiming();
			bool flag = (((onMoveWithSplineEndAttachTiming != null) ? new int?(onMoveWithSplineEndAttachTiming.SplineEntityId) : null) ?? 0) == 0;
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[SceneItemAttachTargetComponent] OnMoveWithSplineEnd AttachTiming SplineEntityId invalid";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId:";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineEntityId", (onMoveWithSplineEndAttachTiming != null) ? new int?(onMoveWithSplineEndAttachTiming.SplineEntityId) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.UpdateLastSplineMoveTaskId();
			if (!EventSystem.Instance.HasWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveStarted, new Action<Entity>(this.OnSceneItemSplineMoveStarted)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey<Entity>(this, base.Entity, EEventName.OnSceneItemSplineMoveStarted, new Action<Entity>(this.OnSceneItemSplineMoveStarted));
			}
			if (!EventSystem.Instance.HasWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveBroken, new Action<Entity>(this.OnSceneItemSplineMoveBroken)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey<Entity>(this, base.Entity, EEventName.OnSceneItemSplineMoveBroken, new Action<Entity>(this.OnSceneItemSplineMoveBroken));
			}
			if (!EventSystem.Instance.HasWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveStopped, new Action<Entity>(this.OnSceneItemSplineMoveStopped)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey<Entity>(this, base.Entity, EEventName.OnSceneItemSplineMoveStopped, new Action<Entity>(this.OnSceneItemSplineMoveStopped));
			}
		}

		// Token: 0x0603D125 RID: 250149 RVA: 0x01192D98 File Offset: 0x01190F98
		[NullableContext(1)]
		private void OnSceneItemSplineMoveStarted(Entity _)
		{
			this.UpdateLastSplineMoveTaskId();
		}

		// Token: 0x0603D126 RID: 250150 RVA: 0x01192DA0 File Offset: 0x01190FA0
		[NullableContext(1)]
		private void OnSceneItemSplineMoveBroken(Entity _)
		{
			this.UpdateLastSplineMoveTaskId();
			this.IsSplineMoveBroken = true;
		}

		// Token: 0x0603D127 RID: 250151 RVA: 0x01192DB0 File Offset: 0x01190FB0
		[NullableContext(1)]
		private void OnSceneItemSplineMoveStopped(Entity _)
		{
			this.UpdateLastSplineMoveTaskId();
			bool isSplineMoveBroken = this.IsSplineMoveBroken;
			this.IsSplineMoveBroken = false;
			if (isSplineMoveBroken || this.IsSpecialRuleSwordRailAttached)
			{
				return;
			}
			IOnMoveWithSplineEndAttachTiming onMoveWithSplineEndAttachTiming = this.GetOnMoveWithSplineEndAttachTiming();
			bool flag = (((onMoveWithSplineEndAttachTiming != null) ? new int?(onMoveWithSplineEndAttachTiming.SplineEntityId) : null) ?? 0) == 0;
			if (flag)
			{
				return;
			}
			int? lastSplineMoveTaskId = this.LastSplineMoveTaskId;
			int splineEntityId = onMoveWithSplineEndAttachTiming.SplineEntityId;
			if (!(lastSplineMoveTaskId.GetValueOrDefault() == splineEntityId & lastSplineMoveTaskId != null))
			{
				return;
			}
			this.HandleAttachByRule();
		}

		// Token: 0x0603D128 RID: 250152 RVA: 0x01192E44 File Offset: 0x01191044
		private void UpdateLastSplineMoveTaskId()
		{
			SceneItemMoveComponent moveComp = this.MoveComp;
			SceneItemSplineMoveTask sceneItemSplineMoveTask = (moveComp != null) ? moveComp.GetCurSplineMoveTask() : null;
			if (sceneItemSplineMoveTask != null)
			{
				this.LastSplineMoveTaskId = new int?(sceneItemSplineMoveTask.SplineEntityId);
			}
		}

		// Token: 0x0603D129 RID: 250153 RVA: 0x01192E78 File Offset: 0x01191078
		private void AttachBySpecialRuleSwordRail()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			AActor aactor = (actorComp != null) ? actorComp.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[SceneItemAttachTargetComponent] SceneItemActor invalid";
				string item = "PbDataId:";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			AActor aactor2;
			if (getCurrentEntity == null)
			{
				aactor2 = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				if (entity == null)
				{
					aactor2 = null;
				}
				else
				{
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					aactor2 = ((component != null) ? component.Owner : null);
				}
			}
			AActor aactor3 = aactor2;
			if (aactor3 == null || !aactor3.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "[SceneItemAttachTargetComponent] SpecialRuleSwordRail target actor invalid";
				string item2 = "PbDataId:";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.IsSpecialRuleSwordRailAttached = AttachToActorController.Instance.AttachToActor(aactor, aactor3, EDetachType.DestroyExternal, "SceneItemAttachTargetComponent.AttachBySpecialRuleSwordRail", null, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true, false, true, false);
		}

		// Token: 0x0603D12A RID: 250154 RVA: 0x01192FA9 File Offset: 0x011911A9
		private void HandleAttachByRule()
		{
			if (this.IsSpecialRuleSwordRailAttachRule())
			{
				this.AttachBySpecialRuleSwordRail();
				return;
			}
			this.HandleTargetAttach();
		}

		// Token: 0x0603D12B RID: 250155 RVA: 0x01192FC0 File Offset: 0x011911C0
		private void DetachBySpecialRuleSwordRail()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			AActor aactor = (actorComp != null) ? actorComp.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				return;
			}
			if (AttachToActorController.Instance.DetachActor(aactor, false, "SceneItemAttachTargetComponent.DetachBySpecialRuleSwordRail", EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld))
			{
				this.IsSpecialRuleSwordRailAttached = false;
			}
		}

		// Token: 0x0603D12C RID: 250156 RVA: 0x01193010 File Offset: 0x01191210
		private void HandleTargetAttach()
		{
			AttachTargetComponent config = this.Config;
			EAttachType? eattachType;
			if (config == null)
			{
				eattachType = null;
			}
			else
			{
				IAttachTarget attachTarget = config.AttachTarget;
				eattachType = ((attachTarget != null) ? new EAttachType?(attachTarget.Type) : null);
			}
			EAttachType? eattachType2 = eattachType;
			if (eattachType2 != null)
			{
				EAttachType valueOrDefault = eattachType2.GetValueOrDefault();
				if (valueOrDefault != EAttachType.Actor)
				{
					if (valueOrDefault == EAttachType.Entity)
					{
						this.DynamicAttachComp.RegEntityTarget(this.TargetPbDataId.Value, this.TargetAttachPoint, this.AttachParam, "[SceneItemAttachTargetComponent] HandleTargetAttach");
						return;
					}
				}
				else
				{
					this.DynamicAttachComp.RegRefActorTarget(this.TargetActorRef, this.AttachParam, "[SceneItemAttachTargetComponent] HandleTargetAttach");
				}
			}
		}

		// Token: 0x0603D12D RID: 250157 RVA: 0x011930B0 File Offset: 0x011912B0
		private void HandleTargetDetach()
		{
			AttachTargetComponent config = this.Config;
			EAttachType? eattachType;
			if (config == null)
			{
				eattachType = null;
			}
			else
			{
				IAttachTarget attachTarget = config.AttachTarget;
				eattachType = ((attachTarget != null) ? new EAttachType?(attachTarget.Type) : null);
			}
			EAttachType? eattachType2 = eattachType;
			if (eattachType2 != null)
			{
				EAttachType valueOrDefault = eattachType2.GetValueOrDefault();
				if (valueOrDefault <= EAttachType.Entity)
				{
					this.DynamicAttachComp.UnRegTarget("[SceneItemAttachTargetComponent] HandleTargetDetach");
				}
			}
		}

		// Token: 0x0603D12E RID: 250158 RVA: 0x01193118 File Offset: 0x01191318
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemAttachTargetComponent sceneItemAttachTargetComponent = (SceneItemAttachTargetComponent)componentTemplate;
			if (sceneItemAttachTargetComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemAttachTargetComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			this.TargetPbDataId = sceneItemAttachTargetComponent.TargetPbDataId;
			this.TargetAttachPoint = sceneItemAttachTargetComponent.TargetAttachPoint;
			this.TargetActorRef = sceneItemAttachTargetComponent.TargetActorRef;
			if (sceneItemAttachTargetComponent.AttachParam == null)
			{
				this.AttachParam = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttachParam), "AttachParam"))
			{
				return false;
			}
			if (sceneItemAttachTargetComponent.DynamicAttachComp == null)
			{
				this.DynamicAttachComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DynamicAttachComp), "DynamicAttachComp"))
			{
				return false;
			}
			if (sceneItemAttachTargetComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemAttachTargetComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			this.IsSplineMoveBroken = sceneItemAttachTargetComponent.IsSplineMoveBroken;
			this.IsSpecialRuleSwordRailAttached = sceneItemAttachTargetComponent.IsSpecialRuleSwordRailAttached;
			this.LastSplineMoveTaskId = sceneItemAttachTargetComponent.LastSplineMoveTaskId;
			return true;
		}

		// Token: 0x1700739E RID: 29598
		// (get) Token: 0x0603D12F RID: 250159 RVA: 0x01193282 File Offset: 0x01191482
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700739F RID: 29599
		// (get) Token: 0x0603D130 RID: 250160 RVA: 0x01193285 File Offset: 0x01191485
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073A0 RID: 29600
		// (get) Token: 0x0603D131 RID: 250161 RVA: 0x01193288 File Offset: 0x01191488
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402064F RID: 132687
		private AttachTargetComponent Config;

		// Token: 0x04020650 RID: 132688
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04020651 RID: 132689
		private int? TargetPbDataId;

		// Token: 0x04020652 RID: 132690
		private string TargetAttachPoint;

		// Token: 0x04020653 RID: 132691
		private string TargetActorRef;

		// Token: 0x04020654 RID: 132692
		private SceneItemDynamicAttachTargetComponent.AttachParam AttachParam;

		// Token: 0x04020655 RID: 132693
		private SceneItemDynamicAttachTargetComponent DynamicAttachComp;

		// Token: 0x04020656 RID: 132694
		private SceneItemActorComponent ActorComp;

		// Token: 0x04020657 RID: 132695
		private SceneItemMoveComponent MoveComp;

		// Token: 0x04020658 RID: 132696
		private bool IsSplineMoveBroken;

		// Token: 0x04020659 RID: 132697
		private bool IsSpecialRuleSwordRailAttached;

		// Token: 0x0402065A RID: 132698
		private int? LastSplineMoveTaskId;
	}
}
