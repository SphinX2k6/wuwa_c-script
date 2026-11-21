using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Rewards
{
	// Token: 0x02005799 RID: 22425
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DangoBrawlRewardTabItem : GridProxyAbstract<DangoBrawlRewardTabData>
	{
		// Token: 0x06037597 RID: 226711 RVA: 0x00F75A94 File Offset: 0x00F73C94
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

		// Token: 0x06037598 RID: 226712 RVA: 0x00F75B5B File Offset: 0x00F73D5B
		public override void Refresh(DangoBrawlRewardTabData data, bool isSelected, int gridIndex)
		{
			this.TabIndex = gridIndex;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			this.SetRedDotVisible(data.CanReceive);
		}

		// Token: 0x06037599 RID: 226713 RVA: 0x00F75B8C File Offset: 0x00F73D8C
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0603759A RID: 226714 RVA: 0x00F75BA0 File Offset: 0x00F73DA0
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

		// Token: 0x0603759B RID: 226715 RVA: 0x00F75BC5 File Offset: 0x00F73DC5
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x0603759C RID: 226716 RVA: 0x00F75BCE File Offset: 0x00F73DCE
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x0603759D RID: 226717 RVA: 0x00F75BD8 File Offset: 0x00F73DD8
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401D3AA RID: 119722
		private int TabIndex = -1;

		// Token: 0x0401D3AB RID: 119723
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;

		// Token: 0x0200B3DC RID: 46044
		[NullableContext(0)]
		private enum ETab
		{
			// Token: 0x040379EF RID: 227823
			Toggle,
			// Token: 0x040379F0 RID: 227824
			Name,
			// Token: 0x040379F1 RID: 227825
			RedPoint
		}
	}
}
