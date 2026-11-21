using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006347 RID: 25415
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterExploreComponent : BaseExploreComponent
	{
		// Token: 0x170074E8 RID: 29928
		// (get) Token: 0x0603D94B RID: 252235 RVA: 0x011D56EE File Offset: 0x011D38EE
		// (set) Token: 0x0603D94C RID: 252236 RVA: 0x011D56F6 File Offset: 0x011D38F6
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

		// Token: 0x0603D94D RID: 252237 RVA: 0x011D5724 File Offset: 0x011D3924
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

		// Token: 0x0603D94E RID: 252238 RVA: 0x011D57E4 File Offset: 0x011D39E4
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

		// Token: 0x0603D94F RID: 252239 RVA: 0x011D586F File Offset: 0x011D3A6F
		protected override bool CheckDisableComponent()
		{
			BaseActorComponent actorComponent = this.ActorComponent;
			return actorComponent == null || !actorComponent.IsRoleAndCtrlByMe;
		}

		// Token: 0x0603D950 RID: 252240 RVA: 0x011D5888 File Offset: 0x011D3A88
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

		// Token: 0x0603D951 RID: 252241 RVA: 0x011D58E0 File Offset: 0x011D3AE0
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

		// Token: 0x0603D952 RID: 252242 RVA: 0x011D5931 File Offset: 0x011D3B31
		protected override void OnTick(float delta)
		{
			this.CheckTick();
		}

		// Token: 0x0603D953 RID: 252243 RVA: 0x011D5939 File Offset: 0x011D3B39
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

		// Token: 0x0603D954 RID: 252244 RVA: 0x011D5976 File Offset: 0x011D3B76
		private void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsDriver || info.PassengerEntity != base.Entity)
			{
				return;
			}
			this.IsInVehicle = false;
			this.OnExploreComponentEnable("主控角色离开载具");
		}

		// Token: 0x0603D955 RID: 252245 RVA: 0x011D59A4 File Offset: 0x011D3BA4
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

		// Token: 0x0603D956 RID: 252246 RVA: 0x011D5A64 File Offset: 0x011D3C64
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

		// Token: 0x0603D957 RID: 252247 RVA: 0x011D5AC4 File Offset: 0x011D3CC4
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

		// Token: 0x0603D958 RID: 252248 RVA: 0x011D5B6B File Offset: 0x011D3D6B
		public void SendHookMovePushProxy()
		{
			base.SendHookMovePush();
		}

		// Token: 0x0603D959 RID: 252249 RVA: 0x011D5B73 File Offset: 0x011D3D73
		[NullableContext(2)]
		public void SendHookTargetRequestProxy(GrapplingHookPointComponent target, [Nullable(1)] Action onFailure, string compositeSessionName = null)
		{
			base.SendHookTargetRequest(target, onFailure, compositeSessionName);
		}

		// Token: 0x0603D95A RID: 252250 RVA: 0x011D5B7E File Offset: 0x011D3D7E
		[NullableContext(2)]
		public void SendHookEndRequestProxy(GrapplingHookPointComponent target, string compositeSessionName = null)
		{
			base.SendHookEndRequest(target, compositeSessionName);
		}

		// Token: 0x0603D95B RID: 252251 RVA: 0x011D5B88 File Offset: 0x011D3D88
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

		// Token: 0x0603D95C RID: 252252 RVA: 0x011D5C98 File Offset: 0x011D3E98
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

		// Token: 0x0603D95D RID: 252253 RVA: 0x011D5DDC File Offset: 0x011D3FDC
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

		// Token: 0x0603D95E RID: 252254 RVA: 0x011D5E60 File Offset: 0x011D4060
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

		// Token: 0x0603D95F RID: 252255 RVA: 0x011D5F4C File Offset: 0x011D414C
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

		// Token: 0x0603D960 RID: 252256 RVA: 0x011D5FBC File Offset: 0x011D41BC
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

		// Token: 0x0603D961 RID: 252257 RVA: 0x011D601C File Offset: 0x011D421C
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

		// Token: 0x0603D962 RID: 252258 RVA: 0x011D61C8 File Offset: 0x011D43C8
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

		// Token: 0x0603D963 RID: 252259 RVA: 0x011D62D4 File Offset: 0x011D44D4
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

		// Token: 0x0603D964 RID: 252260 RVA: 0x011D645F File Offset: 0x011D465F
		private bool CheckHasSkill(int skillId)
		{
			return RouletteModel.Instance.UnlockExploreSkillDataMap.ContainsKey(skillId);
		}

		// Token: 0x0603D965 RID: 252261 RVA: 0x011D6474 File Offset: 0x011D4674
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

		// Token: 0x0603D966 RID: 252262 RVA: 0x011D64D0 File Offset: 0x011D46D0
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

		// Token: 0x0603D967 RID: 252263 RVA: 0x011D6574 File Offset: 0x011D4774
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterExploreComponent characterExploreComponent = (CharacterExploreComponent)componentTemplate;
			if (characterExploreComponent.ManipulateComponent == null)
			{
				this.ManipulateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ManipulateComponent), "ManipulateComponent"))
			{
				return false;
			}
			if (characterExploreComponent.ManipulateInteractComponent == null)
			{
				this.ManipulateInteractComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ManipulateInteractComponent), "ManipulateInteractComponent"))
			{
				return false;
			}
			if (characterExploreComponent.SceneInteractComponent == null)
			{
				this.SceneInteractComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SceneInteractComponent), "SceneInteractComponent"))
			{
				return false;
			}
			this.Manipulating = characterExploreComponent.Manipulating;
			if (characterExploreComponent.ListenSkillIdMap == null)
			{
				this.ListenSkillIdMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<long>(this.ListenSkillIdMap), "ListenSkillIdMap"))
			{
				return false;
			}
			this.IsInVehicle = characterExploreComponent.IsInVehicle;
			this.NeedChangeTargetStateInternal = characterExploreComponent.NeedChangeTargetStateInternal;
			this.NeedAddTag = characterExploreComponent.NeedAddTag;
			this.HookFound = characterExploreComponent.HookFound;
			this.ManipulateFound = characterExploreComponent.ManipulateFound;
			this.LastManipulateEntityId = characterExploreComponent.LastManipulateEntityId;
			this.CurManipulateEntityId = characterExploreComponent.CurManipulateEntityId;
			this.LastHookEntityId = characterExploreComponent.LastHookEntityId;
			this.CurHookEntityId = characterExploreComponent.CurHookEntityId;
			if (characterExploreComponent.ManipulateActorComp == null)
			{
				this.ManipulateActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ManipulateActorComp), "ManipulateActorComp"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170074E9 RID: 29929
		// (get) Token: 0x0603D968 RID: 252264 RVA: 0x011D66E3 File Offset: 0x011D48E3
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074EA RID: 29930
		// (get) Token: 0x0603D969 RID: 252265 RVA: 0x011D66E6 File Offset: 0x011D48E6
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074EB RID: 29931
		// (get) Token: 0x0603D96A RID: 252266 RVA: 0x011D66E9 File Offset: 0x011D48E9
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A97 RID: 133783
		private const int MANIPULATE_VISION_ID = 1003;

		// Token: 0x04020A98 RID: 133784
		private const long DEFAULT_FIX_HOOK_BUFF_ID = 640003009L;

		// Token: 0x04020A99 RID: 133785
		[StaticVariableRuleIgnore]
		private static readonly HashSet<long> ManipulateSkillIdMap = new HashSet<long>
		{
			210007L
		};

		// Token: 0x04020A9A RID: 133786
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

		// Token: 0x04020A9B RID: 133787
		[Nullable(2)]
		private CharacterManipulateComponent ManipulateComponent;

		// Token: 0x04020A9C RID: 133788
		[Nullable(2)]
		private CharacterManipulateInteractComponent ManipulateInteractComponent;

		// Token: 0x04020A9D RID: 133789
		[Nullable(2)]
		private RoleSceneInteractComponent SceneInteractComponent;

		// Token: 0x04020A9E RID: 133790
		private bool Manipulating;

		// Token: 0x04020A9F RID: 133791
		[Nullable(2)]
		private HashSet<long> ListenSkillIdMap;

		// Token: 0x04020AA0 RID: 133792
		private bool IsInVehicle;

		// Token: 0x04020AA1 RID: 133793
		private bool NeedChangeTargetStateInternal = true;

		// Token: 0x04020AA2 RID: 133794
		private bool NeedAddTag;

		// Token: 0x04020AA3 RID: 133795
		private bool HookFound;

		// Token: 0x04020AA4 RID: 133796
		private bool ManipulateFound;

		// Token: 0x04020AA5 RID: 133797
		private int LastManipulateEntityId;

		// Token: 0x04020AA6 RID: 133798
		private int CurManipulateEntityId;

		// Token: 0x04020AA7 RID: 133799
		private int LastHookEntityId;

		// Token: 0x04020AA8 RID: 133800
		private int CurHookEntityId;

		// Token: 0x04020AA9 RID: 133801
		[Nullable(2)]
		private BaseActorComponent ManipulateActorComp;

		// Token: 0x0200BB49 RID: 47945
		[NullableContext(0)]
		private enum ESkillType
		{
			// Token: 0x04039993 RID: 235923
			Hook,
			// Token: 0x04039994 RID: 235924
			Manipulate
		}
	}
}
