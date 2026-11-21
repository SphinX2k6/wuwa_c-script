using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002233 RID: 8755
public class LguiFloatTween : LguiTweenBase<float>
{
	// Token: 0x06015A01 RID: 88577 RVA: 0x00646AA7 File Offset: 0x00644CA7
	public LguiFloatTween()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(base.PlayFillAmount));
	}

	// Token: 0x06015A02 RID: 88578 RVA: 0x00646AC6 File Offset: 0x00644CC6
	[NullableContext(2)]
	protected override ULTweener CreateTween(float start, float end, float time)
	{
		return ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, start, end, time, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06015A03 RID: 88579 RVA: 0x00646AE1 File Offset: 0x00644CE1
	protected override void OnDestroy()
	{
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(base.PlayFillAmount));
	}

	// Token: 0x0400B6AE RID: 46766
	[Nullable(1)]
	protected FLTweenFloatSetterDynamic Delegate;
}
