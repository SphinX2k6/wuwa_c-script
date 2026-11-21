using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x02001A0B RID: 6667
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgCharmItem : SyncGridProxyAbstract<PhoneMsgCharmItemData>
{
	// Token: 0x060106B3 RID: 67251 RVA: 0x004CD194 File Offset: 0x004CB394
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

	// Token: 0x060106B4 RID: 67252 RVA: 0x004CD253 File Offset: 0x004CB453
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060106B5 RID: 67253 RVA: 0x004CD271 File Offset: 0x004CB471
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060106B6 RID: 67254 RVA: 0x004CD28F File Offset: 0x004CB48F
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060106B7 RID: 67255 RVA: 0x004CD297 File Offset: 0x004CB497
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(5);
		PhoneMsgCharmItemData phoneMsgCharmData = this.PhoneMsgCharmData;
		item.SetUIActive(phoneMsgCharmData != null && phoneMsgCharmData.IsHasRedDot());
	}

	// Token: 0x060106B8 RID: 67256 RVA: 0x004CD2B8 File Offset: 0x004CB4B8
	public override void Refresh(PhoneMsgCharmItemData data)
	{
		if (data == null)
		{
			return;
		}
		this.PhoneMsgCharmData = data;
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(data.CharmId);
		if (chatCharmConfig != null)
		{
			base.SetTextureByPath(chatCharmConfig.Value.ChatCharmPathSmall, base.GetTexture(2), null, null);
		}
		base.GetSprite(3).SetUIActive(data.IsUsing);
		base.GetItem(4).SetUIActive(!data.IsUnlocked);
		base.GetItem(5).SetUIActive(data.IsHasRedDot());
		this.SetToggleState(data.IsSelected, true);
	}

	// Token: 0x060106B9 RID: 67257 RVA: 0x004CD358 File Offset: 0x004CB558
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null && this.PhoneMsgCharmData != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PhoneMsgCharmData);
		}
		PhoneMsgCharmItemData phoneMsgCharmData = this.PhoneMsgCharmData;
		if (phoneMsgCharmData != null && phoneMsgCharmData.IsHasRedDot())
		{
			PhoneMsgModel.Instance.RemoveChatShowRedDotById(this.PhoneMsgCharmData.CharmId);
			base.GetItem(5).SetUIActive(false);
		}
	}

	// Token: 0x060106BA RID: 67258 RVA: 0x004CD3C4 File Offset: 0x004CB5C4
	public void SetToggleState(bool state, bool isFirstRefresh = false)
	{
		if (this.PhoneMsgCharmData == null)
		{
			return;
		}
		this.PhoneMsgCharmData.IsSelected = state;
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, isFirstRefresh, isFirstRefresh);
	}

	// Token: 0x060106BB RID: 67259 RVA: 0x004CD3FF File Offset: 0x004CB5FF
	public void OnSelected()
	{
		this.SetToggleState(true, false);
	}

	// Token: 0x060106BC RID: 67260 RVA: 0x004CD409 File Offset: 0x004CB609
	public void OnDeselected()
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x060106BD RID: 67261 RVA: 0x004CD414 File Offset: 0x004CB614
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

	// Token: 0x060106BE RID: 67262 RVA: 0x004CD450 File Offset: 0x004CB650
	public void HideRedDot()
	{
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x040091BA RID: 37306
	[Nullable(2)]
	private PhoneMsgCharmItemData PhoneMsgCharmData;

	// Token: 0x040091BB RID: 37307
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgCharmItemData> OnToggleCallBack;
}
