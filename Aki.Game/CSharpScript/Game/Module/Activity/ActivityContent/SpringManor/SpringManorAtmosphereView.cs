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
	// Token: 0x02004FFC RID: 20476
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorAtmosphereView : UiViewBase
	{
		// Token: 0x06033410 RID: 209936 RVA: 0x00E5E8D7 File Offset: 0x00E5CAD7
		public SpringManorAtmosphereView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033411 RID: 209937 RVA: 0x00E5E8E8 File Offset: 0x00E5CAE8
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

		// Token: 0x06033412 RID: 209938 RVA: 0x00E5EA98 File Offset: 0x00E5CC98
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorAtmosphereView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorAtmosphereView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033413 RID: 209939 RVA: 0x00E5EADB File Offset: 0x00E5CCDB
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

		// Token: 0x06033414 RID: 209940 RVA: 0x00E5EB0C File Offset: 0x00E5CD0C
		protected override void OnBeforeShow()
		{
			this.RefreshLevelView();
			this.RefreshLevelExpDisplay();
		}

		// Token: 0x06033415 RID: 209941 RVA: 0x00E5EB1A File Offset: 0x00E5CD1A
		protected override void OnBeforeHide()
		{
			GameSettingsDeviceRender.Instance.CancelPerformanceLimit(this.ViewInfo.Name);
		}

		// Token: 0x06033416 RID: 209942 RVA: 0x00E5EB36 File Offset: 0x00E5CD36
		private void RefreshView()
		{
			this.RefreshUnlockScroll();
			this.RefreshGetWayScroll();
			this.RefreshRewardPreview();
		}

		// Token: 0x06033417 RID: 209943 RVA: 0x00E5EB4C File Offset: 0x00E5CD4C
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

		// Token: 0x06033418 RID: 209944 RVA: 0x00E5EBE4 File Offset: 0x00E5CDE4
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

		// Token: 0x06033419 RID: 209945 RVA: 0x00E5EC44 File Offset: 0x00E5CE44
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

		// Token: 0x0603341A RID: 209946 RVA: 0x00E5EC9D File Offset: 0x00E5CE9D
		private void InitRewardScroll()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), () => new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.IsReceived)
			}, null, false, null);
		}

		// Token: 0x0603341B RID: 209947 RVA: 0x00E5ECC0 File Offset: 0x00E5CEC0
		private bool IsReceived(TItem _)
		{
			return this.CachedReceived;
		}

		// Token: 0x0603341C RID: 209948 RVA: 0x00E5ECC8 File Offset: 0x00E5CEC8
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

		// Token: 0x0603341D RID: 209949 RVA: 0x00E5ED88 File Offset: 0x00E5CF88
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

		// Token: 0x0603341E RID: 209950 RVA: 0x00E5EE07 File Offset: 0x00E5D007
		private void InitGetWayScroll()
		{
			this.GetWayScrollView = new GenericScrollViewNew<GetWayItem, int>(base.GetScrollViewWithScrollbar(1), () => new GetWayItem
			{
				OnTrackPositionCallback = new Action(this.OnTrackPositionCallback)
			}, null, false, null);
		}

		// Token: 0x0603341F RID: 209951 RVA: 0x00E5EE2A File Offset: 0x00E5D02A
		private void InitUnlockScroll()
		{
			this.UnlockScrollView = new GenericScrollViewNew<UnlockItem, int>(base.GetScrollViewWithScrollbar(4), () => new UnlockItem
			{
				OnTrackPositionCallback = new Action(this.OnTrackPositionCallback)
			}, null, false, null);
		}

		// Token: 0x06033420 RID: 209952 RVA: 0x00E5EE4D File Offset: 0x00E5D04D
		private void OnTrackPositionCallback()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x06033421 RID: 209953 RVA: 0x00E5EE5C File Offset: 0x00E5D05C
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

		// Token: 0x06033422 RID: 209954 RVA: 0x00E5EED0 File Offset: 0x00E5D0D0
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

		// Token: 0x06033423 RID: 209955 RVA: 0x00E5EF60 File Offset: 0x00E5D160
		private void InitLevelAttachView()
		{
			this.LevelAttachView = new NoCircleAttachView<SpringLevelData, LevelItem>(base.GetItem(13).GetOwner(), false);
			UUIItem item = base.GetItem(14);
			item.SetUIActive(false);
			this.LevelAttachView.CreateItems(item.GetOwner(), 0f, new Func<AActor, int, int, LevelItem>(this.CreateLevelItem), EAttachDirection.Horizontal);
		}

		// Token: 0x06033424 RID: 209956 RVA: 0x00E5EFBC File Offset: 0x00E5D1BC
		private LevelItem CreateLevelItem(AActor actor, int index, int showNum)
		{
			LevelItem levelItem = new LevelItem();
			levelItem.CreateThenShowByActor(actor, null);
			levelItem.ClickCallback = new Action<int>(this.OnClickLevel);
			levelItem.SelectCallback = new Action<int, LevelItem>(this.OnSelectLevel);
			levelItem.GetIsSelectLevel = new Func<int, bool>(this.IsSelectLevel);
			return levelItem;
		}

		// Token: 0x06033425 RID: 209957 RVA: 0x00E5F00C File Offset: 0x00E5D20C
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

		// Token: 0x06033426 RID: 209958 RVA: 0x00E5F060 File Offset: 0x00E5D260
		private bool IsSelectLevel(int level)
		{
			return this.SelectLevel == level;
		}

		// Token: 0x06033427 RID: 209959 RVA: 0x00E5F06C File Offset: 0x00E5D26C
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

		// Token: 0x06033428 RID: 209960 RVA: 0x00E5F11C File Offset: 0x00E5D31C
		private void OnClickReward(int _)
		{
			SpringManorController.Instance.RequestAtmosphereRewardReceive(delegate
			{
				this.RefreshView();
				this.RefreshLevelView();
			});
		}

		// Token: 0x0401B3F1 RID: 111601
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401B3F2 RID: 111602
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<SpringLevelData, LevelItem> LevelAttachView;

		// Token: 0x0401B3F3 RID: 111603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<GetWayItem, int> GetWayScrollView;

		// Token: 0x0401B3F4 RID: 111604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<UnlockItem, int> UnlockScrollView;

		// Token: 0x0401B3F5 RID: 111605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401B3F6 RID: 111606
		[Nullable(2)]
		private ButtonItem ReceiveButton;

		// Token: 0x0401B3F7 RID: 111607
		private int SelectLevel = -1;

		// Token: 0x0401B3F8 RID: 111608
		private bool CachedReceived;
	}
}
