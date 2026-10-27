using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x020068F3 RID: 26867
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonH5Data : ActivityBaseData
	{
		// Token: 0x0604302A RID: 274474 RVA: 0x010527D8 File Offset: 0x010509D8
		protected override void PhraseEx(ActivityData data)
		{
			H5ViewActivityData h5ViewActivityData = data.H5ViewActivityData;
			if (h5ViewActivityData != null)
			{
				this.ChangeServerRedDotState(h5ViewActivityData.RedDot);
				this.RewardClaimState = h5ViewActivityData.AllRewardClaimed;
			}
		}

		// Token: 0x0604302B RID: 274475 RVA: 0x01052808 File Offset: 0x01050A08
		public string GetBgPrefabPath()
		{
			H5JumpActivity? config = ConfigH5JumpActivityById.GetConfig(base.Id, true);
			return ((config != null) ? config.GetValueOrDefault().BgPath : null) ?? "";
		}

		// Token: 0x0604302C RID: 274476 RVA: 0x01052846 File Offset: 0x01050A46
		public void ChangeServerRedDotState(bool state)
		{
			this.RedDotInternal = state;
		}

		// Token: 0x0604302D RID: 274477 RVA: 0x0105284F File Offset: 0x01050A4F
		public bool GetRewardClaimState()
		{
			return this.RewardClaimState;
		}

		// Token: 0x0604302E RID: 274478 RVA: 0x01052857 File Offset: 0x01050A57
		public bool GetClickRedDotState()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x0604302F RID: 274479 RVA: 0x01052870 File Offset: 0x01050A70
		public void SetCurrentLoginClickState(bool state)
		{
			this.CurrentLoginClickState = state;
		}

		// Token: 0x06043030 RID: 274480 RVA: 0x01052879 File Offset: 0x01050A79
		public void SaveClickRedDotState()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
		}

		// Token: 0x06043031 RID: 274481 RVA: 0x0105288F File Offset: 0x01050A8F
		public override bool GetExDataRedPointShowState()
		{
			return this.GetClickRedDotState() || (this.RedDotInternal && !this.CurrentLoginClickState);
		}

		// Token: 0x06043032 RID: 274482 RVA: 0x010528AE File Offset: 0x01050AAE
		protected override bool GetExDataFinishShowState()
		{
			return this.RewardClaimState;
		}

		// Token: 0x06043033 RID: 274483 RVA: 0x010528B8 File Offset: 0x01050AB8
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

		// Token: 0x04022E2C RID: 142892
		[Nullable(2)]
		public string GmUrl;

		// Token: 0x04022E2D RID: 142893
		private bool RedDotInternal;

		// Token: 0x04022E2E RID: 142894
		private bool CurrentLoginClickState;

		// Token: 0x04022E2F RID: 142895
		private bool RewardClaimState;

		// Token: 0x04022E30 RID: 142896
		private const int CLICKKEY = 1;
	}
}
