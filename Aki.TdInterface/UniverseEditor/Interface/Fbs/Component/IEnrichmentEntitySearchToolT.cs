using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AD RID: 22189
	public class IEnrichmentEntitySearchToolT
	{
		// Token: 0x17009FB1 RID: 40881
		// (get) Token: 0x060238AE RID: 145582 RVA: 0x004E36AA File Offset: 0x004E18AA
		// (set) Token: 0x060238AF RID: 145583 RVA: 0x004E36B2 File Offset: 0x004E18B2
		public int TargetType { get; set; }

		// Token: 0x17009FB2 RID: 40882
		// (get) Token: 0x060238B0 RID: 145584 RVA: 0x004E36BB File Offset: 0x004E18BB
		// (set) Token: 0x060238B1 RID: 145585 RVA: 0x004E36C3 File Offset: 0x004E18C3
		public float Radius { get; set; }

		// Token: 0x17009FB3 RID: 40883
		// (get) Token: 0x060238B2 RID: 145586 RVA: 0x004E36CC File Offset: 0x004E18CC
		// (set) Token: 0x060238B3 RID: 145587 RVA: 0x004E36D4 File Offset: 0x004E18D4
		public float Height { get; set; }

		// Token: 0x060238B4 RID: 145588 RVA: 0x004E36DD File Offset: 0x004E18DD
		public IEnrichmentEntitySearchToolT()
		{
			this.TargetType = 0;
			this.Radius = 0f;
			this.Height = 0f;
		}
	}
}
