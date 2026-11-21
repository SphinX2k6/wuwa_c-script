using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005505 RID: 21765
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingRewardTargetTabItem : GridProxyAbstract<FishingRewardTargetTabData>
	{
		// Token: 0x06035EF9 RID: 220921 RVA: 0x00F10378 File Offset: 0x00F0E578
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

		// Token: 0x06035EFA RID: 220922 RVA: 0x00F10440 File Offset: 0x00F0E640
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

		// Token: 0x06035EFB RID: 220923 RVA: 0x00F1046B File Offset: 0x00F0E66B
		private void SetRedDotVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06035EFC RID: 220924 RVA: 0x00F10480 File Offset: 0x00F0E680
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

		// Token: 0x06035EFD RID: 220925 RVA: 0x00F104D8 File Offset: 0x00F0E6D8
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

		// Token: 0x06035EFE RID: 220926 RVA: 0x00F10518 File Offset: 0x00F0E718
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

		// Token: 0x0401C820 RID: 116768
		[Nullable(2)]
		private FishingRewardTargetTabData TabData;

		// Token: 0x0401C821 RID: 116769
		private int TabIndex = -1;

		// Token: 0x0200B164 RID: 45412
		private class EComponentDefine
		{
			// Token: 0x04036DAD RID: 224685
			public const int Name = 0;

			// Token: 0x04036DAE RID: 224686
			public const int Toggle = 1;

			// Token: 0x04036DAF RID: 224687
			public const int RedDot = 2;
		}
	}
}
