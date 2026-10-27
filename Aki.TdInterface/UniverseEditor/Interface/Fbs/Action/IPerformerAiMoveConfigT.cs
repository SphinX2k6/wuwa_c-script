using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7C RID: 27772
	public class IPerformerAiMoveConfigT
	{
		// Token: 0x1700CED8 RID: 52952
		// (get) Token: 0x06030F08 RID: 200456 RVA: 0x006A52AA File Offset: 0x006A34AA
		// (set) Token: 0x06030F09 RID: 200457 RVA: 0x006A52B2 File Offset: 0x006A34B2
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x06030F0A RID: 200458 RVA: 0x006A52BB File Offset: 0x006A34BB
		public IPerformerAiMoveConfigT()
		{
			this.Type = EPerformerAiMoveToType.Position;
		}
	}
}
