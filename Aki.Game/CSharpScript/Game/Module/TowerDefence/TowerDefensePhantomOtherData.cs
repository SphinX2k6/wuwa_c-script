using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B34 RID: 19252
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomOtherData : ITowerDefensePhantomOtherData
	{
		// Token: 0x17007B7D RID: 31613
		// (get) Token: 0x06031DB7 RID: 204215 RVA: 0x00B92769 File Offset: 0x00B90969
		// (set) Token: 0x06031DB8 RID: 204216 RVA: 0x00B92771 File Offset: 0x00B90971
		public string NameTextId { get; set; }

		// Token: 0x17007B7E RID: 31614
		// (get) Token: 0x06031DB9 RID: 204217 RVA: 0x00B9277A File Offset: 0x00B9097A
		// (set) Token: 0x06031DBA RID: 204218 RVA: 0x00B92782 File Offset: 0x00B90982
		public string TypeTextId { get; set; }

		// Token: 0x17007B7F RID: 31615
		// (get) Token: 0x06031DBB RID: 204219 RVA: 0x00B9278B File Offset: 0x00B9098B
		// (set) Token: 0x06031DBC RID: 204220 RVA: 0x00B92793 File Offset: 0x00B90993
		public string TypeIconPath { get; set; }

		// Token: 0x17007B80 RID: 31616
		// (get) Token: 0x06031DBD RID: 204221 RVA: 0x00B9279C File Offset: 0x00B9099C
		// (set) Token: 0x06031DBE RID: 204222 RVA: 0x00B927A4 File Offset: 0x00B909A4
		public bool IsLocked { get; set; }
	}
}
