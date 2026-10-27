using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E39 RID: 20025
	public class RogueSelectResultBaseView : UiViewBase
	{
		// Token: 0x060339F6 RID: 211446 RVA: 0x00C14E04 File Offset: 0x00C13004
		[NullableContext(1)]
		public RogueSelectResultBaseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060339F7 RID: 211447 RVA: 0x00C14E10 File Offset: 0x00C13010
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.CloseBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.TabBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060339F8 RID: 211448 RVA: 0x00C14F40 File Offset: 0x00C13140
		protected override void OnStart()
		{
			EToggleState state = (RoguelikeModel.Instance.GetDescModel() == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, true, false, false);
		}

		// Token: 0x060339F9 RID: 211449 RVA: 0x00C14F74 File Offset: 0x00C13174
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x060339FA RID: 211450 RVA: 0x00C14F93 File Offset: 0x00C13193
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x060339FB RID: 211451 RVA: 0x00C14FB2 File Offset: 0x00C131B2
		protected virtual void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x060339FC RID: 211452 RVA: 0x00C14FBA File Offset: 0x00C131BA
		protected virtual void Refresh()
		{
		}

		// Token: 0x060339FD RID: 211453 RVA: 0x00C14FBC File Offset: 0x00C131BC
		protected virtual void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060339FE RID: 211454 RVA: 0x00C14FC5 File Offset: 0x00C131C5
		protected virtual void CloseBtn()
		{
			this.OnCloseBtnClick();
		}

		// Token: 0x060339FF RID: 211455 RVA: 0x00C14FCD File Offset: 0x00C131CD
		protected virtual void TabBtn(EToggleState state)
		{
			RoguelikeModel.Instance.UpdateDescModel(state == EToggleState.ETT_Checked);
		}
	}
}
