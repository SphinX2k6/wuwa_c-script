using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048DA RID: 18650
	[NullableContext(1)]
	public interface ILoopAutoScrollItem<[Nullable(2)] in TData>
	{
		// Token: 0x06030C11 RID: 199697 RVA: 0x00B52069 File Offset: 0x00B50269
		void Refresh(TData data)
		{
		}

		// Token: 0x06030C12 RID: 199698 RVA: 0x00B5206B File Offset: 0x00B5026B
		UniTask RefreshAsync(TData data)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06030C13 RID: 199699
		UniTask CreateByActorAsync(AActor actor);

		// Token: 0x06030C14 RID: 199700
		UUIItem GetRootItem();
	}
}
