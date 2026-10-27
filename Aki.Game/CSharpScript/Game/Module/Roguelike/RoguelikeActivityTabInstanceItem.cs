using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E04 RID: 19972
	public class RoguelikeActivityTabInstanceItem : UiPanelBase
	{
		// Token: 0x06033883 RID: 211075 RVA: 0x00C0AC68 File Offset: 0x00C08E68
		public RoguelikeActivityTabInstanceItem(int instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x06033884 RID: 211076 RVA: 0x00C0AC90 File Offset: 0x00C08E90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033885 RID: 211077 RVA: 0x00C0AD5C File Offset: 0x00C08F5C
		protected override void OnStart()
		{
			this.Update(this.InstanceId);
		}

		// Token: 0x06033886 RID: 211078 RVA: 0x00C0AD6C File Offset: 0x00C08F6C
		protected void Update(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.MapName, Array.Empty<object>());
			int? instanceRewardId = InstanceDungeonConfig.Instance.GetInstanceRewardId(instanceId);
			List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(instanceRewardId.GetValueOrDefault(), null);
			this.RewardItemList = exchangeRewardPreviewRewardList;
			this.IsShowReward = (this.RewardItemList != null && this.RewardItemList.Count > 0);
			AActor owner = base.GetItem(3).GetOwner();
			UUIItem item = base.GetItem(2);
			bool receivedVisible = !ExchangeRewardModel.Instance.GetInstanceDungeonIfCanExchange(instanceId);
			for (int i = 0; i < this.RewardItemList.Count; i++)
			{
				TItem data = this.RewardItemList[i];
				CommonItemSmallItemGrid commonItemSmallItemGrid = null;
				if (i < this.ItemGridList.Count)
				{
					commonItemSmallItemGrid = this.ItemGridList[i];
				}
				if (commonItemSmallItemGrid == null)
				{
					commonItemSmallItemGrid = new CommonItemSmallItemGrid();
					commonItemSmallItemGrid.Initialize(LguiUtil.Instance.DuplicateActor(owner, item));
					this.ItemGridList.Add(commonItemSmallItemGrid);
				}
				commonItemSmallItemGrid.Refresh(data);
				commonItemSmallItemGrid.SetReceivedVisible(receivedVisible);
				commonItemSmallItemGrid.SetActive(true);
			}
			for (int j = this.RewardItemList.Count; j < this.ItemGridList.Count; j++)
			{
				this.ItemGridList[j].SetActive(false);
			}
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0401B568 RID: 111976
		public int InstanceId;

		// Token: 0x0401B569 RID: 111977
		[Nullable(1)]
		public List<CommonItemSmallItemGrid> ItemGridList = new List<CommonItemSmallItemGrid>();

		// Token: 0x0401B56A RID: 111978
		public bool IsShowReward;

		// Token: 0x0401B56B RID: 111979
		[Nullable(1)]
		public List<TItem> RewardItemList = new List<TItem>();

		// Token: 0x0200AF94 RID: 44948
		private class ERoguelikeActivityTabInstanceItemDefine
		{
			// Token: 0x040354E8 RID: 218344
			public const int SpriteIcon = 0;

			// Token: 0x040354E9 RID: 218345
			public const int TxtName = 1;

			// Token: 0x040354EA RID: 218346
			public const int RewardContent = 2;

			// Token: 0x040354EB RID: 218347
			public const int RewardItem = 3;

			// Token: 0x040354EC RID: 218348
			public const int BtnConfirm = 4;
		}
	}
}
