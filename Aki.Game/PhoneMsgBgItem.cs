using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x02002522 RID: 9506
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgBgItem : SyncGridProxyAbstract<PhoneMsgBgItemData>
{
	// Token: 0x060131E6 RID: 78310 RVA: 0x004BF1B4 File Offset: 0x004BD3B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060131E7 RID: 78311 RVA: 0x004BF273 File Offset: 0x004BD473
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060131E8 RID: 78312 RVA: 0x004BF291 File Offset: 0x004BD491
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060131E9 RID: 78313 RVA: 0x004BF2AF File Offset: 0x004BD4AF
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060131EA RID: 78314 RVA: 0x004BF2B7 File Offset: 0x004BD4B7
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(5);
		PhoneMsgBgItemData phoneMsgBgData = this.PhoneMsgBgData;
		item.SetUIActive(phoneMsgBgData != null && phoneMsgBgData.IsHasRedDot());
	}

	// Token: 0x060131EB RID: 78315 RVA: 0x004BF2D8 File Offset: 0x004BD4D8
	public override void Refresh(PhoneMsgBgItemData data)
	{
		if (data == null)
		{
			return;
		}
		this.PhoneMsgBgData = data;
		ChatBg? chatBgConfig = PhoneMsgConfig.Instance.GetChatBgConfig(data.BgId);
		if (chatBgConfig != null)
		{
			base.SetTextureByPath(chatBgConfig.Value.ChatBgPathSmall, base.GetTexture(2), null, null);
		}
		base.GetSprite(3).SetUIActive(data.IsUsing);
		base.GetItem(4).SetUIActive(!data.IsUnlocked);
		base.GetItem(5).SetUIActive(data.IsHasRedDot());
		this.SetToggleState(data.IsSelected, true);
	}

	// Token: 0x060131EC RID: 78316 RVA: 0x004BF378 File Offset: 0x004BD578
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null && this.PhoneMsgBgData != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PhoneMsgBgData);
		}
		PhoneMsgBgItemData phoneMsgBgData = this.PhoneMsgBgData;
		if (phoneMsgBgData != null && phoneMsgBgData.IsHasRedDot())
		{
			PhoneMsgModel.Instance.RemoveChatShowRedDotById(this.PhoneMsgBgData.BgId);
			base.GetItem(5).SetUIActive(false);
		}
	}

	// Token: 0x060131ED RID: 78317 RVA: 0x004BF3E4 File Offset: 0x004BD5E4
	public void SetToggleState(bool state, bool isFirstRefresh = false)
	{
		if (this.PhoneMsgBgData == null)
		{
			return;
		}
		this.PhoneMsgBgData.IsSelected = state;
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, isFirstRefresh, isFirstRefresh);
	}

	// Token: 0x060131EE RID: 78318 RVA: 0x004BF41F File Offset: 0x004BD61F
	public void OnSelected()
	{
		this.SetToggleState(true, false);
	}

	// Token: 0x060131EF RID: 78319 RVA: 0x004BF429 File Offset: 0x004BD629
	public void OnDeselected()
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x060131F0 RID: 78320 RVA: 0x004BF434 File Offset: 0x004BD634
	public void RefreshSpeakerNameTextColor(int bgId)
	{
		bool flag = PhoneMsgModel.Instance.IsDefaultChatBg(bgId);
		base.GetText(2).SetUIActive(flag);
		UUIText text = base.GetText(11);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(!flag);
	}

	// Token: 0x060131F1 RID: 78321 RVA: 0x004BF470 File Offset: 0x004BD670
	public void HideRedDot()
	{
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x0400905C RID: 36956
	[Nullable(2)]
	private PhoneMsgBgItemData PhoneMsgBgData;

	// Token: 0x0400905D RID: 36957
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgBgItemData> OnToggleCallBack;
}
