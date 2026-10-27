using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x0200643E RID: 25662
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorDecalLinkQuestItem : GridProxyAbstract<MotorDecalLinkQuestViewModel>
	{
		// Token: 0x06040822 RID: 264226 RVA: 0x00F9D5FC File Offset: 0x00F9B7FC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickReceive)),
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickSkip))
			};
		}

		// Token: 0x06040823 RID: 264227 RVA: 0x00F9D6FF File Offset: 0x00F9B8FF
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitRewardGridItem), null, false, null);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x06040824 RID: 264228 RVA: 0x00F9D72F File Offset: 0x00F9B92F
		private ActivitySmallItemGrid InitRewardGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x06040825 RID: 264229 RVA: 0x00F9D738 File Offset: 0x00F9B938
		private void OnClickReceive()
		{
			MotorDecalLinkUtil.Debug("OnClickReceive", default(ReadOnlySpan<ValueTuple<string, object>>));
			MotorDecalLinkQuestViewModel currentQuestViewModel = this.CurrentQuestViewModel;
			if (currentQuestViewModel == null)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(1);
			button.SetSelfInteractive(false);
			MotorDecalLinkController.Instance.ReceiveRewardByIpRequest(currentQuestViewModel.ActivityId, currentQuestViewModel.IpId).ContinueWith(delegate()
			{
				button.SetSelfInteractive(true);
			}).Forget();
		}

		// Token: 0x06040826 RID: 264230 RVA: 0x00F9D7B0 File Offset: 0x00F9B9B0
		private void OnClickSkip()
		{
			MotorDecalLinkQuestViewModel currentQuestViewModel = this.CurrentQuestViewModel;
			if (currentQuestViewModel == null || currentQuestViewModel.AccessId == 0)
			{
				return;
			}
			SkipTaskManager.RunByConfigId(currentQuestViewModel.AccessId, null);
			AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(currentQuestViewModel.AccessId);
			if (accessPathConfig != null && accessPathConfig.Value.SkipName == 17)
			{
				UiManager.Instance.CloseHistoryRingView(EUiViewName.CommonActivityView, null);
			}
		}

		// Token: 0x06040827 RID: 264231 RVA: 0x00F9D81C File Offset: 0x00F9BA1C
		public override void Refresh(MotorDecalLinkQuestViewModel questViewModel, bool isSelected, int gridIndex)
		{
			this.CurrentQuestViewModel = questViewModel;
			this.RefreshRewardPreview();
			this.RefreshQuestInfo(questViewModel);
			EMotorDecalQuestState motorDecalQuestState = this.GetMotorDecalQuestState(questViewModel);
			this.RefreshButtonState(motorDecalQuestState);
		}

		// Token: 0x06040828 RID: 264232 RVA: 0x00F9D84C File Offset: 0x00F9BA4C
		private void RefreshRewardPreview()
		{
			MotorDecalLinkQuestViewModel currentQuestViewModel = this.CurrentQuestViewModel;
			if (currentQuestViewModel == null)
			{
				return;
			}
			bool hasClaimed = currentQuestViewModel.Status == EActivityTaskState.FinishedAndClaimed;
			List<IItemGridData> rewardGridDataList = this.GetRewardGridDataList(currentQuestViewModel.RewardInfo, hasClaimed);
			GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView == null)
			{
				return;
			}
			rewardScrollView.RefreshByData(rewardGridDataList, null, false);
		}

		// Token: 0x06040829 RID: 264233 RVA: 0x00F9D890 File Offset: 0x00F9BA90
		private List<IItemGridData> GetRewardGridDataList(Dictionary<int, int> rewardInfo, bool hasClaimed)
		{
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (KeyValuePair<int, int> keyValuePair in rewardInfo)
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
				list.Add(new ItemGridData
				{
					Item = item,
					HasClaimed = hasClaimed
				});
			}
			return list;
		}

		// Token: 0x0604082A RID: 264234 RVA: 0x00F9D914 File Offset: 0x00F9BB14
		private void RefreshQuestInfo(MotorDecalLinkQuestViewModel questViewModel)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), questViewModel.TaskName, Array.Empty<object>());
			if (questViewModel.Status == EActivityTaskState.FinishedAndClaimed)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "MotorLinkage_Quest_Completed", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "MotorLinkage_Quest_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				questViewModel.Current,
				questViewModel.Target
			}));
		}

		// Token: 0x0604082B RID: 264235 RVA: 0x00F9D9A0 File Offset: 0x00F9BBA0
		private void RefreshButtonState(EMotorDecalQuestState state)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(state == EMotorDecalQuestState.Done);
			}
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(state == EMotorDecalQuestState.CanReceive);
			}
			UUIButtonComponent button2 = base.GetButton(0);
			if (button2 == null)
			{
				return;
			}
			button2.RootUIComp.Get().SetUIActive(state == EMotorDecalQuestState.ProgressCanSkip);
		}

		// Token: 0x0604082C RID: 264236 RVA: 0x00F9DA08 File Offset: 0x00F9BC08
		private EMotorDecalQuestState GetMotorDecalQuestState(MotorDecalLinkQuestViewModel questViewModel)
		{
			if (questViewModel.Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				return EMotorDecalQuestState.CanReceive;
			}
			if (questViewModel.Status == EActivityTaskState.FinishedAndClaimed)
			{
				return EMotorDecalQuestState.Done;
			}
			if (questViewModel.AccessId != 0)
			{
				return EMotorDecalQuestState.ProgressCanSkip;
			}
			return EMotorDecalQuestState.Progress;
		}

		// Token: 0x040218BA RID: 137402
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x040218BB RID: 137403
		[Nullable(2)]
		private MotorDecalLinkQuestViewModel CurrentQuestViewModel;
	}
}
