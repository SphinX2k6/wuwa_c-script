using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057F1 RID: 22513
	[NullableContext(2)]
	public interface ICommonRewardComponentUiAccessor
	{
		// Token: 0x06039388 RID: 234376
		UUIItem GetItemForComponent(int childType);

		// Token: 0x06039389 RID: 234377
		UUIText GetTextForComponent(int childType);

		// Token: 0x0603938A RID: 234378
		UUIGridLayout GetGridLayoutForComponent(int childType);

		// Token: 0x0603938B RID: 234379
		UUIButtonComponent GetButtonForComponent(int childType);
	}
}
