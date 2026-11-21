using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C8 RID: 18376
	[NullableContext(2)]
	public interface ICommonRewardComponentUiAccessor
	{
		// Token: 0x0602E29C RID: 189084
		UUIItem GetItemForComponent(int childType);

		// Token: 0x0602E29D RID: 189085
		UUIText GetTextForComponent(int childType);

		// Token: 0x0602E29E RID: 189086
		UUIGridLayout GetGridLayoutForComponent(int childType);

		// Token: 0x0602E29F RID: 189087
		UUIButtonComponent GetButtonForComponent(int childType);
	}
}
