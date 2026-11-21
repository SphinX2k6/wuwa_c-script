using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001879 RID: 6265
[NullableContext(2)]
public interface IGiftDisplayItem
{
	// Token: 0x0600F827 RID: 63527
	[NullableContext(1)]
	UniTask CreateByActorAsync(AActor actor);

	// Token: 0x0600F828 RID: 63528
	UUIItem GetOriginalItem();

	// Token: 0x0600F829 RID: 63529
	void SetActive(bool active);

	// Token: 0x0600F82A RID: 63530
	void Refresh(PayShopGoods data, bool isSelected, int gridIndex);
}
