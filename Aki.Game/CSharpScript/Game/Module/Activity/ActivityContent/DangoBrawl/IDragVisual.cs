using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200679D RID: 26525
	[NullableContext(1)]
	public interface IDragVisual
	{
		// Token: 0x17009695 RID: 38549
		// (get) Token: 0x060421F1 RID: 270833
		int SourceUid { get; }

		// Token: 0x17009696 RID: 38550
		// (get) Token: 0x060421F2 RID: 270834
		int ConfigId { get; }

		// Token: 0x17009697 RID: 38551
		// (get) Token: 0x060421F3 RID: 270835
		EDragSourceKind Source { get; }

		// Token: 0x17009698 RID: 38552
		// (get) Token: 0x060421F4 RID: 270836
		EDangoBrawlTemplateType TemplateType { get; }

		// Token: 0x17009699 RID: 38553
		// (get) Token: 0x060421F5 RID: 270837
		// (set) Token: 0x060421F6 RID: 270838
		EDangoBrawlRotate Rotate { get; set; }

		// Token: 0x1700969A RID: 38554
		// (get) Token: 0x060421F7 RID: 270839
		IDangoBrawlDraggableView DraggableItem { get; }

		// Token: 0x1700969B RID: 38555
		// (get) Token: 0x060421F8 RID: 270840
		DragPayloadFollower[] Followers { get; }

		// Token: 0x1700969C RID: 38556
		// (get) Token: 0x060421F9 RID: 270841
		// (set) Token: 0x060421FA RID: 270842
		FVector2D DragAnchorOffset { get; set; }

		// Token: 0x060421FB RID: 270843
		FVector2D GetLguiTopLeft();

		// Token: 0x060421FC RID: 270844
		void MoveTo(FVector2D lguiPos);

		// Token: 0x060421FD RID: 270845
		void Destroy();
	}
}
