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

// Token: 0x02000877 RID: 2167
[NullableContext(2)]
[Nullable(0)]
public class ActivityNewPlayerSupportTrialRoleView : UiViewBase
{
	// Token: 0x06006240 RID: 25152 RVA: 0x001F52CA File Offset: 0x001F34CA
	[NullableContext(1)]
	public ActivityNewPlayerSupportTrialRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006241 RID: 25153 RVA: 0x001F52EC File Offset: 0x001F34EC
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

	// Token: 0x06006242 RID: 25154 RVA: 0x001F5538 File Offset: 0x001F3738
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x001F557C File Offset: 0x001F377C
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

	// Token: 0x06006244 RID: 25156 RVA: 0x001F55E6 File Offset: 0x001F37E6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCurTrialRoleGroupChanged, new Action<int?, int>(this.OnCurTrialRoleGroupChanged));
		EventSystem.Instance.Add(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x001F5620 File Offset: 0x001F3820
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCurTrialRoleGroupChanged, new Action<int?, int>(this.OnCurTrialRoleGroupChanged));
		EventSystem.Instance.Remove(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x06006246 RID: 25158 RVA: 0x001F565C File Offset: 0x001F385C
	private UniTask InitTrialRoleListComponent()
	{
		ActivityNewPlayerSupportTrialRoleView.<InitTrialRoleListComponent>d__21 <InitTrialRoleListComponent>d__;
		<InitTrialRoleListComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTrialRoleListComponent>d__.<>4__this = this;
		<InitTrialRoleListComponent>d__.<>1__state = -1;
		<InitTrialRoleListComponent>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<InitTrialRoleListComponent>d__21>(ref <InitTrialRoleListComponent>d__);
		return <InitTrialRoleListComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06006247 RID: 25159 RVA: 0x001F56A0 File Offset: 0x001F38A0
	private void InitCommonTabTitle()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(this.ViewModel.CaptionText);
		this.CaptionItem.SetTitleIcon(this.ViewModel.CaptionIcon);
	}

	// Token: 0x06006248 RID: 25160 RVA: 0x001F5704 File Offset: 0x001F3904
	private void InitSequence()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		(base.GetItem(3).GetOwner() as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnLevelUpSequenceEvent));
		this.LoadingSequencePlayer = new UiSequencePlayer(base.GetItem(18));
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x001F5778 File Offset: 0x001F3978
	private void OnClickCloseButton()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600624A RID: 25162 RVA: 0x001F578C File Offset: 0x001F398C
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

	// Token: 0x0600624B RID: 25163 RVA: 0x001F57B8 File Offset: 0x001F39B8
	private UniTask RefreshRoleItemAndViewAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleItemAndViewAsync>d__26 <RefreshRoleItemAndViewAsync>d__;
		<RefreshRoleItemAndViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleItemAndViewAsync>d__.<>4__this = this;
		<RefreshRoleItemAndViewAsync>d__.<>1__state = -1;
		<RefreshRoleItemAndViewAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleItemAndViewAsync>d__26>(ref <RefreshRoleItemAndViewAsync>d__);
		return <RefreshRoleItemAndViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x001F57FC File Offset: 0x001F39FC
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

	// Token: 0x0600624D RID: 25165 RVA: 0x001F5844 File Offset: 0x001F3A44
	private void OnGroupTrialRoleChanged(int preRoleId, int curRoleId, int groupId)
	{
		int trialRoleId = this.TrialRoleGroupData.TrialRoleId;
		bool playLvUpAnim = trialRoleId != preRoleId && trialRoleId == curRoleId;
		this.RefreshRoleView(playLvUpAnim);
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x001F5870 File Offset: 0x001F3A70
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

	// Token: 0x0600624F RID: 25167 RVA: 0x001F5908 File Offset: 0x001F3B08
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

	// Token: 0x06006250 RID: 25168 RVA: 0x001F5988 File Offset: 0x001F3B88
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

	// Token: 0x06006251 RID: 25169 RVA: 0x001F5A00 File Offset: 0x001F3C00
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

	// Token: 0x06006252 RID: 25170 RVA: 0x001F5A86 File Offset: 0x001F3C86
	private void OnRoleFormationClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		FormationController.Instance.OpenFormationView(null, null);
	}

	// Token: 0x06006253 RID: 25171 RVA: 0x001F5A9D File Offset: 0x001F3C9D
	private void OnHelpClick()
	{
		if (this.WaitingLoad)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(this.ViewModel.HelpId);
	}

	// Token: 0x06006254 RID: 25172 RVA: 0x001F5ABD File Offset: 0x001F3CBD
	[NullableContext(1)]
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Role_Switch")
		{
			this.RefreshRoleItem();
		}
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x001F5AD4 File Offset: 0x001F3CD4
	[NullableContext(1)]
	private void OnLevelUpSequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Change_Number")
		{
			TrialRoleInfo trialRoleConfig = this.TrialRoleGroupData.TrialRoleConfig;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Text_PlayerLevelNum_Text", new <>z__ReadOnlySingleElementList<object>(trialRoleConfig.Level));
		}
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x001F5B24 File Offset: 0x001F3D24
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

	// Token: 0x06006257 RID: 25175 RVA: 0x001F5B70 File Offset: 0x001F3D70
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

	// Token: 0x06006258 RID: 25176 RVA: 0x001F5BF8 File Offset: 0x001F3DF8
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

	// Token: 0x06006259 RID: 25177 RVA: 0x001F5E5C File Offset: 0x001F405C
	private UniTask RefreshRoleTagAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleTagAsync>d__40 <RefreshRoleTagAsync>d__;
		<RefreshRoleTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleTagAsync>d__.<>4__this = this;
		<RefreshRoleTagAsync>d__.<>1__state = -1;
		<RefreshRoleTagAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleTagAsync>d__40>(ref <RefreshRoleTagAsync>d__);
		return <RefreshRoleTagAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x001F5EA0 File Offset: 0x001F40A0
	private UniTask RefreshRoleDescAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshRoleDescAsync>d__41 <RefreshRoleDescAsync>d__;
		<RefreshRoleDescAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleDescAsync>d__.<>4__this = this;
		<RefreshRoleDescAsync>d__.<>1__state = -1;
		<RefreshRoleDescAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshRoleDescAsync>d__41>(ref <RefreshRoleDescAsync>d__);
		return <RefreshRoleDescAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x001F5EE4 File Offset: 0x001F40E4
	private UniTask InitRoleSpineItem()
	{
		ActivityNewPlayerSupportTrialRoleView.<InitRoleSpineItem>d__42 <InitRoleSpineItem>d__;
		<InitRoleSpineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleSpineItem>d__.<>4__this = this;
		<InitRoleSpineItem>d__.<>1__state = -1;
		<InitRoleSpineItem>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<InitRoleSpineItem>d__42>(ref <InitRoleSpineItem>d__);
		return <InitRoleSpineItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600625C RID: 25180 RVA: 0x001F5F28 File Offset: 0x001F4128
	private UniTask InitRoleCommonItem()
	{
		ActivityNewPlayerSupportTrialRoleView.<InitRoleCommonItem>d__43 <InitRoleCommonItem>d__;
		<InitRoleCommonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleCommonItem>d__.<>4__this = this;
		<InitRoleCommonItem>d__.<>1__state = -1;
		<InitRoleCommonItem>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<InitRoleCommonItem>d__43>(ref <InitRoleCommonItem>d__);
		return <InitRoleCommonItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600625D RID: 25181 RVA: 0x001F5F6B File Offset: 0x001F416B
	private void PlaySwitchAnim()
	{
		NewPlayerSupportRoleBaseItem curRoleItem = this.CurRoleItem;
		if (curRoleItem == null)
		{
			return;
		}
		curRoleItem.PlaySwitchSeq();
	}

	// Token: 0x0600625E RID: 25182 RVA: 0x001F5F80 File Offset: 0x001F4180
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

	// Token: 0x0600625F RID: 25183 RVA: 0x001F5FA3 File Offset: 0x001F41A3
	private void RefreshCurTrialRoleGroup()
	{
		this.RefreshRoleView(false);
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x001F5FAC File Offset: 0x001F41AC
	private UniTask RefreshCurTrialRoleGroupAsync()
	{
		ActivityNewPlayerSupportTrialRoleView.<RefreshCurTrialRoleGroupAsync>d__47 <RefreshCurTrialRoleGroupAsync>d__;
		<RefreshCurTrialRoleGroupAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurTrialRoleGroupAsync>d__.<>4__this = this;
		<RefreshCurTrialRoleGroupAsync>d__.<>1__state = -1;
		<RefreshCurTrialRoleGroupAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<RefreshCurTrialRoleGroupAsync>d__47>(ref <RefreshCurTrialRoleGroupAsync>d__);
		return <RefreshCurTrialRoleGroupAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x001F5FF0 File Offset: 0x001F41F0
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

	// Token: 0x06006262 RID: 25186 RVA: 0x001F6068 File Offset: 0x001F4268
	private UniTask WaitEntityLoad()
	{
		ActivityNewPlayerSupportTrialRoleView.<WaitEntityLoad>d__49 <WaitEntityLoad>d__;
		<WaitEntityLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitEntityLoad>d__.<>4__this = this;
		<WaitEntityLoad>d__.<>1__state = -1;
		<WaitEntityLoad>d__.<>t__builder.Start<ActivityNewPlayerSupportTrialRoleView.<WaitEntityLoad>d__49>(ref <WaitEntityLoad>d__);
		return <WaitEntityLoad>d__.<>t__builder.Task;
	}

	// Token: 0x06006263 RID: 25187 RVA: 0x001F60AB File Offset: 0x001F42AB
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

	// Token: 0x06006264 RID: 25188 RVA: 0x001F60E0 File Offset: 0x001F42E0
	private bool CanSelectItem()
	{
		return !this.WaitingLoad;
	}

	// Token: 0x04003FB3 RID: 16307
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003FB4 RID: 16308
	private NewPlayerSupportTrialRoleListComponent TrialRoleListComponent;

	// Token: 0x04003FB5 RID: 16309
	private TrialRoleGroupData TrialRoleGroupData;

	// Token: 0x04003FB6 RID: 16310
	private NewPlayerSupportRoleCommonItem RoleCommonItem;

	// Token: 0x04003FB7 RID: 16311
	[Nullable(1)]
	private readonly Dictionary<int, NewPlayerSupportRoleSpineItem> RoleSpineItemMap = new Dictionary<int, NewPlayerSupportRoleSpineItem>();

	// Token: 0x04003FB8 RID: 16312
	private NewPlayerSupportRoleBaseItem CurRoleItem;

	// Token: 0x04003FB9 RID: 16313
	private RoleTagMediumIconItem RoleTagItem;

	// Token: 0x04003FBA RID: 16314
	private ActivityRoleDescribeComponent RoleDescComponent;

	// Token: 0x04003FBB RID: 16315
	private NewPlayerSupportTrialRoleViewModel ViewModel;

	// Token: 0x04003FBC RID: 16316
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003FBD RID: 16317
	private bool WaitingLoad;

	// Token: 0x04003FBE RID: 16318
	private TimerHandle AutoCloseTimer;

	// Token: 0x04003FBF RID: 16319
	private readonly int AutoCloseViewTime = 30000;

	// Token: 0x04003FC0 RID: 16320
	protected UiSequencePlayer LoadingSequencePlayer;

	// Token: 0x02006BBD RID: 27581
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x040236C4 RID: 145092
		public const int TitleItem = 0;

		// Token: 0x040236C5 RID: 145093
		public const int RoleIconBg = 1;

		// Token: 0x040236C6 RID: 145094
		public const int RoleIcon = 2;

		// Token: 0x040236C7 RID: 145095
		public const int RoleSpineItem = 3;

		// Token: 0x040236C8 RID: 145096
		public const int RoleTrialConfirmBtn = 4;

		// Token: 0x040236C9 RID: 145097
		public const int RoleFormationBtn = 5;

		// Token: 0x040236CA RID: 145098
		public const int LevelTxt = 6;

		// Token: 0x040236CB RID: 145099
		public const int RoleLevelTxt = 7;

		// Token: 0x040236CC RID: 145100
		public const int HelpBtn = 8;

		// Token: 0x040236CD RID: 145101
		public const int TrialingItem = 9;

		// Token: 0x040236CE RID: 145102
		public const int LockItem = 10;

		// Token: 0x040236CF RID: 145103
		public const int SyncLevelBtn = 11;

		// Token: 0x040236D0 RID: 145104
		public const int SyncLevelRedDot = 12;

		// Token: 0x040236D1 RID: 145105
		public const int RoleAttrItem = 13;

		// Token: 0x040236D2 RID: 145106
		public const int RoleTagItem = 14;

		// Token: 0x040236D3 RID: 145107
		public const int RoleListItem = 15;

		// Token: 0x040236D4 RID: 145108
		public const int RolePreviewBtn = 16;

		// Token: 0x040236D5 RID: 145109
		public const int LockTxt = 17;

		// Token: 0x040236D6 RID: 145110
		public const int LoadingItem = 18;
	}
}
