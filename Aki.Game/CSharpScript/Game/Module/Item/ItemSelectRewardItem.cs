using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047F8 RID: 18424
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ItemSelectRewardItem : GridProxyAbstract<ItemSelectRewardItemData>
	{
		// Token: 0x0602E440 RID: 189504 RVA: 0x00CE7638 File Offset: 0x00CE5838
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

		// Token: 0x0602E441 RID: 189505 RVA: 0x00CE7741 File Offset: 0x00CE5941
		private void OnClickToggle(EToggleState state)
		{
			this.Data.OnClickToggleCallBack(this.Data.Index);
		}

		// Token: 0x0602E442 RID: 189506 RVA: 0x00CE775E File Offset: 0x00CE595E
		public override void Refresh(ItemSelectRewardItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshToggle(data);
			this.RefreshTexture(data);
			this.RefreshNameText(data);
			this.RefreshDoneItem(data);
			this.RefreshLimitInfoText(data);
		}

		// Token: 0x0602E443 RID: 189507 RVA: 0x00CE778C File Offset: 0x00CE598C
		private void RefreshToggle(ItemSelectRewardItemData data)
		{
			EToggleState state = data.SelectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0602E444 RID: 189508 RVA: 0x00CE77B8 File Offset: 0x00CE59B8
		private void RefreshTexture(ItemSelectRewardItemData data)
		{
			UUITexture texture = base.GetTexture(1);
			base.SetItemIcon(texture, data.ItemId, null, null);
		}

		// Token: 0x0602E445 RID: 189509 RVA: 0x00CE77E4 File Offset: 0x00CE59E4
		private void RefreshNameText(ItemSelectRewardItemData data)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.ItemId);
			base.GetText(2).ShowTextNew(itemConfigData.Name);
		}

		// Token: 0x0602E446 RID: 189510 RVA: 0x00CE7814 File Offset: 0x00CE5A14
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

		// Token: 0x0602E447 RID: 189511 RVA: 0x00CE7846 File Offset: 0x00CE5A46
		private void RefreshDoneItem(ItemSelectRewardItemData data)
		{
			base.GetItem(3).SetUIActive(!this.IfHaveRoleCallBackItemNeedRole(data.ItemId));
		}

		// Token: 0x0602E448 RID: 189512 RVA: 0x00CE7864 File Offset: 0x00CE5A64
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

		// Token: 0x04018A47 RID: 100935
		[Nullable(2)]
		public ItemSelectRewardItemData Data;
	}
}
