using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DDC RID: 15836
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeMemoryRewardItem : GridProxyAbstract<RoguelikeMemoryRewardItemData>
	{
		// Token: 0x06028762 RID: 165730 RVA: 0x00B56AB0 File Offset: 0x00B54CB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnRewardClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028763 RID: 165731 RVA: 0x00B56BBC File Offset: 0x00B54DBC
		private void OnBtnRewardClick()
		{
			int pointItem = RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.PointItem;
			if (InventoryModel.Instance.GetItemCountByConfigId(pointItem, 0) < this.Data.Config.Value.Point)
			{
				return;
			}
			RoguelikeController instance = RoguelikeController.Instance;
			List<int> list = new List<int>();
			RoguelikeMemoryRewardItemData data = this.Data;
			list.Add(((data != null) ? ((data.Config != null) ? new int?(data.Config.GetValueOrDefault().Index) : null) : null).GetValueOrDefault());
			instance.RoguelikeSeasonRewardReceiveRequest(list, null).ContinueWith(delegate(bool task)
			{
			});
		}

		// Token: 0x06028764 RID: 165732 RVA: 0x00B56CA6 File Offset: 0x00B54EA6
		protected override void OnStart()
		{
			if (this.GridItem == null)
			{
				this.GridItem = new CommonItemSmallItemGrid();
				this.GridItem.Initialize(base.GetItem(0).GetOwner());
			}
			this.GridItem.SetActive(false);
		}

		// Token: 0x06028765 RID: 165733 RVA: 0x00B56CE0 File Offset: 0x00B54EE0
		[NullableContext(1)]
		public override void Refresh(RoguelikeMemoryRewardItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			int pointItem = RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.PointItem;
			bool flag = InventoryModel.Instance.GetItemCountByConfigId(pointItem, 0) >= data.Config.Value.Point;
			if (flag)
			{
				SeasonReward seasonReward = data.SeasonReward;
				if (seasonReward == null || !seasonReward.IsReceive)
				{
					base.GetButton(4).SetActive(true, false);
					goto IL_8C;
				}
			}
			base.GetButton(4).SetActive(false, false);
			IL_8C:
			this.GridItem.SetActive(true);
			List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(RewardConfig.Instance.GetDropPackagePreview(data.Config.Value.DropId));
			TItem data2 = new TItem(new InventoryDefine.GetItemData(list[0].Key, 0), list[0].Value);
			this.GridItem.Refresh(data2);
			base.GetText(1).SetText(data.Config.Value.Index.ToString(), true);
			base.GetSprite(2).useChangeColor = flag;
			base.GetSprite(3).useChangeColor = flag;
			base.GetSprite(3).SetUIActive(gridIndex != 0);
		}

		// Token: 0x04015F65 RID: 89957
		public CommonItemSmallItemGrid GridItem;

		// Token: 0x04015F66 RID: 89958
		public RoguelikeMemoryRewardItemData Data;
	}
}
