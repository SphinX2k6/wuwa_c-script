using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002595 RID: 9621
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNarration : ITalkItem
	{
		// Token: 0x0600D82B RID: 55339 RVA: 0x00203827 File Offset: 0x00201A27
		[NullableContext(1)]
		public static ITalkItemVisualNovelNarration Create(ITalkItemVisualNovelNarration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNarration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x0600D82C RID: 55340 RVA: 0x00203848 File Offset: 0x00201A48
		public override ETalkItemType? Type
		{
			get
			{
				if ((this.Instance.NullMask & 1U) == 0U)
				{
					return null;
				}
				return new ETalkItemType?((ETalkItemType)this.Instance.Type);
			}
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0600D82D RID: 55341 RVA: 0x0020387E File Offset: 0x00201A7E
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x0600D82E RID: 55342 RVA: 0x0020388C File Offset: 0x00201A8C
		public override int? PlotLineId
		{
			get
			{
				if ((this.Instance.NullMask & 2U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotLineId);
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x0600D82F RID: 55343 RVA: 0x002038C2 File Offset: 0x00201AC2
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x0600D830 RID: 55344 RVA: 0x002038CF File Offset: 0x00201ACF
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x0600D831 RID: 55345 RVA: 0x002038DC File Offset: 0x00201ADC
		public override bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 4U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x0600D832 RID: 55346 RVA: 0x00203914 File Offset: 0x00201B14
		public override EEditFlag? _EditFlag
		{
			get
			{
				if ((this.Instance.NullMask & 8U) == 0U)
				{
					return null;
				}
				return new EEditFlag?((EEditFlag)this.Instance._EditFlag);
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0600D833 RID: 55347 RVA: 0x0020394C File Offset: 0x00201B4C
		public override int? WhoId
		{
			get
			{
				if ((this.Instance.NullMask & 16U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.WhoId);
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0600D834 RID: 55348 RVA: 0x00203984 File Offset: 0x00201B84
		public override int? TextId
		{
			get
			{
				if ((this.Instance.NullMask & 32U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.TextId);
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x0600D835 RID: 55349 RVA: 0x002039BB File Offset: 0x00201BBB
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x0600D836 RID: 55350 RVA: 0x002039C8 File Offset: 0x00201BC8
		public override float? WaitTime
		{
			get
			{
				if ((this.Instance.NullMask & 64U) == 0U)
				{
					return null;
				}
				return new float?(this.Instance.WaitTime);
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x0600D837 RID: 55351 RVA: 0x002039FF File Offset: 0x00201BFF
		public override ICaptionParam CaptionParams
		{
			get
			{
				if (this._CaptionParamsInited)
				{
					return this._CaptionParamsCache;
				}
				this._CaptionParamsInited = true;
				this._CaptionParamsCache = ICaptionParam.Create(this.Instance.CaptionParams);
				return this._CaptionParamsCache;
			}
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x0600D838 RID: 55352 RVA: 0x00203A34 File Offset: 0x00201C34
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if ((this.Instance.NullMask & 128U) == 0U)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x0600D839 RID: 55353 RVA: 0x00203AB4 File Offset: 0x00201CB4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ITalkOption> Options
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				if ((this.Instance.NullMask & 256U) == 0U)
				{
					return null;
				}
				int optionsLength = this.Instance.OptionsLength;
				this._OptionsCache = new List<ITalkOption>(optionsLength);
				for (int i = 0; i < optionsLength; i++)
				{
					this._OptionsCache.Add(ITalkOption.Create(this.Instance.Options(i)));
				}
				return this._OptionsCache;
			}
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x0600D83A RID: 55354 RVA: 0x00203B32 File Offset: 0x00201D32
		public override PlayMontage Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				this._MontageCache = PlayMontage.Create(this.Instance.Montage);
				return this._MontageCache;
			}
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x0600D83B RID: 55355 RVA: 0x00203B66 File Offset: 0x00201D66
		public override ICameraData CameraData
		{
			get
			{
				if (this._CameraDataInited)
				{
					return this._CameraDataCache;
				}
				this._CameraDataInited = true;
				this._CameraDataCache = ICameraData.Create(this.Instance.CameraData);
				return this._CameraDataCache;
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0600D83C RID: 55356 RVA: 0x00203B9A File Offset: 0x00201D9A
		public override SetFlowTemplate FlowTemplate
		{
			get
			{
				if (this._FlowTemplateInited)
				{
					return this._FlowTemplateCache;
				}
				this._FlowTemplateInited = true;
				this._FlowTemplateCache = SetFlowTemplate.Create(this.Instance.FlowTemplate);
				return this._FlowTemplateCache;
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0600D83D RID: 55357 RVA: 0x00203BD0 File Offset: 0x00201DD0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<SetFlowTemplate> FlowTemplateList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._FlowTemplateListInited)
				{
					return this._FlowTemplateListCache;
				}
				this._FlowTemplateListInited = true;
				if ((this.Instance.NullMask & 512U) == 0U)
				{
					return null;
				}
				int flowTemplateListLength = this.Instance.FlowTemplateListLength;
				this._FlowTemplateListCache = new List<SetFlowTemplate>(flowTemplateListLength);
				for (int i = 0; i < flowTemplateListLength; i++)
				{
					this._FlowTemplateListCache.Add(SetFlowTemplate.Create(this.Instance.FlowTemplateList(i)));
				}
				return this._FlowTemplateListCache;
			}
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0600D83E RID: 55358 RVA: 0x00203C50 File Offset: 0x00201E50
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IMontageData> ActorMontageArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActorMontageArrayInited)
				{
					return this._ActorMontageArrayCache;
				}
				this._ActorMontageArrayInited = true;
				if ((this.Instance.NullMask & 1024U) == 0U)
				{
					return null;
				}
				int actorMontageArrayLength = this.Instance.ActorMontageArrayLength;
				this._ActorMontageArrayCache = new List<IMontageData>(actorMontageArrayLength);
				for (int i = 0; i < actorMontageArrayLength; i++)
				{
					this._ActorMontageArrayCache.Add(IMontageData.Create(this.Instance.ActorMontageArray(i)));
				}
				return this._ActorMontageArrayCache;
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x0600D83F RID: 55359 RVA: 0x00203CD0 File Offset: 0x00201ED0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IActorFaceExpression> ActorFaceExpressionArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActorFaceExpressionArrayInited)
				{
					return this._ActorFaceExpressionArrayCache;
				}
				this._ActorFaceExpressionArrayInited = true;
				if ((this.Instance.NullMask & 2048U) == 0U)
				{
					return null;
				}
				int actorFaceExpressionArrayLength = this.Instance.ActorFaceExpressionArrayLength;
				this._ActorFaceExpressionArrayCache = new List<IActorFaceExpression>(actorFaceExpressionArrayLength);
				for (int i = 0; i < actorFaceExpressionArrayLength; i++)
				{
					this._ActorFaceExpressionArrayCache.Add(IActorFaceExpression.Create(this.Instance.ActorFaceExpressionArray(i)));
				}
				return this._ActorFaceExpressionArrayCache;
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x0600D840 RID: 55360 RVA: 0x00203D50 File Offset: 0x00201F50
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IActorLookAt> ActorLookAtArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActorLookAtArrayInited)
				{
					return this._ActorLookAtArrayCache;
				}
				this._ActorLookAtArrayInited = true;
				if ((this.Instance.NullMask & 4096U) == 0U)
				{
					return null;
				}
				int actorLookAtArrayLength = this.Instance.ActorLookAtArrayLength;
				this._ActorLookAtArrayCache = new List<IActorLookAt>(actorLookAtArrayLength);
				for (int i = 0; i < actorLookAtArrayLength; i++)
				{
					this._ActorLookAtArrayCache.Add(IActorLookAt.Create(this.Instance.ActorLookAtArray(i)));
				}
				return this._ActorLookAtArrayCache;
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0600D841 RID: 55361 RVA: 0x00203DD0 File Offset: 0x00201FD0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IActorTurnTo> ActorTurnToArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActorTurnToArrayInited)
				{
					return this._ActorTurnToArrayCache;
				}
				this._ActorTurnToArrayInited = true;
				if ((this.Instance.NullMask & 8192U) == 0U)
				{
					return null;
				}
				int actorTurnToArrayLength = this.Instance.ActorTurnToArrayLength;
				this._ActorTurnToArrayCache = new List<IActorTurnTo>(actorTurnToArrayLength);
				for (int i = 0; i < actorTurnToArrayLength; i++)
				{
					this._ActorTurnToArrayCache.Add(IActorTurnTo.Create(this.Instance.ActorTurnToArray(i)));
				}
				return this._ActorTurnToArrayCache;
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0600D842 RID: 55362 RVA: 0x00203E4E File Offset: 0x0020204E
		[Nullable(1)]
		public override IPostAkEventType TalkAkEvent
		{
			[NullableContext(1)]
			get
			{
				if (this._TalkAkEventInited)
				{
					return this._TalkAkEventCache;
				}
				this._TalkAkEventInited = true;
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0600D843 RID: 55363 RVA: 0x00203E7D File Offset: 0x0020207D
		[Nullable(1)]
		public override IPostAkEventType TalkEndAkEvent
		{
			[NullableContext(1)]
			get
			{
				if (this._TalkEndAkEventInited)
				{
					return this._TalkEndAkEventCache;
				}
				this._TalkEndAkEventInited = true;
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x0600D844 RID: 55364 RVA: 0x00203EAC File Offset: 0x002020AC
		public override IUniversalTone UniversalTone
		{
			get
			{
				if (this._UniversalToneInited)
				{
					return this._UniversalToneCache;
				}
				this._UniversalToneInited = true;
				this._UniversalToneCache = IUniversalTone.Create(this.Instance.UniversalTone);
				return this._UniversalToneCache;
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0600D845 RID: 55365 RVA: 0x00203EE0 File Offset: 0x002020E0
		[Nullable(1)]
		public override ITalkBackground BackgroundConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._BackgroundConfigInited)
				{
					return this._BackgroundConfigCache;
				}
				this._BackgroundConfigInited = true;
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0600D846 RID: 55366 RVA: 0x00203F10 File Offset: 0x00202110
		public override bool? PlayVoice
		{
			get
			{
				if ((this.Instance.NullMask & 16384U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance.PlayVoice);
			}
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x0600D847 RID: 55367 RVA: 0x00203F4A File Offset: 0x0020214A
		public override ITimeLimitOptionGroup TimeLimitOptionGroup
		{
			get
			{
				if (this._TimeLimitOptionGroupInited)
				{
					return this._TimeLimitOptionGroupCache;
				}
				this._TimeLimitOptionGroupInited = true;
				this._TimeLimitOptionGroupCache = ITimeLimitOptionGroup.Create(this.Instance.TimeLimitOptionGroup);
				return this._TimeLimitOptionGroupCache;
			}
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x0600D848 RID: 55368 RVA: 0x00203F7E File Offset: 0x0020217E
		public override IGamepadShakeInTalk GamepadShake
		{
			get
			{
				if (this._GamepadShakeInited)
				{
					return this._GamepadShakeCache;
				}
				this._GamepadShakeInited = true;
				this._GamepadShakeCache = IGamepadShakeInTalk.Create(this.Instance.GamepadShake);
				return this._GamepadShakeCache;
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x0600D849 RID: 55369 RVA: 0x00203FB4 File Offset: 0x002021B4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> IntroActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._IntroActionsInited)
				{
					return this._IntroActionsCache;
				}
				this._IntroActionsInited = true;
				if ((this.Instance.NullMask & 32768U) == 0U)
				{
					return null;
				}
				int introActionsLength = this.Instance.IntroActionsLength;
				this._IntroActionsCache = new List<ActionInfo>(introActionsLength);
				for (int i = 0; i < introActionsLength; i++)
				{
					this._IntroActionsCache.Add(ActionInfo.Create(this.Instance.IntroActions(i)));
				}
				return this._IntroActionsCache;
			}
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0600D84A RID: 55370 RVA: 0x00204034 File Offset: 0x00202234
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IActorFxEmote> ActorFxEmoteArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActorFxEmoteArrayInited)
				{
					return this._ActorFxEmoteArrayCache;
				}
				this._ActorFxEmoteArrayInited = true;
				if ((this.Instance.NullMask & 65536U) == 0U)
				{
					return null;
				}
				int actorFxEmoteArrayLength = this.Instance.ActorFxEmoteArrayLength;
				this._ActorFxEmoteArrayCache = new List<IActorFxEmote>(actorFxEmoteArrayLength);
				for (int i = 0; i < actorFxEmoteArrayLength; i++)
				{
					this._ActorFxEmoteArrayCache.Add(IActorFxEmote.Create(this.Instance.ActorFxEmoteArray(i)));
				}
				return this._ActorFxEmoteArrayCache;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0600D84B RID: 55371 RVA: 0x002040B4 File Offset: 0x002022B4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ITalkEffectActionType> TalkEffectArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._TalkEffectArrayInited)
				{
					return this._TalkEffectArrayCache;
				}
				this._TalkEffectArrayInited = true;
				if ((this.Instance.NullMask & 131072U) == 0U)
				{
					return null;
				}
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0600D84C RID: 55372 RVA: 0x00204104 File Offset: 0x00202304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IActorVisibility> ActorVisibilityArray
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActorVisibilityArrayInited)
				{
					return this._ActorVisibilityArrayCache;
				}
				this._ActorVisibilityArrayInited = true;
				if ((this.Instance.NullMask & 262144U) == 0U)
				{
					return null;
				}
				int actorVisibilityArrayLength = this.Instance.ActorVisibilityArrayLength;
				this._ActorVisibilityArrayCache = new List<IActorVisibility>(actorVisibilityArrayLength);
				for (int i = 0; i < actorVisibilityArrayLength; i++)
				{
					this._ActorVisibilityArrayCache.Add(IActorVisibility.Create(this.Instance.ActorVisibilityArray(i)));
				}
				return this._ActorVisibilityArrayCache;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0600D84D RID: 55373 RVA: 0x00204184 File Offset: 0x00202384
		public virtual EVisualNovelOptionInteractionType? OptionInteractionType
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new EVisualNovelOptionInteractionType?((EVisualNovelOptionInteractionType)this.Instance.OptionInteractionType);
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0600D84E RID: 55374 RVA: 0x002041BE File Offset: 0x002023BE
		public virtual IVisualNovelOptionGroupSolarSchoolExam OptionGroup
		{
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = IVisualNovelOptionGroupSolarSchoolExam.Create(this.Instance.OptionGroup);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x0600D84F RID: 55375 RVA: 0x002041F4 File Offset: 0x002023F4
		public virtual float? DialogDelay
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new float?(this.Instance.DialogDelay);
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x0600D850 RID: 55376 RVA: 0x00204230 File Offset: 0x00202430
		public virtual bool? ClickShowFull
		{
			get
			{
				if ((this.Instance.NullMask & 2097152U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance.ClickShowFull);
			}
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x0600D851 RID: 55377 RVA: 0x0020426A File Offset: 0x0020246A
		[Nullable(1)]
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._VisualNovelBackgroundConfigInited)
				{
					return this._VisualNovelBackgroundConfigCache;
				}
				this._VisualNovelBackgroundConfigInited = true;
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x0600D852 RID: 55378 RVA: 0x00204299 File Offset: 0x00202499
		[Nullable(1)]
		public virtual IVisualNovelCgBase CgConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._CgConfigInited)
				{
					return this._CgConfigCache;
				}
				this._CgConfigInited = true;
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x0600D853 RID: 55379 RVA: 0x002042C8 File Offset: 0x002024C8
		[Nullable(1)]
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._DisplayItemConfigInited)
				{
					return this._DisplayItemConfigCache;
				}
				this._DisplayItemConfigInited = true;
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x0600D854 RID: 55380 RVA: 0x002042F8 File Offset: 0x002024F8
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this.Instance.NullMask & 4194304U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotKeyId);
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x0600D855 RID: 55381 RVA: 0x00204334 File Offset: 0x00202534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> StartPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._StartPerformancesInited)
				{
					return this._StartPerformancesCache;
				}
				this._StartPerformancesInited = true;
				if ((this.Instance.NullMask & 8388608U) == 0U)
				{
					return null;
				}
				this._StartPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_StartPerformances(this.Instance);
				return this._StartPerformancesCache;
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x0600D856 RID: 55382 RVA: 0x00204384 File Offset: 0x00202584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> EndPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._EndPerformancesInited)
				{
					return this._EndPerformancesCache;
				}
				this._EndPerformancesInited = true;
				if ((this.Instance.NullMask & 16777216U) == 0U)
				{
					return null;
				}
				this._EndPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_EndPerformances(this.Instance);
				return this._EndPerformancesCache;
			}
		}

		// Token: 0x040077D5 RID: 30677
		private ITalkItemVisualNovelNarration Instance;

		// Token: 0x040077D6 RID: 30678
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040077D7 RID: 30679
		private bool _CaptionParamsInited;

		// Token: 0x040077D8 RID: 30680
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040077D9 RID: 30681
		private bool _ActionsInited;

		// Token: 0x040077DA RID: 30682
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040077DB RID: 30683
		private bool _OptionsInited;

		// Token: 0x040077DC RID: 30684
		private PlayMontage _MontageCache;

		// Token: 0x040077DD RID: 30685
		private bool _MontageInited;

		// Token: 0x040077DE RID: 30686
		private ICameraData _CameraDataCache;

		// Token: 0x040077DF RID: 30687
		private bool _CameraDataInited;

		// Token: 0x040077E0 RID: 30688
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040077E1 RID: 30689
		private bool _FlowTemplateInited;

		// Token: 0x040077E2 RID: 30690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040077E3 RID: 30691
		private bool _FlowTemplateListInited;

		// Token: 0x040077E4 RID: 30692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040077E5 RID: 30693
		private bool _ActorMontageArrayInited;

		// Token: 0x040077E6 RID: 30694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040077E7 RID: 30695
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040077E8 RID: 30696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040077E9 RID: 30697
		private bool _ActorLookAtArrayInited;

		// Token: 0x040077EA RID: 30698
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040077EB RID: 30699
		private bool _ActorTurnToArrayInited;

		// Token: 0x040077EC RID: 30700
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040077ED RID: 30701
		private bool _TalkAkEventInited;

		// Token: 0x040077EE RID: 30702
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040077EF RID: 30703
		private bool _TalkEndAkEventInited;

		// Token: 0x040077F0 RID: 30704
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040077F1 RID: 30705
		private bool _UniversalToneInited;

		// Token: 0x040077F2 RID: 30706
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040077F3 RID: 30707
		private bool _BackgroundConfigInited;

		// Token: 0x040077F4 RID: 30708
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040077F5 RID: 30709
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040077F6 RID: 30710
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040077F7 RID: 30711
		private bool _GamepadShakeInited;

		// Token: 0x040077F8 RID: 30712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040077F9 RID: 30713
		private bool _IntroActionsInited;

		// Token: 0x040077FA RID: 30714
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040077FB RID: 30715
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040077FC RID: 30716
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040077FD RID: 30717
		private bool _TalkEffectArrayInited;

		// Token: 0x040077FE RID: 30718
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040077FF RID: 30719
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007800 RID: 30720
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x04007801 RID: 30721
		private bool _OptionGroupInited;

		// Token: 0x04007802 RID: 30722
		[Nullable(1)]
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x04007803 RID: 30723
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x04007804 RID: 30724
		[Nullable(1)]
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x04007805 RID: 30725
		private bool _CgConfigInited;

		// Token: 0x04007806 RID: 30726
		[Nullable(1)]
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x04007807 RID: 30727
		private bool _DisplayItemConfigInited;

		// Token: 0x04007808 RID: 30728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _StartPerformancesCache;

		// Token: 0x04007809 RID: 30729
		private bool _StartPerformancesInited;

		// Token: 0x0400780A RID: 30730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _EndPerformancesCache;

		// Token: 0x0400780B RID: 30731
		private bool _EndPerformancesInited;
	}
}
