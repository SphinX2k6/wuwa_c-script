using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x02005699 RID: 22169
	public class DirectTrainActivityData : ActivityBaseData
	{
		// Token: 0x06036B3A RID: 224058 RVA: 0x00F433D4 File Offset: 0x00F415D4
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			ThroughTrainSummaryActivityData throughTrainSummaryActivityData = data.ThroughTrainSummaryActivityData;
			RepeatedField<int> repeatedField = (throughTrainSummaryActivityData != null) ? throughTrainSummaryActivityData.ActivityIds : null;
			DirectTrainModel instance = DirectTrainModel.Instance;
			if (instance != null)
			{
				instance.SetMainSubActivityIds(repeatedField);
			}
			EventSystem.Instance.Emit(EEventName.ActivityDirectTrainDataUpdate);
			if (this.IsAllSubActivityFinishedOrAbsent(repeatedField))
			{
				base.ForceClose();
			}
		}

		// Token: 0x06036B3B RID: 224059 RVA: 0x00F43424 File Offset: 0x00F41624
		[NullableContext(2)]
		private bool IsAllSubActivityFinishedOrAbsent(IReadOnlyList<int> subActivityIds)
		{
			if (subActivityIds == null || subActivityIds.Count == 0)
			{
				return true;
			}
			foreach (int id in subActivityIds)
			{
				ActivityModel instance = ActivityModel.Instance;
				ActivityBaseData activityBaseData = (instance != null) ? instance.GetActivityById(id) : null;
				if (activityBaseData != null && !activityBaseData.FinishShowState)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06036B3C RID: 224060 RVA: 0x00F43498 File Offset: 0x00F41698
		public override bool GetExDataRedPointShowState()
		{
			DirectTrainModel instance = DirectTrainModel.Instance;
			return instance != null && instance.HasUnReadSubActivity();
		}

		// Token: 0x06036B3D RID: 224061 RVA: 0x00F434AA File Offset: 0x00F416AA
		protected override bool GetExDataFinishShowState()
		{
			return false;
		}

		// Token: 0x170069A3 RID: 27043
		// (get) Token: 0x06036B3E RID: 224062 RVA: 0x00F434AD File Offset: 0x00F416AD
		public override bool RedPointShowState
		{
			get
			{
				return this.CheckIfInShowTime() && !base.IsHiddenByConfig() && (base.GetIfFirstOpen() || this.GetExDataRedPointShowState());
			}
		}
	}
}
