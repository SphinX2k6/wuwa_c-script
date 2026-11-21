using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E6 RID: 230
public class PowerCurve3 : CurveBase
{
	// Token: 0x0600072D RID: 1837 RVA: 0x0002522C File Offset: 0x0002342C
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

	// Token: 0x0600072E RID: 1838 RVA: 0x0002528F File Offset: 0x0002348F
	public override float GetCurrentValueInternal(float key)
	{
		return (float)Math.Pow((double)key, (double)this.N);
	}

	// Token: 0x0400059F RID: 1439
	private readonly float N;
}
