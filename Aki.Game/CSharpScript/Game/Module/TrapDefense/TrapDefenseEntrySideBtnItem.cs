using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A36 RID: 14902
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseEntrySideBtnItem : UiPanelBase
	{
		// Token: 0x06026518 RID: 156952 RVA: 0x00ABB8A0 File Offset: 0x00AB9AA0
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

		// Token: 0x06026519 RID: 156953 RVA: 0x00ABB988 File Offset: 0x00AB9B88
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602651A RID: 156954 RVA: 0x00ABB990 File Offset: 0x00AB9B90
		private void ButtonClick()
		{
			if (this.ButtonFunction != null)
			{
				this.ButtonFunction();
			}
		}

		// Token: 0x0602651B RID: 156955 RVA: 0x00ABB9A8 File Offset: 0x00AB9BA8
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x0602651C RID: 156956 RVA: 0x00ABB9C8 File Offset: 0x00AB9BC8
		public void SetProgressText(string text)
		{
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x0602651D RID: 156957 RVA: 0x00ABB9E8 File Offset: 0x00AB9BE8
		public void SetProgressTextWithLabel(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
		}

		// Token: 0x0602651E RID: 156958 RVA: 0x00ABB9FD File Offset: 0x00AB9BFD
		public void SetLocalTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0602651F RID: 156959 RVA: 0x00ABBA12 File Offset: 0x00AB9C12
		public void TrySetLocalTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06026520 RID: 156960 RVA: 0x00ABBA27 File Offset: 0x00AB9C27
		public void SetShowText(string text)
		{
			base.GetText(1).ShowTextNew(text);
		}

		// Token: 0x06026521 RID: 156961 RVA: 0x00ABBA36 File Offset: 0x00AB9C36
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x06026522 RID: 156962 RVA: 0x00ABBA4A File Offset: 0x00AB9C4A
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06026523 RID: 156963 RVA: 0x00ABBA53 File Offset: 0x00AB9C53
		public void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x06026524 RID: 156964 RVA: 0x00ABBA64 File Offset: 0x00AB9C64
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

		// Token: 0x06026525 RID: 156965 RVA: 0x00ABBAAA File Offset: 0x00AB9CAA
		public void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), 0);
				this.RedDotName = null;
			}
		}

		// Token: 0x04015091 RID: 86161
		private ERedDotName? RedDotName;

		// Token: 0x04015092 RID: 86162
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x020095FF RID: 38399
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402ED63 RID: 191843
			public const int Button = 0;

			// Token: 0x0402ED64 RID: 191844
			public const int ButtonText = 1;

			// Token: 0x0402ED65 RID: 191845
			public const int RedDot = 2;

			// Token: 0x0402ED66 RID: 191846
			public const int TextProgress = 3;
		}
	}
}
