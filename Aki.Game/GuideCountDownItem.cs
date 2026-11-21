using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001286 RID: 4742
public class GuideCountDownItem : UiPanelBase
{
	// Token: 0x0600BBCD RID: 48077 RVA: 0x0037597B File Offset: 0x00373B7B
	public GuideCountDownItem(float totalCountDown)
	{
		this.TotalCountDown = totalCountDown;
		this.Rotator = Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x0600BBCE RID: 48078 RVA: 0x003759A4 File Offset: 0x00373BA4
	[NullableContext(1)]
	public void Init(UUIItem item)
	{
		base.CreateThenShowByActorAsync(item.GetOwner(), null, false);
	}

	// Token: 0x0600BBCF RID: 48079 RVA: 0x003759B8 File Offset: 0x00373BB8
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

	// Token: 0x0600BBD0 RID: 48080 RVA: 0x00375A24 File Offset: 0x00373C24
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

	// Token: 0x0600BBD1 RID: 48081 RVA: 0x00375A9C File Offset: 0x00373C9C
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

	// Token: 0x04006C06 RID: 27654
	private readonly float TotalCountDown;

	// Token: 0x04006C07 RID: 27655
	[Nullable(1)]
	private readonly Rotator Rotator;

	// Token: 0x04006C08 RID: 27656
	[Nullable(2)]
	private UUISprite CircularItem;

	// Token: 0x04006C09 RID: 27657
	[Nullable(2)]
	private UUIItem NeedleItem;

	// Token: 0x0200751F RID: 29983
	private enum EGuideCountDownItem
	{
		// Token: 0x04026104 RID: 155908
		Circular,
		// Token: 0x04026105 RID: 155909
		Needle2
	}
}
