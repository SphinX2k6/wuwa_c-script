using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E1 RID: 225
public abstract class CurveBase
{
	// Token: 0x0600071F RID: 1823 RVA: 0x0002501C File Offset: 0x0002321C
	[NullableContext(1)]
	public CurveBase(params float[] @params)
	{
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00025024 File Offset: 0x00023224
	public float GetCurrentValue(float key)
	{
		return this.GetCurrentValueInternal(MathUtils.Instance.Clamp(key, 0f, 1f));
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00025041 File Offset: 0x00023241
	public virtual float GetCurrentValueInternal(float key)
	{
		return 0f;
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00025048 File Offset: 0x00023248
	public float GetOffsetValue(float key, float delta)
	{
		return this.GetCurrentValue(key + delta) - this.GetCurrentValue(key);
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x0002505C File Offset: 0x0002325C
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
