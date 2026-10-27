using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006174 RID: 24948
	public class RoverlikeShopSubTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603F108 RID: 258312 RVA: 0x00F3D5CC File Offset: 0x00F3B7CC
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

		// Token: 0x0603F109 RID: 258313 RVA: 0x00F3D672 File Offset: 0x00F3B872
		public void SetShopId(int shopId)
		{
			this.ShopId = shopId;
		}

		// Token: 0x0603F10A RID: 258314 RVA: 0x00F3D67B File Offset: 0x00F3B87B
		[NullableContext(1)]
		public void SetOnToggle(Action<int> callback)
		{
			this.OnToggle = callback;
		}

		// Token: 0x0603F10B RID: 258315 RVA: 0x00F3D684 File Offset: 0x00F3B884
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

		// Token: 0x0603F10C RID: 258316 RVA: 0x00F3D6CC File Offset: 0x00F3B8CC
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

		// Token: 0x0603F10D RID: 258317 RVA: 0x00F3D6F7 File Offset: 0x00F3B8F7
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0603F10E RID: 258318 RVA: 0x00F3D6FF File Offset: 0x00F3B8FF
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

		// Token: 0x04020E37 RID: 134711
		private int ShopId;

		// Token: 0x04020E38 RID: 134712
		private int TabId;

		// Token: 0x04020E39 RID: 134713
		[Nullable(2)]
		private Action<int> OnToggle;

		// Token: 0x0200C3DD RID: 50141
		private class EComponent
		{
			// Token: 0x0403B1A7 RID: 242087
			public const int Name = 0;

			// Token: 0x0403B1A8 RID: 242088
			public const int Toggle = 1;

			// Token: 0x0403B1A9 RID: 242089
			public const int Reddot = 2;
		}
	}
}
