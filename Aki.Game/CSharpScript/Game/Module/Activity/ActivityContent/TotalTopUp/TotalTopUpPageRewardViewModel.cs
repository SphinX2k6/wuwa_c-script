using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F9A RID: 24474
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPageRewardViewModel
	{
		// Token: 0x0603E146 RID: 254278 RVA: 0x00EFD73C File Offset: 0x00EFB93C
		public TotalTopUpPageRewardViewModel(TotalTopUpRewardData rewardData, TotalTopUpPageViewModel pageViewModel, int index = 0)
		{
			this.RewardData = rewardData;
			this.PageViewModel = pageViewModel;
			this.Index = index;
			TotalTopUpData actData = this.PageViewModel.ActData;
			this.ActivityId = ((actData != null) ? actData.Id : 0);
		}

		// Token: 0x17008FEE RID: 36846
		// (get) Token: 0x0603E147 RID: 254279 RVA: 0x00EFD797 File Offset: 0x00EFB997
		public int Score
		{
			get
			{
				TotalTopUpRewardData rewardData = this.RewardData;
				if (rewardData == null)
				{
					return 0;
				}
				return rewardData.Score;
			}
		}

		// Token: 0x17008FEF RID: 36847
		// (get) Token: 0x0603E148 RID: 254280 RVA: 0x00EFD7AA File Offset: 0x00EFB9AA
		public ETotalTopUpRewardState State
		{
			get
			{
				TotalTopUpRewardData rewardData = this.RewardData;
				if (rewardData == null)
				{
					return ETotalTopUpRewardState.Lock;
				}
				return rewardData.State;
			}
		}

		// Token: 0x17008FF0 RID: 36848
		// (get) Token: 0x0603E149 RID: 254281 RVA: 0x00EFD7BD File Offset: 0x00EFB9BD
		public int RewardConfigId
		{
			get
			{
				TotalTopUpRewardData rewardData = this.RewardData;
				if (rewardData == null)
				{
					return 0;
				}
				return rewardData.Id;
			}
		}

		// Token: 0x17008FF1 RID: 36849
		// (get) Token: 0x0603E14A RID: 254282 RVA: 0x00EFD7D0 File Offset: 0x00EFB9D0
		public int RewardItemId
		{
			get
			{
				TotalTopUpRewardData rewardData = this.RewardData;
				if (rewardData == null)
				{
					return 0;
				}
				return rewardData.FirstItemId;
			}
		}

		// Token: 0x17008FF2 RID: 36850
		// (get) Token: 0x0603E14B RID: 254283 RVA: 0x00EFD7E3 File Offset: 0x00EFB9E3
		public int RewardCount
		{
			get
			{
				TotalTopUpRewardData rewardData = this.RewardData;
				if (rewardData == null)
				{
					return 0;
				}
				return rewardData.FirstItemCount;
			}
		}

		// Token: 0x0603E14C RID: 254284 RVA: 0x00EFD7F8 File Offset: 0x00EFB9F8
		public unsafe void InitData()
		{
			InventoryConfig instance = InventoryConfig.Instance;
			TotalTopUpRewardData rewardData = this.RewardData;
			ItemConfig itemConfigData = instance.GetItemConfigData((rewardData != null) ? rewardData.FirstItemId : 0);
			if (itemConfigData == null)
			{
				string message = "奖励物品配置不存在";
				string item = "ItemId";
				TotalTopUpRewardData rewardData2 = this.RewardData;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (rewardData2 != null) ? rewardData2.FirstItemId : 0);
				TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.RewardData == null)
			{
				TotalTopUpUtil.Error("奖励数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.IconPath = itemConfigData.Icon;
			int id = this.RewardData.Id;
			TotalTopUpReward? rewardConfigById = TotalTopUpConfig.Instance.GetRewardConfigById(id);
			this.PreviewContentId = (((rewardConfigById != null) ? rewardConfigById.GetValueOrDefault().PreviewContentId : null) ?? string.Empty);
			this.PreviewFunction = (ETotalTopUpPreviewFunction)((rewardConfigById != null) ? rewardConfigById.Value.PreviewFunction : 0);
			this.ClaimFunction = (ETotalTopUpClaimFunction)((rewardConfigById != null) ? rewardConfigById.Value.ClaimFunction : 0);
			this.ShowCheckItem = (rewardConfigById != null && rewardConfigById.GetValueOrDefault().ShowPreviewIcon);
			this.ShowRewardCount = ((rewardConfigById != null) ? rewardConfigById.GetValueOrDefault().ShowRewardCount : 0);
			string message2 = "初始化奖励Config";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ConfigMain", (TotalTopUpConfig.Instance == null) ? "null" : "exist");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigId", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PreviewFunction", ((rewardConfigById != null) ? new int?(rewardConfigById.GetValueOrDefault().PreviewFunction) : null) ?? 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ClaimFunction", ((rewardConfigById != null) ? new int?(rewardConfigById.GetValueOrDefault().ClaimFunction) : null) ?? 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ShowPreview", rewardConfigById != null && rewardConfigById.GetValueOrDefault().ShowPreviewIcon);
			TotalTopUpUtil.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x0603E14D RID: 254285 RVA: 0x00EFDA87 File Offset: 0x00EFBC87
		public void Claim()
		{
			this.PageViewModel.Claim(this);
		}

		// Token: 0x0603E14E RID: 254286 RVA: 0x00EFDA95 File Offset: 0x00EFBC95
		public void PreviewReward()
		{
			this.PageViewModel.Preview(this);
		}

		// Token: 0x040206BE RID: 132798
		public int ActivityId;

		// Token: 0x040206BF RID: 132799
		public string IconPath = string.Empty;

		// Token: 0x040206C0 RID: 132800
		public ETotalTopUpPreviewFunction PreviewFunction;

		// Token: 0x040206C1 RID: 132801
		public string PreviewContentId = string.Empty;

		// Token: 0x040206C2 RID: 132802
		public bool ShowCheckItem;

		// Token: 0x040206C3 RID: 132803
		public int ShowRewardCount;

		// Token: 0x040206C4 RID: 132804
		public ETotalTopUpClaimFunction ClaimFunction;

		// Token: 0x040206C5 RID: 132805
		private readonly TotalTopUpRewardData RewardData;

		// Token: 0x040206C6 RID: 132806
		private readonly TotalTopUpPageViewModel PageViewModel;

		// Token: 0x040206C7 RID: 132807
		public readonly int Index;
	}
}
