using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x02005843 RID: 22595
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonH5Data : ActivityBaseData
	{
		// Token: 0x06037B82 RID: 228226 RVA: 0x00F93E00 File Offset: 0x00F92000
		protected override void PhraseEx(ActivityData data)
		{
			H5ViewActivityData h5ViewActivityData = data.H5ViewActivityData;
			if (h5ViewActivityData != null)
			{
				this.ChangeServerRedDotState(h5ViewActivityData.RedDot);
				this.RewardClaimState = h5ViewActivityData.AllRewardClaimed;
			}
		}

		// Token: 0x06037B83 RID: 228227 RVA: 0x00F93E30 File Offset: 0x00F92030
		public string GetBgPrefabPath()
		{
			H5JumpActivity? config = ConfigH5JumpActivityById.GetConfig(base.Id, true);
			return ((config != null) ? config.GetValueOrDefault().BgPath : null) ?? "";
		}

		// Token: 0x06037B84 RID: 228228 RVA: 0x00F93E6E File Offset: 0x00F9206E
		public void ChangeServerRedDotState(bool state)
		{
			this.RedDotInternal = state;
		}

		// Token: 0x06037B85 RID: 228229 RVA: 0x00F93E77 File Offset: 0x00F92077
		public bool GetRewardClaimState()
		{
			return this.RewardClaimState;
		}

		// Token: 0x06037B86 RID: 228230 RVA: 0x00F93E7F File Offset: 0x00F9207F
		public bool GetClickRedDotState()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x06037B87 RID: 228231 RVA: 0x00F93E98 File Offset: 0x00F92098
		public void SetCurrentLoginClickState(bool state)
		{
			this.CurrentLoginClickState = state;
		}

		// Token: 0x06037B88 RID: 228232 RVA: 0x00F93EA1 File Offset: 0x00F920A1
		public void SaveClickRedDotState()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
		}

		// Token: 0x06037B89 RID: 228233 RVA: 0x00F93EB7 File Offset: 0x00F920B7
		public override bool GetExDataRedPointShowState()
		{
			return this.GetClickRedDotState() || (this.RedDotInternal && !this.CurrentLoginClickState);
		}

		// Token: 0x06037B8A RID: 228234 RVA: 0x00F93ED6 File Offset: 0x00F920D6
		protected override bool GetExDataFinishShowState()
		{
			return this.RewardClaimState;
		}

		// Token: 0x06037B8B RID: 228235 RVA: 0x00F93EE0 File Offset: 0x00F920E0
		[NullableContext(2)]
		public string GetRootUrl()
		{
			if (this.GmUrl != null && this.GmUrl != "")
			{
				return this.GmUrl;
			}
			H5JumpActivity? config = ConfigH5JumpActivityById.GetConfig(base.Id, true);
			if (!KuroSdkController.Instance.GetIfGlobalSdk())
			{
				if (config == null)
				{
					return null;
				}
				return config.GetValueOrDefault().CNRootUrl;
			}
			else
			{
				if (config == null)
				{
					return null;
				}
				return config.GetValueOrDefault().OverseaRootUrl;
			}
		}

		// Token: 0x0401D688 RID: 120456
		[Nullable(2)]
		public string GmUrl;

		// Token: 0x0401D689 RID: 120457
		private bool RedDotInternal;

		// Token: 0x0401D68A RID: 120458
		private bool CurrentLoginClickState;

		// Token: 0x0401D68B RID: 120459
		private bool RewardClaimState;

		// Token: 0x0401D68C RID: 120460
		private const int CLICKKEY = 1;
	}
}
