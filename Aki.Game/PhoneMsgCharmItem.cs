using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using UnrealEngine;

// Token: 0x02002524 RID: 9508
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgCharmItem : SyncGridProxyAbstract<PhoneMsgCharmItemData>
{
	// Token: 0x060131F3 RID: 78323 RVA: 0x004BF488 File Offset: 0x004BD688
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

	// Token: 0x060131F4 RID: 78324 RVA: 0x004BF547 File Offset: 0x004BD747
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060131F5 RID: 78325 RVA: 0x004BF565 File Offset: 0x004BD765
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060131F6 RID: 78326 RVA: 0x004BF583 File Offset: 0x004BD783
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060131F7 RID: 78327 RVA: 0x004BF58B File Offset: 0x004BD78B
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(5);
		PhoneMsgCharmItemData phoneMsgCharmData = this.PhoneMsgCharmData;
		item.SetUIActive(phoneMsgCharmData != null && phoneMsgCharmData.IsHasRedDot());
	}

	// Token: 0x060131F8 RID: 78328 RVA: 0x004BF5AC File Offset: 0x004BD7AC
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

	// Token: 0x060131F9 RID: 78329 RVA: 0x004BF64C File Offset: 0x004BD84C
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

	// Token: 0x060131FA RID: 78330 RVA: 0x004BF6B8 File Offset: 0x004BD8B8
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

	// Token: 0x060131FB RID: 78331 RVA: 0x004BF6F3 File Offset: 0x004BD8F3
	public void OnSelected()
	{
		this.SetToggleState(true, false);
	}

	// Token: 0x060131FC RID: 78332 RVA: 0x004BF6FD File Offset: 0x004BD8FD
	public void OnDeselected()
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x060131FD RID: 78333 RVA: 0x004BF708 File Offset: 0x004BD908
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

	// Token: 0x060131FE RID: 78334 RVA: 0x004BF744 File Offset: 0x004BD944
	public void HideRedDot()
	{
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x04009065 RID: 36965
	[Nullable(2)]
	private PhoneMsgCharmItemData PhoneMsgCharmData;

	// Token: 0x04009066 RID: 36966
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgCharmItemData> OnToggleCallBack;
}
