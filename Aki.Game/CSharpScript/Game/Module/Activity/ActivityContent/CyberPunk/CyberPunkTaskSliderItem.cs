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
	// Token: 0x02005812 RID: 22546
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CyberPunkTaskSliderItem : GridProxyAbstract<CyberPunkTaskData>
	{
		// Token: 0x06037A36 RID: 227894 RVA: 0x00F8DBE7 File Offset: 0x00F8BDE7
		public int GetCurrentItemId()
		{
			return this.CurrentItemId;
		}

		// Token: 0x06037A37 RID: 227895 RVA: 0x00F8DBEF File Offset: 0x00F8BDEF
		public void SetOnClaim(Action<int> callback)
		{
			this.OnClaimCallback = callback;
		}

		// Token: 0x06037A38 RID: 227896 RVA: 0x00F8DBF8 File Offset: 0x00F8BDF8
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

		// Token: 0x06037A39 RID: 227897 RVA: 0x00F8DC63 File Offset: 0x00F8BE63
		public override object GetKey(CyberPunkTaskData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06037A3A RID: 227898 RVA: 0x00F8DC70 File Offset: 0x00F8BE70
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

		// Token: 0x06037A3B RID: 227899 RVA: 0x00F8DE00 File Offset: 0x00F8C000
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

		// Token: 0x06037A3C RID: 227900 RVA: 0x00F8DE40 File Offset: 0x00F8C040
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

		// Token: 0x06037A3D RID: 227901 RVA: 0x00F8DEB4 File Offset: 0x00F8C0B4
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

		// Token: 0x06037A3E RID: 227902 RVA: 0x00F8DF74 File Offset: 0x00F8C174
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

		// Token: 0x06037A3F RID: 227903 RVA: 0x00F8DFE8 File Offset: 0x00F8C1E8
		private void OnClickGetBtn()
		{
			if (this.TaskData == null || this.OnClaimCallback == null)
			{
				return;
			}
			this.OnClaimCallback(this.TaskData.Id);
		}

		// Token: 0x0401D572 RID: 120178
		[Nullable(2)]
		private CyberPunkTaskData TaskData;

		// Token: 0x0401D573 RID: 120179
		[Nullable(2)]
		private Action<int> OnClaimCallback;

		// Token: 0x0401D574 RID: 120180
		[Nullable(2)]
		private CommonItemSmallItemGrid RewardItemGrid;

		// Token: 0x0401D575 RID: 120181
		private int CurrentItemId;

		// Token: 0x0200B463 RID: 46179
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04037CAE RID: 228526
			public const int PropItem = 0;

			// Token: 0x04037CAF RID: 228527
			public const int TxtName = 1;

			// Token: 0x04037CB0 RID: 228528
			public const int TxtDesc = 2;

			// Token: 0x04037CB1 RID: 228529
			public const int TxtValue = 3;

			// Token: 0x04037CB2 RID: 228530
			public const int ExpBarFill = 4;

			// Token: 0x04037CB3 RID: 228531
			public const int TxtDoing = 5;

			// Token: 0x04037CB4 RID: 228532
			public const int GetBtn = 6;

			// Token: 0x04037CB5 RID: 228533
			public const int FinishState = 7;

			// Token: 0x04037CB6 RID: 228534
			public const int RedPoint = 8;
		}
	}
}
