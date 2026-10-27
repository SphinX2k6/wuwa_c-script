using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023C9 RID: 9161
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalCardBaseItem : GridProxyAbstract<PersonalCardData>
{
	// Token: 0x0601250B RID: 75019 RVA: 0x00482E34 File Offset: 0x00481034
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

	// Token: 0x0601250C RID: 75020 RVA: 0x00482EB1 File Offset: 0x004810B1
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalCardRead, new Action<int>(this.OnPersonalCardRead));
	}

	// Token: 0x0601250D RID: 75021 RVA: 0x00482ECF File Offset: 0x004810CF
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalCardRead, new Action<int>(this.OnPersonalCardRead));
	}

	// Token: 0x0601250E RID: 75022 RVA: 0x00482EF0 File Offset: 0x004810F0
	public override void Refresh(PersonalCardData data, bool isSelected, int gridIndex)
	{
		this.CardData = data;
		base.GridIndex = gridIndex;
		this.CardConfig = InventoryConfig.Instance.GetCardItemConfig(data.CardId);
		this.RefreshRedDot(data);
		this.SetToggleState(isSelected);
		base.SetTextureByPath(this.CardConfig.Value.CardPath, base.GetTexture(0), null, null);
	}

	// Token: 0x0601250F RID: 75023 RVA: 0x00482F59 File Offset: 0x00481159
	private void RefreshRedDot(PersonalCardData data)
	{
		base.GetItem(1).SetUIActive(data.IsUnLock && !data.IsRead && this.NeedShowRedDot);
	}

	// Token: 0x06012510 RID: 75024 RVA: 0x00482F80 File Offset: 0x00481180
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.CardData);
		}
	}

	// Token: 0x06012511 RID: 75025 RVA: 0x00482FA1 File Offset: 0x004811A1
	public void SetNeedShowRedDot(bool state)
	{
		this.NeedShowRedDot = state;
	}

	// Token: 0x06012512 RID: 75026 RVA: 0x00482FAA File Offset: 0x004811AA
	public void SetToggleCallBack(Action<int, PersonalCardData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x06012513 RID: 75027 RVA: 0x00482FB4 File Offset: 0x004811B4
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06012514 RID: 75028 RVA: 0x00482FDA File Offset: 0x004811DA
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06012515 RID: 75029 RVA: 0x00482FE3 File Offset: 0x004811E3
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06012516 RID: 75030 RVA: 0x00482FEC File Offset: 0x004811EC
	public BackgroundCard GetConfig()
	{
		return this.CardConfig.Value;
	}

	// Token: 0x06012517 RID: 75031 RVA: 0x00482FF9 File Offset: 0x004811F9
	private void OnPersonalCardRead(int cardId)
	{
		if (cardId != this.CardData.CardId)
		{
			return;
		}
		this.RefreshRedDot(this.CardData);
	}

	// Token: 0x04008A71 RID: 35441
	[Nullable(2)]
	protected PersonalCardData CardData;

	// Token: 0x04008A72 RID: 35442
	protected BackgroundCard? CardConfig;

	// Token: 0x04008A73 RID: 35443
	protected bool NeedShowRedDot = true;

	// Token: 0x04008A74 RID: 35444
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<int, PersonalCardData> OnToggleCallBack;
}
