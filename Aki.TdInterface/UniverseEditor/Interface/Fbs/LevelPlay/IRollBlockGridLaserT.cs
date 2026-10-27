using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004576 RID: 17782
	public class IRollBlockGridLaserT
	{
		// Token: 0x17007E4D RID: 32333
		// (get) Token: 0x0601AD71 RID: 109937 RVA: 0x003D4AD1 File Offset: 0x003D2CD1
		// (set) Token: 0x0601AD72 RID: 109938 RVA: 0x003D4AD9 File Offset: 0x003D2CD9
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E4E RID: 32334
		// (get) Token: 0x0601AD73 RID: 109939 RVA: 0x003D4AE2 File Offset: 0x003D2CE2
		// (set) Token: 0x0601AD74 RID: 109940 RVA: 0x003D4AEA File Offset: 0x003D2CEA
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E4F RID: 32335
		// (get) Token: 0x0601AD75 RID: 109941 RVA: 0x003D4AF3 File Offset: 0x003D2CF3
		// (set) Token: 0x0601AD76 RID: 109942 RVA: 0x003D4AFB File Offset: 0x003D2CFB
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E50 RID: 32336
		// (get) Token: 0x0601AD77 RID: 109943 RVA: 0x003D4B04 File Offset: 0x003D2D04
		// (set) Token: 0x0601AD78 RID: 109944 RVA: 0x003D4B0C File Offset: 0x003D2D0C
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x17007E51 RID: 32337
		// (get) Token: 0x0601AD79 RID: 109945 RVA: 0x003D4B15 File Offset: 0x003D2D15
		// (set) Token: 0x0601AD7A RID: 109946 RVA: 0x003D4B1D File Offset: 0x003D2D1D
		public int Length { get; set; }

		// Token: 0x17007E52 RID: 32338
		// (get) Token: 0x0601AD7B RID: 109947 RVA: 0x003D4B26 File Offset: 0x003D2D26
		// (set) Token: 0x0601AD7C RID: 109948 RVA: 0x003D4B2E File Offset: 0x003D2D2E
		public int Height { get; set; }

		// Token: 0x17007E53 RID: 32339
		// (get) Token: 0x0601AD7D RID: 109949 RVA: 0x003D4B37 File Offset: 0x003D2D37
		// (set) Token: 0x0601AD7E RID: 109950 RVA: 0x003D4B3F File Offset: 0x003D2D3F
		public byte NullMask { get; set; }

		// Token: 0x0601AD7F RID: 109951 RVA: 0x003D4B48 File Offset: 0x003D2D48
		public IRollBlockGridLaserT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.Direction = ERollBlockLayType.Left;
			this.Length = 0;
			this.Height = 0;
			this.NullMask = 0;
		}
	}
}
