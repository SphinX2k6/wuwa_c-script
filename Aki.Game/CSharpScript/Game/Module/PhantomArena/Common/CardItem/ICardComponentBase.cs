using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051C5 RID: 20933
	[NullableContext(1)]
	public interface ICardComponentBase
	{
		// Token: 0x06035997 RID: 219543
		UniTask CreateByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false);

		// Token: 0x06035998 RID: 219544
		UniTask CreateByResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null, bool usePool = false);
	}
}
