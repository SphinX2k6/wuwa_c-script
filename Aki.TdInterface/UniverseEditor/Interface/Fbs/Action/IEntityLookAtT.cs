using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5F RID: 27999
	public class IEntityLookAtT
	{
		// Token: 0x1700CD5C RID: 52572
		// (get) Token: 0x060304C8 RID: 197832 RVA: 0x006904DF File Offset: 0x0068E6DF
		// (set) Token: 0x060304C9 RID: 197833 RVA: 0x006904E7 File Offset: 0x0068E6E7
		public int EntityId { get; set; }

		// Token: 0x1700CD5D RID: 52573
		// (get) Token: 0x060304CA RID: 197834 RVA: 0x006904F0 File Offset: 0x0068E6F0
		// (set) Token: 0x060304CB RID: 197835 RVA: 0x006904F8 File Offset: 0x0068E6F8
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700CD5E RID: 52574
		// (get) Token: 0x060304CC RID: 197836 RVA: 0x00690501 File Offset: 0x0068E701
		// (set) Token: 0x060304CD RID: 197837 RVA: 0x00690509 File Offset: 0x0068E709
		public bool CameraMove { get; set; }

		// Token: 0x1700CD5F RID: 52575
		// (get) Token: 0x060304CE RID: 197838 RVA: 0x00690512 File Offset: 0x0068E712
		// (set) Token: 0x060304CF RID: 197839 RVA: 0x0069051A File Offset: 0x0068E71A
		public byte NullMask { get; set; }

		// Token: 0x060304D0 RID: 197840 RVA: 0x00690523 File Offset: 0x0068E723
		public IEntityLookAtT()
		{
			this.EntityId = 0;
			this.Pos = null;
			this.CameraMove = false;
			this.NullMask = 0;
		}
	}
}
