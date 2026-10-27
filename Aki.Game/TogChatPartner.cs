using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002544 RID: 9540
[NullableContext(2)]
[Nullable(0)]
public class TogChatPartner : UiPanelBase
{
	// Token: 0x0601334F RID: 78671 RVA: 0x004C5DA4 File Offset: 0x004C3FA4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTogSelf))
		};
	}

	// Token: 0x06013350 RID: 78672 RVA: 0x004C5EBC File Offset: 0x004C40BC
	public void RefreshByTheme(int themeId)
	{
		if (this.AppliedThemeId == themeId)
		{
			return;
		}
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(themeId);
		if (chatThemeConfig == null)
		{
			return;
		}
		this.AppliedThemeId = themeId;
		string togChatItemANml = chatThemeConfig.Value.TogChatItemANml;
		string togChatItemAHold = chatThemeConfig.Value.TogChatItemAHold;
		string togChatItemAPress = chatThemeConfig.Value.TogChatItemAPress;
		string togChatItemASel = chatThemeConfig.Value.TogChatItemASel;
		UUITexture texture = base.GetTexture(6);
		AActor aactor = (texture != null) ? texture.GetOwner() : null;
		UUIExtendToggleTextureTransition uuiextendToggleTextureTransition = ((aactor != null) ? aactor.GetComponentByClass(UUIExtendToggleTextureTransition.StaticClass()) : null) as UUIExtendToggleTextureTransition;
		if (uuiextendToggleTextureTransition != null && togChatItemANml != "" && togChatItemAHold != "" && togChatItemAPress != "" && togChatItemASel != "")
		{
			base.SetExtendToggleTextureTransitionByPath(togChatItemANml, uuiextendToggleTextureTransition, EToggleTransitionState.ETT_UnCheckedUnHover);
			base.SetExtendToggleTextureTransitionByPath(togChatItemAHold, uuiextendToggleTextureTransition, EToggleTransitionState.ETT_UnCheckedHover);
			base.SetExtendToggleTextureTransitionByPath(togChatItemAPress, uuiextendToggleTextureTransition, EToggleTransitionState.ETT_UnCheckedPressed);
			base.SetExtendToggleTextureTransitionByPath(togChatItemASel, uuiextendToggleTextureTransition, EToggleTransitionState.ETT_CheckedUnHover);
			base.SetExtendToggleTextureTransitionByPath(togChatItemASel, uuiextendToggleTextureTransition, EToggleTransitionState.ETT_CheckedHover);
			base.SetExtendToggleTextureTransitionByPath(togChatItemASel, uuiextendToggleTextureTransition, EToggleTransitionState.ETT_CheckedPressed);
		}
		string bgSelected = chatThemeConfig.Value.BgSelected;
		UUISprite sprite = base.GetSprite(7);
		if (sprite != null)
		{
			this.SetSpriteByPath(bgSelected, sprite, false, null, null);
		}
		string hexStr = chatThemeConfig.Value.TogChatItemATextcol(0);
		string hexStr2 = chatThemeConfig.Value.TogChatItemATextcol(1);
		string hexStr3 = chatThemeConfig.Value.TogChatItemATextcol(2);
		string hexStr4 = chatThemeConfig.Value.TogChatItemATextcol(3);
		UUIText text = base.GetText(2);
		AActor aactor2 = (text != null) ? text.GetOwner() : null;
		UUIExtendToggleTextTransition uuiextendToggleTextTransition = ((aactor2 != null) ? aactor2.GetComponentByClass(UUIExtendToggleTextTransition.StaticClass()) : null) as UUIExtendToggleTextTransition;
		UUIText text2 = base.GetText(8);
		AActor aactor3 = (text2 != null) ? text2.GetOwner() : null;
		UUIExtendToggleTextTransition uuiextendToggleTextTransition2 = ((aactor3 != null) ? aactor3.GetComponentByClass(UUIExtendToggleTextTransition.StaticClass()) : null) as UUIExtendToggleTextTransition;
		if (uuiextendToggleTextTransition != null && uuiextendToggleTextTransition2 != null)
		{
			FExtendToggleTextTransitionState transitionState = uuiextendToggleTextTransition.TransitionState;
			transitionState.UnCheckUnHoverState.bSetFontColor = true;
			transitionState.UnCheckHoverState.FontColor = FColor.FromHex(hexStr);
			transitionState.UnCheckHoverState.bSetFontColor = true;
			transitionState.UnCheckHoverState.FontColor = FColor.FromHex(hexStr2);
			transitionState.UnCheckPressedState.bSetFontColor = true;
			transitionState.UnCheckPressedState.FontColor = FColor.FromHex(hexStr3);
			FExtendToggleTextTransitionState transitionState2 = uuiextendToggleTextTransition2.TransitionState;
			transitionState2.CheckUnHoverState.bSetFontColor = true;
			transitionState2.CheckUnHoverState.FontColor = FColor.FromHex(hexStr4);
			transitionState2.CheckHoverState.bSetFontColor = true;
			transitionState2.CheckHoverState.FontColor = FColor.FromHex(hexStr4);
			transitionState2.CheckPressedState.bSetFontColor = true;
			transitionState2.CheckPressedState.FontColor = FColor.FromHex(hexStr4);
		}
	}

	// Token: 0x06013351 RID: 78673 RVA: 0x004C6192 File Offset: 0x004C4392
	public void SetChangeAlpha(bool isEnable)
	{
		base.GetItem(9).SetAlpha(isEnable ? 0.5f : 1f);
	}

	// Token: 0x06013352 RID: 78674 RVA: 0x004C61B0 File Offset: 0x004C43B0
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatTabClick, new Action<int, int>(this.HandleSubItemSelected));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshThemeOnChatShowChange));
	}

	// Token: 0x06013353 RID: 78675 RVA: 0x004C61EA File Offset: 0x004C43EA
	private void RefreshThemeOnChatShowChange()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
	}

	// Token: 0x06013354 RID: 78676 RVA: 0x004C61FC File Offset: 0x004C43FC
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatTabClick, new Action<int, int>(this.HandleSubItemSelected));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshThemeOnChatShowChange));
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PhoneMsgChatPartnerRedDot, base.GetItem(3), this.ChatPartnerId);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PhoneMsgChatPartnerRedDotGiftIcon, base.GetItem(5), this.ChatPartnerId);
	}

	// Token: 0x06013355 RID: 78677 RVA: 0x004C6273 File Offset: 0x004C4473
	public UUIExtendToggle GetTogglePartner()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06013356 RID: 78678 RVA: 0x004C627C File Offset: 0x004C447C
	public void RefreshView(int chatPartnerId, bool isSelected, int gridIndex)
	{
		ChatPartner? chatPartnerConfigNew = PhoneMsgModel.Instance.GetChatPartnerConfigNew(chatPartnerId);
		if (chatPartnerConfigNew == null)
		{
			return;
		}
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PhoneMsgChatPartnerRedDot, base.GetItem(3), this.ChatPartnerId);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PhoneMsgChatPartnerRedDotGiftIcon, base.GetItem(5), this.ChatPartnerId);
		this.ChatPartnerId = chatPartnerId;
		string iconMid = chatPartnerConfigNew.Value.IconMid;
		if (!string.IsNullOrEmpty(iconMid))
		{
			base.SetTextureByPath(iconMid, base.GetTexture(1), null, null);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), chatPartnerConfigNew.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), chatPartnerConfigNew.Value.Name, Array.Empty<object>());
		RedDotController.Instance.BindRedDot(ERedDotName.PhoneMsgChatPartnerRedDot, base.GetItem(3), null, this.ChatPartnerId);
		RedDotController.Instance.BindRedDot(ERedDotName.PhoneMsgChatPartnerRedDotGiftIcon, base.GetItem(5), null, this.ChatPartnerId);
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
	}

	// Token: 0x06013357 RID: 78679 RVA: 0x004C6396 File Offset: 0x004C4596
	[NullableContext(1)]
	public void SetClickCallBack(Action func)
	{
		this.OnClickTogCallBack = func;
	}

	// Token: 0x06013358 RID: 78680 RVA: 0x004C639F File Offset: 0x004C459F
	private void OnClickTogSelf(EToggleState toggleState)
	{
		if (this.OnClickTogCallBack != null)
		{
			this.OnClickTogCallBack();
		}
	}

	// Token: 0x06013359 RID: 78681 RVA: 0x004C63B4 File Offset: 0x004C45B4
	public void SetSelected(bool isSelected)
	{
		base.GetText(2).SetUIActive(!isSelected);
		base.GetText(8).SetUIActive(isSelected);
	}

	// Token: 0x0601335A RID: 78682 RVA: 0x004C63D3 File Offset: 0x004C45D3
	public void HandleSubItemSelected(int messageId, int chatPartnerId)
	{
		if (chatPartnerId == this.ChatPartnerId)
		{
			this.SetSelectBgShow(true);
			return;
		}
		this.SetSelectBgShow(false);
	}

	// Token: 0x0601335B RID: 78683 RVA: 0x004C63ED File Offset: 0x004C45ED
	public void SetSelectBgShow(bool isShow)
	{
		base.GetSprite(7).SetUIActive(isShow);
	}

	// Token: 0x04009112 RID: 37138
	private Action OnClickTogCallBack;

	// Token: 0x04009113 RID: 37139
	private int ChatPartnerId;

	// Token: 0x04009114 RID: 37140
	private int AppliedThemeId = -1;

	// Token: 0x04009115 RID: 37141
	public UUIExtendToggle Toggle;

	// Token: 0x02008AFB RID: 35579
	[NullableContext(0)]
	private enum EChatPartnerComponent
	{
		// Token: 0x0402D1EF RID: 184815
		TogSelf,
		// Token: 0x0402D1F0 RID: 184816
		TexHeadIcon,
		// Token: 0x0402D1F1 RID: 184817
		TxtNameNotSelect,
		// Token: 0x0402D1F2 RID: 184818
		ItemRedDot,
		// Token: 0x0402D1F3 RID: 184819
		TxtCount,
		// Token: 0x0402D1F4 RID: 184820
		ItemGiftIcon,
		// Token: 0x0402D1F5 RID: 184821
		SpriteBgNotSelect,
		// Token: 0x0402D1F6 RID: 184822
		SpriteBgSelect,
		// Token: 0x0402D1F7 RID: 184823
		TxtNameSelect,
		// Token: 0x0402D1F8 RID: 184824
		PanelSetAlpha
	}
}
