using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F07 RID: 28423
	public class IRoverRogueActivateT
	{
		// Token: 0x1700D35B RID: 54107
		// (get) Token: 0x06032386 RID: 205702 RVA: 0x006C90DA File Offset: 0x006C72DA
		// (set) Token: 0x06032387 RID: 205703 RVA: 0x006C90E2 File Offset: 0x006C72E2
		public ERoverRogueActivateType InteractType { get; set; }

		// Token: 0x06032388 RID: 205704 RVA: 0x006C90EB File Offset: 0x006C72EB
		public IRoverRogueActivateT()
		{
			this.InteractType = ERoverRogueActivateType.Shop;
		}
	}
}
