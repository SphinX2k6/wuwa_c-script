using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AC RID: 16812
	public class ICommonEventEntityStateChangeT
	{
		// Token: 0x17007227 RID: 29223
		// (get) Token: 0x0601738E RID: 95118 RVA: 0x00350920 File Offset: 0x0034EB20
		// (set) Token: 0x0601738F RID: 95119 RVA: 0x00350928 File Offset: 0x0034EB28
		public ECommonEventType Type { get; set; }

		// Token: 0x17007228 RID: 29224
		// (get) Token: 0x06017390 RID: 95120 RVA: 0x00350931 File Offset: 0x0034EB31
		// (set) Token: 0x06017391 RID: 95121 RVA: 0x00350939 File Offset: 0x0034EB39
		public int EntityId { get; set; }

		// Token: 0x06017392 RID: 95122 RVA: 0x00350942 File Offset: 0x0034EB42
		public ICommonEventEntityStateChangeT()
		{
			this.Type = ECommonEventType.VarValueChange;
			this.EntityId = 0;
		}
	}
}
