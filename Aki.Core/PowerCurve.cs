using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E2 RID: 226
public class PowerCurve : CurveBase
{
	// Token: 0x060006E8 RID: 1768 RVA: 0x00024B00 File Offset: 0x00022D00
	[NullableContext(1)]
	public PowerCurve(params float[] @params) : base(Array.Empty<float>())
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

	// Token: 0x060006E9 RID: 1769 RVA: 0x00024B64 File Offset: 0x00022D64
	public override float GetCurrentValueInternal(float key)
	{
		float value = 2f * key - 1f;
		return (float)((double)Math.Sign(value) * Math.Pow((double)Math.Abs(value), (double)this.N) * 0.5 + 0.5);
	}

	// Token: 0x0400058E RID: 1422
	private readonly float N;
}
