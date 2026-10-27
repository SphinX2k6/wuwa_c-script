using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005148 RID: 20808
	public class IEnrichmentEntitySearchToolT
	{
		// Token: 0x170097C4 RID: 38852
		// (get) Token: 0x0602195A RID: 137562 RVA: 0x004A971E File Offset: 0x004A791E
		// (set) Token: 0x0602195B RID: 137563 RVA: 0x004A9726 File Offset: 0x004A7926
		public int TargetType { get; set; }

		// Token: 0x170097C5 RID: 38853
		// (get) Token: 0x0602195C RID: 137564 RVA: 0x004A972F File Offset: 0x004A792F
		// (set) Token: 0x0602195D RID: 137565 RVA: 0x004A9737 File Offset: 0x004A7937
		public float Radius { get; set; }

		// Token: 0x170097C6 RID: 38854
		// (get) Token: 0x0602195E RID: 137566 RVA: 0x004A9740 File Offset: 0x004A7940
		// (set) Token: 0x0602195F RID: 137567 RVA: 0x004A9748 File Offset: 0x004A7948
		public float Height { get; set; }

		// Token: 0x06021960 RID: 137568 RVA: 0x004A9751 File Offset: 0x004A7951
		public IEnrichmentEntitySearchToolT()
		{
			this.TargetType = 0;
			this.Radius = 0f;
			this.Height = 0f;
		}
	}
}
