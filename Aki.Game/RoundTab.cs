using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x0200163E RID: 5694
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RoundTab : AutoAttachItem<RoundTabData>
{
	// Token: 0x17000D8B RID: 3467
	// (get) Token: 0x0600A00E RID: 40974 RVA: 0x0023356F File Offset: 0x0023176F
	// (set) Token: 0x0600A00F RID: 40975 RVA: 0x00233577 File Offset: 0x00231777
	public Action<int> OnClickCallback { get; set; }

	// Token: 0x0600A010 RID: 40976 RVA: 0x00233580 File Offset: 0x00231780
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A011 RID: 40977 RVA: 0x00233668 File Offset: 0x00231868
	public override void OnSelect()
	{
		Action<int> onClickCallback = this.OnClickCallback;
		if (onClickCallback != null)
		{
			onClickCallback(this.Round);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600A012 RID: 40978 RVA: 0x00233696 File Offset: 0x00231896
	protected override void OnUnSelect()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A013 RID: 40979 RVA: 0x002336AD File Offset: 0x002318AD
	protected override void OnMoveItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A014 RID: 40980 RVA: 0x002336C4 File Offset: 0x002318C4
	protected override void OnRefreshItem(RoundTabData data)
	{
		if (data == null)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(false);
			}
			int currentShowItemIndex = base.GetCurrentShowItemIndex();
			int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
			if (currentShowItemIndex < 0)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetAlpha(0f);
				return;
			}
			else if (WheelTowerModel.Instance.IsLastRound(maxChallengeRound, null) || currentShowItemIndex > maxChallengeRound + 1)
			{
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetAlpha(0f);
				return;
			}
			else
			{
				UUIItem rootItem3 = this.RootItem;
				if (rootItem3 != null)
				{
					rootItem3.SetAlpha(1f);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_RoundSelectTab", new <>z__ReadOnlySingleElementList<object>(currentShowItemIndex + 1));
				UUIItem item = base.GetItem(3);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
				return;
			}
		}
		else
		{
			this.Round = data.Round;
			UUIItem rootItem4 = this.RootItem;
			if (rootItem4 != null)
			{
				rootItem4.SetAlpha(1f);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_RoundSelectTab", new <>z__ReadOnlySingleElementList<object>(this.Round + 1));
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsLock);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetSelfInteractive(!data.IsLock);
			return;
		}
	}

	// Token: 0x0600A015 RID: 40981 RVA: 0x00233819 File Offset: 0x00231A19
	private void OnClickToggle(EToggleState state)
	{
		this.OnSelect();
	}

	// Token: 0x0600A016 RID: 40982 RVA: 0x00233821 File Offset: 0x00231A21
	public RoundTab() : base(null)
	{
	}

	// Token: 0x040048CE RID: 18638
	private int Round = -1;
}
