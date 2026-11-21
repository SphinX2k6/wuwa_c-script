using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050FA RID: 20730
	public class RoverlikeRoleSelectUnlockPanel : UiPanelBase
	{
		// Token: 0x06033DFA RID: 212474 RVA: 0x00E85158 File Offset: 0x00E83358
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

		// Token: 0x06033DFB RID: 212475 RVA: 0x00E8521F File Offset: 0x00E8341F
		[NullableContext(1)]
		public void SetFunctionCallback(Action callback)
		{
			this.FunctionCallback = callback;
		}

		// Token: 0x06033DFC RID: 212476 RVA: 0x00E85228 File Offset: 0x00E83428
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

		// Token: 0x06033DFD RID: 212477 RVA: 0x00E85258 File Offset: 0x00E83458
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

		// Token: 0x06033DFE RID: 212478 RVA: 0x00E85297 File Offset: 0x00E83497
		private void OnClickFunction()
		{
			Action functionCallback = this.FunctionCallback;
			if (functionCallback == null)
			{
				return;
			}
			functionCallback();
		}

		// Token: 0x0401B772 RID: 112498
		[Nullable(2)]
		private Action FunctionCallback;

		// Token: 0x0200ADCE RID: 44494
		private class EComponents
		{
			// Token: 0x04035B33 RID: 219955
			public const int SprLock = 0;

			// Token: 0x04035B34 RID: 219956
			public const int TxtActivated = 1;

			// Token: 0x04035B35 RID: 219957
			public const int BtnFunctionA = 2;
		}
	}
}
