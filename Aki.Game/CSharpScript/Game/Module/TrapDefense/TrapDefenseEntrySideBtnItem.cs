using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A8E RID: 19086
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseEntrySideBtnItem : UiPanelBase
	{
		// Token: 0x06031788 RID: 202632 RVA: 0x00B778EC File Offset: 0x00B75AEC
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031789 RID: 202633 RVA: 0x00B779D4 File Offset: 0x00B75BD4
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0603178A RID: 202634 RVA: 0x00B779DC File Offset: 0x00B75BDC
		private void ButtonClick()
		{
			if (this.ButtonFunction != null)
			{
				this.ButtonFunction();
			}
		}

		// Token: 0x0603178B RID: 202635 RVA: 0x00B779F4 File Offset: 0x00B75BF4
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x0603178C RID: 202636 RVA: 0x00B77A14 File Offset: 0x00B75C14
		public void SetProgressText(string text)
		{
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x0603178D RID: 202637 RVA: 0x00B77A34 File Offset: 0x00B75C34
		public void SetProgressTextWithLabel(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
		}

		// Token: 0x0603178E RID: 202638 RVA: 0x00B77A49 File Offset: 0x00B75C49
		public void SetLocalTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0603178F RID: 202639 RVA: 0x00B77A5E File Offset: 0x00B75C5E
		public void TrySetLocalTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06031790 RID: 202640 RVA: 0x00B77A73 File Offset: 0x00B75C73
		public void SetShowText(string text)
		{
			base.GetText(1).ShowTextNew(text);
		}

		// Token: 0x06031791 RID: 202641 RVA: 0x00B77A82 File Offset: 0x00B75C82
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x06031792 RID: 202642 RVA: 0x00B77A96 File Offset: 0x00B75C96
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06031793 RID: 202643 RVA: 0x00B77A9F File Offset: 0x00B75C9F
		public void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x06031794 RID: 202644 RVA: 0x00B77AB0 File Offset: 0x00B75CB0
		public void BindRedDot(ERedDotName redDotName, int uId = 0)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			this.UnBindRedDot();
			this.RedDotName = new ERedDotName?(redDotName);
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
			}
		}

		// Token: 0x06031795 RID: 202645 RVA: 0x00B77AF6 File Offset: 0x00B75CF6
		public void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), 0);
				this.RedDotName = null;
			}
		}

		// Token: 0x0401A73F RID: 108351
		private ERedDotName? RedDotName;

		// Token: 0x0401A740 RID: 108352
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200ABDF RID: 43999
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040343B2 RID: 213938
			public const int Button = 0;

			// Token: 0x040343B3 RID: 213939
			public const int ButtonText = 1;

			// Token: 0x040343B4 RID: 213940
			public const int RedDot = 2;

			// Token: 0x040343B5 RID: 213941
			public const int TextProgress = 3;
		}
	}
}
