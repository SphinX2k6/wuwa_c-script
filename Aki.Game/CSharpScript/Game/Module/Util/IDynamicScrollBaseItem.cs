using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200384D RID: 14413
	[NullableContext(1)]
	public interface IDynamicScrollBaseItem<[Nullable(2)] TData>
	{
		// Token: 0x060256D3 RID: 153299
		FVector2D GetItemSize(TData data);

		// Token: 0x060256D4 RID: 153300
		UniTask Init(UUIItem actor);

		// Token: 0x060256D5 RID: 153301
		void ClearItem();
	}
}
