using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CDA RID: 11482
public class LguiFloatTween : LguiTweenBase<float>
{
	// Token: 0x06018183 RID: 98691 RVA: 0x00620E3B File Offset: 0x0061F03B
	public LguiFloatTween()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(base.PlayFillAmount));
	}

	// Token: 0x06018184 RID: 98692 RVA: 0x00620E5A File Offset: 0x0061F05A
	[NullableContext(2)]
	protected override ULTweener CreateTween(float start, float end, float time)
	{
		return ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, start, end, time, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06018185 RID: 98693 RVA: 0x00620E75 File Offset: 0x0061F075
	protected override void OnDestroy()
	{
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(base.PlayFillAmount));
	}

	// Token: 0x0400B342 RID: 45890
	[Nullable(1)]
	protected FLTweenFloatSetterDynamic Delegate;
}
