using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EBB RID: 20155
	public class ICheckEntityBuffStackT
	{
		// Token: 0x17008FCE RID: 36814
		// (get) Token: 0x0601F40B RID: 128011 RVA: 0x0045B231 File Offset: 0x00459431
		// (set) Token: 0x0601F40C RID: 128012 RVA: 0x0045B239 File Offset: 0x00459439
		public ECondition Type { get; set; }

		// Token: 0x17008FCF RID: 36815
		// (get) Token: 0x0601F40D RID: 128013 RVA: 0x0045B242 File Offset: 0x00459442
		// (set) Token: 0x0601F40E RID: 128014 RVA: 0x0045B24A File Offset: 0x0045944A
		public IMonsterBuffContainerT Target { get; set; }

		// Token: 0x17008FD0 RID: 36816
		// (get) Token: 0x0601F40F RID: 128015 RVA: 0x0045B253 File Offset: 0x00459453
		// (set) Token: 0x0601F410 RID: 128016 RVA: 0x0045B25B File Offset: 0x0045945B
		public long BuffId { get; set; }

		// Token: 0x17008FD1 RID: 36817
		// (get) Token: 0x0601F411 RID: 128017 RVA: 0x0045B264 File Offset: 0x00459464
		// (set) Token: 0x0601F412 RID: 128018 RVA: 0x0045B26C File Offset: 0x0045946C
		public ECompare Compare { get; set; }

		// Token: 0x17008FD2 RID: 36818
		// (get) Token: 0x0601F413 RID: 128019 RVA: 0x0045B275 File Offset: 0x00459475
		// (set) Token: 0x0601F414 RID: 128020 RVA: 0x0045B27D File Offset: 0x0045947D
		public int Stack { get; set; }

		// Token: 0x0601F415 RID: 128021 RVA: 0x0045B286 File Offset: 0x00459486
		public ICheckEntityBuffStackT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.BuffId = 0L;
			this.Compare = ECompare.Eq;
			this.Stack = 0;
		}
	}
}
