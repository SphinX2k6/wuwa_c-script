using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0A RID: 23562
	public class INpcStandbySitT
	{
		// Token: 0x1700AC7B RID: 44155
		// (get) Token: 0x06026F00 RID: 159488 RVA: 0x0055492B File Offset: 0x00552B2B
		// (set) Token: 0x06026F01 RID: 159489 RVA: 0x00554933 File Offset: 0x00552B33
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700AC7C RID: 44156
		// (get) Token: 0x06026F02 RID: 159490 RVA: 0x0055493C File Offset: 0x00552B3C
		// (set) Token: 0x06026F03 RID: 159491 RVA: 0x00554944 File Offset: 0x00552B44
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700AC7D RID: 44157
		// (get) Token: 0x06026F04 RID: 159492 RVA: 0x0055494D File Offset: 0x00552B4D
		// (set) Token: 0x06026F05 RID: 159493 RVA: 0x00554955 File Offset: 0x00552B55
		public string Montage { get; set; }

		// Token: 0x1700AC7E RID: 44158
		// (get) Token: 0x06026F06 RID: 159494 RVA: 0x0055495E File Offset: 0x00552B5E
		// (set) Token: 0x06026F07 RID: 159495 RVA: 0x00554966 File Offset: 0x00552B66
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700AC7F RID: 44159
		// (get) Token: 0x06026F08 RID: 159496 RVA: 0x0055496F File Offset: 0x00552B6F
		// (set) Token: 0x06026F09 RID: 159497 RVA: 0x00554977 File Offset: 0x00552B77
		public int FaceExpressionId { get; set; }

		// Token: 0x1700AC80 RID: 44160
		// (get) Token: 0x06026F0A RID: 159498 RVA: 0x00554980 File Offset: 0x00552B80
		// (set) Token: 0x06026F0B RID: 159499 RVA: 0x00554988 File Offset: 0x00552B88
		public int PosEntityId { get; set; }

		// Token: 0x1700AC81 RID: 44161
		// (get) Token: 0x06026F0C RID: 159500 RVA: 0x00554991 File Offset: 0x00552B91
		// (set) Token: 0x06026F0D RID: 159501 RVA: 0x00554999 File Offset: 0x00552B99
		public byte NullMask { get; set; }

		// Token: 0x06026F0E RID: 159502 RVA: 0x005549A2 File Offset: 0x00552BA2
		public INpcStandbySitT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.Montage = null;
			this.RegisteredMontageId = null;
			this.FaceExpressionId = 0;
			this.PosEntityId = 0;
			this.NullMask = 0;
		}
	}
}
