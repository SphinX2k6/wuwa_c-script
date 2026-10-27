using System;
using System.Runtime.CompilerServices;

// Token: 0x0200320C RID: 12812
[NullableContext(1)]
[Nullable(0)]
public class InterestItemPosition : InterestItemBase
{
	// Token: 0x1700263A RID: 9786
	// (get) Token: 0x0601BA3A RID: 113210 RVA: 0x00797D1E File Offset: 0x00795F1E
	public override EInterestItemType Type
	{
		get
		{
			return EInterestItemType.Position;
		}
	}

	// Token: 0x0601BA3B RID: 113211 RVA: 0x00797D21 File Offset: 0x00795F21
	public override bool GetLocation(Vector outVector)
	{
		outVector.DeepCopy(this.Position);
		return true;
	}

	// Token: 0x0601BA3C RID: 113212 RVA: 0x00797D30 File Offset: 0x00795F30
	public override string GetDebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 3);
		defaultInterpolatedStringHandler.AppendLiteral("X: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Position.X);
		defaultInterpolatedStringHandler.AppendLiteral(", Y: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Position.Y);
		defaultInterpolatedStringHandler.AppendLiteral(", Z: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Position.Z);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400D958 RID: 55640
	public Vector Position = Vector.Create();
}
