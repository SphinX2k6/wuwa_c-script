using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057AD RID: 22445
	[NullableContext(1)]
	[Nullable(0)]
	public class RealVisual : IDragVisual
	{
		// Token: 0x17006ABC RID: 27324
		// (get) Token: 0x060376BD RID: 227005 RVA: 0x00F7B335 File Offset: 0x00F79535
		public int SourceUid { get; }

		// Token: 0x17006ABD RID: 27325
		// (get) Token: 0x060376BE RID: 227006 RVA: 0x00F7B33D File Offset: 0x00F7953D
		public int ConfigId { get; }

		// Token: 0x17006ABE RID: 27326
		// (get) Token: 0x060376BF RID: 227007 RVA: 0x00F7B345 File Offset: 0x00F79545
		public EDragSourceKind Source { get; }

		// Token: 0x17006ABF RID: 27327
		// (get) Token: 0x060376C0 RID: 227008 RVA: 0x00F7B34D File Offset: 0x00F7954D
		public EDangoBrawlTemplateType TemplateType { get; }

		// Token: 0x17006AC0 RID: 27328
		// (get) Token: 0x060376C1 RID: 227009 RVA: 0x00F7B355 File Offset: 0x00F79555
		// (set) Token: 0x060376C2 RID: 227010 RVA: 0x00F7B35D File Offset: 0x00F7955D
		public EDangoBrawlRotate Rotate { get; set; }

		// Token: 0x17006AC1 RID: 27329
		// (get) Token: 0x060376C3 RID: 227011 RVA: 0x00F7B366 File Offset: 0x00F79566
		public IDangoBrawlDraggableView DraggableItem { get; }

		// Token: 0x17006AC2 RID: 27330
		// (get) Token: 0x060376C4 RID: 227012 RVA: 0x00F7B36E File Offset: 0x00F7956E
		public DragPayloadFollower[] Followers { get; }

		// Token: 0x17006AC3 RID: 27331
		// (get) Token: 0x060376C5 RID: 227013 RVA: 0x00F7B376 File Offset: 0x00F79576
		// (set) Token: 0x060376C6 RID: 227014 RVA: 0x00F7B37E File Offset: 0x00F7957E
		public FVector2D DragAnchorOffset { get; set; } = new FVector2D(0f, 0f);

		// Token: 0x060376C7 RID: 227015 RVA: 0x00F7B388 File Offset: 0x00F79588
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

		// Token: 0x060376C8 RID: 227016 RVA: 0x00F7B3E8 File Offset: 0x00F795E8
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

		// Token: 0x060376C9 RID: 227017 RVA: 0x00F7B440 File Offset: 0x00F79640
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

		// Token: 0x060376CA RID: 227018 RVA: 0x00F7B59B File Offset: 0x00F7979B
		public void Destroy()
		{
		}
	}
}
