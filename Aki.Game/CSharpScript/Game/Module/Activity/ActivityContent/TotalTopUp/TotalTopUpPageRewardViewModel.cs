using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F81 RID: 20353
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPageRewardViewModel
	{
		// Token: 0x060330E0 RID: 209120 RVA: 0x00E4F3F4 File Offset: 0x00E4D5F4
		public TotalTopUpPageRewardViewModel(TotalTopUpRewardData rewardData, TotalTopUpPageViewModel pageViewModel, int index = 0)
		{
			this.RewardData = rewardData;
			this.PageViewModel = pageViewModel;
			this.Index = index;
			TotalTopUpData actData = this.PageViewModel.ActData;
			this.ActivityId = ((actData != null) ? actData.Id : 0);
		}

		// Token: 0x170063C0 RID: 25536
		// (get) Token: 0x060330E1 RID: 209121 RVA: 0x00E4F44F File Offset: 0x00E4D64F
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

		// Token: 0x170063C1 RID: 25537
		// (get) Token: 0x060330E2 RID: 209122 RVA: 0x00E4F462 File Offset: 0x00E4D662
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

		// Token: 0x170063C2 RID: 25538
		// (get) Token: 0x060330E3 RID: 209123 RVA: 0x00E4F475 File Offset: 0x00E4D675
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

		// Token: 0x170063C3 RID: 25539
		// (get) Token: 0x060330E4 RID: 209124 RVA: 0x00E4F488 File Offset: 0x00E4D688
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

		// Token: 0x170063C4 RID: 25540
		// (get) Token: 0x060330E5 RID: 209125 RVA: 0x00E4F49B File Offset: 0x00E4D69B
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

		// Token: 0x060330E6 RID: 209126 RVA: 0x00E4F4B0 File Offset: 0x00E4D6B0
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

		// Token: 0x060330E7 RID: 209127 RVA: 0x00E4F73F File Offset: 0x00E4D93F
		public void Claim()
		{
			this.PageViewModel.Claim(this);
		}

		// Token: 0x060330E8 RID: 209128 RVA: 0x00E4F74D File Offset: 0x00E4D94D
		public void PreviewReward()
		{
			this.PageViewModel.Preview(this);
		}

		// Token: 0x0401B190 RID: 110992
		public int ActivityId;

		// Token: 0x0401B191 RID: 110993
		public string IconPath = string.Empty;

		// Token: 0x0401B192 RID: 110994
		public ETotalTopUpPreviewFunction PreviewFunction;

		// Token: 0x0401B193 RID: 110995
		public string PreviewContentId = string.Empty;

		// Token: 0x0401B194 RID: 110996
		public bool ShowCheckItem;

		// Token: 0x0401B195 RID: 110997
		public int ShowRewardCount;

		// Token: 0x0401B196 RID: 110998
		public ETotalTopUpClaimFunction ClaimFunction;

		// Token: 0x0401B197 RID: 110999
		private readonly TotalTopUpRewardData RewardData;

		// Token: 0x0401B198 RID: 111000
		private readonly TotalTopUpPageViewModel PageViewModel;

		// Token: 0x0401B199 RID: 111001
		public readonly int Index;
	}
}
