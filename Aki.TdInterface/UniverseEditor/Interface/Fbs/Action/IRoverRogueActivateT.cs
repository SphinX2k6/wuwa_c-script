using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768E RID: 30350
	public class IRoverRogueActivateT
	{
		// Token: 0x1700DEB7 RID: 57015
		// (get) Token: 0x060353DE RID: 218078 RVA: 0x00725042 File Offset: 0x00723242
		// (set) Token: 0x060353DF RID: 218079 RVA: 0x0072504A File Offset: 0x0072324A
		public ERoverRogueActivateType InteractType { get; set; }

		// Token: 0x060353E0 RID: 218080 RVA: 0x00725053 File Offset: 0x00723253
		public IRoverRogueActivateT()
		{
			this.InteractType = ERoverRogueActivateType.Shop;
		}
	}
}
