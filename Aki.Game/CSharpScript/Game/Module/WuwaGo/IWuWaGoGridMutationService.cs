using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004715 RID: 18197
	[NullableContext(1)]
	public interface IWuWaGoGridMutationService
	{
		// Token: 0x0602F8D2 RID: 194770
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		UniTask<IWuWaGoMovableFloorBatchResult> ExecuteMovableFloorBatch(IReadOnlyList<MovableFloorController> controllers, string batchSource);
	}
}
