using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02002BB7 RID: 11191
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TimeOfDaySecondCircleAttachItem : AutoAttachItem<TimeOfDaySecondItemSt>, IStaticVariableResetter
{
	// Token: 0x06017329 RID: 95017 RVA: 0x005E16C2 File Offset: 0x005DF8C2
	static TimeOfDaySecondCircleAttachItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDaySecondCircleAttachItem.CreateStaticDefaultValue), new Action(TimeOfDaySecondCircleAttachItem.ResetStaticDefaultValue));
	}

	// Token: 0x0601732A RID: 95018 RVA: 0x005E16E1 File Offset: 0x005DF8E1
	public TimeOfDaySecondCircleAttachItem(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x0601732B RID: 95019 RVA: 0x005E170F File Offset: 0x005DF90F
	public static void CreateStaticDefaultValue()
	{
		TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve = null;
	}

	// Token: 0x0601732C RID: 95020 RVA: 0x005E1717 File Offset: 0x005DF917
	public static void ResetStaticDefaultValue()
	{
		TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve = null;
	}

	// Token: 0x0601732D RID: 95021 RVA: 0x005E1720 File Offset: 0x005DF920
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

	// Token: 0x0601732E RID: 95022 RVA: 0x005E18AE File Offset: 0x005DFAAE
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

	// Token: 0x0601732F RID: 95023 RVA: 0x005E18EC File Offset: 0x005DFAEC
	private void RefreshShowText()
	{
		if (this.CurrentItemData != null)
		{
			base.GetText(2).SetText(this.CurrentItemData.ShowName, true);
			string newText = TodDayTime.ConvertToHourMinuteString((double)this.CurrentItemData.SetTime);
			base.GetText(1).SetText(newText, true);
		}
	}

	// Token: 0x06017330 RID: 95024 RVA: 0x005E193C File Offset: 0x005DFB3C
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

	// Token: 0x06017331 RID: 95025 RVA: 0x005E19A0 File Offset: 0x005DFBA0
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

	// Token: 0x06017332 RID: 95026 RVA: 0x005E1CC6 File Offset: 0x005DFEC6
	private void OnClickStoneBtn()
	{
		if (this.CurrentItemData == null)
		{
			return;
		}
		EventSystem.Instance.Emit<TimeOfDaySecondCircleAttachItem>(EEventName.ClickTimeItem, this);
	}

	// Token: 0x06017333 RID: 95027 RVA: 0x005E1CE2 File Offset: 0x005DFEE2
	protected override void OnUnSelect()
	{
	}

	// Token: 0x06017334 RID: 95028 RVA: 0x005E1CE4 File Offset: 0x005DFEE4
	public override void OnSelect()
	{
		TimeOfDayModel.Instance.CurrentSelectTimeItemSt = this.CurrentItemData;
		EventSystem.Instance.Emit(EEventName.OnSelectTimeItem);
	}

	// Token: 0x0400ADAB RID: 44459
	private TimeOfDaySecondItemSt CurrentItemData;

	// Token: 0x0400ADAC RID: 44460
	[Nullable(1)]
	private readonly Rotator ArrowRotator = Rotator.Create();

	// Token: 0x0400ADAD RID: 44461
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0400ADAE RID: 44462
	public static UCurveFloat MiddleOffsetCurve;

	// Token: 0x0400ADAF RID: 44463
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x0400ADB0 RID: 44464
	private const int MIDDLE_TIME = 12;

	// Token: 0x0400ADB1 RID: 44465
	private const int FULL_ANGLE = 360;

	// Token: 0x0400ADB2 RID: 44466
	private const int ONE_HOUR_ANGLE = 30;

	// Token: 0x0400ADB3 RID: 44467
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x0400ADB4 RID: 44468
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x0400ADB5 RID: 44469
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x0400ADB6 RID: 44470
	private const float BORDER_ALPHA = 0.8f;

	// Token: 0x0400ADB7 RID: 44471
	private const float BORDER_RIGHT = 0.65625f;

	// Token: 0x0400ADB8 RID: 44472
	private const float BORDER_LEFT = 0.34375f;

	// Token: 0x0400ADB9 RID: 44473
	private const float BORDER_LEFT_HIDE = 0.03125f;

	// Token: 0x0400ADBA RID: 44474
	private const float BORDER_RIGHT_HIDE = 0.96875f;

	// Token: 0x0400ADBB RID: 44475
	private const float BORDER_MIDDLE = 0.5f;

	// Token: 0x0400ADBC RID: 44476
	private const float STONE2_BORDER_LEFT = 0.375f;

	// Token: 0x0400ADBD RID: 44477
	private const float STONE2_BORDER_RIGHT = 0.625f;

	// Token: 0x0400ADBE RID: 44478
	private const float NIAGARA_MIN_VALUE = 0.2f;

	// Token: 0x0200916F RID: 37231
	[NullableContext(0)]
	private enum ETimeOfDaySecondItemComponents
	{
		// Token: 0x0402F131 RID: 192817
		Arrow,
		// Token: 0x0402F132 RID: 192818
		TimeText,
		// Token: 0x0402F133 RID: 192819
		CurrentTimeShowText,
		// Token: 0x0402F134 RID: 192820
		StoneBtn,
		// Token: 0x0402F135 RID: 192821
		StoneMixTexture,
		// Token: 0x0402F136 RID: 192822
		SelfItem,
		// Token: 0x0402F137 RID: 192823
		EmptyItem,
		// Token: 0x0402F138 RID: 192824
		NotEmptyItem,
		// Token: 0x0402F139 RID: 192825
		NiagaraItem
	}
}
