using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x0200252B RID: 9515
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgThemeItem : SyncGridProxyAbstract<PhoneMsgThemeItemData>
{
	// Token: 0x06013215 RID: 78357 RVA: 0x004BF990 File Offset: 0x004BDB90
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

	// Token: 0x06013216 RID: 78358 RVA: 0x004BFA4F File Offset: 0x004BDC4F
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x06013217 RID: 78359 RVA: 0x004BFA6D File Offset: 0x004BDC6D
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x06013218 RID: 78360 RVA: 0x004BFA8B File Offset: 0x004BDC8B
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06013219 RID: 78361 RVA: 0x004BFA93 File Offset: 0x004BDC93
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(5);
		PhoneMsgThemeItemData phoneMsgThemeData = this.PhoneMsgThemeData;
		item.SetUIActive(phoneMsgThemeData != null && phoneMsgThemeData.IsHasRedDot());
	}

	// Token: 0x0601321A RID: 78362 RVA: 0x004BFAB4 File Offset: 0x004BDCB4
	public override void Refresh(PhoneMsgThemeItemData data)
	{
		if (data == null)
		{
			return;
		}
		this.PhoneMsgThemeData = data;
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(data.ThemeId);
		if (chatThemeConfig != null)
		{
			base.SetTextureByPath(chatThemeConfig.Value.ChatThemePathSmall, base.GetTexture(2), null, null);
		}
		base.GetSprite(3).SetUIActive(data.IsUsing);
		base.GetItem(4).SetUIActive(!data.IsUnlocked);
		base.GetItem(5).SetUIActive(data.IsHasRedDot());
		this.SetToggleState(data.IsSelected, true);
	}

	// Token: 0x0601321B RID: 78363 RVA: 0x004BFB54 File Offset: 0x004BDD54
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null && this.PhoneMsgThemeData != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PhoneMsgThemeData);
		}
		PhoneMsgThemeItemData phoneMsgThemeData = this.PhoneMsgThemeData;
		if (phoneMsgThemeData != null && phoneMsgThemeData.IsHasRedDot())
		{
			PhoneMsgModel.Instance.RemoveChatShowRedDotById(this.PhoneMsgThemeData.ThemeId);
			base.GetItem(5).SetUIActive(false);
		}
	}

	// Token: 0x0601321C RID: 78364 RVA: 0x004BFBC0 File Offset: 0x004BDDC0
	public void SetToggleState(bool state, bool isFirstRefresh = false)
	{
		if (this.PhoneMsgThemeData == null)
		{
			return;
		}
		this.PhoneMsgThemeData.IsSelected = state;
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, isFirstRefresh, isFirstRefresh);
	}

	// Token: 0x0601321D RID: 78365 RVA: 0x004BFBFB File Offset: 0x004BDDFB
	public void OnSelected()
	{
		this.SetToggleState(true, false);
	}

	// Token: 0x0601321E RID: 78366 RVA: 0x004BFC05 File Offset: 0x004BDE05
	public void OnDeselected()
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x0601321F RID: 78367 RVA: 0x004BFC10 File Offset: 0x004BDE10
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

	// Token: 0x06013220 RID: 78368 RVA: 0x004BFC4C File Offset: 0x004BDE4C
	public void HideRedDot()
	{
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x04009077 RID: 36983
	[Nullable(2)]
	private PhoneMsgThemeItemData PhoneMsgThemeData;

	// Token: 0x04009078 RID: 36984
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgThemeItemData> OnToggleCallBack;
}
