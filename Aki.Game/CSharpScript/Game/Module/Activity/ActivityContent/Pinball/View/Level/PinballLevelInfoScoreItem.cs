using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x0200633E RID: 25406
	public class PinballLevelInfoScoreItem : UiPanelBase
	{
		// Token: 0x0603FEF2 RID: 261874 RVA: 0x00F78548 File Offset: 0x00F76748
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickIcon));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FEF3 RID: 261875 RVA: 0x00F78694 File Offset: 0x00F76894
		[NullableContext(1)]
		public void Refresh(IPinballLevelScoreData data)
		{
			TItem titem = RewardConfig.Instance.GetDropPackagePreviewItemList(data.ConfigDropId)[0];
			int itemId = titem.ItemData.ItemId;
			int count = titem.Count;
			this.RewardItemId = itemId;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			base.SetTextureByPath(itemConfigData.Icon, base.GetTexture(6), null, null);
			base.GetItem(0).SetUIActive(data.CurScore >= data.ConfigScore);
			base.GetSprite(5).SetUIActive(data.CurScore >= data.ConfigScore);
			base.GetText(1).SetText(count.ToString(), true);
			base.GetText(2).SetText(data.ConfigScore.ToString(), true);
			base.GetText(3).SetText(data.ConfigScore.ToString(), true);
		}

		// Token: 0x0603FEF4 RID: 261876 RVA: 0x00F7877F File Offset: 0x00F7697F
		private void OnClickIcon()
		{
			if (this.RewardItemId == 0)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItemId, true, null);
		}

		// Token: 0x0402158E RID: 136590
		private int RewardItemId;

		// Token: 0x0200C555 RID: 50517
		private enum EComponent
		{
			// Token: 0x0403B8F4 RID: 243956
			DoneItem,
			// Token: 0x0403B8F5 RID: 243957
			TxtScoreRewardNum,
			// Token: 0x0403B8F6 RID: 243958
			TxtScore,
			// Token: 0x0403B8F7 RID: 243959
			TxtLightScore,
			// Token: 0x0403B8F8 RID: 243960
			BtnIcon,
			// Token: 0x0403B8F9 RID: 243961
			SprIconDone,
			// Token: 0x0403B8FA RID: 243962
			TexItemIcon
		}
	}
}
