using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02005894 RID: 22676
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonBottomTipItemData
	{
		// Token: 0x17008A8D RID: 35469
		// (get) Token: 0x06039B43 RID: 236355 RVA: 0x00DB6887 File Offset: 0x00DB4A87
		// (set) Token: 0x06039B44 RID: 236356 RVA: 0x00DB688F File Offset: 0x00DB4A8F
		public string TextId { get; set; } = "";

		// Token: 0x17008A8E RID: 35470
		// (get) Token: 0x06039B45 RID: 236357 RVA: 0x00DB6898 File Offset: 0x00DB4A98
		// (set) Token: 0x06039B46 RID: 236358 RVA: 0x00DB68A0 File Offset: 0x00DB4AA0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] TextArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
