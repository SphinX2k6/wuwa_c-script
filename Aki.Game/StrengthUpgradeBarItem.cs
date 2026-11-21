using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E11 RID: 7697
public class StrengthUpgradeBarItem : UiPanelBase
{
	// Token: 0x06013044 RID: 77892 RVA: 0x0058F8A1 File Offset: 0x0058DAA1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06013045 RID: 77893 RVA: 0x0058F8DA File Offset: 0x0058DADA
	protected override void OnStart()
	{
		this.LineItemList = new List<UUIItem>();
		this.LineItemList.Add(base.GetItem(1));
	}

	// Token: 0x06013046 RID: 77894 RVA: 0x0058F8F9 File Offset: 0x0058DAF9
	[NullableContext(1)]
	public void Update(IStrengthUpgradeData data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x06013047 RID: 77895 RVA: 0x0058F908 File Offset: 0x0058DB08
	public void Refresh()
	{
		if (this.Data == null)
		{
			return;
		}
		int singleStrengthValue = this.Data.SingleStrengthValue;
		int maxSingleStrengthItemCount = this.Data.MaxSingleStrengthItemCount;
		int num = Math.Min(this.Data.MaxStrength / singleStrengthValue, maxSingleStrengthItemCount);
		this.RefreshLineItem(num);
		base.GetSprite(0).SetFillAmount(1f / (float)num);
	}

	// Token: 0x06013048 RID: 77896 RVA: 0x0058F968 File Offset: 0x0058DB68
	private void RefreshLineItem(int count)
	{
		if (this.LineItemList == null)
		{
			return;
		}
		UUIItem item = base.GetItem(1);
		UUIItem parentAsUIItem = item.GetParentAsUIItem();
		for (int i = this.LineItemList.Count; i < count; i++)
		{
			this.LineItemList.Add(LguiUtil.Instance.CopyItem(item, parentAsUIItem));
		}
		float num = 360f / (float)count;
		float num2 = 0f;
		for (int j = 0; j < count; j++)
		{
			UUIItem uuiitem = this.LineItemList[j];
			this.RotationCache.Yaw = num2;
			uuiitem.SetUIRelativeRotation(this.RotationCache);
			num2 += num;
		}
	}

	// Token: 0x0400A3B1 RID: 41905
	[Nullable(2)]
	private IStrengthUpgradeData Data;

	// Token: 0x0400A3B2 RID: 41906
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> LineItemList;

	// Token: 0x0400A3B3 RID: 41907
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);
}
