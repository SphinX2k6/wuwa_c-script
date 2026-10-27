using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x02006378 RID: 25464
	public class PinballBattleRoleDetailTabItem : GridProxyAbstract<EPinballBattleRoleDetailTabType>
	{
		// Token: 0x060400D1 RID: 262353 RVA: 0x00F7F86C File Offset: 0x00F7DA6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060400D2 RID: 262354 RVA: 0x00F7F914 File Offset: 0x00F7DB14
		public override void Refresh(EPinballBattleRoleDetailTabType data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			string textStringId = null;
			switch (data)
			{
			case EPinballBattleRoleDetailTabType.Buff:
				textStringId = "Pinaball_inside_State";
				break;
			case EPinballBattleRoleDetailTabType.Attr:
				textStringId = "Pinaball_inside_Attribute";
				break;
			case EPinballBattleRoleDetailTabType.Skill:
				textStringId = "Pinaball_inside_Skill";
				break;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x060400D3 RID: 262355 RVA: 0x00F7F96B File Offset: 0x00F7DB6B
		private void OnToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				IScrollViewDelegate<IGridProxy<EPinballBattleRoleDetailTabType>, EPinballBattleRoleDetailTabType> scrollViewDelegate = base.ScrollViewDelegate;
				if (scrollViewDelegate == null)
				{
					return;
				}
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, true);
			}
		}

		// Token: 0x060400D4 RID: 262356 RVA: 0x00F7F98E File Offset: 0x00F7DB8E
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
			}
			Action<EPinballBattleRoleDetailTabType> onSelectCallBack = this.OnSelectCallBack;
			if (onSelectCallBack == null)
			{
				return;
			}
			onSelectCallBack(this.Data);
		}

		// Token: 0x060400D5 RID: 262357 RVA: 0x00F7F9BD File Offset: 0x00F7DBBD
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04021613 RID: 136723
		private EPinballBattleRoleDetailTabType Data;

		// Token: 0x04021614 RID: 136724
		[Nullable(2)]
		public Action<EPinballBattleRoleDetailTabType> OnSelectCallBack;

		// Token: 0x0200C593 RID: 50579
		private enum EPinballBattleRoleDetailTabItemComp
		{
			// Token: 0x0403BA4B RID: 244299
			Toggle,
			// Token: 0x0403BA4C RID: 244300
			Name
		}
	}
}
