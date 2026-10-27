using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200569E RID: 22174
	public class ExpItem : UiPanelBase
	{
		// Token: 0x060386D2 RID: 231122 RVA: 0x00D659F2 File Offset: 0x00D63BF2
		[NullableContext(1)]
		public ExpItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060386D3 RID: 231123 RVA: 0x00D65A08 File Offset: 0x00D63C08
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

		// Token: 0x060386D4 RID: 231124 RVA: 0x00D65AB4 File Offset: 0x00D63CB4
		public void SetExpSprite(int last, int sum)
		{
			double num = MathUtils.Instance.GetFloatPointFloor((double)last / (double)sum, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(0).SetFillAmount((float)num);
		}

		// Token: 0x060386D5 RID: 231125 RVA: 0x00D65AF9 File Offset: 0x00D63CF9
		public void SetAddText(int add)
		{
			base.GetText(1).SetText(add.ToString(), true);
		}

		// Token: 0x060386D6 RID: 231126 RVA: 0x00D65B0F File Offset: 0x00D63D0F
		public void SetLastText(int last)
		{
			base.GetText(2).SetText(last.ToString(), true);
		}

		// Token: 0x060386D7 RID: 231127 RVA: 0x00D65B25 File Offset: 0x00D63D25
		public void SetSumText(int sum)
		{
			base.GetText(3).SetText(sum.ToString(), true);
		}

		// Token: 0x0200B862 RID: 47202
		private class EExpItemDefine
		{
			// Token: 0x04037CF0 RID: 228592
			public const int ExpSprite = 0;

			// Token: 0x04037CF1 RID: 228593
			public const int AddText = 1;

			// Token: 0x04037CF2 RID: 228594
			public const int LastText = 2;

			// Token: 0x04037CF3 RID: 228595
			public const int SumText = 3;
		}
	}
}
