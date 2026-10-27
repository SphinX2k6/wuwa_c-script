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
	// Token: 0x020062A4 RID: 25252
	public class PrizeDrawingQuestItem : UiPanelBase
	{
		// Token: 0x0603F880 RID: 260224 RVA: 0x00F5CF50 File Offset: 0x00F5B150
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

		// Token: 0x0603F881 RID: 260225 RVA: 0x00F5D0BC File Offset: 0x00F5B2BC
		private void OnClickSkip()
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.CachedQuestId, null);
			ActivityPrizeDrawingController.Instance.ActivityData.ReadQuestRedDot();
			this.RefreshRedDot();
		}

		// Token: 0x0603F882 RID: 260226 RVA: 0x00F5D0F0 File Offset: 0x00F5B2F0
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingQuestItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingQuestItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F883 RID: 260227 RVA: 0x00F5D134 File Offset: 0x00F5B334
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

		// Token: 0x0603F884 RID: 260228 RVA: 0x00F5D199 File Offset: 0x00F5B399
		public void RefreshByQuestId(int questId, int currentProgress, int targetProgress)
		{
			this.CachedQuestId = questId;
			this.RefreshQuestName(questId);
			this.RefreshSkipButton(questId);
			this.RefreshRewardPreview(questId);
			this.RefreshProgress(currentProgress, targetProgress);
			this.RefreshRedDot();
		}

		// Token: 0x0603F885 RID: 260229 RVA: 0x00F5D1C8 File Offset: 0x00F5B3C8
		private void RefreshQuestName(int questId)
		{
			IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(questId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), questConfig.TidName, Array.Empty<object>());
		}

		// Token: 0x0603F886 RID: 260230 RVA: 0x00F5D200 File Offset: 0x00F5B400
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

		// Token: 0x0603F887 RID: 260231 RVA: 0x00F5D250 File Offset: 0x00F5B450
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

		// Token: 0x0603F888 RID: 260232 RVA: 0x00F5D2E6 File Offset: 0x00F5B4E6
		private void RefreshProgress(int currentProgress, int totalProgress)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Ichiban_Kuji_Progress_Task", new <>z__ReadOnlyArray<object>(new object[]
			{
				currentProgress,
				totalProgress
			}));
		}

		// Token: 0x0603F889 RID: 260233 RVA: 0x00F5D31C File Offset: 0x00F5B51C
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

		// Token: 0x0603F88A RID: 260234 RVA: 0x00F5D34E File Offset: 0x00F5B54E
		[NullableContext(1)]
		private void OnClickReward(MediumItemGridExtendCallback callbackParameter)
		{
			if (this.CachedPreviewRewardItemId != -1)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.CachedPreviewRewardItemId, true, null);
			}
		}

		// Token: 0x04021362 RID: 136034
		private int CachedQuestId = -1;

		// Token: 0x04021363 RID: 136035
		private int CachedPreviewRewardItemId = -1;

		// Token: 0x04021364 RID: 136036
		[Nullable(2)]
		private SmallItemGrid PreviewItemGrid;

		// Token: 0x0200C484 RID: 50308
		private enum EComp
		{
			// Token: 0x0403B4B2 RID: 242866
			TxtName,
			// Token: 0x0403B4B3 RID: 242867
			TxtProgress,
			// Token: 0x0403B4B4 RID: 242868
			ItemGrid,
			// Token: 0x0403B4B5 RID: 242869
			BtnSkip,
			// Token: 0x0403B4B6 RID: 242870
			PnlNormal,
			// Token: 0x0403B4B7 RID: 242871
			PnlFinish,
			// Token: 0x0403B4B8 RID: 242872
			PnlChecked,
			// Token: 0x0403B4B9 RID: 242873
			RedDot
		}
	}
}
