using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B1E RID: 23326
	public class ExpItem : UiPanelBase
	{
		// Token: 0x0603B0C5 RID: 241861 RVA: 0x00E13FC6 File Offset: 0x00E121C6
		[NullableContext(1)]
		public ExpItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B0C6 RID: 241862 RVA: 0x00E13FDC File Offset: 0x00E121DC
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

		// Token: 0x0603B0C7 RID: 241863 RVA: 0x00E14088 File Offset: 0x00E12288
		public void SetExpSprite(int last, int sum)
		{
			double num = MathUtils.Instance.GetFloatPointFloor((double)last / (double)sum, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(0).SetFillAmount((float)num);
		}

		// Token: 0x0603B0C8 RID: 241864 RVA: 0x00E140CD File Offset: 0x00E122CD
		public void SetAddText(int add)
		{
			base.GetText(1).SetText(add.ToString(), true);
		}

		// Token: 0x0603B0C9 RID: 241865 RVA: 0x00E140E3 File Offset: 0x00E122E3
		public void SetLastText(int last)
		{
			base.GetText(2).SetText(last.ToString(), true);
		}

		// Token: 0x0603B0CA RID: 241866 RVA: 0x00E140F9 File Offset: 0x00E122F9
		public void SetSumText(int sum)
		{
			base.GetText(3).SetText(sum.ToString(), true);
		}

		// Token: 0x0200BD56 RID: 48470
		private enum EExpItemDefine
		{
			// Token: 0x040391B3 RID: 233907
			ExpSprite,
			// Token: 0x040391B4 RID: 233908
			AddText,
			// Token: 0x040391B5 RID: 233909
			LastText,
			// Token: 0x040391B6 RID: 233910
			SumText
		}
	}
}
