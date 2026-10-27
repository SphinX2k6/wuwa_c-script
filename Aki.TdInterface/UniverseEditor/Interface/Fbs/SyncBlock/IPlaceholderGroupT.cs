using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B7C RID: 15228
	public class IPlaceholderGroupT
	{
		// Token: 0x1700686B RID: 26731
		// (get) Token: 0x06014DB9 RID: 85433 RVA: 0x003073BB File Offset: 0x003055BB
		// (set) Token: 0x06014DBA RID: 85434 RVA: 0x003073C3 File Offset: 0x003055C3
		public int FragmentId { get; set; }

		// Token: 0x1700686C RID: 26732
		// (get) Token: 0x06014DBB RID: 85435 RVA: 0x003073CC File Offset: 0x003055CC
		// (set) Token: 0x06014DBC RID: 85436 RVA: 0x003073D4 File Offset: 0x003055D4
		public List<IPlaceholderT> Placeholders { get; set; }

		// Token: 0x06014DBD RID: 85437 RVA: 0x003073DD File Offset: 0x003055DD
		public IPlaceholderGroupT()
		{
			this.FragmentId = 0;
			this.Placeholders = null;
		}
	}
}
