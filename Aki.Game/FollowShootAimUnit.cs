using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001F46 RID: 8006
public class FollowShootAimUnit : HudUnitBase
{
	// Token: 0x0600F77A RID: 63354 RVA: 0x003BDA38 File Offset: 0x003BBC38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F77B RID: 63355 RVA: 0x003BDBD0 File Offset: 0x003BBDD0
	protected override void OnStart()
	{
		base.OnStart();
		base.InitTweenAnim(9);
		base.InitTweenAnim(10);
		for (int i = 0; i <= 8; i++)
		{
			this.IconList.Add(base.GetTexture(i));
		}
	}

	// Token: 0x0600F77C RID: 63356 RVA: 0x003BDC14 File Offset: 0x003BBE14
	public void RefreshState(bool isYellow, bool bForce = false)
	{
		if (this.IsYellowState == isYellow && !bForce)
		{
			return;
		}
		this.IsYellowState = isYellow;
		foreach (UUIItem uuiitem in this.IconList)
		{
			UUIItem uuiitem2 = uuiitem;
			FColor? fcolor = new FColor?(uuiitem.changeColor);
			uuiitem2.SetChangeColor(isYellow, fcolor);
		}
	}

	// Token: 0x0600F77D RID: 63357 RVA: 0x003BDC8C File Offset: 0x003BBE8C
	public void SetIsAimTarget(bool isAimTarget)
	{
		if (this.IsAimTarget == isAimTarget)
		{
			return;
		}
		this.IsAimTarget = isAimTarget;
		if (this.IsAimTarget)
		{
			base.StopTweenAnim(10);
			base.PlayTweenAnim(9);
			return;
		}
		base.StopTweenAnim(9);
		base.PlayTweenAnim(10);
	}

	// Token: 0x040072C1 RID: 29377
	[Nullable(1)]
	private readonly List<UUIItem> IconList = new List<UUIItem>();

	// Token: 0x040072C2 RID: 29378
	private bool IsYellowState;

	// Token: 0x040072C3 RID: 29379
	private bool IsAimTarget;

	// Token: 0x02008535 RID: 34101
	private enum EChildType
	{
		// Token: 0x0402B5DF RID: 177631
		AimTexture1,
		// Token: 0x0402B5E0 RID: 177632
		AimTexture2,
		// Token: 0x0402B5E1 RID: 177633
		AimTexture3,
		// Token: 0x0402B5E2 RID: 177634
		AimTexture4,
		// Token: 0x0402B5E3 RID: 177635
		AimTexture5,
		// Token: 0x0402B5E4 RID: 177636
		AimTexture6,
		// Token: 0x0402B5E5 RID: 177637
		AimTexture7,
		// Token: 0x0402B5E6 RID: 177638
		AimTexture8,
		// Token: 0x0402B5E7 RID: 177639
		AimTexture9,
		// Token: 0x0402B5E8 RID: 177640
		AnimStart,
		// Token: 0x0402B5E9 RID: 177641
		AnimStop
	}
}
