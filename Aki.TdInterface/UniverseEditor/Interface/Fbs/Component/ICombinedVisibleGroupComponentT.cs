using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005527 RID: 21799
	public class ICombinedVisibleGroupComponentT
	{
		// Token: 0x17009BCE RID: 39886
		// (get) Token: 0x06022773 RID: 141171 RVA: 0x004BF85A File Offset: 0x004BDA5A
		// (set) Token: 0x06022774 RID: 141172 RVA: 0x004BF862 File Offset: 0x004BDA62
		public bool Disabled { get; set; }

		// Token: 0x17009BCF RID: 39887
		// (get) Token: 0x06022775 RID: 141173 RVA: 0x004BF86B File Offset: 0x004BDA6B
		// (set) Token: 0x06022776 RID: 141174 RVA: 0x004BF873 File Offset: 0x004BDA73
		public List<int> AreaIds { get; set; }

		// Token: 0x17009BD0 RID: 39888
		// (get) Token: 0x06022777 RID: 141175 RVA: 0x004BF87C File Offset: 0x004BDA7C
		// (set) Token: 0x06022778 RID: 141176 RVA: 0x004BF884 File Offset: 0x004BDA84
		public bool IncludeSubArea { get; set; }

		// Token: 0x17009BD1 RID: 39889
		// (get) Token: 0x06022779 RID: 141177 RVA: 0x004BF88D File Offset: 0x004BDA8D
		// (set) Token: 0x0602277A RID: 141178 RVA: 0x004BF895 File Offset: 0x004BDA95
		public List<int> EntityIds { get; set; }

		// Token: 0x17009BD2 RID: 39890
		// (get) Token: 0x0602277B RID: 141179 RVA: 0x004BF89E File Offset: 0x004BDA9E
		// (set) Token: 0x0602277C RID: 141180 RVA: 0x004BF8A6 File Offset: 0x004BDAA6
		public byte NullMask { get; set; }

		// Token: 0x0602277D RID: 141181 RVA: 0x004BF8AF File Offset: 0x004BDAAF
		public ICombinedVisibleGroupComponentT()
		{
			this.Disabled = false;
			this.AreaIds = null;
			this.IncludeSubArea = false;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
