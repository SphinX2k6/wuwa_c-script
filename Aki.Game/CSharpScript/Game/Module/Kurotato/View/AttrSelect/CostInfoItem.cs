using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004757 RID: 18263
	internal class CostInfoItem : UiPanelBase
	{
		// Token: 0x0602DD88 RID: 187784 RVA: 0x00CD4DD4 File Offset: 0x00CD2FD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickTitle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DD89 RID: 187785 RVA: 0x00CD4E7A File Offset: 0x00CD307A
		private void OnClickTitle()
		{
			Action onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb();
		}

		// Token: 0x0602DD8A RID: 187786 RVA: 0x00CD4E8C File Offset: 0x00CD308C
		[NullableContext(1)]
		public void SetOnClickCb(Action cb)
		{
			this.OnClickCb = cb;
		}

		// Token: 0x040187EE RID: 100334
		[Nullable(2)]
		private Action OnClickCb;

		// Token: 0x0200A3B8 RID: 41912
		private class ECostItemComp
		{
			// Token: 0x04032BFE RID: 207870
			public const int BtnTitle = 0;

			// Token: 0x04032BFF RID: 207871
			public const int TextNum = 1;
		}
	}
}
