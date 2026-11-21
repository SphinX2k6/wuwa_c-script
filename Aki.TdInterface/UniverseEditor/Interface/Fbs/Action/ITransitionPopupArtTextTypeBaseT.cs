using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C33 RID: 31795
	public class ITransitionPopupArtTextTypeBaseT
	{
		// Token: 0x1700EE12 RID: 60946
		// (get) Token: 0x060394F9 RID: 234745 RVA: 0x007BD54A File Offset: 0x007BB74A
		// (set) Token: 0x060394FA RID: 234746 RVA: 0x007BD552 File Offset: 0x007BB752
		public ETransitionPopupArtTextType Type { get; set; }

		// Token: 0x060394FB RID: 234747 RVA: 0x007BD55B File Offset: 0x007BB75B
		public ITransitionPopupArtTextTypeBaseT()
		{
			this.Type = ETransitionPopupArtTextType.YuanCheng;
		}
	}
}
