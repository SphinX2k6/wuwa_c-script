using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000978 RID: 2424
public class ActivityRoleGuideRoleItem : UiPanelBase
{
	// Token: 0x06006A59 RID: 27225 RVA: 0x00211F3C File Offset: 0x0021013C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006A5A RID: 27226 RVA: 0x00211F84 File Offset: 0x00210184
	protected override void OnBeforeShow()
	{
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null)
		{
			return;
		}
		spine.SetAnimation(0, "idle", true);
	}

	// Token: 0x02006C7E RID: 27774
	private class EComponents
	{
		// Token: 0x04023A53 RID: 146003
		public const int SpineActor = 0;
	}
}
