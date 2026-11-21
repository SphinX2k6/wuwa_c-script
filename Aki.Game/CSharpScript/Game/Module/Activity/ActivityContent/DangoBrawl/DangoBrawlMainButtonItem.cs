using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005773 RID: 22387
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMainButtonItem : UiPanelBase
	{
		// Token: 0x060373B9 RID: 226233 RVA: 0x00F6BC8C File Offset: 0x00F69E8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060373BA RID: 226234 RVA: 0x00F6BD53 File Offset: 0x00F69F53
		public void SetOnClick(Action onClick)
		{
			this.OnClickInternal = onClick;
		}

		// Token: 0x060373BB RID: 226235 RVA: 0x00F6BD5C File Offset: 0x00F69F5C
		public void SetProgressText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060373BC RID: 226236 RVA: 0x00F6BD71 File Offset: 0x00F69F71
		public void SetProgressText(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x060373BD RID: 226237 RVA: 0x00F6BD86 File Offset: 0x00F69F86
		public void SetRedDotVisible(bool value)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(value);
		}

		// Token: 0x060373BE RID: 226238 RVA: 0x00F6BD9A File Offset: 0x00F69F9A
		public void BindRedDot(object _, int? __ = null)
		{
		}

		// Token: 0x060373BF RID: 226239 RVA: 0x00F6BD9C File Offset: 0x00F69F9C
		public void UnBindRedDot()
		{
		}

		// Token: 0x060373C0 RID: 226240 RVA: 0x00F6BD9E File Offset: 0x00F69F9E
		private void OnClick()
		{
			this.OnClickInternal();
		}

		// Token: 0x0401D2FA RID: 119546
		private Action OnClickInternal = delegate()
		{
		};

		// Token: 0x0200B38C RID: 45964
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x0403781D RID: 227357
			TxtProgress,
			// Token: 0x0403781E RID: 227358
			RedDot,
			// Token: 0x0403781F RID: 227359
			Btn
		}
	}
}
