using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020018AE RID: 6318
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalCardBaseItem : GridProxyAbstract<PersonalCardData>
{
	// Token: 0x0600F9BD RID: 63933 RVA: 0x00490334 File Offset: 0x0048E534
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600F9BE RID: 63934 RVA: 0x004903B1 File Offset: 0x0048E5B1
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalCardRead, new Action<int>(this.OnPersonalCardRead));
	}

	// Token: 0x0600F9BF RID: 63935 RVA: 0x004903CF File Offset: 0x0048E5CF
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalCardRead, new Action<int>(this.OnPersonalCardRead));
	}

	// Token: 0x0600F9C0 RID: 63936 RVA: 0x004903F0 File Offset: 0x0048E5F0
	public override void Refresh(PersonalCardData data, bool isSelected, int gridIndex)
	{
		this.CardData = data;
		base.GridIndex = gridIndex;
		this.CardConfig = InventoryConfig.Instance.GetCardItemConfig(data.CardId);
		this.RefreshRedDot(data);
		this.SetToggleState(isSelected);
		base.SetTextureByPath(this.CardConfig.Value.CardPath, base.GetTexture(0), null, null);
	}

	// Token: 0x0600F9C1 RID: 63937 RVA: 0x00490459 File Offset: 0x0048E659
	private void RefreshRedDot(PersonalCardData data)
	{
		base.GetItem(1).SetUIActive(data.IsUnLock && !data.IsRead && this.NeedShowRedDot);
	}

	// Token: 0x0600F9C2 RID: 63938 RVA: 0x00490480 File Offset: 0x0048E680
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.CardData);
		}
	}

	// Token: 0x0600F9C3 RID: 63939 RVA: 0x004904A1 File Offset: 0x0048E6A1
	public void SetNeedShowRedDot(bool state)
	{
		this.NeedShowRedDot = state;
	}

	// Token: 0x0600F9C4 RID: 63940 RVA: 0x004904AA File Offset: 0x0048E6AA
	public void SetToggleCallBack(Action<int, PersonalCardData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600F9C5 RID: 63941 RVA: 0x004904B4 File Offset: 0x0048E6B4
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600F9C6 RID: 63942 RVA: 0x004904DA File Offset: 0x0048E6DA
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600F9C7 RID: 63943 RVA: 0x004904E3 File Offset: 0x0048E6E3
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600F9C8 RID: 63944 RVA: 0x004904EC File Offset: 0x0048E6EC
	public BackgroundCard GetConfig()
	{
		return this.CardConfig.Value;
	}

	// Token: 0x0600F9C9 RID: 63945 RVA: 0x004904F9 File Offset: 0x0048E6F9
	private void OnPersonalCardRead(int cardId)
	{
		if (cardId != this.CardData.CardId)
		{
			return;
		}
		this.RefreshRedDot(this.CardData);
	}

	// Token: 0x04008BB8 RID: 35768
	[Nullable(2)]
	protected PersonalCardData CardData;

	// Token: 0x04008BB9 RID: 35769
	protected BackgroundCard? CardConfig;

	// Token: 0x04008BBA RID: 35770
	protected bool NeedShowRedDot = true;

	// Token: 0x04008BBB RID: 35771
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<int, PersonalCardData> OnToggleCallBack;
}
