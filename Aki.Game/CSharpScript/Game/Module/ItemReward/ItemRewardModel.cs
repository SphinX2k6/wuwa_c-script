using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E7 RID: 22503
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemRewardModel : ModelBase
	{
		// Token: 0x0603931E RID: 234270 RVA: 0x00D904F0 File Offset: 0x00D8E6F0
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<T> CurrentRewardData<T>() where T : IRewardInfo
		{
			RewardData<T> rewardData = this.CurrentRewardDataInternal as RewardData<T>;
			if (rewardData != null)
			{
				return rewardData;
			}
			return null;
		}

		// Token: 0x0603931F RID: 234271 RVA: 0x00D9050F File Offset: 0x00D8E70F
		[NullableContext(2)]
		private IRewardDataInterface CurrentRewardData()
		{
			return this.CurrentRewardDataInternal;
		}

		// Token: 0x06039320 RID: 234272 RVA: 0x00D90517 File Offset: 0x00D8E717
		protected override bool OnClear()
		{
			this.CurrentRewardDataInternal = null;
			this.CurrentReasonId = null;
			return true;
		}

		// Token: 0x06039321 RID: 234273 RVA: 0x00D90530 File Offset: 0x00D8E730
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IRewardInfo> RefreshRewardData(EUiViewName viewName, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null)
		{
			RewardInfo rewardInfo = new RewardInfo
			{
				Type = ERewardInfoType.Default,
				ViewName = viewName
			};
			this.NewRewardData<IRewardInfo>(true);
			this.CurrentRewardData<IRewardInfo>().SetRewardInfo(rewardInfo);
			this.CurrentRewardData<IRewardInfo>().SetItemList(rewardItemDataList);
			return this.CurrentRewardData<IRewardInfo>();
		}

		// Token: 0x06039322 RID: 234274 RVA: 0x00D90578 File Offset: 0x00D8E778
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IExploreLevelRewardInfo> RefreshExploreLevelRewardData(EUiViewName viewName, int currentExploreLevel, int targetExploreLevel, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null)
		{
			ExploreLevelRewardInfo rewardInfo = new ExploreLevelRewardInfo
			{
				Type = ERewardInfoType.Default,
				ViewName = viewName,
				CurrentExploreLevel = currentExploreLevel,
				TargetExploreLevel = targetExploreLevel
			};
			this.NewRewardData<IExploreLevelRewardInfo>(true);
			this.CurrentRewardData<IExploreLevelRewardInfo>().SetRewardInfo(rewardInfo);
			this.CurrentRewardData<IExploreLevelRewardInfo>().SetItemList(rewardItemDataList);
			return this.CurrentRewardData<IExploreLevelRewardInfo>();
		}

		// Token: 0x06039323 RID: 234275 RVA: 0x00D905D0 File Offset: 0x00D8E7D0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IExploreLevelRewardInfo> GetExploreLevelRewardData(EUiViewName viewName, int currentExploreLevel, int targetExploreLevel, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null)
		{
			ExploreLevelRewardInfo rewardInfo = new ExploreLevelRewardInfo
			{
				Type = ERewardInfoType.Default,
				ViewName = viewName,
				CurrentExploreLevel = currentExploreLevel,
				TargetExploreLevel = targetExploreLevel
			};
			RewardData<IExploreLevelRewardInfo> rewardData = new RewardData<IExploreLevelRewardInfo>(null, null);
			rewardData.SetRewardInfo(rewardInfo);
			rewardData.SetItemList(rewardItemDataList);
			return rewardData;
		}

		// Token: 0x06039324 RID: 234276 RVA: 0x00D90618 File Offset: 0x00D8E818
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<ICommonRewardInfo> RefreshCommonRewardDataFromConfig(int configId, EUiViewName viewName, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, Action onCloseCallback = null, string leftBtnTextId = null, string rightBtnTextId = null, Action leftAction = null, Action rightAction = null, bool tipsCanSkip = true, bool disableMaskClose = false)
		{
			CommonRewardViewDisplay? commonRewardViewDisplayConfig = ItemRewardConfig.Instance.GetCommonRewardViewDisplayConfig(configId);
			if (commonRewardViewDisplayConfig == null)
			{
				return null;
			}
			CommonRewardViewDisplay value = commonRewardViewDisplayConfig.Value;
			CommonRewardInfo rewardInfo = new CommonRewardInfo
			{
				Type = ERewardInfoType.Common,
				ViewName = viewName,
				AudioId = value.AudioId,
				Title = value.Title,
				ContinueText = value.ContinueText,
				IsItemVisible = value.IsItemVisible,
				OnCloseCallback = onCloseCallback,
				LeftBtnTextId = leftBtnTextId,
				RightBtnTextId = rightBtnTextId,
				LeftAction = leftAction,
				RightAction = rightAction,
				DisableMaskClose = new bool?(disableMaskClose),
				TipsCanSkip = new bool?(tipsCanSkip)
			};
			this.NewRewardData<ICommonRewardInfo>(true);
			this.CurrentRewardData<ICommonRewardInfo>().SetRewardInfo(rewardInfo);
			this.CurrentRewardData<ICommonRewardInfo>().SetItemList(rewardItemDataList);
			return this.CurrentRewardData<ICommonRewardInfo>();
		}

		// Token: 0x06039325 RID: 234277 RVA: 0x00D906F4 File Offset: 0x00D8E8F4
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<ICommonRewardInfo> CreateCommonRewardDataFromConfig(int configId, EUiViewName viewName, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, Action onCloseCallback = null, string leftBtnTextId = null, string rightBtnTextId = null, Action leftAction = null, Action rightAction = null, bool tipsCanSkip = true, bool disableMaskClose = false)
		{
			CommonRewardViewDisplay? commonRewardViewDisplayConfig = ItemRewardConfig.Instance.GetCommonRewardViewDisplayConfig(configId);
			if (commonRewardViewDisplayConfig == null)
			{
				return null;
			}
			CommonRewardViewDisplay value = commonRewardViewDisplayConfig.Value;
			CommonRewardInfo rewardInfo = new CommonRewardInfo
			{
				Type = ERewardInfoType.Common,
				ViewName = viewName,
				AudioId = value.AudioId,
				Title = value.Title,
				ContinueText = value.ContinueText,
				IsItemVisible = value.IsItemVisible,
				OnCloseCallback = onCloseCallback,
				LeftBtnTextId = leftBtnTextId,
				RightBtnTextId = rightBtnTextId,
				LeftAction = leftAction,
				RightAction = rightAction,
				DisableMaskClose = new bool?(disableMaskClose),
				TipsCanSkip = new bool?(tipsCanSkip)
			};
			RewardData<ICommonRewardInfo> rewardData = new RewardData<ICommonRewardInfo>(null, null);
			rewardData.SetRewardInfo(rewardInfo);
			rewardData.SetItemList(rewardItemDataList);
			return rewardData;
		}

		// Token: 0x06039326 RID: 234278 RVA: 0x00D907C0 File Offset: 0x00D8E9C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<ICompositeRewardInfo> RefreshCompositeRewardDataFromConfig(int configId, bool isSuccess = true, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardProgress> progressQueue = null)
		{
			CompositeRewardDisplay? compositeRewardViewDisplayConfig = ItemRewardConfig.Instance.GetCompositeRewardViewDisplayConfig(configId);
			if (compositeRewardViewDisplayConfig == null)
			{
				return null;
			}
			CompositeRewardDisplay value = compositeRewardViewDisplayConfig.Value;
			CompositeRewardInfo rewardInfo = new CompositeRewardInfo
			{
				Type = ERewardInfoType.Composite,
				ViewName = EUiViewName.CompositeRewardView,
				Id = value.Id,
				AudioId = value.AudioId,
				IsSuccess = isSuccess,
				Title = value.Title,
				ContinueText = value.ContinueText,
				TitleIconPath = value.TitleIconPath,
				IsProgressVisible = value.IsProgressVisible,
				ProgressBarTitle = value.ProgressBarTitle,
				ProgressBarAnimationTime = value.ProgressBarAnimationTime,
				IsItemVisible = value.IsItemVisible
			};
			this.NewRewardData<ICompositeRewardInfo>(true);
			this.CurrentRewardData<ICompositeRewardInfo>().SetRewardInfo(rewardInfo);
			this.CurrentRewardData<ICompositeRewardInfo>().SetItemList(rewardItemDataList);
			if (progressQueue != null)
			{
				this.CurrentRewardData<ICompositeRewardInfo>().SetProgressQueue(progressQueue);
			}
			return this.CurrentRewardData<ICompositeRewardInfo>();
		}

		// Token: 0x06039327 RID: 234279 RVA: 0x00D908B8 File Offset: 0x00D8EAB8
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IExploreRewardInfo> RefreshExploreRewardDataFromConfig(int configId, bool isSuccess = true, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, IRewardExploreRecord exploreRecordInfo = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreBar> exploreBarDataList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreConfirmButton> buttonInfoList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreTargetReached> targetReached = null, IRewardExploreToggle stateToggle = null, Action onCloseCallback = null, string tip = null, bool? isShowOnlineChallengePlayer = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreFriendData> exploreFriendDataList = null, ReachTargetData scoreReachedData = null, bool? isRewardMultiLine = null, AccumulatedScoreData accumulatedScoreData = null, string titleTextId = null)
		{
			ExploreRewardDisplay? exploreRewardDisplayConfig = ItemRewardConfig.Instance.GetExploreRewardDisplayConfig(configId);
			if (exploreRewardDisplayConfig == null)
			{
				return null;
			}
			ExploreRewardDisplay value = exploreRewardDisplayConfig.Value;
			ExploreRewardInfo rewardInfo = new ExploreRewardInfo
			{
				Type = ERewardInfoType.Explore,
				ViewName = EUiViewName.ExploreRewardView,
				AudioId = value.AudioId,
				IsSuccess = isSuccess,
				Title = (titleTextId ?? value.Title),
				TitleHexColor = value.TitleHexColor,
				TitleIconPath = value.TitleIconPath,
				TitleIconHexColor = value.TitleIconHexColor,
				IsRecordVisible = value.IsRecordVisible,
				IsItemVisible = value.IsItemVisible,
				IsExploreProgressVisible = value.IsExploreProgressVisible,
				ExploreBarTipsTextId = value.ExploreBarTipsTextId,
				IsDescription = value.IsDescription,
				Description = value.Description,
				OnCloseCallback = onCloseCallback,
				Tip = tip,
				IsShowOnlineChallengePlayer = isShowOnlineChallengePlayer,
				IsRewardMultiLine = isRewardMultiLine
			};
			this.NewRewardData<IExploreRewardInfo>(true);
			this.CurrentRewardData<IExploreRewardInfo>().SetRewardInfo(rewardInfo);
			if (rewardItemDataList != null)
			{
				ItemRewardRoleDevelopStateTagUtil.FillRewardRoleDevelopStateTagType(rewardItemDataList);
			}
			this.CurrentRewardData<IExploreRewardInfo>().SetItemList(rewardItemDataList);
			if (exploreRecordInfo != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetExploreRecordInfo(exploreRecordInfo);
			}
			if (exploreBarDataList != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetExploreBarDataList(exploreBarDataList);
			}
			if (buttonInfoList != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetButtonInfoList(buttonInfoList);
			}
			if (targetReached != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetTargetReached(targetReached);
			}
			if (stateToggle != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetStateToggle(stateToggle);
			}
			if (exploreFriendDataList != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetExploreFriendDataList(exploreFriendDataList);
			}
			if (scoreReachedData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetScoreReached(scoreReachedData);
			}
			if (accumulatedScoreData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetAccumulatedScoreData(accumulatedScoreData);
			}
			return this.CurrentRewardData<IExploreRewardInfo>();
		}

		// Token: 0x06039328 RID: 234280 RVA: 0x00D90A70 File Offset: 0x00D8EC70
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IExploreRewardInfo> RefreshExploreRewardDataFromConfigNew(IExploreRewardViewData data)
		{
			ExploreRewardDisplay? exploreRewardDisplayConfig = ItemRewardConfig.Instance.GetExploreRewardDisplayConfig(data.ConfigId);
			if (exploreRewardDisplayConfig == null)
			{
				return null;
			}
			ExploreRewardDisplay value = exploreRewardDisplayConfig.Value;
			ExploreRewardInfo rewardInfo = new ExploreRewardInfo
			{
				Type = ERewardInfoType.Explore,
				ViewName = EUiViewName.ExploreRewardView,
				AudioId = value.AudioId,
				IsSuccess = data.IsSuccess,
				Title = (data.TitleTextId ?? value.Title),
				TitleHexColor = value.TitleHexColor,
				TitleIconPath = value.TitleIconPath,
				TitleIconHexColor = value.TitleIconHexColor,
				IsRecordVisible = value.IsRecordVisible,
				IsItemVisible = value.IsItemVisible,
				IsExploreProgressVisible = value.IsExploreProgressVisible,
				ExploreBarTipsTextId = value.ExploreBarTipsTextId,
				IsDescription = value.IsDescription,
				Description = value.Description,
				OnCloseCallback = data.OnCloseCallback,
				Tip = data.Tip,
				IsShowOnlineChallengePlayer = data.IsShowOnlineChallengePlayer,
				IsRewardMultiLine = data.IsRewardMultiLine,
				IsBagFull = data.IsBagFull
			};
			this.NewRewardData<IExploreRewardInfo>(true);
			this.CurrentRewardData<IExploreRewardInfo>().SetRewardInfo(rewardInfo);
			if (data.RewardItemDataList != null)
			{
				ItemRewardRoleDevelopStateTagUtil.FillRewardRoleDevelopStateTagType(data.RewardItemDataList);
			}
			this.CurrentRewardData<IExploreRewardInfo>().SetItemList(data.RewardItemDataList);
			if (data.ExploreRecordInfo != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetExploreRecordInfo(data.ExploreRecordInfo);
			}
			if (data.ExploreBarDataList != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetExploreBarDataList(data.ExploreBarDataList);
			}
			if (data.ButtonInfoList != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetButtonInfoList(data.ButtonInfoList);
			}
			if (data.TargetReached != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetTargetReached(data.TargetReached);
			}
			if (data.StateToggle != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetStateToggle(data.StateToggle);
			}
			if (data.ExploreFriendDataList != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetExploreFriendDataList(data.ExploreFriendDataList);
			}
			if (data.ScoreReachedData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetScoreReached(data.ScoreReachedData);
			}
			if (data.AccumulatedScoreData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetAccumulatedScoreData(data.AccumulatedScoreData);
			}
			if (data.BabelTowerSuccessData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetBabelTowerSuccessData(data.BabelTowerSuccessData);
			}
			if (data.DangoAbyssSuccessData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetDangoAbyssSuccessData(data.DangoAbyssSuccessData);
			}
			if (data.HonamiTowerSuccessData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetHonamiTowerSuccessData(data.HonamiTowerSuccessData);
			}
			if (data.RoguelikeBossChallengeData != null)
			{
				this.CurrentRewardData<IExploreRewardInfo>().SetRoguelikeBossChallengeData(data.RoguelikeBossChallengeData);
			}
			return this.CurrentRewardData<IExploreRewardInfo>();
		}

		// Token: 0x06039329 RID: 234281 RVA: 0x00D90D04 File Offset: 0x00D8EF04
		public void SetItemList(List<RewardItemData> rewardItemList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			if (rewardItemList == null || rewardItemList.Count < 1)
			{
				return;
			}
			this.CurrentRewardData().SetItemList(rewardItemList);
			EventSystem.Instance.Emit<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, rewardItemList);
		}

		// Token: 0x0603932A RID: 234282 RVA: 0x00D90D40 File Offset: 0x00D8EF40
		public void AddItemList(List<RewardItemData> rewardItemList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			if (rewardItemList == null || rewardItemList.Count < 1)
			{
				return;
			}
			this.CurrentRewardData().AddItemList(rewardItemList);
			EventSystem.Instance.Emit<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, rewardItemList);
		}

		// Token: 0x0603932B RID: 234283 RVA: 0x00D90D7C File Offset: 0x00D8EF7C
		public void SetProgressQueue(List<IRewardProgress> progressQueue)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetProgressQueue(progressQueue);
			EventSystem.Instance.Emit(EEventName.OnRefreshRewardProgressBar);
		}

		// Token: 0x0603932C RID: 234284 RVA: 0x00D90DAA File Offset: 0x00D8EFAA
		public void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetExploreBarDataList(exploreBarDataList);
		}

		// Token: 0x0603932D RID: 234285 RVA: 0x00D90DC8 File Offset: 0x00D8EFC8
		public void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetExploreRecordInfo(exploreRecordInfo);
		}

		// Token: 0x0603932E RID: 234286 RVA: 0x00D90DE6 File Offset: 0x00D8EFE6
		public void SetExploreFriendDataList(List<IRewardExploreFriendData> exploreFriendDataList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetExploreFriendDataList(exploreFriendDataList);
		}

		// Token: 0x0603932F RID: 234287 RVA: 0x00D90E04 File Offset: 0x00D8F004
		public void SetButtonList(List<IRewardExploreConfirmButton> rewardButtonList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			if (rewardButtonList == null || rewardButtonList.Count < 1)
			{
				return;
			}
			this.CurrentRewardData().SetButtonInfoList(rewardButtonList);
			EventSystem.Instance.Emit(EEventName.OnRefreshRewardButton);
		}

		// Token: 0x06039330 RID: 234288 RVA: 0x00D90E40 File Offset: 0x00D8F040
		public RewardData<T> NewRewardData<[Nullable(0)] T>(bool inheritData = false) where T : IRewardInfo
		{
			if (this.CurrentRewardDataInternal != null)
			{
				RewardData<T> rewardData = this.CurrentRewardDataInternal as RewardData<T>;
				if (rewardData != null)
				{
					return rewardData;
				}
			}
			RewardData<T> rewardData2 = new RewardData<T>(default(T), null);
			if (inheritData)
			{
				rewardData2.InheritData(this.CurrentRewardDataInternal);
			}
			this.CurrentRewardDataInternal = rewardData2;
			return rewardData2;
		}

		// Token: 0x06039331 RID: 234289 RVA: 0x00D90E8E File Offset: 0x00D8F08E
		public void ClearCurrentRewardData()
		{
			this.CurrentRewardDataInternal = null;
		}

		// Token: 0x06039332 RID: 234290 RVA: 0x00D90E97 File Offset: 0x00D8F097
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IRewardInfo> GetCurrentRewardData()
		{
			return this.CurrentRewardData<IRewardInfo>();
		}

		// Token: 0x17008A03 RID: 35331
		// (get) Token: 0x06039333 RID: 234291 RVA: 0x00D90E9F File Offset: 0x00D8F09F
		public static ItemRewardModel Instance
		{
			get
			{
				return ItemRewardModel._Instance;
			}
		}

		// Token: 0x06039334 RID: 234292 RVA: 0x00D90EA6 File Offset: 0x00D8F0A6
		public static ItemRewardModel GetOrCreateInstance()
		{
			if (ItemRewardModel._Instance == null)
			{
				ItemRewardModel.CreateInstance();
			}
			return ItemRewardModel._Instance;
		}

		// Token: 0x06039335 RID: 234293 RVA: 0x00D90EBA File Offset: 0x00D8F0BA
		public static bool CreateInstance()
		{
			if (ItemRewardModel._Instance != null)
			{
				return true;
			}
			ItemRewardModel._Instance = new ItemRewardModel();
			return true;
		}

		// Token: 0x06039336 RID: 234294 RVA: 0x00D90ED0 File Offset: 0x00D8F0D0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039337 RID: 234295 RVA: 0x00D90ED2 File Offset: 0x00D8F0D2
		public static void ResetStaticDefaultValue()
		{
			ItemRewardModel._Instance = null;
		}

		// Token: 0x06039338 RID: 234296 RVA: 0x00D90EDA File Offset: 0x00D8F0DA
		static ItemRewardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardModel.CreateStaticDefaultValue), new Action(ItemRewardModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DEEC RID: 122604
		[Nullable(2)]
		private IRewardDataInterface CurrentRewardDataInternal;

		// Token: 0x0401DEED RID: 122605
		public int? CurrentReasonId;

		// Token: 0x0401DEEE RID: 122606
		public List<RewardData<ICommonRewardInfo>> CacheCommonRewardDataList = new List<RewardData<ICommonRewardInfo>>();

		// Token: 0x0401DEEF RID: 122607
		[Nullable(2)]
		private static ItemRewardModel _Instance;
	}
}
