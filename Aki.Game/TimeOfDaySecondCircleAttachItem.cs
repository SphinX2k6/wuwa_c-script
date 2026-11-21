using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02002132 RID: 8498
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TimeOfDaySecondCircleAttachItem : AutoAttachItem<TimeOfDaySecondItemSt>, IStaticVariableResetter
{
	// Token: 0x06014D5A RID: 85338 RVA: 0x0060E296 File Offset: 0x0060C496
	static TimeOfDaySecondCircleAttachItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDaySecondCircleAttachItem.CreateStaticDefaultValue), new Action(TimeOfDaySecondCircleAttachItem.ResetStaticDefaultValue));
	}

	// Token: 0x06014D5B RID: 85339 RVA: 0x0060E2B5 File Offset: 0x0060C4B5
	public TimeOfDaySecondCircleAttachItem(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x06014D5C RID: 85340 RVA: 0x0060E2E3 File Offset: 0x0060C4E3
	public static void CreateStaticDefaultValue()
	{
		TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve = null;
	}

	// Token: 0x06014D5D RID: 85341 RVA: 0x0060E2EB File Offset: 0x0060C4EB
	public static void ResetStaticDefaultValue()
	{
		TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve = null;
	}

	// Token: 0x06014D5E RID: 85342 RVA: 0x0060E2F4 File Offset: 0x0060C4F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickStoneBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014D5F RID: 85343 RVA: 0x0060E482 File Offset: 0x0060C682
	[NullableContext(1)]
	protected override void OnRefreshItem(TimeOfDaySecondItemSt data)
	{
		this.CurrentItemData = data;
		base.GetItem(6).SetUIActive(data == null);
		base.GetItem(7).SetUIActive(data != null);
		this.RefreshShowText();
		this.RefreshArrow();
		this.OnMoveItem();
	}

	// Token: 0x06014D60 RID: 85344 RVA: 0x0060E4C0 File Offset: 0x0060C6C0
	private void RefreshShowText()
	{
		if (this.CurrentItemData != null)
		{
			base.GetText(2).SetText(this.CurrentItemData.ShowName, true);
			string newText = TodDayTime.ConvertToHourMinuteString((double)this.CurrentItemData.SetTime);
			base.GetText(1).SetText(newText, true);
		}
	}

	// Token: 0x06014D61 RID: 85345 RVA: 0x0060E510 File Offset: 0x0060C710
	private void RefreshArrow()
	{
		if (this.CurrentItemData != null)
		{
			int num = this.CurrentItemData.SetTime / 3600;
			if (num > 12)
			{
				num -= 12;
			}
			int num2 = 360 - 30 * num;
			UUIItem item = base.GetItem(0);
			this.ArrowRotator.Yaw = (float)num2;
			FRotator frotator = this.ArrowRotator.ToUeRotator();
			item.SetUIRelativeRotation(frotator);
		}
	}

	// Token: 0x06014D62 RID: 85346 RVA: 0x0060E574 File Offset: 0x0060C774
	protected override void OnMoveItem()
	{
		float currentMovePercentage = base.GetCurrentMovePercentage();
		FVector relativeScale3D = this.RootItem.RelativeScale3D;
		float num = 0f;
		float num2;
		if (currentMovePercentage >= 0.34375f && currentMovePercentage < 0.5f)
		{
			num2 = (currentMovePercentage - 0.34375f) / 0.15625f;
			num = MathUtils.Instance.Lerp(0.8f, 1f, num2);
		}
		else if (currentMovePercentage > 0.03125f && currentMovePercentage < 0.34375f)
		{
			num2 = (currentMovePercentage - 0.03125f) / 0.3125f;
			num = MathUtils.Instance.Lerp(0.4f, 0.8f, num2);
		}
		else if (currentMovePercentage <= 0.03125f)
		{
			num = 0.4f;
		}
		if (currentMovePercentage >= 0.5f && currentMovePercentage < 0.65625f)
		{
			num2 = (currentMovePercentage - 0.5f) / 0.15625f;
			num = MathUtils.Instance.Lerp(1f, 0.8f, num2);
		}
		else if (currentMovePercentage >= 0.65625f && currentMovePercentage < 0.96875f)
		{
			num2 = (currentMovePercentage - 0.65625f) / 0.3125f;
			num = MathUtils.Instance.Lerp(0.8f, 0.4f, num2);
		}
		else if (currentMovePercentage >= 0.96875f)
		{
			num = 0.4f;
		}
		base.GetItem(5).SetAlpha(num);
		float anchorOffsetX;
		if (currentMovePercentage > 0.375f && currentMovePercentage < 0.5f)
		{
			num2 = (currentMovePercentage - 0.375f) / 0.125f;
			num = MathUtils.Instance.Lerp(0f, 1f, num2);
			UCurveFloat middleOffsetCurve = TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve;
			anchorOffsetX = -((middleOffsetCurve != null) ? middleOffsetCurve.GetFloatValue(1f - num2) : 0f);
		}
		else if (currentMovePercentage >= 0.5f && currentMovePercentage < 0.625f)
		{
			num2 = (currentMovePercentage - 0.5f) / 0.125f;
			num = MathUtils.Instance.Lerp(1f, 0f, num2);
			UCurveFloat middleOffsetCurve2 = TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve;
			anchorOffsetX = ((middleOffsetCurve2 != null) ? middleOffsetCurve2.GetFloatValue(num2) : 0f);
		}
		else
		{
			num = 0f;
			UCurveFloat middleOffsetCurve3 = TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve;
			float num3 = (middleOffsetCurve3 != null) ? middleOffsetCurve3.GetFloatValue(1f) : 0f;
			if (currentMovePercentage < 0.375f)
			{
				anchorOffsetX = -num3;
			}
			else
			{
				anchorOffsetX = num3;
			}
		}
		base.GetItem(7).SetAnchorOffsetX(anchorOffsetX);
		base.GetItem(6).SetAnchorOffsetX(anchorOffsetX);
		base.GetItem(8).SetAlpha(Math.Max(0.2f, num));
		base.GetTexture(4).SetAlpha(num);
		if (currentMovePercentage < 0.4f || currentMovePercentage > 0.6f)
		{
			if (relativeScale3D.X != this.DefaultScale.X)
			{
				this.RootItem.SetUIItemScale(this.DefaultScale);
			}
			return;
		}
		if (currentMovePercentage >= 0.4f && currentMovePercentage <= 0.5f)
		{
			num2 = currentMovePercentage - 0.4f;
			float num4 = MathUtils.Instance.Lerp(0.8f, 1f, num2 * 10f);
			FVector uiitemScale = new FVector(num4, num4, num4);
			uiitemScale.Set(num4, num4, num4);
			this.RootItem.SetUIItemScale(uiitemScale);
			return;
		}
		num2 = currentMovePercentage - 0.5f;
		float num5 = MathUtils.Instance.Lerp(1f, 0.8f, num2 * 10f);
		FVector uiitemScale2 = new FVector(num5, num5, num5);
		this.RootItem.SetUIItemScale(uiitemScale2);
	}

	// Token: 0x06014D63 RID: 85347 RVA: 0x0060E89A File Offset: 0x0060CA9A
	private void OnClickStoneBtn()
	{
		if (this.CurrentItemData == null)
		{
			return;
		}
		EventSystem.Instance.Emit<TimeOfDaySecondCircleAttachItem>(EEventName.ClickTimeItem, this);
	}

	// Token: 0x06014D64 RID: 85348 RVA: 0x0060E8B6 File Offset: 0x0060CAB6
	protected override void OnUnSelect()
	{
	}

	// Token: 0x06014D65 RID: 85349 RVA: 0x0060E8B8 File Offset: 0x0060CAB8
	public override void OnSelect()
	{
		TimeOfDayModel.Instance.CurrentSelectTimeItemSt = this.CurrentItemData;
		EventSystem.Instance.Emit(EEventName.OnSelectTimeItem);
	}

	// Token: 0x0400B1B0 RID: 45488
	private TimeOfDaySecondItemSt CurrentItemData;

	// Token: 0x0400B1B1 RID: 45489
	[Nullable(1)]
	private readonly Rotator ArrowRotator = Rotator.Create();

	// Token: 0x0400B1B2 RID: 45490
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0400B1B3 RID: 45491
	public static UCurveFloat MiddleOffsetCurve;

	// Token: 0x0400B1B4 RID: 45492
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x0400B1B5 RID: 45493
	private const int MIDDLE_TIME = 12;

	// Token: 0x0400B1B6 RID: 45494
	private const int FULL_ANGLE = 360;

	// Token: 0x0400B1B7 RID: 45495
	private const int ONE_HOUR_ANGLE = 30;

	// Token: 0x0400B1B8 RID: 45496
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x0400B1B9 RID: 45497
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x0400B1BA RID: 45498
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x0400B1BB RID: 45499
	private const float BORDER_ALPHA = 0.8f;

	// Token: 0x0400B1BC RID: 45500
	private const float BORDER_RIGHT = 0.65625f;

	// Token: 0x0400B1BD RID: 45501
	private const float BORDER_LEFT = 0.34375f;

	// Token: 0x0400B1BE RID: 45502
	private const float BORDER_LEFT_HIDE = 0.03125f;

	// Token: 0x0400B1BF RID: 45503
	private const float BORDER_RIGHT_HIDE = 0.96875f;

	// Token: 0x0400B1C0 RID: 45504
	private const float BORDER_MIDDLE = 0.5f;

	// Token: 0x0400B1C1 RID: 45505
	private const float STONE2_BORDER_LEFT = 0.375f;

	// Token: 0x0400B1C2 RID: 45506
	private const float STONE2_BORDER_RIGHT = 0.625f;

	// Token: 0x0400B1C3 RID: 45507
	private const float NIAGARA_MIN_VALUE = 0.2f;

	// Token: 0x020083B3 RID: 33715
	[NullableContext(0)]
	private enum ETimeOfDaySecondItemComponents
	{
		// Token: 0x0402A837 RID: 174135
		Arrow,
		// Token: 0x0402A838 RID: 174136
		TimeText,
		// Token: 0x0402A839 RID: 174137
		CurrentTimeShowText,
		// Token: 0x0402A83A RID: 174138
		StoneBtn,
		// Token: 0x0402A83B RID: 174139
		StoneMixTexture,
		// Token: 0x0402A83C RID: 174140
		SelfItem,
		// Token: 0x0402A83D RID: 174141
		EmptyItem,
		// Token: 0x0402A83E RID: 174142
		NotEmptyItem,
		// Token: 0x0402A83F RID: 174143
		NiagaraItem
	}
}
