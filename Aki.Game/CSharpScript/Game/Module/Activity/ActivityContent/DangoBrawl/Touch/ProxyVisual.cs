using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057AC RID: 22444
	[NullableContext(1)]
	[Nullable(0)]
	public class ProxyVisual : IDragVisual
	{
		// Token: 0x17006AB4 RID: 27316
		// (get) Token: 0x060376AD RID: 226989 RVA: 0x00F7B0EB File Offset: 0x00F792EB
		public int SourceUid
		{
			get
			{
				DangoBrawlViewItemBase innerPanel = this.InnerPanel;
				if (innerPanel == null)
				{
					return 0;
				}
				return innerPanel.MyUid;
			}
		}

		// Token: 0x17006AB5 RID: 27317
		// (get) Token: 0x060376AE RID: 226990 RVA: 0x00F7B0FE File Offset: 0x00F792FE
		public int ConfigId
		{
			get
			{
				DangoBrawlViewItemBase innerPanel = this.InnerPanel;
				if (innerPanel == null)
				{
					return 0;
				}
				return innerPanel.MyConfigId;
			}
		}

		// Token: 0x17006AB6 RID: 27318
		// (get) Token: 0x060376AF RID: 226991 RVA: 0x00F7B111 File Offset: 0x00F79311
		public EDragSourceKind Source
		{
			get
			{
				return EDragSourceKind.Shop;
			}
		}

		// Token: 0x17006AB7 RID: 27319
		// (get) Token: 0x060376B0 RID: 226992 RVA: 0x00F7B114 File Offset: 0x00F79314
		public EDangoBrawlTemplateType TemplateType { get; }

		// Token: 0x17006AB8 RID: 27320
		// (get) Token: 0x060376B1 RID: 226993 RVA: 0x00F7B11C File Offset: 0x00F7931C
		// (set) Token: 0x060376B2 RID: 226994 RVA: 0x00F7B124 File Offset: 0x00F79324
		public EDangoBrawlRotate Rotate { get; set; }

		// Token: 0x17006AB9 RID: 27321
		// (get) Token: 0x060376B3 RID: 226995 RVA: 0x00F7B12D File Offset: 0x00F7932D
		public IDangoBrawlDraggableView DraggableItem
		{
			get
			{
				return this.InnerPanel;
			}
		}

		// Token: 0x17006ABA RID: 27322
		// (get) Token: 0x060376B4 RID: 226996 RVA: 0x00F7B135 File Offset: 0x00F79335
		public DragPayloadFollower[] Followers
		{
			get
			{
				return Array.Empty<DragPayloadFollower>();
			}
		}

		// Token: 0x17006ABB RID: 27323
		// (get) Token: 0x060376B5 RID: 226997 RVA: 0x00F7B13C File Offset: 0x00F7933C
		// (set) Token: 0x060376B6 RID: 226998 RVA: 0x00F7B144 File Offset: 0x00F79344
		public FVector2D DragAnchorOffset { get; set; } = new FVector2D(0f, 0f);

		// Token: 0x060376B7 RID: 226999 RVA: 0x00F7B14D File Offset: 0x00F7934D
		private ProxyVisual(UUIItem rootItem, UUIItem parent, EDangoBrawlTemplateType templateType)
		{
			this.RootItem = rootItem;
			this.Parent = parent;
			this.TemplateType = templateType;
		}

		// Token: 0x060376B8 RID: 227000 RVA: 0x00F7B180 File Offset: 0x00F79380
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<ProxyVisual> CreateProxyVisualAsync(ActivityDangoBrawlData data, UUIItem template, UUIItem container, int uid, int configId, EDangoBrawlTemplateType type)
		{
			ProxyVisual.<CreateProxyVisualAsync>d__25 <CreateProxyVisualAsync>d__;
			<CreateProxyVisualAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ProxyVisual>.Create();
			<CreateProxyVisualAsync>d__.data = data;
			<CreateProxyVisualAsync>d__.template = template;
			<CreateProxyVisualAsync>d__.container = container;
			<CreateProxyVisualAsync>d__.uid = uid;
			<CreateProxyVisualAsync>d__.configId = configId;
			<CreateProxyVisualAsync>d__.type = type;
			<CreateProxyVisualAsync>d__.<>1__state = -1;
			<CreateProxyVisualAsync>d__.<>t__builder.Start<ProxyVisual.<CreateProxyVisualAsync>d__25>(ref <CreateProxyVisualAsync>d__);
			return <CreateProxyVisualAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060376B9 RID: 227001 RVA: 0x00F7B1F0 File Offset: 0x00F793F0
		public FVector2D GetLguiTopLeft()
		{
			if (!this.RootItem.IsValid())
			{
				return new FVector2D(0f, 0f);
			}
			FVector2D? itemTopLeft = DangoBrawlUtil.GetItemTopLeft(this.RootItem);
			if (itemTopLeft == null)
			{
				return new FVector2D(0f, 0f);
			}
			return itemTopLeft.GetValueOrDefault();
		}

		// Token: 0x060376BA RID: 227002 RVA: 0x00F7B248 File Offset: 0x00F79448
		public void MoveTo(FVector2D pointerLguiPos)
		{
			if (!this.RootItem.IsValid() || !this.Parent.IsValid())
			{
				return;
			}
			FVector lguispaceAbsolutePosition = this.Parent.GetLGUISpaceAbsolutePosition();
			FVector2D pivot = this.RootItem.GetPivot();
			float width = this.RootItem.GetWidth();
			float height = this.RootItem.GetHeight();
			FVector2D fvector2D = DangoBrawlUtil.PointerToItemCenter(pointerLguiPos, this.DragAnchorOffset);
			float num = fvector2D.X + (pivot.X - 0.5f) * width;
			float num2 = fvector2D.Y + (pivot.Y - 0.5f) * height;
			this.RootItem.SetUIRelativeLocation(new FVector(num - lguispaceAbsolutePosition.X, num2 - lguispaceAbsolutePosition.Y, 0f));
			this.DraggableItem.OnMoving();
		}

		// Token: 0x060376BB RID: 227003 RVA: 0x00F7B30B File Offset: 0x00F7950B
		public void Destroy()
		{
			DangoBrawlViewItemBase innerPanel = this.InnerPanel;
			if (innerPanel != null)
			{
				innerPanel.Destroy(null);
			}
			this.InnerPanel = null;
		}

		// Token: 0x060376BC RID: 227004 RVA: 0x00F7B326 File Offset: 0x00F79526
		public DangoBrawlViewItemBase DetachInnerPanel()
		{
			DangoBrawlViewItemBase innerPanel = this.InnerPanel;
			this.InnerPanel = null;
			return innerPanel;
		}

		// Token: 0x0401D400 RID: 119808
		protected readonly UUIItem RootItem;

		// Token: 0x0401D401 RID: 119809
		protected readonly UUIItem Parent;

		// Token: 0x0401D402 RID: 119810
		[Nullable(2)]
		protected DangoBrawlViewItemBase InnerPanel;
	}
}
