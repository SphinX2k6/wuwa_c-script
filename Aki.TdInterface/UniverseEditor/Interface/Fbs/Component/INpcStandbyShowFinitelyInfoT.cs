using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFE RID: 23550
	public class INpcStandbyShowFinitelyInfoT
	{
		// Token: 0x1700AC53 RID: 44115
		// (get) Token: 0x06026E6A RID: 159338 RVA: 0x00553410 File Offset: 0x00551610
		// (set) Token: 0x06026E6B RID: 159339 RVA: 0x00553418 File Offset: 0x00551618
		public string Montage { get; set; }

		// Token: 0x1700AC54 RID: 44116
		// (get) Token: 0x06026E6C RID: 159340 RVA: 0x00553421 File Offset: 0x00551621
		// (set) Token: 0x06026E6D RID: 159341 RVA: 0x00553429 File Offset: 0x00551629
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700AC55 RID: 44117
		// (get) Token: 0x06026E6E RID: 159342 RVA: 0x00553432 File Offset: 0x00551632
		// (set) Token: 0x06026E6F RID: 159343 RVA: 0x0055343A File Offset: 0x0055163A
		public int FaceExpressionId { get; set; }

		// Token: 0x1700AC56 RID: 44118
		// (get) Token: 0x06026E70 RID: 159344 RVA: 0x00553443 File Offset: 0x00551643
		// (set) Token: 0x06026E71 RID: 159345 RVA: 0x0055344B File Offset: 0x0055164B
		public int Time { get; set; }

		// Token: 0x1700AC57 RID: 44119
		// (get) Token: 0x06026E72 RID: 159346 RVA: 0x00553454 File Offset: 0x00551654
		// (set) Token: 0x06026E73 RID: 159347 RVA: 0x0055345C File Offset: 0x0055165C
		public IIgnoreEntityIdsCollisionT IgnoreEntityCollision { get; set; }

		// Token: 0x1700AC58 RID: 44120
		// (get) Token: 0x06026E74 RID: 159348 RVA: 0x00553465 File Offset: 0x00551665
		// (set) Token: 0x06026E75 RID: 159349 RVA: 0x0055346D File Offset: 0x0055166D
		public byte NullMask { get; set; }

		// Token: 0x06026E76 RID: 159350 RVA: 0x00553476 File Offset: 0x00551676
		public INpcStandbyShowFinitelyInfoT()
		{
			this.Montage = null;
			this.RegisteredMontageId = null;
			this.FaceExpressionId = 0;
			this.Time = 0;
			this.IgnoreEntityCollision = null;
			this.NullMask = 0;
		}
	}
}
