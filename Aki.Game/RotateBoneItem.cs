using System;
using System.Runtime.CompilerServices;

// Token: 0x0200263A RID: 9786
[NullableContext(1)]
[Nullable(0)]
public class RotateBoneItem
{
	// Token: 0x060186E1 RID: 100065 RVA: 0x0076099A File Offset: 0x0075EB9A
	public void Set(float startAlpha, float endAlpha, CurveBase curve = null)
	{
		this.StartAlpha = startAlpha;
		this.EndAlpha = endAlpha;
		this.Curve = (curve ?? CurveUtils.DefaultCubic);
	}

	// Token: 0x060186E2 RID: 100066 RVA: 0x007609BA File Offset: 0x0075EBBA
	public float GetBoneAlpha(float time)
	{
		return MathUtils.Instance.Lerp(this.StartAlpha, this.EndAlpha, this.Curve.GetCurrentValue(time));
	}

	// Token: 0x0400D2E8 RID: 53992
	private float StartAlpha;

	// Token: 0x0400D2E9 RID: 53993
	private float EndAlpha = 1f;

	// Token: 0x0400D2EA RID: 53994
	private CurveBase Curve = CurveUtils.DefaultCubic;
}
