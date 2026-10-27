using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F53 RID: 20307
	public class ICaptureStrategicPointT
	{
		// Token: 0x1700927D RID: 37501
		// (get) Token: 0x060202EF RID: 131823 RVA: 0x0047A89B File Offset: 0x00478A9B
		// (set) Token: 0x060202F0 RID: 131824 RVA: 0x0047A8A3 File Offset: 0x00478AA3
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700927E RID: 37502
		// (get) Token: 0x060202F1 RID: 131825 RVA: 0x0047A8AC File Offset: 0x00478AAC
		// (set) Token: 0x060202F2 RID: 131826 RVA: 0x0047A8B4 File Offset: 0x00478AB4
		public int MaxValue { get; set; }

		// Token: 0x1700927F RID: 37503
		// (get) Token: 0x060202F3 RID: 131827 RVA: 0x0047A8BD File Offset: 0x00478ABD
		// (set) Token: 0x060202F4 RID: 131828 RVA: 0x0047A8C5 File Offset: 0x00478AC5
		public int InitValue { get; set; }

		// Token: 0x17009280 RID: 37504
		// (get) Token: 0x060202F5 RID: 131829 RVA: 0x0047A8CE File Offset: 0x00478ACE
		// (set) Token: 0x060202F6 RID: 131830 RVA: 0x0047A8D6 File Offset: 0x00478AD6
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x17009281 RID: 37505
		// (get) Token: 0x060202F7 RID: 131831 RVA: 0x0047A8DF File Offset: 0x00478ADF
		// (set) Token: 0x060202F8 RID: 131832 RVA: 0x0047A8E7 File Offset: 0x00478AE7
		public int IncreaseSpeed { get; set; }

		// Token: 0x17009282 RID: 37506
		// (get) Token: 0x060202F9 RID: 131833 RVA: 0x0047A8F0 File Offset: 0x00478AF0
		// (set) Token: 0x060202FA RID: 131834 RVA: 0x0047A8F8 File Offset: 0x00478AF8
		public int DecreaseSpeed { get; set; }

		// Token: 0x17009283 RID: 37507
		// (get) Token: 0x060202FB RID: 131835 RVA: 0x0047A901 File Offset: 0x00478B01
		// (set) Token: 0x060202FC RID: 131836 RVA: 0x0047A909 File Offset: 0x00478B09
		public int UnoccupiedDecreaseSpeed { get; set; }

		// Token: 0x17009284 RID: 37508
		// (get) Token: 0x060202FD RID: 131837 RVA: 0x0047A912 File Offset: 0x00478B12
		// (set) Token: 0x060202FE RID: 131838 RVA: 0x0047A91A File Offset: 0x00478B1A
		public IStaticEntitiyMatchT EnemyEntitiyMatch { get; set; }

		// Token: 0x17009285 RID: 37509
		// (get) Token: 0x060202FF RID: 131839 RVA: 0x0047A923 File Offset: 0x00478B23
		// (set) Token: 0x06020300 RID: 131840 RVA: 0x0047A92B File Offset: 0x00478B2B
		public ECaptureStateType CaptureType { get; set; }

		// Token: 0x17009286 RID: 37510
		// (get) Token: 0x06020301 RID: 131841 RVA: 0x0047A934 File Offset: 0x00478B34
		// (set) Token: 0x06020302 RID: 131842 RVA: 0x0047A93C File Offset: 0x00478B3C
		public byte NullMask { get; set; }

		// Token: 0x06020303 RID: 131843 RVA: 0x0047A948 File Offset: 0x00478B48
		public ICaptureStrategicPointT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.IncreaseSpeed = 0;
			this.DecreaseSpeed = 0;
			this.UnoccupiedDecreaseSpeed = 0;
			this.EnemyEntitiyMatch = null;
			this.CaptureType = ECaptureStateType.Default;
			this.NullMask = 0;
		}
	}
}
