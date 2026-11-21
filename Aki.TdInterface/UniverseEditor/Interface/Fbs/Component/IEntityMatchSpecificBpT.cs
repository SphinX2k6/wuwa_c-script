using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005707 RID: 22279
	public class IEntityMatchSpecificBpT
	{
		// Token: 0x1700A09F RID: 41119
		// (get) Token: 0x06023C6B RID: 146539 RVA: 0x004EAFFF File Offset: 0x004E91FF
		// (set) Token: 0x06023C6C RID: 146540 RVA: 0x004EB007 File Offset: 0x004E9207
		public EEntityMatchType Type { get; set; }

		// Token: 0x1700A0A0 RID: 41120
		// (get) Token: 0x06023C6D RID: 146541 RVA: 0x004EB010 File Offset: 0x004E9210
		// (set) Token: 0x06023C6E RID: 146542 RVA: 0x004EB018 File Offset: 0x004E9218
		public List<string> SpecificBpList { get; set; }

		// Token: 0x06023C6F RID: 146543 RVA: 0x004EB021 File Offset: 0x004E9221
		public IEntityMatchSpecificBpT()
		{
			this.Type = EEntityMatchType.Player;
			this.SpecificBpList = null;
		}
	}
}
