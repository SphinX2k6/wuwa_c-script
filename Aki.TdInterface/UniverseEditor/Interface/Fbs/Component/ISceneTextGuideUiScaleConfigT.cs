using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF3 RID: 24307
	public class ISceneTextGuideUiScaleConfigT
	{
		// Token: 0x1700B3AB RID: 45995
		// (get) Token: 0x06028C52 RID: 166994 RVA: 0x0059294E File Offset: 0x00590B4E
		// (set) Token: 0x06028C53 RID: 166995 RVA: 0x00592956 File Offset: 0x00590B56
		public int MinDist { get; set; }

		// Token: 0x1700B3AC RID: 45996
		// (get) Token: 0x06028C54 RID: 166996 RVA: 0x0059295F File Offset: 0x00590B5F
		// (set) Token: 0x06028C55 RID: 166997 RVA: 0x00592967 File Offset: 0x00590B67
		public int MaxDist { get; set; }

		// Token: 0x1700B3AD RID: 45997
		// (get) Token: 0x06028C56 RID: 166998 RVA: 0x00592970 File Offset: 0x00590B70
		// (set) Token: 0x06028C57 RID: 166999 RVA: 0x00592978 File Offset: 0x00590B78
		public float MinScale { get; set; }

		// Token: 0x1700B3AE RID: 45998
		// (get) Token: 0x06028C58 RID: 167000 RVA: 0x00592981 File Offset: 0x00590B81
		// (set) Token: 0x06028C59 RID: 167001 RVA: 0x00592989 File Offset: 0x00590B89
		public float MaxScale { get; set; }

		// Token: 0x1700B3AF RID: 45999
		// (get) Token: 0x06028C5A RID: 167002 RVA: 0x00592992 File Offset: 0x00590B92
		// (set) Token: 0x06028C5B RID: 167003 RVA: 0x0059299A File Offset: 0x00590B9A
		public ESceneTextGuideUiScaleType ScaleType { get; set; }

		// Token: 0x06028C5C RID: 167004 RVA: 0x005929A3 File Offset: 0x00590BA3
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
