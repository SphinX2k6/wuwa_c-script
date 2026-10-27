using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DC4 RID: 7620
public class GuideCountDownItem : UiPanelBase
{
	// Token: 0x0600E7AE RID: 59310 RVA: 0x00369CE7 File Offset: 0x00367EE7
	public GuideCountDownItem(float totalCountDown)
	{
		this.TotalCountDown = totalCountDown;
		this.Rotator = Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x0600E7AF RID: 59311 RVA: 0x00369D10 File Offset: 0x00367F10
	[NullableContext(1)]
	public void Init(UUIItem item)
	{
		base.CreateThenShowByActorAsync(item.GetOwner(), null, false);
	}

	// Token: 0x0600E7B0 RID: 59312 RVA: 0x00369D24 File Offset: 0x00367F24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E7B1 RID: 59313 RVA: 0x00369D90 File Offset: 0x00367F90
	protected override void OnStart()
	{
		this.CircularItem = base.GetSprite(0);
		this.NeedleItem = base.GetSprite(1);
		this.CircularItem.SetFillAmount(1f);
		this.Rotator.Set(0f, 0f, 0f);
		UUIItem needleItem = this.NeedleItem;
		FRotator frotator = this.Rotator.ToUeRotator();
		needleItem.SetUIRelativeRotation(frotator);
		this.RootItem.SetUIActive(true);
	}

	// Token: 0x0600E7B2 RID: 59314 RVA: 0x00369E08 File Offset: 0x00368008
	public void OnDurationChange(float remainDuration)
	{
		if (base.IsShowOrShowing)
		{
			float num = remainDuration / this.TotalCountDown;
			this.CircularItem.SetFillAmount(num);
			this.Rotator.Set(0f, (num - 1f) * 360f, 0f);
			UUIItem needleItem = this.NeedleItem;
			FRotator frotator = this.Rotator.ToUeRotator();
			needleItem.SetUIRelativeRotation(frotator);
		}
	}

	// Token: 0x04006B25 RID: 27429
	private readonly float TotalCountDown;

	// Token: 0x04006B26 RID: 27430
	[Nullable(1)]
	private readonly Rotator Rotator;

	// Token: 0x04006B27 RID: 27431
	[Nullable(2)]
	private UUISprite CircularItem;

	// Token: 0x04006B28 RID: 27432
	[Nullable(2)]
	private UUIItem NeedleItem;

	// Token: 0x02008397 RID: 33687
	private enum EGuideCountDownItem
	{
		// Token: 0x0402ADDE RID: 175582
		Circular,
		// Token: 0x0402ADDF RID: 175583
		Needle2
	}
}
