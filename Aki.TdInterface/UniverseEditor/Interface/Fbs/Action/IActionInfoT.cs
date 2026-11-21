using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E0 RID: 26336
	public class IActionInfoT
	{
		// Token: 0x1700BF7F RID: 49023
		// (get) Token: 0x0602C42E RID: 181294 RVA: 0x00606CC7 File Offset: 0x00604EC7
		// (set) Token: 0x0602C42F RID: 181295 RVA: 0x00606CCF File Offset: 0x00604ECF
		public EAction Name { get; set; }

		// Token: 0x1700BF80 RID: 49024
		// (get) Token: 0x0602C430 RID: 181296 RVA: 0x00606CD8 File Offset: 0x00604ED8
		// (set) Token: 0x0602C431 RID: 181297 RVA: 0x00606CE0 File Offset: 0x00604EE0
		public bool Async { get; set; }

		// Token: 0x1700BF81 RID: 49025
		// (get) Token: 0x0602C432 RID: 181298 RVA: 0x00606CE9 File Offset: 0x00604EE9
		// (set) Token: 0x0602C433 RID: 181299 RVA: 0x00606CF1 File Offset: 0x00604EF1
		public IActionParams_UnionT Params { get; set; }

		// Token: 0x1700BF82 RID: 49026
		// (get) Token: 0x0602C434 RID: 181300 RVA: 0x00606CFA File Offset: 0x00604EFA
		// (set) Token: 0x0602C435 RID: 181301 RVA: 0x00606D02 File Offset: 0x00604F02
		public int ActionId { get; set; }

		// Token: 0x1700BF83 RID: 49027
		// (get) Token: 0x0602C436 RID: 181302 RVA: 0x00606D0B File Offset: 0x00604F0B
		// (set) Token: 0x0602C437 RID: 181303 RVA: 0x00606D13 File Offset: 0x00604F13
		public bool Disabled { get; set; }

		// Token: 0x1700BF84 RID: 49028
		// (get) Token: 0x0602C438 RID: 181304 RVA: 0x00606D1C File Offset: 0x00604F1C
		// (set) Token: 0x0602C439 RID: 181305 RVA: 0x00606D24 File Offset: 0x00604F24
		public string ActionGuid { get; set; }

		// Token: 0x1700BF85 RID: 49029
		// (get) Token: 0x0602C43A RID: 181306 RVA: 0x00606D2D File Offset: 0x00604F2D
		// (set) Token: 0x0602C43B RID: 181307 RVA: 0x00606D35 File Offset: 0x00604F35
		public float Timeout { get; set; }

		// Token: 0x1700BF86 RID: 49030
		// (get) Token: 0x0602C43C RID: 181308 RVA: 0x00606D3E File Offset: 0x00604F3E
		// (set) Token: 0x0602C43D RID: 181309 RVA: 0x00606D46 File Offset: 0x00604F46
		public byte NullMask { get; set; }

		// Token: 0x0602C43E RID: 181310 RVA: 0x00606D50 File Offset: 0x00604F50
		public IActionInfoT()
		{
			this.Name = EAction.Undefined;
			this.Async = false;
			this.Params = null;
			this.ActionId = 0;
			this.Disabled = false;
			this.ActionGuid = null;
			this.Timeout = 0f;
			this.NullMask = 0;
		}
	}
}
