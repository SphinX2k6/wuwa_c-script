using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E72 RID: 15986
	public class IEnergyFishFollowStateT
	{
		// Token: 0x17006BF7 RID: 27639
		// (get) Token: 0x060158D4 RID: 88276 RVA: 0x0031B743 File Offset: 0x00319943
		// (set) Token: 0x060158D5 RID: 88277 RVA: 0x0031B74B File Offset: 0x0031994B
		public EEnergyFishState Type { get; set; }

		// Token: 0x17006BF8 RID: 27640
		// (get) Token: 0x060158D6 RID: 88278 RVA: 0x0031B754 File Offset: 0x00319954
		// (set) Token: 0x060158D7 RID: 88279 RVA: 0x0031B75C File Offset: 0x0031995C
		public string ActorKey { get; set; }

		// Token: 0x17006BF9 RID: 27641
		// (get) Token: 0x060158D8 RID: 88280 RVA: 0x0031B765 File Offset: 0x00319965
		// (set) Token: 0x060158D9 RID: 88281 RVA: 0x0031B76D File Offset: 0x0031996D
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17006BFA RID: 27642
		// (get) Token: 0x060158DA RID: 88282 RVA: 0x0031B776 File Offset: 0x00319976
		// (set) Token: 0x060158DB RID: 88283 RVA: 0x0031B77E File Offset: 0x0031997E
		public float MaxSpeed { get; set; }

		// Token: 0x17006BFB RID: 27643
		// (get) Token: 0x060158DC RID: 88284 RVA: 0x0031B787 File Offset: 0x00319987
		// (set) Token: 0x060158DD RID: 88285 RVA: 0x0031B78F File Offset: 0x0031998F
		public float NiagaraFollowStrength { get; set; }

		// Token: 0x17006BFC RID: 27644
		// (get) Token: 0x060158DE RID: 88286 RVA: 0x0031B798 File Offset: 0x00319998
		// (set) Token: 0x060158DF RID: 88287 RVA: 0x0031B7A0 File Offset: 0x003199A0
		public byte NullMask { get; set; }

		// Token: 0x060158E0 RID: 88288 RVA: 0x0031B7A9 File Offset: 0x003199A9
		public IEnergyFishFollowStateT()
		{
			this.Type = EEnergyFishState.Spline;
			this.ActorKey = null;
			this.Offset = null;
			this.MaxSpeed = 0f;
			this.NiagaraFollowStrength = 0f;
			this.NullMask = 0;
		}
	}
}
