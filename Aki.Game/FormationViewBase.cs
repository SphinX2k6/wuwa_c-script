using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010C8 RID: 4296
[NullableContext(1)]
[Nullable(0)]
public abstract class FormationViewBase<[Nullable(0)] TProvider, [Nullable(0)] TValidator, [Nullable(0)] TPresenter> : UiTickViewBase where TProvider : IFormationProvider where TValidator : IFormationValidator where TPresenter : ISlotPresenter
{
	// Token: 0x0600AAAF RID: 43695 RVA: 0x003254D5 File Offset: 0x003236D5
	protected FormationViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011CF RID: 4559
	// (get) Token: 0x0600AAB0 RID: 43696
	protected abstract TProvider Provider { get; }

	// Token: 0x170011D0 RID: 4560
	// (get) Token: 0x0600AAB1 RID: 43697
	protected abstract TValidator Validator { get; }

	// Token: 0x170011D1 RID: 4561
	// (get) Token: 0x0600AAB2 RID: 43698
	protected abstract TPresenter Presenter { get; }

	// Token: 0x170011D2 RID: 4562
	// (get) Token: 0x0600AAB3 RID: 43699
	protected abstract FormationViewKeys Keys { get; }

	// Token: 0x0600AAB4 RID: 43700 RVA: 0x003254EC File Offset: 0x003236EC
	protected void InitCommonStartContext()
	{
		bool flag = InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
		this.CanShowSpecialTrialRole = RoleModel.Instance.CanUseSpecialTrialRole(null);
		this.CanUseSpecialTrailRole = (this.CanShowSpecialTrialRole && !flag);
	}

	// Token: 0x0600AAB5 RID: 43701 RVA: 0x00325538 File Offset: 0x00323738
	protected void FinalizeStartViewVisibility()
	{
		bool isMulti = GameModeModel.Instance.IsMulti;
		base.GetButton(this.Keys.Confirm).RootUIComp.Get().SetUIActive(!isMulti);
		base.GetButton(this.Keys.QuickSelect).RootUIComp.Get().SetUIActive(!isMulti);
		base.GetItem(this.Keys.Loading).SetUIActive(false);
		this.SetCloseButtonVisible(true);
	}

	// Token: 0x0600AAB6 RID: 43702 RVA: 0x003255BC File Offset: 0x003237BC
	protected override void OnBeforeDestroy()
	{
		TPresenter presenter = this.Presenter;
		presenter.DestroyAll();
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy();
			this.TabComponent = null;
		}
		this.WaitingClose = false;
	}

	// Token: 0x0600AAB7 RID: 43703 RVA: 0x00325600 File Offset: 0x00323800
	protected override void OnTick(float delta)
	{
		TPresenter presenter = this.Presenter;
		presenter.OnTick(delta);
	}

	// Token: 0x0600AAB8 RID: 43704 RVA: 0x00325624 File Offset: 0x00323824
	protected override void OnHandleLoadScene()
	{
		TPresenter presenter = this.Presenter;
		presenter.OnHandleLoadScene();
	}

	// Token: 0x0600AAB9 RID: 43705 RVA: 0x00325648 File Offset: 0x00323848
	protected override void OnHandleReleaseScene()
	{
		TPresenter presenter = this.Presenter;
		presenter.OnHandleReleaseScene();
	}

	// Token: 0x0600AABA RID: 43706
	[NullableContext(2)]
	protected abstract void OnRefreshRoleView(int[] needRefreshPosition = null);

	// Token: 0x0600AABB RID: 43707
	[NullableContext(2)]
	protected abstract void RefreshAllRoleView(int formationId, int[] needRefreshPosition = null);

	// Token: 0x0600AABC RID: 43708
	protected abstract void RefreshRoleView(int formationId, int position);

	// Token: 0x0600AABD RID: 43709
	protected abstract void RefreshConfirmButton();

	// Token: 0x0600AABE RID: 43710
	protected abstract void OnClickConfirm();

	// Token: 0x0600AABF RID: 43711
	protected abstract void OnClickClose();

	// Token: 0x0600AAC0 RID: 43712
	protected abstract void OnClickQuickSelect();

	// Token: 0x0600AAC1 RID: 43713
	protected abstract bool IsAllowClose();

	// Token: 0x0600AAC2 RID: 43714 RVA: 0x0032566C File Offset: 0x0032386C
	protected void SetCloseButtonVisible(bool bVisible)
	{
		UUIItem uuiitem = base.GetButton(this.Keys.Close).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(bVisible);
	}

	// Token: 0x0600AAC3 RID: 43715
	protected abstract void OnAddRoleButtonClicked(int position);

	// Token: 0x0600AAC4 RID: 43716
	protected abstract TeamRoleSelectViewData GetRoleSelectViewData();

	// Token: 0x0600AAC5 RID: 43717
	protected abstract void OnEnsureFormation(int roleId);

	// Token: 0x0600AAC6 RID: 43718 RVA: 0x003256AF File Offset: 0x003238AF
	protected void OnSelectBack()
	{
		this.SetCloseButtonVisible(true);
		this.OnExitRoleSelectScene();
	}

	// Token: 0x0600AAC7 RID: 43719 RVA: 0x003256BE File Offset: 0x003238BE
	protected virtual void OnEnterRoleSelectScene(int position)
	{
	}

	// Token: 0x0600AAC8 RID: 43720 RVA: 0x003256C0 File Offset: 0x003238C0
	protected virtual void OnExitRoleSelectScene()
	{
	}

	// Token: 0x0600AAC9 RID: 43721 RVA: 0x003256C4 File Offset: 0x003238C4
	protected bool OnQuickSelectCanConfirm(int[] roleIdList)
	{
		TValidator validator = this.Validator;
		return validator.CanQuickSelectConfirm(roleIdList, this.EditFormationId);
	}

	// Token: 0x0600AACA RID: 43722 RVA: 0x003256EC File Offset: 0x003238EC
	protected bool OnQuickSelectCanSelect(int roleId, int[] roleIdList)
	{
		TValidator validator = this.Validator;
		return validator.CanSelectRole(roleId, roleIdList);
	}

	// Token: 0x0600AACB RID: 43723
	protected abstract void OnQuickSelectConfirm(int[] roleIdList);

	// Token: 0x0600AACC RID: 43724 RVA: 0x0032570F File Offset: 0x0032390F
	protected void OnQuickSelectHideFinishCallBack()
	{
		this.OnRefreshRoleView(null);
		this.SetCloseButtonVisible(true);
	}

	// Token: 0x0600AACD RID: 43725 RVA: 0x00325720 File Offset: 0x00323920
	protected void PlayJoinTeamAudio(int roleId)
	{
		string str = "[" + base.GetType().Name + "]";
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(roleId, true) : null;
		int? num = (roleDataBase != null) ? new int?(roleDataBase.GetRoleSkinId()) : null;
		if (num == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.SYB;
			string message = str + " PlayJoinTeamAudio 没有皮肤ID";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		AudioConfig instance3 = AudioConfig.Instance;
		RoleSkinAudio? roleSkinAudio;
		string text = (instance3 != null) ? ((instance3.GetRoleConfig(num.Value) != null) ? roleSkinAudio.GetValueOrDefault().JoinTeamEvent : null) : null;
		if (!string.IsNullOrEmpty(text))
		{
			AudioSystem.Instance.PostEvent("play_ui_fx_spl_team_role_choose");
			AudioSystem.Instance.PostEvent(text);
		}
	}

	// Token: 0x0600AACE RID: 43726 RVA: 0x00325810 File Offset: 0x00323A10
	protected UniTask CreateAllFormationButtons()
	{
		FormationViewBase<TProvider, TValidator, TPresenter>.<CreateAllFormationButtons>d__41 <CreateAllFormationButtons>d__;
		<CreateAllFormationButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllFormationButtons>d__.<>4__this = this;
		<CreateAllFormationButtons>d__.<>1__state = -1;
		<CreateAllFormationButtons>d__.<>t__builder.Start<FormationViewBase<TProvider, TValidator, TPresenter>.<CreateAllFormationButtons>d__41>(ref <CreateAllFormationButtons>d__);
		return <CreateAllFormationButtons>d__.<>t__builder.Task;
	}

	// Token: 0x0600AACF RID: 43727 RVA: 0x00325853 File Offset: 0x00323A53
	protected virtual IFormationTabComponent CreateFormationTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data)
	{
		return new DefaultFormationTabComponent(uiItem, data);
	}

	// Token: 0x0600AAD0 RID: 43728
	protected abstract bool IsCurrentTab(int formationId);

	// Token: 0x0600AAD1 RID: 43729 RVA: 0x0032585C File Offset: 0x00323A5C
	protected EditFormationTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new EditFormationTabItem(true);
	}

	// Token: 0x0600AAD2 RID: 43730 RVA: 0x00325864 File Offset: 0x00323A64
	protected CommonTabData GetCommonData(int index)
	{
		string resourceId = FormationDefine.FormationIndexSprites[index];
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		int num = index + 1;
		CommonTabTitleData commonTabTitleData = new CommonTabTitleData(TextConfig.Instance.GetTextContentIdById("TeamText"), new object[]
		{
			num
		});
		CommonTabTitleData commonTabTitleData2 = commonTabTitleData;
		FormationData formationData = FormationModel.Instance.GetFormationData(num);
		commonTabTitleData2.RawText = ((formationData != null) ? formationData.Name : null);
		CommonTabData commonTabData = new CommonTabData(resourcePath, commonTabTitleData, null);
		commonTabData.SetSmallIcon(UiResourceConfig.Instance.GetResourcePath("SP_TeamTitle"));
		return commonTabData;
	}

	// Token: 0x0600AAD3 RID: 43731 RVA: 0x003258E8 File Offset: 0x00323AE8
	protected virtual void OnFormationButtonClicked(int index)
	{
		if (this.WaitingClose)
		{
			return;
		}
		int num = index + 1;
		if (num == this.EditFormationId)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[" + base.GetType().Name + "] 当点击编队按钮时";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formationId", num);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.RefreshAllRoleView(num, null);
		this.EditFormationId = num;
		this.RefreshConfirmButton();
	}

	// Token: 0x040062FD RID: 25341
	protected int EditFormationId;

	// Token: 0x040062FE RID: 25342
	protected int EditPosition;

	// Token: 0x040062FF RID: 25343
	protected bool WaitingClose;

	// Token: 0x04006300 RID: 25344
	protected bool CanUseSpecialTrailRole = true;

	// Token: 0x04006301 RID: 25345
	protected bool CanShowSpecialTrialRole = true;

	// Token: 0x04006302 RID: 25346
	[Nullable(2)]
	protected IFormationTabComponent TabComponent;
}
