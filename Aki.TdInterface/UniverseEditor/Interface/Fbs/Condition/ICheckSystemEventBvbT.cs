using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005023 RID: 20515
	public class ICheckSystemEventBvbT
	{
		// Token: 0x170092CD RID: 37581
		// (get) Token: 0x0602008D RID: 131213 RVA: 0x00471BFC File Offset: 0x0046FDFC
		// (set) Token: 0x0602008E RID: 131214 RVA: 0x00471C04 File Offset: 0x0046FE04
		public ECondition Type { get; set; }

		// Token: 0x170092CE RID: 37582
		// (get) Token: 0x0602008F RID: 131215 RVA: 0x00471C0D File Offset: 0x0046FE0D
		// (set) Token: 0x06020090 RID: 131216 RVA: 0x00471C15 File Offset: 0x0046FE15
		public EBvbEventName EventName { get; set; }

		// Token: 0x06020091 RID: 131217 RVA: 0x00471C1E File Offset: 0x0046FE1E
		public ICheckSystemEventBvbT()
		{
			this.Type = ECondition.CompareVar;
			this.EventName = EBvbEventName.AIEvolution;
		}
	}
}
