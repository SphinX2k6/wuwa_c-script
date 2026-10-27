using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DF RID: 26335
	public class IEntityLookAtT
	{
		// Token: 0x1700C3A6 RID: 50086
		// (get) Token: 0x0602DC8B RID: 187531 RVA: 0x00642F6B File Offset: 0x0064116B
		// (set) Token: 0x0602DC8C RID: 187532 RVA: 0x00642F73 File Offset: 0x00641173
		public int EntityId { get; set; }

		// Token: 0x1700C3A7 RID: 50087
		// (get) Token: 0x0602DC8D RID: 187533 RVA: 0x00642F7C File Offset: 0x0064117C
		// (set) Token: 0x0602DC8E RID: 187534 RVA: 0x00642F84 File Offset: 0x00641184
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C3A8 RID: 50088
		// (get) Token: 0x0602DC8F RID: 187535 RVA: 0x00642F8D File Offset: 0x0064118D
		// (set) Token: 0x0602DC90 RID: 187536 RVA: 0x00642F95 File Offset: 0x00641195
		public bool CameraMove { get; set; }

		// Token: 0x1700C3A9 RID: 50089
		// (get) Token: 0x0602DC91 RID: 187537 RVA: 0x00642F9E File Offset: 0x0064119E
		// (set) Token: 0x0602DC92 RID: 187538 RVA: 0x00642FA6 File Offset: 0x006411A6
		public byte NullMask { get; set; }

		// Token: 0x0602DC93 RID: 187539 RVA: 0x00642FAF File Offset: 0x006411AF
		public IEntityLookAtT()
		{
			this.EntityId = 0;
			this.Pos = null;
			this.CameraMove = false;
			this.NullMask = 0;
		}
	}
}
