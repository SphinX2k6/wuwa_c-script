using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E3 RID: 29667
	public class IPerformerAiMoveConfigT
	{
		// Token: 0x1700D9F3 RID: 55795
		// (get) Token: 0x06033E63 RID: 212579 RVA: 0x006FF7AA File Offset: 0x006FD9AA
		// (set) Token: 0x06033E64 RID: 212580 RVA: 0x006FF7B2 File Offset: 0x006FD9B2
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x06033E65 RID: 212581 RVA: 0x006FF7BB File Offset: 0x006FD9BB
		public IPerformerAiMoveConfigT()
		{
			this.Type = EPerformerAiMoveToType.Position;
		}
	}
}
