using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006114 RID: 24852
	public class RoverlikeRewardButton : UiPanelBase
	{
		// Token: 0x0603ED76 RID: 257398 RVA: 0x00F2D5F4 File Offset: 0x00F2B7F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ED77 RID: 257399 RVA: 0x00F2D6BC File Offset: 0x00F2B8BC
		public void SetProgressNumText(int curNum, int totalNum)
		{
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(curNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603ED78 RID: 257400 RVA: 0x00F2D704 File Offset: 0x00F2B904
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isShow);
			}
		}

		// Token: 0x0603ED79 RID: 257401 RVA: 0x00F2D723 File Offset: 0x00F2B923
		private void OnClickBtn()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x04020D1C RID: 134428
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200C370 RID: 50032
		protected class ERewardBtnComponent
		{
			// Token: 0x0403AFA3 RID: 241571
			public const int RootBtn = 0;

			// Token: 0x0403AFA4 RID: 241572
			public const int TxtNum = 1;

			// Token: 0x0403AFA5 RID: 241573
			public const int RedDot = 2;
		}
	}
}
