using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x0200568E RID: 22158
	public class ActivityDirectTrainData : ActivityBaseData
	{
		// Token: 0x06036AD4 RID: 223956 RVA: 0x00F41F38 File Offset: 0x00F40138
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

		// Token: 0x1700699C RID: 27036
		// (get) Token: 0x06036AD5 RID: 223957 RVA: 0x00F41F84 File Offset: 0x00F40184
		// (set) Token: 0x06036AD6 RID: 223958 RVA: 0x00F41FD4 File Offset: 0x00F401D4
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

		// Token: 0x1700699D RID: 27037
		// (get) Token: 0x06036AD7 RID: 223959 RVA: 0x00F4207F File Offset: 0x00F4027F
		public override bool RedPointShowState
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06036AD8 RID: 223960 RVA: 0x00F42082 File Offset: 0x00F40282
		protected override bool GetExDataFinishShowState()
		{
			return this.IsFinished;
		}

		// Token: 0x0401CE3E RID: 118334
		public bool IsFinished;

		// Token: 0x0401CE3F RID: 118335
		private bool? HaveDisplayedGotoRedDotInner;
	}
}
