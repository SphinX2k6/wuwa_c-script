using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x0200685C RID: 26716
	[NullableContext(1)]
	[Nullable(0)]
	public class ProxyVisual : IDragVisual
	{
		// Token: 0x17009773 RID: 38771
		// (get) Token: 0x06042B58 RID: 273240 RVA: 0x01039B9F File Offset: 0x01037D9F
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

		// Token: 0x17009774 RID: 38772
		// (get) Token: 0x06042B59 RID: 273241 RVA: 0x01039BB2 File Offset: 0x01037DB2
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

		// Token: 0x17009775 RID: 38773
		// (get) Token: 0x06042B5A RID: 273242 RVA: 0x01039BC5 File Offset: 0x01037DC5
		public EDragSourceKind Source
		{
			get
			{
				return EDragSourceKind.Shop;
			}
		}

		// Token: 0x17009776 RID: 38774
		// (get) Token: 0x06042B5B RID: 273243 RVA: 0x01039BC8 File Offset: 0x01037DC8
		public EDangoBrawlTemplateType TemplateType { get; }

		// Token: 0x17009777 RID: 38775
		// (get) Token: 0x06042B5C RID: 273244 RVA: 0x01039BD0 File Offset: 0x01037DD0
		// (set) Token: 0x06042B5D RID: 273245 RVA: 0x01039BD8 File Offset: 0x01037DD8
		public EDangoBrawlRotate Rotate { get; set; }

		// Token: 0x17009778 RID: 38776
		// (get) Token: 0x06042B5E RID: 273246 RVA: 0x01039BE1 File Offset: 0x01037DE1
		public IDangoBrawlDraggableView DraggableItem
		{
			get
			{
				return this.InnerPanel;
			}
		}

		// Token: 0x17009779 RID: 38777
		// (get) Token: 0x06042B5F RID: 273247 RVA: 0x01039BE9 File Offset: 0x01037DE9
		public DragPayloadFollower[] Followers
		{
			get
			{
				return Array.Empty<DragPayloadFollower>();
			}
		}

		// Token: 0x1700977A RID: 38778
		// (get) Token: 0x06042B60 RID: 273248 RVA: 0x01039BF0 File Offset: 0x01037DF0
		// (set) Token: 0x06042B61 RID: 273249 RVA: 0x01039BF8 File Offset: 0x01037DF8
		public FVector2D DragAnchorOffset { get; set; } = new FVector2D(0f, 0f);

		// Token: 0x06042B62 RID: 273250 RVA: 0x01039C01 File Offset: 0x01037E01
		private ProxyVisual(UUIItem rootItem, UUIItem parent, EDangoBrawlTemplateType templateType)
		{
			this.RootItem = rootItem;
			this.Parent = parent;
			this.TemplateType = templateType;
		}

		// Token: 0x06042B63 RID: 273251 RVA: 0x01039C34 File Offset: 0x01037E34
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

		// Token: 0x06042B64 RID: 273252 RVA: 0x01039CA4 File Offset: 0x01037EA4
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

		// Token: 0x06042B65 RID: 273253 RVA: 0x01039CFC File Offset: 0x01037EFC
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

		// Token: 0x06042B66 RID: 273254 RVA: 0x01039DBF File Offset: 0x01037FBF
		public void Destroy()
		{
			DangoBrawlViewItemBase innerPanel = this.InnerPanel;
			if (innerPanel != null)
			{
				innerPanel.Destroy(null);
			}
			this.InnerPanel = null;
		}

		// Token: 0x06042B67 RID: 273255 RVA: 0x01039DDA File Offset: 0x01037FDA
		public DangoBrawlViewItemBase DetachInnerPanel()
		{
			DangoBrawlViewItemBase innerPanel = this.InnerPanel;
			this.InnerPanel = null;
			return innerPanel;
		}

		// Token: 0x04022BA3 RID: 142243
		protected readonly UUIItem RootItem;

		// Token: 0x04022BA4 RID: 142244
		protected readonly UUIItem Parent;

		// Token: 0x04022BA5 RID: 142245
		[Nullable(2)]
		protected DangoBrawlViewItemBase InnerPanel;
	}
}
