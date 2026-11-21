using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200384C RID: 14412
	[NullableContext(1)]
	public interface IDynamicScrollItem<[Nullable(2)] TData>
	{
		// Token: 0x060256CD RID: 153293
		[return: Nullable(2)]
		AUIBaseActor GetUsingItem(TData data);

		// Token: 0x060256CE RID: 153294
		void Update(TData data, int index);

		// Token: 0x060256CF RID: 153295
		UniTask Init(UUIItem actor);

		// Token: 0x060256D0 RID: 153296
		void ClearItem();

		// Token: 0x17004CF2 RID: 19698
		// (set) Token: 0x060256D1 RID: 153297
		bool SkipDestroyActor { set; }

		// Token: 0x060256D2 RID: 153298
		void SetUiActive(bool visibility);
	}
}
