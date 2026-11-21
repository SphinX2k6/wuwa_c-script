using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A39 RID: 14905
	public class TrapDefenseBuildingDevelopNormalDragItem : UiPanelBase
	{
		// Token: 0x0602653C RID: 156988 RVA: 0x00ABBDF4 File Offset: 0x00AB9FF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602653D RID: 156989 RVA: 0x00ABBE80 File Offset: 0x00ABA080
		[NullableContext(1)]
		public void UpdateItem(TrapDefenseBuildingDevelopItemData data)
		{
			base.SetTextureByPath(data.GetIconPath(), base.GetTexture(0), null, null);
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0602653E RID: 156990 RVA: 0x00ABBEBC File Offset: 0x00ABA0BC
		[NullableContext(1)]
		public UUIDraggableComponent GetDraggableComp()
		{
			return base.GetDraggable(1);
		}

		// Token: 0x02009603 RID: 38403
		private class ENormalDrag
		{
			// Token: 0x0402ED72 RID: 191858
			public const int Icon = 0;

			// Token: 0x0402ED73 RID: 191859
			public const int Draggable = 1;

			// Token: 0x0402ED74 RID: 191860
			public const int Cost = 2;
		}
	}
}
