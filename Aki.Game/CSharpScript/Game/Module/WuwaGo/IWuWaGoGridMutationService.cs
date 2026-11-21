using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003645 RID: 13893
	[NullableContext(1)]
	public interface IWuWaGoGridMutationService
	{
		// Token: 0x06024098 RID: 147608
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		UniTask<IWuWaGoMovableFloorBatchResult> ExecuteMovableFloorBatch(IReadOnlyList<MovableFloorController> controllers, string batchSource);
	}
}
