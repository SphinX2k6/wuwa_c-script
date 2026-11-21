using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Container
{
	// Token: 0x0200456A RID: 17770
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkSpritePoolObj : IMarkSpritePoolObj
	{
		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x0602CC6D RID: 183405 RVA: 0x00C8A1EE File Offset: 0x00C883EE
		// (set) Token: 0x0602CC6E RID: 183406 RVA: 0x00C8A1F6 File Offset: 0x00C883F6
		public string SpritePath { get; set; }

		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x0602CC6F RID: 183407 RVA: 0x00C8A1FF File Offset: 0x00C883FF
		// (set) Token: 0x0602CC70 RID: 183408 RVA: 0x00C8A207 File Offset: 0x00C88407
		public double RecycleTimeStamp { get; set; }

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x0602CC71 RID: 183409 RVA: 0x00C8A210 File Offset: 0x00C88410
		// (set) Token: 0x0602CC72 RID: 183410 RVA: 0x00C8A218 File Offset: 0x00C88418
		public ULGUISpriteData_BaseObject Obj { get; set; }

		// Token: 0x17005A39 RID: 23097
		// (get) Token: 0x0602CC73 RID: 183411 RVA: 0x00C8A221 File Offset: 0x00C88421
		// (set) Token: 0x0602CC74 RID: 183412 RVA: 0x00C8A229 File Offset: 0x00C88429
		public int Ref { get; set; }
	}
}
