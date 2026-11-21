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
	// Token: 0x0200485C RID: 18524
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InstanceTipGrid : GridProxyAbstract<IInstanceTipGridData>
	{
		// Token: 0x0602E9DA RID: 190938 RVA: 0x00D03C22 File Offset: 0x00D01E22
		public void Initialize(UUIItem uiItem)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}

		// Token: 0x0602E9DB RID: 190939 RVA: 0x00D03C30 File Offset: 0x00D01E30
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

		// Token: 0x0602E9DC RID: 190940 RVA: 0x00D03CFC File Offset: 0x00D01EFC
		protected override void OnBeforeDestroy()
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.ItemGridList)
			{
				commonItemSmallItemGrid.Destroy(null);
			}
			this.ItemGridList.Clear();
		}

		// Token: 0x0602E9DD RID: 190941 RVA: 0x00D03D58 File Offset: 0x00D01F58
		public override void Refresh(IInstanceTipGridData gridData, bool isSelected, int gridIndex)
		{
			this.InstanceId = gridData.InstanceId;
			this.IsDouble = gridData.IsDouble;
			this.UpdateRewardPreview();
			this.UpdateButtonState();
			this.UpdateRewardText();
		}

		// Token: 0x0602E9DE RID: 190942 RVA: 0x00D03D84 File Offset: 0x00D01F84
		public void ClearGrid()
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.ItemGridList)
			{
				commonItemSmallItemGrid.Destroy(null);
			}
			this.ItemGridList.Clear();
		}

		// Token: 0x0602E9DF RID: 190943 RVA: 0x00D03DE0 File Offset: 0x00D01FE0
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

		// Token: 0x0602E9E0 RID: 190944 RVA: 0x00D04014 File Offset: 0x00D02214
		private void UpdateButtonState()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(this.IsShowReward && this.IsShowDetail);
		}

		// Token: 0x0602E9E1 RID: 190945 RVA: 0x00D04038 File Offset: 0x00D02238
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

		// Token: 0x04018CC2 RID: 101570
		private int InstanceId;

		// Token: 0x04018CC3 RID: 101571
		private bool IsDouble;

		// Token: 0x04018CC4 RID: 101572
		[Nullable(2)]
		private List<TItem> RewardItemList;

		// Token: 0x04018CC5 RID: 101573
		private readonly bool IsShowDetail = true;

		// Token: 0x04018CC6 RID: 101574
		private bool IsShowReward;

		// Token: 0x04018CC7 RID: 101575
		private readonly List<CommonItemSmallItemGrid> ItemGridList = new List<CommonItemSmallItemGrid>();

		// Token: 0x0200A4F8 RID: 42232
		[NullableContext(0)]
		public static class EChildCom
		{
			// Token: 0x04033180 RID: 209280
			public const int UiTextInstanceTitle = 0;

			// Token: 0x04033181 RID: 209281
			public const int UiItemContainer = 1;

			// Token: 0x04033182 RID: 209282
			public const int UiItemItem = 2;

			// Token: 0x04033183 RID: 209283
			public const int BtnPreView = 3;

			// Token: 0x04033184 RID: 209284
			public const int DoubleLabel = 4;
		}
	}
}
