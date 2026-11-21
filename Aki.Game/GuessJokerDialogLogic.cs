using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;

// Token: 0x020004E3 RID: 1251
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerDialogLogic
{
	// Token: 0x06003DF3 RID: 15859 RVA: 0x0015DC9B File Offset: 0x0015BE9B
	public void InitData(IGuessJokerDialogData data)
	{
		this.Data = data;
	}

	// Token: 0x06003DF4 RID: 15860 RVA: 0x0015DCA4 File Offset: 0x0015BEA4
	public void PlayDialog(ITalkItemDialog talkData, [Nullable(2)] Action finishCallback = null)
	{
		GuessJokerDialogLogic.<>c__DisplayClass7_0 CS$<>8__locals1 = new GuessJokerDialogLogic.<>c__DisplayClass7_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.Data == null)
		{
			global::Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJokerDialogLogic未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (finishCallback != null)
			{
				finishCallback();
			}
			return;
		}
		GuessJokerDialogLogic.<>c__DisplayClass7_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.DialogVersion + 1;
		this.DialogVersion = num;
		CS$<>8__locals2.currentVersion = num;
		this.TalkData = talkData;
		this.FinishCallback = finishCallback;
		EGuessJokerPlayerType playerType = this.GetPlayerType();
		string tidTalk = talkData.TidTalk;
		if (this.Data.GetDialogText != null)
		{
			UUIText uuitext = this.Data.GetDialogText(playerType);
			if (uuitext != null)
			{
				uuitext.ShowTextNew(tidTalk);
			}
		}
		CS$<>8__locals1.isStartOrVoiceFinish = false;
		if (this.Data.OnDialogStart != null)
		{
			this.Data.OnDialogStart(playerType, tidTalk, new Action(CS$<>8__locals1.<PlayDialog>g__OnAnimComplete|0));
		}
		else if (this.Data.GetDialogItem != null)
		{
			UUIItem uuiitem = this.Data.GetDialogItem(playerType);
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
				CS$<>8__locals1.isStartOrVoiceFinish = true;
			}
		}
		if (talkData.WhoId.GetValueOrDefault() != 750088 && talkData.WhoId.GetValueOrDefault() != 701052)
		{
			this.PlayMouthAnim(talkData);
		}
		PlotAudio? config = ConfigPlotAudioById.GetConfig(talkData.TidTalk, true);
		if (config == null)
		{
			this.OnDialogEnd();
			return;
		}
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
		this.PlotPlayEventResult = AudioSystem.Instance.PostEvent("play_vo_plot_review_log", null, new PostEventArgs?(new PostEventArgs
		{
			ExternalSourceName = "external_plot_review_log_voice",
			ExternalSourceMediaName = externalSourcesMediaName,
			CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				if (CS$<>8__locals1.currentVersion != CS$<>8__locals1.<>4__this.DialogVersion)
				{
					return;
				}
				if (callbackType == EAkCallbackType.EndOfEvent)
				{
					if (!CS$<>8__locals1.isStartOrVoiceFinish)
					{
						CS$<>8__locals1.isStartOrVoiceFinish = true;
						return;
					}
					CS$<>8__locals1.<>4__this.OnDialogEnd();
				}
			}
		}));
	}

	// Token: 0x06003DF5 RID: 15861 RVA: 0x0015DE7C File Offset: 0x0015C07C
	private void OnDialogEnd()
	{
		if (this.Data == null || this.TalkData == null)
		{
			Action finishCallback = this.FinishCallback;
			if (finishCallback != null)
			{
				finishCallback();
			}
			this.FinishCallback = null;
			return;
		}
		EGuessJokerPlayerType playerType = this.GetPlayerType();
		if (this.Data.OnDialogEnd != null)
		{
			this.Data.OnDialogEnd(playerType, new Action(this.<OnDialogEnd>g__OnComplete|8_0));
			return;
		}
		if (this.Data.GetDialogItem != null)
		{
			UUIItem uuiitem = this.Data.GetDialogItem(playerType);
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(false);
			}
			this.<OnDialogEnd>g__OnComplete|8_0();
			return;
		}
		this.<OnDialogEnd>g__OnComplete|8_0();
	}

	// Token: 0x06003DF6 RID: 15862 RVA: 0x0015DF1C File Offset: 0x0015C11C
	private EGuessJokerPlayerType GetPlayerType()
	{
		if (this.TalkData == null)
		{
			return EGuessJokerPlayerType.Ai;
		}
		if (this.TalkData.WhoId.GetValueOrDefault() != 750088 && this.TalkData.WhoId.GetValueOrDefault() != 701052)
		{
			return EGuessJokerPlayerType.Ai;
		}
		return EGuessJokerPlayerType.Me;
	}

	// Token: 0x06003DF7 RID: 15863 RVA: 0x0015DF6C File Offset: 0x0015C16C
	private void PlayMouthAnim(ITalkItemDialog talkItem)
	{
		GuessJokerDialogLogic.<>c__DisplayClass10_0 CS$<>8__locals1 = new GuessJokerDialogLogic.<>c__DisplayClass10_0();
		CS$<>8__locals1.<>4__this = this;
		if (talkItem.PlayVoice.GetValueOrDefault() && talkItem.TidTalk != null && !string.IsNullOrEmpty(talkItem.TidTalk) && !talkItem.NoMouthAnim.GetValueOrDefault())
		{
			ETalkItemType? type = talkItem.Type;
			ETalkItemType etalkItemType = ETalkItemType.Talk;
			if (type.GetValueOrDefault() == etalkItemType & type != null)
			{
				ITalkItemStyle style = talkItem.Style;
				if (style != null && style.Type == ETalkItemStyle.InnerVoice)
				{
					return;
				}
				CS$<>8__locals1.entityId = GuessJokerGamePlayModel.Instance.EntityId;
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(CS$<>8__locals1.entityId);
				if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
				{
					return;
				}
				GuessJokerDialogLogic.<>c__DisplayClass10_0 CS$<>8__locals2 = CS$<>8__locals1;
				CharacterAnimationComponent component = entityByPbDataId.Entity.GetComponent<CharacterAnimationComponent>();
				CS$<>8__locals2.curAnimInst = ((component != null) ? component.MainAnimInstance : null);
				if (CS$<>8__locals1.curAnimInst == null)
				{
					return;
				}
				PlotAudio? config = ConfigPlotAudioById.GetConfig(talkItem.TidTalk, true);
				if (config == null || !config.Value.GenLipSync)
				{
					return;
				}
				if (this.MouthAnimLoadingId != -1)
				{
					ResourceSystem.Instance.CancelAsyncLoad(this.MouthAnimLoadingId);
					this.MouthAnimLoadingId = -1;
				}
				string audioMouthAnimName = PlotAudioModel.Instance.GetAudioMouthAnimName(config.Value);
				this.MouthAnimLoadingId = ResourceSystem.Instance.LoadAsync<UAnimSequence>(audioMouthAnimName, delegate([Nullable(2)] UAnimSequence anim, string path)
				{
					CS$<>8__locals1.<>4__this.MouthAnimLoadingId = -1;
					if (anim == null || !anim.IsValid())
					{
						return;
					}
					CS$<>8__locals1.curAnimInst.StopSlotAnimation(0f, SequenceDefine.ABP_Mouth_Slot_Name);
					UAnimMontage animMontage = CS$<>8__locals1.curAnimInst.PlaySlotAnimationAsDynamicMontage(anim, SequenceDefine.ABP_Mouth_Slot_Name, 0f, 0f, 1f, 1, -1f, 0f, false);
					EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(CS$<>8__locals1.entityId);
					if (((entityByPbDataId2 != null) ? entityByPbDataId2.Entity : null) != null)
					{
						CommonNpcPerformComponent component2 = entityByPbDataId2.Entity.GetComponent<CommonNpcPerformComponent>();
						NpcFacialExpressionController npcFacialExpressionController = (component2 != null) ? component2.ExpressionController : null;
						if (npcFacialExpressionController == null)
						{
							return;
						}
						npcFacialExpressionController.ChangeFaceForMouthMontage(animMontage);
					}
				}, 100, "js_undefined");
				return;
			}
		}
	}

	// Token: 0x06003DF8 RID: 15864 RVA: 0x0015E0CC File Offset: 0x0015C2CC
	public void Clear()
	{
		this.DialogVersion++;
		AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
		{
			TransitionDuration = new int?(0)
		}));
		if (this.MouthAnimLoadingId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MouthAnimLoadingId);
		}
		EGuessJokerPlayerType playerType = this.GetPlayerType();
		IGuessJokerDialogData data = this.Data;
		if (data != null)
		{
			Action<EGuessJokerPlayerType> onCancelDialogStartAnim = data.OnCancelDialogStartAnim;
			if (onCancelDialogStartAnim != null)
			{
				onCancelDialogStartAnim(playerType);
			}
		}
		this.MouthAnimLoadingId = -1;
		this.PlotPlayEventResult = 0;
		this.TalkData = null;
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		this.FinishCallback = null;
	}

	// Token: 0x06003DFA RID: 15866 RVA: 0x0015E18C File Offset: 0x0015C38C
	[CompilerGenerated]
	private void <OnDialogEnd>g__OnComplete|8_0()
	{
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		this.FinishCallback = null;
	}

	// Token: 0x0400319C RID: 12700
	[Nullable(2)]
	private IGuessJokerDialogData Data;

	// Token: 0x0400319D RID: 12701
	[Nullable(2)]
	private ITalkItemDialog TalkData;

	// Token: 0x0400319E RID: 12702
	private int PlotPlayEventResult;

	// Token: 0x0400319F RID: 12703
	private int MouthAnimLoadingId = -1;

	// Token: 0x040031A0 RID: 12704
	[Nullable(2)]
	private Action FinishCallback;

	// Token: 0x040031A1 RID: 12705
	private int DialogVersion;
}
