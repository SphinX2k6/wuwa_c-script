using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001F RID: 31
[NullableContext(2)]
[Nullable(0)]
public struct SeekOnEventArgs
{
	// Token: 0x060000BE RID: 190 RVA: 0x000065C0 File Offset: 0x000047C0
	public SeekOnEventArgs(AActor Actor, int? Handle, bool? SnapToMarker)
	{
		this.Actor = Actor;
		this.Handle = Handle;
		this.SnapToMarker = SnapToMarker;
	}

	// Token: 0x040000AE RID: 174
	public AActor Actor;

	// Token: 0x040000AF RID: 175
	public int? Handle;

	// Token: 0x040000B0 RID: 176
	public bool? SnapToMarker;
}
