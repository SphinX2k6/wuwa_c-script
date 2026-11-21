using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x02006258 RID: 25176
	[NullableContext(2)]
	public interface IEffectVisibilityRecord
	{
		// Token: 0x170072EB RID: 29419
		// (get) Token: 0x0603CBF7 RID: 248823
		// (set) Token: 0x0603CBF8 RID: 248824
		[Nullable(1)]
		DragPlayEffectVisibilityProvider Provider { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170072EC RID: 29420
		// (get) Token: 0x0603CBF9 RID: 248825
		// (set) Token: 0x0603CBFA RID: 248826
		IGuidePathVisibilityHost Attached { get; set; }

		// Token: 0x170072ED RID: 29421
		// (get) Token: 0x0603CBFB RID: 248827
		// (set) Token: 0x0603CBFC RID: 248828
		Action CancelPending { get; set; }
	}
}
