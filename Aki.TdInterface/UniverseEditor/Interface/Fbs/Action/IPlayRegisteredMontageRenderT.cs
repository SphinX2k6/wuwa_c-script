using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D39 RID: 27961
	public class IPlayRegisteredMontageRenderT
	{
		// Token: 0x1700D06D RID: 53357
		// (get) Token: 0x06031597 RID: 202135 RVA: 0x006B181D File Offset: 0x006AFA1D
		// (set) Token: 0x06031598 RID: 202136 RVA: 0x006B1825 File Offset: 0x006AFA25
		public int EntityId { get; set; }

		// Token: 0x1700D06E RID: 53358
		// (get) Token: 0x06031599 RID: 202137 RVA: 0x006B182E File Offset: 0x006AFA2E
		// (set) Token: 0x0603159A RID: 202138 RVA: 0x006B1836 File Offset: 0x006AFA36
		public bool IsOverlayMontage { get; set; }

		// Token: 0x1700D06F RID: 53359
		// (get) Token: 0x0603159B RID: 202139 RVA: 0x006B183F File Offset: 0x006AFA3F
		// (set) Token: 0x0603159C RID: 202140 RVA: 0x006B1847 File Offset: 0x006AFA47
		public IMontageIdT MontageId { get; set; }

		// Token: 0x1700D070 RID: 53360
		// (get) Token: 0x0603159D RID: 202141 RVA: 0x006B1850 File Offset: 0x006AFA50
		// (set) Token: 0x0603159E RID: 202142 RVA: 0x006B1858 File Offset: 0x006AFA58
		public int FaceExpressionId { get; set; }

		// Token: 0x1700D071 RID: 53361
		// (get) Token: 0x0603159F RID: 202143 RVA: 0x006B1861 File Offset: 0x006AFA61
		// (set) Token: 0x060315A0 RID: 202144 RVA: 0x006B1869 File Offset: 0x006AFA69
		public float LoopDuration { get; set; }

		// Token: 0x1700D072 RID: 53362
		// (get) Token: 0x060315A1 RID: 202145 RVA: 0x006B1872 File Offset: 0x006AFA72
		// (set) Token: 0x060315A2 RID: 202146 RVA: 0x006B187A File Offset: 0x006AFA7A
		public int RepeatTimes { get; set; }

		// Token: 0x1700D073 RID: 53363
		// (get) Token: 0x060315A3 RID: 202147 RVA: 0x006B1883 File Offset: 0x006AFA83
		// (set) Token: 0x060315A4 RID: 202148 RVA: 0x006B188B File Offset: 0x006AFA8B
		public bool KeepMontageWhenEnd { get; set; }

		// Token: 0x1700D074 RID: 53364
		// (get) Token: 0x060315A5 RID: 202149 RVA: 0x006B1894 File Offset: 0x006AFA94
		// (set) Token: 0x060315A6 RID: 202150 RVA: 0x006B189C File Offset: 0x006AFA9C
		public bool KeepMontageAfterFlow { get; set; }

		// Token: 0x1700D075 RID: 53365
		// (get) Token: 0x060315A7 RID: 202151 RVA: 0x006B18A5 File Offset: 0x006AFAA5
		// (set) Token: 0x060315A8 RID: 202152 RVA: 0x006B18AD File Offset: 0x006AFAAD
		public byte NullMask { get; set; }

		// Token: 0x060315A9 RID: 202153 RVA: 0x006B18B8 File Offset: 0x006AFAB8
		public IPlayRegisteredMontageRenderT()
		{
			this.EntityId = 0;
			this.IsOverlayMontage = false;
			this.MontageId = null;
			this.FaceExpressionId = 0;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.KeepMontageWhenEnd = false;
			this.KeepMontageAfterFlow = false;
			this.NullMask = 0;
		}
	}
}
