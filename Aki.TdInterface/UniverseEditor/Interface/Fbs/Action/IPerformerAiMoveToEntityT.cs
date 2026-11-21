using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EC RID: 29676
	public class IPerformerAiMoveToEntityT
	{
		// Token: 0x1700DA00 RID: 55808
		// (get) Token: 0x06033EA6 RID: 212646 RVA: 0x006FFF90 File Offset: 0x006FE190
		// (set) Token: 0x06033EA7 RID: 212647 RVA: 0x006FFF98 File Offset: 0x006FE198
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x1700DA01 RID: 55809
		// (get) Token: 0x06033EA8 RID: 212648 RVA: 0x006FFFA1 File Offset: 0x006FE1A1
		// (set) Token: 0x06033EA9 RID: 212649 RVA: 0x006FFFA9 File Offset: 0x006FE1A9
		public int EntityId { get; set; }

		// Token: 0x06033EAA RID: 212650 RVA: 0x006FFFB2 File Offset: 0x006FE1B2
		public IPerformerAiMoveToEntityT()
		{
			this.Type = EPerformerAiMoveToType.Position;
			this.EntityId = 0;
		}
	}
}
