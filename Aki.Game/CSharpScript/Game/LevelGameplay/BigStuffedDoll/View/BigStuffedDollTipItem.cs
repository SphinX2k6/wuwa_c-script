using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F56 RID: 28502
	public class BigStuffedDollTipItem : UiPanelBase
	{
		// Token: 0x06045575 RID: 284021 RVA: 0x011288B8 File Offset: 0x01126AB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06045576 RID: 284022 RVA: 0x01128900 File Offset: 0x01126B00
		[NullableContext(1)]
		public void ShowTips(string key, int stayTime)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, key, Array.Empty<object>());
			base.ShowAsync();
			TimerSystem.Instance.Delay(delegate(float _)
			{
				base.HideAsync();
			}, (float)stayTime, null, null, true, 1f);
		}

		// Token: 0x0200CD8D RID: 52621
		private class EViewComponent
		{
			// Token: 0x0403DEFE RID: 253694
			public const int TextTip = 0;
		}
	}
}
