using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F9 RID: 10233
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemCenterText : ITalkItem
	{
		// Token: 0x0600E2BC RID: 58044 RVA: 0x00215F91 File Offset: 0x00214191
		[NullableContext(0)]
		public static ITalkItemCenterText Create(ITalkItemCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x00215FB0 File Offset: 0x002141B0
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

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x0600E2BE RID: 58046 RVA: 0x00215FE6 File Offset: 0x002141E6
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x00215FF4 File Offset: 0x002141F4
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

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x0600E2C0 RID: 58048 RVA: 0x0021602A File Offset: 0x0021422A
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x0600E2C1 RID: 58049 RVA: 0x00216037 File Offset: 0x00214237
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0600E2C2 RID: 58050 RVA: 0x00216044 File Offset: 0x00214244
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

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x0021607C File Offset: 0x0021427C
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

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x0600E2C4 RID: 58052 RVA: 0x002160B4 File Offset: 0x002142B4
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

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x002160EC File Offset: 0x002142EC
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

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x0600E2C6 RID: 58054 RVA: 0x00216123 File Offset: 0x00214323
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x00216130 File Offset: 0x00214330
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

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0600E2C8 RID: 58056 RVA: 0x00216167 File Offset: 0x00214367
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

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0600E2C9 RID: 58057 RVA: 0x0021619C File Offset: 0x0021439C
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

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x0600E2CA RID: 58058 RVA: 0x0021621C File Offset: 0x0021441C
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

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0600E2CB RID: 58059 RVA: 0x0021629A File Offset: 0x0021449A
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

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x0600E2CC RID: 58060 RVA: 0x002162CE File Offset: 0x002144CE
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

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x0600E2CD RID: 58061 RVA: 0x00216302 File Offset: 0x00214502
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

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x0600E2CE RID: 58062 RVA: 0x00216338 File Offset: 0x00214538
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

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x0600E2CF RID: 58063 RVA: 0x002163B8 File Offset: 0x002145B8
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

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x0600E2D0 RID: 58064 RVA: 0x00216438 File Offset: 0x00214638
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

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x0600E2D1 RID: 58065 RVA: 0x002164B8 File Offset: 0x002146B8
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

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x0600E2D2 RID: 58066 RVA: 0x00216538 File Offset: 0x00214738
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

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x0600E2D3 RID: 58067 RVA: 0x002165B6 File Offset: 0x002147B6
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemCenterText_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x0600E2D4 RID: 58068 RVA: 0x002165E5 File Offset: 0x002147E5
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemCenterText_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x0600E2D5 RID: 58069 RVA: 0x00216614 File Offset: 0x00214814
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

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0600E2D6 RID: 58070 RVA: 0x00216648 File Offset: 0x00214848
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemCenterText_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x0600E2D7 RID: 58071 RVA: 0x00216678 File Offset: 0x00214878
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

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x0600E2D8 RID: 58072 RVA: 0x002166B2 File Offset: 0x002148B2
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

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x0600E2D9 RID: 58073 RVA: 0x002166E6 File Offset: 0x002148E6
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

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x0600E2DA RID: 58074 RVA: 0x0021671C File Offset: 0x0021491C
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

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x0600E2DB RID: 58075 RVA: 0x0021679C File Offset: 0x0021499C
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

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x0021681C File Offset: 0x00214A1C
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemCenterText_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x0021686C File Offset: 0x00214A6C
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

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x002168EA File Offset: 0x00214AEA
		public virtual IShowCenterTextParams CenterTextConfig
		{
			get
			{
				if (this._CenterTextConfigInited)
				{
					return this._CenterTextConfigCache;
				}
				this._CenterTextConfigInited = true;
				this._CenterTextConfigCache = IShowCenterTextParams.Create(this.Instance.CenterTextConfig);
				return this._CenterTextConfigCache;
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x0600E2DF RID: 58079 RVA: 0x00216920 File Offset: 0x00214B20
		public virtual bool? _IsPlotActionForPreview
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance._IsPlotActionForPreview);
			}
		}

		// Token: 0x04007B99 RID: 31641
		private ITalkItemCenterText Instance;

		// Token: 0x04007B9A RID: 31642
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007B9B RID: 31643
		private bool _CaptionParamsInited;

		// Token: 0x04007B9C RID: 31644
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007B9D RID: 31645
		private bool _ActionsInited;

		// Token: 0x04007B9E RID: 31646
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007B9F RID: 31647
		private bool _OptionsInited;

		// Token: 0x04007BA0 RID: 31648
		private PlayMontage _MontageCache;

		// Token: 0x04007BA1 RID: 31649
		private bool _MontageInited;

		// Token: 0x04007BA2 RID: 31650
		private ICameraData _CameraDataCache;

		// Token: 0x04007BA3 RID: 31651
		private bool _CameraDataInited;

		// Token: 0x04007BA4 RID: 31652
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007BA5 RID: 31653
		private bool _FlowTemplateInited;

		// Token: 0x04007BA6 RID: 31654
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007BA7 RID: 31655
		private bool _FlowTemplateListInited;

		// Token: 0x04007BA8 RID: 31656
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007BA9 RID: 31657
		private bool _ActorMontageArrayInited;

		// Token: 0x04007BAA RID: 31658
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007BAB RID: 31659
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007BAC RID: 31660
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007BAD RID: 31661
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007BAE RID: 31662
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007BAF RID: 31663
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007BB0 RID: 31664
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007BB1 RID: 31665
		private bool _TalkAkEventInited;

		// Token: 0x04007BB2 RID: 31666
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007BB3 RID: 31667
		private bool _TalkEndAkEventInited;

		// Token: 0x04007BB4 RID: 31668
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007BB5 RID: 31669
		private bool _UniversalToneInited;

		// Token: 0x04007BB6 RID: 31670
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007BB7 RID: 31671
		private bool _BackgroundConfigInited;

		// Token: 0x04007BB8 RID: 31672
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007BB9 RID: 31673
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007BBA RID: 31674
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007BBB RID: 31675
		private bool _GamepadShakeInited;

		// Token: 0x04007BBC RID: 31676
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007BBD RID: 31677
		private bool _IntroActionsInited;

		// Token: 0x04007BBE RID: 31678
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007BBF RID: 31679
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007BC0 RID: 31680
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007BC1 RID: 31681
		private bool _TalkEffectArrayInited;

		// Token: 0x04007BC2 RID: 31682
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007BC3 RID: 31683
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007BC4 RID: 31684
		private IShowCenterTextParams _CenterTextConfigCache;

		// Token: 0x04007BC5 RID: 31685
		private bool _CenterTextConfigInited;
	}
}
