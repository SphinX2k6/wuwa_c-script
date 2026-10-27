using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004E13 RID: 19987
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeMemoryRewardItem : GridProxyAbstract<RoguelikeMemoryRewardItemData>
	{
		// Token: 0x060338F7 RID: 211191 RVA: 0x00C0D5A4 File Offset: 0x00C0B7A4
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

		// Token: 0x060338F8 RID: 211192 RVA: 0x00C0D6B0 File Offset: 0x00C0B8B0
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

		// Token: 0x060338F9 RID: 211193 RVA: 0x00C0D79A File Offset: 0x00C0B99A
		protected override void OnStart()
		{
			if (this.GridItem == null)
			{
				this.GridItem = new CommonItemSmallItemGrid();
				this.GridItem.Initialize(base.GetItem(0).GetOwner());
			}
			this.GridItem.SetActive(false);
		}

		// Token: 0x060338FA RID: 211194 RVA: 0x00C0D7D4 File Offset: 0x00C0B9D4
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
			List<KeyValuePair<int, int>> list = RewardConfig.Instance.GetDropPackagePreview(data.Config.Value.DropId).ToList<KeyValuePair<int, int>>();
			TItem data2 = new TItem(new InventoryDefine.GetItemData(list[0].Key, 0), list[0].Value);
			this.GridItem.Refresh(data2);
			base.GetText(1).SetText(data.Config.Value.Index.ToString(), true);
			base.GetSprite(2).useChangeColor = flag;
			base.GetSprite(3).useChangeColor = flag;
			base.GetSprite(3).SetUIActive(gridIndex != 0);
		}

		// Token: 0x0401B592 RID: 112018
		public CommonItemSmallItemGrid GridItem;

		// Token: 0x0401B593 RID: 112019
		public RoguelikeMemoryRewardItemData Data;
	}
}
