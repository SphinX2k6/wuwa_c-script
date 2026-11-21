using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AFF RID: 19199
	public class ExpItem : UiPanelBase
	{
		// Token: 0x06030037 RID: 196663 RVA: 0x00D64CDF File Offset: 0x00D62EDF
		[NullableContext(1)]
		public ExpItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030038 RID: 196664 RVA: 0x00D64CF4 File Offset: 0x00D62EF4
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

		// Token: 0x06030039 RID: 196665 RVA: 0x00D64DA0 File Offset: 0x00D62FA0
		public void SetExpSprite(int last, int sum)
		{
			double num = MathUtils.Instance.GetFloatPointFloor((double)last / (double)sum, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(0).SetFillAmount((float)num);
		}

		// Token: 0x0603003A RID: 196666 RVA: 0x00D64DE5 File Offset: 0x00D62FE5
		public void SetAddText(int add)
		{
			base.GetText(1).SetText(add.ToString(), true);
		}

		// Token: 0x0603003B RID: 196667 RVA: 0x00D64DFB File Offset: 0x00D62FFB
		public void SetLastText(int last)
		{
			base.GetText(2).SetText(last.ToString(), true);
		}

		// Token: 0x0603003C RID: 196668 RVA: 0x00D64E11 File Offset: 0x00D63011
		public void SetSumText(int sum)
		{
			base.GetText(3).SetText(sum.ToString(), true);
		}

		// Token: 0x0200A75F RID: 42847
		private enum EExpItemDefine
		{
			// Token: 0x04033B7F RID: 211839
			ExpSprite,
			// Token: 0x04033B80 RID: 211840
			AddText,
			// Token: 0x04033B81 RID: 211841
			LastText,
			// Token: 0x04033B82 RID: 211842
			SumText
		}
	}
}
