using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E0 RID: 224
public class CubicCurveWithStartSlope : CurveBase
{
	// Token: 0x0600071D RID: 1821 RVA: 0x00024F44 File Offset: 0x00023144
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

	// Token: 0x0600071E RID: 1822 RVA: 0x00025000 File Offset: 0x00023200
	public override float GetCurrentValueInternal(float key)
	{
		return ((this.A * key + this.B) * key + this.C) * key;
	}

	// Token: 0x04000599 RID: 1433
	private readonly float A;

	// Token: 0x0400059A RID: 1434
	private readonly float B;

	// Token: 0x0400059B RID: 1435
	private readonly float C = 1f;
}
