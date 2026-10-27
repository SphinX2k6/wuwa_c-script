using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069DD RID: 27101
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandBubbleTypeBase
	{
		// Token: 0x060436CE RID: 276174 RVA: 0x0107A468 File Offset: 0x01078668
		public bool GetCanInterruptBySelf()
		{
			return this.CanInterruptBySelf;
		}

		// Token: 0x060436CF RID: 276175 RVA: 0x0107A470 File Offset: 0x01078670
		public virtual bool TryStartBubble(bool canPlay)
		{
			return false;
		}

		// Token: 0x060436D0 RID: 276176 RVA: 0x0107A474 File Offset: 0x01078674
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

		// Token: 0x060436D1 RID: 276177 RVA: 0x0107A5F4 File Offset: 0x010787F4
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

		// Token: 0x060436D2 RID: 276178 RVA: 0x0107A628 File Offset: 0x01078828
		protected void OnBubbleEnd()
		{
			EventSystem.Instance.Emit<ETuningStandBubbleTriggerType>(EEventName.TuningStandBubbleEnd, this.BubbleType);
		}

		// Token: 0x060436D3 RID: 276179 RVA: 0x0107A640 File Offset: 0x01078840
		public void Destroy()
		{
			this.Interrupted();
			this.PlayFlow = null;
		}

		// Token: 0x060436D4 RID: 276180 RVA: 0x0107A650 File Offset: 0x01078850
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

		// Token: 0x060436D5 RID: 276181 RVA: 0x0107A710 File Offset: 0x01078910
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

		// Token: 0x060436D6 RID: 276182 RVA: 0x0107A7BC File Offset: 0x010789BC
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

		// Token: 0x040232F4 RID: 144116
		protected bool CanInterruptBySelf;

		// Token: 0x040232F5 RID: 144117
		[Nullable(2)]
		protected PlayFlow PlayFlow;

		// Token: 0x040232F6 RID: 144118
		protected ETuningStandBubbleTriggerType BubbleType;

		// Token: 0x040232F7 RID: 144119
		protected List<ITuningStandBubbleData> TalkList = new List<ITuningStandBubbleData>();

		// Token: 0x040232F8 RID: 144120
		[Nullable(2)]
		protected TimerHandle TimerHandle;

		// Token: 0x040232F9 RID: 144121
		protected int CurIndex;

		// Token: 0x040232FA RID: 144122
		protected float RemainTime = 2f;
	}
}
