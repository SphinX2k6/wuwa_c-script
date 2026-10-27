using System;
using System.Runtime.CompilerServices;

// Token: 0x020000EB RID: 235
public class SquaredCurve : CurveBase
{
	// Token: 0x06000737 RID: 1847 RVA: 0x00027BD0 File Offset: 0x00025DD0
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

	// Token: 0x06000738 RID: 1848 RVA: 0x00027C62 File Offset: 0x00025E62
	public override float GetCurrentValueInternal(float key)
	{
		return (this.A * key + this.B) * key;
	}

	// Token: 0x040005BF RID: 1471
	private readonly float A;

	// Token: 0x040005C0 RID: 1472
	private readonly float B = 1f;
}
