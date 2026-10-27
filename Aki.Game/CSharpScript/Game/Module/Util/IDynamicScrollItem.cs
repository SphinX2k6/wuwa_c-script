using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048D5 RID: 18645
	[NullableContext(1)]
	public interface IDynamicScrollItem<[Nullable(2)] TData>
	{
		// Token: 0x06030BA1 RID: 199585
		[return: Nullable(2)]
		AUIBaseActor GetUsingItem(TData data);

		// Token: 0x06030BA2 RID: 199586
		void Update(TData data, int index);

		// Token: 0x06030BA3 RID: 199587
		UniTask Init(UUIItem actor);

		// Token: 0x06030BA4 RID: 199588
		void ClearItem();

		// Token: 0x1700798A RID: 31114
		// (set) Token: 0x06030BA5 RID: 199589
		bool SkipDestroyActor { set; }

		// Token: 0x06030BA6 RID: 199590
		void SetUiActive(bool visibility);
	}
}
