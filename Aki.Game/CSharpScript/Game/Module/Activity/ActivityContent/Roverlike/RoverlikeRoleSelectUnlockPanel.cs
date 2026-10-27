using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200617C RID: 24956
	public class RoverlikeRoleSelectUnlockPanel : UiPanelBase
	{
		// Token: 0x0603F13A RID: 258362 RVA: 0x00F3E290 File Offset: 0x00F3C490
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickFunction));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F13B RID: 258363 RVA: 0x00F3E357 File Offset: 0x00F3C557
		[NullableContext(1)]
		public void SetFunctionCallback(Action callback)
		{
			this.FunctionCallback = callback;
		}

		// Token: 0x0603F13C RID: 258364 RVA: 0x00F3E360 File Offset: 0x00F3C560
		public void SetFunctionButtonActive(bool active)
		{
			UUIButtonComponent button = base.GetButton(2);
			AUIBaseActor auibaseActor = ((button != null) ? button.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor == null)
			{
				return;
			}
			UUIItem uiitem = auibaseActor.GetUIItem();
			if (uiitem == null)
			{
				return;
			}
			uiitem.SetUIActive(active);
		}

		// Token: 0x0603F13D RID: 258365 RVA: 0x00F3E390 File Offset: 0x00F3C590
		[NullableContext(1)]
		public void RefreshUnlockDesc(string textId)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(textId))
			{
				LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
				return;
			}
			text.SetText("", true);
		}

		// Token: 0x0603F13E RID: 258366 RVA: 0x00F3E3CF File Offset: 0x00F3C5CF
		private void OnClickFunction()
		{
			Action functionCallback = this.FunctionCallback;
			if (functionCallback == null)
			{
				return;
			}
			functionCallback();
		}

		// Token: 0x04020E45 RID: 134725
		[Nullable(2)]
		private Action FunctionCallback;

		// Token: 0x0200C3E7 RID: 50151
		private class EComponents
		{
			// Token: 0x0403B1D2 RID: 242130
			public const int SprLock = 0;

			// Token: 0x0403B1D3 RID: 242131
			public const int TxtActivated = 1;

			// Token: 0x0403B1D4 RID: 242132
			public const int BtnFunctionA = 2;
		}
	}
}
