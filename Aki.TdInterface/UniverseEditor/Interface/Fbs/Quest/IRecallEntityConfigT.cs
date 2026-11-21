using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044CD RID: 17613
	public class IRecallEntityConfigT
	{
		// Token: 0x17007A9C RID: 31388
		// (get) Token: 0x06019746 RID: 104262 RVA: 0x003A1AE6 File Offset: 0x0039FCE6
		// (set) Token: 0x06019747 RID: 104263 RVA: 0x003A1AEE File Offset: 0x0039FCEE
		public List<IRecallEntityGroupT> EntityGroups { get; set; }

		// Token: 0x17007A9D RID: 31389
		// (get) Token: 0x06019748 RID: 104264 RVA: 0x003A1AF7 File Offset: 0x0039FCF7
		// (set) Token: 0x06019749 RID: 104265 RVA: 0x003A1AFF File Offset: 0x0039FCFF
		public List<IRecallEntryT> Recalls { get; set; }

		// Token: 0x0601974A RID: 104266 RVA: 0x003A1B08 File Offset: 0x0039FD08
		public IRecallEntityConfigT()
		{
			this.EntityGroups = null;
			this.Recalls = null;
		}
	}
}
