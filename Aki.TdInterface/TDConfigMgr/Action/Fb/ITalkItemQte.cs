using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FA RID: 10234
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemQte : ITalkItem
	{
		// Token: 0x0600E2E1 RID: 58081 RVA: 0x00216962 File Offset: 0x00214B62
		[NullableContext(0)]
		public static ITalkItemQte Create(ITalkItemQte? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemQte
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x0600E2E2 RID: 58082 RVA: 0x00216984 File Offset: 0x00214B84
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

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x0600E2E3 RID: 58083 RVA: 0x002169BA File Offset: 0x00214BBA
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x002169C8 File Offset: 0x00214BC8
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

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x002169FE File Offset: 0x00214BFE
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x0600E2E6 RID: 58086 RVA: 0x00216A0B File Offset: 0x00214C0B
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x0600E2E7 RID: 58087 RVA: 0x00216A18 File Offset: 0x00214C18
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

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x0600E2E8 RID: 58088 RVA: 0x00216A50 File Offset: 0x00214C50
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

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x0600E2E9 RID: 58089 RVA: 0x00216A88 File Offset: 0x00214C88
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

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x0600E2EA RID: 58090 RVA: 0x00216AC0 File Offset: 0x00214CC0
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

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x0600E2EB RID: 58091 RVA: 0x00216AF7 File Offset: 0x00214CF7
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x0600E2EC RID: 58092 RVA: 0x00216B04 File Offset: 0x00214D04
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

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x0600E2ED RID: 58093 RVA: 0x00216B3B File Offset: 0x00214D3B
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

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x0600E2EE RID: 58094 RVA: 0x00216B70 File Offset: 0x00214D70
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

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x0600E2EF RID: 58095 RVA: 0x00216BF0 File Offset: 0x00214DF0
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

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x0600E2F0 RID: 58096 RVA: 0x00216C6E File Offset: 0x00214E6E
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

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x0600E2F1 RID: 58097 RVA: 0x00216CA2 File Offset: 0x00214EA2
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

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x0600E2F2 RID: 58098 RVA: 0x00216CD6 File Offset: 0x00214ED6
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

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x00216D0C File Offset: 0x00214F0C
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

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x00216D8C File Offset: 0x00214F8C
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

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x00216E0C File Offset: 0x0021500C
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

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x0600E2F6 RID: 58102 RVA: 0x00216E8C File Offset: 0x0021508C
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

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x00216F0C File Offset: 0x0021510C
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

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x00216F8A File Offset: 0x0021518A
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemQte_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x00216FB9 File Offset: 0x002151B9
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemQte_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x0600E2FA RID: 58106 RVA: 0x00216FE8 File Offset: 0x002151E8
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

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0600E2FB RID: 58107 RVA: 0x0021701C File Offset: 0x0021521C
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemQte_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x0021704C File Offset: 0x0021524C
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

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x00217086 File Offset: 0x00215286
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

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x002170BA File Offset: 0x002152BA
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

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x002170F0 File Offset: 0x002152F0
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

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0600E300 RID: 58112 RVA: 0x00217170 File Offset: 0x00215370
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

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x0600E301 RID: 58113 RVA: 0x002171F0 File Offset: 0x002153F0
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemQte_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0600E302 RID: 58114 RVA: 0x00217240 File Offset: 0x00215440
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

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x0600E303 RID: 58115 RVA: 0x002172BE File Offset: 0x002154BE
		public virtual int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x04007BC6 RID: 31686
		private ITalkItemQte Instance;

		// Token: 0x04007BC7 RID: 31687
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007BC8 RID: 31688
		private bool _CaptionParamsInited;

		// Token: 0x04007BC9 RID: 31689
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007BCA RID: 31690
		private bool _ActionsInited;

		// Token: 0x04007BCB RID: 31691
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007BCC RID: 31692
		private bool _OptionsInited;

		// Token: 0x04007BCD RID: 31693
		private PlayMontage _MontageCache;

		// Token: 0x04007BCE RID: 31694
		private bool _MontageInited;

		// Token: 0x04007BCF RID: 31695
		private ICameraData _CameraDataCache;

		// Token: 0x04007BD0 RID: 31696
		private bool _CameraDataInited;

		// Token: 0x04007BD1 RID: 31697
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007BD2 RID: 31698
		private bool _FlowTemplateInited;

		// Token: 0x04007BD3 RID: 31699
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007BD4 RID: 31700
		private bool _FlowTemplateListInited;

		// Token: 0x04007BD5 RID: 31701
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007BD6 RID: 31702
		private bool _ActorMontageArrayInited;

		// Token: 0x04007BD7 RID: 31703
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007BD8 RID: 31704
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007BD9 RID: 31705
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007BDA RID: 31706
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007BDB RID: 31707
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007BDC RID: 31708
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007BDD RID: 31709
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007BDE RID: 31710
		private bool _TalkAkEventInited;

		// Token: 0x04007BDF RID: 31711
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007BE0 RID: 31712
		private bool _TalkEndAkEventInited;

		// Token: 0x04007BE1 RID: 31713
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007BE2 RID: 31714
		private bool _UniversalToneInited;

		// Token: 0x04007BE3 RID: 31715
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007BE4 RID: 31716
		private bool _BackgroundConfigInited;

		// Token: 0x04007BE5 RID: 31717
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007BE6 RID: 31718
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007BE7 RID: 31719
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007BE8 RID: 31720
		private bool _GamepadShakeInited;

		// Token: 0x04007BE9 RID: 31721
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007BEA RID: 31722
		private bool _IntroActionsInited;

		// Token: 0x04007BEB RID: 31723
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007BEC RID: 31724
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007BED RID: 31725
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007BEE RID: 31726
		private bool _TalkEffectArrayInited;

		// Token: 0x04007BEF RID: 31727
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007BF0 RID: 31728
		private bool _ActorVisibilityArrayInited;
	}
}
