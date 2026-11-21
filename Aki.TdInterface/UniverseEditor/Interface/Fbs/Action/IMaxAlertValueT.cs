using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007199 RID: 29081
	public class IMaxAlertValueT
	{
		// Token: 0x1700D4E5 RID: 54501
		// (get) Token: 0x060328FB RID: 207099 RVA: 0x006D50AA File Offset: 0x006D32AA
		// (set) Token: 0x060328FC RID: 207100 RVA: 0x006D50B2 File Offset: 0x006D32B2
		public EValueChangeType Type { get; set; }

		// Token: 0x060328FD RID: 207101 RVA: 0x006D50BB File Offset: 0x006D32BB
		public IMaxAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
