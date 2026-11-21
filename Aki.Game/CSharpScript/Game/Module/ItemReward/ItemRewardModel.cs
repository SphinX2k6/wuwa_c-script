using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047BE RID: 18366
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemRewardModel : ModelBase
	{
		// Token: 0x0602E232 RID: 188978 RVA: 0x00CDF338 File Offset: 0x00CDD538
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

		// Token: 0x0602E233 RID: 188979 RVA: 0x00CDF357 File Offset: 0x00CDD557
		[NullableContext(2)]
		private IRewardDataInterface CurrentRewardData()
		{
			return this.CurrentRewardDataInternal;
		}

		// Token: 0x0602E234 RID: 188980 RVA: 0x00CDF35F File Offset: 0x00CDD55F
		protected override bool OnClear()
		{
			this.CurrentRewardDataInternal = null;
			this.CurrentReasonId = null;
			return true;
		}

		// Token: 0x0602E235 RID: 188981 RVA: 0x00CDF378 File Offset: 0x00CDD578
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

		// Token: 0x0602E236 RID: 188982 RVA: 0x00CDF3C0 File Offset: 0x00CDD5C0
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

		// Token: 0x0602E237 RID: 188983 RVA: 0x00CDF418 File Offset: 0x00CDD618
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

		// Token: 0x0602E238 RID: 188984 RVA: 0x00CDF460 File Offset: 0x00CDD660
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

		// Token: 0x0602E239 RID: 188985 RVA: 0x00CDF53C File Offset: 0x00CDD73C
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

		// Token: 0x0602E23A RID: 188986 RVA: 0x00CDF608 File Offset: 0x00CDD808
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

		// Token: 0x0602E23B RID: 188987 RVA: 0x00CDF700 File Offset: 0x00CDD900
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

		// Token: 0x0602E23C RID: 188988 RVA: 0x00CDF8B8 File Offset: 0x00CDDAB8
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

		// Token: 0x0602E23D RID: 188989 RVA: 0x00CDFB4C File Offset: 0x00CDDD4C
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

		// Token: 0x0602E23E RID: 188990 RVA: 0x00CDFB88 File Offset: 0x00CDDD88
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

		// Token: 0x0602E23F RID: 188991 RVA: 0x00CDFBC4 File Offset: 0x00CDDDC4
		public void SetProgressQueue(List<IRewardProgress> progressQueue)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetProgressQueue(progressQueue);
			EventSystem.Instance.Emit(EEventName.OnRefreshRewardProgressBar);
		}

		// Token: 0x0602E240 RID: 188992 RVA: 0x00CDFBF2 File Offset: 0x00CDDDF2
		public void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetExploreBarDataList(exploreBarDataList);
		}

		// Token: 0x0602E241 RID: 188993 RVA: 0x00CDFC10 File Offset: 0x00CDDE10
		public void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetExploreRecordInfo(exploreRecordInfo);
		}

		// Token: 0x0602E242 RID: 188994 RVA: 0x00CDFC2E File Offset: 0x00CDDE2E
		public void SetExploreFriendDataList(List<IRewardExploreFriendData> exploreFriendDataList)
		{
			if (this.CurrentRewardData() == null)
			{
				this.NewRewardData<IRewardInfo>(false);
			}
			this.CurrentRewardData().SetExploreFriendDataList(exploreFriendDataList);
		}

		// Token: 0x0602E243 RID: 188995 RVA: 0x00CDFC4C File Offset: 0x00CDDE4C
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

		// Token: 0x0602E244 RID: 188996 RVA: 0x00CDFC88 File Offset: 0x00CDDE88
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

		// Token: 0x0602E245 RID: 188997 RVA: 0x00CDFCD6 File Offset: 0x00CDDED6
		public void ClearCurrentRewardData()
		{
			this.CurrentRewardDataInternal = null;
		}

		// Token: 0x0602E246 RID: 188998 RVA: 0x00CDFCDF File Offset: 0x00CDDEDF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<IRewardInfo> GetCurrentRewardData()
		{
			return this.CurrentRewardData<IRewardInfo>();
		}

		// Token: 0x17005DCD RID: 24013
		// (get) Token: 0x0602E247 RID: 188999 RVA: 0x00CDFCE7 File Offset: 0x00CDDEE7
		public static ItemRewardModel Instance
		{
			get
			{
				return ItemRewardModel._Instance;
			}
		}

		// Token: 0x0602E248 RID: 189000 RVA: 0x00CDFCEE File Offset: 0x00CDDEEE
		public static ItemRewardModel GetOrCreateInstance()
		{
			if (ItemRewardModel._Instance == null)
			{
				ItemRewardModel.CreateInstance();
			}
			return ItemRewardModel._Instance;
		}

		// Token: 0x0602E249 RID: 189001 RVA: 0x00CDFD02 File Offset: 0x00CDDF02
		public static bool CreateInstance()
		{
			if (ItemRewardModel._Instance != null)
			{
				return true;
			}
			ItemRewardModel._Instance = new ItemRewardModel();
			return true;
		}

		// Token: 0x0602E24A RID: 189002 RVA: 0x00CDFD18 File Offset: 0x00CDDF18
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E24B RID: 189003 RVA: 0x00CDFD1A File Offset: 0x00CDDF1A
		public static void ResetStaticDefaultValue()
		{
			ItemRewardModel._Instance = null;
		}

		// Token: 0x0602E24C RID: 189004 RVA: 0x00CDFD22 File Offset: 0x00CDDF22
		static ItemRewardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardModel.CreateStaticDefaultValue), new Action(ItemRewardModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018983 RID: 100739
		[Nullable(2)]
		private IRewardDataInterface CurrentRewardDataInternal;

		// Token: 0x04018984 RID: 100740
		public int? CurrentReasonId;

		// Token: 0x04018985 RID: 100741
		public List<RewardData<ICommonRewardInfo>> CacheCommonRewardDataList = new List<RewardData<ICommonRewardInfo>>();

		// Token: 0x04018986 RID: 100742
		[Nullable(2)]
		private static ItemRewardModel _Instance;
	}
}
