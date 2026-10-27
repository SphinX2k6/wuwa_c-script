using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02005780 RID: 22400
	internal class CostInfoItem : UiPanelBase
	{
		// Token: 0x06038E78 RID: 233080 RVA: 0x00D86114 File Offset: 0x00D84314
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

		// Token: 0x06038E79 RID: 233081 RVA: 0x00D861BA File Offset: 0x00D843BA
		private void OnClickTitle()
		{
			Action onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb();
		}

		// Token: 0x06038E7A RID: 233082 RVA: 0x00D861CC File Offset: 0x00D843CC
		[NullableContext(1)]
		public void SetOnClickCb(Action cb)
		{
			this.OnClickCb = cb;
		}

		// Token: 0x0401DD58 RID: 122200
		[Nullable(2)]
		private Action OnClickCb;

		// Token: 0x0200B9A0 RID: 47520
		private class ECostItemComp
		{
			// Token: 0x04038209 RID: 229897
			public const int BtnTitle = 0;

			// Token: 0x0403820A RID: 229898
			public const int TextNum = 1;
		}
	}
}
