using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x020023ED RID: 9197
[NullableContext(2)]
[Nullable(0)]
public class PersonalRootView : UiViewBase
{
	// Token: 0x060125F6 RID: 75254 RVA: 0x00487568 File Offset: 0x00485768
	[NullableContext(1)]
	public PersonalRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060125F7 RID: 75255 RVA: 0x0048757C File Offset: 0x0048577C
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

	// Token: 0x060125F8 RID: 75256 RVA: 0x00487958 File Offset: 0x00485B58
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

	// Token: 0x060125F9 RID: 75257 RVA: 0x004879A4 File Offset: 0x00485BA4
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

	// Token: 0x060125FA RID: 75258 RVA: 0x00487A94 File Offset: 0x00485C94
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

	// Token: 0x060125FB RID: 75259 RVA: 0x00487B81 File Offset: 0x00485D81
	protected override void OnBeforeCreate()
	{
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x060125FC RID: 75260 RVA: 0x00487B9C File Offset: 0x00485D9C
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalRootView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalRootView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125FD RID: 75261 RVA: 0x00487BE0 File Offset: 0x00485DE0
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

	// Token: 0x060125FE RID: 75262 RVA: 0x00487CBC File Offset: 0x00485EBC
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

	// Token: 0x060125FF RID: 75263 RVA: 0x00487D7C File Offset: 0x00485F7C
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

	// Token: 0x06012600 RID: 75264 RVA: 0x00487DF0 File Offset: 0x00485FF0
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

	// Token: 0x06012601 RID: 75265 RVA: 0x00487F00 File Offset: 0x00486100
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06012602 RID: 75266 RVA: 0x00487F08 File Offset: 0x00486108
	protected override void OnBeforeDestroy()
	{
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Destroy(null);
	}

	// Token: 0x06012603 RID: 75267 RVA: 0x00487F1C File Offset: 0x0048611C
	protected override void OnAfterDestroy()
	{
		CameraController.Instance.SetViewTarget(this.OriginalCamera, "PersonalRootView.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
	}

	// Token: 0x06012604 RID: 75268 RVA: 0x00487F62 File Offset: 0x00486162
	[NullableContext(1)]
	private PersonalRoleDisplayMediumItem InitRoleItem()
	{
		PersonalRoleDisplayMediumItem personalRoleDisplayMediumItem = new PersonalRoleDisplayMediumItem();
		personalRoleDisplayMediumItem.BindClickItemCallBack(new Action<int>(this.OnRoleItemClick));
		return personalRoleDisplayMediumItem;
	}

	// Token: 0x06012605 RID: 75269 RVA: 0x00487F7C File Offset: 0x0048617C
	private void SetWorldLevelText()
	{
		int num = this.PersonalInfoData.IsOtherData ? this.PersonalInfoData.WorldLevel : WorldLevelModel.Instance.CurWorldLevel;
		if (num > 0)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(8), "WorldLevelNum", new <>z__ReadOnlySingleElementList<object>(num));
		}
	}

	// Token: 0x06012606 RID: 75270 RVA: 0x00487FD4 File Offset: 0x004861D4
	private void SetPlayerLevelText()
	{
		int? num = this.PersonalInfoData.IsOtherData ? new int?(this.PersonalInfoData.Level) : FunctionModel.Instance.GetPlayerLevel();
		if (num != null)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(9), "PlayerLevelNum", new <>z__ReadOnlySingleElementList<object>(num.Value));
		}
	}

	// Token: 0x06012607 RID: 75271 RVA: 0x0048803C File Offset: 0x0048623C
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

	// Token: 0x06012608 RID: 75272 RVA: 0x0048812C File Offset: 0x0048632C
	private void SetPlayerName()
	{
		string text = this.PersonalInfoData.IsOtherData ? this.PersonalInfoData.Name : FunctionModel.Instance.GetPlayerName();
		if (!string.IsNullOrEmpty(text))
		{
			base.GetText(5).SetText(text, true);
		}
	}

	// Token: 0x06012609 RID: 75273 RVA: 0x00488174 File Offset: 0x00486374
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

	// Token: 0x0601260A RID: 75274 RVA: 0x004881CC File Offset: 0x004863CC
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

	// Token: 0x0601260B RID: 75275 RVA: 0x00488248 File Offset: 0x00486448
	private void SetUid()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), "UserId", new <>z__ReadOnlySingleElementList<object>(this.PersonalInfoData.IsOtherData ? this.PersonalInfoData.PlayerId : FunctionModel.Instance.PlayerId));
	}

	// Token: 0x0601260C RID: 75276 RVA: 0x0048829C File Offset: 0x0048649C
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

	// Token: 0x0601260D RID: 75277 RVA: 0x00488300 File Offset: 0x00486500
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

	// Token: 0x0601260E RID: 75278 RVA: 0x00488508 File Offset: 0x00486708
	protected void RefreshButtonState()
	{
		bool flag = !this.PersonalInfoData.IsOtherData;
		base.GetButton(11).SetSelfInteractive(flag);
		base.GetButton(2).RootUIComp.Get().SetUIActive(flag);
		base.GetButton(12).RootUIComp.Get().SetUIActive(flag);
		base.GetButton(14).RootUIComp.Get().SetUIActive(flag);
		base.GetButton(18).RootUIComp.Get().SetUIActive(flag);
	}

	// Token: 0x0601260F RID: 75279 RVA: 0x004885A0 File Offset: 0x004867A0
	private void RefreshRedDot()
	{
		bool uiactive = PersonalModel.Instance.CheckCanShowPersonalTip() && !this.PersonalInfoData.IsOtherData;
		base.GetItem(23).SetUIActive(uiactive);
	}

	// Token: 0x06012610 RID: 75280 RVA: 0x004885D9 File Offset: 0x004867D9
	private void BindRedDot()
	{
		if (!this.PersonalInfoData.IsOtherData)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.PersonalCard, base.GetItem(19), null, 0);
		}
	}

	// Token: 0x06012611 RID: 75281 RVA: 0x00488601 File Offset: 0x00486801
	private void UnBindRedDot()
	{
		if (!this.PersonalInfoData.IsOtherData)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.PersonalCard, base.GetItem(19), 0);
		}
	}

	// Token: 0x06012612 RID: 75282 RVA: 0x00488628 File Offset: 0x00486828
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

	// Token: 0x06012613 RID: 75283 RVA: 0x0048869F File Offset: 0x0048689F
	protected void OnWorldLevelChange()
	{
		this.SetWorldLevelText();
	}

	// Token: 0x06012614 RID: 75284 RVA: 0x004886A7 File Offset: 0x004868A7
	protected void OnSignChange()
	{
		this.SetPlayerSignature();
	}

	// Token: 0x06012615 RID: 75285 RVA: 0x004886AF File Offset: 0x004868AF
	protected void OnNameChange()
	{
		this.SetPlayerName();
	}

	// Token: 0x06012616 RID: 75286 RVA: 0x004886B7 File Offset: 0x004868B7
	protected void OnBirthChange()
	{
		this.SetBirthText();
	}

	// Token: 0x06012617 RID: 75287 RVA: 0x004886BF File Offset: 0x004868BF
	protected void OnRoleShowListChange()
	{
	}

	// Token: 0x06012618 RID: 75288 RVA: 0x004886C1 File Offset: 0x004868C1
	protected void OnHeadIconChange(int roleId)
	{
		this.SetPlayerIcon();
	}

	// Token: 0x06012619 RID: 75289 RVA: 0x004886C9 File Offset: 0x004868C9
	protected void OnCardChange()
	{
		this.RefreshCard();
	}

	// Token: 0x0601261A RID: 75290 RVA: 0x004886D1 File Offset: 0x004868D1
	protected void OnPlayerTitleChange()
	{
		this.RefreshPlayerTitle();
	}

	// Token: 0x0601261B RID: 75291 RVA: 0x004886D9 File Offset: 0x004868D9
	protected void OnClickDetailButton()
	{
		if (this.PersonalInfoData.IsOtherData)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PersonalOptionView, null, null);
	}

	// Token: 0x0601261C RID: 75292 RVA: 0x004886FA File Offset: 0x004868FA
	protected void OnClickSignButton()
	{
		if (this.PersonalInfoData.IsOtherData)
		{
			return;
		}
		CommonInputViewController.Instance.OpenPersonalSignInputView();
	}

	// Token: 0x0601261D RID: 75293 RVA: 0x00488714 File Offset: 0x00486914
	protected void OnClickWorldLevelTipsButton()
	{
		WorldLevelController.Instance.OpenWorldLevelInfoView();
	}

	// Token: 0x0601261E RID: 75294 RVA: 0x00488720 File Offset: 0x00486920
	protected void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601261F RID: 75295 RVA: 0x00488729 File Offset: 0x00486929
	protected void OnClickRenameButton()
	{
		CommonInputViewController.Instance.OpenSetRoleNameInputView();
	}

	// Token: 0x06012620 RID: 75296 RVA: 0x00488738 File Offset: 0x00486938
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

	// Token: 0x06012621 RID: 75297 RVA: 0x00488797 File Offset: 0x00486997
	protected bool OnCanShowToggleExecuteChange()
	{
		return !this.UiViewSequence.IsInSequence();
	}

	// Token: 0x06012622 RID: 75298 RVA: 0x004887A7 File Offset: 0x004869A7
	protected void OnClickPersonalCardButton()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalCardView, this.PersonalInfoData, null);
	}

	// Token: 0x06012623 RID: 75299 RVA: 0x004887C0 File Offset: 0x004869C0
	protected void OnClickExchangePreviewRoleButton()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView))
		{
			return;
		}
		PersonalModel.Instance.SetPersonalTipState(false);
		this.RefreshRedDot();
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		QuickRoleSelectViewData quickRoleSelectViewData = new QuickRoleSelectViewData(EFilterSortGroupId.EditFormation, this.ShowRoleList.ToArray(), roleList.Cast<RoleDataBase>().ToList<RoleDataBase>());
		quickRoleSelectViewData.OnWaitLoadingConfirm = new Func<List<int>, UniTask>(this.OnWaitLoadingConfirmCallBack);
		quickRoleSelectViewData.OnRoleSelectFull = new Action(this.OnRoleSelectFull);
		quickRoleSelectViewData.OnBack = new Action(this.OnSelectBack);
		quickRoleSelectViewData.ShowDetailButton = false;
		UiManager.Instance.OpenView(EUiViewName.PersonalQuickRoleSelectView, quickRoleSelectViewData, null);
	}

	// Token: 0x06012624 RID: 75300 RVA: 0x00488868 File Offset: 0x00486A68
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

	// Token: 0x06012625 RID: 75301 RVA: 0x004888B3 File Offset: 0x00486AB3
	private void OnSelectBack()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06012626 RID: 75302 RVA: 0x004888BC File Offset: 0x00486ABC
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

	// Token: 0x06012627 RID: 75303 RVA: 0x0048893C File Offset: 0x00486B3C
	protected bool CheckClickInterval()
	{
		int value = ConfigCommonParamById.GetIntConfig("IndividualizationRoleSwitchIntervalTime").Value;
		return Time.Instance.Now - this.LastClickTime >= (double)value;
	}

	// Token: 0x06012628 RID: 75304 RVA: 0x00488974 File Offset: 0x00486B74
	protected void OnRoleSelectFull()
	{
		ScrollingTipsController.Instance.ShowTipsById("DisplayFull_text", Array.Empty<object>());
	}

	// Token: 0x06012629 RID: 75305 RVA: 0x0048898C File Offset: 0x00486B8C
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

	// Token: 0x04008B10 RID: 35600
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PersonalRoleDisplayMediumItem, PersonalRoleDisplayContentData> RoleItemLayout;

	// Token: 0x04008B11 RID: 35601
	[Nullable(1)]
	private readonly List<int> ShowRoleList = new List<int>();

	// Token: 0x04008B12 RID: 35602
	private int CurSelectRoleId;

	// Token: 0x04008B13 RID: 35603
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008B14 RID: 35604
	private AActor SceneSequenceCamera;

	// Token: 0x04008B15 RID: 35605
	private AActor SceneEmptyCamera;

	// Token: 0x04008B16 RID: 35606
	private AActor OriginalCamera;

	// Token: 0x04008B17 RID: 35607
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x04008B18 RID: 35608
	private double LastClickTime;

	// Token: 0x04008B19 RID: 35609
	private PlayerTitleItem TitleItem;

	// Token: 0x04008B1A RID: 35610
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x0200898A RID: 35210
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CB13 RID: 183059
		CopyIdButton,
		// Token: 0x0402CB14 RID: 183060
		IdText,
		// Token: 0x0402CB15 RID: 183061
		DetailButton,
		// Token: 0x0402CB16 RID: 183062
		CardTexture,
		// Token: 0x0402CB17 RID: 183063
		IconTexture,
		// Token: 0x0402CB18 RID: 183064
		NameText,
		// Token: 0x0402CB19 RID: 183065
		SignatureText,
		// Token: 0x0402CB1A RID: 183066
		BirthText,
		// Token: 0x0402CB1B RID: 183067
		WorldLevelText,
		// Token: 0x0402CB1C RID: 183068
		PlayerLevelText,
		// Token: 0x0402CB1D RID: 183069
		HorizontalLayout,
		// Token: 0x0402CB1E RID: 183070
		SignButton,
		// Token: 0x0402CB1F RID: 183071
		WorldLevelTipsButton,
		// Token: 0x0402CB20 RID: 183072
		CloseButton,
		// Token: 0x0402CB21 RID: 183073
		RenameButton,
		// Token: 0x0402CB22 RID: 183074
		EmptySequenceItem,
		// Token: 0x0402CB23 RID: 183075
		ShowViewToggle,
		// Token: 0x0402CB24 RID: 183076
		PersonalCardButton,
		// Token: 0x0402CB25 RID: 183077
		ExchangePreviewRoleButton,
		// Token: 0x0402CB26 RID: 183078
		PersonalRedDot,
		// Token: 0x0402CB27 RID: 183079
		ShowViewRoot,
		// Token: 0x0402CB28 RID: 183080
		ThirdPartyItem,
		// Token: 0x0402CB29 RID: 183081
		ThirdPartyText,
		// Token: 0x0402CB2A RID: 183082
		ExchangePreviewRoleRedDot,
		// Token: 0x0402CB2B RID: 183083
		CopyIdButtonSprite,
		// Token: 0x0402CB2C RID: 183084
		CopyIdButtonHoldSprite,
		// Token: 0x0402CB2D RID: 183085
		PlayerTitleItem,
		// Token: 0x0402CB2E RID: 183086
		ThirdPartyTexture,
		// Token: 0x0402CB2F RID: 183087
		PcItem,
		// Token: 0x0402CB30 RID: 183088
		ThirdPartyButton,
		// Token: 0x0402CB31 RID: 183089
		ThirdPartyRootItem
	}
}
