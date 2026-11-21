using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005735 RID: 22325
	internal class DangoBrawlBackpackShopRateItem : UiPanelBase
	{
		// Token: 0x06036F1D RID: 225053 RVA: 0x00F53B50 File Offset: 0x00F51D50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036F1E RID: 225054 RVA: 0x00F53BB9 File Offset: 0x00F51DB9
		[NullableContext(1)]
		public void Refresh(float rate, string title)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DangoBrawlBattleUIText_051", new <>z__ReadOnlySingleElementList<object>(rate.ToString()));
		}

		// Token: 0x0200B2CF RID: 45775
		private enum EComponents
		{
			// Token: 0x040373D8 RID: 226264
			TxtName,
			// Token: 0x040373D9 RID: 226265
			TxtRate
		}
	}
}
