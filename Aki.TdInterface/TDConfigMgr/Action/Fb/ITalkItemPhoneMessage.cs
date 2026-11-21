using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002801 RID: 10241
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemPhoneMessage : ITalkItem
	{
		// Token: 0x0600E33C RID: 58172 RVA: 0x00217DF4 File Offset: 0x00215FF4
		[NullableContext(0)]
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

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x0600E33D RID: 58173 RVA: 0x00217E14 File Offset: 0x00216014
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

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x0600E33E RID: 58174 RVA: 0x00217E4A File Offset: 0x0021604A
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x0600E33F RID: 58175 RVA: 0x00217E58 File Offset: 0x00216058
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

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x0600E340 RID: 58176 RVA: 0x00217E8E File Offset: 0x0021608E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x0600E341 RID: 58177 RVA: 0x00217E9B File Offset: 0x0021609B
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x0600E342 RID: 58178 RVA: 0x00217EA8 File Offset: 0x002160A8
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

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x0600E343 RID: 58179 RVA: 0x00217EE0 File Offset: 0x002160E0
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

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x0600E344 RID: 58180 RVA: 0x00217F18 File Offset: 0x00216118
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

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x00217F50 File Offset: 0x00216150
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

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x0600E346 RID: 58182 RVA: 0x00217F87 File Offset: 0x00216187
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x0600E347 RID: 58183 RVA: 0x00217F94 File Offset: 0x00216194
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

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x0600E348 RID: 58184 RVA: 0x00217FCB File Offset: 0x002161CB
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

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x0600E349 RID: 58185 RVA: 0x00218000 File Offset: 0x00216200
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x0600E34A RID: 58186 RVA: 0x00218080 File Offset: 0x00216280
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ITalkOption> Options
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x0600E34B RID: 58187 RVA: 0x002180FE File Offset: 0x002162FE
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

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x0600E34C RID: 58188 RVA: 0x00218132 File Offset: 0x00216332
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

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0600E34D RID: 58189 RVA: 0x00218166 File Offset: 0x00216366
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

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x0600E34E RID: 58190 RVA: 0x0021819C File Offset: 0x0021639C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<SetFlowTemplate> FlowTemplateList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x0600E34F RID: 58191 RVA: 0x0021821C File Offset: 0x0021641C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IMontageData> ActorMontageArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x0600E350 RID: 58192 RVA: 0x0021829C File Offset: 0x0021649C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IActorFaceExpression> ActorFaceExpressionArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x0600E351 RID: 58193 RVA: 0x0021831C File Offset: 0x0021651C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IActorLookAt> ActorLookAtArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x0600E352 RID: 58194 RVA: 0x0021839C File Offset: 0x0021659C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IActorTurnTo> ActorTurnToArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0600E353 RID: 58195 RVA: 0x0021841A File Offset: 0x0021661A
		[Nullable(0)]
		public override IPostAkEventType TalkAkEvent
		{
			[NullableContext(0)]
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

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0600E354 RID: 58196 RVA: 0x00218449 File Offset: 0x00216649
		[Nullable(0)]
		public override IPostAkEventType TalkEndAkEvent
		{
			[NullableContext(0)]
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

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x0600E355 RID: 58197 RVA: 0x00218478 File Offset: 0x00216678
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

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x0600E356 RID: 58198 RVA: 0x002184AC File Offset: 0x002166AC
		[Nullable(0)]
		public override ITalkBackground BackgroundConfig
		{
			[NullableContext(0)]
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

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x0600E357 RID: 58199 RVA: 0x002184DC File Offset: 0x002166DC
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

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x0600E358 RID: 58200 RVA: 0x00218516 File Offset: 0x00216716
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

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x0600E359 RID: 58201 RVA: 0x0021854A File Offset: 0x0021674A
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

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x0600E35A RID: 58202 RVA: 0x00218580 File Offset: 0x00216780
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> IntroActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x0600E35B RID: 58203 RVA: 0x00218600 File Offset: 0x00216800
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IActorFxEmote> ActorFxEmoteArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x0600E35C RID: 58204 RVA: 0x00218680 File Offset: 0x00216880
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ITalkEffectActionType> TalkEffectArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x0600E35D RID: 58205 RVA: 0x002186D0 File Offset: 0x002168D0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IActorVisibility> ActorVisibilityArray
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x0600E35E RID: 58206 RVA: 0x0021874E File Offset: 0x0021694E
		[Nullable(0)]
		public virtual ITalkItemPhoneMessageBase MessageType
		{
			[NullableContext(0)]
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

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x0600E35F RID: 58207 RVA: 0x0021877D File Offset: 0x0021697D
		[Nullable(0)]
		public virtual ITalkItemStyle Style
		{
			[NullableContext(0)]
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

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x0600E360 RID: 58208 RVA: 0x002187AC File Offset: 0x002169AC
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

		// Token: 0x04007C23 RID: 31779
		private ITalkItemPhoneMessage Instance;

		// Token: 0x04007C24 RID: 31780
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007C25 RID: 31781
		private bool _CaptionParamsInited;

		// Token: 0x04007C26 RID: 31782
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007C27 RID: 31783
		private bool _ActionsInited;

		// Token: 0x04007C28 RID: 31784
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007C29 RID: 31785
		private bool _OptionsInited;

		// Token: 0x04007C2A RID: 31786
		private PlayMontage _MontageCache;

		// Token: 0x04007C2B RID: 31787
		private bool _MontageInited;

		// Token: 0x04007C2C RID: 31788
		private ICameraData _CameraDataCache;

		// Token: 0x04007C2D RID: 31789
		private bool _CameraDataInited;

		// Token: 0x04007C2E RID: 31790
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007C2F RID: 31791
		private bool _FlowTemplateInited;

		// Token: 0x04007C30 RID: 31792
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007C31 RID: 31793
		private bool _FlowTemplateListInited;

		// Token: 0x04007C32 RID: 31794
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007C33 RID: 31795
		private bool _ActorMontageArrayInited;

		// Token: 0x04007C34 RID: 31796
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007C35 RID: 31797
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007C36 RID: 31798
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007C37 RID: 31799
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007C38 RID: 31800
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007C39 RID: 31801
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007C3A RID: 31802
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007C3B RID: 31803
		private bool _TalkAkEventInited;

		// Token: 0x04007C3C RID: 31804
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007C3D RID: 31805
		private bool _TalkEndAkEventInited;

		// Token: 0x04007C3E RID: 31806
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007C3F RID: 31807
		private bool _UniversalToneInited;

		// Token: 0x04007C40 RID: 31808
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007C41 RID: 31809
		private bool _BackgroundConfigInited;

		// Token: 0x04007C42 RID: 31810
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007C43 RID: 31811
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007C44 RID: 31812
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007C45 RID: 31813
		private bool _GamepadShakeInited;

		// Token: 0x04007C46 RID: 31814
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007C47 RID: 31815
		private bool _IntroActionsInited;

		// Token: 0x04007C48 RID: 31816
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007C49 RID: 31817
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007C4A RID: 31818
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007C4B RID: 31819
		private bool _TalkEffectArrayInited;

		// Token: 0x04007C4C RID: 31820
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007C4D RID: 31821
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007C4E RID: 31822
		[Nullable(0)]
		private ITalkItemPhoneMessageBase _MessageTypeCache;

		// Token: 0x04007C4F RID: 31823
		private bool _MessageTypeInited;

		// Token: 0x04007C50 RID: 31824
		[Nullable(0)]
		private ITalkItemStyle _StyleCache;

		// Token: 0x04007C51 RID: 31825
		private bool _StyleInited;
	}
}
