using System;
using System.Runtime.CompilerServices;

// Token: 0x0200277B RID: 10107
[NullableContext(1)]
[Nullable(0)]
public class InterestItemPosition : InterestItemBase
{
	// Token: 0x1700287B RID: 10363
	// (get) Token: 0x060195BF RID: 103871 RVA: 0x007C047E File Offset: 0x007BE67E
	public override EInterestItemType Type
	{
		get
		{
			return EInterestItemType.Position;
		}
	}

	// Token: 0x060195C0 RID: 103872 RVA: 0x007C0481 File Offset: 0x007BE681
	public override bool GetLocation(Vector outVector)
	{
		outVector.DeepCopy(this.Position);
		return true;
	}

	// Token: 0x060195C1 RID: 103873 RVA: 0x007C0490 File Offset: 0x007BE690
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

	// Token: 0x0400DDF7 RID: 56823
	public Vector Position = Vector.Create();
}
