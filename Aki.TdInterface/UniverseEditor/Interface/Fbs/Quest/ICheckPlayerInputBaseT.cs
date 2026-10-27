using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D59 RID: 15705
	public class ICheckPlayerInputBaseT
	{
		// Token: 0x17006BCB RID: 27595
		// (get) Token: 0x06015BA7 RID: 88999 RVA: 0x003225FE File Offset: 0x003207FE
		// (set) Token: 0x06015BA8 RID: 89000 RVA: 0x00322606 File Offset: 0x00320806
		public ECheckPlayerInputType Type { get; set; }

		// Token: 0x06015BA9 RID: 89001 RVA: 0x0032260F File Offset: 0x0032080F
		public ICheckPlayerInputBaseT()
		{
			this.Type = ECheckPlayerInputType.PressButton;
		}
	}
}
