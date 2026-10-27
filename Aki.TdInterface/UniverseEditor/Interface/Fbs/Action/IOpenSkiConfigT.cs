using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2E RID: 27694
	public class IOpenSkiConfigT
	{
		// Token: 0x1700CE00 RID: 52736
		// (get) Token: 0x06030B9A RID: 199578 RVA: 0x0069DB8D File Offset: 0x0069BD8D
		// (set) Token: 0x06030B9B RID: 199579 RVA: 0x0069DB95 File Offset: 0x0069BD95
		public ESkiConfig Type { get; set; }

		// Token: 0x1700CE01 RID: 52737
		// (get) Token: 0x06030B9C RID: 199580 RVA: 0x0069DB9E File Offset: 0x0069BD9E
		// (set) Token: 0x06030B9D RID: 199581 RVA: 0x0069DBA6 File Offset: 0x0069BDA6
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700CE02 RID: 52738
		// (get) Token: 0x06030B9E RID: 199582 RVA: 0x0069DBAF File Offset: 0x0069BDAF
		// (set) Token: 0x06030B9F RID: 199583 RVA: 0x0069DBB7 File Offset: 0x0069BDB7
		public string SkiConfig { get; set; }

		// Token: 0x06030BA0 RID: 199584 RVA: 0x0069DBC0 File Offset: 0x0069BDC0
		public IOpenSkiConfigT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
			this.SkiConfig = null;
		}
	}
}
