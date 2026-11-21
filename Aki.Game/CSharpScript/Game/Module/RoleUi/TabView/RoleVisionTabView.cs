using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi.TabView.VisionSubView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView
{
	// Token: 0x02003C9D RID: 15517
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVisionTabView : UiTabViewBase
	{
		// Token: 0x06027BA2 RID: 162722 RVA: 0x00B2042C File Offset: 0x00B1E62C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnShowCalabash)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnVisionGroupButton))
			};
		}

		// Token: 0x06027BA3 RID: 162723 RVA: 0x00B20574 File Offset: 0x00B1E774
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnChangeRole));
			EventSystem.Instance.Add<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
			EventSystem.Instance.Add<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.OnPhantomPersonalSkillActive));
			EventSystem.Instance.Add(EEventName.PhantomEquipError, new Action(this.OnEquipError));
			EventSystem.Instance.Add(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
			EventSystem.Instance.Add(EEventName.HideVisionTabRole, new Action(this.HideVisionTabRole));
		}

		// Token: 0x06027BA4 RID: 162724 RVA: 0x00B2062C File Offset: 0x00B1E82C
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnChangeRole));
			EventSystem.Instance.Remove<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
			EventSystem.Instance.Remove<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.OnPhantomPersonalSkillActive));
			EventSystem.Instance.Remove(EEventName.PhantomEquipError, new Action(this.OnEquipError));
			EventSystem.Instance.Remove(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
			EventSystem.Instance.Remove(EEventName.HideVisionTabRole, new Action(this.HideVisionTabRole));
		}

		// Token: 0x06027BA5 RID: 162725 RVA: 0x00B206E1 File Offset: 0x00B1E8E1
		private void HideVisionTabRole()
		{
			this.HideRole(true);
		}

		// Token: 0x06027BA6 RID: 162726 RVA: 0x00B206EA File Offset: 0x00B1E8EA
		private void ResetRoleFlag()
		{
			this.HasUpdateRole = false;
		}

		// Token: 0x06027BA7 RID: 162727 RVA: 0x00B206F3 File Offset: 0x00B1E8F3
		private void OnShowCalabash()
		{
			this.OpenCalabashView().Forget();
		}

		// Token: 0x06027BA8 RID: 162728 RVA: 0x00B20700 File Offset: 0x00B1E900
		private void OnVisionGroupButton()
		{
			this.OnClickVisionGroupButton();
		}

		// Token: 0x06027BA9 RID: 162729 RVA: 0x00B20708 File Offset: 0x00B1E908
		private UniTask OpenCalabashView()
		{
			RoleVisionTabView.<OpenCalabashView>d__24 <OpenCalabashView>d__;
			<OpenCalabashView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenCalabashView>d__.<>4__this = this;
			<OpenCalabashView>d__.<>1__state = -1;
			<OpenCalabashView>d__.<>t__builder.Start<RoleVisionTabView.<OpenCalabashView>d__24>(ref <OpenCalabashView>d__);
			return <OpenCalabashView>d__.<>t__builder.Task;
		}

		// Token: 0x06027BAA RID: 162730 RVA: 0x00B2074C File Offset: 0x00B1E94C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleVisionTabView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleVisionTabView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027BAB RID: 162731 RVA: 0x00B20790 File Offset: 0x00B1E990
		private void OnClickVisionGroupButton()
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			this.HideRole(true);
			UiManager.Instance.OpenView(EUiViewName.VisionAssembleView, curSelectRoleId, null);
		}

		// Token: 0x06027BAC RID: 162732 RVA: 0x00B207C8 File Offset: 0x00B1E9C8
		protected override void OnStart()
		{
			base.GetItem(7).SetUIActive(true);
			base.GetItem(7).SetRaycastTarget(false);
			this.RoleVisionInfoPanel.SetActive(true);
			this.RoleVisionInfoPanel.SetConfirmButtonCall(delegate
			{
				this.OnClickVision(this.CurrentSelectIndex);
			});
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			this.AnimationTime = PhantomBattleConfig.Instance.GetVisionDragCurveTime();
			EventSystem.Instance.Emit(EEventName.OnVisionRefineSubNeedAck);
		}

		// Token: 0x06027BAD RID: 162733 RVA: 0x00B2084C File Offset: 0x00B1EA4C
		private UniTask InitVisionHeadItem()
		{
			RoleVisionTabView.<InitVisionHeadItem>d__28 <InitVisionHeadItem>d__;
			<InitVisionHeadItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitVisionHeadItem>d__.<>4__this = this;
			<InitVisionHeadItem>d__.<>1__state = -1;
			<InitVisionHeadItem>d__.<>t__builder.Start<RoleVisionTabView.<InitVisionHeadItem>d__28>(ref <InitVisionHeadItem>d__);
			return <InitVisionHeadItem>d__.<>t__builder.Task;
		}

		// Token: 0x06027BAE RID: 162734 RVA: 0x00B2088F File Offset: 0x00B1EA8F
		protected void PlayMontageStart(bool reLoop = false)
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Chip, reLoop, false, false);
		}

		// Token: 0x06027BAF RID: 162735 RVA: 0x00B208A0 File Offset: 0x00B1EAA0
		protected override void OnBeforeShow()
		{
			PhantomBattleModel.Instance.ClearCurrentDragIndex();
			this.ShowRoleModel();
			if (this.HasUpdateRole)
			{
				this.PlayMontageStart(true);
				this.HasUpdateRole = false;
			}
			else if (this.IfHiddenRole)
			{
				this.PlayMontageStart(true);
				this.IfHiddenRole = false;
			}
			else
			{
				this.PlayMontageStart(false);
			}
			this.CurrentSelectIndex = 0;
			this.RefreshView();
			this.ResetClickState();
			this.RefreshPhantomClickState();
			this.CurrentDragIndex = 999;
			this.ResetVisionPosition(true).Forget();
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			this.RefreshGroupRedDot();
			this.RefreshGroupButtonShowState();
			EventSystem.Instance.Emit<int>(EEventName.RefreshVisionEquipRedPoint, curSelectRoleId);
		}

		// Token: 0x06027BB0 RID: 162736 RVA: 0x00B20950 File Offset: 0x00B1EB50
		private void RefreshGroupRedDot()
		{
			bool visionGroupFirstOpenState = VisionEquipGroupModel.Instance.GetVisionGroupFirstOpenState();
			base.GetItem(10).SetUIActive(visionGroupFirstOpenState);
		}

		// Token: 0x06027BB1 RID: 162737 RVA: 0x00B20976 File Offset: 0x00B1EB76
		protected void OnChangeRole(int roleId)
		{
			this.RefreshView();
			this.HasUpdateRole = true;
			this.PlayMontageStart(true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshVisionEquipRedPoint, roleId);
		}

		// Token: 0x06027BB2 RID: 162738 RVA: 0x00B209A0 File Offset: 0x00B1EBA0
		private void RefreshView()
		{
			this.RefreshPhantom();
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			bool flag = curSelectRoleData.IsTrialRole();
			PhantomBattleController.Instance.ChangeRoleEvent(curSelectRoleData.GetDataId());
			this.RoleVisionInfoPanel.RefreshView(this.RoleViewAgent);
			base.GetButton(6).RootUIComp.Get().SetUIActive(!flag);
			this.RefreshCost();
		}

		// Token: 0x06027BB3 RID: 162739 RVA: 0x00B20A0C File Offset: 0x00B1EC0C
		private void RefreshCost()
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			int roleCurrentPhantomCost;
			int num;
			if (curSelectRoleData != null && curSelectRoleData.IsTrialRole())
			{
				roleCurrentPhantomCost = PhantomBattleModel.Instance.GetRoleCurrentPhantomCost(curSelectRoleData.GetDataId());
				num = PhantomBattleConfig.Instance.GetVisionReachableCostMax();
			}
			else
			{
				roleCurrentPhantomCost = PhantomBattleModel.Instance.GetRoleCurrentPhantomCost(curSelectRoleData.GetRoleId());
				num = this.GetCostMax();
			}
			base.GetText(8).SetText(StringUtils.Format("{0}/{1}", new string[]
			{
				roleCurrentPhantomCost.ToString(),
				num.ToString()
			}), true);
			int roleId = curSelectRoleData.GetRoleId();
			EventSystem.Instance.Emit<int>(EEventName.RefreshVisionEquipRedPoint, roleId);
		}

		// Token: 0x06027BB4 RID: 162740 RVA: 0x00B20AB3 File Offset: 0x00B1ECB3
		private int GetCostMax()
		{
			return PhantomBattleModel.Instance.GetMaxCost();
		}

		// Token: 0x06027BB5 RID: 162741 RVA: 0x00B20ABF File Offset: 0x00B1ECBF
		private void OnPhantomPersonalSkillActive(int uniqueId)
		{
			this.RefreshPhantom();
		}

		// Token: 0x06027BB6 RID: 162742 RVA: 0x00B20AC8 File Offset: 0x00B1ECC8
		protected void RefreshPhantom()
		{
			RoleViewAgent roleViewAgent = this.RoleViewAgent;
			RoleDataBase roleDataBase = (roleViewAgent != null) ? roleViewAgent.GetCurSelectRoleData() : null;
			List<PhantomDataBase> currentViewShowPhantomList = PhantomBattleModel.Instance.GetCurrentViewShowPhantomList(roleDataBase);
			int count = this.RoleVisionItem.Count;
			for (int i = 0; i < count; i++)
			{
				PhantomDataBase data = (currentViewShowPhantomList.Count > i) ? currentViewShowPhantomList[i] : null;
				this.RoleVisionItem[i].UpdateItem(data, roleDataBase);
				this.VisionDragItem[i].Refresh(data, roleDataBase.IsTrialRole());
			}
			this.RefreshCost();
		}

		// Token: 0x06027BB7 RID: 162743 RVA: 0x00B20B54 File Offset: 0x00B1ED54
		protected void OnEquipError()
		{
			this.ResetVisionPosition(true).Forget();
		}

		// Token: 0x06027BB8 RID: 162744 RVA: 0x00B20B62 File Offset: 0x00B1ED62
		protected override void OnBeforeHide()
		{
			this.CancelPendingDragAndAnimation();
			UiLayer.Instance.SetShowMaskLayer("playBackToStartPositionAnimation", false);
			UiLayer.Instance.SetShowMaskLayer("OnEquipVision", false);
		}

		// Token: 0x06027BB9 RID: 162745 RVA: 0x00B20B8C File Offset: 0x00B1ED8C
		private void CancelPendingDragAndAnimation()
		{
			CustomPromise<bool> failAnimationPromise = this.FailAnimationPromise;
			if (failAnimationPromise != null)
			{
				failAnimationPromise.SetResult(true);
			}
			this.IsAnimationOn = false;
			this.IsFailAnimation = false;
			this.CeaseAnimationState = false;
			foreach (VisionCommonDragItem visionCommonDragItem in this.VisionDragItem)
			{
				visionCommonDragItem.CancelDrag();
			}
			PhantomBattleModel.Instance.ClearCurrentDragIndex();
			this.CurrentDragIndex = 999;
			this.ResetVisionPosition(false).Forget();
		}

		// Token: 0x06027BBA RID: 162746 RVA: 0x00B20C24 File Offset: 0x00B1EE24
		protected void OnClickFailVision(int index)
		{
			if (!this.IfCanClick())
			{
				return;
			}
			this.ResetVisionPosition(true).Forget();
		}

		// Token: 0x06027BBB RID: 162747 RVA: 0x00B20C3C File Offset: 0x00B1EE3C
		protected void OnClickVision(int index)
		{
			if (!this.IfCanClick())
			{
				return;
			}
			this.ResetVisionPosition(true).Forget();
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			if (curSelectRoleData.IsTrialRole())
			{
				ScrollingTipsController.Instance.ShowTipsById("RolePhantomTrialTips", Array.Empty<object>());
				return;
			}
			this.CurrentSelectIndex = index;
			PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = index;
			int? num = new int?(PhantomBattleController.Instance.GetEquipByIndex(curSelectRoleData.GetRoleId(), index));
			PhantomBattleModel.Instance.CurrentSelectUniqueId = num.Value;
			this.HideRole(true);
			this.RefreshPhantomClickState();
			this.ResetVisionPosition(true).Forget();
			AudioSystem.Instance.PostEvent("ui_vision_item_click");
			PhantomUtil.OpenVisionEquipmentView(curSelectRoleData.GetRoleId(), -1, new ERoleViewSource?(this.RoleViewAgent.Source));
			this.UiViewSequence.PlaySequencePurely("HideView", false, false);
		}

		// Token: 0x06027BBC RID: 162748 RVA: 0x00B20D1C File Offset: 0x00B1EF1C
		private void RefreshGroupButtonShowState()
		{
			bool flag = this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole();
			bool flag2 = FunctionModel.Instance.IsOpen(10075);
			base.GetButton(9).RootUIComp.Get().SetUIActive(flag2 && !flag);
		}

		// Token: 0x06027BBD RID: 162749 RVA: 0x00B20D70 File Offset: 0x00B1EF70
		private void ResetClickState()
		{
			int count = this.RoleVisionItem.Count;
			for (int i = 0; i < count; i++)
			{
				this.RoleVisionItem[i].SetToggleState(EToggleState.ETT_UnDetermined, false, false);
			}
		}

		// Token: 0x06027BBE RID: 162750 RVA: 0x00B20DAC File Offset: 0x00B1EFAC
		private void RefreshPhantomClickState()
		{
			int count = this.RoleVisionItem.Count;
			for (int i = 0; i < count; i++)
			{
				this.RoleVisionItem[i].SetToggleState(EToggleState.ETT_UnChecked, false, false);
			}
		}

		// Token: 0x06027BBF RID: 162751 RVA: 0x00B20DE8 File Offset: 0x00B1EFE8
		protected void OnPointerDownCallBack(int index)
		{
			if (!this.IfCanClick())
			{
				return;
			}
			base.GetItem(7).SetRaycastTarget(true);
			int count = this.VisionDragItem.Count;
			for (int i = 0; i < count; i++)
			{
				this.VisionDragItem[i].StartClickCheckTimer();
			}
			this.CurrentDragIndex = 999;
		}

		// Token: 0x06027BC0 RID: 162752 RVA: 0x00B20E3F File Offset: 0x00B1F03F
		protected void OnPointerUpCallBack(int index)
		{
			base.GetItem(7).SetRaycastTarget(false);
		}

		// Token: 0x06027BC1 RID: 162753 RVA: 0x00B20E50 File Offset: 0x00B1F050
		protected void OnBeginDrag(int index)
		{
			this.CurrentDragIndex = index;
			if (this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole())
			{
				return;
			}
			foreach (VisionCommonDragItem visionCommonDragItem in this.VisionDragItem)
			{
				visionCommonDragItem.StartDragState();
			}
			int count = this.VisionDragItem.Count;
			for (int i = 0; i < count; i++)
			{
				if (PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.VisionDragItem[i].GetCurrentIndex()))
				{
					this.VisionDragItem[i].SetDragItemHierarchyMax();
				}
			}
			this.VisionDragItem[index].SetItemToPointerPosition();
			AudioSystem.Instance.PostEvent("ui_vision_item_drag");
		}

		// Token: 0x06027BC2 RID: 162754 RVA: 0x00B20F24 File Offset: 0x00B1F124
		protected void OnDragEndCallBack(VisionCommonDragItem self, List<VisionCommonDragItem> targets, bool _)
		{
			if (targets.Count >= 1)
			{
				int currentIndex = self.GetCurrentIndex();
				int overlapIndex = VisionCommonDragItem.GetOverlapIndex(self, targets);
				RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
				List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(curSelectRoleData.GetRoleId()).GetIncrIdList();
				this.SetIndexVisionMoveState(currentIndex, true);
				this.SetIndexVisionMoveState(overlapIndex, true);
				this.SetIndexVisionAnimateState(currentIndex, true);
				this.SetIndexVisionAnimateState(overlapIndex, true);
				PhantomBattleController.Instance.SendPhantomPutOnRequest(incrIdList[currentIndex], curSelectRoleData.GetRoleId(), overlapIndex, currentIndex, true);
				return;
			}
			this.ResetVisionPosition(true).Forget();
			AudioSystem.Instance.PostEvent("ui_vision_item_drop");
		}

		// Token: 0x06027BC3 RID: 162755 RVA: 0x00B20FC4 File Offset: 0x00B1F1C4
		private void OnEquipEquipment(int selfIndex, int targetIndex, bool fromDrag)
		{
			if (!fromDrag)
			{
				this.RefreshPhantom();
				return;
			}
			UiLayer.Instance.SetShowMaskLayer("OnEquipVision", true);
			this.IsAnimationOn = false;
			this.CurrentRunningTime = 0f;
			Vector2D animationTargetPos = this.VisionDragItem[targetIndex].GetAnimationTargetPos();
			this.VisionDragItem[selfIndex].SetDragComponentToTargetPositionParam(animationTargetPos);
			Vector2D animationTargetPos2 = this.VisionDragItem[selfIndex].GetAnimationTargetPos();
			this.VisionDragItem[targetIndex].SetDragComponentToTargetPositionParam(animationTargetPos2);
			this.CurrentAnimationSourceIndex = selfIndex;
			this.CurrentAnimationTargetIndex = targetIndex;
			this.SetIndexVisionMoveState(this.CurrentAnimationSourceIndex, true);
			this.SetIndexVisionMoveState(this.CurrentAnimationTargetIndex, true);
			this.SetIndexVisionAnimateState(this.CurrentAnimationSourceIndex, true);
			this.SetIndexVisionAnimateState(this.CurrentAnimationTargetIndex, true);
			this.IsAnimationOn = true;
			AudioSystem.Instance.PostEvent("ui_vision_equip_on");
		}

		// Token: 0x06027BC4 RID: 162756 RVA: 0x00B2109E File Offset: 0x00B1F29E
		private void SetIndexVisionMoveState(int index, bool state)
		{
			if (index >= 0)
			{
				this.VisionDragItem[index].SetMovingState(state);
			}
		}

		// Token: 0x06027BC5 RID: 162757 RVA: 0x00B210B6 File Offset: 0x00B1F2B6
		private void SetIndexVisionAnimateState(int index, bool state)
		{
			if (index >= 0)
			{
				this.RoleVisionItem[index].SetAnimationState(state);
			}
		}

		// Token: 0x06027BC6 RID: 162758 RVA: 0x00B210CE File Offset: 0x00B1F2CE
		protected override void OnTickUiTabViewBase(float deltaTime)
		{
			this.CheckPlayMoveFailAnimation(deltaTime);
			this.CheckPlayMoveSuccessAnimation(deltaTime);
		}

		// Token: 0x06027BC7 RID: 162759 RVA: 0x00B210E0 File Offset: 0x00B1F2E0
		private void CheckPlayMoveSuccessAnimation(float deltaTime)
		{
			if (!this.IsAnimationOn)
			{
				return;
			}
			this.CurrentRunningTime += deltaTime;
			float num = this.CurrentRunningTime / (float)this.AnimationTime;
			if (num >= 1f)
			{
				num = 1f;
			}
			this.VisionDragItem[this.CurrentAnimationSourceIndex].TickDoCeaseAnimation(num);
			this.VisionDragItem[this.CurrentAnimationTargetIndex].TickDoCeaseAnimation(num);
			if (num >= 1f)
			{
				this.DoCeaseAnimationAndResetView().Forget();
				this.IsAnimationOn = false;
			}
		}

		// Token: 0x06027BC8 RID: 162760 RVA: 0x00B2116C File Offset: 0x00B1F36C
		private void CheckPlayMoveFailAnimation(float deltaTime)
		{
			if (!this.IsFailAnimation)
			{
				return;
			}
			this.CurrentRunningTime += deltaTime;
			float num = this.CurrentRunningTime / (float)this.AnimationTime;
			if (num >= 1f)
			{
				num = 1f;
			}
			this.VisionDragItem[this.CurrentDragIndex].TickDoCeaseAnimation(num);
			if (num >= 1f)
			{
				this.DoFailCeaseAnimation(this.CurrentDragIndex).Forget();
				this.IsFailAnimation = false;
			}
		}

		// Token: 0x06027BC9 RID: 162761 RVA: 0x00B211E5 File Offset: 0x00B1F3E5
		private bool IfCanClick()
		{
			return !this.IsAnimationOn && !this.IsFailAnimation && !this.CeaseAnimationState;
		}

		// Token: 0x06027BCA RID: 162762 RVA: 0x00B21204 File Offset: 0x00B1F404
		private UniTask DoCeaseAnimationAndResetView()
		{
			RoleVisionTabView.<DoCeaseAnimationAndResetView>d__58 <DoCeaseAnimationAndResetView>d__;
			<DoCeaseAnimationAndResetView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoCeaseAnimationAndResetView>d__.<>4__this = this;
			<DoCeaseAnimationAndResetView>d__.<>1__state = -1;
			<DoCeaseAnimationAndResetView>d__.<>t__builder.Start<RoleVisionTabView.<DoCeaseAnimationAndResetView>d__58>(ref <DoCeaseAnimationAndResetView>d__);
			return <DoCeaseAnimationAndResetView>d__.<>t__builder.Task;
		}

		// Token: 0x06027BCB RID: 162763 RVA: 0x00B21248 File Offset: 0x00B1F448
		private UniTask DoFailCeaseAnimation(int index)
		{
			RoleVisionTabView.<DoFailCeaseAnimation>d__59 <DoFailCeaseAnimation>d__;
			<DoFailCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoFailCeaseAnimation>d__.<>4__this = this;
			<DoFailCeaseAnimation>d__.index = index;
			<DoFailCeaseAnimation>d__.<>1__state = -1;
			<DoFailCeaseAnimation>d__.<>t__builder.Start<RoleVisionTabView.<DoFailCeaseAnimation>d__59>(ref <DoFailCeaseAnimation>d__);
			return <DoFailCeaseAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x06027BCC RID: 162764 RVA: 0x00B21294 File Offset: 0x00B1F494
		private UniTask PlayCeaseAnimation(int index)
		{
			RoleVisionTabView.<PlayCeaseAnimation>d__60 <PlayCeaseAnimation>d__;
			<PlayCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCeaseAnimation>d__.<>4__this = this;
			<PlayCeaseAnimation>d__.index = index;
			<PlayCeaseAnimation>d__.<>1__state = -1;
			<PlayCeaseAnimation>d__.<>t__builder.Start<RoleVisionTabView.<PlayCeaseAnimation>d__60>(ref <PlayCeaseAnimation>d__);
			return <PlayCeaseAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x06027BCD RID: 162765 RVA: 0x00B212E0 File Offset: 0x00B1F4E0
		private UniTask ResetVisionPosition(bool playBackToStartPositionAnimation = true)
		{
			RoleVisionTabView.<ResetVisionPosition>d__61 <ResetVisionPosition>d__;
			<ResetVisionPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetVisionPosition>d__.<>4__this = this;
			<ResetVisionPosition>d__.playBackToStartPositionAnimation = playBackToStartPositionAnimation;
			<ResetVisionPosition>d__.<>1__state = -1;
			<ResetVisionPosition>d__.<>t__builder.Start<RoleVisionTabView.<ResetVisionPosition>d__61>(ref <ResetVisionPosition>d__);
			return <ResetVisionPosition>d__.<>t__builder.Task;
		}

		// Token: 0x06027BCE RID: 162766 RVA: 0x00B2132B File Offset: 0x00B1F52B
		private void HideRole(bool isHide)
		{
			if (isHide)
			{
				UiSceneManager.Instance.HideRoleSystemRoleActor();
				this.IfHiddenRole = true;
			}
		}

		// Token: 0x06027BCF RID: 162767 RVA: 0x00B21344 File Offset: 0x00B1F544
		private void ShowRoleModel()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			if (roleSystemRoleActor == null)
			{
				return;
			}
			UiModelBase model = roleSystemRoleActor.Model;
			UiModelUtil.Instance.StopFade(model);
			UiModelUtil.Instance.SetDitherEffect(model, 1f);
			UiModelUtil.Instance.SetVisible(model, true);
		}

		// Token: 0x06027BD0 RID: 162768 RVA: 0x00B21390 File Offset: 0x00B1F590
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] GetRoleVisionGuideItem(int index)
		{
			if (!this.IfCanClick())
			{
				return null;
			}
			if (index >= 0)
			{
				RoleVisionCommonItem roleVisionCommonItem = this.RoleVisionItem[index];
				UUIItem uuiitem;
				if (roleVisionCommonItem == null)
				{
					uuiitem = null;
				}
				else
				{
					UUIDraggableComponent dragComponent = roleVisionCommonItem.GetDragComponent();
					uuiitem = ((dragComponent != null) ? dragComponent.RootUIComp.Get() : null);
				}
				UUIItem uuiitem2 = uuiitem;
				if (uuiitem2 != null)
				{
					return new UUIItem[]
					{
						uuiitem2,
						uuiitem2
					};
				}
			}
			return null;
		}

		// Token: 0x06027BD1 RID: 162769 RVA: 0x00B213EC File Offset: 0x00B1F5EC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 1)
			{
				if (configParams[0] == "Equipped")
				{
					RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
					List<PhantomDataBase> currentViewShowPhantomList = PhantomBattleModel.Instance.GetCurrentViewShowPhantomList(curSelectRoleData);
					int index = -1;
					for (int i = 0; i < currentViewShowPhantomList.Count; i++)
					{
						if (currentViewShowPhantomList[i] != null)
						{
							index = i;
							break;
						}
					}
					return this.GetRoleVisionGuideItem(index);
				}
				if (configParams[0] == "First")
				{
					return this.GetRoleVisionGuideItem(0);
				}
				RoleVisionInfoPanel roleVisionInfoPanel = this.RoleVisionInfoPanel;
				UUIItem uuiitem = (roleVisionInfoPanel != null) ? roleVisionInfoPanel.GetTxtItemByIndex(int.Parse(configParams[0])) : null;
				if (uuiitem != null)
				{
					return new UUIItem[]
					{
						uuiitem,
						uuiitem
					};
				}
			}
			return null;
		}

		// Token: 0x06027BD2 RID: 162770 RVA: 0x00B2149C File Offset: 0x00B1F69C
		protected override void OnBeforeDestroy()
		{
			this.IsAnimationOn = false;
		}

		// Token: 0x04015A72 RID: 88690
		private const int INVALIDINDEX = 999;

		// Token: 0x04015A73 RID: 88691
		[Nullable(2)]
		private CustomPromise<bool> FailAnimationPromise;

		// Token: 0x04015A74 RID: 88692
		private bool IsAnimationOn;

		// Token: 0x04015A75 RID: 88693
		private bool IsFailAnimation;

		// Token: 0x04015A76 RID: 88694
		private bool CeaseAnimationState;

		// Token: 0x04015A77 RID: 88695
		private int CurrentAnimationSourceIndex = -1;

		// Token: 0x04015A78 RID: 88696
		private int CurrentAnimationTargetIndex = -1;

		// Token: 0x04015A79 RID: 88697
		private int AnimationTime;

		// Token: 0x04015A7A RID: 88698
		private float CurrentRunningTime;

		// Token: 0x04015A7B RID: 88699
		private int CurrentDragIndex = 999;

		// Token: 0x04015A7C RID: 88700
		[Nullable(2)]
		private RoleVisionInfoPanel RoleVisionInfoPanel;

		// Token: 0x04015A7D RID: 88701
		[Nullable(2)]
		private RoleViewAgent RoleViewAgent;

		// Token: 0x04015A7E RID: 88702
		private readonly List<RoleVisionCommonItem> RoleVisionItem = new List<RoleVisionCommonItem>();

		// Token: 0x04015A7F RID: 88703
		private readonly List<VisionCommonDragItem> VisionDragItem = new List<VisionCommonDragItem>();

		// Token: 0x04015A80 RID: 88704
		private int CurrentSelectIndex;

		// Token: 0x04015A81 RID: 88705
		private bool IfHiddenRole;

		// Token: 0x04015A82 RID: 88706
		private bool HasUpdateRole;

		// Token: 0x02009891 RID: 39057
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F923 RID: 194851
			MainVisionItem,
			// Token: 0x0402F924 RID: 194852
			SubVisionItem1,
			// Token: 0x0402F925 RID: 194853
			SubVisionItem2,
			// Token: 0x0402F926 RID: 194854
			SubVisionItem3,
			// Token: 0x0402F927 RID: 194855
			SubVisionItem4,
			// Token: 0x0402F928 RID: 194856
			VisionInfoPanel,
			// Token: 0x0402F929 RID: 194857
			CalabashBtn,
			// Token: 0x0402F92A RID: 194858
			DragPanel,
			// Token: 0x0402F92B RID: 194859
			CurrentCostText,
			// Token: 0x0402F92C RID: 194860
			VisionGroupButton,
			// Token: 0x0402F92D RID: 194861
			VisionGroupRedDot
		}
	}
}
