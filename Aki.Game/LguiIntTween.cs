using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CDB RID: 11483
public class LguiIntTween : LguiTweenBase<int>
{
	// Token: 0x06018186 RID: 98694 RVA: 0x00620E88 File Offset: 0x0061F088
	public LguiIntTween()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenIntSetterDynamic>(new Action<int>(base.PlayFillAmount));
	}

	// Token: 0x06018187 RID: 98695 RVA: 0x00620EA7 File Offset: 0x0061F0A7
	[NullableContext(2)]
	protected override ULTweener CreateTween(int start, int end, float time)
	{
		return ULTweenBPLibrary.IntTo(GlobalData.World, this.Delegate, start, end, time, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06018188 RID: 98696 RVA: 0x00620EC2 File Offset: 0x0061F0C2
	protected override void OnDestroy()
	{
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(base.PlayFillAmount));
	}

	// Token: 0x0400B343 RID: 45891
	[Nullable(1)]
	protected FLTweenIntSetterDynamic Delegate;
}
