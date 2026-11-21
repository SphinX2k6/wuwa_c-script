using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043B3 RID: 17331
	[NullableContext(2)]
	public interface IRewardItemData
	{
		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x0602BC9F RID: 179359
		ItemConfig ItemInfo { get; }

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x0602BCA0 RID: 179360
		int Count { get; }
	}
}
