using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x02001A2E RID: 6702
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TogChatPartner : SyncGridProxyAbstract<ChatPartnerTabItemData>
{
	// Token: 0x06010812 RID: 67602 RVA: 0x004D41B8 File Offset: 0x004D23B8
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

	// Token: 0x06010813 RID: 67603 RVA: 0x004D42D0 File Offset: 0x004D24D0
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatTabClick, new Action<int, int>(this.HandleSubItemSelected));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshThemeOnChatShowChange));
	}

	// Token: 0x06010814 RID: 67604 RVA: 0x004D430A File Offset: 0x004D250A
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatTabClick, new Action<int, int>(this.HandleSubItemSelected));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshThemeOnChatShowChange));
		this.UnBindRedDot();
	}

	// Token: 0x06010815 RID: 67605 RVA: 0x004D434C File Offset: 0x004D254C
	[NullableContext(1)]
	public override void Refresh(ChatPartnerTabItemData data)
	{
		this.CurData = data;
		int chatPartnerId = data.ChatPartnerId;
		this.RefreshView(chatPartnerId);
		Func<int, bool> isExpandedProvider = data.IsExpandedProvider;
		bool selectedState = isExpandedProvider != null && isExpandedProvider(chatPartnerId);
		Func<int, bool> isSelectedPartnerProvider = data.IsSelectedPartnerProvider;
		bool selectBgShow = isSelectedPartnerProvider != null && isSelectedPartnerProvider(chatPartnerId);
		this.SetSelectedState(selectedState);
		this.SetSelectBgShow(selectBgShow);
	}

	// Token: 0x06010816 RID: 67606 RVA: 0x004D43A4 File Offset: 0x004D25A4
	public override void Clear()
	{
		this.SetSelectBgShow(false);
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.UnBindRedDot();
	}

	// Token: 0x06010817 RID: 67607 RVA: 0x004D43C4 File Offset: 0x004D25C4
	public void OnClickThisItem()
	{
		ChatPartnerTabItemData curData = this.CurData;
		if (curData == null)
		{
			return;
		}
		Action<int> onClickPartner = curData.OnClickPartner;
		if (onClickPartner == null)
		{
			return;
		}
		onClickPartner(this.CurData.ChatPartnerId);
	}

	// Token: 0x06010818 RID: 67608 RVA: 0x004D43EC File Offset: 0x004D25EC
	public void SetSelectedState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		this.SetSelected(state);
	}

	// Token: 0x06010819 RID: 67609 RVA: 0x004D441C File Offset: 0x004D261C
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

	// Token: 0x0601081A RID: 67610 RVA: 0x004D46F2 File Offset: 0x004D28F2
	private void RefreshThemeOnChatShowChange()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
	}

	// Token: 0x0601081B RID: 67611 RVA: 0x004D4704 File Offset: 0x004D2904
	public void SetChangeAlpha(bool isEnable)
	{
		base.GetItem(9).SetAlpha(isEnable ? 0.5f : 1f);
	}

	// Token: 0x0601081C RID: 67612 RVA: 0x004D4722 File Offset: 0x004D2922
	public void UnBindRedDot()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PhoneMsgChatPartnerRedDot, base.GetItem(3), this.ChatPartnerId);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PhoneMsgChatPartnerRedDotGiftIcon, base.GetItem(5), this.ChatPartnerId);
	}

	// Token: 0x0601081D RID: 67613 RVA: 0x004D4756 File Offset: 0x004D2956
	public UUIExtendToggle GetTogglePartner()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0601081E RID: 67614 RVA: 0x004D4760 File Offset: 0x004D2960
	public void RefreshView(int chatPartnerId)
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

	// Token: 0x0601081F RID: 67615 RVA: 0x004D487A File Offset: 0x004D2A7A
	[NullableContext(1)]
	public void SetClickCallBack(Action func)
	{
	}

	// Token: 0x06010820 RID: 67616 RVA: 0x004D487C File Offset: 0x004D2A7C
	private void OnClickTogSelf(EToggleState toggleState)
	{
		ChatPartnerTabItemData curData = this.CurData;
		if (curData == null)
		{
			return;
		}
		Action<int> onClickPartner = curData.OnClickPartner;
		if (onClickPartner == null)
		{
			return;
		}
		onClickPartner(this.CurData.ChatPartnerId);
	}

	// Token: 0x06010821 RID: 67617 RVA: 0x004D48A3 File Offset: 0x004D2AA3
	public void SetSelected(bool isSelected)
	{
		base.GetText(2).SetUIActive(!isSelected);
		base.GetText(8).SetUIActive(isSelected);
	}

	// Token: 0x06010822 RID: 67618 RVA: 0x004D48C2 File Offset: 0x004D2AC2
	public void HandleSubItemSelected(int messageId, int chatPartnerId)
	{
		this.SetSelectBgShow(chatPartnerId == this.ChatPartnerId);
	}

	// Token: 0x06010823 RID: 67619 RVA: 0x004D48D3 File Offset: 0x004D2AD3
	public void SetSelectBgShow(bool isShow)
	{
		base.GetSprite(7).SetUIActive(isShow);
	}

	// Token: 0x04009262 RID: 37474
	private int ChatPartnerId;

	// Token: 0x04009263 RID: 37475
	private int AppliedThemeId = -1;

	// Token: 0x04009264 RID: 37476
	private ChatPartnerTabItemData CurData;

	// Token: 0x04009265 RID: 37477
	public UUIExtendToggle Toggle;

	// Token: 0x02007C81 RID: 31873
	[NullableContext(0)]
	private enum EChatPartnerComponent
	{
		// Token: 0x04028500 RID: 165120
		TogSelf,
		// Token: 0x04028501 RID: 165121
		TexHeadIcon,
		// Token: 0x04028502 RID: 165122
		TxtNameNotSelect,
		// Token: 0x04028503 RID: 165123
		ItemRedDot,
		// Token: 0x04028504 RID: 165124
		TxtCount,
		// Token: 0x04028505 RID: 165125
		ItemGiftIcon,
		// Token: 0x04028506 RID: 165126
		SpriteBgNotSelect,
		// Token: 0x04028507 RID: 165127
		SpriteBgSelect,
		// Token: 0x04028508 RID: 165128
		TxtNameSelect,
		// Token: 0x04028509 RID: 165129
		PanelSetAlpha
	}
}
