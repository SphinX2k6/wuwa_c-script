using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200190A RID: 6410
public class MediumItemGridCoolDownComponent : MediumItemGridComponent
{
	// Token: 0x0600BBE3 RID: 48099 RVA: 0x002A9510 File Offset: 0x002A7710
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

	// Token: 0x0600BBE4 RID: 48100 RVA: 0x002A957C File Offset: 0x002A777C
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

	// Token: 0x0600BBE5 RID: 48101 RVA: 0x002A96DF File Offset: 0x002A78DF
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemCD";
	}

	// Token: 0x0600BBE6 RID: 48102 RVA: 0x002A96E6 File Offset: 0x002A78E6
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007E7E RID: 32382
	private class EChildType
	{
		// Token: 0x0402963E RID: 169534
		public const int CoolDownPercentSprite = 0;

		// Token: 0x0402963F RID: 169535
		public const int CoolDownText = 1;
	}
}
