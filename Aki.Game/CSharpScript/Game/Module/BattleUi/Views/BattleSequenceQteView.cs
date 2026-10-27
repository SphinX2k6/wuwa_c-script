using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CDD RID: 23773
	public class BattleSequenceQteView : UiViewBase
	{
		// Token: 0x0603C286 RID: 246406 RVA: 0x00E66907 File Offset: 0x00E64B07
		[NullableContext(1)]
		public BattleSequenceQteView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603C287 RID: 246407 RVA: 0x00E66910 File Offset: 0x00E64B10
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

		// Token: 0x0603C288 RID: 246408 RVA: 0x00E66995 File Offset: 0x00E64B95
		private void OnClickedQteButton()
		{
		}

		// Token: 0x0603C289 RID: 246409 RVA: 0x00E66997 File Offset: 0x00E64B97
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequencePurely("Huxi", false, false);
		}

		// Token: 0x0200BF34 RID: 48948
		private enum EChildCom
		{
			// Token: 0x04039ACA RID: 236234
			BtnQte
		}
	}
}
