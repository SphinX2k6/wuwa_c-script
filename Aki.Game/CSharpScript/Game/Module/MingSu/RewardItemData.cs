using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053D1 RID: 21457
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardItemData : IRewardItemData
	{
		// Token: 0x170083C4 RID: 33732
		// (get) Token: 0x06036D5A RID: 224602 RVA: 0x00CFCA1B File Offset: 0x00CFAC1B
		// (set) Token: 0x06036D5B RID: 224603 RVA: 0x00CFCA23 File Offset: 0x00CFAC23
		public ItemConfig ItemInfo { get; set; }

		// Token: 0x170083C5 RID: 33733
		// (get) Token: 0x06036D5C RID: 224604 RVA: 0x00CFCA2C File Offset: 0x00CFAC2C
		// (set) Token: 0x06036D5D RID: 224605 RVA: 0x00CFCA34 File Offset: 0x00CFAC34
		public int Count { get; set; }
	}
}
