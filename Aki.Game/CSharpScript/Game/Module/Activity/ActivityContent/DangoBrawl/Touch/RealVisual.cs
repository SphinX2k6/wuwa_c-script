using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x0200685D RID: 26717
	[NullableContext(1)]
	[Nullable(0)]
	public class RealVisual : IDragVisual
	{
		// Token: 0x1700977B RID: 38779
		// (get) Token: 0x06042B68 RID: 273256 RVA: 0x01039DE9 File Offset: 0x01037FE9
		public int SourceUid { get; }

		// Token: 0x1700977C RID: 38780
		// (get) Token: 0x06042B69 RID: 273257 RVA: 0x01039DF1 File Offset: 0x01037FF1
		public int ConfigId { get; }

		// Token: 0x1700977D RID: 38781
		// (get) Token: 0x06042B6A RID: 273258 RVA: 0x01039DF9 File Offset: 0x01037FF9
		public EDragSourceKind Source { get; }

		// Token: 0x1700977E RID: 38782
		// (get) Token: 0x06042B6B RID: 273259 RVA: 0x01039E01 File Offset: 0x01038001
		public EDangoBrawlTemplateType TemplateType { get; }

		// Token: 0x1700977F RID: 38783
		// (get) Token: 0x06042B6C RID: 273260 RVA: 0x01039E09 File Offset: 0x01038009
		// (set) Token: 0x06042B6D RID: 273261 RVA: 0x01039E11 File Offset: 0x01038011
		public EDangoBrawlRotate Rotate { get; set; }

		// Token: 0x17009780 RID: 38784
		// (get) Token: 0x06042B6E RID: 273262 RVA: 0x01039E1A File Offset: 0x0103801A
		public IDangoBrawlDraggableView DraggableItem { get; }

		// Token: 0x17009781 RID: 38785
		// (get) Token: 0x06042B6F RID: 273263 RVA: 0x01039E22 File Offset: 0x01038022
		public DragPayloadFollower[] Followers { get; }

		// Token: 0x17009782 RID: 38786
		// (get) Token: 0x06042B70 RID: 273264 RVA: 0x01039E2A File Offset: 0x0103802A
		// (set) Token: 0x06042B71 RID: 273265 RVA: 0x01039E32 File Offset: 0x01038032
		public FVector2D DragAnchorOffset { get; set; } = new FVector2D(0f, 0f);

		// Token: 0x06042B72 RID: 273266 RVA: 0x01039E3C File Offset: 0x0103803C
		public RealVisual(EDragSourceKind source, int sourceUid, int configId, EDangoBrawlTemplateType type, EDangoBrawlRotate rotate, IDangoBrawlDraggableView draggable, DragPayloadFollower[] followers)
		{
			this.Source = source;
			this.SourceUid = sourceUid;
			this.ConfigId = configId;
			this.TemplateType = type;
			this.Rotate = rotate;
			this.DraggableItem = draggable;
			this.Followers = followers;
		}

		// Token: 0x06042B73 RID: 273267 RVA: 0x01039E9C File Offset: 0x0103809C
		public FVector2D GetLguiTopLeft()
		{
			UUIItem draggableRootItem = this.DraggableItem.GetDraggableRootItem();
			if (!draggableRootItem.IsValid())
			{
				return new FVector2D(0f, 0f);
			}
			FVector2D? itemTopLeft = DangoBrawlUtil.GetItemTopLeft(draggableRootItem);
			if (itemTopLeft == null)
			{
				return new FVector2D(0f, 0f);
			}
			return itemTopLeft.GetValueOrDefault();
		}

		// Token: 0x06042B74 RID: 273268 RVA: 0x01039EF4 File Offset: 0x010380F4
		public void MoveTo(FVector2D pointerLguiPos)
		{
			UUIItem draggableRootItem = this.DraggableItem.GetDraggableRootItem();
			if (!draggableRootItem.IsValid())
			{
				return;
			}
			UUIItem parentAsUIItem = draggableRootItem.GetParentAsUIItem();
			if (parentAsUIItem == null)
			{
				return;
			}
			FVector lguispaceAbsolutePosition = parentAsUIItem.GetLGUISpaceAbsolutePosition();
			FVector2D pivot = draggableRootItem.GetPivot();
			float width = draggableRootItem.GetWidth();
			float height = draggableRootItem.GetHeight();
			FVector2D fvector2D = DangoBrawlUtil.PointerToItemCenter(pointerLguiPos, this.DragAnchorOffset);
			float num = fvector2D.X + (pivot.X - 0.5f) * width;
			float num2 = fvector2D.Y + (pivot.Y - 0.5f) * height;
			draggableRootItem.SetUIRelativeLocation(new FVector(num - lguispaceAbsolutePosition.X, num2 - lguispaceAbsolutePosition.Y, 0f));
			this.DraggableItem.OnMoving();
			foreach (DragPayloadFollower dragPayloadFollower in this.Followers)
			{
				UUIItem draggableRootItem2 = dragPayloadFollower.View.GetDraggableRootItem();
				if (draggableRootItem2.IsValid())
				{
					UUIItem parentAsUIItem2 = draggableRootItem2.GetParentAsUIItem();
					if (parentAsUIItem2 != null)
					{
						FVector lguispaceAbsolutePosition2 = parentAsUIItem2.GetLGUISpaceAbsolutePosition();
						float num3 = num + dragPayloadFollower.OffsetToPrimary.X;
						float num4 = num2 + dragPayloadFollower.OffsetToPrimary.Y;
						draggableRootItem2.SetUIRelativeLocation(new FVector(num3 - lguispaceAbsolutePosition2.X, num4 - lguispaceAbsolutePosition2.Y, 0f));
						dragPayloadFollower.View.OnMoving();
					}
				}
			}
		}

		// Token: 0x06042B75 RID: 273269 RVA: 0x0103A04F File Offset: 0x0103824F
		public void Destroy()
		{
		}
	}
}
