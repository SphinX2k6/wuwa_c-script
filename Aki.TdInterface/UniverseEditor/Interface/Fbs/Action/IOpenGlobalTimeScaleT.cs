using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C01 RID: 27649
	public class IOpenGlobalTimeScaleT
	{
		// Token: 0x1700CD9C RID: 52636
		// (get) Token: 0x060309BE RID: 199102 RVA: 0x00699366 File Offset: 0x00697566
		// (set) Token: 0x060309BF RID: 199103 RVA: 0x0069936E File Offset: 0x0069756E
		public ESetTimeScaleType Type { get; set; }

		// Token: 0x1700CD9D RID: 52637
		// (get) Token: 0x060309C0 RID: 199104 RVA: 0x00699377 File Offset: 0x00697577
		// (set) Token: 0x060309C1 RID: 199105 RVA: 0x0069937F File Offset: 0x0069757F
		public float TimeScale { get; set; }

		// Token: 0x1700CD9E RID: 52638
		// (get) Token: 0x060309C2 RID: 199106 RVA: 0x00699388 File Offset: 0x00697588
		// (set) Token: 0x060309C3 RID: 199107 RVA: 0x00699390 File Offset: 0x00697590
		public float Duration { get; set; }

		// Token: 0x060309C4 RID: 199108 RVA: 0x00699399 File Offset: 0x00697599
		public IOpenGlobalTimeScaleT()
		{
			this.Type = ESetTimeScaleType.Open;
			this.TimeScale = 0f;
			this.Duration = 0f;
		}
	}
}
