using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEC RID: 27628
	public class INumberVarT
	{
		// Token: 0x1700CD5E RID: 52574
		// (get) Token: 0x060308CA RID: 198858 RVA: 0x00697257 File Offset: 0x00695457
		// (set) Token: 0x060308CB RID: 198859 RVA: 0x0069725F File Offset: 0x0069545F
		public string Name { get; set; }

		// Token: 0x1700CD5F RID: 52575
		// (get) Token: 0x060308CC RID: 198860 RVA: 0x00697268 File Offset: 0x00695468
		// (set) Token: 0x060308CD RID: 198861 RVA: 0x00697270 File Offset: 0x00695470
		public float Value { get; set; }

		// Token: 0x060308CE RID: 198862 RVA: 0x00697279 File Offset: 0x00695479
		public INumberVarT()
		{
			this.Name = null;
			this.Value = 0f;
		}
	}
}
