using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x0200644C RID: 25676
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x17009483 RID: 38019
		// (get) Token: 0x06040895 RID: 264341 RVA: 0x00F9EFF9 File Offset: 0x00F9D1F9
		private ActivityMotorLinkageData ActivityData
		{
			get
			{
				return ActivityMotorLinkageController.Instance.ActivityData;
			}
		}

		// Token: 0x06040896 RID: 264342 RVA: 0x00F9F008 File Offset: 0x00F9D208
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickReceive)),
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickSkip))
			};
		}

		// Token: 0x06040897 RID: 264343 RVA: 0x00F9F10B File Offset: 0x00F9D30B
		protected override void OnStart()
		{
			this.ItemScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.ItemProxyCreate), null, false, null);
		}

		// Token: 0x06040898 RID: 264344 RVA: 0x00F9F130 File Offset: 0x00F9D330
		private void OnClickReceive()
		{
			UUIButtonComponent button = base.GetButton(1);
			button.SetSelfInteractive(false);
			int ip = ActivityMotorLinkageConfig.Instance.GetQuestConfig(this.QuestId).Ip;
			ActivityMotorLinkageController.Instance.ReceiveAllRewardRequest(ip).ContinueWith(delegate()
			{
				button.SetSelfInteractive(true);
			}).Forget();
		}

		// Token: 0x06040899 RID: 264345 RVA: 0x00F9F198 File Offset: 0x00F9D398
		private void OnClickSkip()
		{
			SkipTaskManager.RunByConfigId(ActivityMotorLinkageConfig.Instance.GetQuestConfig(this.QuestId).AccessId, null);
		}

		// Token: 0x0604089A RID: 264346 RVA: 0x00F9F1C4 File Offset: 0x00F9D3C4
		public override void Refresh(int questId, bool isSelected, int gridIndex)
		{
			bool flag = this.QuestId == questId;
			this.QuestId = questId;
			if (!flag)
			{
				this.RefreshRewardPreview(questId);
			}
			EMotorQuestState motorQuestState = this.GetMotorQuestState(questId);
			this.RefreshQuestInfo(questId);
			this.RefreshButtonState(motorQuestState);
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ActivityData.IsQuestCanReceive(questId));
		}

		// Token: 0x0604089B RID: 264347 RVA: 0x00F9F220 File Offset: 0x00F9D420
		private void RefreshRewardPreview(int questId)
		{
			List<TItem> displayRewardCommonInfo = this.GetDisplayRewardCommonInfo(questId);
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> itemScrollView = this.ItemScrollView;
			if (itemScrollView == null)
			{
				return;
			}
			itemScrollView.RefreshByData(displayRewardCommonInfo, null, false);
		}

		// Token: 0x0604089C RID: 264348 RVA: 0x00F9F248 File Offset: 0x00F9D448
		private List<TItem> GetDisplayRewardCommonInfo(int questId)
		{
			MotorLinkageQuest questConfig = ActivityMotorLinkageConfig.Instance.GetQuestConfig(questId);
			List<TItem> list = new List<TItem>();
			for (int i = 0; i < questConfig.RewardInfoLength; i++)
			{
				DicIntInt? dicIntInt = questConfig.RewardInfo(i);
				if (dicIntInt != null)
				{
					list.Add(new TItem(new InventoryDefine.GetItemData(dicIntInt.Value.Key, 0), dicIntInt.Value.Value));
				}
			}
			return list;
		}

		// Token: 0x0604089D RID: 264349 RVA: 0x00F9F2C0 File Offset: 0x00F9D4C0
		private void RefreshQuestInfo(int questId)
		{
			MotorLinkageQuest questConfig = ActivityMotorLinkageConfig.Instance.GetQuestConfig(questId);
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(questConfig.TaskName);
			}
			if (!this.ActivityData.IsQuestRewardReceived(questId))
			{
				int questCurrentProgress = this.ActivityData.GetQuestCurrentProgress(questId);
				int questTargetProgress = this.ActivityData.GetQuestTargetProgress(questId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "MotorLinkage_Quest_Progress", new <>z__ReadOnlyArray<object>(new object[]
				{
					questCurrentProgress,
					questTargetProgress
				}));
				return;
			}
			UUIText text2 = base.GetText(5);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("MotorLinkage_Quest_Completed");
		}

		// Token: 0x0604089E RID: 264350 RVA: 0x00F9F364 File Offset: 0x00F9D564
		private void RefreshButtonState(EMotorQuestState state)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(state == EMotorQuestState.Progress);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(state == EMotorQuestState.Done);
			}
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(state == EMotorQuestState.CanReceive);
			}
			UUIButtonComponent button2 = base.GetButton(0);
			if (button2 == null)
			{
				return;
			}
			button2.RootUIComp.Get().SetUIActive(state == EMotorQuestState.ProgressCanSkip);
		}

		// Token: 0x0604089F RID: 264351 RVA: 0x00F9F3E4 File Offset: 0x00F9D5E4
		private EMotorQuestState GetMotorQuestState(int questId)
		{
			if (this.ActivityData.IsQuestCanReceive(questId))
			{
				return EMotorQuestState.CanReceive;
			}
			if (this.ActivityData.IsQuestRewardReceived(questId))
			{
				return EMotorQuestState.Done;
			}
			if (ActivityMotorLinkageConfig.Instance.GetQuestConfig(questId).AccessId != 0)
			{
				return EMotorQuestState.ProgressCanSkip;
			}
			return EMotorQuestState.Progress;
		}

		// Token: 0x060408A0 RID: 264352 RVA: 0x00F9F429 File Offset: 0x00F9D629
		private CommonItemSmallItemGrid ItemProxyCreate()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x040218F7 RID: 137463
		private int QuestId = -1;

		// Token: 0x040218F8 RID: 137464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemScrollView;
	}
}
