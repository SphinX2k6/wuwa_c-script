using System;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004740 RID: 18240
	public class IMontageConfigT
	{
		// Token: 0x170082DD RID: 33501
		// (get) Token: 0x0601C10D RID: 114957 RVA: 0x003FA17B File Offset: 0x003F837B
		// (set) Token: 0x0601C10E RID: 114958 RVA: 0x003FA183 File Offset: 0x003F8383
		public int Id { get; set; }

		// Token: 0x170082DE RID: 33502
		// (get) Token: 0x0601C10F RID: 114959 RVA: 0x003FA18C File Offset: 0x003F838C
		// (set) Token: 0x0601C110 RID: 114960 RVA: 0x003FA194 File Offset: 0x003F8394
		public string ActionMontage { get; set; }

		// Token: 0x170082DF RID: 33503
		// (get) Token: 0x0601C111 RID: 114961 RVA: 0x003FA19D File Offset: 0x003F839D
		// (set) Token: 0x0601C112 RID: 114962 RVA: 0x003FA1A5 File Offset: 0x003F83A5
		public string ExpressionMontage { get; set; }

		// Token: 0x170082E0 RID: 33504
		// (get) Token: 0x0601C113 RID: 114963 RVA: 0x003FA1AE File Offset: 0x003F83AE
		// (set) Token: 0x0601C114 RID: 114964 RVA: 0x003FA1B6 File Offset: 0x003F83B6
		public string MouthSequence { get; set; }

		// Token: 0x170082E1 RID: 33505
		// (get) Token: 0x0601C115 RID: 114965 RVA: 0x003FA1BF File Offset: 0x003F83BF
		// (set) Token: 0x0601C116 RID: 114966 RVA: 0x003FA1C7 File Offset: 0x003F83C7
		public string InitState { get; set; }

		// Token: 0x170082E2 RID: 33506
		// (get) Token: 0x0601C117 RID: 114967 RVA: 0x003FA1D0 File Offset: 0x003F83D0
		// (set) Token: 0x0601C118 RID: 114968 RVA: 0x003FA1D8 File Offset: 0x003F83D8
		public string EndState { get; set; }

		// Token: 0x170082E3 RID: 33507
		// (get) Token: 0x0601C119 RID: 114969 RVA: 0x003FA1E1 File Offset: 0x003F83E1
		// (set) Token: 0x0601C11A RID: 114970 RVA: 0x003FA1E9 File Offset: 0x003F83E9
		public bool DisableBlinkCurve { get; set; }

		// Token: 0x170082E4 RID: 33508
		// (get) Token: 0x0601C11B RID: 114971 RVA: 0x003FA1F2 File Offset: 0x003F83F2
		// (set) Token: 0x0601C11C RID: 114972 RVA: 0x003FA1FA File Offset: 0x003F83FA
		public string MaleVariant { get; set; }

		// Token: 0x170082E5 RID: 33509
		// (get) Token: 0x0601C11D RID: 114973 RVA: 0x003FA203 File Offset: 0x003F8403
		// (set) Token: 0x0601C11E RID: 114974 RVA: 0x003FA20B File Offset: 0x003F840B
		public byte NullMask { get; set; }

		// Token: 0x0601C11F RID: 114975 RVA: 0x003FA214 File Offset: 0x003F8414
		public IMontageConfigT()
		{
			this.Id = 0;
			this.ActionMontage = null;
			this.ExpressionMontage = null;
			this.MouthSequence = null;
			this.InitState = null;
			this.EndState = null;
			this.DisableBlinkCurve = false;
			this.MaleVariant = null;
			this.NullMask = 0;
		}
	}
}
