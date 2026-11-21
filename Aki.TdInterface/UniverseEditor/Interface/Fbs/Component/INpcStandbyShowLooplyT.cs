using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C01 RID: 23553
	public class INpcStandbyShowLooplyT
	{
		// Token: 0x1700AC62 RID: 44130
		// (get) Token: 0x06026E9C RID: 159388 RVA: 0x00553BEA File Offset: 0x00551DEA
		// (set) Token: 0x06026E9D RID: 159389 RVA: 0x00553BF2 File Offset: 0x00551DF2
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700AC63 RID: 44131
		// (get) Token: 0x06026E9E RID: 159390 RVA: 0x00553BFB File Offset: 0x00551DFB
		// (set) Token: 0x06026E9F RID: 159391 RVA: 0x00553C03 File Offset: 0x00551E03
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700AC64 RID: 44132
		// (get) Token: 0x06026EA0 RID: 159392 RVA: 0x00553C0C File Offset: 0x00551E0C
		// (set) Token: 0x06026EA1 RID: 159393 RVA: 0x00553C14 File Offset: 0x00551E14
		public string Montage { get; set; }

		// Token: 0x1700AC65 RID: 44133
		// (get) Token: 0x06026EA2 RID: 159394 RVA: 0x00553C1D File Offset: 0x00551E1D
		// (set) Token: 0x06026EA3 RID: 159395 RVA: 0x00553C25 File Offset: 0x00551E25
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700AC66 RID: 44134
		// (get) Token: 0x06026EA4 RID: 159396 RVA: 0x00553C2E File Offset: 0x00551E2E
		// (set) Token: 0x06026EA5 RID: 159397 RVA: 0x00553C36 File Offset: 0x00551E36
		public int FaceExpressionId { get; set; }

		// Token: 0x1700AC67 RID: 44135
		// (get) Token: 0x06026EA6 RID: 159398 RVA: 0x00553C3F File Offset: 0x00551E3F
		// (set) Token: 0x06026EA7 RID: 159399 RVA: 0x00553C47 File Offset: 0x00551E47
		public IIgnoreEntityIdsCollisionT IgnoreEntityCollision { get; set; }

		// Token: 0x1700AC68 RID: 44136
		// (get) Token: 0x06026EA8 RID: 159400 RVA: 0x00553C50 File Offset: 0x00551E50
		// (set) Token: 0x06026EA9 RID: 159401 RVA: 0x00553C58 File Offset: 0x00551E58
		public bool SetFadeInTimeToZero { get; set; }

		// Token: 0x1700AC69 RID: 44137
		// (get) Token: 0x06026EAA RID: 159402 RVA: 0x00553C61 File Offset: 0x00551E61
		// (set) Token: 0x06026EAB RID: 159403 RVA: 0x00553C69 File Offset: 0x00551E69
		public byte NullMask { get; set; }

		// Token: 0x06026EAC RID: 159404 RVA: 0x00553C72 File Offset: 0x00551E72
		public INpcStandbyShowLooplyT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.Montage = null;
			this.RegisteredMontageId = null;
			this.FaceExpressionId = 0;
			this.IgnoreEntityCollision = null;
			this.SetFadeInTimeToZero = false;
			this.NullMask = 0;
		}
	}
}
