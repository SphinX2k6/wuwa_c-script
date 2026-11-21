using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C3 RID: 17091
	public class IHandInGroupT
	{
		// Token: 0x170074F8 RID: 29944
		// (get) Token: 0x06017F65 RID: 98149 RVA: 0x0036BD7D File Offset: 0x00369F7D
		// (set) Token: 0x06017F66 RID: 98150 RVA: 0x0036BD85 File Offset: 0x00369F85
		public EHandInItemType HandInType { get; set; }

		// Token: 0x170074F9 RID: 29945
		// (get) Token: 0x06017F67 RID: 98151 RVA: 0x0036BD8E File Offset: 0x00369F8E
		// (set) Token: 0x06017F68 RID: 98152 RVA: 0x0036BD96 File Offset: 0x00369F96
		public List<int> ItemIds { get; set; }

		// Token: 0x170074FA RID: 29946
		// (get) Token: 0x06017F69 RID: 98153 RVA: 0x0036BD9F File Offset: 0x00369F9F
		// (set) Token: 0x06017F6A RID: 98154 RVA: 0x0036BDA7 File Offset: 0x00369FA7
		public int Count { get; set; }

		// Token: 0x170074FB RID: 29947
		// (get) Token: 0x06017F6B RID: 98155 RVA: 0x0036BDB0 File Offset: 0x00369FB0
		// (set) Token: 0x06017F6C RID: 98156 RVA: 0x0036BDB8 File Offset: 0x00369FB8
		public int Slot { get; set; }

		// Token: 0x170074FC RID: 29948
		// (get) Token: 0x06017F6D RID: 98157 RVA: 0x0036BDC1 File Offset: 0x00369FC1
		// (set) Token: 0x06017F6E RID: 98158 RVA: 0x0036BDC9 File Offset: 0x00369FC9
		public IHandInItemRangeT ChoiceRange { get; set; }

		// Token: 0x06017F6F RID: 98159 RVA: 0x0036BDD2 File Offset: 0x00369FD2
		public IHandInGroupT()
		{
			this.HandInType = EHandInItemType.ItemIds;
			this.ItemIds = null;
			this.Count = 0;
			this.Slot = 0;
			this.ChoiceRange = null;
		}
	}
}
