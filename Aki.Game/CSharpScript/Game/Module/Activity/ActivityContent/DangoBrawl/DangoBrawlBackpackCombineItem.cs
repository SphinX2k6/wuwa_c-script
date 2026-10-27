using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067E1 RID: 26593
	public class DangoBrawlBackpackCombineItem : GridProxyAbstract<DangoBrawlCombineRowData>
	{
		// Token: 0x06042394 RID: 271252 RVA: 0x010115E4 File Offset: 0x0100F7E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCombine));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042395 RID: 271253 RVA: 0x0101168A File Offset: 0x0100F88A
		public override void Refresh(DangoBrawlCombineRowData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x06042396 RID: 271254 RVA: 0x0101168C File Offset: 0x0100F88C
		private void OnClickCombine()
		{
		}

		// Token: 0x0200C8F5 RID: 51445
		private enum EComponents
		{
			// Token: 0x0403CAAC RID: 248492
			BtnCombine,
			// Token: 0x0403CAAD RID: 248493
			TextureCombine
		}
	}
}
