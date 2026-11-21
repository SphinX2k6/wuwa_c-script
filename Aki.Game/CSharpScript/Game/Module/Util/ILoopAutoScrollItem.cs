using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003851 RID: 14417
	[NullableContext(1)]
	public interface ILoopAutoScrollItem<[Nullable(2)] in TData>
	{
		// Token: 0x0602573E RID: 153406 RVA: 0x00A8CED9 File Offset: 0x00A8B0D9
		void Refresh(TData data)
		{
		}

		// Token: 0x0602573F RID: 153407 RVA: 0x00A8CEDB File Offset: 0x00A8B0DB
		UniTask RefreshAsync(TData data)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06025740 RID: 153408
		UniTask CreateByActorAsync(AActor actor);

		// Token: 0x06025741 RID: 153409
		UUIItem GetRootItem();
	}
}
