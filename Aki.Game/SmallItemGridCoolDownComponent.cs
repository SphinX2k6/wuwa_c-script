using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200196F RID: 6511
public class SmallItemGridCoolDownComponent : SmallItemGridComponent
{
	// Token: 0x0600BEB8 RID: 48824 RVA: 0x002B26CC File Offset: 0x002B08CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BEB9 RID: 48825 RVA: 0x002B2738 File Offset: 0x002B0938
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		ISmallItemGridCoolDownComponentParams smallItemGridCoolDownComponentParams = (ISmallItemGridCoolDownComponentParams)tempData;
		float? coolDown = smallItemGridCoolDownComponentParams.CoolDown;
		float? totalCdTime = smallItemGridCoolDownComponentParams.TotalCdTime;
		if (coolDown == null || totalCdTime == null)
		{
			this.SetActive(false);
			return;
		}
		base.GetSprite(0).SetFillAmount(coolDown.Value / totalCdTime.Value);
		this.SetActive(true);
		UUIText text = base.GetText(1);
		if (coolDown.Value < (float)SmallItemGridModel.Instance.ItemGridCoolDownSecond)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "ItemCdTime_Second", new <>z__ReadOnlySingleElementList<object>(coolDown.Value.ToString("F1")));
			return;
		}
		int timeValue = TimeUtil.Instance.CalculateRemainingTime((double)coolDown.Value, CommonDefine.ETimeType.Minute).TimeValue;
		if ((double)coolDown.Value < TimeUtil.Instance.Hour)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "ItemCdTime_Minute", new <>z__ReadOnlySingleElementList<object>(timeValue));
			return;
		}
		if (coolDown.Value < (float)TimeUtil.Instance.OneDaySeconds)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "ItemCdTime_Hour", new <>z__ReadOnlySingleElementList<object>(timeValue));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "ItemCdTime_Day", new <>z__ReadOnlySingleElementList<object>(timeValue));
	}

	// Token: 0x0600BEBA RID: 48826 RVA: 0x002B286F File Offset: 0x002B0A6F
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBCD";
	}

	// Token: 0x0600BEBB RID: 48827 RVA: 0x002B2876 File Offset: 0x002B0A76
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007EBE RID: 32446
	private enum EChildType
	{
		// Token: 0x040296F3 RID: 169715
		CoolDownPercentSprite,
		// Token: 0x040296F4 RID: 169716
		CoolDownText
	}
}
