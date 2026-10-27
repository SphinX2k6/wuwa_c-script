using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065AF RID: 26031
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardItemBlockGrid : GridProxyAbstract<IPanelPos>
	{
		// Token: 0x0604149D RID: 267421 RVA: 0x00FD2A58 File Offset: 0x00FD0C58
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

		// Token: 0x0604149E RID: 267422 RVA: 0x00FD2AD4 File Offset: 0x00FD0CD4
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

		// Token: 0x0604149F RID: 267423 RVA: 0x00FD2BB4 File Offset: 0x00FD0DB4
		protected override void OnStart()
		{
			this.InitDrag();
			base.GetSprite(0).SetUIActive(false);
		}

		// Token: 0x060414A0 RID: 267424 RVA: 0x00FD2BC9 File Offset: 0x00FD0DC9
		public override void Refresh(IPanelPos data, bool isSelected, int gridIndex)
		{
			this.Value = this.ParentItem.GetValueByPanelPos(data);
			this.RefreshDragItemActive(false);
		}

		// Token: 0x060414A1 RID: 267425 RVA: 0x00FD2BE4 File Offset: 0x00FD0DE4
		public void RefreshDragItemActive(bool isInSelectState)
		{
			this.DraggableComponent.RootUIComp.Get().SetUIActive(this.Value != 0 || isInSelectState);
		}

		// Token: 0x04021FC3 RID: 139203
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x04021FC4 RID: 139204
		private DockyardItemBlock ParentItem;

		// Token: 0x04021FC5 RID: 139205
		private int Value;

		// Token: 0x0200C7B6 RID: 51126
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C53C RID: 247100
			public const int BgSprite = 0;

			// Token: 0x0403C53D RID: 247101
			public const int DraggableItem = 1;
		}
	}
}
