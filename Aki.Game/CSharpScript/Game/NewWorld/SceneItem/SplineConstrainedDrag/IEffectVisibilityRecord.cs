using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071A3 RID: 29091
	[NullableContext(2)]
	public interface IEffectVisibilityRecord
	{
		// Token: 0x17009D9E RID: 40350
		// (get) Token: 0x060472FF RID: 291583
		// (set) Token: 0x06047300 RID: 291584
		[Nullable(1)]
		DragPlayEffectVisibilityProvider Provider { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009D9F RID: 40351
		// (get) Token: 0x06047301 RID: 291585
		// (set) Token: 0x06047302 RID: 291586
		IGuidePathVisibilityHost Attached { get; set; }

		// Token: 0x17009DA0 RID: 40352
		// (get) Token: 0x06047303 RID: 291587
		// (set) Token: 0x06047304 RID: 291588
		Action CancelPending { get; set; }
	}
}
