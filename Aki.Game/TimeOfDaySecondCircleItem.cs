using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002133 RID: 8499
[NullableContext(1)]
[Nullable(0)]
public class TimeOfDaySecondCircleItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x06014D66 RID: 85350 RVA: 0x0060E8DC File Offset: 0x0060CADC
	public TimeOfDaySecondCircleItem(AActor uiItem) : base(uiItem)
	{
	}

	// Token: 0x06014D67 RID: 85351 RVA: 0x0060E93C File Offset: 0x0060CB3C
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

	// Token: 0x06014D68 RID: 85352 RVA: 0x0060EA69 File Offset: 0x0060CC69
	public override void RefreshItem(int showItemIndex)
	{
		this.CurrentShowItemIndex = showItemIndex;
		this.CurrentItemData = this.Data[showItemIndex];
		this.RefreshShowText();
		this.RefreshArrow();
	}

	// Token: 0x06014D69 RID: 85353 RVA: 0x0060EA8C File Offset: 0x0060CC8C
	private void RefreshShowText()
	{
		if (this.CurrentItemData != null)
		{
			base.GetText(2).SetText(this.CurrentItemData.ShowName, true);
			string newText = TodDayTime.ConvertToHourMinuteString((double)this.CurrentItemData.SetTime);
			base.GetText(1).SetText(newText, true);
		}
	}

	// Token: 0x06014D6A RID: 85354 RVA: 0x0060EADC File Offset: 0x0060CCDC
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

	// Token: 0x06014D6B RID: 85355 RVA: 0x0060EB3F File Offset: 0x0060CD3F
	public override void SetData(object param)
	{
		this.Data = (TimeOfDaySecondItemSt[])param;
	}

	// Token: 0x06014D6C RID: 85356 RVA: 0x0060EB50 File Offset: 0x0060CD50
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

	// Token: 0x06014D6D RID: 85357 RVA: 0x0060EDF6 File Offset: 0x0060CFF6
	public override void OnUnSelect()
	{
	}

	// Token: 0x06014D6E RID: 85358 RVA: 0x0060EDF8 File Offset: 0x0060CFF8
	public override void OnSelect()
	{
		TimeOfDayModel.Instance.CurrentSelectTimeItemSt = this.CurrentItemData;
		EventSystem.Instance.Emit(EEventName.OnSelectTimeItem);
	}

	// Token: 0x0400B1C4 RID: 45508
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TimeOfDaySecondItemSt[] Data;

	// Token: 0x0400B1C5 RID: 45509
	[Nullable(2)]
	private TimeOfDaySecondItemSt CurrentItemData;

	// Token: 0x0400B1C6 RID: 45510
	private readonly Rotator ArrowRotator = Rotator.Create();

	// Token: 0x0400B1C7 RID: 45511
	private readonly FVector DefaultScale = new FVector(0.9f, 0.9f, 0.9f);

	// Token: 0x0400B1C8 RID: 45512
	private const float ANIMAL_SCALE = 0.9f;

	// Token: 0x0400B1C9 RID: 45513
	private const int MIDDLE_TIME = 12;

	// Token: 0x0400B1CA RID: 45514
	private const int FULL_ANGLE = 360;

	// Token: 0x0400B1CB RID: 45515
	private const int ONE_HOUR_ANGLE = 30;

	// Token: 0x0400B1CC RID: 45516
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x0400B1CD RID: 45517
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x0400B1CE RID: 45518
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x0400B1CF RID: 45519
	private const float BORDER_ALPHA = 0.65f;

	// Token: 0x0400B1D0 RID: 45520
	private const float BORDER_RIGHT = 0.9f;

	// Token: 0x0400B1D1 RID: 45521
	private const float BORDER_LEFT = 0.1f;

	// Token: 0x0400B1D2 RID: 45522
	private const float BORDER_LEFT_HIDE = 0.04f;

	// Token: 0x0400B1D3 RID: 45523
	private const float BORDER_RIGHT_HIDE = 0.96f;

	// Token: 0x0400B1D4 RID: 45524
	private const float BORDER_MIDDLE = 0.5f;

	// Token: 0x0400B1D5 RID: 45525
	private const float STONE2_BORDER_LEFT = 0.3f;

	// Token: 0x0400B1D6 RID: 45526
	private const float STONE2_BORDER_RIGHT = 0.7f;

	// Token: 0x0400B1D7 RID: 45527
	private readonly Action OnClickStoneBtn = delegate()
	{
	};

	// Token: 0x020083B4 RID: 33716
	[NullableContext(0)]
	private enum ETimeOfDaySecondItemComponents
	{
		// Token: 0x0402A841 RID: 174145
		Arrow,
		// Token: 0x0402A842 RID: 174146
		TimeText,
		// Token: 0x0402A843 RID: 174147
		CurrentTimeShowText,
		// Token: 0x0402A844 RID: 174148
		StoneBtn,
		// Token: 0x0402A845 RID: 174149
		StoneMixTexture,
		// Token: 0x0402A846 RID: 174150
		SelfItem
	}
}
