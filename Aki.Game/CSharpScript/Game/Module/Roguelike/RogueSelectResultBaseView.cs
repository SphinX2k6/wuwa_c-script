using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E02 RID: 15874
	public class RogueSelectResultBaseView : UiViewBase
	{
		// Token: 0x06028861 RID: 165985 RVA: 0x00B5E32C File Offset: 0x00B5C52C
		[NullableContext(1)]
		public RogueSelectResultBaseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028862 RID: 165986 RVA: 0x00B5E338 File Offset: 0x00B5C538
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

		// Token: 0x06028863 RID: 165987 RVA: 0x00B5E468 File Offset: 0x00B5C668
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

		// Token: 0x06028864 RID: 165988 RVA: 0x00B5E49C File Offset: 0x00B5C69C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x06028865 RID: 165989 RVA: 0x00B5E4BB File Offset: 0x00B5C6BB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x06028866 RID: 165990 RVA: 0x00B5E4DA File Offset: 0x00B5C6DA
		protected virtual void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06028867 RID: 165991 RVA: 0x00B5E4E2 File Offset: 0x00B5C6E2
		protected virtual void Refresh()
		{
		}

		// Token: 0x06028868 RID: 165992 RVA: 0x00B5E4E4 File Offset: 0x00B5C6E4
		protected virtual void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06028869 RID: 165993 RVA: 0x00B5E4ED File Offset: 0x00B5C6ED
		protected virtual void CloseBtn()
		{
			this.OnCloseBtnClick();
		}

		// Token: 0x0602886A RID: 165994 RVA: 0x00B5E4F5 File Offset: 0x00B5C6F5
		protected virtual void TabBtn(EToggleState state)
		{
			RoguelikeModel.Instance.UpdateDescModel(state == EToggleState.ETT_Checked);
		}
	}
}
