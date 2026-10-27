using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007119 RID: 28953
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterExploreComponent : BaseExploreComponent
	{
		// Token: 0x17009D1F RID: 40223
		// (get) Token: 0x06046B03 RID: 289539 RVA: 0x011CC9E5 File Offset: 0x011CABE5
		// (set) Token: 0x06046B04 RID: 289540 RVA: 0x011CC9ED File Offset: 0x011CABED
		public bool NeedChangeTargetState
		{
			get
			{
				return this.NeedChangeTargetStateInternal;
			}
			set
			{
				this.NeedChangeTargetStateInternal = value;
				if (value && base.FocusTarget != null)
				{
					base.FocusTarget.ChangeHookPointState(this.FocusTargetLegalExceptSkill ? EHookPointState.Interactive : EHookPointState.NonInteractive);
				}
			}
		}

		// Token: 0x06046B05 RID: 289541 RVA: 0x011CCA18 File Offset: 0x011CAC18
		protected override bool OnStart()
		{
			this.LogKey = "(角色)探索组件";
			base.OnStart();
			if (this.CheckDisableComponent())
			{
				return true;
			}
			this.ManipulateComponent = base.Entity.GetComponent<CharacterManipulateComponent>();
			this.ManipulateInteractComponent = base.Entity.GetComponent<CharacterManipulateInteractComponent>();
			this.SceneInteractComponent = base.Entity.GetComponent<RoleSceneInteractComponent>();
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
			return true;
		}

		// Token: 0x06046B06 RID: 289542 RVA: 0x011CCAD8 File Offset: 0x011CACD8
		protected override bool OnEnd()
		{
			base.OnEnd();
			if (this.CheckDisableComponent())
			{
				return true;
			}
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
			this.OnExploreComponentDisable("OnEnd");
			return true;
		}

		// Token: 0x06046B07 RID: 289543 RVA: 0x011CCB63 File Offset: 0x011CAD63
		protected override bool CheckDisableComponent()
		{
			BaseActorComponent actorComponent = this.ActorComponent;
			return actorComponent == null || !actorComponent.IsRoleAndCtrlByMe;
		}

		// Token: 0x06046B08 RID: 289544 RVA: 0x011CCB7C File Offset: 0x011CAD7C
		protected override bool OnExploreComponentEnable(string reason)
		{
			if (!base.OnExploreComponentEnable(reason))
			{
				return false;
			}
			this.Manipulating = false;
			EventSystem.Instance.Add(EEventName.OnChangeSelectedExploreId, new Action(this.OnExploreVisionSkillChange));
			EventSystem.Instance.Add<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnManipulateFound));
			return true;
		}

		// Token: 0x06046B09 RID: 289545 RVA: 0x011CCBD4 File Offset: 0x011CADD4
		protected override bool OnExploreComponentDisable(string reason)
		{
			if (!base.OnExploreComponentDisable(reason))
			{
				return false;
			}
			EventSystem.Instance.Remove(EEventName.OnChangeSelectedExploreId, new Action(this.OnExploreVisionSkillChange));
			EventSystem.Instance.Remove<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnManipulateFound));
			return true;
		}

		// Token: 0x06046B0A RID: 289546 RVA: 0x011CCC25 File Offset: 0x011CAE25
		protected override void OnTick(float delta)
		{
			this.CheckTick();
		}

		// Token: 0x06046B0B RID: 289547 RVA: 0x011CCC2D File Offset: 0x011CAE2D
		private void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsDriver || info.PassengerEntity != base.Entity)
			{
				return;
			}
			this.IsInVehicle = true;
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			if (highlightLogic != null)
			{
				highlightLogic.HideHighlightExploreSkill();
			}
			this.OnExploreComponentDisable("主控角色进入载具");
		}

		// Token: 0x06046B0C RID: 289548 RVA: 0x011CCC6A File Offset: 0x011CAE6A
		private void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsDriver || info.PassengerEntity != base.Entity)
			{
				return;
			}
			this.IsInVehicle = false;
			this.OnExploreComponentEnable("主控角色离开载具");
		}

		// Token: 0x06046B0D RID: 289549 RVA: 0x011CCC98 File Offset: 0x011CAE98
		private void CheckTick()
		{
			CharacterManipulateComponent manipulateComponent = this.ManipulateComponent;
			bool flag;
			if (((manipulateComponent != null) ? manipulateComponent.CurSelectedEntity : null) == null)
			{
				CharacterManipulateInteractComponent manipulateInteractComponent = this.ManipulateInteractComponent;
				flag = (((manipulateInteractComponent != null) ? manipulateInteractComponent.GetCurrentTarget : null) != null);
			}
			else
			{
				flag = true;
			}
			if (!flag && this.ManipulateFound)
			{
				this.ManipulateFound = false;
				this.ManipulateActorComp = null;
				this.CurManipulateEntityId = 0;
				this.LastManipulateEntityId = 0;
			}
			GrapplingHookPointComponent focusTarget = base.FocusTarget;
			if ((focusTarget == null || !focusTarget.Valid) && this.HookFound)
			{
				this.HookFound = false;
				this.CurHookEntityId = 0;
				this.LastHookEntityId = 0;
			}
			if (this.HookFound || this.ManipulateFound)
			{
				if (this.HookFound != this.ManipulateFound)
				{
					this.CheckSimpleTrue();
					return;
				}
				this.CheckBothTrue();
			}
		}

		// Token: 0x06046B0E RID: 289550 RVA: 0x011CCD58 File Offset: 0x011CAF58
		private void CheckSimpleTrue()
		{
			if (this.HookFound && this.CurHookEntityId != this.LastHookEntityId && this.FocusTargetLegalExceptSkill)
			{
				this.TryChangeSkill(CharacterExploreComponent.ESkillType.Hook);
				this.NeedChangeTargetState = true;
				return;
			}
			if (this.ManipulateFound && this.CurManipulateEntityId != this.LastManipulateEntityId)
			{
				this.TryChangeSkill(CharacterExploreComponent.ESkillType.Manipulate);
				this.NeedChangeTargetState = false;
			}
		}

		// Token: 0x06046B0F RID: 289551 RVA: 0x011CCDB8 File Offset: 0x011CAFB8
		private void CheckBothTrue()
		{
			if (this.Manipulating)
			{
				this.TryChangeSkill(CharacterExploreComponent.ESkillType.Manipulate);
				return;
			}
			Vector actorLocationProxy = this.ActorComponent.ActorLocationProxy;
			Vector hookLocation = base.FocusTarget.HookLocation;
			Vector actorLocationProxy2 = this.ManipulateActorComp.ActorLocationProxy;
			double num = Vector.DistSquared(actorLocationProxy, hookLocation);
			double num2 = Vector.DistSquared(actorLocationProxy, actorLocationProxy2);
			if (Math.Abs(num - num2) < 1.1754943508222875E-38 || num > num2)
			{
				if (this.CurManipulateEntityId != this.LastManipulateEntityId)
				{
					this.TryChangeSkill(CharacterExploreComponent.ESkillType.Manipulate);
				}
				this.NeedChangeTargetState = false;
				return;
			}
			if (this.CurHookEntityId != this.LastHookEntityId && this.FocusTargetLegalExceptSkill)
			{
				this.TryChangeSkill(CharacterExploreComponent.ESkillType.Hook);
			}
			this.NeedChangeTargetState = true;
		}

		// Token: 0x06046B10 RID: 289552 RVA: 0x011CCE5F File Offset: 0x011CB05F
		public void SendHookMovePushProxy()
		{
			base.SendHookMovePush();
		}

		// Token: 0x06046B11 RID: 289553 RVA: 0x011CCE67 File Offset: 0x011CB067
		[NullableContext(2)]
		public void SendHookTargetRequestProxy(GrapplingHookPointComponent target, [Nullable(1)] Action onFailure, string compositeSessionName = null)
		{
			base.SendHookTargetRequest(target, onFailure, compositeSessionName);
		}

		// Token: 0x06046B12 RID: 289554 RVA: 0x011CCE72 File Offset: 0x011CB072
		[NullableContext(2)]
		public void SendHookEndRequestProxy(GrapplingHookPointComponent target, string compositeSessionName = null)
		{
			base.SendHookEndRequest(target, compositeSessionName);
		}

		// Token: 0x06046B13 RID: 289555 RVA: 0x011CCE7C File Offset: 0x011CB07C
		public void SetDataFromOldRole(EntityHandle oldEntity)
		{
			CharacterExploreComponent component = oldEntity.Entity.GetComponent<CharacterExploreComponent>();
			this.IsInVehicle = component.IsInVehicle;
			if (component.IsLockingTarget)
			{
				base.ForceLockTarget(component.FocusTarget, "上场角色继承下场角色锁定目标");
			}
			else
			{
				base.FocusTarget = component.FocusTarget;
				base.FocusTargetLegal = component.FocusTargetLegal;
			}
			this.PendingHighlightSkill = component.PendingHighlightSkill;
			if (component.HighlightLogic != null)
			{
				this.HighlightLogic = component.HighlightLogic;
				component.HighlightLogic = null;
				HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
				if (highlightLogic != null)
				{
					highlightLogic.Init(this);
				}
			}
			else
			{
				base.InitHighlightHandle();
			}
			if (component.CurrentIconTagId != null)
			{
				int? num = component.CurrentIconTagId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					base.UpdateHookIconTag(true, component.CurrentIconTagId, "上场角色继承下场角色Tag");
				}
			}
			if (component.CurrentIconHighlightTagId != null)
			{
				int? num = component.CurrentIconHighlightTagId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					base.UpdateHookIconHighlightTag(true, component.CurrentIconHighlightTagId);
				}
			}
		}

		// Token: 0x06046B14 RID: 289556 RVA: 0x011CCF8C File Offset: 0x011CB18C
		[NullableContext(2)]
		protected override void OnDetectedTargetChanged(GrapplingHookPointComponent prevTarget)
		{
			if (prevTarget != null && prevTarget.Valid && prevTarget != base.FocusTarget)
			{
				prevTarget.ChangeHookPointState(EHookPointState.Normal);
			}
			GrapplingHookPointComponent focusTarget = base.FocusTarget;
			if (focusTarget != null && focusTarget.Valid && this.NeedChangeTargetState)
			{
				base.FocusTarget.ChangeHookPointState(this.FocusTargetLegalExceptSkill ? EHookPointState.Interactive : EHookPointState.NonInteractive);
			}
			this.OnHookPointFound();
			if (base.FocusTarget != null && this.FocusTargetLegalExceptSkill)
			{
				if (RouletteModel.Instance.CurrentExploreSkillId != 1001)
				{
					this.NeedAddTag = true;
				}
				else if (base.FocusTargetLegal)
				{
					base.UpdateHookIconTag(true, base.FocusTarget.GetTagId(), "(角色)当前选中的钩锁点有效");
					base.UpdateHookIconHighlightTag(true, new int?(base.FocusTarget.GetHighlightTagId()));
				}
				else
				{
					if (CharacterExploreModel.Instance.AutoResetSkillFinished)
					{
						base.UpdateHookIconTag(false, null, "(角色)当前选中的钩锁点无效，且不需要等待切换技能");
					}
					base.UpdateHookIconHighlightTag(false, null);
				}
			}
			else
			{
				this.NeedAddTag = false;
				if (CharacterExploreModel.Instance.AutoResetSkillFinished)
				{
					base.UpdateHookIconTag(false, null, "(角色)当前未选中点，且不需要等待切换技能");
				}
				base.UpdateHookIconHighlightTag(false, null);
			}
			this.SceneInteractComponent.OnDetectedTargetChanged();
		}

		// Token: 0x06046B15 RID: 289557 RVA: 0x011CD0D0 File Offset: 0x011CB2D0
		private void OnChangeRoleCompleted(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			if (this.IsInVehicle)
			{
				return;
			}
			if (oldEntity == newEntity)
			{
				return;
			}
			int? num = (oldEntity != null) ? new int?(oldEntity.Id) : null;
			int id = base.Entity.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				this.OnExploreComponentDisable("OnRoleGoDown");
				return;
			}
			if (newEntity.Id == base.Entity.Id)
			{
				this.OnExploreComponentEnable("OnRoleGoUp");
			}
		}

		// Token: 0x06046B16 RID: 289558 RVA: 0x011CD154 File Offset: 0x011CB354
		private void OnExploreVisionSkillChange()
		{
			this.HookFound = false;
			this.ManipulateFound = false;
			if (RouletteModel.Instance.CurrentExploreSkillId == 1001)
			{
				if (this.NeedAddTag)
				{
					bool add = true;
					GrapplingHookPointComponent focusTarget = base.FocusTarget;
					base.UpdateHookIconTag(add, (focusTarget != null) ? focusTarget.GetTagId() : null, "切换到钩锁技能且NeedAddTag为真时, 添加定点钩索可用标签");
					bool add2 = true;
					GrapplingHookPointComponent focusTarget2 = base.FocusTarget;
					base.UpdateHookIconHighlightTag(add2, (focusTarget2 != null) ? new int?(focusTarget2.GetHighlightTagId()) : null);
				}
				return;
			}
			List<int> onSettingExploreSkillIdList = RouletteModel.Instance.OnSettingExploreSkillIdList;
			if (onSettingExploreSkillIdList.Count > 0)
			{
				List<int> list = onSettingExploreSkillIdList;
				if (list[list.Count - 1] == 1001)
				{
					return;
				}
			}
			base.UpdateHookIconTag(false, null, "切换到非钩锁技能时，删除定点钩索可用标签");
			base.UpdateHookIconHighlightTag(false, null);
			if (base.FocusTarget != null)
			{
				base.FocusTarget.ChangeHookPointState(EHookPointState.Normal);
				base.FocusTarget = null;
			}
		}

		// Token: 0x06046B17 RID: 289559 RVA: 0x011CD240 File Offset: 0x011CB440
		private void OnHookPointFound()
		{
			if (base.FocusTarget == null || !this.FocusTargetLegalExceptSkill)
			{
				this.HookFound = false;
				this.CurHookEntityId = 0;
				this.LastHookEntityId = 0;
				this.CheckExit(CharacterExploreComponent.ESkillType.Hook);
				return;
			}
			if (this.CurHookEntityId == base.FocusTarget.Entity.Id)
			{
				return;
			}
			this.CurHookEntityId = base.FocusTarget.Entity.Id;
			this.HookFound = true;
		}

		// Token: 0x06046B18 RID: 289560 RVA: 0x011CD2B0 File Offset: 0x011CB4B0
		[NullableContext(2)]
		private void OnManipulateFound(bool find, Entity entity, bool isCastTarget)
		{
			this.Manipulating = isCastTarget;
			if (isCastTarget)
			{
				return;
			}
			if (!find)
			{
				this.ManipulateFound = false;
				this.ManipulateActorComp = null;
				this.CurManipulateEntityId = 0;
				this.LastManipulateEntityId = 0;
				this.CheckExit(CharacterExploreComponent.ESkillType.Manipulate);
				return;
			}
			this.ManipulateFound = true;
			this.ManipulateActorComp = entity.GetComponent<BaseActorComponent>();
			this.CurManipulateEntityId = entity.Id;
		}

		// Token: 0x06046B19 RID: 289561 RVA: 0x011CD310 File Offset: 0x011CB510
		private unsafe void OnCharSkillEnd(int entityId, int skillId)
		{
			CharacterExploreModel exploreModel = CharacterExploreModel.Instance;
			if (this.ListenSkillIdMap.Contains((long)skillId))
			{
				if (base.FocusTarget != null && this.FocusTargetLegalExceptSkill)
				{
					this.TryChangeSkill(CharacterExploreComponent.ESkillType.Hook);
				}
				else if (this.ManipulateFound)
				{
					this.TryChangeSkill(CharacterExploreComponent.ESkillType.Manipulate);
				}
				else
				{
					exploreModel.ResetExplodeSkillId(EExploreSkillLayer.Auto, "OnCharSkillEnd");
					int topLayerExplodeSkillId = exploreModel.GetTopLayerExplodeSkillId();
					RouletteController.Instance.ExploreSkillSetRequest(topLayerExplodeSkillId, delegate(bool _)
					{
						exploreModel.AutoResetSkillFinished = true;
						if (this.FocusTarget == null || !this.FocusTargetLegalExceptSkill)
						{
							this.UpdateHookIconTag(false, null, "(角色)钩锁技能结束且当前选中钩锁点无效, 删除定点钩索可用标签");
						}
					}, true);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[CharacterExploreComponent] OnCharSkillEnd";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EndSkillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FocusTarget", base.FocusTarget);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FocusTargetLegalExceptSkill", this.FocusTargetLegalExceptSkill);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ManipulateFound", this.ManipulateFound);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("OldSkill", RouletteModel.Instance.CurrentExploreSkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("TopLayerSkillId", exploreModel.GetTopLayerExplodeSkillId());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				this.NeedChangeTargetState = true;
				EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
			}
		}

		// Token: 0x06046B1A RID: 289562 RVA: 0x011CD4BC File Offset: 0x011CB6BC
		private unsafe void TryChangeSkill(CharacterExploreComponent.ESkillType type)
		{
			int num = 0;
			if (type != CharacterExploreComponent.ESkillType.Hook)
			{
				if (type == CharacterExploreComponent.ESkillType.Manipulate)
				{
					num = 1003;
					this.LastManipulateEntityId = this.CurManipulateEntityId;
				}
			}
			else
			{
				num = 1001;
				this.LastHookEntityId = this.CurHookEntityId;
			}
			if (this.CheckHasSkill(num))
			{
				CharacterExploreModel instance = CharacterExploreModel.Instance;
				if (instance.CheckNeedChangeSkill(num, EExploreSkillLayer.Auto))
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CK;
					string message = "[CharacterExploreComponent] TryChangeSkill";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OldSkill", RouletteModel.Instance.CurrentExploreSkillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewSkill", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Id", base.Entity.Id);
					instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					RouletteController.Instance.ExploreSkillSetRequest(num, null, true);
					instance.AutoResetSkillFinished = false;
				}
				instance.SetExploreSkillId(num, EExploreSkillLayer.Auto, "角色探索组件自动切换技能");
			}
		}

		// Token: 0x06046B1B RID: 289563 RVA: 0x011CD5C8 File Offset: 0x011CB7C8
		private unsafe void CheckExit(CharacterExploreComponent.ESkillType type)
		{
			if (this.HookFound)
			{
				this.TryChangeSkill(CharacterExploreComponent.ESkillType.Hook);
				this.NeedChangeTargetState = true;
				return;
			}
			if (this.ManipulateFound)
			{
				return;
			}
			CharacterExploreModel exploreModel = CharacterExploreModel.Instance;
			if (!exploreModel.ExistAutoLayerSkill())
			{
				exploreModel.AutoResetSkillFinished = true;
				return;
			}
			if (this.IsNeedAddListen(type))
			{
				if (type != CharacterExploreComponent.ESkillType.Hook)
				{
					if (type == CharacterExploreComponent.ESkillType.Manipulate)
					{
						this.ListenSkillIdMap = CharacterExploreComponent.ManipulateSkillIdMap;
					}
				}
				else
				{
					this.ListenSkillIdMap = CharacterExploreComponent.HookSkillIdMap;
				}
				if (!EventSystem.Instance.HasWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd)))
				{
					EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
				}
				return;
			}
			exploreModel.ResetExplodeSkillId(EExploreSkillLayer.Auto, "CheckExit");
			int topLayerExplodeSkillId = exploreModel.GetTopLayerExplodeSkillId();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[CharacterExploreComponent] CheckExit";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OldSkill", RouletteModel.Instance.CurrentExploreSkillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewSkill", topLayerExplodeSkillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Id", base.Entity.Id);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			RouletteController.Instance.ExploreSkillSetRequest(topLayerExplodeSkillId, delegate(bool _)
			{
				exploreModel.AutoResetSkillFinished = true;
			}, true);
			this.NeedChangeTargetState = true;
		}

		// Token: 0x06046B1C RID: 289564 RVA: 0x011CD753 File Offset: 0x011CB953
		private bool CheckHasSkill(int skillId)
		{
			return RouletteModel.Instance.UnlockExploreSkillDataMap.ContainsKey(skillId);
		}

		// Token: 0x06046B1D RID: 289565 RVA: 0x011CD768 File Offset: 0x011CB968
		private bool IsNeedAddListen(CharacterExploreComponent.ESkillType type)
		{
			BaseSkillComponent skillComponent = this.SkillComponent;
			if (((skillComponent != null) ? skillComponent.CurrentSkill : null) == null)
			{
				return false;
			}
			int skillId = this.SkillComponent.CurrentSkill.SkillId;
			return (type == CharacterExploreComponent.ESkillType.Hook && CharacterExploreComponent.HookSkillIdMap.Contains((long)skillId)) || (type == CharacterExploreComponent.ESkillType.Manipulate && CharacterExploreComponent.ManipulateSkillIdMap.Contains((long)skillId));
		}

		// Token: 0x06046B1E RID: 289566 RVA: 0x011CD7C4 File Offset: 0x011CB9C4
		public unsafe long GetFixHookBuffIdByTarget()
		{
			GrapplingHookPointComponent interactingTarget = base.InteractingTarget;
			if (interactingTarget == null || !interactingTarget.Valid)
			{
				return 640003009L;
			}
			long valueOrDefault = interactingTarget.GetHookEffectBuffId().GetValueOrDefault(640003009L);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[CharacterExploreComponent] GetFixHookBuffIdByTarget";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", interactingTarget.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", valueOrDefault);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return valueOrDefault;
		}

		// Token: 0x06046B1F RID: 289567 RVA: 0x011CD868 File Offset: 0x011CBA68
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterExploreComponent characterExploreComponent = (CharacterExploreComponent)componentTemplate;
			if (base.CanResetComponentProperty("ManipulateComponent"))
			{
				if (characterExploreComponent.ManipulateComponent == null)
				{
					this.ManipulateComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterManipulateComponent>(this.ManipulateComponent), "ManipulateComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ManipulateInteractComponent"))
			{
				if (characterExploreComponent.ManipulateInteractComponent == null)
				{
					this.ManipulateInteractComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterManipulateInteractComponent>(this.ManipulateInteractComponent), "ManipulateInteractComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SceneInteractComponent"))
			{
				if (characterExploreComponent.SceneInteractComponent == null)
				{
					this.SceneInteractComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RoleSceneInteractComponent>(this.SceneInteractComponent), "SceneInteractComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Manipulating"))
			{
				this.Manipulating = characterExploreComponent.Manipulating;
			}
			if (base.CanResetComponentProperty("ListenSkillIdMap"))
			{
				if (characterExploreComponent.ListenSkillIdMap == null)
				{
					this.ListenSkillIdMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<long>(this.ListenSkillIdMap), "ListenSkillIdMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInVehicle"))
			{
				this.IsInVehicle = characterExploreComponent.IsInVehicle;
			}
			if (base.CanResetComponentProperty("NeedChangeTargetStateInternal"))
			{
				this.NeedChangeTargetStateInternal = characterExploreComponent.NeedChangeTargetStateInternal;
			}
			if (base.CanResetComponentProperty("NeedAddTag"))
			{
				this.NeedAddTag = characterExploreComponent.NeedAddTag;
			}
			if (base.CanResetComponentProperty("HookFound"))
			{
				this.HookFound = characterExploreComponent.HookFound;
			}
			if (base.CanResetComponentProperty("ManipulateFound"))
			{
				this.ManipulateFound = characterExploreComponent.ManipulateFound;
			}
			if (base.CanResetComponentProperty("LastManipulateEntityId"))
			{
				this.LastManipulateEntityId = characterExploreComponent.LastManipulateEntityId;
			}
			if (base.CanResetComponentProperty("CurManipulateEntityId"))
			{
				this.CurManipulateEntityId = characterExploreComponent.CurManipulateEntityId;
			}
			if (base.CanResetComponentProperty("LastHookEntityId"))
			{
				this.LastHookEntityId = characterExploreComponent.LastHookEntityId;
			}
			if (base.CanResetComponentProperty("CurHookEntityId"))
			{
				this.CurHookEntityId = characterExploreComponent.CurHookEntityId;
			}
			if (base.CanResetComponentProperty("ManipulateActorComp"))
			{
				if (characterExploreComponent.ManipulateActorComp == null)
				{
					this.ManipulateActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ManipulateActorComp), "ManipulateActorComp"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040251B7 RID: 151991
		private const int MANIPULATE_VISION_ID = 1003;

		// Token: 0x040251B8 RID: 151992
		private const long DEFAULT_FIX_HOOK_BUFF_ID = 640003009L;

		// Token: 0x040251B9 RID: 151993
		[StaticVariableRuleIgnore]
		private static readonly HashSet<long> ManipulateSkillIdMap = new HashSet<long>
		{
			210007L
		};

		// Token: 0x040251BA RID: 151994
		[StaticVariableRuleIgnore]
		private static readonly HashSet<long> HookSkillIdMap = new HashSet<long>
		{
			100020L,
			100021L,
			100022L,
			200004L,
			210130L,
			100024L,
			210032L
		};

		// Token: 0x040251BB RID: 151995
		[Nullable(2)]
		private CharacterManipulateComponent ManipulateComponent;

		// Token: 0x040251BC RID: 151996
		[Nullable(2)]
		private CharacterManipulateInteractComponent ManipulateInteractComponent;

		// Token: 0x040251BD RID: 151997
		[Nullable(2)]
		private RoleSceneInteractComponent SceneInteractComponent;

		// Token: 0x040251BE RID: 151998
		private bool Manipulating;

		// Token: 0x040251BF RID: 151999
		[Nullable(2)]
		private HashSet<long> ListenSkillIdMap;

		// Token: 0x040251C0 RID: 152000
		private bool IsInVehicle;

		// Token: 0x040251C1 RID: 152001
		private bool NeedChangeTargetStateInternal = true;

		// Token: 0x040251C2 RID: 152002
		private bool NeedAddTag;

		// Token: 0x040251C3 RID: 152003
		private bool HookFound;

		// Token: 0x040251C4 RID: 152004
		private bool ManipulateFound;

		// Token: 0x040251C5 RID: 152005
		private int LastManipulateEntityId;

		// Token: 0x040251C6 RID: 152006
		private int CurManipulateEntityId;

		// Token: 0x040251C7 RID: 152007
		private int LastHookEntityId;

		// Token: 0x040251C8 RID: 152008
		private int CurHookEntityId;

		// Token: 0x040251C9 RID: 152009
		[Nullable(2)]
		private BaseActorComponent ManipulateActorComp;

		// Token: 0x0200CE81 RID: 52865
		[NullableContext(0)]
		private enum ESkillType
		{
			// Token: 0x0403E289 RID: 254601
			Hook,
			// Token: 0x0403E28A RID: 254602
			Manipulate
		}
	}
}
