using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x0200673E RID: 26430
	public class ActivityDirectTrainData : ActivityBaseData
	{
		// Token: 0x06041F88 RID: 270216 RVA: 0x01000B88 File Offset: 0x00FFED88
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			ThroughTrainActivityData throughTrainActivityData = data.ThroughTrainActivityData;
			if (throughTrainActivityData != null)
			{
				this.IsFinished = throughTrainActivityData.IsFinish;
			}
			EventSystem.Instance.Emit(EEventName.ActivityDirectTrainDataUpdate);
			EventSystem.Instance.Emit<int>(EEventName.ActivityDirectTrainRedDotUpdate, base.Id);
		}

		// Token: 0x1700965D RID: 38493
		// (get) Token: 0x06041F89 RID: 270217 RVA: 0x01000BD4 File Offset: 0x00FFEDD4
		// (set) Token: 0x06041F8A RID: 270218 RVA: 0x01000C24 File Offset: 0x00FFEE24
		public bool HaveDisplayedGotoRedDot
		{
			get
			{
				if (this.HaveDisplayedGotoRedDotInner == null)
				{
					HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.DirectTrainGotoRedDotHaveDisplayedByActId, null) ?? new HashSet<int>();
					this.HaveDisplayedGotoRedDotInner = new bool?(hashSet.Contains(base.Id));
				}
				return this.HaveDisplayedGotoRedDotInner.Value;
			}
			set
			{
				bool? haveDisplayedGotoRedDotInner = this.HaveDisplayedGotoRedDotInner;
				if (!(haveDisplayedGotoRedDotInner.GetValueOrDefault() == value & haveDisplayedGotoRedDotInner != null))
				{
					if (base.IsUnLock() || ActivityDirectTrainHelper.IsProOpen)
					{
						HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.DirectTrainGotoRedDotHaveDisplayedByActId, null) ?? new HashSet<int>();
						if (value)
						{
							hashSet.Add(base.Id);
						}
						else
						{
							hashSet.Remove(base.Id);
						}
						LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.DirectTrainGotoRedDotHaveDisplayedByActId, hashSet);
					}
					EventSystem.Instance.Emit<int>(EEventName.ActivityDirectTrainRedDotUpdate, base.Id);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				}
				this.HaveDisplayedGotoRedDotInner = new bool?(value);
			}
		}

		// Token: 0x1700965E RID: 38494
		// (get) Token: 0x06041F8B RID: 270219 RVA: 0x01000CCF File Offset: 0x00FFEECF
		public override bool RedPointShowState
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06041F8C RID: 270220 RVA: 0x01000CD2 File Offset: 0x00FFEED2
		protected override bool GetExDataFinishShowState()
		{
			return this.IsFinished;
		}

		// Token: 0x040225E5 RID: 140773
		public bool IsFinished;

		// Token: 0x040225E6 RID: 140774
		private bool? HaveDisplayedGotoRedDotInner;
	}
}
