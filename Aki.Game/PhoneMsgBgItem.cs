using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x02001A09 RID: 6665
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgBgItem : SyncGridProxyAbstract<PhoneMsgBgItemData>
{
	// Token: 0x060106A6 RID: 67238 RVA: 0x004CCEC0 File Offset: 0x004CB0C0
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

	// Token: 0x060106A7 RID: 67239 RVA: 0x004CCF7F File Offset: 0x004CB17F
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060106A8 RID: 67240 RVA: 0x004CCF9D File Offset: 0x004CB19D
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060106A9 RID: 67241 RVA: 0x004CCFBB File Offset: 0x004CB1BB
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060106AA RID: 67242 RVA: 0x004CCFC3 File Offset: 0x004CB1C3
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(5);
		PhoneMsgBgItemData phoneMsgBgData = this.PhoneMsgBgData;
		item.SetUIActive(phoneMsgBgData != null && phoneMsgBgData.IsHasRedDot());
	}

	// Token: 0x060106AB RID: 67243 RVA: 0x004CCFE4 File Offset: 0x004CB1E4
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

	// Token: 0x060106AC RID: 67244 RVA: 0x004CD084 File Offset: 0x004CB284
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

	// Token: 0x060106AD RID: 67245 RVA: 0x004CD0F0 File Offset: 0x004CB2F0
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

	// Token: 0x060106AE RID: 67246 RVA: 0x004CD12B File Offset: 0x004CB32B
	public void OnSelected()
	{
		this.SetToggleState(true, false);
	}

	// Token: 0x060106AF RID: 67247 RVA: 0x004CD135 File Offset: 0x004CB335
	public void OnDeselected()
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x060106B0 RID: 67248 RVA: 0x004CD140 File Offset: 0x004CB340
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

	// Token: 0x060106B1 RID: 67249 RVA: 0x004CD17C File Offset: 0x004CB37C
	public void HideRedDot()
	{
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x040091B1 RID: 37297
	[Nullable(2)]
	private PhoneMsgBgItemData PhoneMsgBgData;

	// Token: 0x040091B2 RID: 37298
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgBgItemData> OnToggleCallBack;
}
