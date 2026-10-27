using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.Plot;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02003204 RID: 12804
[NullableContext(1)]
[Nullable(0)]
public class NpcFlowLogic : CharacterFlowLogic
{
	// Token: 0x0601BA11 RID: 113169 RVA: 0x0079730C File Offset: 0x0079550C
	public NpcFlowLogic(BaseActorComponent actorComp, BubbleComponent bubbleData) : base(actorComp, bubbleData)
	{
	}

	// Token: 0x17002633 RID: 9779
	// (get) Token: 0x0601BA12 RID: 113170 RVA: 0x00797316 File Offset: 0x00795516
	public NpcRedDotFlowLogic RedDotLogic
	{
		get
		{
			if (this.RedDotInternal == null)
			{
				this.RedDotInternal = new NpcRedDotFlowLogic();
			}
			return this.RedDotInternal;
		}
	}

	// Token: 0x0601BA13 RID: 113171 RVA: 0x00797331 File Offset: 0x00795531
	protected override void ResetFlowState()
	{
		base.ResetFlowState();
		this.RedDotLogic.ManualControlRedDotActive(false, false);
	}

	// Token: 0x0601BA14 RID: 113172 RVA: 0x00797348 File Offset: 0x00795548
	protected override void PlayTalk(int id)
	{
		if (id < this.CurrentTalkItems.Count && this.DynamicFlowData != null && this.DynamicFlowData.RedDot != null)
		{
			this.RedDotLogic.ManualControlRedDotActive(true, this.DynamicFlowData.RedDot.Value);
		}
		base.PlayTalk(id);
	}

	// Token: 0x0601BA15 RID: 113173 RVA: 0x007973A8 File Offset: 0x007955A8
	protected unsafe override bool HandleTalkAction([Nullable(2)] Entity entity, ITalkItem config)
	{
		if (entity == null)
		{
			return false;
		}
		this.PlayAkEvent((config != null) ? config.TalkAkEvent : null);
		this.IsAudioLoading = false;
		if (config.Montage != null)
		{
			NpcFlowComponent component = entity.GetComponent<NpcFlowComponent>();
			if (component != null)
			{
				component.TryPlayMontage(config.Montage.ActionMontage.Path);
			}
		}
		PlotAudio? plotAudio = config.PlayVoice.GetValueOrDefault() ? ConfigPlotAudioById.GetConfig(config.TidTalk, true) : null;
		if (plotAudio != null)
		{
			this.HandleNormalAudio(plotAudio.Value, config, entity);
			return true;
		}
		if (config.UniversalTone != null)
		{
			int universalToneId = config.UniversalTone.UniversalToneId;
			int? num;
			if (config.UniversalTone.TimberId == null)
			{
				NpcFlowComponent component2 = entity.GetComponent<NpcFlowComponent>();
				num = ((component2 != null) ? component2.GetTimberId() : null);
			}
			else
			{
				num = config.UniversalTone.TimberId;
			}
			int? num2 = num;
			if (num2 != null)
			{
				Interjection? config2 = ConfigInterjectionByTimberIdAndUniversalToneId.GetConfig(num2.Value, universalToneId, true);
				if (config2 != null)
				{
					this.HandleInterjection(config2.Value, config, entity);
					return true;
				}
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "通用语气配置无法获取，策划检查配置捏";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timberId", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("universalToneId", universalToneId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		string flowText = base.GetFlowText(config.TidTalk);
		this.WaitSecondsRemain = (double)base.GetWaitSeconds(config, 0f);
		double num3 = this.WaitSecondsRemain + 0.05000000074505806;
		this.IsWaitForDialogueUi = true;
		entity.GetComponent<PawnHeadInfoComponent>().SetDialogueText(flowText, (float)num3, this.RedDotLogic.GetRedDotActive()).ContinueWith(delegate()
		{
			this.IsWaitForDialogueUi = false;
		});
		return true;
	}

	// Token: 0x0601BA16 RID: 113174 RVA: 0x007975B4 File Offset: 0x007957B4
	private void HandleNormalAudio(PlotAudio audioConfig, ITalkItem config, Entity entity)
	{
		ExternalSourceSetting? config2 = ConfigExternalSourceSettingById.GetConfig(audioConfig.ExternalSourceSetting, true);
		this.BeginAudio(entity, config, (audioConfig.TailTime < 0) ? PlotModel.Instance.PlotGlobalConfig.BubbleAudioEndDelay : ((float)audioConfig.TailTime));
		int id = this.AudioUniqueId;
		this.PlayEventHandle = this.PostBubbleAudio(AudioSystem.Instance.parseAudioEventPath(config2.Value.BubbleEvent), new PostEventArgs
		{
			ExternalSourceName = config2.Value.BubbleSrc,
			ExternalSourceMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(audioConfig),
			CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				this.OnAudioCallback(id, callbackType, callbackInfo);
			}
		});
	}

	// Token: 0x0601BA17 RID: 113175 RVA: 0x0079768C File Offset: 0x0079588C
	private void HandleInterjection(Interjection audioConfig, ITalkItem config, Entity entity)
	{
		this.BeginAudio(entity, config, 0f);
		int id = this.AudioUniqueId;
		this.PlayEventHandle = this.PostBubbleAudio(AudioSystem.Instance.parseAudioEventPath(audioConfig.AkEvent), new PostEventArgs
		{
			CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				this.OnAudioCallback(id, callbackType, callbackInfo);
			}
		});
	}

	// Token: 0x0601BA18 RID: 113176 RVA: 0x00797705 File Offset: 0x00795905
	private void BeginAudio(Entity entity, ITalkItem config, float extraDuration = 0f)
	{
		this.IsAudioLoading = true;
		this.WaitSecondsRemain = 1.0;
		this.AudioUniqueId++;
		this.AudioEntity = entity;
		this.AudioConfig = config;
		this.AudioExtraDuration = extraDuration;
	}

	// Token: 0x0601BA19 RID: 113177 RVA: 0x00797740 File Offset: 0x00795940
	[NullableContext(2)]
	private void OnAudioCallback(int id, EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
	{
		if (id != this.AudioUniqueId)
		{
			return;
		}
		if (callbackType != EAkCallbackType.Duration)
		{
			return;
		}
		float duration = (callbackInfo as UAkDurationCallbackInfo).Duration;
		this.CallBackDuration(duration + this.AudioExtraDuration, this.AudioEntity, this.AudioConfig);
	}

	// Token: 0x0601BA1A RID: 113178 RVA: 0x00797784 File Offset: 0x00795984
	private int PostBubbleAudio(string eventName, PostEventArgs args)
	{
		BaseActorComponent actorComp = this.ActorComp;
		AActor aactor = (actorComp != null) ? actorComp.Owner : null;
		if (aactor == null || !aactor.IsValid())
		{
			return 0;
		}
		UAkComponent andPrepareAudioTarget = this.GetAndPrepareAudioTarget(aactor);
		if (andPrepareAudioTarget == null)
		{
			return AudioSystem.Instance.PostEvent(eventName, aactor, new PostEventArgs?(args));
		}
		return AudioSystem.Instance.PostEvent(eventName, andPrepareAudioTarget, new PostEventArgs?(args));
	}

	// Token: 0x0601BA1B RID: 113179 RVA: 0x007977E4 File Offset: 0x007959E4
	[return: Nullable(2)]
	private UAkComponent GetAndPrepareAudioTarget(AActor owner)
	{
		UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(owner, new FName?(FName.NAME_None), null);
		if (akComponent == null || !akComponent.IsValid())
		{
			return null;
		}
		akComponent.bEnableOcclusion = base.IsAudioOccludedByScene;
		return akComponent;
	}

	// Token: 0x0601BA1C RID: 113180 RVA: 0x00797828 File Offset: 0x00795A28
	[NullableContext(2)]
	private void PlayAkEvent(IPostAkEventType config)
	{
		if (config == null)
		{
			return;
		}
		if (config.Type == EPostAkEvent.Global)
		{
			string akEvent = (config as IPostAkEventGlobal).AkEvent;
			AudioController.Instance.PostEvent(akEvent, null, null, null, null, null, true, "");
			return;
		}
		if (config.Type == EPostAkEvent.Target)
		{
			string akEvent2 = (config as IPostAkEventTargeted).AkEvent;
			int entityId = (config as IPostAkEventTargeted).EntityId;
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
			if (entityByPbDataId == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			BaseActorComponent component = entityByPbDataId.Entity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "未能获取到该实体对应的有效Actor";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			AudioController.Instance.PostEvent(akEvent2, aactor, null, null, null, null, true, "");
		}
	}

	// Token: 0x0601BA1D RID: 113181 RVA: 0x0079795C File Offset: 0x00795B5C
	private void CallBackDuration(float duration, Entity entity, ITalkItem config)
	{
		this.IsAudioLoading = false;
		this.WaitSecondsRemain = ((duration > 0f) ? TimeUtil.Instance.SetTimeSecond((double)duration) : 3.0);
		string flowText = base.GetFlowText(config.TidTalk);
		if (StringUtils.IsEmpty(flowText))
		{
			return;
		}
		double num2;
		if (config.WaitTime != null)
		{
			float? waitTime = config.WaitTime;
			float num = 0f;
			if (waitTime.GetValueOrDefault() > num & waitTime != null)
			{
				num2 = (double)(config.WaitTime.Value + 0.05f);
				goto IL_9A;
			}
		}
		num2 = this.WaitSecondsRemain + 0.05000000074505806;
		IL_9A:
		double num3 = num2;
		PawnHeadInfoComponent component = entity.GetComponent<PawnHeadInfoComponent>();
		this.IsWaitForDialogueUi = true;
		component.SetDialogueText(flowText, (float)num3, false).ContinueWith(delegate()
		{
			this.IsWaitForDialogueUi = false;
		});
	}

	// Token: 0x0601BA1E RID: 113182 RVA: 0x00797A2C File Offset: 0x00795C2C
	public override void Tick(float deltaSeconds)
	{
		if (!this.EnableUpdate)
		{
			return;
		}
		if (this.IsWaitForDialogueUi)
		{
			return;
		}
		this.WaitSecondsRemain -= (double)deltaSeconds;
		if (this.WaitSecondsRemain <= 0.0)
		{
			if (this.IsAudioLoading)
			{
				global::Log.Instance.Warn(ELogModule.Level, ELogAuthor.FZX, "冒泡音频加载超时", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearAudio();
				this.CallBackDuration(0f, this.AudioEntity, this.AudioConfig);
				return;
			}
			if (base.IsExecuteFlowEnd)
			{
				if (!this.IsPause)
				{
					base.StartFlow();
					return;
				}
				this.EnableUpdate = false;
				return;
			}
			else
			{
				this.PlayTalk(this.CurrentTalkId + 1);
			}
		}
	}

	// Token: 0x0601BA1F RID: 113183 RVA: 0x00797ADC File Offset: 0x00795CDC
	public void ClearAudio()
	{
		this.IsAudioLoading = false;
		this.AudioUniqueId++;
		if (this.PlayEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.PlayEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(1000)
			}));
			this.PlayEventHandle = 0;
		}
	}

	// Token: 0x0400D943 RID: 55619
	private const int DEFAULT_WAIT_TIME = 3;

	// Token: 0x0400D944 RID: 55620
	private const int LOAD_AUDIO_TIME = 1;

	// Token: 0x0400D945 RID: 55621
	private const int BREAK_TIME = 1000;

	// Token: 0x0400D946 RID: 55622
	private int PlayEventHandle;

	// Token: 0x0400D947 RID: 55623
	private int AudioUniqueId;

	// Token: 0x0400D948 RID: 55624
	[Nullable(2)]
	private Entity AudioEntity;

	// Token: 0x0400D949 RID: 55625
	[Nullable(2)]
	private ITalkItem AudioConfig;

	// Token: 0x0400D94A RID: 55626
	private float AudioExtraDuration;

	// Token: 0x0400D94B RID: 55627
	private bool IsAudioLoading;

	// Token: 0x0400D94C RID: 55628
	[Nullable(2)]
	private NpcRedDotFlowLogic RedDotInternal;
}
