using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005477 RID: 21623
	public class IInteractStyleBaseT
	{
		// Token: 0x17009F28 RID: 40744
		// (get) Token: 0x06023923 RID: 145699 RVA: 0x004EB422 File Offset: 0x004E9622
		// (set) Token: 0x06023924 RID: 145700 RVA: 0x004EB42A File Offset: 0x004E962A
		public EInteractStyleType Type { get; set; }

		// Token: 0x06023925 RID: 145701 RVA: 0x004EB433 File Offset: 0x004E9633
		public IInteractStyleBaseT()
		{
			this.Type = EInteractStyleType.Panorama;
		}
	}
}
