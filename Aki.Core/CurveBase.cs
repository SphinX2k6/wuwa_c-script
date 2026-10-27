using System;
using System.Runtime.CompilerServices;

// Token: 0x020000DF RID: 223
public abstract class CurveBase
{
	// Token: 0x060006DE RID: 1758 RVA: 0x00024A48 File Offset: 0x00022C48
	[NullableContext(1)]
	public CurveBase(params float[] @params)
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00024A50 File Offset: 0x00022C50
	public float GetCurrentValue(float key)
	{
		return this.GetCurrentValueInternal(MathUtils.Instance.Clamp(key, 0f, 1f));
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00024A6D File Offset: 0x00022C6D
	public virtual float GetCurrentValueInternal(float key)
	{
		return 0f;
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00024A74 File Offset: 0x00022C74
	public float GetOffsetValue(float key, float delta)
	{
		return this.GetCurrentValue(key + delta) - this.GetCurrentValue(key);
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00024A88 File Offset: 0x00022C88
	public float GetOffsetRate(float key, float delta)
	{
		if (key >= 1f)
		{
			return 1f;
		}
		float currentValue = this.GetCurrentValue(key);
		return (this.GetCurrentValue(key + delta) - currentValue) / (1f - currentValue);
	}
}
