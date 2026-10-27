using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002558 RID: 9560
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemPhoneMessage : ITalkItem
	{
		// Token: 0x0600D5D2 RID: 54738 RVA: 0x001FC1F8 File Offset: 0x001FA3F8
		[NullableContext(1)]
		public static ITalkItemPhoneMessage Create(ITalkItemPhoneMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0600D5D3 RID: 54739 RVA: 0x001FC218 File Offset: 0x001FA418
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

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x001FC24E File Offset: 0x001FA44E
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600D5D5 RID: 54741 RVA: 0x001FC25C File Offset: 0x001FA45C
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

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x001FC292 File Offset: 0x001FA492
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600D5D7 RID: 54743 RVA: 0x001FC29F File Offset: 0x001FA49F
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600D5D8 RID: 54744 RVA: 0x001FC2AC File Offset: 0x001FA4AC
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

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x001FC2E4 File Offset: 0x001FA4E4
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

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x001FC31C File Offset: 0x001FA51C
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

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600D5DB RID: 54747 RVA: 0x001FC354 File Offset: 0x001FA554
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

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600D5DC RID: 54748 RVA: 0x001FC38B File Offset: 0x001FA58B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0600D5DD RID: 54749 RVA: 0x001FC398 File Offset: 0x001FA598
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

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600D5DE RID: 54750 RVA: 0x001FC3CF File Offset: 0x001FA5CF
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

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600D5DF RID: 54751 RVA: 0x001FC404 File Offset: 0x001FA604
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

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600D5E0 RID: 54752 RVA: 0x001FC484 File Offset: 0x001FA684
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

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x001FC502 File Offset: 0x001FA702
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

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0600D5E2 RID: 54754 RVA: 0x001FC536 File Offset: 0x001FA736
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

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x0600D5E3 RID: 54755 RVA: 0x001FC56A File Offset: 0x001FA76A
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

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x0600D5E4 RID: 54756 RVA: 0x001FC5A0 File Offset: 0x001FA7A0
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

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x001FC620 File Offset: 0x001FA820
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

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x0600D5E6 RID: 54758 RVA: 0x001FC6A0 File Offset: 0x001FA8A0
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

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x001FC720 File Offset: 0x001FA920
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

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x0600D5E8 RID: 54760 RVA: 0x001FC7A0 File Offset: 0x001FA9A0
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

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x001FC81E File Offset: 0x001FAA1E
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemPhoneMessage_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600D5EA RID: 54762 RVA: 0x001FC84D File Offset: 0x001FAA4D
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemPhoneMessage_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600D5EB RID: 54763 RVA: 0x001FC87C File Offset: 0x001FAA7C
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

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600D5EC RID: 54764 RVA: 0x001FC8B0 File Offset: 0x001FAAB0
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemPhoneMessage_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x001FC8E0 File Offset: 0x001FAAE0
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

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600D5EE RID: 54766 RVA: 0x001FC91A File Offset: 0x001FAB1A
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

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x001FC94E File Offset: 0x001FAB4E
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

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0600D5F0 RID: 54768 RVA: 0x001FC984 File Offset: 0x001FAB84
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

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0600D5F1 RID: 54769 RVA: 0x001FCA04 File Offset: 0x001FAC04
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

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0600D5F2 RID: 54770 RVA: 0x001FCA84 File Offset: 0x001FAC84
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemPhoneMessage_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x001FCAD4 File Offset: 0x001FACD4
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

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600D5F4 RID: 54772 RVA: 0x001FCB52 File Offset: 0x001FAD52
		[Nullable(1)]
		public virtual ITalkItemPhoneMessageBase MessageType
		{
			[NullableContext(1)]
			get
			{
				if (this._MessageTypeInited)
				{
					return this._MessageTypeCache;
				}
				this._MessageTypeInited = true;
				this._MessageTypeCache = ActionReadHelper.ReadITalkItemPhoneMessage_MessageType(this.Instance);
				return this._MessageTypeCache;
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600D5F5 RID: 54773 RVA: 0x001FCB81 File Offset: 0x001FAD81
		[Nullable(1)]
		public virtual ITalkItemStyle Style
		{
			[NullableContext(1)]
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				this._StyleCache = ActionReadHelper.ReadITalkItemPhoneMessage_Style(this.Instance);
				return this._StyleCache;
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x0600D5F6 RID: 54774 RVA: 0x001FCBB0 File Offset: 0x001FADB0
		public virtual float? OtherIsTypingDuration
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new float?(this.Instance.OtherIsTypingDuration);
			}
		}

		// Token: 0x040075C6 RID: 30150
		private ITalkItemPhoneMessage Instance;

		// Token: 0x040075C7 RID: 30151
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040075C8 RID: 30152
		private bool _CaptionParamsInited;

		// Token: 0x040075C9 RID: 30153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040075CA RID: 30154
		private bool _ActionsInited;

		// Token: 0x040075CB RID: 30155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040075CC RID: 30156
		private bool _OptionsInited;

		// Token: 0x040075CD RID: 30157
		private PlayMontage _MontageCache;

		// Token: 0x040075CE RID: 30158
		private bool _MontageInited;

		// Token: 0x040075CF RID: 30159
		private ICameraData _CameraDataCache;

		// Token: 0x040075D0 RID: 30160
		private bool _CameraDataInited;

		// Token: 0x040075D1 RID: 30161
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040075D2 RID: 30162
		private bool _FlowTemplateInited;

		// Token: 0x040075D3 RID: 30163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040075D4 RID: 30164
		private bool _FlowTemplateListInited;

		// Token: 0x040075D5 RID: 30165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040075D6 RID: 30166
		private bool _ActorMontageArrayInited;

		// Token: 0x040075D7 RID: 30167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040075D8 RID: 30168
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040075D9 RID: 30169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040075DA RID: 30170
		private bool _ActorLookAtArrayInited;

		// Token: 0x040075DB RID: 30171
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040075DC RID: 30172
		private bool _ActorTurnToArrayInited;

		// Token: 0x040075DD RID: 30173
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040075DE RID: 30174
		private bool _TalkAkEventInited;

		// Token: 0x040075DF RID: 30175
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040075E0 RID: 30176
		private bool _TalkEndAkEventInited;

		// Token: 0x040075E1 RID: 30177
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040075E2 RID: 30178
		private bool _UniversalToneInited;

		// Token: 0x040075E3 RID: 30179
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040075E4 RID: 30180
		private bool _BackgroundConfigInited;

		// Token: 0x040075E5 RID: 30181
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040075E6 RID: 30182
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040075E7 RID: 30183
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040075E8 RID: 30184
		private bool _GamepadShakeInited;

		// Token: 0x040075E9 RID: 30185
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040075EA RID: 30186
		private bool _IntroActionsInited;

		// Token: 0x040075EB RID: 30187
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040075EC RID: 30188
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040075ED RID: 30189
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040075EE RID: 30190
		private bool _TalkEffectArrayInited;

		// Token: 0x040075EF RID: 30191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040075F0 RID: 30192
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040075F1 RID: 30193
		[Nullable(1)]
		private ITalkItemPhoneMessageBase _MessageTypeCache;

		// Token: 0x040075F2 RID: 30194
		private bool _MessageTypeInited;

		// Token: 0x040075F3 RID: 30195
		[Nullable(1)]
		private ITalkItemStyle _StyleCache;

		// Token: 0x040075F4 RID: 30196
		private bool _StyleInited;
	}
}
