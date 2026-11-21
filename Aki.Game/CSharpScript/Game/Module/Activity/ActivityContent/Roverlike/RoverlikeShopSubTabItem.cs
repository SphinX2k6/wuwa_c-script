using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050F2 RID: 20722
	public class RoverlikeShopSubTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06033DC8 RID: 212424 RVA: 0x00E844A0 File Offset: 0x00E826A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033DC9 RID: 212425 RVA: 0x00E84546 File Offset: 0x00E82746
		public void SetShopId(int shopId)
		{
			this.ShopId = shopId;
		}

		// Token: 0x06033DCA RID: 212426 RVA: 0x00E8454F File Offset: 0x00E8274F
		[NullableContext(1)]
		public void SetOnToggle(Action<int> callback)
		{
			this.OnToggle = callback;
		}

		// Token: 0x06033DCB RID: 212427 RVA: 0x00E84558 File Offset: 0x00E82758
		public override void Refresh(int dataId, bool isSelected, int gridIndex)
		{
			this.TabId = dataId;
			PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId((PayShopDefine.EPayShopTabType)this.ShopId, dataId);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
		}

		// Token: 0x06033DCC RID: 212428 RVA: 0x00E845A0 File Offset: 0x00E827A0
		public void SetToggleState(bool bSelected)
		{
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x06033DCD RID: 212429 RVA: 0x00E845CB File Offset: 0x00E827CB
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06033DCE RID: 212430 RVA: 0x00E845D3 File Offset: 0x00E827D3
		private void OnToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> onToggle = this.OnToggle;
				if (onToggle == null)
				{
					return;
				}
				onToggle(this.TabId);
			}
		}

		// Token: 0x0401B764 RID: 112484
		private int ShopId;

		// Token: 0x0401B765 RID: 112485
		private int TabId;

		// Token: 0x0401B766 RID: 112486
		[Nullable(2)]
		private Action<int> OnToggle;

		// Token: 0x0200ADC4 RID: 44484
		private class EComponent
		{
			// Token: 0x04035B08 RID: 219912
			public const int Name = 0;

			// Token: 0x04035B09 RID: 219913
			public const int Toggle = 1;

			// Token: 0x04035B0A RID: 219914
			public const int Reddot = 2;
		}
	}
}
