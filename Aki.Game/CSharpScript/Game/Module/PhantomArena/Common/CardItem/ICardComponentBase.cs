using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x02004195 RID: 16789
	[NullableContext(1)]
	public interface ICardComponentBase
	{
		// Token: 0x0602A892 RID: 174226
		UniTask CreateByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false);

		// Token: 0x0602A893 RID: 174227
		UniTask CreateByResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null, bool usePool = false);
	}
}
