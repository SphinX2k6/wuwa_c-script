using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200552D RID: 21805
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardItemBlockGrid : GridProxyAbstract<IPanelPos>
	{
		// Token: 0x06036162 RID: 221538 RVA: 0x00F19A5C File Offset: 0x00F17C5C
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentItem = (this.OpenParam as DockyardItemBlock);
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036163 RID: 221539 RVA: 0x00F19AD8 File Offset: 0x00F17CD8
		private void InitDrag()
		{
			this.DraggableComponent = base.GetDraggable(1);
			this.DraggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.ParentItem.OnPointerDown));
			this.DraggableComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.ParentItem.OnPointerUp));
			this.DraggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.ParentItem.OnPointerUp));
			this.DraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.ParentItem.OnDragBegin));
			this.DraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.ParentItem.OnDrag));
			this.DraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.ParentItem.OnDragEnd));
		}

		// Token: 0x06036164 RID: 221540 RVA: 0x00F19BB8 File Offset: 0x00F17DB8
		protected override void OnStart()
		{
			this.InitDrag();
			base.GetSprite(0).SetUIActive(false);
		}

		// Token: 0x06036165 RID: 221541 RVA: 0x00F19BCD File Offset: 0x00F17DCD
		public override void Refresh(IPanelPos data, bool isSelected, int gridIndex)
		{
			this.Value = this.ParentItem.GetValueByPanelPos(data);
			this.RefreshDragItemActive(false);
		}

		// Token: 0x06036166 RID: 221542 RVA: 0x00F19BE8 File Offset: 0x00F17DE8
		public void RefreshDragItemActive(bool isInSelectState)
		{
			this.DraggableComponent.RootUIComp.Get().SetUIActive(this.Value != 0 || isInSelectState);
		}

		// Token: 0x0401C8F4 RID: 116980
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401C8F5 RID: 116981
		private DockyardItemBlock ParentItem;

		// Token: 0x0401C8F6 RID: 116982
		private int Value;

		// Token: 0x0200B19B RID: 45467
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036E8D RID: 224909
			public const int BgSprite = 0;

			// Token: 0x04036E8E RID: 224910
			public const int DraggableItem = 1;
		}
	}
}
