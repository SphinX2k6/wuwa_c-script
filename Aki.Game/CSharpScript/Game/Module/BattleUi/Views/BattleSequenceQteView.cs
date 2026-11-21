using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CBF RID: 19647
	public class BattleSequenceQteView : UiViewBase
	{
		// Token: 0x060311DC RID: 201180 RVA: 0x00DB6EBB File Offset: 0x00DB50BB
		[NullableContext(1)]
		public BattleSequenceQteView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060311DD RID: 201181 RVA: 0x00DB6EC4 File Offset: 0x00DB50C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedQteButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060311DE RID: 201182 RVA: 0x00DB6F49 File Offset: 0x00DB5149
		private void OnClickedQteButton()
		{
		}

		// Token: 0x060311DF RID: 201183 RVA: 0x00DB6F4B File Offset: 0x00DB514B
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequencePurely("Huxi", false, false);
		}

		// Token: 0x0200A93A RID: 43322
		private enum EChildCom
		{
			// Token: 0x0403448C RID: 214156
			BtnQte
		}
	}
}
