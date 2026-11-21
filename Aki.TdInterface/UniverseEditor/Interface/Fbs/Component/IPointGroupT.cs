using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D62 RID: 23906
	public class IPointGroupT
	{
		// Token: 0x1700AFF6 RID: 45046
		// (get) Token: 0x06027CBF RID: 163007 RVA: 0x00571C30 File Offset: 0x0056FE30
		// (set) Token: 0x06027CC0 RID: 163008 RVA: 0x00571C38 File Offset: 0x0056FE38
		public IPointGroupByLayerT GroupConfig { get; set; }

		// Token: 0x1700AFF7 RID: 45047
		// (get) Token: 0x06027CC1 RID: 163009 RVA: 0x00571C41 File Offset: 0x0056FE41
		// (set) Token: 0x06027CC2 RID: 163010 RVA: 0x00571C49 File Offset: 0x0056FE49
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x06027CC3 RID: 163011 RVA: 0x00571C52 File Offset: 0x0056FE52
		public IPointGroupT()
		{
			this.GroupConfig = null;
			this.Points = null;
		}
	}
}
