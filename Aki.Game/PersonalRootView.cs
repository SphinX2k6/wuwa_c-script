using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018D2 RID: 6354
[NullableContext(2)]
[Nullable(0)]
public class PersonalRootView : UiViewBase
{
	// Token: 0x0600FAA8 RID: 64168 RVA: 0x00494A74 File Offset: 0x00492C74
	[NullableContext(1)]
	public PersonalRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FAA9 RID: 64169 RVA: 0x00494A88 File Offset: 0x00492C88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIText)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUISprite)),
			new ValueTuple<int, Type>(25, typeof(UUISprite)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUITexture)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(30, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCopyUidClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickDetailButton)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickSignButton)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickWorldLevelTipsButton)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnClickCloseButton)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickRenameButton)),
			new ValueTuple<int, Delegate>(16, new Action<EToggleState>(this.OnClickShowViewToggle)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickPersonalCardButton)),
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickExchangePreviewRoleButton)),
			new ValueTuple<int, Delegate>(29, new Action(this.OnClickThirdPartyButton))
		};
	}

	// Token: 0x0600FAAA RID: 64170 RVA: 0x00494E64 File Offset: 0x00493064
	private void OnClickThirdPartyButton()
	{
		string text;
		if (!this.PersonalInfoData.IsOtherData)
		{
			text = PlayerInfoModel.Instance.GetThirdPartyUserId();
		}
		else
		{
			PersonalInfoData personalInfoData = this.PersonalInfoData;
			text = ((personalInfoData != null) ? personalInfoData.ThirdUserId : null);
		}
		string text2 = text;
		if (!string.IsNullOrEmpty(text2))
		{
			KuroSdkController.Instance.OpenProfileCard(text2);
		}
	}

	// Token: 0x0600FAAB RID: 64171 RVA: 0x00494EB0 File Offset: 0x004930B0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSignChange, new Action(this.OnSignChange));
		EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.OnNameChange));
		EventSystem.Instance.Add(EEventName.OnRoleShowListChange, new Action(this.OnRoleShowListChange));
		EventSystem.Instance.Add<int>(EEventName.OnHeadIconChange, new Action<int>(this.OnHeadIconChange));
		EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(this.OnBirthChange));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(this.OnWorldLevelChange));
		EventSystem.Instance.Add(EEventName.OnPlayerTitleChange, new Action(this.OnPlayerTitleChange));
	}

	// Token: 0x0600FAAC RID: 64172 RVA: 0x00494FA0 File Offset: 0x004931A0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSignChange, new Action(this.OnSignChange));
		EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.OnNameChange));
		EventSystem.Instance.Remove(EEventName.OnRoleShowListChange, new Action(this.OnRoleShowListChange));
		EventSystem.Instance.Remove(EEventName.OnHeadIconChange, new Action<int>(this.OnHeadIconChange));
		EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(this.OnBirthChange));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(this.OnWorldLevelChange));
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleChange, new Action(this.OnPlayerTitleChange));
	}

	// Token: 0x0600FAAD RID: 64173 RVA: 0x0049508D File Offset: 0x0049328D
	protected override void OnBeforeCreate()
	{
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x0600FAAE RID: 64174 RVA: 0x004950A8 File Offset: 0x004932A8
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalRootView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalRootView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FAAF RID: 64175 RVA: 0x004950EC File Offset: 0x004932EC
	protected override void OnStart()
	{
		this.RoleItemLayout = new GenericLayout<PersonalRoleDisplayMediumItem, PersonalRoleDisplayContentData>(base.GetHorizontalLayout(10), new Func<PersonalRoleDisplayMediumItem>(this.InitRoleItem), null, false, true);
		if (Info.Instance.IsHomeConsolePlatform())
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
			UUISprite sprite = base.GetSprite(24);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(25);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
		}
		this.SetUid();
		this.SetWorldLevelText();
		this.SetPlayerLevelText();
		this.SetBirthText();
		this.SetPlayerName();
		this.SetPlayerSignature();
		this.SetPlayerIcon();
		this.RefreshCard();
		this.RefreshPlayerTitle();
		this.RefreshThirdPartyItem();
		this.RefreshButtonState();
		this.RefreshRedDot();
		base.GetExtendToggle(16).CanExecuteChange.Bind(new Func<bool>(this.OnCanShowToggleExecuteChange));
	}

	// Token: 0x0600FAB0 RID: 64176 RVA: 0x004951C8 File Offset: 0x004933C8
	protected override void OnHandleLoadScene()
	{
		this.OriginalCamera = CameraController.Instance.MainModel.CurrentCameraActor;
		this.SceneSequenceCamera = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SceneCamera1").Value, ECollectActorType.Default);
		this.GachaSequence.BindSceneSequenceCamera(this.SceneSequenceCamera);
		this.SceneEmptyCamera = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("personal").Value, ECollectActorType.Default);
		this.GachaSequence.BindEmptySequenceCamera(this.SceneEmptyCamera);
		this.UpdateInteractBp = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("UpdateInteractBP").Value, ECollectActorType.Default) as BP_UpdateInteract_C);
		this.UpdateInteractBp.SetTickableWhenPaused(true);
		this.GachaSequence.BindUpdateInteractBp(this.UpdateInteractBp);
	}

	// Token: 0x0600FAB1 RID: 64177 RVA: 0x00495288 File Offset: 0x00493488
	protected override void OnBeforeShow()
	{
		List<RoleShowEntry> roleShowList = this.PersonalInfoData.RoleShowList;
		List<int> list = new List<int>();
		foreach (RoleShowEntry roleShowEntry in roleShowList)
		{
			list.Add(roleShowEntry.Proto_RoleId);
		}
		this.RefreshRoleShowList(list, true, 0);
		this.BindRedDot();
	}

	// Token: 0x0600FAB2 RID: 64178 RVA: 0x004952FC File Offset: 0x004934FC
	[NullableContext(1)]
	protected void RefreshRoleShowList(List<int> roleIdList, bool isLastFrame, int releaseRoleIdAfterPlay = 0)
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("role_show_list_max_count");
		this.ShowRoleList.Clear();
		int num = 0;
		for (;;)
		{
			int num2 = num;
			int? num3 = intConfig;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			if (num < roleIdList.Count)
			{
				int item = roleIdList[num];
				this.ShowRoleList.Add(item);
			}
			else
			{
				this.ShowRoleList.Add(-1);
			}
			num++;
		}
		List<PersonalRoleDisplayContentData> list = new List<PersonalRoleDisplayContentData>();
		foreach (int roleId in this.ShowRoleList)
		{
			list.Add(new PersonalRoleDisplayContentData
			{
				RoleId = roleId,
				IfOtherData = this.PersonalInfoData.IsOtherData
			});
		}
		this.RoleItemLayout.RefreshByData(list, delegate
		{
			if (this.ShowRoleList.Count > 0 && this.ShowRoleList[0] > 0)
			{
				this.CurSelectRoleId = this.ShowRoleList[0];
				this.RoleItemLayout.SelectGridProxy(0, false);
				this.GachaSequence.PlayRoleSequence(this.CurSelectRoleId, releaseRoleIdAfterPlay);
				this.GetItem(15).SetUIActive(false);
				return;
			}
			this.GachaSequence.PlayEmptySequence();
			if (releaseRoleIdAfterPlay > 0)
			{
				this.GachaSequence.ReleaseLevelSequenceActor(releaseRoleIdAfterPlay);
			}
			this.GetItem(15).SetUIActive(true);
		}, false);
	}

	// Token: 0x0600FAB3 RID: 64179 RVA: 0x0049540C File Offset: 0x0049360C
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600FAB4 RID: 64180 RVA: 0x00495414 File Offset: 0x00493614
	protected override void OnBeforeDestroy()
	{
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Destroy(null);
	}

	// Token: 0x0600FAB5 RID: 64181 RVA: 0x00495428 File Offset: 0x00493628
	protected override void OnAfterDestroy()
	{
		CameraController.Instance.SetViewTarget(this.OriginalCamera, "PersonalRootView.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
	}

	// Token: 0x0600FAB6 RID: 64182 RVA: 0x0049546E File Offset: 0x0049366E
	[NullableContext(1)]
	private PersonalRoleDisplayMediumItem InitRoleItem()
	{
		PersonalRoleDisplayMediumItem personalRoleDisplayMediumItem = new PersonalRoleDisplayMediumItem();
		personalRoleDisplayMediumItem.BindClickItemCallBack(new Action<int>(this.OnRoleItemClick));
		return personalRoleDisplayMediumItem;
	}

	// Token: 0x0600FAB7 RID: 64183 RVA: 0x00495488 File Offset: 0x00493688
	private void SetWorldLevelText()
	{
		int num = this.PersonalInfoData.IsOtherData ? this.PersonalInfoData.WorldLevel : WorldLevelModel.Instance.CurWorldLevel;
		if (num > 0)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(8), "WorldLevelNum", new <>z__ReadOnlySingleElementList<object>(num));
		}
	}

	// Token: 0x0600FAB8 RID: 64184 RVA: 0x004954E0 File Offset: 0x004936E0
	private void SetPlayerLevelText()
	{
		int? num = this.PersonalInfoData.IsOtherData ? new int?(this.PersonalInfoData.Level) : FunctionModel.Instance.GetPlayerLevel();
		if (num != null)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(9), "PlayerLevelNum", new <>z__ReadOnlySingleElementList<object>(num.Value));
		}
	}

	// Token: 0x0600FAB9 RID: 64185 RVA: 0x00495548 File Offset: 0x00493748
	private void SetBirthText()
	{
		UUIText text = base.GetText(7);
		if (this.PersonalInfoData.IsOtherData && !this.PersonalInfoData.IsBirthdayDisplay)
		{
			LguiUtil.Instance.SetLocalText(text, "BirthDay", new <>z__ReadOnlyArray<object>(new object[]
			{
				"--",
				"--"
			}));
			return;
		}
		int birthday = this.PersonalInfoData.Birthday;
		double num = Math.Floor((double)birthday / 100.0);
		int date = birthday % 100;
		if (birthday == 0)
		{
			LguiUtil.Instance.SetLocalText(text, "BirthDay", new <>z__ReadOnlyArray<object>(new object[]
			{
				"--",
				"--"
			}));
			return;
		}
		string birthLocalText = PersonalConfig.Instance.GetBirthLocalText((int)num, EBirthDateType.MONTH);
		string birthLocalText2 = PersonalConfig.Instance.GetBirthLocalText(date, EBirthDateType.DAY);
		LguiUtil.Instance.SetLocalText(text, "BirthDay", new <>z__ReadOnlyArray<object>(new object[]
		{
			birthLocalText,
			birthLocalText2
		}));
	}

	// Token: 0x0600FABA RID: 64186 RVA: 0x00495638 File Offset: 0x00493838
	private void SetPlayerName()
	{
		string text = this.PersonalInfoData.IsOtherData ? this.PersonalInfoData.Name : FunctionModel.Instance.GetPlayerName();
		if (!string.IsNullOrEmpty(text))
		{
			base.GetText(5).SetText(text, true);
		}
	}

	// Token: 0x0600FABB RID: 64187 RVA: 0x00495680 File Offset: 0x00493880
	private void SetPlayerSignature()
	{
		string signature = this.PersonalInfoData.Signature;
		bool isOtherData = this.PersonalInfoData.IsOtherData;
		UUIText text = base.GetText(6);
		if (string.IsNullOrEmpty(signature) && !isOtherData)
		{
			LguiUtil.Instance.SetLocalText(text, "ClickToSetSign", Array.Empty<object>());
			return;
		}
		text.SetText(signature, true);
	}

	// Token: 0x0600FABC RID: 64188 RVA: 0x004956D8 File Offset: 0x004938D8
	private void SetPlayerIcon()
	{
		UUITexture texture = base.GetTexture(4);
		int value = this.PersonalInfoData.HeadPhotoId.Value;
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(value, false);
		if (playerHeadData != null)
		{
			base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), texture, null, null);
			texture.SetUIActive(true);
			return;
		}
		if (value > 0)
		{
			string roleHeadIcon = RoleConfig.Instance.GetRoleHeadIcon(value, false);
			base.SetRoleIcon(roleHeadIcon, texture, value, null, null);
		}
	}

	// Token: 0x0600FABD RID: 64189 RVA: 0x00495754 File Offset: 0x00493954
	private void SetUid()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), "UserId", new <>z__ReadOnlySingleElementList<object>(this.PersonalInfoData.IsOtherData ? this.PersonalInfoData.PlayerId : FunctionModel.Instance.PlayerId));
	}

	// Token: 0x0600FABE RID: 64190 RVA: 0x004957A8 File Offset: 0x004939A8
	protected void RefreshCard()
	{
		int? curCardId = this.PersonalInfoData.CurCardId;
		if (curCardId == null)
		{
			return;
		}
		BackgroundCard? config = ConfigBackgroundCardById.GetConfig(curCardId.Value, true);
		if (config == null)
		{
			return;
		}
		base.SetTextureByPath(config.Value.FunctionViewCardPath, base.GetTexture(3), null, null);
	}

	// Token: 0x0600FABF RID: 64191 RVA: 0x0049580C File Offset: 0x00493A0C
	private void RefreshThirdPartyItem()
	{
		KuroSdkController instance = KuroSdkController.Instance;
		bool? flag = (instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null;
		if (flag != null && flag.Value)
		{
			string value;
			if (!this.PersonalInfoData.IsOtherData)
			{
				value = PlayerInfoModel.Instance.GetThirdPartyUserId();
			}
			else
			{
				PersonalInfoData personalInfoData = this.PersonalInfoData;
				value = ((personalInfoData != null) ? personalInfoData.ThirdUserId : null);
			}
			bool flag2 = !string.IsNullOrEmpty(value);
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUITexture texture = base.GetTexture(27);
			if (texture != null)
			{
				texture.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(28);
			if (item2 != null)
			{
				item2.SetUIActive(!flag2);
			}
			UUIItem item3 = base.GetItem(30);
			if (item3 != null)
			{
				item3.SetUIActive(flag2);
			}
			if (flag2)
			{
				string text;
				if (!this.PersonalInfoData.IsOtherData)
				{
					text = PlayerInfoModel.Instance.GetThirdPartyOnlineId();
				}
				else
				{
					PersonalInfoData personalInfoData2 = this.PersonalInfoData;
					text = (((personalInfoData2 != null) ? personalInfoData2.ThirdOnlineId : null) ?? string.Empty);
				}
				string newText = text;
				UUIText text2 = base.GetText(22);
				if (text2 != null)
				{
					text2.SetText(newText, true);
				}
				string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Small);
				base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(27), null, null);
				string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
				UUIText text3 = base.GetText(22);
				if (text3 != null)
				{
					text3.SetColor(FColor.FromHex(thirdPartyTextColor));
				}
				bool uiactive = Info.Instance.IsXboxPlatform();
				UUIButtonComponent button = base.GetButton(29);
				if (button == null)
				{
					return;
				}
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem == null)
				{
					return;
				}
				uuiitem.SetUIActive(uiactive);
				return;
			}
			else
			{
				UUIText text4 = base.GetText(22);
				if (text4 == null)
				{
					return;
				}
				text4.SetText(string.Empty, true);
				return;
			}
		}
		else
		{
			UUIItem item4 = base.GetItem(30);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(21);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUITexture texture2 = base.GetTexture(27);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(28);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600FAC0 RID: 64192 RVA: 0x00495A14 File Offset: 0x00493C14
	protected void RefreshButtonState()
	{
		bool flag = !this.PersonalInfoData.IsOtherData;
		base.GetButton(11).SetSelfInteractive(flag);
		base.GetButton(2).RootUIComp.Get().SetUIActive(flag);
		base.GetButton(12).RootUIComp.Get().SetUIActive(flag);
		base.GetButton(14).RootUIComp.Get().SetUIActive(flag);
		base.GetButton(18).RootUIComp.Get().SetUIActive(flag);
	}

	// Token: 0x0600FAC1 RID: 64193 RVA: 0x00495AAC File Offset: 0x00493CAC
	private void RefreshRedDot()
	{
		bool uiactive = PersonalModel.Instance.CheckCanShowPersonalTip() && !this.PersonalInfoData.IsOtherData;
		base.GetItem(23).SetUIActive(uiactive);
	}

	// Token: 0x0600FAC2 RID: 64194 RVA: 0x00495AE5 File Offset: 0x00493CE5
	private void BindRedDot()
	{
		if (!this.PersonalInfoData.IsOtherData)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.PersonalCard, base.GetItem(19), null, 0);
		}
	}

	// Token: 0x0600FAC3 RID: 64195 RVA: 0x00495B0D File Offset: 0x00493D0D
	private void UnBindRedDot()
	{
		if (!this.PersonalInfoData.IsOtherData)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.PersonalCard, base.GetItem(19), 0);
		}
	}

	// Token: 0x0600FAC4 RID: 64196 RVA: 0x00495B34 File Offset: 0x00493D34
	private void OnCopyUidClick()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int playerId = this.PersonalInfoData.PlayerId;
		if (id.GetValueOrDefault() == playerId & id != null)
		{
			GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
		}
		else
		{
			GenericPromptController.Instance.ShowPromptByCode("CopyOtherUID", Array.Empty<object>());
		}
		ULGUIBPLibrary.ClipBoardCopy(this.PersonalInfoData.PlayerId.ToString());
	}

	// Token: 0x0600FAC5 RID: 64197 RVA: 0x00495BAB File Offset: 0x00493DAB
	protected void OnWorldLevelChange()
	{
		this.SetWorldLevelText();
	}

	// Token: 0x0600FAC6 RID: 64198 RVA: 0x00495BB3 File Offset: 0x00493DB3
	protected void OnSignChange()
	{
		this.SetPlayerSignature();
	}

	// Token: 0x0600FAC7 RID: 64199 RVA: 0x00495BBB File Offset: 0x00493DBB
	protected void OnNameChange()
	{
		this.SetPlayerName();
	}

	// Token: 0x0600FAC8 RID: 64200 RVA: 0x00495BC3 File Offset: 0x00493DC3
	protected void OnBirthChange()
	{
		this.SetBirthText();
	}

	// Token: 0x0600FAC9 RID: 64201 RVA: 0x00495BCB File Offset: 0x00493DCB
	protected void OnRoleShowListChange()
	{
	}

	// Token: 0x0600FACA RID: 64202 RVA: 0x00495BCD File Offset: 0x00493DCD
	protected void OnHeadIconChange(int roleId)
	{
		this.SetPlayerIcon();
	}

	// Token: 0x0600FACB RID: 64203 RVA: 0x00495BD5 File Offset: 0x00493DD5
	protected void OnCardChange()
	{
		this.RefreshCard();
	}

	// Token: 0x0600FACC RID: 64204 RVA: 0x00495BDD File Offset: 0x00493DDD
	protected void OnPlayerTitleChange()
	{
		this.RefreshPlayerTitle();
	}

	// Token: 0x0600FACD RID: 64205 RVA: 0x00495BE5 File Offset: 0x00493DE5
	protected void OnClickDetailButton()
	{
		if (this.PersonalInfoData.IsOtherData)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PersonalOptionView, null, null);
	}

	// Token: 0x0600FACE RID: 64206 RVA: 0x00495C06 File Offset: 0x00493E06
	protected void OnClickSignButton()
	{
		if (this.PersonalInfoData.IsOtherData)
		{
			return;
		}
		CommonInputViewController.Instance.OpenPersonalSignInputView();
	}

	// Token: 0x0600FACF RID: 64207 RVA: 0x00495C20 File Offset: 0x00493E20
	protected void OnClickWorldLevelTipsButton()
	{
		WorldLevelController.Instance.OpenWorldLevelInfoView();
	}

	// Token: 0x0600FAD0 RID: 64208 RVA: 0x00495C2C File Offset: 0x00493E2C
	protected void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FAD1 RID: 64209 RVA: 0x00495C35 File Offset: 0x00493E35
	protected void OnClickRenameButton()
	{
		CommonInputViewController.Instance.OpenSetRoleNameInputView();
	}

	// Token: 0x0600FAD2 RID: 64210 RVA: 0x00495C44 File Offset: 0x00493E44
	protected void OnClickShowViewToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.UiViewSequence.StopPrevSequence(true, false);
			base.PlaySequence("CloseView", delegate
			{
				UUIItem item = base.GetItem(20);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}, false);
			return;
		}
		this.UiViewSequence.StopPrevSequence(true, false);
		base.PlaySequence("StartView", null, false);
		base.GetItem(20).SetUIActive(true);
	}

	// Token: 0x0600FAD3 RID: 64211 RVA: 0x00495CA3 File Offset: 0x00493EA3
	protected bool OnCanShowToggleExecuteChange()
	{
		return !this.UiViewSequence.IsInSequence();
	}

	// Token: 0x0600FAD4 RID: 64212 RVA: 0x00495CB3 File Offset: 0x00493EB3
	protected void OnClickPersonalCardButton()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalCardView, this.PersonalInfoData, null);
	}

	// Token: 0x0600FAD5 RID: 64213 RVA: 0x00495CCC File Offset: 0x00493ECC
	protected void OnClickExchangePreviewRoleButton()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView))
		{
			return;
		}
		PersonalModel.Instance.SetPersonalTipState(false);
		this.RefreshRedDot();
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		QuickRoleSelectViewData quickRoleSelectViewData = new QuickRoleSelectViewData(EFilterSortGroupId.EditFormation, this.ShowRoleList.ToArray(), new List<RoleDataBase>(roleList));
		quickRoleSelectViewData.OnWaitLoadingConfirm = new Func<List<int>, UniTask>(this.OnWaitLoadingConfirmCallBack);
		quickRoleSelectViewData.OnRoleSelectFull = new Action(this.OnRoleSelectFull);
		quickRoleSelectViewData.OnBack = new Action(this.OnSelectBack);
		quickRoleSelectViewData.ShowDetailButton = false;
		UiManager.Instance.OpenView(EUiViewName.PersonalQuickRoleSelectView, quickRoleSelectViewData, null);
	}

	// Token: 0x0600FAD6 RID: 64214 RVA: 0x00495D70 File Offset: 0x00493F70
	[NullableContext(1)]
	protected UniTask OnWaitLoadingConfirmCallBack(List<int> roleIdList)
	{
		PersonalRootView.<OnWaitLoadingConfirmCallBack>d__58 <OnWaitLoadingConfirmCallBack>d__;
		<OnWaitLoadingConfirmCallBack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnWaitLoadingConfirmCallBack>d__.<>4__this = this;
		<OnWaitLoadingConfirmCallBack>d__.roleIdList = roleIdList;
		<OnWaitLoadingConfirmCallBack>d__.<>1__state = -1;
		<OnWaitLoadingConfirmCallBack>d__.<>t__builder.Start<PersonalRootView.<OnWaitLoadingConfirmCallBack>d__58>(ref <OnWaitLoadingConfirmCallBack>d__);
		return <OnWaitLoadingConfirmCallBack>d__.<>t__builder.Task;
	}

	// Token: 0x0600FAD7 RID: 64215 RVA: 0x00495DBB File Offset: 0x00493FBB
	private void OnSelectBack()
	{
		this.RefreshRedDot();
	}

	// Token: 0x0600FAD8 RID: 64216 RVA: 0x00495DC4 File Offset: 0x00493FC4
	protected void OnRoleItemClick(int roleId)
	{
		if (this.CurSelectRoleId == roleId)
		{
			return;
		}
		if (!this.CheckClickInterval())
		{
			return;
		}
		this.CurSelectRoleId = roleId;
		int num = -1;
		for (int i = 0; i < this.ShowRoleList.Count; i++)
		{
			if (this.ShowRoleList[i] == roleId)
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			this.RoleItemLayout.SelectGridProxy(num, false);
		}
		this.GachaSequence.PlayRoleSequence(roleId, 0);
		this.LastClickTime = Time.Instance.Now;
	}

	// Token: 0x0600FAD9 RID: 64217 RVA: 0x00495E44 File Offset: 0x00494044
	protected bool CheckClickInterval()
	{
		int value = ConfigCommonParamById.GetIntConfig("IndividualizationRoleSwitchIntervalTime").Value;
		return Time.Instance.Now - this.LastClickTime >= (double)value;
	}

	// Token: 0x0600FADA RID: 64218 RVA: 0x00495E7C File Offset: 0x0049407C
	protected void OnRoleSelectFull()
	{
		ScrollingTipsController.Instance.ShowTipsById("DisplayFull_text", Array.Empty<object>());
	}

	// Token: 0x0600FADB RID: 64219 RVA: 0x00495E94 File Offset: 0x00494094
	protected void RefreshPlayerTitle()
	{
		int? curPlayerTitleId = this.PersonalInfoData.CurPlayerTitleId;
		int? curPlayerTitleLevel = this.PersonalInfoData.CurPlayerTitleLevel;
		int sex = this.PersonalInfoData.Sex;
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Refresh(curPlayerTitleId, curPlayerTitleLevel, new int?(sex));
	}

	// Token: 0x04008C57 RID: 35927
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PersonalRoleDisplayMediumItem, PersonalRoleDisplayContentData> RoleItemLayout;

	// Token: 0x04008C58 RID: 35928
	[Nullable(1)]
	private readonly List<int> ShowRoleList = new List<int>();

	// Token: 0x04008C59 RID: 35929
	private int CurSelectRoleId;

	// Token: 0x04008C5A RID: 35930
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008C5B RID: 35931
	private AActor SceneSequenceCamera;

	// Token: 0x04008C5C RID: 35932
	private AActor SceneEmptyCamera;

	// Token: 0x04008C5D RID: 35933
	private AActor OriginalCamera;

	// Token: 0x04008C5E RID: 35934
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x04008C5F RID: 35935
	private double LastClickTime;

	// Token: 0x04008C60 RID: 35936
	private PlayerTitleItem TitleItem;

	// Token: 0x04008C61 RID: 35937
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x02007B13 RID: 31507
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027E2E RID: 163374
		CopyIdButton,
		// Token: 0x04027E2F RID: 163375
		IdText,
		// Token: 0x04027E30 RID: 163376
		DetailButton,
		// Token: 0x04027E31 RID: 163377
		CardTexture,
		// Token: 0x04027E32 RID: 163378
		IconTexture,
		// Token: 0x04027E33 RID: 163379
		NameText,
		// Token: 0x04027E34 RID: 163380
		SignatureText,
		// Token: 0x04027E35 RID: 163381
		BirthText,
		// Token: 0x04027E36 RID: 163382
		WorldLevelText,
		// Token: 0x04027E37 RID: 163383
		PlayerLevelText,
		// Token: 0x04027E38 RID: 163384
		HorizontalLayout,
		// Token: 0x04027E39 RID: 163385
		SignButton,
		// Token: 0x04027E3A RID: 163386
		WorldLevelTipsButton,
		// Token: 0x04027E3B RID: 163387
		CloseButton,
		// Token: 0x04027E3C RID: 163388
		RenameButton,
		// Token: 0x04027E3D RID: 163389
		EmptySequenceItem,
		// Token: 0x04027E3E RID: 163390
		ShowViewToggle,
		// Token: 0x04027E3F RID: 163391
		PersonalCardButton,
		// Token: 0x04027E40 RID: 163392
		ExchangePreviewRoleButton,
		// Token: 0x04027E41 RID: 163393
		PersonalRedDot,
		// Token: 0x04027E42 RID: 163394
		ShowViewRoot,
		// Token: 0x04027E43 RID: 163395
		ThirdPartyItem,
		// Token: 0x04027E44 RID: 163396
		ThirdPartyText,
		// Token: 0x04027E45 RID: 163397
		ExchangePreviewRoleRedDot,
		// Token: 0x04027E46 RID: 163398
		CopyIdButtonSprite,
		// Token: 0x04027E47 RID: 163399
		CopyIdButtonHoldSprite,
		// Token: 0x04027E48 RID: 163400
		PlayerTitleItem,
		// Token: 0x04027E49 RID: 163401
		ThirdPartyTexture,
		// Token: 0x04027E4A RID: 163402
		PcItem,
		// Token: 0x04027E4B RID: 163403
		ThirdPartyButton,
		// Token: 0x04027E4C RID: 163404
		ThirdPartyRootItem
	}
}
