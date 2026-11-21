using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E4 RID: 228
public class PowerCurve : CurveBase
{
	// Token: 0x06000729 RID: 1833 RVA: 0x000250D4 File Offset: 0x000232D4
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

	// Token: 0x0600072A RID: 1834 RVA: 0x00025138 File Offset: 0x00023338
	public override float GetCurrentValueInternal(float key)
	{
		float value = 2f * key - 1f;
		return (float)((double)Math.Sign(value) * Math.Pow((double)Math.Abs(value), (double)this.N) * 0.5 + 0.5);
	}

	// Token: 0x0400059D RID: 1437
	private readonly float N;
}
