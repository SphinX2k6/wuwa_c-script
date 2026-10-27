using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069DB RID: 27099
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandBubbleProxy
	{
		// Token: 0x060436C9 RID: 276169 RVA: 0x0107A214 File Offset: 0x01078414
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

		// Token: 0x060436CA RID: 276170 RVA: 0x0107A328 File Offset: 0x01078528
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

		// Token: 0x060436CB RID: 276171 RVA: 0x0107A3D1 File Offset: 0x010785D1
		private void OnBubbleEnd(ETuningStandBubbleTriggerType _)
		{
			this.CurPlayingType = null;
		}

		// Token: 0x060436CC RID: 276172 RVA: 0x0107A3E0 File Offset: 0x010785E0
		public void Destroy()
		{
			foreach (KeyValuePair<ETuningStandBubbleTriggerType, TuningStandBubbleTypeBase> keyValuePair in this.BubbleClassMap)
			{
				keyValuePair.Value.Destroy();
			}
			EventSystem.Instance.Remove(EEventName.TuningStandBubbleEnd, new Action<ETuningStandBubbleTriggerType>(this.OnBubbleEnd));
			this.BubbleClassMap.Clear();
		}

		// Token: 0x040232EE RID: 144110
		private readonly Dictionary<ETuningStandBubbleTriggerType, TuningStandBubbleTypeBase> BubbleClassMap = new Dictionary<ETuningStandBubbleTriggerType, TuningStandBubbleTypeBase>();

		// Token: 0x040232EF RID: 144111
		private ETuningStandBubbleTriggerType? CurPlayingType;
	}
}
