using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002BB8 RID: 11192
[NullableContext(1)]
[Nullable(0)]
public class TimeOfDaySecondCircleItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x06017335 RID: 95029 RVA: 0x005E1D08 File Offset: 0x005DFF08
	public TimeOfDaySecondCircleItem(AActor uiItem) : base(uiItem)
	{
	}

	// Token: 0x06017336 RID: 95030 RVA: 0x005E1D68 File Offset: 0x005DFF68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
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
		this.ComponentRegisterInfos = list;
		Action item = delegate()
		{
			this.OnClickStoneBtn();
		};
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, item);
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017337 RID: 95031 RVA: 0x005E1E95 File Offset: 0x005E0095
	public override void RefreshItem(int showItemIndex)
	{
		this.CurrentShowItemIndex = showItemIndex;
		this.CurrentItemData = this.Data[showItemIndex];
		this.RefreshShowText();
		this.RefreshArrow();
	}

	// Token: 0x06017338 RID: 95032 RVA: 0x005E1EB8 File Offset: 0x005E00B8
	private void RefreshShowText()
	{
		if (this.CurrentItemData != null)
		{
			base.GetText(2).SetText(this.CurrentItemData.ShowName, true);
			string newText = TodDayTime.ConvertToHourMinuteString((double)this.CurrentItemData.SetTime);
			base.GetText(1).SetText(newText, true);
		}
	}

	// Token: 0x06017339 RID: 95033 RVA: 0x005E1F08 File Offset: 0x005E0108
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

	// Token: 0x0601733A RID: 95034 RVA: 0x005E1F6B File Offset: 0x005E016B
	public override void SetData(object param)
	{
		this.Data = (TimeOfDaySecondItemSt[])param;
	}

	// Token: 0x0601733B RID: 95035 RVA: 0x005E1F7C File Offset: 0x005E017C
	public override void OnMoveItem(float offset)
	{
		float width = base.GetAttachItem().ExhibitionView.ItemActor.GetWidth();
		UUIItem rootItem = base.GetRootItem();
		float num = (rootItem.GetAnchorOffsetX() + width / 2f) / width;
		FVector relativeScale3D = rootItem.RelativeScale3D;
		float alpha = 0f;
		float num2;
		if (num > 0.1f && num < 0.5f)
		{
			num2 = (num - 0.1f) / 0.4f;
			alpha = MathUtils.Instance.Lerp(0.65f, 1f, num2);
		}
		else if (num > 0.04f && num < 0.1f)
		{
			num2 = (num - 0.04f) / 0.060000002f;
			alpha = MathUtils.Instance.Lerp(0f, 0.65f, num2);
		}
		else if (num <= 0.04f)
		{
			alpha = 0f;
		}
		if (num >= 0.5f && num < 0.9f)
		{
			num2 = (num - 0.5f) / 0.39999998f;
			alpha = MathUtils.Instance.Lerp(1f, 0.65f, num2);
		}
		else if (num >= 0.9f && num < 0.96f)
		{
			num2 = (num - 0.9f) / 0.060000002f;
			alpha = MathUtils.Instance.Lerp(0.65f, 0f, num2);
		}
		else if (num >= 0.96f)
		{
			alpha = 0f;
		}
		base.GetItem(5).SetAlpha(alpha);
		if (num > 0.3f && num < 0.5f)
		{
			num2 = (num - 0.3f) / 0.19999999f;
			alpha = MathUtils.Instance.Lerp(0f, 1f, num2);
		}
		else if (num >= 0.5f && num < 0.7f)
		{
			num2 = (num - 0.5f) / 0.19999999f;
			alpha = MathUtils.Instance.Lerp(1f, 0f, num2);
		}
		else
		{
			alpha = 0f;
		}
		base.GetTexture(4).SetAlpha(alpha);
		if (num < 0.4f || num > 0.6f)
		{
			if (relativeScale3D.X != this.DefaultScale.X)
			{
				rootItem.SetUIItemScale(this.DefaultScale);
			}
			return;
		}
		if (num >= 0.4f && num <= 0.5f)
		{
			num2 = num - 0.4f;
			float num3 = MathUtils.Instance.Lerp(0.9f, 1f, num2 * 10f);
			FVector uiitemScale = new FVector(num3, num3, num3);
			rootItem.SetUIItemScale(uiitemScale);
			return;
		}
		num2 = num - 0.5f;
		float num4 = MathUtils.Instance.Lerp(1f, 0.9f, num2 * 10f);
		FVector uiitemScale2 = new FVector(num4, num4, num4);
		rootItem.SetUIItemScale(uiitemScale2);
	}

	// Token: 0x0601733C RID: 95036 RVA: 0x005E2222 File Offset: 0x005E0422
	public override void OnUnSelect()
	{
	}

	// Token: 0x0601733D RID: 95037 RVA: 0x005E2224 File Offset: 0x005E0424
	public override void OnSelect()
	{
		TimeOfDayModel.Instance.CurrentSelectTimeItemSt = this.CurrentItemData;
		EventSystem.Instance.Emit(EEventName.OnSelectTimeItem);
	}

	// Token: 0x0400ADBF RID: 44479
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TimeOfDaySecondItemSt[] Data;

	// Token: 0x0400ADC0 RID: 44480
	[Nullable(2)]
	private TimeOfDaySecondItemSt CurrentItemData;

	// Token: 0x0400ADC1 RID: 44481
	private readonly Rotator ArrowRotator = Rotator.Create();

	// Token: 0x0400ADC2 RID: 44482
	private readonly FVector DefaultScale = new FVector(0.9f, 0.9f, 0.9f);

	// Token: 0x0400ADC3 RID: 44483
	private const float ANIMAL_SCALE = 0.9f;

	// Token: 0x0400ADC4 RID: 44484
	private const int MIDDLE_TIME = 12;

	// Token: 0x0400ADC5 RID: 44485
	private const int FULL_ANGLE = 360;

	// Token: 0x0400ADC6 RID: 44486
	private const int ONE_HOUR_ANGLE = 30;

	// Token: 0x0400ADC7 RID: 44487
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x0400ADC8 RID: 44488
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x0400ADC9 RID: 44489
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x0400ADCA RID: 44490
	private const float BORDER_ALPHA = 0.65f;

	// Token: 0x0400ADCB RID: 44491
	private const float BORDER_RIGHT = 0.9f;

	// Token: 0x0400ADCC RID: 44492
	private const float BORDER_LEFT = 0.1f;

	// Token: 0x0400ADCD RID: 44493
	private const float BORDER_LEFT_HIDE = 0.04f;

	// Token: 0x0400ADCE RID: 44494
	private const float BORDER_RIGHT_HIDE = 0.96f;

	// Token: 0x0400ADCF RID: 44495
	private const float BORDER_MIDDLE = 0.5f;

	// Token: 0x0400ADD0 RID: 44496
	private const float STONE2_BORDER_LEFT = 0.3f;

	// Token: 0x0400ADD1 RID: 44497
	private const float STONE2_BORDER_RIGHT = 0.7f;

	// Token: 0x0400ADD2 RID: 44498
	private readonly Action OnClickStoneBtn = delegate()
	{
	};

	// Token: 0x02009170 RID: 37232
	[NullableContext(0)]
	private enum ETimeOfDaySecondItemComponents
	{
		// Token: 0x0402F13B RID: 192827
		Arrow,
		// Token: 0x0402F13C RID: 192828
		TimeText,
		// Token: 0x0402F13D RID: 192829
		CurrentTimeShowText,
		// Token: 0x0402F13E RID: 192830
		StoneBtn,
		// Token: 0x0402F13F RID: 192831
		StoneMixTexture,
		// Token: 0x0402F140 RID: 192832
		SelfItem
	}
}
