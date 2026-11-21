using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E5 RID: 229
public class PowerCurve2 : CurveBase
{
	// Token: 0x0600072B RID: 1835 RVA: 0x00025184 File Offset: 0x00023384
	[NullableContext(1)]
	public PowerCurve2(params float[] @params) : base(Array.Empty<float>())
	{
		if (@params[0] < 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "幂函数N值不合法，自动修复为0";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("StartSlope", @params[0]);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.N = 0f;
			return;
		}
		this.N = @params[0];
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000251E8 File Offset: 0x000233E8
	public override float GetCurrentValueInternal(float key)
	{
		float value = 2f * key - 1f;
		return (float)(1.0 - (double)Math.Sign(value) * Math.Pow((double)Math.Abs(value), (double)this.N));
	}

	// Token: 0x0400059E RID: 1438
	private readonly float N;
}
