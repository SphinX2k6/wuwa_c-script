using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E6 RID: 22758
	public class ISceneTextGuideUiScaleConfigT
	{
		// Token: 0x1700AA7B RID: 43643
		// (get) Token: 0x060266F0 RID: 157424 RVA: 0x0054BE02 File Offset: 0x0054A002
		// (set) Token: 0x060266F1 RID: 157425 RVA: 0x0054BE0A File Offset: 0x0054A00A
		public int MinDist { get; set; }

		// Token: 0x1700AA7C RID: 43644
		// (get) Token: 0x060266F2 RID: 157426 RVA: 0x0054BE13 File Offset: 0x0054A013
		// (set) Token: 0x060266F3 RID: 157427 RVA: 0x0054BE1B File Offset: 0x0054A01B
		public int MaxDist { get; set; }

		// Token: 0x1700AA7D RID: 43645
		// (get) Token: 0x060266F4 RID: 157428 RVA: 0x0054BE24 File Offset: 0x0054A024
		// (set) Token: 0x060266F5 RID: 157429 RVA: 0x0054BE2C File Offset: 0x0054A02C
		public float MinScale { get; set; }

		// Token: 0x1700AA7E RID: 43646
		// (get) Token: 0x060266F6 RID: 157430 RVA: 0x0054BE35 File Offset: 0x0054A035
		// (set) Token: 0x060266F7 RID: 157431 RVA: 0x0054BE3D File Offset: 0x0054A03D
		public float MaxScale { get; set; }

		// Token: 0x1700AA7F RID: 43647
		// (get) Token: 0x060266F8 RID: 157432 RVA: 0x0054BE46 File Offset: 0x0054A046
		// (set) Token: 0x060266F9 RID: 157433 RVA: 0x0054BE4E File Offset: 0x0054A04E
		public ESceneTextGuideUiScaleType ScaleType { get; set; }

		// Token: 0x060266FA RID: 157434 RVA: 0x0054BE57 File Offset: 0x0054A057
		public ISceneTextGuideUiScaleConfigT()
		{
			this.MinDist = 0;
			this.MaxDist = 0;
			this.MinScale = 0f;
			this.MaxScale = 0f;
			this.ScaleType = ESceneTextGuideUiScaleType.FarBigNearSmall;
		}
	}
}
