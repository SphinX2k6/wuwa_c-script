using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056ED RID: 22253
	[NullableContext(1)]
	public interface IDragVisual
	{
		// Token: 0x170069D6 RID: 27094
		// (get) Token: 0x06036D47 RID: 224583
		int SourceUid { get; }

		// Token: 0x170069D7 RID: 27095
		// (get) Token: 0x06036D48 RID: 224584
		int ConfigId { get; }

		// Token: 0x170069D8 RID: 27096
		// (get) Token: 0x06036D49 RID: 224585
		EDragSourceKind Source { get; }

		// Token: 0x170069D9 RID: 27097
		// (get) Token: 0x06036D4A RID: 224586
		EDangoBrawlTemplateType TemplateType { get; }

		// Token: 0x170069DA RID: 27098
		// (get) Token: 0x06036D4B RID: 224587
		// (set) Token: 0x06036D4C RID: 224588
		EDangoBrawlRotate Rotate { get; set; }

		// Token: 0x170069DB RID: 27099
		// (get) Token: 0x06036D4D RID: 224589
		IDangoBrawlDraggableView DraggableItem { get; }

		// Token: 0x170069DC RID: 27100
		// (get) Token: 0x06036D4E RID: 224590
		DragPayloadFollower[] Followers { get; }

		// Token: 0x170069DD RID: 27101
		// (get) Token: 0x06036D4F RID: 224591
		// (set) Token: 0x06036D50 RID: 224592
		FVector2D DragAnchorOffset { get; set; }

		// Token: 0x06036D51 RID: 224593
		FVector2D GetLguiTopLeft();

		// Token: 0x06036D52 RID: 224594
		void MoveTo(FVector2D lguiPos);

		// Token: 0x06036D53 RID: 224595
		void Destroy();
	}
}
