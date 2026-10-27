using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x02006749 RID: 26441
	public class DirectTrainActivityData : ActivityBaseData
	{
		// Token: 0x06041FEB RID: 270315 RVA: 0x01001FE0 File Offset: 0x010001E0
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

		// Token: 0x06041FEC RID: 270316 RVA: 0x01002030 File Offset: 0x01000230
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

		// Token: 0x06041FED RID: 270317 RVA: 0x010020A4 File Offset: 0x010002A4
		public override bool GetExDataRedPointShowState()
		{
			DirectTrainModel instance = DirectTrainModel.Instance;
			return instance != null && instance.HasUnReadSubActivity();
		}

		// Token: 0x06041FEE RID: 270318 RVA: 0x010020B6 File Offset: 0x010002B6
		protected override bool GetExDataFinishShowState()
		{
			return false;
		}

		// Token: 0x17009664 RID: 38500
		// (get) Token: 0x06041FEF RID: 270319 RVA: 0x010020B9 File Offset: 0x010002B9
		public override bool RedPointShowState
		{
			get
			{
				return this.CheckIfInShowTime() && !base.IsHiddenByConfig() && (base.GetIfFirstOpen() || this.GetExDataRedPointShowState());
			}
		}
	}
}
