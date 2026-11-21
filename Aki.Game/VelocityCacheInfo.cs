using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020027EC RID: 10220
[NullableContext(1)]
[Nullable(0)]
public class VelocityCacheInfo
{
	// Token: 0x06019B5A RID: 105306 RVA: 0x007EAF00 File Offset: 0x007E9100
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

	// Token: 0x0400E18E RID: 57742
	public long Frame;

	// Token: 0x0400E18F RID: 57743
	public float? SpeedZ;

	// Token: 0x0400E190 RID: 57744
	public float? VelocityZ;

	// Token: 0x0400E191 RID: 57745
	public float? LastZ;

	// Token: 0x0400E192 RID: 57746
	public EMovementMode? MoveMode;

	// Token: 0x0400E193 RID: 57747
	public string Context = "";
}
