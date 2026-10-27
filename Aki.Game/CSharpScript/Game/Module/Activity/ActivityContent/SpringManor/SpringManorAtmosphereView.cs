using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200607E RID: 24702
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorAtmosphereView : UiViewBase
	{
		// Token: 0x0603E74C RID: 255820 RVA: 0x00F17B13 File Offset: 0x00F15D13
		public SpringManorAtmosphereView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E74D RID: 255821 RVA: 0x00F17B24 File Offset: 0x00F15D24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIText)),
				new ValueTuple<int, Type>(17, typeof(UUIItem))
			};
		}

		// Token: 0x0603E74E RID: 255822 RVA: 0x00F17CD4 File Offset: 0x00F15ED4
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorAtmosphereView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorAtmosphereView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E74F RID: 255823 RVA: 0x00F17D17 File Offset: 0x00F15F17
		protected override void OnStart()
		{
			this.InitCaption();
			this.InitLevelAttachView();
			this.InitGetWayScroll();
			this.InitUnlockScroll();
			this.InitRewardScroll();
			ButtonItem receiveButton = this.ReceiveButton;
			if (receiveButton == null)
			{
				return;
			}
			receiveButton.SetRedDotVisible(true);
		}

		// Token: 0x0603E750 RID: 255824 RVA: 0x00F17D48 File Offset: 0x00F15F48
		protected override void OnBeforeShow()
		{
			this.RefreshLevelView();
			this.RefreshLevelExpDisplay();
		}

		// Token: 0x0603E751 RID: 255825 RVA: 0x00F17D56 File Offset: 0x00F15F56
		protected override void OnBeforeHide()
		{
			GameSettingsDeviceRender.Instance.CancelPerformanceLimit(this.ViewInfo.Name);
		}

		// Token: 0x0603E752 RID: 255826 RVA: 0x00F17D72 File Offset: 0x00F15F72
		private void RefreshView()
		{
			this.RefreshUnlockScroll();
			this.RefreshGetWayScroll();
			this.RefreshRewardPreview();
		}

		// Token: 0x0603E753 RID: 255827 RVA: 0x00F17D88 File Offset: 0x00F15F88
		private void RefreshLevelExpDisplay()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int atmosphereLevel = instance.ActivityData.GetAtmosphereLevel();
			bool flag = instance.IsMaxLevel(atmosphereLevel);
			UUIText text = base.GetText(16);
			if (flag)
			{
				if (text != null)
				{
					text.ShowTextNew("Spring26_Atmosphere_Max");
				}
				return;
			}
			int atmosphere = instance.ActivityData.GetAtmosphere();
			int nextLevel = instance.GetNextLevel();
			int levelNeedExp = instance.GetLevelNeedExp(nextLevel);
			if (text != null)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(atmosphere);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(levelNeedExp);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x0603E754 RID: 255828 RVA: 0x00F17E20 File Offset: 0x00F16020
		private void OnSelectLevel(int level, LevelItem levelItem)
		{
			if (this.SelectLevel == level)
			{
				return;
			}
			NoCircleAttachView<SpringLevelData, LevelItem> levelAttachView = this.LevelAttachView;
			LevelItem levelItem2 = (levelAttachView != null) ? levelAttachView.GetItemByShowIndex(this.SelectLevel - 1) : null;
			if (levelItem2 != null)
			{
				LevelItem levelItem3 = levelItem2;
				if (levelItem3 != null)
				{
					levelItem3.PlaySequence("SleToNor");
				}
			}
			levelItem.PlaySequence("NorToSle");
			this.SelectLevel = level;
			this.RefreshView();
		}

		// Token: 0x0603E755 RID: 255829 RVA: 0x00F17E80 File Offset: 0x00F16080
		private void InitCaption()
		{
			PopupCaptionItem caption = this.Caption;
			if (caption != null)
			{
				caption.SetCloseCallBack(delegate
				{
					base.CloseMe(null);
				});
			}
			PopupCaptionItem caption2 = this.Caption;
			if (caption2 == null)
			{
				return;
			}
			caption2.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(495);
			});
		}

		// Token: 0x0603E756 RID: 255830 RVA: 0x00F17ED9 File Offset: 0x00F160D9
		private void InitRewardScroll()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), () => new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.IsReceived)
			}, null, false, null);
		}

		// Token: 0x0603E757 RID: 255831 RVA: 0x00F17EFC File Offset: 0x00F160FC
		private bool IsReceived(TItem _)
		{
			return this.CachedReceived;
		}

		// Token: 0x0603E758 RID: 255832 RVA: 0x00F17F04 File Offset: 0x00F16104
		private void RefreshRewardPreview()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			AtmosphereLevel? levelConfig = instance.GetLevelConfig(this.SelectLevel);
			if (levelConfig == null || levelConfig.Value.DropId == 0)
			{
				this.SetRewardState(ERewardState.None);
				return;
			}
			bool flag = instance.ActivityData.IsLevelRewardClaimed(levelConfig.Value.Id);
			this.CachedReceived = flag;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(levelConfig.Value.DropId);
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView != null)
			{
				rewardScrollView.RefreshByData(dropPackagePreviewItemList, null, false);
			}
			if (flag)
			{
				this.SetRewardState(ERewardState.Received);
				return;
			}
			if (instance.GetAtmosphereLevel() >= this.SelectLevel)
			{
				this.SetRewardState(ERewardState.CanReceive);
				return;
			}
			this.SetRewardState(ERewardState.Progress);
		}

		// Token: 0x0603E759 RID: 255833 RVA: 0x00F17FC4 File Offset: 0x00F161C4
		private void SetRewardState(ERewardState state)
		{
			bool flag = state == ERewardState.None;
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			ButtonItem receiveButton = this.ReceiveButton;
			if (receiveButton != null)
			{
				receiveButton.SetUiActive(state == ERewardState.CanReceive);
			}
			UUIItem item3 = base.GetItem(9);
			if (item3 != null)
			{
				item3.SetUIActive(state == ERewardState.Progress);
			}
			UUIItem item4 = base.GetItem(10);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(state == ERewardState.Received);
		}

		// Token: 0x0603E75A RID: 255834 RVA: 0x00F18043 File Offset: 0x00F16243
		private void InitGetWayScroll()
		{
			this.GetWayScrollView = new GenericScrollViewNew<GetWayItem, int>(base.GetScrollViewWithScrollbar(1), () => new GetWayItem
			{
				OnTrackPositionCallback = new Action(this.OnTrackPositionCallback)
			}, null, false, null);
		}

		// Token: 0x0603E75B RID: 255835 RVA: 0x00F18066 File Offset: 0x00F16266
		private void InitUnlockScroll()
		{
			this.UnlockScrollView = new GenericScrollViewNew<UnlockItem, int>(base.GetScrollViewWithScrollbar(4), () => new UnlockItem
			{
				OnTrackPositionCallback = new Action(this.OnTrackPositionCallback)
			}, null, false, null);
		}

		// Token: 0x0603E75C RID: 255836 RVA: 0x00F18089 File Offset: 0x00F16289
		private void OnTrackPositionCallback()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x0603E75D RID: 255837 RVA: 0x00F18098 File Offset: 0x00F16298
		private void RefreshGetWayScroll()
		{
			AtmosphereLevel? levelConfig = SpringManorModel.Instance.GetLevelConfig(this.SelectLevel);
			if (levelConfig == null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < levelConfig.Value.UpgradeWayLength; i++)
			{
				list.Add(levelConfig.Value.UpgradeWay(i));
			}
			GenericScrollViewNew<GetWayItem, int> getWayScrollView = this.GetWayScrollView;
			if (getWayScrollView == null)
			{
				return;
			}
			getWayScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0603E75E RID: 255838 RVA: 0x00F1810C File Offset: 0x00F1630C
		private void RefreshUnlockScroll()
		{
			AtmosphereLevel? levelConfig = SpringManorModel.Instance.GetLevelConfig(this.SelectLevel);
			if (levelConfig == null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < levelConfig.Value.UnlockFunctionLength; i++)
			{
				list.Add(levelConfig.Value.UnlockFunction(i));
			}
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(list.Count == 0);
			}
			GenericScrollViewNew<UnlockItem, int> unlockScrollView = this.UnlockScrollView;
			if (unlockScrollView == null)
			{
				return;
			}
			unlockScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0603E75F RID: 255839 RVA: 0x00F1819C File Offset: 0x00F1639C
		private void InitLevelAttachView()
		{
			this.LevelAttachView = new NoCircleAttachView<SpringLevelData, LevelItem>(base.GetItem(13).GetOwner(), false);
			UUIItem item = base.GetItem(14);
			item.SetUIActive(false);
			this.LevelAttachView.CreateItems(item.GetOwner(), 0f, new Func<AActor, int, int, LevelItem>(this.CreateLevelItem), EAttachDirection.Horizontal);
		}

		// Token: 0x0603E760 RID: 255840 RVA: 0x00F181F8 File Offset: 0x00F163F8
		private LevelItem CreateLevelItem(AActor actor, int index, int showNum)
		{
			LevelItem levelItem = new LevelItem();
			levelItem.CreateThenShowByActor(actor, null);
			levelItem.ClickCallback = new Action<int>(this.OnClickLevel);
			levelItem.SelectCallback = new Action<int, LevelItem>(this.OnSelectLevel);
			levelItem.GetIsSelectLevel = new Func<int, bool>(this.IsSelectLevel);
			return levelItem;
		}

		// Token: 0x0603E761 RID: 255841 RVA: 0x00F18248 File Offset: 0x00F16448
		private void OnClickLevel(int level)
		{
			NoCircleAttachView<SpringLevelData, LevelItem> levelAttachView = this.LevelAttachView;
			int? num = (levelAttachView != null) ? new int?(levelAttachView.GetCurrentSelectIndex()) : null;
			int num2 = level - 1;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				this.LevelAttachView.AttachToIndex(level - 1, false);
			}
		}

		// Token: 0x0603E762 RID: 255842 RVA: 0x00F1829C File Offset: 0x00F1649C
		private bool IsSelectLevel(int level)
		{
			return this.SelectLevel == level;
		}

		// Token: 0x0603E763 RID: 255843 RVA: 0x00F182A8 File Offset: 0x00F164A8
		private void RefreshLevelView()
		{
			List<SpringLevelData> totalLevelData = SpringManorModel.Instance.GetTotalLevelData();
			if (this.SelectLevel == -1)
			{
				int atmosphereLevel = SpringManorModel.Instance.GetAtmosphereLevel();
				this.LevelAttachView.ReloadView(totalLevelData.Count, totalLevelData.ToArray(), atmosphereLevel - 1);
				this.LevelAttachView.AttachToIndex(atmosphereLevel - 1, true);
				return;
			}
			foreach (LevelItem levelItem in this.LevelAttachView.GetItems())
			{
				levelItem.SetData(totalLevelData.ToArray());
				if (levelItem != null)
				{
					levelItem.RefreshPerformance();
				}
			}
		}

		// Token: 0x0603E764 RID: 255844 RVA: 0x00F18358 File Offset: 0x00F16558
		private void OnClickReward(int _)
		{
			SpringManorController.Instance.RequestAtmosphereRewardReceive(delegate
			{
				this.RefreshView();
				this.RefreshLevelView();
			});
		}

		// Token: 0x04020AC4 RID: 133828
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04020AC5 RID: 133829
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<SpringLevelData, LevelItem> LevelAttachView;

		// Token: 0x04020AC6 RID: 133830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<GetWayItem, int> GetWayScrollView;

		// Token: 0x04020AC7 RID: 133831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<UnlockItem, int> UnlockScrollView;

		// Token: 0x04020AC8 RID: 133832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x04020AC9 RID: 133833
		[Nullable(2)]
		private ButtonItem ReceiveButton;

		// Token: 0x04020ACA RID: 133834
		private int SelectLevel = -1;

		// Token: 0x04020ACB RID: 133835
		private bool CachedReceived;
	}
}
