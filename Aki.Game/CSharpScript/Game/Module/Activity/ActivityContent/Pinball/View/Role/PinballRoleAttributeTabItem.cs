using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005284 RID: 21124
	public class PinballRoleAttributeTabItem : UiPanelBase
	{
		// Token: 0x06034949 RID: 215369 RVA: 0x00EB5640 File Offset: 0x00EB3840
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

		// Token: 0x0603494A RID: 215370 RVA: 0x00EB56E6 File Offset: 0x00EB38E6
		[NullableContext(1)]
		public void Refresh(IPinballRoleAttributeTabItemData data)
		{
			this.Data = data;
			this.OnSelectedDelegate = data.OnSelectedDelegate;
			this.RefreshSelectState(true);
		}

		// Token: 0x0603494B RID: 215371 RVA: 0x00EB5704 File Offset: 0x00EB3904
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

		// Token: 0x0603494C RID: 215372 RVA: 0x00EB5740 File Offset: 0x00EB3940
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

		// Token: 0x0401BDD6 RID: 114134
		[Nullable(2)]
		protected IPinballRoleAttributeTabItemData Data;

		// Token: 0x0401BDD7 RID: 114135
		[Nullable(2)]
		public Action<EPinballRoleAttributeTabIndex> OnSelectedDelegate;

		// Token: 0x0200AEE2 RID: 44770
		private enum EComponent
		{
			// Token: 0x04036085 RID: 221317
			ItemToggle,
			// Token: 0x04036086 RID: 221318
			NameText
		}
	}
}
