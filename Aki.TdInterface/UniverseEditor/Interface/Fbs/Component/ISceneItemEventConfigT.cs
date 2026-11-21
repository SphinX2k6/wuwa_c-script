using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ECC RID: 24268
	public class ISceneItemEventConfigT
	{
		// Token: 0x1700B34C RID: 45900
		// (get) Token: 0x06028ACA RID: 166602 RVA: 0x0058F5E6 File Offset: 0x0058D7E6
		// (set) Token: 0x06028ACB RID: 166603 RVA: 0x0058F5EE File Offset: 0x0058D7EE
		public string EntityStateTagName { get; set; }

		// Token: 0x1700B34D RID: 45901
		// (get) Token: 0x06028ACC RID: 166604 RVA: 0x0058F5F7 File Offset: 0x0058D7F7
		// (set) Token: 0x06028ACD RID: 166605 RVA: 0x0058F5FF File Offset: 0x0058D7FF
		public List<ISceneItemSequenceEventDataT> SequenceEvents { get; set; }

		// Token: 0x1700B34E RID: 45902
		// (get) Token: 0x06028ACE RID: 166606 RVA: 0x0058F608 File Offset: 0x0058D808
		// (set) Token: 0x06028ACF RID: 166607 RVA: 0x0058F610 File Offset: 0x0058D810
		public byte NullMask { get; set; }

		// Token: 0x06028AD0 RID: 166608 RVA: 0x0058F619 File Offset: 0x0058D819
		public ISceneItemEventConfigT()
		{
			this.EntityStateTagName = null;
			this.SequenceEvents = null;
			this.NullMask = 0;
		}
	}
}
