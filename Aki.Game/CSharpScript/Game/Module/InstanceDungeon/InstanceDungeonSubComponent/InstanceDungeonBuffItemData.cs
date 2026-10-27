using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02005896 RID: 22678
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonBuffItemData
	{
		// Token: 0x17008A8F RID: 35471
		// (get) Token: 0x06039B4B RID: 236363 RVA: 0x00DB6955 File Offset: 0x00DB4B55
		// (set) Token: 0x06039B4C RID: 236364 RVA: 0x00DB695D File Offset: 0x00DB4B5D
		public string BuffText { get; set; }

		// Token: 0x17008A90 RID: 35472
		// (get) Token: 0x06039B4D RID: 236365 RVA: 0x00DB6966 File Offset: 0x00DB4B66
		// (set) Token: 0x06039B4E RID: 236366 RVA: 0x00DB696E File Offset: 0x00DB4B6E
		public bool ShowMonsterPreview { get; set; }

		// Token: 0x17008A91 RID: 35473
		// (get) Token: 0x06039B4F RID: 236367 RVA: 0x00DB6977 File Offset: 0x00DB4B77
		// (set) Token: 0x06039B50 RID: 236368 RVA: 0x00DB697F File Offset: 0x00DB4B7F
		public InstanceDungeonBuffItem.EBuffInfoType BuffInfoType { get; set; }
	}
}
