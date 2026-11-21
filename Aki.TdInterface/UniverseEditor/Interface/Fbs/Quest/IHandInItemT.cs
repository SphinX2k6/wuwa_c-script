using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C6 RID: 17094
	public class IHandInItemT
	{
		// Token: 0x17007501 RID: 29953
		// (get) Token: 0x06017F8B RID: 98187 RVA: 0x0036C1A5 File Offset: 0x0036A3A5
		// (set) Token: 0x06017F8C RID: 98188 RVA: 0x0036C1AD File Offset: 0x0036A3AD
		public EHandInItemType HandInType { get; set; }

		// Token: 0x17007502 RID: 29954
		// (get) Token: 0x06017F8D RID: 98189 RVA: 0x0036C1B6 File Offset: 0x0036A3B6
		// (set) Token: 0x06017F8E RID: 98190 RVA: 0x0036C1BE File Offset: 0x0036A3BE
		public List<int> ItemIds { get; set; }

		// Token: 0x17007503 RID: 29955
		// (get) Token: 0x06017F8F RID: 98191 RVA: 0x0036C1C7 File Offset: 0x0036A3C7
		// (set) Token: 0x06017F90 RID: 98192 RVA: 0x0036C1CF File Offset: 0x0036A3CF
		public int Count { get; set; }

		// Token: 0x06017F91 RID: 98193 RVA: 0x0036C1D8 File Offset: 0x0036A3D8
		public IHandInItemT()
		{
			this.HandInType = EHandInItemType.ItemIds;
			this.ItemIds = null;
			this.Count = 0;
		}
	}
}
