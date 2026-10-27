using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DCF RID: 19919
	internal class RoguelikeBossChallengePagePointItem : GridProxyAbstract<bool>
	{
		// Token: 0x06033688 RID: 210568 RVA: 0x00C00AA8 File Offset: 0x00BFECA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033689 RID: 210569 RVA: 0x00C00AF0 File Offset: 0x00BFECF0
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.OnDeselected(false);
		}

		// Token: 0x0603368A RID: 210570 RVA: 0x00C00AF9 File Offset: 0x00BFECF9
		public override void OnSelected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(true);
		}

		// Token: 0x0603368B RID: 210571 RVA: 0x00C00B08 File Offset: 0x00BFED08
		public override void OnDeselected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(false);
		}

		// Token: 0x0200AF46 RID: 44870
		private class EPagePointComponents
		{
			// Token: 0x04035384 RID: 217988
			public const int PnlDot = 0;
		}
	}
}
