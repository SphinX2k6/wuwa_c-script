using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EBB RID: 16059
	public class IItemObtainT
	{
		// Token: 0x17006F78 RID: 28536
		// (get) Token: 0x06016B0C RID: 92940 RVA: 0x00346ADD File Offset: 0x00344CDD
		// (set) Token: 0x06016B0D RID: 92941 RVA: 0x00346AE5 File Offset: 0x00344CE5
		public EShowUiType Type { get; set; }

		// Token: 0x17006F79 RID: 28537
		// (get) Token: 0x06016B0E RID: 92942 RVA: 0x00346AEE File Offset: 0x00344CEE
		// (set) Token: 0x06016B0F RID: 92943 RVA: 0x00346AF6 File Offset: 0x00344CF6
		public List<int> ItemIds { get; set; }

		// Token: 0x17006F7A RID: 28538
		// (get) Token: 0x06016B10 RID: 92944 RVA: 0x00346AFF File Offset: 0x00344CFF
		// (set) Token: 0x06016B11 RID: 92945 RVA: 0x00346B07 File Offset: 0x00344D07
		public byte NullMask { get; set; }

		// Token: 0x06016B12 RID: 92946 RVA: 0x00346B10 File Offset: 0x00344D10
		public IItemObtainT()
		{
			this.Type = EShowUiType.All;
			this.ItemIds = null;
			this.NullMask = 0;
		}
	}
}
