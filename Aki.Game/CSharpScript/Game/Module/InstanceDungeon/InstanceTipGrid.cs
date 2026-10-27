using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005884 RID: 22660
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InstanceTipGrid : GridProxyAbstract<IInstanceTipGridData>
	{
		// Token: 0x06039AB7 RID: 236215 RVA: 0x00DB4D0A File Offset: 0x00DB2F0A
		public void Initialize(UUIItem uiItem)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}

		// Token: 0x06039AB8 RID: 236216 RVA: 0x00DB4D18 File Offset: 0x00DB2F18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039AB9 RID: 236217 RVA: 0x00DB4DE4 File Offset: 0x00DB2FE4
		protected override void OnBeforeDestroy()
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.ItemGridList)
			{
				commonItemSmallItemGrid.Destroy(null);
			}
			this.ItemGridList.Clear();
		}

		// Token: 0x06039ABA RID: 236218 RVA: 0x00DB4E40 File Offset: 0x00DB3040
		public override void Refresh(IInstanceTipGridData gridData, bool isSelected, int gridIndex)
		{
			this.InstanceId = gridData.InstanceId;
			this.IsDouble = gridData.IsDouble;
			this.UpdateRewardPreview();
			this.UpdateButtonState();
			this.UpdateRewardText();
		}

		// Token: 0x06039ABB RID: 236219 RVA: 0x00DB4E6C File Offset: 0x00DB306C
		public void ClearGrid()
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.ItemGridList)
			{
				commonItemSmallItemGrid.Destroy(null);
			}
			this.ItemGridList.Clear();
		}

		// Token: 0x06039ABC RID: 236220 RVA: 0x00DB4EC8 File Offset: 0x00DB30C8
		private void UpdateRewardPreview()
		{
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(this.InstanceId) : null;
			if (instanceDungeon == null)
			{
				return;
			}
			List<int> list = new List<int>();
			list.AddRange(instanceDungeon.Value.GetCustomTypesBytes());
			ActivityDoubleRewardController instance2 = ActivityDoubleRewardController.Instance;
			ActivityDoubleRewardData activityDoubleRewardData = (instance2 != null) ? instance2.GetDungeonUpActivity(list, true) : null;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(activityDoubleRewardData != null || this.IsDouble);
			}
			int? instanceRewardId = InstanceDungeonConfig.Instance.GetInstanceRewardId(this.InstanceId);
			this.RewardItemList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(instanceRewardId.GetValueOrDefault(), null);
			this.IsShowReward = (this.RewardItemList != null && this.RewardItemList.Count > 0);
			UUIItem item2 = base.GetItem(2);
			AActor actor = (item2 != null) ? item2.GetOwner() : null;
			UUIItem item3 = base.GetItem(1);
			int num = 0;
			ExchangeRewardModel instance3 = ExchangeRewardModel.Instance;
			bool flag;
			if (instance3 == null || !instance3.IsFinishInstance(this.InstanceId))
			{
				ExchangeRewardModel instance4 = ExchangeRewardModel.Instance;
				flag = (instance4 != null && instance4.IsFinishInstanceCompatible(this.InstanceId));
			}
			else
			{
				flag = true;
			}
			bool receivedVisible = flag;
			if (this.RewardItemList != null)
			{
				foreach (TItem data in this.RewardItemList)
				{
					CommonItemSmallItemGrid commonItemSmallItemGrid;
					if (num < this.ItemGridList.Count)
					{
						commonItemSmallItemGrid = this.ItemGridList[num];
					}
					else
					{
						commonItemSmallItemGrid = new CommonItemSmallItemGrid();
						AActor aactor = LguiUtil.Instance.DuplicateActor(actor, item3);
						if (aactor != null)
						{
							commonItemSmallItemGrid.Initialize(aactor);
							this.ItemGridList.Add(commonItemSmallItemGrid);
						}
					}
					num++;
					commonItemSmallItemGrid.Refresh(data);
					commonItemSmallItemGrid.SetReceivedVisible(receivedVisible);
					commonItemSmallItemGrid.SetActive(true);
				}
			}
			for (int i = num; i < this.ItemGridList.Count; i++)
			{
				this.ItemGridList[i].SetActive(false);
			}
			UUIItem item4 = base.GetItem(2);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
		}

		// Token: 0x06039ABD RID: 236221 RVA: 0x00DB50FC File Offset: 0x00DB32FC
		private void UpdateButtonState()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(this.IsShowReward && this.IsShowDetail);
		}

		// Token: 0x06039ABE RID: 236222 RVA: 0x00DB5120 File Offset: 0x00DB3320
		private void UpdateRewardText()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			if (config == null)
			{
				return;
			}
			if (config.Value.InstSubType == 11)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Value.MapName, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_ProbReward_Text", Array.Empty<object>());
		}

		// Token: 0x0401E225 RID: 123429
		private int InstanceId;

		// Token: 0x0401E226 RID: 123430
		private bool IsDouble;

		// Token: 0x0401E227 RID: 123431
		[Nullable(2)]
		private List<TItem> RewardItemList;

		// Token: 0x0401E228 RID: 123432
		private readonly bool IsShowDetail = true;

		// Token: 0x0401E229 RID: 123433
		private bool IsShowReward;

		// Token: 0x0401E22A RID: 123434
		private readonly List<CommonItemSmallItemGrid> ItemGridList = new List<CommonItemSmallItemGrid>();

		// Token: 0x0200BADF RID: 47839
		[NullableContext(0)]
		public static class EChildCom
		{
			// Token: 0x0403877F RID: 231295
			public const int UiTextInstanceTitle = 0;

			// Token: 0x04038780 RID: 231296
			public const int UiItemContainer = 1;

			// Token: 0x04038781 RID: 231297
			public const int UiItemItem = 2;

			// Token: 0x04038782 RID: 231298
			public const int BtnPreView = 3;

			// Token: 0x04038783 RID: 231299
			public const int DoubleLabel = 4;
		}
	}
}
