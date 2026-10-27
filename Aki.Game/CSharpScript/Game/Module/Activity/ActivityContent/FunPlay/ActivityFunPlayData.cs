using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x0200656C RID: 25964
	public class ActivityFunPlayData : ActivityBaseData
	{
		// Token: 0x06041121 RID: 266529 RVA: 0x00FC511C File Offset: 0x00FC331C
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

		// Token: 0x06041122 RID: 266530 RVA: 0x00FC5156 File Offset: 0x00FC3356
		public bool CheckRedDot()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return this.CheckPreQuestUnFinishRedDot();
			}
			return this.CheckPreQuestFinishedRedDot();
		}

		// Token: 0x06041123 RID: 266531 RVA: 0x00FC516D File Offset: 0x00FC336D
		public bool CheckPreQuestFinishedRedDot()
		{
			return this.GetClickRedDotState(100) || ActivityFunPlayModel.Instance.GetHasInternalRedDot();
		}

		// Token: 0x06041124 RID: 266532 RVA: 0x00FC5185 File Offset: 0x00FC3385
		public bool CheckPreQuestUnFinishRedDot()
		{
			return this.GetClickRedDotState(200);
		}

		// Token: 0x06041125 RID: 266533 RVA: 0x00FC5197 File Offset: 0x00FC3397
		public bool GetClickRedDotState(int key)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, key, 0, 0) == 0;
		}

		// Token: 0x06041126 RID: 266534 RVA: 0x00FC51B0 File Offset: 0x00FC33B0
		public void SetClickRedDotState()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
			ActivityModel.Instance.SaveActivityData(base.Id, 200, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06041127 RID: 266535 RVA: 0x00FC5200 File Offset: 0x00FC3400
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckRedDot();
		}

		// Token: 0x06041128 RID: 266536 RVA: 0x00FC5208 File Offset: 0x00FC3408
		protected override bool GetExDataFinishShowState()
		{
			return base.IsUnLock() && base.GetPreGuideQuestFinishState() && ActivityFunPlayModel.Instance.IsAllRewardClaimed();
		}

		// Token: 0x04021E91 RID: 138897
		public const int CLICKKEY = 100;

		// Token: 0x04021E92 RID: 138898
		public const int CLICKQUESTKEY = 200;
	}
}
