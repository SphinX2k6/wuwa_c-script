using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F6 RID: 21238
	public class PinballBattleRoleDetailTabItem : GridProxyAbstract<EPinballBattleRoleDetailTabType>
	{
		// Token: 0x06034D92 RID: 216466 RVA: 0x00EC67D0 File Offset: 0x00EC49D0
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

		// Token: 0x06034D93 RID: 216467 RVA: 0x00EC6878 File Offset: 0x00EC4A78
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

		// Token: 0x06034D94 RID: 216468 RVA: 0x00EC68CF File Offset: 0x00EC4ACF
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

		// Token: 0x06034D95 RID: 216469 RVA: 0x00EC68F2 File Offset: 0x00EC4AF2
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

		// Token: 0x06034D96 RID: 216470 RVA: 0x00EC6921 File Offset: 0x00EC4B21
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401BF42 RID: 114498
		private EPinballBattleRoleDetailTabType Data;

		// Token: 0x0401BF43 RID: 114499
		[Nullable(2)]
		public Action<EPinballBattleRoleDetailTabType> OnSelectCallBack;

		// Token: 0x0200AF7A RID: 44922
		private enum EPinballBattleRoleDetailTabItemComp
		{
			// Token: 0x040363AD RID: 222125
			Toggle,
			// Token: 0x040363AE RID: 222126
			Name
		}
	}
}
