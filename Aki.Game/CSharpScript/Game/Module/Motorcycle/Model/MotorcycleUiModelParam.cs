using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Motorcycle.Model
{
	// Token: 0x02004376 RID: 17270
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleUiModelParam
	{
		// Token: 0x17005773 RID: 22387
		// (get) Token: 0x0602B9C6 RID: 178630 RVA: 0x00C3E8D3 File Offset: 0x00C3CAD3
		// (set) Token: 0x0602B9C7 RID: 178631 RVA: 0x00C3E8DB File Offset: 0x00C3CADB
		public int FrameId { get; set; }

		// Token: 0x17005774 RID: 22388
		// (get) Token: 0x0602B9C8 RID: 178632 RVA: 0x00C3E8E4 File Offset: 0x00C3CAE4
		// (set) Token: 0x0602B9C9 RID: 178633 RVA: 0x00C3E8EC File Offset: 0x00C3CAEC
		public int[] StickerIds { get; set; }

		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x0602B9CA RID: 178634 RVA: 0x00C3E8F5 File Offset: 0x00C3CAF5
		// (set) Token: 0x0602B9CB RID: 178635 RVA: 0x00C3E8FD File Offset: 0x00C3CAFD
		public int[] DecorationIds { get; set; }
	}
}
