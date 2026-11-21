using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x02001A12 RID: 6674
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgThemeItem : SyncGridProxyAbstract<PhoneMsgThemeItemData>
{
	// Token: 0x060106D5 RID: 67285 RVA: 0x004CD69C File Offset: 0x004CB89C
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

	// Token: 0x060106D6 RID: 67286 RVA: 0x004CD75B File Offset: 0x004CB95B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060106D7 RID: 67287 RVA: 0x004CD779 File Offset: 0x004CB979
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060106D8 RID: 67288 RVA: 0x004CD797 File Offset: 0x004CB997
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060106D9 RID: 67289 RVA: 0x004CD79F File Offset: 0x004CB99F
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(5);
		PhoneMsgThemeItemData phoneMsgThemeData = this.PhoneMsgThemeData;
		item.SetUIActive(phoneMsgThemeData != null && phoneMsgThemeData.IsHasRedDot());
	}

	// Token: 0x060106DA RID: 67290 RVA: 0x004CD7C0 File Offset: 0x004CB9C0
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

	// Token: 0x060106DB RID: 67291 RVA: 0x004CD860 File Offset: 0x004CBA60
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

	// Token: 0x060106DC RID: 67292 RVA: 0x004CD8CC File Offset: 0x004CBACC
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

	// Token: 0x060106DD RID: 67293 RVA: 0x004CD907 File Offset: 0x004CBB07
	public void OnSelected()
	{
		this.SetToggleState(true, false);
	}

	// Token: 0x060106DE RID: 67294 RVA: 0x004CD911 File Offset: 0x004CBB11
	public void OnDeselected()
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x060106DF RID: 67295 RVA: 0x004CD91C File Offset: 0x004CBB1C
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

	// Token: 0x060106E0 RID: 67296 RVA: 0x004CD958 File Offset: 0x004CBB58
	public void HideRedDot()
	{
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x040091CC RID: 37324
	[Nullable(2)]
	private PhoneMsgThemeItemData PhoneMsgThemeData;

	// Token: 0x040091CD RID: 37325
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgThemeItemData> OnToggleCallBack;
}
