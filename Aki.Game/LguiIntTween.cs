using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002234 RID: 8756
public class LguiIntTween : LguiTweenBase<int>
{
	// Token: 0x06015A04 RID: 88580 RVA: 0x00646AF4 File Offset: 0x00644CF4
	public LguiIntTween()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenIntSetterDynamic>(new Action<int>(base.PlayFillAmount));
	}

	// Token: 0x06015A05 RID: 88581 RVA: 0x00646B13 File Offset: 0x00644D13
	[NullableContext(2)]
	protected override ULTweener CreateTween(int start, int end, float time)
	{
		return ULTweenBPLibrary.IntTo(GlobalData.World, this.Delegate, start, end, time, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06015A06 RID: 88582 RVA: 0x00646B2E File Offset: 0x00644D2E
	protected override void OnDestroy()
	{
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(base.PlayFillAmount));
	}

	// Token: 0x0400B6AF RID: 46767
	[Nullable(1)]
	protected FLTweenIntSetterDynamic Delegate;
}
