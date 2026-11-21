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
	// Token: 0x020053CA RID: 21450
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x170067E5 RID: 26597
		// (get) Token: 0x06035556 RID: 218454 RVA: 0x00EE5F75 File Offset: 0x00EE4175
		private ActivityMotorLinkageData ActivityData
		{
			get
			{
				return ActivityMotorLinkageController.Instance.ActivityData;
			}
		}

		// Token: 0x06035557 RID: 218455 RVA: 0x00EE5F84 File Offset: 0x00EE4184
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

		// Token: 0x06035558 RID: 218456 RVA: 0x00EE6087 File Offset: 0x00EE4287
		protected override void OnStart()
		{
			this.ItemScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.ItemProxyCreate), null, false, null);
		}

		// Token: 0x06035559 RID: 218457 RVA: 0x00EE60AC File Offset: 0x00EE42AC
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

		// Token: 0x0603555A RID: 218458 RVA: 0x00EE6114 File Offset: 0x00EE4314
		private void OnClickSkip()
		{
			SkipTaskManager.RunByConfigId(ActivityMotorLinkageConfig.Instance.GetQuestConfig(this.QuestId).AccessId, null);
		}

		// Token: 0x0603555B RID: 218459 RVA: 0x00EE6140 File Offset: 0x00EE4340
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

		// Token: 0x0603555C RID: 218460 RVA: 0x00EE619C File Offset: 0x00EE439C
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

		// Token: 0x0603555D RID: 218461 RVA: 0x00EE61C4 File Offset: 0x00EE43C4
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

		// Token: 0x0603555E RID: 218462 RVA: 0x00EE623C File Offset: 0x00EE443C
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

		// Token: 0x0603555F RID: 218463 RVA: 0x00EE62E0 File Offset: 0x00EE44E0
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

		// Token: 0x06035560 RID: 218464 RVA: 0x00EE6360 File Offset: 0x00EE4560
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

		// Token: 0x06035561 RID: 218465 RVA: 0x00EE63A5 File Offset: 0x00EE45A5
		private CommonItemSmallItemGrid ItemProxyCreate()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0401C226 RID: 115238
		private int QuestId = -1;

		// Token: 0x0401C227 RID: 115239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemScrollView;
	}
}
