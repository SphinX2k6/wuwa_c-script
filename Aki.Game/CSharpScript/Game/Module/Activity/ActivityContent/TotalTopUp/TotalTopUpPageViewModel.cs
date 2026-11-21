using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F80 RID: 20352
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPageViewModel
	{
		// Token: 0x170063BC RID: 25532
		// (get) Token: 0x060330CF RID: 209103 RVA: 0x00E4EA12 File Offset: 0x00E4CC12
		public IReadOnlyList<TotalTopUpRotation> RotationList
		{
			get
			{
				return this.RotationConfigList;
			}
		}

		// Token: 0x060330D0 RID: 209104 RVA: 0x00E4EA1A File Offset: 0x00E4CC1A
		public bool HasRotation(int rewardId)
		{
			return this.RotationConfigMap.ContainsKey(rewardId);
		}

		// Token: 0x060330D1 RID: 209105 RVA: 0x00E4EA28 File Offset: 0x00E4CC28
		public TotalTopUpRotation? GetRotation(int rewardId)
		{
			TotalTopUpRotation value;
			if (this.RotationConfigMap.TryGetValue(rewardId, out value))
			{
				return new TotalTopUpRotation?(value);
			}
			return null;
		}

		// Token: 0x060330D2 RID: 209106 RVA: 0x00E4EA58 File Offset: 0x00E4CC58
		[NullableContext(2)]
		public TotalTopUpPageRewardViewModel GetRewardViewModel(int rewardId)
		{
			foreach (TotalTopUpPageRewardViewModel totalTopUpPageRewardViewModel in this.RewardViewModels)
			{
				if (totalTopUpPageRewardViewModel.RewardConfigId == rewardId)
				{
					return totalTopUpPageRewardViewModel;
				}
			}
			return null;
		}

		// Token: 0x170063BD RID: 25533
		// (get) Token: 0x060330D3 RID: 209107 RVA: 0x00E4EAB4 File Offset: 0x00E4CCB4
		public int CurrentScore
		{
			get
			{
				TotalTopUpData actData = this.ActData;
				if (actData == null)
				{
					return 0;
				}
				return actData.ProgressData.CurrentScore;
			}
		}

		// Token: 0x060330D4 RID: 209108 RVA: 0x00E4EACC File Offset: 0x00E4CCCC
		public int GetRewardScore(int rewardId)
		{
			TotalTopUpRewardData totalTopUpRewardData;
			if (this.ActData != null && this.ActData.RewardDataMap.TryGetValue(rewardId, out totalTopUpRewardData))
			{
				return totalTopUpRewardData.Score;
			}
			return 0;
		}

		// Token: 0x170063BE RID: 25534
		// (get) Token: 0x060330D5 RID: 209109 RVA: 0x00E4EAFE File Offset: 0x00E4CCFE
		public int NextScore
		{
			get
			{
				TotalTopUpData actData = this.ActData;
				if (actData == null)
				{
					return 0;
				}
				return actData.ProgressData.NextScore;
			}
		}

		// Token: 0x170063BF RID: 25535
		// (get) Token: 0x060330D6 RID: 209110 RVA: 0x00E4EB18 File Offset: 0x00E4CD18
		public float ProgressPercent
		{
			get
			{
				float num = (float)this.CurrentScore;
				float num2 = (float)this.NextScore;
				if (num2 <= 0f)
				{
					return 1f;
				}
				return Math.Min(num / num2, 1f);
			}
		}

		// Token: 0x060330D7 RID: 209111 RVA: 0x00E4EB50 File Offset: 0x00E4CD50
		public unsafe void InitData(TotalTopUpData actData, int activityId)
		{
			TotalTopUpUtil.Debug("初始化数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RewardViewModels.Clear();
			this.ActData = actData;
			List<TotalTopUpRewardData> rewardDataList = actData.RewardDataList;
			if (rewardDataList.Count <= 1)
			{
				TotalTopUpUtil.Debug("数据数量异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int num = 0;
			foreach (TotalTopUpRewardData totalTopUpRewardData in rewardDataList)
			{
				string message = "初始化奖励";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RewardId", totalTopUpRewardData.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Score", totalTopUpRewardData.Score);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("State", totalTopUpRewardData.State);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ButtonSlot", totalTopUpRewardData.PreviewButtonRegistry);
				TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				TotalTopUpPageRewardViewModel totalTopUpPageRewardViewModel = new TotalTopUpPageRewardViewModel(totalTopUpRewardData, this, num);
				totalTopUpPageRewardViewModel.InitData();
				this.RewardViewModels.Add(totalTopUpPageRewardViewModel);
				num++;
			}
			this.LoadRotationConfig(activityId);
		}

		// Token: 0x060330D8 RID: 209112 RVA: 0x00E4ECB8 File Offset: 0x00E4CEB8
		private unsafe void LoadRotationConfig(int activityId)
		{
			this.RotationConfigList.Clear();
			this.RotationConfigMap.Clear();
			bool flag = TotalTopUpConfig.Instance != null;
			TotalTopUpConfig instance = TotalTopUpConfig.Instance;
			IReadOnlyList<TotalTopUpRotation> readOnlyList = (instance != null) ? instance.GetRotationListByActivityId(activityId) : null;
			string message = "加载轮播配置";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasTotalTopUpConfig", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RotationListIsUndefined", readOnlyList == null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("RotationListLength", (readOnlyList != null) ? readOnlyList.Count : -1);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (readOnlyList == null || readOnlyList.Count <= 0)
			{
				return;
			}
			foreach (TotalTopUpRotation totalTopUpRotation in readOnlyList)
			{
				string message2 = "轮播配置条目";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", totalTopUpRotation.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActivityId", totalTopUpRotation.ActivityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Sort", totalTopUpRotation.Sort);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("PreviewType", totalTopUpRotation.PreviewType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("ShowDuration", totalTopUpRotation.ShowDuration);
				TotalTopUpUtil.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
				this.RotationConfigList.Add(totalTopUpRotation);
				this.RotationConfigMap[totalTopUpRotation.Id] = totalTopUpRotation;
			}
			this.RotationConfigList.Sort((TotalTopUpRotation a, TotalTopUpRotation b) => b.Sort - a.Sort);
		}

		// Token: 0x060330D9 RID: 209113 RVA: 0x00E4EF00 File Offset: 0x00E4D100
		public void Claim(TotalTopUpPageRewardViewModel rewardViewModel)
		{
			if (rewardViewModel.State != ETotalTopUpRewardState.CanClaim)
			{
				return;
			}
			if (rewardViewModel.ClaimFunction != ETotalTopUpClaimFunction.None)
			{
				this.DoSpecialClaim(rewardViewModel);
				return;
			}
			string message = "请求领取奖励";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RewardId", rewardViewModel.RewardConfigId);
			TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TotalTopUpController.Instance.RequestClaim(rewardViewModel.RewardConfigId, null);
		}

		// Token: 0x060330DA RID: 209114 RVA: 0x00E4EF68 File Offset: 0x00E4D168
		private void DoSpecialClaim(TotalTopUpPageRewardViewModel rewardViewModel)
		{
			ETotalTopUpClaimFunction claimFunction = rewardViewModel.ClaimFunction;
			if (claimFunction == ETotalTopUpClaimFunction.CharPick)
			{
				TotalTopUpPickRoleViewModel totalTopUpPickRoleViewModel = new TotalTopUpPickRoleViewModel();
				totalTopUpPickRoleViewModel.LoadFromActivityData(this.ActData, rewardViewModel.Index);
				UiManager.Instance.OpenView(EUiViewName.TotalTopUpPickRoleRewardView, totalTopUpPickRoleViewModel, null);
				return;
			}
			string message = "未知的特殊领奖功能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Function", claimFunction);
			TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060330DB RID: 209115 RVA: 0x00E4EFD0 File Offset: 0x00E4D1D0
		public void Preview(TotalTopUpPageRewardViewModel rewardViewModel)
		{
			TotalTopUpReward? rewardConfigById = TotalTopUpConfig.Instance.GetRewardConfigById(rewardViewModel.RewardConfigId);
			if (rewardConfigById == null)
			{
				string message = "[打开预览界面]预览奖励配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RewardId", rewardViewModel.RewardConfigId);
				TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (rewardViewModel.PreviewFunction == ETotalTopUpPreviewFunction.MotorCustomize)
			{
				string message2 = "打开摩托车定制界面";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PreviewId", rewardConfigById.Value.MotorPreviewId);
				TotalTopUpUtil.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(rewardConfigById.Value.MotorPreviewId);
				return;
			}
			if (rewardViewModel.PreviewFunction == ETotalTopUpPreviewFunction.SummonPreview)
			{
				UiManager.Instance.OpenView(EUiViewName.SpecialItemSummonShowView, rewardViewModel.RewardItemId, null);
				return;
			}
			if (rewardViewModel.PreviewFunction == ETotalTopUpPreviewFunction.OrnamentPreview)
			{
				RoleController.Instance.OpenOrnamentPreviewView(rewardViewModel.RewardItemId, null);
				return;
			}
			if (rewardViewModel.PreviewFunction == ETotalTopUpPreviewFunction.None)
			{
				ItemController.Instance.OpenItemTipsByItemId(rewardViewModel.RewardItemId, false, null, false);
				return;
			}
			ITotalTopUpPreviewViewParam param = new TotalTopUpPreviewViewParam
			{
				RewardConfig = rewardConfigById.Value,
				RewardData = this.ActData.RewardDataList[rewardViewModel.Index]
			};
			UiManager.Instance.OpenView(EUiViewName.TotalTopUpPreviewView, param, null);
		}

		// Token: 0x060330DC RID: 209116 RVA: 0x00E4F11C File Offset: 0x00E4D31C
		public void GotoStore()
		{
			TotalTopUpPageViewModel.<>c__DisplayClass22_0 CS$<>8__locals1 = new TotalTopUpPageViewModel.<>c__DisplayClass22_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = this.ActData;
			if (CS$<>8__locals1.data == null)
			{
				return;
			}
			if (this.RequestScoreInfoInProgress)
			{
				return;
			}
			this.RequestScoreInfoInProgress = true;
			CS$<>8__locals1.task = TotalTopUpController.Instance.RequestScoreInfoAsync(0);
			CS$<>8__locals1.<GotoStore>g__GotoStoreAfterRequest|0().Forget();
		}

		// Token: 0x060330DD RID: 209117 RVA: 0x00E4F178 File Offset: 0x00E4D378
		private static bool CheckWeekCardAvail()
		{
			WeekCardModel instance = WeekCardModel.Instance;
			WeekCardViewModel weekCardViewModel = (instance != null) ? instance.GetViewModel(EWeekCardKind.Normal) : null;
			return weekCardViewModel != null && weekCardViewModel.IsBuyOpen() && !weekCardViewModel.IsBuy() && TotalTopUpController.Instance.GetGoodsScore(weekCardViewModel.GetPayShopGoodsId().GetValueOrDefault()) > 0;
		}

		// Token: 0x060330DE RID: 209118 RVA: 0x00E4F1C8 File Offset: 0x00E4D3C8
		private unsafe bool CheckGiftPackAvail()
		{
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.GiftBag, 1, true);
			if (payShopTabData == null || payShopTabData.Count <= 0)
			{
				return false;
			}
			foreach (PayShopGoods payShopGoods in payShopTabData)
			{
				if (payShopGoods != null && !payShopGoods.IsSoldOut() && payShopGoods.IsShowInShop() && !payShopGoods.CheckIfMonthCardItem())
				{
					int num2;
					int num = (this.ActData != null && this.ActData.GoodsScoreMap.TryGetValue(payShopGoods.GetGoodsId(), out num2)) ? num2 : 0;
					if (num > 0)
					{
						string message = "发现可购买礼包";
						<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GoodsId", payShopGoods.GetGoodsId());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Score", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SoldOut", payShopGoods.IsSoldOut());
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
						string item = "BoughtCount";
						PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
						ptr = new ValueTuple<string, object>(item, ((goodsData != null) ? new int?(goodsData.BoughtCount) : null) ?? 0);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
						string item2 = "Limit";
						PayShopGoodsData goodsData2 = payShopGoods.GetGoodsData();
						ptr2 = new ValueTuple<string, object>(item2, ((goodsData2 != null) ? new int?(goodsData2.BuyLimit) : null) ?? 0);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("ShowInShop", payShopGoods.IsShowInShop());
						TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0401B18B RID: 110987
		[Nullable(2)]
		public TotalTopUpData ActData;

		// Token: 0x0401B18C RID: 110988
		public readonly List<TotalTopUpPageRewardViewModel> RewardViewModels = new List<TotalTopUpPageRewardViewModel>();

		// Token: 0x0401B18D RID: 110989
		private readonly List<TotalTopUpRotation> RotationConfigList = new List<TotalTopUpRotation>();

		// Token: 0x0401B18E RID: 110990
		private readonly Dictionary<int, TotalTopUpRotation> RotationConfigMap = new Dictionary<int, TotalTopUpRotation>();

		// Token: 0x0401B18F RID: 110991
		private bool RequestScoreInfoInProgress;
	}
}
