using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E9 RID: 29673
	public class IPerformerAiMoveToT
	{
		// Token: 0x1700D9FA RID: 55802
		// (get) Token: 0x06033E8E RID: 212622 RVA: 0x006FFD31 File Offset: 0x006FDF31
		// (set) Token: 0x06033E8F RID: 212623 RVA: 0x006FFD39 File Offset: 0x006FDF39
		public TPerformerAiMoveToConfigUnion Config { get; set; }

		// Token: 0x1700D9FB RID: 55803
		// (get) Token: 0x06033E90 RID: 212624 RVA: 0x006FFD42 File Offset: 0x006FDF42
		// (set) Token: 0x06033E91 RID: 212625 RVA: 0x006FFD4A File Offset: 0x006FDF4A
		public float StopDistance { get; set; }

		// Token: 0x1700D9FC RID: 55804
		// (get) Token: 0x06033E92 RID: 212626 RVA: 0x006FFD53 File Offset: 0x006FDF53
		// (set) Token: 0x06033E93 RID: 212627 RVA: 0x006FFD5B File Offset: 0x006FDF5B
		public byte NullMask { get; set; }

		// Token: 0x06033E94 RID: 212628 RVA: 0x006FFD64 File Offset: 0x006FDF64
		public IPerformerAiMoveToT()
		{
			this.Config = null;
			this.StopDistance = 0f;
			this.NullMask = 0;
		}
	}
}
