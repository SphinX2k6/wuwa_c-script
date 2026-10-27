using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002394 RID: 9108
[NullableContext(2)]
public interface IGiftDisplayItem
{
	// Token: 0x06012375 RID: 74613
	[NullableContext(1)]
	UniTask CreateByActorAsync(AActor actor);

	// Token: 0x06012376 RID: 74614
	UUIItem GetOriginalItem();

	// Token: 0x06012377 RID: 74615
	void SetActive(bool active);

	// Token: 0x06012378 RID: 74616
	void Refresh(PayShopGoods data, bool isSelected, int gridIndex);
}
