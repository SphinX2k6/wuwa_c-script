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
	// Token: 0x02003DCD RID: 15821
	public class RoguelikeActivityTabInstanceItem : UiPanelBase
	{
		// Token: 0x060286EE RID: 165614 RVA: 0x00B54178 File Offset: 0x00B52378
		public RoguelikeActivityTabInstanceItem(int instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x060286EF RID: 165615 RVA: 0x00B541A0 File Offset: 0x00B523A0
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

		// Token: 0x060286F0 RID: 165616 RVA: 0x00B5426C File Offset: 0x00B5246C
		protected override void OnStart()
		{
			this.Update(this.InstanceId);
		}

		// Token: 0x060286F1 RID: 165617 RVA: 0x00B5427C File Offset: 0x00B5247C
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

		// Token: 0x04015F3B RID: 89915
		public int InstanceId;

		// Token: 0x04015F3C RID: 89916
		[Nullable(1)]
		public List<CommonItemSmallItemGrid> ItemGridList = new List<CommonItemSmallItemGrid>();

		// Token: 0x04015F3D RID: 89917
		public bool IsShowReward;

		// Token: 0x04015F3E RID: 89918
		[Nullable(1)]
		public List<TItem> RewardItemList = new List<TItem>();

		// Token: 0x020099C9 RID: 39369
		private class ERoguelikeActivityTabInstanceItemDefine
		{
			// Token: 0x0402FF1B RID: 196379
			public const int SpriteIcon = 0;

			// Token: 0x0402FF1C RID: 196380
			public const int TxtName = 1;

			// Token: 0x0402FF1D RID: 196381
			public const int RewardContent = 2;

			// Token: 0x0402FF1E RID: 196382
			public const int RewardItem = 3;

			// Token: 0x0402FF1F RID: 196383
			public const int BtnConfirm = 4;
		}
	}
}
