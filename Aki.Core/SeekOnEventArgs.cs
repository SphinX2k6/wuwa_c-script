using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001F RID: 31
[NullableContext(2)]
[Nullable(0)]
public struct SeekOnEventArgs
{
	// Token: 0x060000BC RID: 188 RVA: 0x00006848 File Offset: 0x00004A48
	public SeekOnEventArgs(AActor Actor, int? Handle, bool? SnapToMarker)
	{
		this.Actor = Actor;
		this.Handle = Handle;
		this.SnapToMarker = SnapToMarker;
	}

	// Token: 0x040000AD RID: 173
	public AActor Actor;

	// Token: 0x040000AE RID: 174
	public int? Handle;

	// Token: 0x040000AF RID: 175
	public bool? SnapToMarker;
}
