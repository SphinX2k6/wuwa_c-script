using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053D0 RID: 21456
	[NullableContext(2)]
	public interface IRewardItemData
	{
		// Token: 0x170083C2 RID: 33730
		// (get) Token: 0x06036D58 RID: 224600
		ItemConfig ItemInfo { get; }

		// Token: 0x170083C3 RID: 33731
		// (get) Token: 0x06036D59 RID: 224601
		int Count { get; }
	}
}
