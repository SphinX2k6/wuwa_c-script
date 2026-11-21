using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004674 RID: 18036
	public class ExpItem : UiPanelBase
	{
		// Token: 0x0602D5CF RID: 185807 RVA: 0x00CB3B43 File Offset: 0x00CB1D43
		[NullableContext(1)]
		public ExpItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D5D0 RID: 185808 RVA: 0x00CB3B58 File Offset: 0x00CB1D58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D5D1 RID: 185809 RVA: 0x00CB3C04 File Offset: 0x00CB1E04
		public void SetExpSprite(int last, int sum)
		{
			double num = MathUtils.Instance.GetFloatPointFloor((double)last / (double)sum, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(0).SetFillAmount((float)num);
		}

		// Token: 0x0602D5D2 RID: 185810 RVA: 0x00CB3C49 File Offset: 0x00CB1E49
		public void SetAddText(int add)
		{
			base.GetText(1).SetText(add.ToString(), true);
		}

		// Token: 0x0602D5D3 RID: 185811 RVA: 0x00CB3C5F File Offset: 0x00CB1E5F
		public void SetLastText(int last)
		{
			base.GetText(2).SetText(last.ToString(), true);
		}

		// Token: 0x0602D5D4 RID: 185812 RVA: 0x00CB3C75 File Offset: 0x00CB1E75
		public void SetSumText(int sum)
		{
			base.GetText(3).SetText(sum.ToString(), true);
		}

		// Token: 0x0200A28A RID: 41610
		private class EExpItemDefine
		{
			// Token: 0x0403270D RID: 206605
			public const int ExpSprite = 0;

			// Token: 0x0403270E RID: 206606
			public const int AddText = 1;

			// Token: 0x0403270F RID: 206607
			public const int LastText = 2;

			// Token: 0x04032710 RID: 206608
			public const int SumText = 3;
		}
	}
}
