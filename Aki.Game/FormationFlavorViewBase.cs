using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C04 RID: 7172
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
	// Token: 0x0600D646 RID: 54854 RVA: 0x00318CD0 File Offset: 0x00316ED0
	protected FormationFlavorViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011A6 RID: 4518
	// (get) Token: 0x0600D647 RID: 54855 RVA: 0x00318D3F File Offset: 0x00316F3F
	protected override FormationDataProvider Provider { get; } = new FormationDataProvider();

	// Token: 0x170011A7 RID: 4519
	// (get) Token: 0x0600D648 RID: 54856 RVA: 0x00318D47 File Offset: 0x00316F47
	protected override FormationContextValidator Validator { get; } = new FormationContextValidator();

	// Token: 0x170011A8 RID: 4520
	// (get) Token: 0x0600D649 RID: 54857
	protected abstract FormationActionKeys FormationActionKeys { get; }

	// Token: 0x0600D64A RID: 54858
	protected abstract UniTask CreateAllSlotsAsync();

	// Token: 0x0600D64B RID: 54859 RVA: 0x00318D50 File Offset: 0x00316F50
	protected override UniTask OnBeforeStartAsync()
	{
		FormationFlavorViewBase.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationFlavorViewBase.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D64C RID: 54860 RVA: 0x00318D94 File Offset: 0x00316F94
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

	// Token: 0x0600D64D RID: 54861 RVA: 0x00318DE0 File Offset: 0x00316FE0
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

	// Token: 0x0600D64E RID: 54862 RVA: 0x00318ED4 File Offset: 0x003170D4
	protected override void OnStart()
	{
		RoleModel.Instance.StartGamePlayRoleEdit(ESkillBranchCacheType.Normal);
		UUIItem item = base.GetItem(this.Keys.Tab);
		this.TabStartSequencePlayer = new LevelSequencePlayer(item);
		this.TabCloseSequencePlayer = new LevelSequencePlayer(item);
	}

	// Token: 0x0600D64F RID: 54863 RVA: 0x00318F16 File Offset: 0x00317116
	protected override void OnAfterShow()
	{
		FormationModel.Instance.SetViewSwitching(false);
		this.ReportSwitchLog();
	}

	// Token: 0x0600D650 RID: 54864 RVA: 0x00318F2C File Offset: 0x0031712C
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

	// Token: 0x0600D651 RID: 54865 RVA: 0x00318FFC File Offset: 0x003171FC
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

	// Token: 0x0600D652 RID: 54866 RVA: 0x0031901C File Offset: 0x0031721C
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

	// Token: 0x0600D653 RID: 54867 RVA: 0x00319090 File Offset: 0x00317290
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

	// Token: 0x0600D654 RID: 54868 RVA: 0x003190E4 File Offset: 0x003172E4
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

	// Token: 0x0600D655 RID: 54869 RVA: 0x00319124 File Offset: 0x00317324
	protected override void RefreshConfirmButton()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return;
		}
		FormationModel instance = FormationModel.Instance;
		int editFormationId = this.EditFormationId;
		int? currentFormationId = instance.CurrentFormationId;
		bool flag2;
		bool flag = flag2 = !(editFormationId == currentFormationId.GetValueOrDefault() & currentFormationId != null);
		if (flag2 && !this.CanUseSpecialTrailRole)
		{
			flag2 = !instance.GetEditingRoleIdList(this.EditFormationId).Any((int id) => RoleUtils.IsSpecialTrialRole(id));
		}
		base.GetButton(this.Keys.Confirm).SetSelfInteractive(flag2);
		string textTableId = flag ? "EditBattleTeamFight" : "EditBattleTeamFighting";
		LguiUtil.Instance.SetLocalText(base.GetText(this.Keys.ConfirmText), textTableId, Array.Empty<object>());
	}

	// Token: 0x0600D656 RID: 54870 RVA: 0x003191ED File Offset: 0x003173ED
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

	// Token: 0x0600D657 RID: 54871 RVA: 0x00319210 File Offset: 0x00317410
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

	// Token: 0x0600D658 RID: 54872 RVA: 0x00319260 File Offset: 0x00317460
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

	// Token: 0x0600D659 RID: 54873 RVA: 0x00319374 File Offset: 0x00317574
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

	// Token: 0x0600D65A RID: 54874 RVA: 0x003193D8 File Offset: 0x003175D8
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

	// Token: 0x0600D65B RID: 54875 RVA: 0x00319493 File Offset: 0x00317693
	private void SetFormationEditViewOpen(bool isOpen)
	{
		this.IsFormationEditViewOpen = isOpen;
		this.RefreshFormationEditViewVisibility();
	}

	// Token: 0x0600D65C RID: 54876 RVA: 0x003194A4 File Offset: 0x003176A4
	private void RefreshFormationEditViewVisibility()
	{
		bool flag = !this.IsFormationEditViewOpen;
		this.SetTabVisible(flag);
		bool uiactive = flag && !GameModeModel.Instance.IsMulti;
		base.GetButton(this.Keys.Confirm).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(this.Keys.QuickSelect).RootUIComp.Get().SetUIActive(uiactive);
		this.OnFormationEditViewOpenChanged(this.IsFormationEditViewOpen);
	}

	// Token: 0x0600D65D RID: 54877 RVA: 0x0031952C File Offset: 0x0031772C
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

	// Token: 0x0600D65E RID: 54878 RVA: 0x0031958C File Offset: 0x0031778C
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

	// Token: 0x0600D65F RID: 54879 RVA: 0x00319618 File Offset: 0x00317818
	protected virtual void OnFormationEditViewOpenChanged(bool isOpen)
	{
	}

	// Token: 0x0600D660 RID: 54880 RVA: 0x0031961A File Offset: 0x0031781A
	private void OnFormationEditViewClosed()
	{
		if (!base.IsDestroyOrDestroying)
		{
			this.SetFormationEditViewOpen(false);
		}
	}

	// Token: 0x0600D661 RID: 54881 RVA: 0x0031962B File Offset: 0x0031782B
	private void OnFormationEditViewConfirm()
	{
		if (!base.IsDestroyOrDestroying)
		{
			this.OnClickConfirm();
		}
	}

	// Token: 0x0600D662 RID: 54882 RVA: 0x0031963B File Offset: 0x0031783B
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

	// Token: 0x0600D663 RID: 54883 RVA: 0x0031965C File Offset: 0x0031785C
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

	// Token: 0x0600D664 RID: 54884 RVA: 0x003196A8 File Offset: 0x003178A8
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

	// Token: 0x0600D665 RID: 54885 RVA: 0x0031972C File Offset: 0x0031792C
	protected UniTask RequestOnConfirm()
	{
		FormationFlavorViewBase.<RequestOnConfirm>d__51 <RequestOnConfirm>d__;
		<RequestOnConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestOnConfirm>d__.<>4__this = this;
		<RequestOnConfirm>d__.<>1__state = -1;
		<RequestOnConfirm>d__.<>t__builder.Start<FormationFlavorViewBase.<RequestOnConfirm>d__51>(ref <RequestOnConfirm>d__);
		return <RequestOnConfirm>d__.<>t__builder.Task;
	}

	// Token: 0x0600D666 RID: 54886 RVA: 0x00319770 File Offset: 0x00317970
	protected UniTask RequestOnClose()
	{
		FormationFlavorViewBase.<RequestOnClose>d__52 <RequestOnClose>d__;
		<RequestOnClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestOnClose>d__.<>4__this = this;
		<RequestOnClose>d__.<>1__state = -1;
		<RequestOnClose>d__.<>t__builder.Start<FormationFlavorViewBase.<RequestOnClose>d__52>(ref <RequestOnClose>d__);
		return <RequestOnClose>d__.<>t__builder.Task;
	}

	// Token: 0x0600D667 RID: 54887 RVA: 0x003197B4 File Offset: 0x003179B4
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

	// Token: 0x0600D668 RID: 54888 RVA: 0x00319834 File Offset: 0x00317A34
	protected UniTask WaitEntityAddBeforeClose()
	{
		FormationFlavorViewBase.<WaitEntityAddBeforeClose>d__54 <WaitEntityAddBeforeClose>d__;
		<WaitEntityAddBeforeClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitEntityAddBeforeClose>d__.<>4__this = this;
		<WaitEntityAddBeforeClose>d__.<>1__state = -1;
		<WaitEntityAddBeforeClose>d__.<>t__builder.Start<FormationFlavorViewBase.<WaitEntityAddBeforeClose>d__54>(ref <WaitEntityAddBeforeClose>d__);
		return <WaitEntityAddBeforeClose>d__.<>t__builder.Task;
	}

	// Token: 0x0600D669 RID: 54889 RVA: 0x00319877 File Offset: 0x00317A77
	protected void CloseFormationView()
	{
		if (this.IsResetToBattle)
		{
			UiManager.Instance.ResetToBattleView(null);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600D66A RID: 54890 RVA: 0x00319894 File Offset: 0x00317A94
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
			if (editingRoleIdList.Any((int id) => RoleUtils.IsSpecialTrialRole(id)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x170011A9 RID: 4521
	// (get) Token: 0x0600D66B RID: 54891 RVA: 0x00319943 File Offset: 0x00317B43
	protected virtual EUiViewName RoleSelectViewName { get; } = EUiViewName.TeamRoleSelectView;

	// Token: 0x0600D66C RID: 54892 RVA: 0x0031994C File Offset: 0x00317B4C
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

	// Token: 0x0600D66D RID: 54893 RVA: 0x003199CC File Offset: 0x00317BCC
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

	// Token: 0x0600D66E RID: 54894 RVA: 0x00319A1C File Offset: 0x00317C1C
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

	// Token: 0x0600D66F RID: 54895 RVA: 0x00319B14 File Offset: 0x00317D14
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

	// Token: 0x0600D670 RID: 54896 RVA: 0x00319CE4 File Offset: 0x00317EE4
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

	// Token: 0x0600D671 RID: 54897 RVA: 0x00319D38 File Offset: 0x00317F38
	protected override bool IsCurrentTab(int formationId)
	{
		int? currentFormationId = FormationModel.Instance.CurrentFormationId;
		return formationId == currentFormationId.GetValueOrDefault() & currentFormationId != null;
	}

	// Token: 0x0600D672 RID: 54898 RVA: 0x00319D64 File Offset: 0x00317F64
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

	// Token: 0x0600D673 RID: 54899 RVA: 0x00319DB0 File Offset: 0x00317FB0
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

	// Token: 0x0600D674 RID: 54900 RVA: 0x00319E34 File Offset: 0x00318034
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

	// Token: 0x0600D675 RID: 54901 RVA: 0x00319E63 File Offset: 0x00318063
	private bool IsFormation3DView()
	{
		return this.ViewInfo.Name == EUiViewName.Formation3DView;
	}

	// Token: 0x0600D676 RID: 54902 RVA: 0x00319E7C File Offset: 0x0031807C
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

	// Token: 0x0600D677 RID: 54903 RVA: 0x00319EBE File Offset: 0x003180BE
	private void SwitchFormationView(bool use3DView)
	{
		this.SwitchFormationViewAsync(use3DView);
	}

	// Token: 0x0600D678 RID: 54904 RVA: 0x00319EC8 File Offset: 0x003180C8
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

	// Token: 0x0600D679 RID: 54905 RVA: 0x00319F14 File Offset: 0x00318114
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

	// Token: 0x0600D67A RID: 54906 RVA: 0x00319F5C File Offset: 0x0031815C
	private void PrepareQuickSelectLog(int formationId)
	{
		this.QuickSelectLogData = this.CreateFormationLogData(3, formationId);
	}

	// Token: 0x0600D67B RID: 54907 RVA: 0x00319F6C File Offset: 0x0031816C
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

	// Token: 0x0600D67C RID: 54908 RVA: 0x00319FD0 File Offset: 0x003181D0
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

	// Token: 0x0600D67D RID: 54909 RVA: 0x0031A014 File Offset: 0x00318214
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

	// Token: 0x04006211 RID: 25105
	protected int GoBattleFormationId = -1;

	// Token: 0x04006212 RID: 25106
	protected bool IsResetToBattle = true;

	// Token: 0x04006213 RID: 25107
	[Nullable(2)]
	protected TimerHandle DelayLoadingTimer;

	// Token: 0x04006214 RID: 25108
	[Nullable(2)]
	protected TimerHandle AutoCloseTimer;

	// Token: 0x04006215 RID: 25109
	[Nullable(2)]
	private UUIExtendToggle FormationSwitchToggle;

	// Token: 0x04006216 RID: 25110
	private bool HasHandledInitial3dRoleViewAsync;

	// Token: 0x04006217 RID: 25111
	private bool HasRefreshedRoleViewBeforeShowAsync;

	// Token: 0x04006218 RID: 25112
	private bool IsFormationEditViewOpen;

	// Token: 0x04006219 RID: 25113
	[Nullable(2)]
	private LevelSequencePlayer TabStartSequencePlayer;

	// Token: 0x0400621A RID: 25114
	[Nullable(2)]
	private LevelSequencePlayer TabCloseSequencePlayer;

	// Token: 0x0400621B RID: 25115
	private bool IsTabVisible = true;

	// Token: 0x0400621C RID: 25116
	private long ViewOpenStartTimeMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();

	// Token: 0x0400621D RID: 25117
	[Nullable(2)]
	private Team3DSwitchLogData OpenLogData;

	// Token: 0x0400621E RID: 25118
	[Nullable(0)]
	private UniTask<long?> InitialRoleLoadPromise = UniTask.FromResult<long?>(new long?(0L));

	// Token: 0x0400621F RID: 25119
	[Nullable(2)]
	private Team3DSwitchLogData QuickSelectLogData;
}
