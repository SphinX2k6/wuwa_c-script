using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02005821 RID: 22561
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ItemSelectRewardItem : GridProxyAbstract<ItemSelectRewardItemData>
	{
		// Token: 0x0603952C RID: 234796 RVA: 0x00D987AC File Offset: 0x00D969AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603952D RID: 234797 RVA: 0x00D988B5 File Offset: 0x00D96AB5
		private void OnClickToggle(EToggleState state)
		{
			this.Data.OnClickToggleCallBack(this.Data.Index);
		}

		// Token: 0x0603952E RID: 234798 RVA: 0x00D988D2 File Offset: 0x00D96AD2
		public override void Refresh(ItemSelectRewardItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshToggle(data);
			this.RefreshTexture(data);
			this.RefreshNameText(data);
			this.RefreshDoneItem(data);
			this.RefreshLimitInfoText(data);
		}

		// Token: 0x0603952F RID: 234799 RVA: 0x00D98900 File Offset: 0x00D96B00
		private void RefreshToggle(ItemSelectRewardItemData data)
		{
			EToggleState state = data.SelectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x06039530 RID: 234800 RVA: 0x00D9892C File Offset: 0x00D96B2C
		private void RefreshTexture(ItemSelectRewardItemData data)
		{
			UUITexture texture = base.GetTexture(1);
			base.SetItemIcon(texture, data.ItemId, null, null);
		}

		// Token: 0x06039531 RID: 234801 RVA: 0x00D98958 File Offset: 0x00D96B58
		private void RefreshNameText(ItemSelectRewardItemData data)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.ItemId);
			base.GetText(2).ShowTextNew(itemConfigData.Name);
		}

		// Token: 0x06039532 RID: 234802 RVA: 0x00D98988 File Offset: 0x00D96B88
		private bool IfHaveRoleCallBackItemNeedRole(int itemId)
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(itemId);
			if (resonantItemRoleId == null)
			{
				return false;
			}
			int id = resonantItemRoleId[0];
			return RoleModel.Instance.GetRoleInstanceById(id) != null;
		}

		// Token: 0x06039533 RID: 234803 RVA: 0x00D989BA File Offset: 0x00D96BBA
		private void RefreshDoneItem(ItemSelectRewardItemData data)
		{
			base.GetItem(3).SetUIActive(!this.IfHaveRoleCallBackItemNeedRole(data.ItemId));
		}

		// Token: 0x06039534 RID: 234804 RVA: 0x00D989D8 File Offset: 0x00D96BD8
		private void RefreshLimitInfoText(ItemSelectRewardItemData data)
		{
			int num = 0;
			ResonantChainOptionLimitInfo limitInfo = data.LimitInfo;
			int num2 = (limitInfo != null) ? limitInfo.LimitNum : 0;
			if (data.LimitInfo != null)
			{
				foreach (ResonantChainOptionLimitItemInfo resonantChainOptionLimitItemInfo in data.LimitInfo.ItemInfos)
				{
					if (resonantChainOptionLimitItemInfo.ItemId == data.ItemId)
					{
						num = resonantChainOptionLimitItemInfo.Count;
						break;
					}
				}
			}
			int num3 = num2 - num;
			string textStringId = (num3 > 0) ? "ResonantChainOptionLimitInfoTextNormal" : "ResonantChainOptionLimitInfoTextMax";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				num3,
				num2
			}));
		}

		// Token: 0x0401DFB0 RID: 122800
		[Nullable(2)]
		public ItemSelectRewardItemData Data;
	}
}
