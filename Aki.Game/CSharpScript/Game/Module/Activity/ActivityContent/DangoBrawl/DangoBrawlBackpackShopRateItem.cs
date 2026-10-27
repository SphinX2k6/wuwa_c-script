using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067E5 RID: 26597
	internal class DangoBrawlBackpackShopRateItem : UiPanelBase
	{
		// Token: 0x060423C7 RID: 271303 RVA: 0x010126B8 File Offset: 0x010108B8
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

		// Token: 0x060423C8 RID: 271304 RVA: 0x01012721 File Offset: 0x01010921
		[NullableContext(1)]
		public void Refresh(float rate, string title)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DangoBrawlBattleUIText_051", new <>z__ReadOnlySingleElementList<object>(rate.ToString()));
		}

		// Token: 0x0200C8FF RID: 51455
		private enum EComponents
		{
			// Token: 0x0403CAE3 RID: 248547
			TxtName,
			// Token: 0x0403CAE4 RID: 248548
			TxtRate
		}
	}
}
