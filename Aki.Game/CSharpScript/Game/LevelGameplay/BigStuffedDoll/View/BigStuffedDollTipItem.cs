using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060D7 RID: 24791
	public class BigStuffedDollTipItem : UiPanelBase
	{
		// Token: 0x0603B723 RID: 243491 RVA: 0x010D2698 File Offset: 0x010D0898
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

		// Token: 0x0603B724 RID: 243492 RVA: 0x010D26E0 File Offset: 0x010D08E0
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

		// Token: 0x0200B97F RID: 47487
		private class EViewComponent
		{
			// Token: 0x0403932D RID: 234285
			public const int TextTip = 0;
		}
	}
}
