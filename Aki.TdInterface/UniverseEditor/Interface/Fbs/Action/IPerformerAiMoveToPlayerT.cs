using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C88 RID: 27784
	public class IPerformerAiMoveToPlayerT
	{
		// Token: 0x1700CEE9 RID: 52969
		// (get) Token: 0x06030F5F RID: 200543 RVA: 0x006A5C2E File Offset: 0x006A3E2E
		// (set) Token: 0x06030F60 RID: 200544 RVA: 0x006A5C36 File Offset: 0x006A3E36
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x06030F61 RID: 200545 RVA: 0x006A5C3F File Offset: 0x006A3E3F
		public IPerformerAiMoveToPlayerT()
		{
			this.Type = EPerformerAiMoveToType.Position;
		}
	}
}
