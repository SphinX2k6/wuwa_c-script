using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AA RID: 26026
	public class IDestroySummonedVehicleT
	{
		// Token: 0x1700C141 RID: 49473
		// (get) Token: 0x0602D25B RID: 184923 RVA: 0x00630FA7 File Offset: 0x0062F1A7
		// (set) Token: 0x0602D25C RID: 184924 RVA: 0x00630FAF File Offset: 0x0062F1AF
		public ESummonEntityType Type { get; set; }

		// Token: 0x1700C142 RID: 49474
		// (get) Token: 0x0602D25D RID: 184925 RVA: 0x00630FB8 File Offset: 0x0062F1B8
		// (set) Token: 0x0602D25E RID: 184926 RVA: 0x00630FC0 File Offset: 0x0062F1C0
		public string TemplateId { get; set; }

		// Token: 0x0602D25F RID: 184927 RVA: 0x00630FC9 File Offset: 0x0062F1C9
		public IDestroySummonedVehicleT()
		{
			this.Type = ESummonEntityType.Vehicle;
			this.TemplateId = null;
		}
	}
}
