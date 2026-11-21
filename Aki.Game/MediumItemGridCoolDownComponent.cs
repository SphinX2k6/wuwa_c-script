using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DC3 RID: 3523
public class MediumItemGridCoolDownComponent : MediumItemGridComponent
{
	// Token: 0x06008FCD RID: 36813 RVA: 0x002B3C6C File Offset: 0x002B1E6C
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

	// Token: 0x06008FCE RID: 36814 RVA: 0x002B3CD8 File Offset: 0x002B1ED8
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		IMediumItemGridCoolDownComponentParams mediumItemGridCoolDownComponentParams = data as IMediumItemGridCoolDownComponentParams;
		if (mediumItemGridCoolDownComponentParams == null)
		{
			return;
		}
		float? coolDown = mediumItemGridCoolDownComponentParams.CoolDown;
		float? totalCdTime = mediumItemGridCoolDownComponentParams.TotalCdTime;
		if (coolDown == null || coolDown.Value == 0f || totalCdTime == null || totalCdTime.Value == 0f)
		{
			this.SetActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetFillAmount(coolDown.Value / totalCdTime.Value);
		}
		this.SetActive(true);
		UUIText text = base.GetText(1);
		if (coolDown.Value < (float)MediumItemGridModel.Instance.ItemGridCoolDownSecond)
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

	// Token: 0x06008FCF RID: 36815 RVA: 0x002B3E3B File Offset: 0x002B203B
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemCD";
	}

	// Token: 0x06008FD0 RID: 36816 RVA: 0x002B3E42 File Offset: 0x002B2042
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007005 RID: 28677
	private class EChildType
	{
		// Token: 0x0402496A RID: 149866
		public const int CoolDownPercentSprite = 0;

		// Token: 0x0402496B RID: 149867
		public const int CoolDownText = 1;
	}
}
