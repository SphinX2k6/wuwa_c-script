using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010C3 RID: 4291
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1,
	1
})]
public abstract class FormationFlavorViewBase : FormationViewBase<FormationDataProvider, FormationContextValidator, ISlotPresenter>
{
	// Token: 0x0600AA59 RID: 43609 RVA: 0x00323FC0 File Offset: 0x003221C0
	protected FormationFlavorViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011CB RID: 4555
	// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x0032402F File Offset: 0x0032222F
	protected override FormationDataProvider Provider { get; } = new FormationDataProvider();

	// Token: 0x170011CC RID: 4556
	// (get) Token: 0x0600AA5B RID: 43611 RVA: 0x00324037 File Offset: 0x00322237
	protected override FormationContextValidator Validator { get; } = new FormationContextValidator();

	// Token: 0x170011CD RID: 4557
	// (get) Token: 0x0600AA5C RID: 43612
	protected abstract FormationActionKeys FormationActionKeys { get; }

	// Token: 0x0600AA5D RID: 43613
	protected abstract UniTask CreateAllSlotsAsync();

	// Token: 0x0600AA5E RID: 43614 RVA: 0x00324040 File Offset: 0x00322240
	protected override UniTask OnBeforeStartAsync()
	{
		FormationFlavorViewBase.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA5F RID: 43615 RVA: 0x00324084 File Offset: 0x00322284
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		FormationFlavorViewBase.<OnHandlePostLoadSceneAsync>d__26 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<OnHandlePostLoadSceneAsync>d__26>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA60 RID: 43616 RVA: 0x003240D0 File Offset: 0x003222D0
	protected override void OnBeforeShow()
	{
		this.Presenter.ActivateDragData();
		bool flag = !GameModeModel.Instance.IsMulti;
		if (flag)
		{
			int index = this.EditFormationId - 1;
			this.TabComponent.SelectToggleByIndex(index, false);
			this.TabComponent.ScrollToToggleByIndex(index);
			this.TabComponent.RefreshTitleByIndex(index);
			this.RefreshTeamBattleTips();
		}
		UUIButtonComponent button = base.GetButton(this.FormationActionKeys.PresetForm);
		object obj;
		if (button == null)
		{
			obj = null;
		}
		else
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			obj = ((uuiitem != null) ? uuiitem.GetAttachParent() : null);
		}
		UUIItem uuiitem2 = obj as UUIItem;
		if (uuiitem2 != null)
		{
			uuiitem2.SetUIActive(flag);
		}
		UUIButtonComponent button2 = base.GetButton(this.FormationActionKeys.EditFormName);
		if (button2 != null)
		{
			UUIItem uuiitem3 = button2.RootUIComp.Get();
			if (uuiitem3 != null)
			{
				uuiitem3.SetUIActive(flag);
			}
		}
		if (this.HasRefreshedRoleViewBeforeShowAsync)
		{
			this.HasRefreshedRoleViewBeforeShowAsync = false;
		}
		else
		{
			this.RefreshAllRoleView(this.EditFormationId, null);
		}
		this.RefreshFormationSwitchToggleState();
	}

	// Token: 0x0600AA61 RID: 43617 RVA: 0x003241C4 File Offset: 0x003223C4
	protected override void OnStart()
	{
		RoleModel.Instance.StartGamePlayRoleEdit(ESkillBranchCacheType.Normal);
		UUIItem item = base.GetItem(this.Keys.Tab);
		this.TabStartSequencePlayer = new LevelSequencePlayer(item);
		this.TabCloseSequencePlayer = new LevelSequencePlayer(item);
	}

	// Token: 0x0600AA62 RID: 43618 RVA: 0x00324206 File Offset: 0x00322406
	protected override void OnAfterShow()
	{
		FormationModel.Instance.SetViewSwitching(false);
		this.ReportSwitchLog();
	}

	// Token: 0x0600AA63 RID: 43619 RVA: 0x0032421C File Offset: 0x0032241C
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle formationSwitchToggle = this.FormationSwitchToggle;
		if (formationSwitchToggle != null)
		{
			formationSwitchToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnFormationSwitchToggleStateChange));
		}
		this.FormationSwitchToggle = null;
		base.OnBeforeDestroy();
		if (this.DelayLoadingTimer != null)
		{
			if (TimerSystem.Instance.Has(this.DelayLoadingTimer))
			{
				TimerSystem.Instance.Remove(this.DelayLoadingTimer);
			}
			this.DelayLoadingTimer = null;
		}
		if (this.AutoCloseTimer != null)
		{
			if (TimerSystem.Instance.Has(this.AutoCloseTimer))
			{
				TimerSystem.Instance.Remove(this.AutoCloseTimer);
			}
			this.AutoCloseTimer = null;
		}
		LevelSequencePlayer tabStartSequencePlayer = this.TabStartSequencePlayer;
		if (tabStartSequencePlayer != null)
		{
			tabStartSequencePlayer.Clear();
		}
		this.TabStartSequencePlayer = null;
		LevelSequencePlayer tabCloseSequencePlayer = this.TabCloseSequencePlayer;
		if (tabCloseSequencePlayer != null)
		{
			tabCloseSequencePlayer.Clear();
		}
		this.TabCloseSequencePlayer = null;
	}

	// Token: 0x0600AA64 RID: 43620 RVA: 0x003242EC File Offset: 0x003224EC
	[NullableContext(2)]
	protected override void OnRefreshRoleView(int[] needRefreshPosition = null)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		this.RefreshConfirmButton();
		this.RefreshAllRoleView(this.EditFormationId, needRefreshPosition);
	}

	// Token: 0x0600AA65 RID: 43621 RVA: 0x0032430C File Offset: 0x0032250C
	[NullableContext(2)]
	protected override void RefreshAllRoleView(int formationId, int[] needRefreshPosition = null)
	{
		Team3DSwitchLogData quickSelectLogData = this.QuickSelectLogData;
		this.QuickSelectLogData = null;
		if (quickSelectLogData != null && quickSelectLogData.i_formation_id == formationId)
		{
			this.ReportFormationLogAsync(quickSelectLogData, this.RefreshAllRoleViewAsync(formationId, needRefreshPosition));
			return;
		}
		if (FormationModel.Instance.GetEditingRoleIdList(formationId).Length == 0)
		{
			this.Presenter.ResetAll();
			return;
		}
		for (int i = 1; i <= 3; i++)
		{
			if (needRefreshPosition == null || Array.IndexOf<int>(needRefreshPosition, i) != -1)
			{
				this.RefreshRoleView(formationId, i);
			}
		}
	}

	// Token: 0x0600AA66 RID: 43622 RVA: 0x00324380 File Offset: 0x00322580
	[NullableContext(0)]
	protected virtual UniTask<long?> RefreshAllRoleViewAsync(int formationId, [Nullable(2)] int[] needRefreshPosition = null)
	{
		FormationFlavorViewBase.<RefreshAllRoleViewAsync>d__33 <RefreshAllRoleViewAsync>d__;
		<RefreshAllRoleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<long?>.Create();
		<RefreshAllRoleViewAsync>d__.<>4__this = this;
		<RefreshAllRoleViewAsync>d__.formationId = formationId;
		<RefreshAllRoleViewAsync>d__.needRefreshPosition = needRefreshPosition;
		<RefreshAllRoleViewAsync>d__.<>1__state = -1;
		<RefreshAllRoleViewAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<RefreshAllRoleViewAsync>d__33>(ref <RefreshAllRoleViewAsync>d__);
		return <RefreshAllRoleViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA67 RID: 43623 RVA: 0x003243D4 File Offset: 0x003225D4
	protected override void RefreshRoleView(int formationId, int position)
	{
		IRoleSlotDisplayData roleSlotDisplayData = this.Provider.BuildSlotDisplayData(formationId, position);
		if (roleSlotDisplayData.ConfigId <= 0)
		{
			this.Presenter.Reset(position);
			return;
		}
		this.Presenter.Refresh(position, roleSlotDisplayData);
	}

	// Token: 0x0600AA68 RID: 43624 RVA: 0x00324414 File Offset: 0x00322614
	protected override void RefreshConfirmButton()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return;
		}
		FormationModel instance = FormationModel.Instance;
		int editFormationId = this.EditFormationId;
		int? currentFormationId = instance.CurrentFormationId;
		bool flag = !(editFormationId == currentFormationId.GetValueOrDefault() & currentFormationId != null);
		bool flag2 = flag;
		if (flag2 && !this.CanUseSpecialTrailRole)
		{
			int[] editingRoleIdList = instance.GetEditingRoleIdList(this.EditFormationId);
			bool flag3 = false;
			for (int i = 0; i < editingRoleIdList.Length; i++)
			{
				if (RoleUtils.IsSpecialTrialRole(editingRoleIdList[i]))
				{
					flag3 = true;
					break;
				}
			}
			flag2 = !flag3;
		}
		base.GetButton(this.Keys.Confirm).SetSelfInteractive(flag2);
		string textTableId = flag ? "EditBattleTeamFight" : "EditBattleTeamFighting";
		LguiUtil.Instance.SetLocalText(base.GetText(this.Keys.ConfirmText), textTableId, Array.Empty<object>());
	}

	// Token: 0x0600AA69 RID: 43625 RVA: 0x003244E7 File Offset: 0x003226E7
	protected override void OnClickConfirm()
	{
		if (this.WaitingClose)
		{
			return;
		}
		if (!this.IsAllowClose())
		{
			return;
		}
		this.RequestOnConfirm();
		this.ShowLoading();
	}

	// Token: 0x0600AA6A RID: 43626 RVA: 0x00324508 File Offset: 0x00322708
	protected override void OnClickClose()
	{
		if (this.WaitingClose)
		{
			return;
		}
		int editFormationId = this.EditFormationId;
		int? currentFormationId = FormationModel.Instance.CurrentFormationId;
		if ((editFormationId == currentFormationId.GetValueOrDefault() & currentFormationId != null) && !this.IsAllowClose())
		{
			return;
		}
		this.RequestOnClose();
		this.ShowLoading();
	}

	// Token: 0x0600AA6B RID: 43627 RVA: 0x00324558 File Offset: 0x00322758
	protected override void OnClickQuickSelect()
	{
		FormationModel instance = FormationModel.Instance;
		if (this.WaitingClose || instance.IsViewSwitching() || UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView))
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int item in instance.GetEditingRoleIdList(this.EditFormationId))
		{
			list.Add(item);
		}
		List<RoleDataBase> roleDataList = RoleModel.Instance.GetRoleDataList(this.CanShowSpecialTrialRole);
		QuickRoleSelectViewData quickRoleSelectViewData = new QuickRoleSelectViewData(EFilterSortGroupId.EditFormation, list.ToArray(), roleDataList);
		quickRoleSelectViewData.CanConfirm = new Func<int[], bool>(base.OnQuickSelectCanConfirm);
		quickRoleSelectViewData.OnConfirm = new Action<int[]>(this.OnQuickSelectConfirm);
		quickRoleSelectViewData.OnBack = new Action(base.OnSelectBack);
		quickRoleSelectViewData.OnHideFinish = new Action(this.OnQuickSelectHideFinished);
		quickRoleSelectViewData.CanSelectRole = new Func<int, int[], bool>(base.OnQuickSelectCanSelect);
		quickRoleSelectViewData.CanUseSpecialTrialRole = this.CanUseSpecialTrailRole;
		UiManager.Instance.OpenView(EUiViewName.QuickRoleSelectView, quickRoleSelectViewData, delegate(bool isSuccess, int viewId)
		{
			if (isSuccess)
			{
				base.AddChildViewById(viewId);
			}
		});
		base.SetCloseButtonVisible(false);
	}

	// Token: 0x0600AA6C RID: 43628 RVA: 0x0032466C File Offset: 0x0032286C
	private void OnQuickSelectHideFinished()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.RoleRootView);
		if (viewByName != null && !viewByName.WaitToDestroy && !viewByName.IsDestroyOrDestroying)
		{
			base.SetCloseButtonVisible(true);
			return;
		}
		base.OnQuickSelectHideFinishCallBack();
		if (this.UiViewSequence != null)
		{
			base.PlayOrReplaySequence(this.UiViewSequence.StartSequenceName, false, null);
		}
	}

	// Token: 0x0600AA6D RID: 43629 RVA: 0x003246D0 File Offset: 0x003228D0
	protected void OnClickPresetForm()
	{
		if (this.WaitingClose || UiManager.Instance.IsViewOpen(EUiViewName.FormationEditView))
		{
			return;
		}
		this.SetFormationEditViewOpen(true);
		IFormationEditViewData param = new IFormationEditViewData
		{
			InitialFormationId = new int?(this.EditFormationId),
			SwitchFormationCallback = new Func<int, bool>(this.OnEditViewSwitchFormation),
			RenameFormationCallback = new Action<int>(this.OnEditViewRenameFormation),
			CloseCallback = new Action(this.OnFormationEditViewClosed),
			ConfirmCallback = new Action(this.OnFormationEditViewConfirm),
			QuickSelectConfirmCallback = new Action<int>(this.PrepareQuickSelectLog)
		};
		UiManager.Instance.OpenView(EUiViewName.FormationEditView, param, delegate(bool isSuccess, int viewId)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			if (isSuccess)
			{
				base.AddChildViewById(viewId);
				return;
			}
			this.SetFormationEditViewOpen(false);
		});
	}

	// Token: 0x0600AA6E RID: 43630 RVA: 0x0032478B File Offset: 0x0032298B
	private void SetFormationEditViewOpen(bool isOpen)
	{
		this.IsFormationEditViewOpen = isOpen;
		this.RefreshFormationEditViewVisibility();
	}

	// Token: 0x0600AA6F RID: 43631 RVA: 0x0032479C File Offset: 0x0032299C
	private void RefreshFormationEditViewVisibility()
	{
		bool flag = !this.IsFormationEditViewOpen;
		this.SetTabVisible(flag);
		bool uiactive = flag && !GameModeModel.Instance.IsMulti;
		base.GetButton(this.Keys.Confirm).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(this.Keys.QuickSelect).RootUIComp.Get().SetUIActive(uiactive);
		this.OnFormationEditViewOpenChanged(this.IsFormationEditViewOpen);
	}

	// Token: 0x0600AA70 RID: 43632 RVA: 0x00324824 File Offset: 0x00322A24
	protected void SetTabVisible(bool visible)
	{
		if (this.IsTabVisible == visible)
		{
			return;
		}
		this.IsTabVisible = visible;
		if (visible)
		{
			this.PlayTabStartSequence();
			return;
		}
		LevelSequencePlayer tabStartSequencePlayer = this.TabStartSequencePlayer;
		if (tabStartSequencePlayer != null)
		{
			tabStartSequencePlayer.StopSequenceByKey("Start", false, true);
		}
		LevelSequencePlayer tabCloseSequencePlayer = this.TabCloseSequencePlayer;
		if (tabCloseSequencePlayer == null)
		{
			return;
		}
		tabCloseSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0600AA71 RID: 43633 RVA: 0x00324884 File Offset: 0x00322A84
	protected void PlayTabStartSequence()
	{
		UUIItem item = base.GetItem(this.Keys.Tab);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		LevelSequencePlayer tabCloseSequencePlayer = this.TabCloseSequencePlayer;
		if (tabCloseSequencePlayer != null)
		{
			tabCloseSequencePlayer.StopSequenceByKey("Close", false, false);
		}
		LevelSequencePlayer tabStartSequencePlayer = this.TabStartSequencePlayer;
		if (tabStartSequencePlayer != null && tabStartSequencePlayer.IsPlayingSequence("Start"))
		{
			this.TabStartSequencePlayer.ReplaySequenceByKey("Start");
			return;
		}
		LevelSequencePlayer tabStartSequencePlayer2 = this.TabStartSequencePlayer;
		if (tabStartSequencePlayer2 == null)
		{
			return;
		}
		tabStartSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600AA72 RID: 43634 RVA: 0x00324910 File Offset: 0x00322B10
	protected virtual void OnFormationEditViewOpenChanged(bool isOpen)
	{
	}

	// Token: 0x0600AA73 RID: 43635 RVA: 0x00324912 File Offset: 0x00322B12
	private void OnFormationEditViewClosed()
	{
		if (!base.IsDestroyOrDestroying)
		{
			this.SetFormationEditViewOpen(false);
		}
	}

	// Token: 0x0600AA74 RID: 43636 RVA: 0x00324923 File Offset: 0x00322B23
	private void OnFormationEditViewConfirm()
	{
		if (!base.IsDestroyOrDestroying)
		{
			this.OnClickConfirm();
		}
	}

	// Token: 0x0600AA75 RID: 43637 RVA: 0x00324933 File Offset: 0x00322B33
	private void OnEditViewRenameFormation(int formationId)
	{
		if (this.EditFormationId == formationId)
		{
			IFormationTabComponent tabComponent = this.TabComponent;
			if (tabComponent == null)
			{
				return;
			}
			tabComponent.RefreshTitleByIndex(formationId - 1);
		}
	}

	// Token: 0x0600AA76 RID: 43638 RVA: 0x00324954 File Offset: 0x00322B54
	protected void OnClickEditFormName()
	{
		if (this.WaitingClose)
		{
			return;
		}
		int formationId = this.EditFormationId;
		FormationController.Instance.OpenRenameFormationInputView(formationId, delegate
		{
			if (this.EditFormationId == formationId)
			{
				IFormationTabComponent tabComponent = this.TabComponent;
				if (tabComponent == null)
				{
					return;
				}
				tabComponent.RefreshTitleByIndex(formationId - 1);
			}
		});
	}

	// Token: 0x0600AA77 RID: 43639 RVA: 0x003249A0 File Offset: 0x00322BA0
	private bool OnEditViewSwitchFormation(int formationId)
	{
		if (this.WaitingClose)
		{
			this.QuickSelectLogData = null;
			return false;
		}
		this.RefreshTeamBattleTips();
		int num = formationId - 1;
		if (this.TabComponent.GetSelectedIndex() == num)
		{
			this.RefreshAllRoleView(formationId, null);
			this.RefreshConfirmButton();
			this.RefreshFormationEditViewVisibility();
			return true;
		}
		this.TabComponent.SelectToggleByIndex(num, false);
		if (this.TabComponent.GetSelectedIndex() != num)
		{
			this.QuickSelectLogData = null;
			return false;
		}
		this.TabComponent.ScrollToToggleByIndex(num);
		this.RefreshFormationEditViewVisibility();
		return true;
	}

	// Token: 0x0600AA78 RID: 43640 RVA: 0x00324A24 File Offset: 0x00322C24
	protected UniTask RequestOnConfirm()
	{
		FormationFlavorViewBase.<RequestOnConfirm>d__51 <RequestOnConfirm>d__;
		<RequestOnConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestOnConfirm>d__.<>4__this = this;
		<RequestOnConfirm>d__.<>1__state = -1;
		<RequestOnConfirm>d__.<>t__builder.Start<FormationFlavorViewBase.<RequestOnConfirm>d__51>(ref <RequestOnConfirm>d__);
		return <RequestOnConfirm>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA79 RID: 43641 RVA: 0x00324A68 File Offset: 0x00322C68
	protected UniTask RequestOnClose()
	{
		FormationFlavorViewBase.<RequestOnClose>d__52 <RequestOnClose>d__;
		<RequestOnClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestOnClose>d__.<>4__this = this;
		<RequestOnClose>d__.<>1__state = -1;
		<RequestOnClose>d__.<>t__builder.Start<FormationFlavorViewBase.<RequestOnClose>d__52>(ref <RequestOnClose>d__);
		return <RequestOnClose>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA7A RID: 43642 RVA: 0x00324AAC File Offset: 0x00322CAC
	protected void ShowLoading()
	{
		if (this.DelayLoadingTimer == null)
		{
			UiLayer.Instance.SetShowMaskLayer("FormationViewClosing", true);
			this.DelayLoadingTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				base.SetCloseButtonVisible(false);
				base.GetItem(this.Keys.Loading).SetUIActive(true);
			}, 500f, null, null, true, 1f);
		}
		if (this.AutoCloseTimer == null)
		{
			this.AutoCloseTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				UiLayer.Instance.SetShowMaskLayer("FormationViewClosing", false);
				this.CloseFormationView();
			}, 30000f, null, null, true, 1f);
		}
	}

	// Token: 0x0600AA7B RID: 43643 RVA: 0x00324B2C File Offset: 0x00322D2C
	protected UniTask WaitEntityAddBeforeClose()
	{
		FormationFlavorViewBase.<WaitEntityAddBeforeClose>d__54 <WaitEntityAddBeforeClose>d__;
		<WaitEntityAddBeforeClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitEntityAddBeforeClose>d__.<>4__this = this;
		<WaitEntityAddBeforeClose>d__.<>1__state = -1;
		<WaitEntityAddBeforeClose>d__.<>t__builder.Start<FormationFlavorViewBase.<WaitEntityAddBeforeClose>d__54>(ref <WaitEntityAddBeforeClose>d__);
		return <WaitEntityAddBeforeClose>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA7C RID: 43644 RVA: 0x00324B6F File Offset: 0x00322D6F
	protected void CloseFormationView()
	{
		if (this.IsResetToBattle)
		{
			UiManager.Instance.ResetToBattleView(null);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600AA7D RID: 43645 RVA: 0x00324B8C File Offset: 0x00322D8C
	protected override bool IsAllowClose()
	{
		FormationModel instance = FormationModel.Instance;
		int[] editingRoleIdList = instance.GetEditingRoleIdList(this.EditFormationId);
		if (editingRoleIdList.Length == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamNoRole", Array.Empty<object>());
			return false;
		}
		bool flag = true;
		foreach (int roleConfigId in editingRoleIdList)
		{
			if (!instance.IsRoleDead(roleConfigId))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditFormationAllDead", Array.Empty<object>());
			return false;
		}
		if (!this.CanUseSpecialTrailRole)
		{
			for (int j = 0; j < editingRoleIdList.Length; j++)
			{
				if (RoleUtils.IsSpecialTrialRole(editingRoleIdList[j]))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x170011CE RID: 4558
	// (get) Token: 0x0600AA7E RID: 43646 RVA: 0x00324C31 File Offset: 0x00322E31
	protected virtual EUiViewName RoleSelectViewName { get; } = EUiViewName.TeamRoleSelectView;

	// Token: 0x0600AA7F RID: 43647 RVA: 0x00324C3C File Offset: 0x00322E3C
	protected override void OnAddRoleButtonClicked(int position)
	{
		if (this.WaitingClose)
		{
			return;
		}
		if (!FormationModel.Instance.IsMyPosition(position))
		{
			ScrollingTipsController.Instance.ShowTipsById("IsNotMyRole", Array.Empty<object>());
			return;
		}
		int num = this.NormalizeEmptySlotPosition(position);
		this.EditPosition = num;
		if (!UiManager.Instance.IsViewShow(this.RoleSelectViewName))
		{
			UiManager.Instance.OpenView(this.RoleSelectViewName, this.GetRoleSelectViewData(), null);
			this.OnEnterRoleSelectScene(num);
		}
		base.SetCloseButtonVisible(false);
	}

	// Token: 0x0600AA80 RID: 43648 RVA: 0x00324CBC File Offset: 0x00322EBC
	private int NormalizeEmptySlotPosition(int position)
	{
		FormationModel instance = FormationModel.Instance;
		if (GameModeModel.Instance.IsMulti || instance.GetEditingRoleId(this.EditFormationId, position) > 0)
		{
			return position;
		}
		for (int i = 1; i < position; i++)
		{
			if (instance.GetEditingRoleId(this.EditFormationId, i) == 0)
			{
				return i;
			}
		}
		return position;
	}

	// Token: 0x0600AA81 RID: 43649 RVA: 0x00324D0C File Offset: 0x00322F0C
	protected override TeamRoleSelectViewData GetRoleSelectViewData()
	{
		FormationModel instance = FormationModel.Instance;
		List<RoleDataBase> roleDataList = RoleModel.Instance.GetRoleDataList(this.CanShowSpecialTrialRole);
		int editingRoleId = instance.GetEditingRoleId(this.EditFormationId, this.EditPosition);
		TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, editingRoleId, roleDataList, new Action<int>(this.OnEnsureFormation), new Action(base.OnSelectBack), new int?(this.EditPosition), null);
		teamRoleSelectViewData.SetGetConfirmButtonEnableFunction((int roleId) => this.Validator.IsConfirmButtonEnable(roleId, this.EditFormationId, this.EditPosition));
		teamRoleSelectViewData.SetGetConfirmButtonTextFunction((int roleId) => this.Validator.GetConfirmButtonTextId(roleId, this.EditFormationId, this.EditPosition));
		teamRoleSelectViewData.SetHideFinishCallBack(delegate
		{
			this.OnRefreshRoleView(null);
		});
		teamRoleSelectViewData.SetConfirmCheckFunction((int roleId) => this.Validator.ConfirmCheck(roleId, this.EditFormationId, this.EditPosition));
		teamRoleSelectViewData.IsNeedRevive = ((int roleId) => this.Validator.IsNeedRevive(roleId, this.EditFormationId));
		teamRoleSelectViewData.CanJoinTeam = ((int roleId) => this.Validator.CanJoinTeam(roleId, this.EditFormationId));
		teamRoleSelectViewData.CanUseSpecialTrialRole = this.CanUseSpecialTrailRole;
		teamRoleSelectViewData.FormationRoleList = instance.GetEditingRoleIdList(this.EditFormationId);
		return teamRoleSelectViewData;
	}

	// Token: 0x0600AA82 RID: 43650 RVA: 0x00324E04 File Offset: 0x00323004
	protected unsafe override void OnEnsureFormation(int roleId)
	{
		base.SetCloseButtonVisible(true);
		this.OnExitRoleSelectScene();
		FormationModel instance = FormationModel.Instance;
		int editingRolePosition = instance.GetEditingRolePosition(this.EditFormationId, roleId);
		int editPosition = this.EditPosition;
		string str = "[" + base.GetType().Name + "]";
		if (!instance.IsInEditingFormation(this.EditFormationId, roleId))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.SYB;
			string message = str + " 编队角色加入";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("position", editPosition);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", roleId);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			instance.SetEditingRoleId(this.EditFormationId, this.EditPosition, roleId, true);
			base.PlayJoinTeamAudio(roleId);
			return;
		}
		if (instance.GetEditingRoleId(this.EditFormationId, editPosition) == 0)
		{
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Formation;
			ELogAuthor author2 = ELogAuthor.SYB;
			string message2 = str + " 编队角色换下";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("position", editingRolePosition);
			instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			instance.SetEditingRoleId(this.EditFormationId, editingRolePosition, 0, true);
			return;
		}
		if (editingRolePosition == editPosition)
		{
			Log instance4 = Log.Instance;
			ELogModule module3 = ELogModule.Formation;
			ELogAuthor author3 = ELogAuthor.SYB;
			string message3 = str + " 编队角色位置相同,换下";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("position", editPosition);
			instance4.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			instance.SetEditingRoleId(this.EditFormationId, editPosition, 0, true);
			return;
		}
		int editingRoleId = instance.GetEditingRoleId(this.EditFormationId, editPosition);
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, str + " 编队角色更换", default(ReadOnlySpan<ValueTuple<string, object>>));
		instance.SetEditingRoleId(this.EditFormationId, editPosition, roleId, true);
		instance.SetEditingRoleId(this.EditFormationId, editingRolePosition, editingRoleId, true);
	}

	// Token: 0x0600AA83 RID: 43651 RVA: 0x00324FD4 File Offset: 0x003231D4
	protected override void OnQuickSelectConfirm(int[] roleIdList)
	{
		base.SetCloseButtonVisible(true);
		FormationModel instance = FormationModel.Instance;
		for (int i = 0; i < 3; i++)
		{
			int roleId = (i < roleIdList.Length) ? roleIdList[i] : 0;
			int editPosition = i + 1;
			instance.SetEditingRoleId(this.EditFormationId, editPosition, roleId, false);
		}
		this.PrepareQuickSelectLog(this.EditFormationId);
	}

	// Token: 0x0600AA84 RID: 43652 RVA: 0x00325028 File Offset: 0x00323228
	protected override bool IsCurrentTab(int formationId)
	{
		int? currentFormationId = FormationModel.Instance.CurrentFormationId;
		return formationId == currentFormationId.GetValueOrDefault() & currentFormationId != null;
	}

	// Token: 0x0600AA85 RID: 43653 RVA: 0x00325054 File Offset: 0x00323254
	private void RefreshTeamBattleTips()
	{
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		for (int i = 1; i <= maxFormationId; i++)
		{
			IFormationTabComponent tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				EditFormationTabItem tabItemByIndex = tabComponent.GetTabItemByIndex(i - 1);
				if (tabItemByIndex != null)
				{
					tabItemByIndex.ShowTeamBattleTips(this.IsCurrentTab(i));
				}
			}
		}
	}

	// Token: 0x0600AA86 RID: 43654 RVA: 0x003250A0 File Offset: 0x003232A0
	private void CreateFormationSwitchToggle()
	{
		int? descToggleItem = this.Keys.DescToggleItem;
		if (descToggleItem == null)
		{
			return;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(descToggleItem.Value);
		if (extendToggle == null)
		{
			return;
		}
		if (!Info.Instance.IsLowMemoryDevice)
		{
			this.FormationSwitchToggle = extendToggle;
			this.FormationSwitchToggle.OnStateChange.Add(new Action<EToggleState>(this.OnFormationSwitchToggleStateChange));
			this.RefreshFormationSwitchToggleState();
			return;
		}
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(false);
	}

	// Token: 0x0600AA87 RID: 43655 RVA: 0x00325124 File Offset: 0x00323324
	private void RefreshFormationSwitchToggleState()
	{
		EToggleState state = this.IsFormation3DView() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		UUIExtendToggle formationSwitchToggle = this.FormationSwitchToggle;
		if (formationSwitchToggle == null)
		{
			return;
		}
		formationSwitchToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0600AA88 RID: 43656 RVA: 0x00325153 File Offset: 0x00323353
	private bool IsFormation3DView()
	{
		return this.ViewInfo.Name == EUiViewName.Formation3DView;
	}

	// Token: 0x0600AA89 RID: 43657 RVA: 0x0032516C File Offset: 0x0032336C
	private void OnFormationSwitchToggleStateChange(EToggleState state)
	{
		if (this.WaitingClose || FormationModel.Instance.IsViewSwitching() || state == EToggleState.ETT_UnDetermined)
		{
			this.RefreshFormationSwitchToggleState();
			return;
		}
		bool flag = state == EToggleState.ETT_UnChecked;
		if (flag == this.IsFormation3DView())
		{
			return;
		}
		this.SwitchFormationView(flag);
	}

	// Token: 0x0600AA8A RID: 43658 RVA: 0x003251AE File Offset: 0x003233AE
	private void SwitchFormationView(bool use3DView)
	{
		this.SwitchFormationViewAsync(use3DView);
	}

	// Token: 0x0600AA8B RID: 43659 RVA: 0x003251B8 File Offset: 0x003233B8
	private UniTask SwitchFormationViewAsync(bool use3DView)
	{
		FormationFlavorViewBase.<SwitchFormationViewAsync>d__72 <SwitchFormationViewAsync>d__;
		<SwitchFormationViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchFormationViewAsync>d__.<>4__this = this;
		<SwitchFormationViewAsync>d__.use3DView = use3DView;
		<SwitchFormationViewAsync>d__.<>1__state = -1;
		<SwitchFormationViewAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<SwitchFormationViewAsync>d__72>(ref <SwitchFormationViewAsync>d__);
		return <SwitchFormationViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA8C RID: 43660 RVA: 0x00325204 File Offset: 0x00323404
	private void ReportSwitchLog()
	{
		Team3DSwitchLogData openLogData = this.OpenLogData;
		if (openLogData == null)
		{
			return;
		}
		this.OpenLogData = null;
		openLogData.i_cost_time = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.ViewOpenStartTimeMs);
		this.ReportFormationLogAsync(openLogData, this.InitialRoleLoadPromise);
	}

	// Token: 0x0600AA8D RID: 43661 RVA: 0x0032524C File Offset: 0x0032344C
	private void PrepareQuickSelectLog(int formationId)
	{
		this.QuickSelectLogData = this.CreateFormationLogData(3, formationId);
	}

	// Token: 0x0600AA8E RID: 43662 RVA: 0x0032525C File Offset: 0x0032345C
	private Team3DSwitchLogData CreateFormationLogData(int type, int formationId)
	{
		Team3DSwitchLogData team3DSwitchLogData = new Team3DSwitchLogData();
		team3DSwitchLogData.i_type = type;
		team3DSwitchLogData.i_formation_id = formationId;
		List<int> list = new List<int>();
		for (int i = 1; i <= 3; i++)
		{
			int configId = this.Provider.BuildSlotDisplayData(formationId, i).ConfigId;
			if (configId > 0)
			{
				list.Add(configId);
			}
		}
		team3DSwitchLogData.s_roles = string.Join<int>(",", list);
		return team3DSwitchLogData;
	}

	// Token: 0x0600AA8F RID: 43663 RVA: 0x003252C0 File Offset: 0x003234C0
	[NullableContext(0)]
	private UniTask<long?> WaitRoleLoadAsync(UniTask<long?> roleLoadPromise)
	{
		FormationFlavorViewBase.<WaitRoleLoadAsync>d__76 <WaitRoleLoadAsync>d__;
		<WaitRoleLoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<long?>.Create();
		<WaitRoleLoadAsync>d__.roleLoadPromise = roleLoadPromise;
		<WaitRoleLoadAsync>d__.<>1__state = -1;
		<WaitRoleLoadAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<WaitRoleLoadAsync>d__76>(ref <WaitRoleLoadAsync>d__);
		return <WaitRoleLoadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA90 RID: 43664 RVA: 0x00325304 File Offset: 0x00323504
	[NullableContext(0)]
	private UniTask ReportFormationLogAsync([Nullable(1)] Team3DSwitchLogData logData, UniTask<long?> roleLoadPromise)
	{
		FormationFlavorViewBase.<ReportFormationLogAsync>d__77 <ReportFormationLogAsync>d__;
		<ReportFormationLogAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReportFormationLogAsync>d__.<>4__this = this;
		<ReportFormationLogAsync>d__.logData = logData;
		<ReportFormationLogAsync>d__.roleLoadPromise = roleLoadPromise;
		<ReportFormationLogAsync>d__.<>1__state = -1;
		<ReportFormationLogAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<ReportFormationLogAsync>d__77>(ref <ReportFormationLogAsync>d__);
		return <ReportFormationLogAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040062E3 RID: 25315
	protected int GoBattleFormationId = -1;

	// Token: 0x040062E4 RID: 25316
	protected bool IsResetToBattle = true;

	// Token: 0x040062E5 RID: 25317
	[Nullable(2)]
	protected TimerHandle DelayLoadingTimer;

	// Token: 0x040062E6 RID: 25318
	[Nullable(2)]
	protected TimerHandle AutoCloseTimer;

	// Token: 0x040062E7 RID: 25319
	[Nullable(2)]
	private UUIExtendToggle FormationSwitchToggle;

	// Token: 0x040062E8 RID: 25320
	private bool HasHandledInitial3dRoleViewAsync;

	// Token: 0x040062E9 RID: 25321
	private bool HasRefreshedRoleViewBeforeShowAsync;

	// Token: 0x040062EA RID: 25322
	private bool IsFormationEditViewOpen;

	// Token: 0x040062EB RID: 25323
	[Nullable(2)]
	private LevelSequencePlayer TabStartSequencePlayer;

	// Token: 0x040062EC RID: 25324
	[Nullable(2)]
	private LevelSequencePlayer TabCloseSequencePlayer;

	// Token: 0x040062ED RID: 25325
	private bool IsTabVisible = true;

	// Token: 0x040062EE RID: 25326
	private long ViewOpenStartTimeMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();

	// Token: 0x040062EF RID: 25327
	[Nullable(2)]
	private Team3DSwitchLogData OpenLogData;

	// Token: 0x040062F0 RID: 25328
	[Nullable(0)]
	private UniTask<long?> InitialRoleLoadPromise = UniTask.FromResult<long?>(new long?(0L));

	// Token: 0x040062F1 RID: 25329
	[Nullable(2)]
	private Team3DSwitchLogData QuickSelectLogData;
}
