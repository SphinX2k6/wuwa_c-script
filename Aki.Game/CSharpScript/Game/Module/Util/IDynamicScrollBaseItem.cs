using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048D6 RID: 18646
	[NullableContext(1)]
	public interface IDynamicScrollBaseItem<[Nullable(2)] TData>
	{
		// Token: 0x06030BA7 RID: 199591
		FVector2D GetItemSize(TData data);

		// Token: 0x06030BA8 RID: 199592
		UniTask Init(UUIItem actor);

		// Token: 0x06030BA9 RID: 199593
		void ClearItem();
	}
}
