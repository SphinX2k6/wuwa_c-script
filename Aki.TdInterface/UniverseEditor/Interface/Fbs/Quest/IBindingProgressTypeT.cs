using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004149 RID: 16713
	public class IBindingProgressTypeT
	{
		// Token: 0x17007132 RID: 28978
		// (get) Token: 0x06016F6F RID: 94063 RVA: 0x00346BE2 File Offset: 0x00344DE2
		// (set) Token: 0x06016F70 RID: 94064 RVA: 0x00346BEA File Offset: 0x00344DEA
		public EBindingProgressType Type { get; set; }

		// Token: 0x06016F71 RID: 94065 RVA: 0x00346BF3 File Offset: 0x00344DF3
		public IBindingProgressTypeT()
		{
			this.Type = EBindingProgressType.PlayerHavingItemCount;
		}
	}
}
