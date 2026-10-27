using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Rewards
{
	// Token: 0x02006849 RID: 26697
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DangoBrawlRewardTabItem : GridProxyAbstract<DangoBrawlRewardTabData>
	{
		// Token: 0x06042A42 RID: 272962 RVA: 0x0103456C File Offset: 0x0103276C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042A43 RID: 272963 RVA: 0x01034633 File Offset: 0x01032833
		public override void Refresh(DangoBrawlRewardTabData data, bool isSelected, int gridIndex)
		{
			this.TabIndex = gridIndex;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			this.SetRedDotVisible(data.CanReceive);
		}

		// Token: 0x06042A44 RID: 272964 RVA: 0x01034664 File Offset: 0x01032864
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06042A45 RID: 272965 RVA: 0x01034678 File Offset: 0x01032878
		private void OnClickToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				this.SetToggleSelect(true, false);
				return;
			}
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x06042A46 RID: 272966 RVA: 0x0103469D File Offset: 0x0103289D
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x06042A47 RID: 272967 RVA: 0x010346A6 File Offset: 0x010328A6
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x06042A48 RID: 272968 RVA: 0x010346B0 File Offset: 0x010328B0
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04022B4D RID: 142157
		private int TabIndex = -1;

		// Token: 0x04022B4E RID: 142158
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;

		// Token: 0x0200CA11 RID: 51729
		[NullableContext(0)]
		private enum ETab
		{
			// Token: 0x0403D108 RID: 250120
			Toggle,
			// Token: 0x0403D109 RID: 250121
			Name,
			// Token: 0x0403D10A RID: 250122
			RedPoint
		}
	}
}
