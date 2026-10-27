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
	// Token: 0x02004CEB RID: 19691
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVisionTabView : UiTabViewBase
	{
		// Token: 0x06032DC7 RID: 208327 RVA: 0x00BDAB24 File Offset: 0x00BD8D24
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

		// Token: 0x06032DC8 RID: 208328 RVA: 0x00BDAC6C File Offset: 0x00BD8E6C
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnChangeRole));
			EventSystem.Instance.Add<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
			EventSystem.Instance.Add<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.OnPhantomPersonalSkillActive));
			EventSystem.Instance.Add(EEventName.PhantomEquipError, new Action(this.OnEquipError));
			EventSystem.Instance.Add(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
			EventSystem.Instance.Add(EEventName.HideVisionTabRole, new Action(this.HideVisionTabRole));
		}

		// Token: 0x06032DC9 RID: 208329 RVA: 0x00BDAD24 File Offset: 0x00BD8F24
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnChangeRole));
			EventSystem.Instance.Remove<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
			EventSystem.Instance.Remove<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.OnPhantomPersonalSkillActive));
			EventSystem.Instance.Remove(EEventName.PhantomEquipError, new Action(this.OnEquipError));
			EventSystem.Instance.Remove(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
			EventSystem.Instance.Remove(EEventName.HideVisionTabRole, new Action(this.HideVisionTabRole));
		}

		// Token: 0x06032DCA RID: 208330 RVA: 0x00BDADD9 File Offset: 0x00BD8FD9
		private void HideVisionTabRole()
		{
			this.HideRole(true);
		}

		// Token: 0x06032DCB RID: 208331 RVA: 0x00BDADE2 File Offset: 0x00BD8FE2
		private void ResetRoleFlag()
		{
			this.HasUpdateRole = false;
		}

		// Token: 0x06032DCC RID: 208332 RVA: 0x00BDADEB File Offset: 0x00BD8FEB
		private void OnShowCalabash()
		{
			this.OpenCalabashView().Forget();
		}

		// Token: 0x06032DCD RID: 208333 RVA: 0x00BDADF8 File Offset: 0x00BD8FF8
		private void OnVisionGroupButton()
		{
			this.OnClickVisionGroupButton();
		}

		// Token: 0x06032DCE RID: 208334 RVA: 0x00BDAE00 File Offset: 0x00BD9000
		private UniTask OpenCalabashView()
		{
			RoleVisionTabView.<OpenCalabashView>d__24 <OpenCalabashView>d__;
			<OpenCalabashView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenCalabashView>d__.<>4__this = this;
			<OpenCalabashView>d__.<>1__state = -1;
			<OpenCalabashView>d__.<>t__builder.Start<RoleVisionTabView.<OpenCalabashView>d__24>(ref <OpenCalabashView>d__);
			return <OpenCalabashView>d__.<>t__builder.Task;
		}

		// Token: 0x06032DCF RID: 208335 RVA: 0x00BDAE44 File Offset: 0x00BD9044
		protected override UniTask OnBeforeStartAsync()
		{
			RoleVisionTabView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleVisionTabView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032DD0 RID: 208336 RVA: 0x00BDAE88 File Offset: 0x00BD9088
		private void OnClickVisionGroupButton()
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			this.HideRole(true);
			UiManager.Instance.OpenView(EUiViewName.VisionAssembleView, curSelectRoleId, null);
		}

		// Token: 0x06032DD1 RID: 208337 RVA: 0x00BDAEC0 File Offset: 0x00BD90C0
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

		// Token: 0x06032DD2 RID: 208338 RVA: 0x00BDAF44 File Offset: 0x00BD9144
		private UniTask InitVisionHeadItem()
		{
			RoleVisionTabView.<InitVisionHeadItem>d__28 <InitVisionHeadItem>d__;
			<InitVisionHeadItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitVisionHeadItem>d__.<>4__this = this;
			<InitVisionHeadItem>d__.<>1__state = -1;
			<InitVisionHeadItem>d__.<>t__builder.Start<RoleVisionTabView.<InitVisionHeadItem>d__28>(ref <InitVisionHeadItem>d__);
			return <InitVisionHeadItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032DD3 RID: 208339 RVA: 0x00BDAF87 File Offset: 0x00BD9187
		protected void PlayMontageStart(bool reLoop = false)
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Chip, reLoop, false, false);
		}

		// Token: 0x06032DD4 RID: 208340 RVA: 0x00BDAF98 File Offset: 0x00BD9198
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

		// Token: 0x06032DD5 RID: 208341 RVA: 0x00BDB048 File Offset: 0x00BD9248
		private void RefreshGroupRedDot()
		{
			bool visionGroupFirstOpenState = VisionEquipGroupModel.Instance.GetVisionGroupFirstOpenState();
			base.GetItem(10).SetUIActive(visionGroupFirstOpenState);
		}

		// Token: 0x06032DD6 RID: 208342 RVA: 0x00BDB06E File Offset: 0x00BD926E
		protected void OnChangeRole(int roleId)
		{
			this.RefreshView();
			this.HasUpdateRole = true;
			this.PlayMontageStart(true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshVisionEquipRedPoint, roleId);
		}

		// Token: 0x06032DD7 RID: 208343 RVA: 0x00BDB098 File Offset: 0x00BD9298
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

		// Token: 0x06032DD8 RID: 208344 RVA: 0x00BDB104 File Offset: 0x00BD9304
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

		// Token: 0x06032DD9 RID: 208345 RVA: 0x00BDB1AB File Offset: 0x00BD93AB
		private int GetCostMax()
		{
			return PhantomBattleModel.Instance.GetMaxCost();
		}

		// Token: 0x06032DDA RID: 208346 RVA: 0x00BDB1B7 File Offset: 0x00BD93B7
		private void OnPhantomPersonalSkillActive(int uniqueId)
		{
			this.RefreshPhantom();
		}

		// Token: 0x06032DDB RID: 208347 RVA: 0x00BDB1C0 File Offset: 0x00BD93C0
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

		// Token: 0x06032DDC RID: 208348 RVA: 0x00BDB24C File Offset: 0x00BD944C
		protected void OnEquipError()
		{
			this.ResetVisionPosition(true).Forget();
		}

		// Token: 0x06032DDD RID: 208349 RVA: 0x00BDB25A File Offset: 0x00BD945A
		protected override void OnBeforeHide()
		{
			this.CancelPendingDragAndAnimation();
			UiLayer.Instance.SetShowMaskLayer("playBackToStartPositionAnimation", false);
			UiLayer.Instance.SetShowMaskLayer("OnEquipVision", false);
		}

		// Token: 0x06032DDE RID: 208350 RVA: 0x00BDB284 File Offset: 0x00BD9484
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

		// Token: 0x06032DDF RID: 208351 RVA: 0x00BDB31C File Offset: 0x00BD951C
		protected void OnClickFailVision(int index)
		{
			if (!this.IfCanClick())
			{
				return;
			}
			this.ResetVisionPosition(true).Forget();
		}

		// Token: 0x06032DE0 RID: 208352 RVA: 0x00BDB334 File Offset: 0x00BD9534
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

		// Token: 0x06032DE1 RID: 208353 RVA: 0x00BDB414 File Offset: 0x00BD9614
		private void RefreshGroupButtonShowState()
		{
			bool flag = this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole();
			bool flag2 = FunctionModel.Instance.IsOpen(10075);
			base.GetButton(9).RootUIComp.Get().SetUIActive(flag2 && !flag);
		}

		// Token: 0x06032DE2 RID: 208354 RVA: 0x00BDB468 File Offset: 0x00BD9668
		private void ResetClickState()
		{
			int count = this.RoleVisionItem.Count;
			for (int i = 0; i < count; i++)
			{
				this.RoleVisionItem[i].SetToggleState(EToggleState.ETT_UnDetermined, false, false);
			}
		}

		// Token: 0x06032DE3 RID: 208355 RVA: 0x00BDB4A4 File Offset: 0x00BD96A4
		private void RefreshPhantomClickState()
		{
			int count = this.RoleVisionItem.Count;
			for (int i = 0; i < count; i++)
			{
				this.RoleVisionItem[i].SetToggleState(EToggleState.ETT_UnChecked, false, false);
			}
		}

		// Token: 0x06032DE4 RID: 208356 RVA: 0x00BDB4E0 File Offset: 0x00BD96E0
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

		// Token: 0x06032DE5 RID: 208357 RVA: 0x00BDB537 File Offset: 0x00BD9737
		protected void OnPointerUpCallBack(int index)
		{
			base.GetItem(7).SetRaycastTarget(false);
		}

		// Token: 0x06032DE6 RID: 208358 RVA: 0x00BDB548 File Offset: 0x00BD9748
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

		// Token: 0x06032DE7 RID: 208359 RVA: 0x00BDB61C File Offset: 0x00BD981C
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

		// Token: 0x06032DE8 RID: 208360 RVA: 0x00BDB6BC File Offset: 0x00BD98BC
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

		// Token: 0x06032DE9 RID: 208361 RVA: 0x00BDB796 File Offset: 0x00BD9996
		private void SetIndexVisionMoveState(int index, bool state)
		{
			if (index >= 0)
			{
				this.VisionDragItem[index].SetMovingState(state);
			}
		}

		// Token: 0x06032DEA RID: 208362 RVA: 0x00BDB7AE File Offset: 0x00BD99AE
		private void SetIndexVisionAnimateState(int index, bool state)
		{
			if (index >= 0)
			{
				this.RoleVisionItem[index].SetAnimationState(state);
			}
		}

		// Token: 0x06032DEB RID: 208363 RVA: 0x00BDB7C6 File Offset: 0x00BD99C6
		protected override void OnTickUiTabViewBase(float deltaTime)
		{
			this.CheckPlayMoveFailAnimation(deltaTime);
			this.CheckPlayMoveSuccessAnimation(deltaTime);
		}

		// Token: 0x06032DEC RID: 208364 RVA: 0x00BDB7D8 File Offset: 0x00BD99D8
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

		// Token: 0x06032DED RID: 208365 RVA: 0x00BDB864 File Offset: 0x00BD9A64
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

		// Token: 0x06032DEE RID: 208366 RVA: 0x00BDB8DD File Offset: 0x00BD9ADD
		private bool IfCanClick()
		{
			return !this.IsAnimationOn && !this.IsFailAnimation && !this.CeaseAnimationState;
		}

		// Token: 0x06032DEF RID: 208367 RVA: 0x00BDB8FC File Offset: 0x00BD9AFC
		private UniTask DoCeaseAnimationAndResetView()
		{
			RoleVisionTabView.<DoCeaseAnimationAndResetView>d__58 <DoCeaseAnimationAndResetView>d__;
			<DoCeaseAnimationAndResetView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoCeaseAnimationAndResetView>d__.<>4__this = this;
			<DoCeaseAnimationAndResetView>d__.<>1__state = -1;
			<DoCeaseAnimationAndResetView>d__.<>t__builder.Start<RoleVisionTabView.<DoCeaseAnimationAndResetView>d__58>(ref <DoCeaseAnimationAndResetView>d__);
			return <DoCeaseAnimationAndResetView>d__.<>t__builder.Task;
		}

		// Token: 0x06032DF0 RID: 208368 RVA: 0x00BDB940 File Offset: 0x00BD9B40
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

		// Token: 0x06032DF1 RID: 208369 RVA: 0x00BDB98C File Offset: 0x00BD9B8C
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

		// Token: 0x06032DF2 RID: 208370 RVA: 0x00BDB9D8 File Offset: 0x00BD9BD8
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

		// Token: 0x06032DF3 RID: 208371 RVA: 0x00BDBA23 File Offset: 0x00BD9C23
		private void HideRole(bool isHide)
		{
			if (isHide)
			{
				UiSceneManager.Instance.HideRoleSystemRoleActor();
				this.IfHiddenRole = true;
			}
		}

		// Token: 0x06032DF4 RID: 208372 RVA: 0x00BDBA3C File Offset: 0x00BD9C3C
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

		// Token: 0x06032DF5 RID: 208373 RVA: 0x00BDBA88 File Offset: 0x00BD9C88
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

		// Token: 0x06032DF6 RID: 208374 RVA: 0x00BDBAE4 File Offset: 0x00BD9CE4
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

		// Token: 0x06032DF7 RID: 208375 RVA: 0x00BDBB94 File Offset: 0x00BD9D94
		protected override void OnBeforeDestroy()
		{
			this.IsAnimationOn = false;
		}

		// Token: 0x0401B0ED RID: 110829
		private const int INVALIDINDEX = 999;

		// Token: 0x0401B0EE RID: 110830
		[Nullable(2)]
		private CustomPromise<bool> FailAnimationPromise;

		// Token: 0x0401B0EF RID: 110831
		private bool IsAnimationOn;

		// Token: 0x0401B0F0 RID: 110832
		private bool IsFailAnimation;

		// Token: 0x0401B0F1 RID: 110833
		private bool CeaseAnimationState;

		// Token: 0x0401B0F2 RID: 110834
		private int CurrentAnimationSourceIndex = -1;

		// Token: 0x0401B0F3 RID: 110835
		private int CurrentAnimationTargetIndex = -1;

		// Token: 0x0401B0F4 RID: 110836
		private int AnimationTime;

		// Token: 0x0401B0F5 RID: 110837
		private float CurrentRunningTime;

		// Token: 0x0401B0F6 RID: 110838
		private int CurrentDragIndex = 999;

		// Token: 0x0401B0F7 RID: 110839
		[Nullable(2)]
		private RoleVisionInfoPanel RoleVisionInfoPanel;

		// Token: 0x0401B0F8 RID: 110840
		[Nullable(2)]
		private RoleViewAgent RoleViewAgent;

		// Token: 0x0401B0F9 RID: 110841
		private readonly List<RoleVisionCommonItem> RoleVisionItem = new List<RoleVisionCommonItem>();

		// Token: 0x0401B0FA RID: 110842
		private readonly List<VisionCommonDragItem> VisionDragItem = new List<VisionCommonDragItem>();

		// Token: 0x0401B0FB RID: 110843
		private int CurrentSelectIndex;

		// Token: 0x0401B0FC RID: 110844
		private bool IfHiddenRole;

		// Token: 0x0401B0FD RID: 110845
		private bool HasUpdateRole;

		// Token: 0x0200AE73 RID: 44659
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034F7B RID: 216955
			MainVisionItem,
			// Token: 0x04034F7C RID: 216956
			SubVisionItem1,
			// Token: 0x04034F7D RID: 216957
			SubVisionItem2,
			// Token: 0x04034F7E RID: 216958
			SubVisionItem3,
			// Token: 0x04034F7F RID: 216959
			SubVisionItem4,
			// Token: 0x04034F80 RID: 216960
			VisionInfoPanel,
			// Token: 0x04034F81 RID: 216961
			CalabashBtn,
			// Token: 0x04034F82 RID: 216962
			DragPanel,
			// Token: 0x04034F83 RID: 216963
			CurrentCostText,
			// Token: 0x04034F84 RID: 216964
			VisionGroupButton,
			// Token: 0x04034F85 RID: 216965
			VisionGroupRedDot
		}
	}
}
