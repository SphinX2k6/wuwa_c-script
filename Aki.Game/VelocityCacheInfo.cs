using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200327C RID: 12924
[NullableContext(1)]
[Nullable(0)]
public class VelocityCacheInfo
{
	// Token: 0x0601BF6A RID: 114538 RVA: 0x007C3B44 File Offset: 0x007C1D44
	public string Dump()
	{
		bool isPlayInEditor = GlobalData.IsPlayInEditor;
		string str = "";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Frame, ");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.Frame);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		string str2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[CurZ1, ");
		defaultInterpolatedStringHandler.AppendFormatted<float?>(this.SpeedZ);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		string str3 = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[CurZ2, ");
		defaultInterpolatedStringHandler.AppendFormatted<float?>(this.VelocityZ);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		string str4 = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[LastZ, ");
		defaultInterpolatedStringHandler.AppendFormatted<float?>(this.LastZ);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		string str5 = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Mode, ");
		defaultInterpolatedStringHandler.AppendFormatted<EMovementMode?>(this.MoveMode);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		return str5 + defaultInterpolatedStringHandler.ToStringAndClear() + "[Context, " + this.Context + "]" + "，";
	}

	// Token: 0x0400DCEC RID: 56556
	public long Frame;

	// Token: 0x0400DCED RID: 56557
	public float? SpeedZ;

	// Token: 0x0400DCEE RID: 56558
	public float? VelocityZ;

	// Token: 0x0400DCEF RID: 56559
	public float? LastZ;

	// Token: 0x0400DCF0 RID: 56560
	public EMovementMode? MoveMode;

	// Token: 0x0400DCF1 RID: 56561
	public string Context = "";
}
