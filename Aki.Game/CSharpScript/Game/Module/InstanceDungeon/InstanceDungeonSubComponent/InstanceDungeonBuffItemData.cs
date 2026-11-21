using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200486E RID: 18542
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonBuffItemData
	{
		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x0602EA6E RID: 191086 RVA: 0x00D0586D File Offset: 0x00D03A6D
		// (set) Token: 0x0602EA6F RID: 191087 RVA: 0x00D05875 File Offset: 0x00D03A75
		public string BuffText { get; set; }

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x0602EA70 RID: 191088 RVA: 0x00D0587E File Offset: 0x00D03A7E
		// (set) Token: 0x0602EA71 RID: 191089 RVA: 0x00D05886 File Offset: 0x00D03A86
		public bool ShowMonsterPreview { get; set; }

		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x0602EA72 RID: 191090 RVA: 0x00D0588F File Offset: 0x00D03A8F
		// (set) Token: 0x0602EA73 RID: 191091 RVA: 0x00D05897 File Offset: 0x00D03A97
		public InstanceDungeonBuffItem.EBuffInfoType BuffInfoType { get; set; }
	}
}
