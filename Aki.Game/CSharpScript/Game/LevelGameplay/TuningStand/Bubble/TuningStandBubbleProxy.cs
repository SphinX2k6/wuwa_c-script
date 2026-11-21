using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B37 RID: 23351
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandBubbleProxy
	{
		// Token: 0x06039705 RID: 235269 RVA: 0x0101E6C8 File Offset: 0x0101C8C8
		public TuningStandBubbleProxy(IList<ITuningStandBubbleConfig> bubbleDataList)
		{
			this.BubbleClassMap[ETuningStandBubbleTriggerType.Enter] = new TuningStandBubbleTypeEnter();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.StartLink] = new TuningStandBubbleTypeStartLink();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.InvalidLink] = new TuningStandBubbleTypeInValidLink();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.LinkUp] = new TuningStandBubbleTypeLinkUp();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.LinkMiss] = new TuningStandBubbleTypeLinkMiss();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.LinkComplete] = new TuningStandBubbleTypeLinkComplete();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.Reset] = new TuningStandBubbleTypeReset();
			this.BubbleClassMap[ETuningStandBubbleTriggerType.TooLong] = new TuningStandBubbleTypeTooLong();
			foreach (ITuningStandBubbleConfig tuningStandBubbleConfig in bubbleDataList)
			{
				this.BubbleClassMap[tuningStandBubbleConfig.TriggerType].Init(tuningStandBubbleConfig.Flow);
			}
			EventSystem.Instance.Add<ETuningStandBubbleTriggerType>(EEventName.TuningStandBubbleEnd, new Action<ETuningStandBubbleTriggerType>(this.OnBubbleEnd));
		}

		// Token: 0x06039706 RID: 235270 RVA: 0x0101E7DC File Offset: 0x0101C9DC
		public bool TryStartBubbleFlow(ETuningStandBubbleTriggerType type)
		{
			TuningStandBubbleTypeBase tuningStandBubbleTypeBase;
			if (!this.BubbleClassMap.TryGetValue(type, out tuningStandBubbleTypeBase))
			{
				return false;
			}
			ETuningStandBubbleTriggerType? curPlayingType = this.CurPlayingType;
			if ((curPlayingType.GetValueOrDefault() == type & curPlayingType != null) && !tuningStandBubbleTypeBase.GetCanInterruptBySelf())
			{
				return false;
			}
			TuningStandBubbleTypeBase tuningStandBubbleTypeBase2 = tuningStandBubbleTypeBase;
			curPlayingType = this.CurPlayingType;
			ETuningStandBubbleTriggerType etuningStandBubbleTriggerType = ETuningStandBubbleTriggerType.Enter;
			if (tuningStandBubbleTypeBase2.TryStartBubble(!(curPlayingType.GetValueOrDefault() == etuningStandBubbleTriggerType & curPlayingType != null)))
			{
				if (this.CurPlayingType != null)
				{
					TuningStandBubbleTypeBase tuningStandBubbleTypeBase3 = this.BubbleClassMap[this.CurPlayingType.Value];
					if (tuningStandBubbleTypeBase3 != null)
					{
						tuningStandBubbleTypeBase3.Interrupted();
					}
				}
				this.CurPlayingType = new ETuningStandBubbleTriggerType?(type);
				return true;
			}
			return false;
		}

		// Token: 0x06039707 RID: 235271 RVA: 0x0101E885 File Offset: 0x0101CA85
		private void OnBubbleEnd(ETuningStandBubbleTriggerType _)
		{
			this.CurPlayingType = null;
		}

		// Token: 0x06039708 RID: 235272 RVA: 0x0101E894 File Offset: 0x0101CA94
		public void Destroy()
		{
			foreach (KeyValuePair<ETuningStandBubbleTriggerType, TuningStandBubbleTypeBase> keyValuePair in this.BubbleClassMap)
			{
				keyValuePair.Value.Destroy();
			}
			EventSystem.Instance.Remove(EEventName.TuningStandBubbleEnd, new Action<ETuningStandBubbleTriggerType>(this.OnBubbleEnd));
			this.BubbleClassMap.Clear();
		}

		// Token: 0x0401E4DE RID: 124126
		private readonly Dictionary<ETuningStandBubbleTriggerType, TuningStandBubbleTypeBase> BubbleClassMap = new Dictionary<ETuningStandBubbleTriggerType, TuningStandBubbleTypeBase>();

		// Token: 0x0401E4DF RID: 124127
		private ETuningStandBubbleTriggerType? CurPlayingType;
	}
}
