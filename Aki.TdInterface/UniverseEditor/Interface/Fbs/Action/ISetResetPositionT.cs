using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007068 RID: 28776
	public class ISetResetPositionT
	{
		// Token: 0x1700D5E3 RID: 54755
		// (get) Token: 0x06032F3C RID: 208700 RVA: 0x006DFAC2 File Offset: 0x006DDCC2
		// (set) Token: 0x06032F3D RID: 208701 RVA: 0x006DFACA File Offset: 0x006DDCCA
		public ESetTeleControlType Type { get; set; }

		// Token: 0x1700D5E4 RID: 54756
		// (get) Token: 0x06032F3E RID: 208702 RVA: 0x006DFAD3 File Offset: 0x006DDCD3
		// (set) Token: 0x06032F3F RID: 208703 RVA: 0x006DFADB File Offset: 0x006DDCDB
		public int EntityId { get; set; }

		// Token: 0x1700D5E5 RID: 54757
		// (get) Token: 0x06032F40 RID: 208704 RVA: 0x006DFAE4 File Offset: 0x006DDCE4
		// (set) Token: 0x06032F41 RID: 208705 RVA: 0x006DFAEC File Offset: 0x006DDCEC
		public int PositionEntityId { get; set; }

		// Token: 0x06032F42 RID: 208706 RVA: 0x006DFAF5 File Offset: 0x006DDCF5
		public ISetResetPositionT()
		{
			this.Type = ESetTeleControlType.OpenGravity;
			this.EntityId = 0;
			this.PositionEntityId = 0;
		}
	}
}
