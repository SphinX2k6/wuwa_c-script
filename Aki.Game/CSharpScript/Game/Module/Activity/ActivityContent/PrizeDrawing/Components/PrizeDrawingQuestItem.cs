using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components
{
	// Token: 0x02005222 RID: 21026
	public class PrizeDrawingQuestItem : UiPanelBase
	{
		// Token: 0x06034541 RID: 214337 RVA: 0x00EA3EAC File Offset: 0x00EA20AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSkip));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034542 RID: 214338 RVA: 0x00EA4018 File Offset: 0x00EA2218
		private void OnClickSkip()
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.CachedQuestId, null);
			ActivityPrizeDrawingController.Instance.ActivityData.ReadQuestRedDot();
			this.RefreshRedDot();
		}

		// Token: 0x06034543 RID: 214339 RVA: 0x00EA404C File Offset: 0x00EA224C
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingQuestItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingQuestItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034544 RID: 214340 RVA: 0x00EA4090 File Offset: 0x00EA2290
		public void RefreshFinishState(bool isFinished)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(isFinished);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(!isFinished);
			}
			base.GetButton(3).RootUIComp.Get().SetUIActive(!isFinished);
			UUIItem item3 = base.GetItem(6);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(isFinished);
		}

		// Token: 0x06034545 RID: 214341 RVA: 0x00EA40F5 File Offset: 0x00EA22F5
		public void RefreshByQuestId(int questId, int currentProgress, int targetProgress)
		{
			this.CachedQuestId = questId;
			this.RefreshQuestName(questId);
			this.RefreshSkipButton(questId);
			this.RefreshRewardPreview(questId);
			this.RefreshProgress(currentProgress, targetProgress);
			this.RefreshRedDot();
		}

		// Token: 0x06034546 RID: 214342 RVA: 0x00EA4124 File Offset: 0x00EA2324
		private void RefreshQuestName(int questId)
		{
			IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(questId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), questConfig.TidName, Array.Empty<object>());
		}

		// Token: 0x06034547 RID: 214343 RVA: 0x00EA415C File Offset: 0x00EA235C
		private void RefreshSkipButton(int questId)
		{
			bool flag = QuestNewModel.Instance.CheckQuestFinished(questId);
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!flag);
			}
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag);
		}

		// Token: 0x06034548 RID: 214344 RVA: 0x00EA41AC File Offset: 0x00EA23AC
		private void RefreshRewardPreview(int questId)
		{
			List<TItem> displayRewardCommonInfoFromQuestConfig = QuestNewModel.Instance.GetDisplayRewardCommonInfoFromQuestConfig(questId);
			if (displayRewardCommonInfoFromQuestConfig == null || displayRewardCommonInfoFromQuestConfig.Count == 0)
			{
				return;
			}
			TItem titem = displayRewardCommonInfoFromQuestConfig[0];
			int itemId = titem.ItemData.ItemId;
			int count = titem.Count;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = InventoryConfig.Instance.GetItemConfig(itemId),
				ItemConfigId = new int?(itemId),
				BottomText = ((count == 0) ? "" : count.ToString())
			};
			SmallItemGrid previewItemGrid = this.PreviewItemGrid;
			if (previewItemGrid != null)
			{
				previewItemGrid.Apply<PropSmallItemGrid>(parameters);
			}
			this.CachedPreviewRewardItemId = itemId;
		}

		// Token: 0x06034549 RID: 214345 RVA: 0x00EA4242 File Offset: 0x00EA2442
		private void RefreshProgress(int currentProgress, int totalProgress)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Ichiban_Kuji_Progress_Task", new <>z__ReadOnlyArray<object>(new object[]
			{
				currentProgress,
				totalProgress
			}));
		}

		// Token: 0x0603454A RID: 214346 RVA: 0x00EA4278 File Offset: 0x00EA2478
		private void RefreshRedDot()
		{
			bool flag = ActivityPrizeDrawingController.Instance.ActivityData.IsCurQuestReaded();
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!flag);
		}

		// Token: 0x0603454B RID: 214347 RVA: 0x00EA42AA File Offset: 0x00EA24AA
		[NullableContext(1)]
		private void OnClickReward(MediumItemGridExtendCallback callbackParameter)
		{
			if (this.CachedPreviewRewardItemId != -1)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.CachedPreviewRewardItemId, true, null, false);
			}
		}

		// Token: 0x0401BC91 RID: 113809
		private int CachedQuestId = -1;

		// Token: 0x0401BC92 RID: 113810
		private int CachedPreviewRewardItemId = -1;

		// Token: 0x0401BC93 RID: 113811
		[Nullable(2)]
		private SmallItemGrid PreviewItemGrid;

		// Token: 0x0200AE6B RID: 44651
		private enum EComp
		{
			// Token: 0x04035E14 RID: 220692
			TxtName,
			// Token: 0x04035E15 RID: 220693
			TxtProgress,
			// Token: 0x04035E16 RID: 220694
			ItemGrid,
			// Token: 0x04035E17 RID: 220695
			BtnSkip,
			// Token: 0x04035E18 RID: 220696
			PnlNormal,
			// Token: 0x04035E19 RID: 220697
			PnlFinish,
			// Token: 0x04035E1A RID: 220698
			PnlChecked,
			// Token: 0x04035E1B RID: 220699
			RedDot
		}
	}
}
