using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006306 RID: 25350
	public class PinballRoleAttributeTabItem : UiPanelBase
	{
		// Token: 0x0603FC88 RID: 261256 RVA: 0x00F6E6E4 File Offset: 0x00F6C8E4
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(delegate(EToggleState _)
			{
				this.OnSelectedInternal();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FC89 RID: 261257 RVA: 0x00F6E78A File Offset: 0x00F6C98A
		[NullableContext(1)]
		public void Refresh(IPinballRoleAttributeTabItemData data)
		{
			this.Data = data;
			this.OnSelectedDelegate = data.OnSelectedDelegate;
			this.RefreshSelectState(true);
		}

		// Token: 0x0603FC8A RID: 261258 RVA: 0x00F6E7A8 File Offset: 0x00F6C9A8
		public void RefreshSelectState(bool bJumpToLastFrame)
		{
			IPinballRoleAttributeTabItemData data = this.Data;
			EToggleState state = (data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, bJumpToLastFrame);
		}

		// Token: 0x0603FC8B RID: 261259 RVA: 0x00F6E7E4 File Offset: 0x00F6C9E4
		private void OnSelectedInternal()
		{
			IPinballRoleAttributeTabItemData data = this.Data;
			EPinballRoleAttributeTabIndex? epinballRoleAttributeTabIndex = (data != null) ? new EPinballRoleAttributeTabIndex?(data.TabIndex) : null;
			if (epinballRoleAttributeTabIndex == null)
			{
				return;
			}
			Action<EPinballRoleAttributeTabIndex> onSelectedDelegate = this.OnSelectedDelegate;
			if (onSelectedDelegate == null)
			{
				return;
			}
			onSelectedDelegate(epinballRoleAttributeTabIndex.Value);
		}

		// Token: 0x040214A7 RID: 136359
		[Nullable(2)]
		protected IPinballRoleAttributeTabItemData Data;

		// Token: 0x040214A8 RID: 136360
		[Nullable(2)]
		public Action<EPinballRoleAttributeTabIndex> OnSelectedDelegate;

		// Token: 0x0200C4FB RID: 50427
		private enum EComponent
		{
			// Token: 0x0403B723 RID: 243491
			ItemToggle,
			// Token: 0x0403B724 RID: 243492
			NameText
		}
	}
}
