using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068C2 RID: 26818
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CyberPunkTaskSliderItem : GridProxyAbstract<CyberPunkTaskData>
	{
		// Token: 0x06042EDE RID: 274142 RVA: 0x0104C5BF File Offset: 0x0104A7BF
		public int GetCurrentItemId()
		{
			return this.CurrentItemId;
		}

		// Token: 0x06042EDF RID: 274143 RVA: 0x0104C5C7 File Offset: 0x0104A7C7
		public void SetOnClaim(Action<int> callback)
		{
			this.OnClaimCallback = callback;
		}

		// Token: 0x06042EE0 RID: 274144 RVA: 0x0104C5D0 File Offset: 0x0104A7D0
		public override void Refresh(CyberPunkTaskData data, bool isSelected, int gridIndex)
		{
			this.TaskData = data;
			EdgeRunnerScoreReward? edgeRunnerScoreRewardConfigById = CyberPunkConfig.Instance.GetEdgeRunnerScoreRewardConfigById(data.Id);
			if (edgeRunnerScoreRewardConfigById == null)
			{
				return;
			}
			this.RefreshProgress(edgeRunnerScoreRewardConfigById.Value.Score, data.Current);
			this.RefreshRewardItem(edgeRunnerScoreRewardConfigById.Value.DropId);
			this.RefreshState(data.Status);
		}

		// Token: 0x06042EE1 RID: 274145 RVA: 0x0104C63B File Offset: 0x0104A83B
		public override object GetKey(CyberPunkTaskData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06042EE2 RID: 274146 RVA: 0x0104C648 File Offset: 0x0104A848
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickGetBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042EE3 RID: 274147 RVA: 0x0104C7D8 File Offset: 0x0104A9D8
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				this.RewardItemGrid = new CommonItemSmallItemGrid();
				this.RewardItemGrid.Initialize(item.GetOwner());
				this.RewardItemGrid.SetAllowClickBack(true);
			}
		}

		// Token: 0x06042EE4 RID: 274148 RVA: 0x0104C818 File Offset: 0x0104AA18
		private void RefreshProgress(int targetScore, int currentValue)
		{
			float fillAmount = Math.Min((float)currentValue / (float)targetScore, 1f);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(currentValue, targetScore));
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(targetScore);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x06042EE5 RID: 274149 RVA: 0x0104C88C File Offset: 0x0104AA8C
		private void RefreshRewardItem(int dropId)
		{
			if (dropId <= 0)
			{
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			if (dropPackagePreviewItemList == null || dropPackagePreviewItemList.Count == 0)
			{
				return;
			}
			int itemId = dropPackagePreviewItemList[0].ItemData.ItemId;
			this.CurrentItemId = itemId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData != null)
			{
				string text = ConfigMultiTextLang.GetLocalTextNew(ECyberPunkTextIdHelper.ToTextId(ECyberPunkTextId.REWARD), null) ?? "";
				string newValue = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null) ?? "";
				string newText = text.Replace("{0}", newValue);
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.SetText(newText, true);
				}
			}
			CommonItemSmallItemGrid rewardItemGrid = this.RewardItemGrid;
			if (rewardItemGrid == null)
			{
				return;
			}
			rewardItemGrid.RefreshByConfigId(itemId, null, null, false, false);
		}

		// Token: 0x06042EE6 RID: 274150 RVA: 0x0104C94C File Offset: 0x0104AB4C
		private void RefreshState(ConditionTaskState status)
		{
			bool uiactive = status == ConditionTaskState.ConditionTaskRunning;
			bool uiactive2 = status == ConditionTaskState.ConditionTaskFinish;
			bool uiactive3 = status == ConditionTaskState.ConditionTaskTaken;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(uiactive);
			}
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive2);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(uiactive3);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive2);
		}

		// Token: 0x06042EE7 RID: 274151 RVA: 0x0104C9C0 File Offset: 0x0104ABC0
		private void OnClickGetBtn()
		{
			if (this.TaskData == null || this.OnClaimCallback == null)
			{
				return;
			}
			this.OnClaimCallback(this.TaskData.Id);
		}

		// Token: 0x04022D16 RID: 142614
		[Nullable(2)]
		private CyberPunkTaskData TaskData;

		// Token: 0x04022D17 RID: 142615
		[Nullable(2)]
		private Action<int> OnClaimCallback;

		// Token: 0x04022D18 RID: 142616
		[Nullable(2)]
		private CommonItemSmallItemGrid RewardItemGrid;

		// Token: 0x04022D19 RID: 142617
		private int CurrentItemId;

		// Token: 0x0200CA9B RID: 51867
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x0403D3D4 RID: 250836
			public const int PropItem = 0;

			// Token: 0x0403D3D5 RID: 250837
			public const int TxtName = 1;

			// Token: 0x0403D3D6 RID: 250838
			public const int TxtDesc = 2;

			// Token: 0x0403D3D7 RID: 250839
			public const int TxtValue = 3;

			// Token: 0x0403D3D8 RID: 250840
			public const int ExpBarFill = 4;

			// Token: 0x0403D3D9 RID: 250841
			public const int TxtDoing = 5;

			// Token: 0x0403D3DA RID: 250842
			public const int GetBtn = 6;

			// Token: 0x0403D3DB RID: 250843
			public const int FinishState = 7;

			// Token: 0x0403D3DC RID: 250844
			public const int RedPoint = 8;
		}
	}
}
