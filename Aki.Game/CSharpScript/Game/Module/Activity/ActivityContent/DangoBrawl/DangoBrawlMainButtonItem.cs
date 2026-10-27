using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006823 RID: 26659
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMainButtonItem : UiPanelBase
	{
		// Token: 0x06042865 RID: 272485 RVA: 0x0102A750 File Offset: 0x01028950
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

		// Token: 0x06042866 RID: 272486 RVA: 0x0102A817 File Offset: 0x01028A17
		public void SetOnClick(Action onClick)
		{
			this.OnClickInternal = onClick;
		}

		// Token: 0x06042867 RID: 272487 RVA: 0x0102A820 File Offset: 0x01028A20
		public void SetProgressText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06042868 RID: 272488 RVA: 0x0102A835 File Offset: 0x01028A35
		public void SetProgressText(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x06042869 RID: 272489 RVA: 0x0102A84A File Offset: 0x01028A4A
		public void SetRedDotVisible(bool value)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(value);
		}

		// Token: 0x0604286A RID: 272490 RVA: 0x0102A85E File Offset: 0x01028A5E
		public void BindRedDot(object _, int? __ = null)
		{
		}

		// Token: 0x0604286B RID: 272491 RVA: 0x0102A860 File Offset: 0x01028A60
		public void UnBindRedDot()
		{
		}

		// Token: 0x0604286C RID: 272492 RVA: 0x0102A862 File Offset: 0x01028A62
		private void OnClick()
		{
			this.OnClickInternal();
		}

		// Token: 0x04022A9D RID: 141981
		private Action OnClickInternal = delegate()
		{
		};

		// Token: 0x0200C9C0 RID: 51648
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x0403CF33 RID: 249651
			TxtProgress,
			// Token: 0x0403CF34 RID: 249652
			RedDot,
			// Token: 0x0403CF35 RID: 249653
			Btn
		}
	}
}
