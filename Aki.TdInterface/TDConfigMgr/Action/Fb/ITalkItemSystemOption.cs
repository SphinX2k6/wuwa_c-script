using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F8 RID: 10232
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemSystemOption : ITalkItem
	{
		// Token: 0x0600E298 RID: 58008 RVA: 0x00215600 File Offset: 0x00213800
		[NullableContext(0)]
		public static ITalkItemSystemOption Create(ITalkItemSystemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemSystemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0600E299 RID: 58009 RVA: 0x00215620 File Offset: 0x00213820
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

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x0600E29A RID: 58010 RVA: 0x00215656 File Offset: 0x00213856
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0600E29B RID: 58011 RVA: 0x00215664 File Offset: 0x00213864
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

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0600E29C RID: 58012 RVA: 0x0021569A File Offset: 0x0021389A
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0600E29D RID: 58013 RVA: 0x002156A7 File Offset: 0x002138A7
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0600E29E RID: 58014 RVA: 0x002156B4 File Offset: 0x002138B4
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

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0600E29F RID: 58015 RVA: 0x002156EC File Offset: 0x002138EC
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

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x0600E2A0 RID: 58016 RVA: 0x00215724 File Offset: 0x00213924
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

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0600E2A1 RID: 58017 RVA: 0x0021575C File Offset: 0x0021395C
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

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x0600E2A2 RID: 58018 RVA: 0x00215793 File Offset: 0x00213993
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x0600E2A3 RID: 58019 RVA: 0x002157A0 File Offset: 0x002139A0
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

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x0600E2A4 RID: 58020 RVA: 0x002157D7 File Offset: 0x002139D7
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

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x0021580C File Offset: 0x00213A0C
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

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x0600E2A6 RID: 58022 RVA: 0x0021588C File Offset: 0x00213A8C
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

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x0021590A File Offset: 0x00213B0A
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

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0600E2A8 RID: 58024 RVA: 0x0021593E File Offset: 0x00213B3E
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

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0600E2A9 RID: 58025 RVA: 0x00215972 File Offset: 0x00213B72
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

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0600E2AA RID: 58026 RVA: 0x002159A8 File Offset: 0x00213BA8
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

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x00215A28 File Offset: 0x00213C28
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

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x00215AA8 File Offset: 0x00213CA8
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

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x00215B28 File Offset: 0x00213D28
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

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x0600E2AE RID: 58030 RVA: 0x00215BA8 File Offset: 0x00213DA8
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

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x00215C26 File Offset: 0x00213E26
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemSystemOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x0600E2B0 RID: 58032 RVA: 0x00215C55 File Offset: 0x00213E55
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemSystemOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x00215C84 File Offset: 0x00213E84
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

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x0600E2B2 RID: 58034 RVA: 0x00215CB8 File Offset: 0x00213EB8
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemSystemOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x00215CE8 File Offset: 0x00213EE8
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

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0600E2B4 RID: 58036 RVA: 0x00215D22 File Offset: 0x00213F22
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

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x00215D56 File Offset: 0x00213F56
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

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0600E2B6 RID: 58038 RVA: 0x00215D8C File Offset: 0x00213F8C
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

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x0600E2B7 RID: 58039 RVA: 0x00215E0C File Offset: 0x0021400C
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

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0600E2B8 RID: 58040 RVA: 0x00215E8C File Offset: 0x0021408C
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemSystemOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x00215EDC File Offset: 0x002140DC
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

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x0600E2BA RID: 58042 RVA: 0x00215F5A File Offset: 0x0021415A
		[Nullable(0)]
		public virtual ISystemOptionType OptionConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._OptionConfigInited)
				{
					return this._OptionConfigCache;
				}
				this._OptionConfigInited = true;
				this._OptionConfigCache = ActionReadHelper.ReadITalkItemSystemOption_OptionConfig(this.Instance);
				return this._OptionConfigCache;
			}
		}

		// Token: 0x04007B6C RID: 31596
		private ITalkItemSystemOption Instance;

		// Token: 0x04007B6D RID: 31597
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007B6E RID: 31598
		private bool _CaptionParamsInited;

		// Token: 0x04007B6F RID: 31599
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007B70 RID: 31600
		private bool _ActionsInited;

		// Token: 0x04007B71 RID: 31601
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007B72 RID: 31602
		private bool _OptionsInited;

		// Token: 0x04007B73 RID: 31603
		private PlayMontage _MontageCache;

		// Token: 0x04007B74 RID: 31604
		private bool _MontageInited;

		// Token: 0x04007B75 RID: 31605
		private ICameraData _CameraDataCache;

		// Token: 0x04007B76 RID: 31606
		private bool _CameraDataInited;

		// Token: 0x04007B77 RID: 31607
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007B78 RID: 31608
		private bool _FlowTemplateInited;

		// Token: 0x04007B79 RID: 31609
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007B7A RID: 31610
		private bool _FlowTemplateListInited;

		// Token: 0x04007B7B RID: 31611
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007B7C RID: 31612
		private bool _ActorMontageArrayInited;

		// Token: 0x04007B7D RID: 31613
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007B7E RID: 31614
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007B7F RID: 31615
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007B80 RID: 31616
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007B81 RID: 31617
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007B82 RID: 31618
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007B83 RID: 31619
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007B84 RID: 31620
		private bool _TalkAkEventInited;

		// Token: 0x04007B85 RID: 31621
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007B86 RID: 31622
		private bool _TalkEndAkEventInited;

		// Token: 0x04007B87 RID: 31623
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007B88 RID: 31624
		private bool _UniversalToneInited;

		// Token: 0x04007B89 RID: 31625
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007B8A RID: 31626
		private bool _BackgroundConfigInited;

		// Token: 0x04007B8B RID: 31627
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007B8C RID: 31628
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007B8D RID: 31629
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007B8E RID: 31630
		private bool _GamepadShakeInited;

		// Token: 0x04007B8F RID: 31631
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007B90 RID: 31632
		private bool _IntroActionsInited;

		// Token: 0x04007B91 RID: 31633
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007B92 RID: 31634
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007B93 RID: 31635
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007B94 RID: 31636
		private bool _TalkEffectArrayInited;

		// Token: 0x04007B95 RID: 31637
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007B96 RID: 31638
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007B97 RID: 31639
		[Nullable(0)]
		private ISystemOptionType _OptionConfigCache;

		// Token: 0x04007B98 RID: 31640
		private bool _OptionConfigInited;
	}
}
