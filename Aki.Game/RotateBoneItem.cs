using System;
using System.Runtime.CompilerServices;

// Token: 0x020030E2 RID: 12514
[NullableContext(1)]
[Nullable(0)]
public class RotateBoneItem
{
	// Token: 0x0601ACC5 RID: 109765 RVA: 0x0073AF5E File Offset: 0x0073915E
	public void Set(float startAlpha, float endAlpha, CurveBase curve = null)
	{
		this.StartAlpha = startAlpha;
		this.EndAlpha = endAlpha;
		this.Curve = (curve ?? CurveUtils.DefaultCubic);
	}

	// Token: 0x0601ACC6 RID: 109766 RVA: 0x0073AF7E File Offset: 0x0073917E
	public float GetBoneAlpha(float time)
	{
		return MathUtils.Instance.Lerp(this.StartAlpha, this.EndAlpha, this.Curve.GetCurrentValue(time));
	}

	// Token: 0x0400CEF8 RID: 52984
	private float StartAlpha;

	// Token: 0x0400CEF9 RID: 52985
	private float EndAlpha = 1f;

	// Token: 0x0400CEFA RID: 52986
	private CurveBase Curve = CurveUtils.DefaultCubic;
}
