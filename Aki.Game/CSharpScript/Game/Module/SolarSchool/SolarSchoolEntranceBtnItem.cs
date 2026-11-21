using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A1A RID: 23066
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolEntranceBtnItem : UiPanelBase
	{
		// Token: 0x06038CE6 RID: 232678 RVA: 0x00FE6C9C File Offset: 0x00FE4E9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038CE7 RID: 232679 RVA: 0x00FE6D84 File Offset: 0x00FE4F84
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06038CE8 RID: 232680 RVA: 0x00FE6D8D File Offset: 0x00FE4F8D
		public void SetEnable(bool enable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetEnable(enable);
		}

		// Token: 0x06038CE9 RID: 232681 RVA: 0x00FE6DA1 File Offset: 0x00FE4FA1
		public void SetRedDotVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06038CEA RID: 232682 RVA: 0x00FE6DB5 File Offset: 0x00FE4FB5
		public void SetTimeTextVisible(bool bVisible)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(bVisible);
		}

		// Token: 0x06038CEB RID: 232683 RVA: 0x00FE6DC9 File Offset: 0x00FE4FC9
		public void SetNumText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06038CEC RID: 232684 RVA: 0x00FE6DDE File Offset: 0x00FE4FDE
		public void SetTimeText(string text)
		{
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06038CED RID: 232685 RVA: 0x00FE6DF3 File Offset: 0x00FE4FF3
		private void OnBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401DE6A RID: 122474
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x0200B5DC RID: 46556
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040383D9 RID: 230361
			public const int Btn = 0;

			// Token: 0x040383DA RID: 230362
			public const int NumText = 1;

			// Token: 0x040383DB RID: 230363
			public const int RedDotItem = 2;

			// Token: 0x040383DC RID: 230364
			public const int TimeTipsItem = 3;

			// Token: 0x040383DD RID: 230365
			public const int TimeText = 4;
		}
	}
}
