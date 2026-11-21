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
	// Token: 0x020053BC RID: 21436
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorDecalLinkQuestItem : GridProxyAbstract<MotorDecalLinkQuestViewModel>
	{
		// Token: 0x060354E3 RID: 218339 RVA: 0x00EE4578 File Offset: 0x00EE2778
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

		// Token: 0x060354E4 RID: 218340 RVA: 0x00EE467B File Offset: 0x00EE287B
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitRewardGridItem), null, false, null);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x060354E5 RID: 218341 RVA: 0x00EE46AB File Offset: 0x00EE28AB
		private ActivitySmallItemGrid InitRewardGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x060354E6 RID: 218342 RVA: 0x00EE46B4 File Offset: 0x00EE28B4
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

		// Token: 0x060354E7 RID: 218343 RVA: 0x00EE472C File Offset: 0x00EE292C
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

		// Token: 0x060354E8 RID: 218344 RVA: 0x00EE4798 File Offset: 0x00EE2998
		public override void Refresh(MotorDecalLinkQuestViewModel questViewModel, bool isSelected, int gridIndex)
		{
			this.CurrentQuestViewModel = questViewModel;
			this.RefreshRewardPreview();
			this.RefreshQuestInfo(questViewModel);
			EMotorDecalQuestState motorDecalQuestState = this.GetMotorDecalQuestState(questViewModel);
			this.RefreshButtonState(motorDecalQuestState);
		}

		// Token: 0x060354E9 RID: 218345 RVA: 0x00EE47C8 File Offset: 0x00EE29C8
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

		// Token: 0x060354EA RID: 218346 RVA: 0x00EE480C File Offset: 0x00EE2A0C
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

		// Token: 0x060354EB RID: 218347 RVA: 0x00EE4890 File Offset: 0x00EE2A90
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

		// Token: 0x060354EC RID: 218348 RVA: 0x00EE491C File Offset: 0x00EE2B1C
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

		// Token: 0x060354ED RID: 218349 RVA: 0x00EE4984 File Offset: 0x00EE2B84
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

		// Token: 0x0401C1E9 RID: 115177
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401C1EA RID: 115178
		[Nullable(2)]
		private MotorDecalLinkQuestViewModel CurrentQuestViewModel;
	}
}
