using System;
using System.Runtime.CompilerServices;

// Token: 0x020000ED RID: 237
public class SquaredCurve : CurveBase
{
	// Token: 0x06000779 RID: 1913 RVA: 0x000281D0 File Offset: 0x000263D0
	[NullableContext(1)]
	public SquaredCurve(params float[] @params) : base(Array.Empty<float>())
	{
		if (@params[0] < 0f || @params[0] > 2f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "二阶曲线配置的Slope不合法，必须大于等于0小于等于2。自动修复为1";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("StartSlope", @params[0]);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.A = 0f;
			this.B = 1f;
			return;
		}
		this.A = 1f - @params[0];
		this.B = @params[0];
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00028262 File Offset: 0x00026462
	public override float GetCurrentValueInternal(float key)
	{
		return (this.A * key + this.B) * key;
	}

	// Token: 0x040005CE RID: 1486
	private readonly float A;

	// Token: 0x040005CF RID: 1487
	private readonly float B = 1f;
}
