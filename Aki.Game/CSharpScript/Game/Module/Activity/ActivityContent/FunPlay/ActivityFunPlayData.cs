using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054EA RID: 21738
	public class ActivityFunPlayData : ActivityBaseData
	{
		// Token: 0x06035DE6 RID: 220646 RVA: 0x00F0C100 File Offset: 0x00F0A300
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			FunPlayActivityInfo funPlayActivityInfo = data.FunPlayActivityInfo;
			RepeatedField<FunPlayChallengeInfo> repeatedField = (funPlayActivityInfo != null) ? funPlayActivityInfo.FunPlayChallengeInfos : null;
			if (repeatedField == null)
			{
				return;
			}
			ActivityFunPlayModel.Instance.CreateChallengeData(repeatedField.ToArray<FunPlayChallengeInfo>(), base.Id);
		}

		// Token: 0x06035DE7 RID: 220647 RVA: 0x00F0C13A File Offset: 0x00F0A33A
		public bool CheckRedDot()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return this.CheckPreQuestUnFinishRedDot();
			}
			return this.CheckPreQuestFinishedRedDot();
		}

		// Token: 0x06035DE8 RID: 220648 RVA: 0x00F0C151 File Offset: 0x00F0A351
		public bool CheckPreQuestFinishedRedDot()
		{
			return this.GetClickRedDotState(100) || ActivityFunPlayModel.Instance.GetHasInternalRedDot();
		}

		// Token: 0x06035DE9 RID: 220649 RVA: 0x00F0C169 File Offset: 0x00F0A369
		public bool CheckPreQuestUnFinishRedDot()
		{
			return this.GetClickRedDotState(200);
		}

		// Token: 0x06035DEA RID: 220650 RVA: 0x00F0C17B File Offset: 0x00F0A37B
		public bool GetClickRedDotState(int key)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, key, 0, 0) == 0;
		}

		// Token: 0x06035DEB RID: 220651 RVA: 0x00F0C194 File Offset: 0x00F0A394
		public void SetClickRedDotState()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
			ActivityModel.Instance.SaveActivityData(base.Id, 200, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06035DEC RID: 220652 RVA: 0x00F0C1E4 File Offset: 0x00F0A3E4
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckRedDot();
		}

		// Token: 0x06035DED RID: 220653 RVA: 0x00F0C1EC File Offset: 0x00F0A3EC
		protected override bool GetExDataFinishShowState()
		{
			return base.IsUnLock() && base.GetPreGuideQuestFinishState() && ActivityFunPlayModel.Instance.IsAllRewardClaimed();
		}

		// Token: 0x0401C7C2 RID: 116674
		public const int CLICKKEY = 100;

		// Token: 0x0401C7C3 RID: 116675
		public const int CLICKQUESTKEY = 200;
	}
}
