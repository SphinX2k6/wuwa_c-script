using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E4 RID: 228
public class PowerCurve3 : CurveBase
{
	// Token: 0x060006EC RID: 1772 RVA: 0x00024C58 File Offset: 0x00022E58
	[NullableContext(1)]
	public PowerCurve3(params float[] @params) : base(Array.Empty<float>())
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

	// Token: 0x060006ED RID: 1773 RVA: 0x00024CBB File Offset: 0x00022EBB
	public override float GetCurrentValueInternal(float key)
	{
		return (float)Math.Pow((double)key, (double)this.N);
	}

	// Token: 0x04000590 RID: 1424
	private readonly float N;
}
