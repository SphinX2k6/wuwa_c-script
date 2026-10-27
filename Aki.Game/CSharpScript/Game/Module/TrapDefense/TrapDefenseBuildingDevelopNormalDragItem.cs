using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A91 RID: 19089
	public class TrapDefenseBuildingDevelopNormalDragItem : UiPanelBase
	{
		// Token: 0x060317AC RID: 202668 RVA: 0x00B77E40 File Offset: 0x00B76040
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

		// Token: 0x060317AD RID: 202669 RVA: 0x00B77ECC File Offset: 0x00B760CC
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

		// Token: 0x060317AE RID: 202670 RVA: 0x00B77F08 File Offset: 0x00B76108
		[NullableContext(1)]
		public UUIDraggableComponent GetDraggableComp()
		{
			return base.GetDraggable(1);
		}

		// Token: 0x0200ABE3 RID: 44003
		private class ENormalDrag
		{
			// Token: 0x040343C1 RID: 213953
			public const int Icon = 0;

			// Token: 0x040343C2 RID: 213954
			public const int Draggable = 1;

			// Token: 0x040343C3 RID: 213955
			public const int Cost = 2;
		}
	}
}
