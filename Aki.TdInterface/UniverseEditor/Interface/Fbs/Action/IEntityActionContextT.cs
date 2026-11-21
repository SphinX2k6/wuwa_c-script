using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D50 RID: 27984
	public class IEntityActionContextT
	{
		// Token: 0x1700CD43 RID: 52547
		// (get) Token: 0x0603045C RID: 197724 RVA: 0x0068F9F9 File Offset: 0x0068DBF9
		// (set) Token: 0x0603045D RID: 197725 RVA: 0x0068FA01 File Offset: 0x0068DC01
		public string Type { get; set; }

		// Token: 0x0603045E RID: 197726 RVA: 0x0068FA0A File Offset: 0x0068DC0A
		public IEntityActionContextT()
		{
			this.Type = null;
		}
	}
}
