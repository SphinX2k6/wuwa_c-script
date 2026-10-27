using System;
using System.Runtime.CompilerServices;

// Token: 0x020000DE RID: 222
public class CubicCurveWithStartSlope : CurveBase
{
	// Token: 0x060006DC RID: 1756 RVA: 0x00024970 File Offset: 0x00022B70
	[NullableContext(1)]
	public CubicCurveWithStartSlope(params float[] @params) : base(Array.Empty<float>())
	{
		if (@params[0] <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "三阶曲线配置的Slope不合法，必须大于0。自动修复为1";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("StartSlope", @params[0]);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.A = 0f;
			this.B = 0f;
			this.C = 1f;
			return;
		}
		this.A = @params[0] + 1f / @params[0] - 2f;
		this.B = 3f - 2f * @params[0] - 1f / @params[0];
		this.C = @params[0];
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00024A2C File Offset: 0x00022C2C
	public override float GetCurrentValueInternal(float key)
	{
		return ((this.A * key + this.B) * key + this.C) * key;
	}

	// Token: 0x0400058A RID: 1418
	private readonly float A;

	// Token: 0x0400058B RID: 1419
	private readonly float B;

	// Token: 0x0400058C RID: 1420
	private readonly float C = 1f;
}
