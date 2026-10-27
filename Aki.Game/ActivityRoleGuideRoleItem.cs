using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014C4 RID: 5316
public class ActivityRoleGuideRoleItem : UiPanelBase
{
	// Token: 0x060096C4 RID: 38596 RVA: 0x00208FD0 File Offset: 0x002071D0
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

	// Token: 0x060096C5 RID: 38597 RVA: 0x00209018 File Offset: 0x00207218
	protected override void OnBeforeShow()
	{
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null)
		{
			return;
		}
		spine.SetAnimation(0, "idle", true);
	}

	// Token: 0x02007AFA RID: 31482
	private class EComponents
	{
		// Token: 0x04028739 RID: 165689
		public const int SpineActor = 0;
	}
}
