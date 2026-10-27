using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002896 RID: 10390
public class StrengthUpgradeBarItem : UiPanelBase
{
	// Token: 0x06015646 RID: 87622 RVA: 0x00564B45 File Offset: 0x00562D45
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06015647 RID: 87623 RVA: 0x00564B7E File Offset: 0x00562D7E
	protected override void OnStart()
	{
		this.LineItemList = new List<UUIItem>();
		this.LineItemList.Add(base.GetItem(1));
	}

	// Token: 0x06015648 RID: 87624 RVA: 0x00564B9D File Offset: 0x00562D9D
	[NullableContext(1)]
	public void Update(IStrengthUpgradeData data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x06015649 RID: 87625 RVA: 0x00564BAC File Offset: 0x00562DAC
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

	// Token: 0x0601564A RID: 87626 RVA: 0x00564C0C File Offset: 0x00562E0C
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

	// Token: 0x04009FC8 RID: 40904
	[Nullable(2)]
	private IStrengthUpgradeData Data;

	// Token: 0x04009FC9 RID: 40905
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> LineItemList;

	// Token: 0x04009FCA RID: 40906
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);
}
