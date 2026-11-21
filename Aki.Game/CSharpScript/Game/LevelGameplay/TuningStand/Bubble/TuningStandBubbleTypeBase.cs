using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B39 RID: 23353
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandBubbleTypeBase
	{
		// Token: 0x0603970A RID: 235274 RVA: 0x0101E91C File Offset: 0x0101CB1C
		public bool GetCanInterruptBySelf()
		{
			return this.CanInterruptBySelf;
		}

		// Token: 0x0603970B RID: 235275 RVA: 0x0101E924 File Offset: 0x0101CB24
		public virtual bool TryStartBubble(bool canPlay)
		{
			return false;
		}

		// Token: 0x0603970C RID: 235276 RVA: 0x0101E928 File Offset: 0x0101CB28
		public unsafe void Init(PlayFlow playFlow)
		{
			this.PlayFlow = playFlow;
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(playFlow.FlowListName, playFlow.FlowId, playFlow.StateId);
			if (flowStateActions == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "找不到对应的剧本配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", playFlow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", playFlow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", playFlow.StateId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					ShowTalk showTalk = actionInfo.Params as ShowTalk;
					if (showTalk != null)
					{
						foreach (ITalkItem talkData in showTalk.TalkItems)
						{
							ITuningStandBubbleData tuningStandBubbleData = this.CreateBubbleData(talkData);
							if (tuningStandBubbleData != null)
							{
								this.TalkList.Add(tuningStandBubbleData);
							}
						}
					}
				}
			}
			if (this.TalkList.Count == 0)
			{
				this.PlayFlow = null;
			}
		}

		// Token: 0x0603970D RID: 235277 RVA: 0x0101EAA8 File Offset: 0x0101CCA8
		public void Interrupted()
		{
			if (this.TimerHandle != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				}
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603970E RID: 235278 RVA: 0x0101EADC File Offset: 0x0101CCDC
		protected void OnBubbleEnd()
		{
			EventSystem.Instance.Emit<ETuningStandBubbleTriggerType>(EEventName.TuningStandBubbleEnd, this.BubbleType);
		}

		// Token: 0x0603970F RID: 235279 RVA: 0x0101EAF4 File Offset: 0x0101CCF4
		public void Destroy()
		{
			this.Interrupted();
			this.PlayFlow = null;
		}

		// Token: 0x06039710 RID: 235280 RVA: 0x0101EB04 File Offset: 0x0101CD04
		[return: Nullable(2)]
		protected ITuningStandBubbleData CreateBubbleData(ITalkItem talkData)
		{
			TuningStandBubbleData tuningStandBubbleData = new TuningStandBubbleData
			{
				WaitTime = 0f
			};
			if (talkData.WaitTime != null && talkData.WaitTime.Value > 0f)
			{
				tuningStandBubbleData.WaitTime = talkData.WaitTime.Value;
			}
			ValueTuple<bool, bool, string> talkData2 = this.GetTalkData(talkData);
			bool item = talkData2.Item1;
			bool item2 = talkData2.Item2;
			string item3 = talkData2.Item3;
			if (!item)
			{
				return null;
			}
			if (item2)
			{
				tuningStandBubbleData.MainRoleTex = item3;
				tuningStandBubbleData.MainRoleTalk = talkData.TidTalk;
			}
			else
			{
				tuningStandBubbleData.FloroTex = item3;
				tuningStandBubbleData.FloroTalk = talkData.TidTalk;
			}
			if (tuningStandBubbleData.WaitTime == 0f)
			{
				tuningStandBubbleData.WaitTime = this.RemainTime;
			}
			return tuningStandBubbleData;
		}

		// Token: 0x06039711 RID: 235281 RVA: 0x0101EBC4 File Offset: 0x0101CDC4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected ValueTuple<bool, bool, string> GetTalkData(ITalkItem talkData)
		{
			Speaker? config = ConfigSpeakerById.GetConfig(talkData.WhoId.GetValueOrDefault(-1), true);
			if (config == null)
			{
				return new ValueTuple<bool, bool, string>(false, false, "");
			}
			bool flag = talkData.Name != "FLL";
			string headIconAsset = config.Value.HeadIconAsset;
			if (flag)
			{
				EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
				if ((playerGender == EPlayerGender.Female && talkData.Name == "M") || (playerGender == EPlayerGender.Male && talkData.Name == "F"))
				{
					return new ValueTuple<bool, bool, string>(false, false, "");
				}
			}
			return new ValueTuple<bool, bool, string>(true, flag, headIconAsset);
		}

		// Token: 0x06039712 RID: 235282 RVA: 0x0101EC70 File Offset: 0x0101CE70
		protected void UpdateBubble()
		{
			if (this.CurIndex >= this.TalkList.Count)
			{
				this.OnBubbleEnd();
				return;
			}
			ITuningStandBubbleData tuningStandBubbleData = this.TalkList[this.CurIndex];
			this.CurIndex++;
			EventSystem.Instance.Emit<ITuningStandBubbleData>(EEventName.TuningStandBubbleUpdate, tuningStandBubbleData);
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.UpdateBubble();
			}, (float)((long)(tuningStandBubbleData.WaitTime * 1000f)), null, null, true, 1f);
		}

		// Token: 0x0401E4E4 RID: 124132
		protected bool CanInterruptBySelf;

		// Token: 0x0401E4E5 RID: 124133
		[Nullable(2)]
		protected PlayFlow PlayFlow;

		// Token: 0x0401E4E6 RID: 124134
		protected ETuningStandBubbleTriggerType BubbleType;

		// Token: 0x0401E4E7 RID: 124135
		protected List<ITuningStandBubbleData> TalkList = new List<ITuningStandBubbleData>();

		// Token: 0x0401E4E8 RID: 124136
		[Nullable(2)]
		protected TimerHandle TimerHandle;

		// Token: 0x0401E4E9 RID: 124137
		protected int CurIndex;

		// Token: 0x0401E4EA RID: 124138
		protected float RemainTime = 2f;
	}
}
