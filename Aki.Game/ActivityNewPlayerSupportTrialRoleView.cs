using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C3 RID: 5059
[NullableContext(2)]
[Nullable(0)]
public class ActivityNewPlayerSupportTrialRoleView : UiViewBase
{
	// Token: 0x06008EAB RID: 36523 RVA: 0x001EC7AA File Offset: 0x001EA9AA
	[NullableContext(1)]
	public ActivityNewPlayerSupportTrialRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008EAC RID: 36524 RVA: 0x001EC7CC File Offset: 0x001EA9CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(16, new Action(this.OnRolePreviewBtnClick)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnSyncLevelBtnClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnRoleTrialConfirmClick)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnRoleFormationClick)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnHelpClick))
		};
	}

	// Token: 0x06008EAD RID: 36525 RVA: 0x001ECA18 File Offset: 0x001EAC18
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008EAE RID: 36526 RVA: 0x001ECA5C File Offset: 0x001EAC5C
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer = null;
		this.LoadingSequencePlayer = null;
		UUIItem item = base.GetItem(3);
		AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
		if (auibaseActor != null)
		{
			auibaseActor.OnSequencePlayEvent.Unbind();
		}
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Unbind();
		}
		this.RoleSpineItemMap.Clear();
		this.DestroyTimer();
	}

	// Token: 0x06008EAF RID: 36527 RVA: 0x001ECAC6 File Offset: 0x001EACC6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCurTrialRoleGroupChanged, new Action<int?, int>(this.OnCurTrialRoleGroupChanged));
		EventSystem.Instance.Add(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x06008EB0 RID: 36528 RVA: 0x001ECB00 File Offset: 0x001EAD00
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCurTrialRoleGroupChanged, new Action<int?, int>(this.OnCurTrialRoleGroupChanged));
		EventSystem.Instance.Remove(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x06008EB1 RID: 36529 RVA: 0x001ECB3C File Offset: 0x001EAD3C
	private UniTask InitTrialRoleListComponent()
	{
		ActivityNewPlayerSupportTrialRoleView.<InitTrialRoleListComponent>d__21 <InitTrialRoleListComponent>d__;
		<InitTrialRoleListComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTrialRoleListComponent>d__.<>4__this = this;
		<InitTrialRoleListComponent>d__.<>1__state = -1;
		<InitTrialRoleListComponent>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<InitTrialRoleListComponent>d__21>(ref <InitTrialRoleListComponent>d__);
		return <InitTrialRoleListComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06008EB2 RID: 36530 RVA: 0x001ECB80 File Offset: 0x001EAD80
	private void InitCommonTabTitle()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(this.ViewModel.CaptionText);
		this.CaptionItem.SetTitleIcon(this.ViewModel.CaptionIcon);
	}

	// Token: 0x06008EB3 RID: 36531 RVA: 0x001ECBE4 File Offset: 0x001EADE4
	private void InitSequence()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		(base.GetItem(3).GetOwner() as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnLevelUpSequenceEvent));
		this.LoadingSequencePlayer = new UiSequencePlayer(base.GetItem(18));
	}

	// Token: 0x06008EB4 RID: 36532 RVA: 0x001ECC58 File Offset: 0x001EAE58
	private void OnClickCloseButton()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06008EB5 RID: 36533 RVA: 0x001ECC6C File Offset: 0x001EAE6C
	private void OnTrialRoleItemSelect(int groupId)
	{
		TrialRoleGroupData trialRoleByGroupId = this.ViewModel.GetTrialRoleByGroupId(groupId);
		if (trialRoleByGroupId == null)
		{
			return;
		}
		this.TrialRoleGroupData = trialRoleByGroupId;
		this.RefreshRoleItemAndViewAsync();
	}

	// Token: 0x06008EB6 RID: 36534 RVA: 0x001ECC98 File Offset: 0x001EAE98
	private UniTask RefreshRoleItemAndViewAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleItemAndViewAsync>d__26 <RefreshRoleItemAndViewAsync>d__;
		<RefreshRoleItemAndViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleItemAndViewAsync>d__.<>4__this = this;
		<RefreshRoleItemAndViewAsync>d__.<>1__state = -1;
		<RefreshRoleItemAndViewAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleItemAndViewAsync>d__26>(ref <RefreshRoleItemAndViewAsync>d__);
		return <RefreshRoleItemAndViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008EB7 RID: 36535 RVA: 0x001ECCDC File Offset: 0x001EAEDC
	private void OnCurTrialRoleGroupChanged(int? preGroupId, int curGroupId)
	{
		int trialRoleId = this.TrialRoleGroupData.TrialRoleId;
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		if (((currentFormationData != null) ? currentFormationData.RoleIdList : null).Contains(trialRoleId))
		{
			this.RefreshCurTrialRoleGroupAsync();
			return;
		}
		this.RefreshCurTrialRoleGroup();
	}

	// Token: 0x06008EB8 RID: 36536 RVA: 0x001ECD24 File Offset: 0x001EAF24
	private void OnGroupTrialRoleChanged(int preRoleId, int curRoleId, int groupId)
	{
		int trialRoleId = this.TrialRoleGroupData.TrialRoleId;
		bool playLvUpAnim = trialRoleId != preRoleId && trialRoleId == curRoleId;
		this.RefreshRoleView(playLvUpAnim);
	}

	// Token: 0x06008EB9 RID: 36537 RVA: 0x001ECD50 File Offset: 0x001EAF50
	private void OnRolePreviewBtnClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (TrialRoleGroupData trialRoleGroupData in this.ViewModel.GetTrialRoleList())
		{
			list.Add(trialRoleGroupData.GetPreviewTrialRoleId());
		}
		TrialRoleGroupData trialRoleGroupData2 = this.TrialRoleGroupData;
		int selectRoleId = (trialRoleGroupData2 != null) ? trialRoleGroupData2.GetPreviewTrialRoleId() : 0;
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, selectRoleId, list, null, null);
	}

	// Token: 0x06008EBA RID: 36538 RVA: 0x001ECDE8 File Offset: 0x001EAFE8
	private void OnSyncLevelBtnClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		if (!TrialRoleModel.Instance.CheckCanOperateTrialRole())
		{
			return;
		}
		TrialRoleGroupData trialRoleGroupData = this.TrialRoleGroupData;
		if (trialRoleGroupData == null || !trialRoleGroupData.CanUpgrade())
		{
			return;
		}
		TrialRoleGroupData trialRoleGroupData2 = this.TrialRoleGroupData;
		int? num = (trialRoleGroupData2 != null) ? new int?(trialRoleGroupData2.TrialRoleId) : null;
		if (num == null)
		{
			return;
		}
		Action<int> requestTrialRoleLvUpFunc = this.ViewModel.GetRequestTrialRoleLvUpFunc();
		if (requestTrialRoleLvUpFunc == null)
		{
			return;
		}
		requestTrialRoleLvUpFunc(num.Value);
	}

	// Token: 0x06008EBB RID: 36539 RVA: 0x001ECE68 File Offset: 0x001EB068
	private void OnRoleTrialConfirmClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		if (!TrialRoleModel.Instance.CheckCanOperateTrialRole())
		{
			return;
		}
		TrialRoleGroupData trialRoleGroupData = this.TrialRoleGroupData;
		int? num = (trialRoleGroupData != null) ? new int?(trialRoleGroupData.TrialRoleId) : null;
		if (num == null)
		{
			return;
		}
		Action<int, Action<int>> requestSetCurUseTrialRoleFunc = this.ViewModel.GetRequestSetCurUseTrialRoleFunc();
		if (requestSetCurUseTrialRoleFunc == null)
		{
			return;
		}
		requestSetCurUseTrialRoleFunc(num.Value, new Action<int>(this.OnSetCurUseTrialRoleCallback));
	}

	// Token: 0x06008EBC RID: 36540 RVA: 0x001ECEE0 File Offset: 0x001EB0E0
	private void OnSetCurUseTrialRoleCallback(int roleId)
	{
		int trialRoleId = this.TrialRoleGroupData.TrialRoleId;
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		if (((currentFormationData != null) ? currentFormationData.RoleIdList : null).Contains(trialRoleId) || ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TrialRoleChooseConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			FormationController.Instance.OpenFormationView(null, null);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06008EBD RID: 36541 RVA: 0x001ECF66 File Offset: 0x001EB166
	private void OnRoleFormationClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		FormationController.Instance.OpenFormationView(null, null);
	}

	// Token: 0x06008EBE RID: 36542 RVA: 0x001ECF7D File Offset: 0x001EB17D
	private void OnHelpClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(this.ViewModel.HelpId);
	}

	// Token: 0x06008EBF RID: 36543 RVA: 0x001ECF9D File Offset: 0x001EB19D
	[NullableContext(1)]
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Role_Switch")
		{
			this.RefreshRoleItem();
		}
	}

	// Token: 0x06008EC0 RID: 36544 RVA: 0x001ECFB4 File Offset: 0x001EB1B4
	[NullableContext(1)]
	private void OnLevelUpSequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Change_Number")
		{
			TrialRoleInfo trialRoleConfig = this.TrialRoleGroupData.TrialRoleConfig;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Text_PlayerLevelNum_Text", new <>z__ReadOnlySingleElementList<object>(trialRoleConfig.Level));
		}
	}

	// Token: 0x06008EC1 RID: 36545 RVA: 0x001ED004 File Offset: 0x001EB204
	private UniTask RefreshRoleItemAsync(bool playSwitchAnim = false)
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleItemAsync>d__37 <RefreshRoleItemAsync>d__;
		<RefreshRoleItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleItemAsync>d__.<>4__this = this;
		<RefreshRoleItemAsync>d__.playSwitchAnim = playSwitchAnim;
		<RefreshRoleItemAsync>d__.<>1__state = -1;
		<RefreshRoleItemAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleItemAsync>d__37>(ref <RefreshRoleItemAsync>d__);
		return <RefreshRoleItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008EC2 RID: 36546 RVA: 0x001ED050 File Offset: 0x001EB250
	private void RefreshRoleItem()
	{
		TrialRoleInfo trialRoleConfig = this.TrialRoleGroupData.TrialRoleConfig;
		foreach (KeyValuePair<int, NewPlayerSupportRoleSpineItem> keyValuePair in this.RoleSpineItemMap)
		{
			int key = keyValuePair.Key;
			keyValuePair.Value.SetUiActive(key == trialRoleConfig.GroupId);
		}
		NewPlayerSupportRoleBaseItem curRoleItem = this.CurRoleItem;
		if (curRoleItem == null)
		{
			return;
		}
		curRoleItem.Update(trialRoleConfig);
	}

	// Token: 0x06008EC3 RID: 36547 RVA: 0x001ED0D8 File Offset: 0x001EB2D8
	private void RefreshRoleView(bool playLvUpAnim = false)
	{
		base.GetItem(18).SetUIActive(false);
		int trialRoleId = this.TrialRoleGroupData.TrialRoleId;
		int trialRoleGroupId = this.TrialRoleGroupData.TrialRoleGroupId;
		int realRoleId = this.TrialRoleGroupData.RealRoleId;
		string roleStand = ActivityRoleTrialConfig.Instance.GetRoleTrialRoleConfigByRoleId(realRoleId).Value.RoleStand;
		UUITexture roleTex = base.GetTexture(2);
		base.SetTextureByPath(roleStand, roleTex, null, delegate(bool _)
		{
			roleTex.SetSizeFromTexture();
		});
		string configColorByRealRoleId = this.GetConfigColorByRealRoleId(realRoleId);
		if (!StringUtils.IsBlank(configColorByRealRoleId))
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetColor(FColor.FromHex(configColorByRealRoleId));
			}
		}
		this.RefreshRoleTagAsync();
		this.RefreshRoleDescAsync();
		bool uiactive = this.TrialRoleGroupData.CanUpgrade();
		bool flag = this.TrialRoleGroupData.IsUnlocked();
		int? curUseTrialRoleId = this.ViewModel.GetCurUseTrialRoleId();
		int num = trialRoleId;
		bool flag2 = curUseTrialRoleId.GetValueOrDefault() == num & curUseTrialRoleId != null;
		base.GetItem(10).SetUIActive(!flag);
		base.GetButton(11).RootUIComp.Get().SetUIActive(uiactive);
		base.GetItem(12).SetUIActive(uiactive);
		base.GetItem(9).SetUIActive(flag && flag2);
		base.GetButton(5).RootUIComp.Get().SetUIActive(flag && flag2);
		base.GetButton(4).RootUIComp.Get().SetUIActive(flag && !flag2);
		if (!flag)
		{
			string trialRoleGroupUnlockDesc = this.ViewModel.GetTrialRoleGroupUnlockDesc(trialRoleGroupId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), trialRoleGroupUnlockDesc, Array.Empty<object>());
		}
		int previewTrialRoleId = this.TrialRoleGroupData.GetPreviewTrialRoleId();
		TrialRoleInfo? trialRoleConfig = TrialRoleConfig.Instance.GetTrialRoleConfig(previewTrialRoleId);
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Text_WorldLevelNum_Text", new <>z__ReadOnlySingleElementList<object>(originWorldLevel));
		if (playLvUpAnim)
		{
			this.SequencePlayer.PlayLevelSequenceByName("Saoguang", false, null, false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Text_PlayerLevelNum_Text", new <>z__ReadOnlySingleElementList<object>(trialRoleConfig.Value.Level));
	}

	// Token: 0x06008EC4 RID: 36548 RVA: 0x001ED33C File Offset: 0x001EB53C
	private UniTask RefreshRoleTagAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleTagAsync>d__40 <RefreshRoleTagAsync>d__;
		<RefreshRoleTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleTagAsync>d__.<>4__this = this;
		<RefreshRoleTagAsync>d__.<>1__state = -1;
		<RefreshRoleTagAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleTagAsync>d__40>(ref <RefreshRoleTagAsync>d__);
		return <RefreshRoleTagAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008EC5 RID: 36549 RVA: 0x001ED380 File Offset: 0x001EB580
	private UniTask RefreshRoleDescAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleDescAsync>d__41 <RefreshRoleDescAsync>d__;
		<RefreshRoleDescAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleDescAsync>d__.<>4__this = this;
		<RefreshRoleDescAsync>d__.<>1__state = -1;
		<RefreshRoleDescAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleDescAsync>d__41>(ref <RefreshRoleDescAsync>d__);
		return <RefreshRoleDescAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008EC6 RID: 36550 RVA: 0x001ED3C4 File Offset: 0x001EB5C4
	private UniTask InitRoleSpineItem()
	{
		ActivityNewPlayerSupportTrialRoleView.<InitRoleSpineItem>d__42 <InitRoleSpineItem>d__;
		<InitRoleSpineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleSpineItem>d__.<>4__this = this;
		<InitRoleSpineItem>d__.<>1__state = -1;
		<InitRoleSpineItem>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<InitRoleSpineItem>d__42>(ref <InitRoleSpineItem>d__);
		return <InitRoleSpineItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008EC7 RID: 36551 RVA: 0x001ED408 File Offset: 0x001EB608
	private UniTask InitRoleCommonItem()
	{
		ActivityNewPlayerSupportTrialRoleView.<InitRoleCommonItem>d__43 <InitRoleCommonItem>d__;
		<InitRoleCommonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleCommonItem>d__.<>4__this = this;
		<InitRoleCommonItem>d__.<>1__state = -1;
		<InitRoleCommonItem>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<InitRoleCommonItem>d__43>(ref <InitRoleCommonItem>d__);
		return <InitRoleCommonItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008EC8 RID: 36552 RVA: 0x001ED44B File Offset: 0x001EB64B
	private void PlaySwitchAnim()
	{
		NewPlayerSupportRoleBaseItem curRoleItem = this.CurRoleItem;
		if (curRoleItem == null)
		{
			return;
		}
		curRoleItem.PlaySwitchSeq();
	}

	// Token: 0x06008EC9 RID: 36553 RVA: 0x001ED460 File Offset: 0x001EB660
	[NullableContext(1)]
	private string GetConfigColorByRealRoleId(int realRoleId)
	{
		string result;
		if (!ActivityNewPlayerSupportDefine.RoleBgColor.TryGetValue(realRoleId, out result))
		{
			return "";
		}
		return result;
	}

	// Token: 0x06008ECA RID: 36554 RVA: 0x001ED483 File Offset: 0x001EB683
	private void RefreshCurTrialRoleGroup()
	{
		this.RefreshRoleView(false);
	}

	// Token: 0x06008ECB RID: 36555 RVA: 0x001ED48C File Offset: 0x001EB68C
	private UniTask RefreshCurTrialRoleGroupAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshCurTrialRoleGroupAsync>d__47 <RefreshCurTrialRoleGroupAsync>d__;
		<RefreshCurTrialRoleGroupAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurTrialRoleGroupAsync>d__.<>4__this = this;
		<RefreshCurTrialRoleGroupAsync>d__.<>1__state = -1;
		<RefreshCurTrialRoleGroupAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshCurTrialRoleGroupAsync>d__47>(ref <RefreshCurTrialRoleGroupAsync>d__);
		return <RefreshCurTrialRoleGroupAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008ECC RID: 36556 RVA: 0x001ED4D0 File Offset: 0x001EB6D0
	private void ShowLoading()
	{
		if (this.AutoCloseTimer == null)
		{
			base.GetItem(18).SetUIActive(true);
			UiLayer.Instance.SetShowMaskLayer("TrialRoleViewClosing", true);
			this.LoadingSequencePlayer.PlaySequence("Progressing", false, null);
			this.AutoCloseTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				base.GetItem(18).SetUIActive(false);
				UiLayer.Instance.SetShowMaskLayer("TrialRoleViewClosing", false);
			}, (float)this.AutoCloseViewTime, null, null, true, 1f);
		}
	}

	// Token: 0x06008ECD RID: 36557 RVA: 0x001ED548 File Offset: 0x001EB748
	private UniTask WaitEntityLoad()
	{
		ActivityNewPlayerSupportTrialRoleView.<WaitEntityLoad>d__49 <WaitEntityLoad>d__;
		<WaitEntityLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitEntityLoad>d__.<>4__this = this;
		<WaitEntityLoad>d__.<>1__state = -1;
		<WaitEntityLoad>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<WaitEntityLoad>d__49>(ref <WaitEntityLoad>d__);
		return <WaitEntityLoad>d__.<>t__builder.Task;
	}

	// Token: 0x06008ECE RID: 36558 RVA: 0x001ED58B File Offset: 0x001EB78B
	private void DestroyTimer()
	{
		if (this.AutoCloseTimer == null)
		{
			return;
		}
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoCloseTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoCloseTimer);
		}
		this.AutoCloseTimer = null;
	}

	// Token: 0x06008ECF RID: 36559 RVA: 0x001ED5C0 File Offset: 0x001EB7C0
	private bool CanSelectItem()
	{
		return !this.WaitingLoad;
	}

	// Token: 0x04003F1B RID: 16155
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003F1C RID: 16156
	private NewPlayerSupportTrialRoleListComponent TrialRoleListComponent;

	// Token: 0x04003F1D RID: 16157
	private TrialRoleGroupData TrialRoleGroupData;

	// Token: 0x04003F1E RID: 16158
	private NewPlayerSupportRoleCommonItem RoleCommonItem;

	// Token: 0x04003F1F RID: 16159
	[Nullable(1)]
	private readonly Dictionary<int, NewPlayerSupportRoleSpineItem> RoleSpineItemMap = new Dictionary<int, NewPlayerSupportRoleSpineItem>();

	// Token: 0x04003F20 RID: 16160
	private NewPlayerSupportRoleBaseItem CurRoleItem;

	// Token: 0x04003F21 RID: 16161
	private RoleTagMediumIconItem RoleTagItem;

	// Token: 0x04003F22 RID: 16162
	private ActivityRoleDescribeComponent RoleDescComponent;

	// Token: 0x04003F23 RID: 16163
	private NewPlayerSupportTrialRoleViewModel ViewModel;

	// Token: 0x04003F24 RID: 16164
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003F25 RID: 16165
	private bool WaitingLoad;

	// Token: 0x04003F26 RID: 16166
	private TimerHandle AutoCloseTimer;

	// Token: 0x04003F27 RID: 16167
	private readonly int AutoCloseViewTime = 30000;

	// Token: 0x04003F28 RID: 16168
	protected UiSequencePlayer LoadingSequencePlayer;

	// Token: 0x02007A37 RID: 31287
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x040283A7 RID: 164775
		public const int TitleItem = 0;

		// Token: 0x040283A8 RID: 164776
		public const int RoleIconBg = 1;

		// Token: 0x040283A9 RID: 164777
		public const int RoleIcon = 2;

		// Token: 0x040283AA RID: 164778
		public const int RoleSpineItem = 3;

		// Token: 0x040283AB RID: 164779
		public const int RoleTrialConfirmBtn = 4;

		// Token: 0x040283AC RID: 164780
		public const int RoleFormationBtn = 5;

		// Token: 0x040283AD RID: 164781
		public const int LevelTxt = 6;

		// Token: 0x040283AE RID: 164782
		public const int RoleLevelTxt = 7;

		// Token: 0x040283AF RID: 164783
		public const int HelpBtn = 8;

		// Token: 0x040283B0 RID: 164784
		public const int TrialingItem = 9;

		// Token: 0x040283B1 RID: 164785
		public const int LockItem = 10;

		// Token: 0x040283B2 RID: 164786
		public const int SyncLevelBtn = 11;

		// Token: 0x040283B3 RID: 164787
		public const int SyncLevelRedDot = 12;

		// Token: 0x040283B4 RID: 164788
		public const int RoleAttrItem = 13;

		// Token: 0x040283B5 RID: 164789
		public const int RoleTagItem = 14;

		// Token: 0x040283B6 RID: 164790
		public const int RoleListItem = 15;

		// Token: 0x040283B7 RID: 164791
		public const int RolePreviewBtn = 16;

		// Token: 0x040283B8 RID: 164792
		public const int LockTxt = 17;

		// Token: 0x040283B9 RID: 164793
		public const int LoadingItem = 18;
	}
}
