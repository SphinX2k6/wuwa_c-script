using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C09 RID: 7177
[NullableContext(1)]
[Nullable(0)]
public abstract class FormationViewBase<[Nullable(0)] TProvider, [Nullable(0)] TValidator, [Nullable(0)] TPresenter> : UiTickViewBase where TProvider : IFormationProvider where TValidator : IFormationValidator where TPresenter : ISlotPresenter
{
	// Token: 0x0600D69C RID: 54940 RVA: 0x0031A1E5 File Offset: 0x003183E5
	protected FormationViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011AA RID: 4522
	// (get) Token: 0x0600D69D RID: 54941
	protected abstract TProvider Provider { get; }

	// Token: 0x170011AB RID: 4523
	// (get) Token: 0x0600D69E RID: 54942
	protected abstract TValidator Validator { get; }

	// Token: 0x170011AC RID: 4524
	// (get) Token: 0x0600D69F RID: 54943
	protected abstract TPresenter Presenter { get; }

	// Token: 0x170011AD RID: 4525
	// (get) Token: 0x0600D6A0 RID: 54944
	protected abstract FormationViewKeys Keys { get; }

	// Token: 0x0600D6A1 RID: 54945 RVA: 0x0031A1FC File Offset: 0x003183FC
	protected void InitCommonStartContext()
	{
		bool flag = InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
		this.CanShowSpecialTrialRole = RoleModel.Instance.CanUseSpecialTrialRole(null);
		this.CanUseSpecialTrailRole = (this.CanShowSpecialTrialRole && !flag);
	}

	// Token: 0x0600D6A2 RID: 54946 RVA: 0x0031A248 File Offset: 0x00318448
	protected void FinalizeStartViewVisibility()
	{
		bool isMulti = GameModeModel.Instance.IsMulti;
		base.GetButton(this.Keys.Confirm).RootUIComp.Get().SetUIActive(!isMulti);
		base.GetButton(this.Keys.QuickSelect).RootUIComp.Get().SetUIActive(!isMulti);
		base.GetItem(this.Keys.Loading).SetUIActive(false);
		this.SetCloseButtonVisible(true);
	}

	// Token: 0x0600D6A3 RID: 54947 RVA: 0x0031A2CC File Offset: 0x003184CC
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

	// Token: 0x0600D6A4 RID: 54948 RVA: 0x0031A310 File Offset: 0x00318510
	protected override void OnTick(float delta)
	{
		TPresenter presenter = this.Presenter;
		presenter.OnTick(delta);
	}

	// Token: 0x0600D6A5 RID: 54949 RVA: 0x0031A334 File Offset: 0x00318534
	protected override void OnHandleLoadScene()
	{
		TPresenter presenter = this.Presenter;
		presenter.OnHandleLoadScene();
	}

	// Token: 0x0600D6A6 RID: 54950 RVA: 0x0031A358 File Offset: 0x00318558
	protected override void OnHandleReleaseScene()
	{
		TPresenter presenter = this.Presenter;
		presenter.OnHandleReleaseScene();
	}

	// Token: 0x0600D6A7 RID: 54951
	[NullableContext(2)]
	protected abstract void OnRefreshRoleView(int[] needRefreshPosition = null);

	// Token: 0x0600D6A8 RID: 54952
	[NullableContext(2)]
	protected abstract void RefreshAllRoleView(int formationId, int[] needRefreshPosition = null);

	// Token: 0x0600D6A9 RID: 54953
	protected abstract void RefreshRoleView(int formationId, int position);

	// Token: 0x0600D6AA RID: 54954
	protected abstract void RefreshConfirmButton();

	// Token: 0x0600D6AB RID: 54955
	protected abstract void OnClickConfirm();

	// Token: 0x0600D6AC RID: 54956
	protected abstract void OnClickClose();

	// Token: 0x0600D6AD RID: 54957
	protected abstract void OnClickQuickSelect();

	// Token: 0x0600D6AE RID: 54958
	protected abstract bool IsAllowClose();

	// Token: 0x0600D6AF RID: 54959 RVA: 0x0031A37C File Offset: 0x0031857C
	protected void SetCloseButtonVisible(bool bVisible)
	{
		UUIItem uuiitem = base.GetButton(this.Keys.Close).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(bVisible);
	}

	// Token: 0x0600D6B0 RID: 54960
	protected abstract void OnAddRoleButtonClicked(int position);

	// Token: 0x0600D6B1 RID: 54961
	protected abstract TeamRoleSelectViewData GetRoleSelectViewData();

	// Token: 0x0600D6B2 RID: 54962
	protected abstract void OnEnsureFormation(int roleId);

	// Token: 0x0600D6B3 RID: 54963 RVA: 0x0031A3BF File Offset: 0x003185BF
	protected void OnSelectBack()
	{
		this.SetCloseButtonVisible(true);
		this.OnExitRoleSelectScene();
	}

	// Token: 0x0600D6B4 RID: 54964 RVA: 0x0031A3CE File Offset: 0x003185CE
	protected virtual void OnEnterRoleSelectScene(int position)
	{
	}

	// Token: 0x0600D6B5 RID: 54965 RVA: 0x0031A3D0 File Offset: 0x003185D0
	protected virtual void OnExitRoleSelectScene()
	{
	}

	// Token: 0x0600D6B6 RID: 54966 RVA: 0x0031A3D4 File Offset: 0x003185D4
	protected bool OnQuickSelectCanConfirm(int[] roleIdList)
	{
		TValidator validator = this.Validator;
		return validator.CanQuickSelectConfirm(roleIdList);
	}

	// Token: 0x0600D6B7 RID: 54967 RVA: 0x0031A3F8 File Offset: 0x003185F8
	protected bool OnQuickSelectCanSelect(int roleId, int[] roleIdList)
	{
		TValidator validator = this.Validator;
		return validator.CanSelectRole(roleId, roleIdList);
	}

	// Token: 0x0600D6B8 RID: 54968
	protected abstract void OnQuickSelectConfirm(int[] roleIdList);

	// Token: 0x0600D6B9 RID: 54969 RVA: 0x0031A41B File Offset: 0x0031861B
	protected void OnQuickSelectHideFinishCallBack()
	{
		this.OnRefreshRoleView(null);
		this.SetCloseButtonVisible(true);
	}

	// Token: 0x0600D6BA RID: 54970 RVA: 0x0031A42C File Offset: 0x0031862C
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

	// Token: 0x0600D6BB RID: 54971 RVA: 0x0031A51C File Offset: 0x0031871C
	protected UniTask CreateAllFormationButtons()
	{
		FormationViewBase<TProvider, TValidator, TPresenter>.<CreateAllFormationButtons>d__41 <CreateAllFormationButtons>d__;
		<CreateAllFormationButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllFormationButtons>d__.<>4__this = this;
		<CreateAllFormationButtons>d__.<>1__state = -1;
		<CreateAllFormationButtons>d__.<>t__builder.Start<FormationViewBase<TProvider, TValidator, TPresenter>.<CreateAllFormationButtons>d__41>(ref <CreateAllFormationButtons>d__);
		return <CreateAllFormationButtons>d__.<>t__builder.Task;
	}

	// Token: 0x0600D6BC RID: 54972 RVA: 0x0031A55F File Offset: 0x0031875F
	protected virtual IFormationTabComponent CreateFormationTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data)
	{
		return new DefaultFormationTabComponent(uiItem, data);
	}

	// Token: 0x0600D6BD RID: 54973
	protected abstract bool IsCurrentTab(int formationId);

	// Token: 0x0600D6BE RID: 54974 RVA: 0x0031A568 File Offset: 0x00318768
	protected EditFormationTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new EditFormationTabItem(true);
	}

	// Token: 0x0600D6BF RID: 54975 RVA: 0x0031A570 File Offset: 0x00318770
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

	// Token: 0x0600D6C0 RID: 54976 RVA: 0x0031A5F4 File Offset: 0x003187F4
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

	// Token: 0x0400622B RID: 25131
	protected int EditFormationId;

	// Token: 0x0400622C RID: 25132
	protected int EditPosition;

	// Token: 0x0400622D RID: 25133
	protected bool WaitingClose;

	// Token: 0x0400622E RID: 25134
	protected bool CanUseSpecialTrailRole = true;

	// Token: 0x0400622F RID: 25135
	protected bool CanShowSpecialTrialRole = true;

	// Token: 0x04006230 RID: 25136
	[Nullable(2)]
	protected IFormationTabComponent TabComponent;
}
