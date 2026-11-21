using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005731 RID: 22321
	public class DangoBrawlBackpackCombineItem : GridProxyAbstract<DangoBrawlCombineRowData>
	{
		// Token: 0x06036EEA RID: 225002 RVA: 0x00F52A7C File Offset: 0x00F50C7C
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

		// Token: 0x06036EEB RID: 225003 RVA: 0x00F52B22 File Offset: 0x00F50D22
		public override void Refresh(DangoBrawlCombineRowData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x06036EEC RID: 225004 RVA: 0x00F52B24 File Offset: 0x00F50D24
		private void OnClickCombine()
		{
		}

		// Token: 0x0200B2C5 RID: 45765
		private enum EComponents
		{
			// Token: 0x040373A1 RID: 226209
			BtnCombine,
			// Token: 0x040373A2 RID: 226210
			TextureCombine
		}
	}
}
