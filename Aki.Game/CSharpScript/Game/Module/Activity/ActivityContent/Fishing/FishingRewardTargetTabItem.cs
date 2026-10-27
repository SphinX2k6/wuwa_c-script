using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006587 RID: 25991
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingRewardTargetTabItem : GridProxyAbstract<FishingRewardTargetTabData>
	{
		// Token: 0x06041234 RID: 266804 RVA: 0x00FC93C0 File Offset: 0x00FC75C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnTabToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041235 RID: 266805 RVA: 0x00FC9488 File Offset: 0x00FC7688
		public void SetToggleState(bool bSelect, bool bFire)
		{
			EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06041236 RID: 266806 RVA: 0x00FC94B3 File Offset: 0x00FC76B3
		private void SetRedDotVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06041237 RID: 266807 RVA: 0x00FC94C8 File Offset: 0x00FC76C8
		public void RefreshRedDot()
		{
			FishingRewardTargetTabData tabData = this.TabData;
			bool? flag;
			if (tabData == null)
			{
				flag = null;
			}
			else
			{
				Func<int, bool> refreshRedDot = tabData.RefreshRedDot;
				flag = ((refreshRedDot != null) ? new bool?(refreshRedDot(this.TabIndex + 1)) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			this.SetRedDotVisible(valueOrDefault);
		}

		// Token: 0x06041238 RID: 266808 RVA: 0x00FC9520 File Offset: 0x00FC7720
		[NullableContext(1)]
		public override void Refresh(FishingRewardTargetTabData data, bool isSelected, int gridIndex)
		{
			this.TabData = data;
			this.TabIndex = data.Index;
			if (!StringUtils.IsEmpty(data.NameTextId))
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.ShowTextNew(data.NameTextId);
				}
			}
			this.RefreshRedDot();
		}

		// Token: 0x06041239 RID: 266809 RVA: 0x00FC9560 File Offset: 0x00FC7760
		private void OnTabToggle(EToggleState _)
		{
			FishingRewardTargetTabData tabData = this.TabData;
			if (tabData == null)
			{
				return;
			}
			Action<int> clickedCallback = tabData.ClickedCallback;
			if (clickedCallback == null)
			{
				return;
			}
			clickedCallback(this.TabIndex);
		}

		// Token: 0x04021EEF RID: 138991
		[Nullable(2)]
		private FishingRewardTargetTabData TabData;

		// Token: 0x04021EF0 RID: 138992
		private int TabIndex = -1;

		// Token: 0x0200C77F RID: 51071
		private class EComponentDefine
		{
			// Token: 0x0403C45C RID: 246876
			public const int Name = 0;

			// Token: 0x0403C45D RID: 246877
			public const int Toggle = 1;

			// Token: 0x0403C45E RID: 246878
			public const int RedDot = 2;
		}
	}
}
