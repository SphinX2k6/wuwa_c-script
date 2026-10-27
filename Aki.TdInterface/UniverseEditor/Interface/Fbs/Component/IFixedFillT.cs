using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005271 RID: 21105
	public class IFixedFillT
	{
		// Token: 0x17009AA2 RID: 39586
		// (get) Token: 0x06022589 RID: 140681 RVA: 0x004C2D3D File Offset: 0x004C0F3D
		// (set) Token: 0x0602258A RID: 140682 RVA: 0x004C2D45 File Offset: 0x004C0F45
		public EFillType Type { get; set; }

		// Token: 0x17009AA3 RID: 39587
		// (get) Token: 0x0602258B RID: 140683 RVA: 0x004C2D4E File Offset: 0x004C0F4E
		// (set) Token: 0x0602258C RID: 140684 RVA: 0x004C2D56 File Offset: 0x004C0F56
		public int ModelId { get; set; }

		// Token: 0x17009AA4 RID: 39588
		// (get) Token: 0x0602258D RID: 140685 RVA: 0x004C2D5F File Offset: 0x004C0F5F
		// (set) Token: 0x0602258E RID: 140686 RVA: 0x004C2D67 File Offset: 0x004C0F67
		public IPieceIndexT Centre { get; set; }

		// Token: 0x17009AA5 RID: 39589
		// (get) Token: 0x0602258F RID: 140687 RVA: 0x004C2D70 File Offset: 0x004C0F70
		// (set) Token: 0x06022590 RID: 140688 RVA: 0x004C2D78 File Offset: 0x004C0F78
		public IJigsawConfigT Config { get; set; }

		// Token: 0x17009AA6 RID: 39590
		// (get) Token: 0x06022591 RID: 140689 RVA: 0x004C2D81 File Offset: 0x004C0F81
		// (set) Token: 0x06022592 RID: 140690 RVA: 0x004C2D89 File Offset: 0x004C0F89
		public byte NullMask { get; set; }

		// Token: 0x06022593 RID: 140691 RVA: 0x004C2D92 File Offset: 0x004C0F92
		public IFixedFillT()
		{
			this.Type = EFillType.Fixed;
			this.ModelId = 0;
			this.Centre = null;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
