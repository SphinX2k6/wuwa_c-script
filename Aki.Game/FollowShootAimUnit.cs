using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001408 RID: 5128
public class FollowShootAimUnit : HudUnitBase
{
	// Token: 0x0600CB99 RID: 52121 RVA: 0x003C9524 File Offset: 0x003C7724
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

	// Token: 0x0600CB9A RID: 52122 RVA: 0x003C96BC File Offset: 0x003C78BC
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

	// Token: 0x0600CB9B RID: 52123 RVA: 0x003C9700 File Offset: 0x003C7900
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

	// Token: 0x0600CB9C RID: 52124 RVA: 0x003C9778 File Offset: 0x003C7978
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

	// Token: 0x040073A2 RID: 29602
	[Nullable(1)]
	private readonly List<UUIItem> IconList = new List<UUIItem>();

	// Token: 0x040073A3 RID: 29603
	private bool IsYellowState;

	// Token: 0x040073A4 RID: 29604
	private bool IsAimTarget;

	// Token: 0x020076BA RID: 30394
	private enum EChildType
	{
		// Token: 0x04026903 RID: 157955
		AimTexture1,
		// Token: 0x04026904 RID: 157956
		AimTexture2,
		// Token: 0x04026905 RID: 157957
		AimTexture3,
		// Token: 0x04026906 RID: 157958
		AimTexture4,
		// Token: 0x04026907 RID: 157959
		AimTexture5,
		// Token: 0x04026908 RID: 157960
		AimTexture6,
		// Token: 0x04026909 RID: 157961
		AimTexture7,
		// Token: 0x0402690A RID: 157962
		AimTexture8,
		// Token: 0x0402690B RID: 157963
		AimTexture9,
		// Token: 0x0402690C RID: 157964
		AnimStart,
		// Token: 0x0402690D RID: 157965
		AnimStop
	}
}
