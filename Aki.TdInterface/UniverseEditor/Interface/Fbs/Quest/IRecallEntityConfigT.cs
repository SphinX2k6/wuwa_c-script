using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200408C RID: 16524
	public class IRecallEntityConfigT
	{
		// Token: 0x1700749A RID: 29850
		// (get) Token: 0x060180AD RID: 98477 RVA: 0x00377CAE File Offset: 0x00375EAE
		// (set) Token: 0x060180AE RID: 98478 RVA: 0x00377CB6 File Offset: 0x00375EB6
		public List<IRecallEntityGroupT> EntityGroups { get; set; }

		// Token: 0x1700749B RID: 29851
		// (get) Token: 0x060180AF RID: 98479 RVA: 0x00377CBF File Offset: 0x00375EBF
		// (set) Token: 0x060180B0 RID: 98480 RVA: 0x00377CC7 File Offset: 0x00375EC7
		public List<IRecallEntryT> Recalls { get; set; }

		// Token: 0x060180B1 RID: 98481 RVA: 0x00377CD0 File Offset: 0x00375ED0
		public IRecallEntityConfigT()
		{
			this.EntityGroups = null;
			this.Recalls = null;
		}
	}
}
