using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F1 RID: 10225
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemOption : ITalkItem
	{
		// Token: 0x0600E253 RID: 57939 RVA: 0x002146BA File Offset: 0x002128BA
		[NullableContext(0)]
		public static ITalkItemOption Create(ITalkItemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0600E254 RID: 57940 RVA: 0x002146DC File Offset: 0x002128DC
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

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0600E255 RID: 57941 RVA: 0x00214712 File Offset: 0x00212912
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0600E256 RID: 57942 RVA: 0x00214720 File Offset: 0x00212920
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

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x0600E257 RID: 57943 RVA: 0x00214756 File Offset: 0x00212956
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00214763 File Offset: 0x00212963
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00214770 File Offset: 0x00212970
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

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0600E25A RID: 57946 RVA: 0x002147A8 File Offset: 0x002129A8
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

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0600E25B RID: 57947 RVA: 0x002147E0 File Offset: 0x002129E0
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

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x0600E25C RID: 57948 RVA: 0x00214818 File Offset: 0x00212A18
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

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0600E25D RID: 57949 RVA: 0x0021484F File Offset: 0x00212A4F
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x0600E25E RID: 57950 RVA: 0x0021485C File Offset: 0x00212A5C
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

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0600E25F RID: 57951 RVA: 0x00214893 File Offset: 0x00212A93
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

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0600E260 RID: 57952 RVA: 0x002148C8 File Offset: 0x00212AC8
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

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0600E261 RID: 57953 RVA: 0x00214948 File Offset: 0x00212B48
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

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0600E262 RID: 57954 RVA: 0x002149C6 File Offset: 0x00212BC6
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

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x0600E263 RID: 57955 RVA: 0x002149FA File Offset: 0x00212BFA
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

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0600E264 RID: 57956 RVA: 0x00214A2E File Offset: 0x00212C2E
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

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x0600E265 RID: 57957 RVA: 0x00214A64 File Offset: 0x00212C64
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

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x0600E266 RID: 57958 RVA: 0x00214AE4 File Offset: 0x00212CE4
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

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x0600E267 RID: 57959 RVA: 0x00214B64 File Offset: 0x00212D64
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

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0600E268 RID: 57960 RVA: 0x00214BE4 File Offset: 0x00212DE4
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

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x0600E269 RID: 57961 RVA: 0x00214C64 File Offset: 0x00212E64
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

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0600E26A RID: 57962 RVA: 0x00214CE2 File Offset: 0x00212EE2
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0600E26B RID: 57963 RVA: 0x00214D11 File Offset: 0x00212F11
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x0600E26C RID: 57964 RVA: 0x00214D40 File Offset: 0x00212F40
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

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0600E26D RID: 57965 RVA: 0x00214D74 File Offset: 0x00212F74
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0600E26E RID: 57966 RVA: 0x00214DA4 File Offset: 0x00212FA4
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

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x0600E26F RID: 57967 RVA: 0x00214DDE File Offset: 0x00212FDE
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

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x0600E270 RID: 57968 RVA: 0x00214E12 File Offset: 0x00213012
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

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x0600E271 RID: 57969 RVA: 0x00214E48 File Offset: 0x00213048
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

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x0600E272 RID: 57970 RVA: 0x00214EC8 File Offset: 0x002130C8
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

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x0600E273 RID: 57971 RVA: 0x00214F48 File Offset: 0x00213148
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x0600E274 RID: 57972 RVA: 0x00214F98 File Offset: 0x00213198
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

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x0600E275 RID: 57973 RVA: 0x00215016 File Offset: 0x00213216
		[Nullable(0)]
		public virtual IShowTalkCameraMotion CameraMotion
		{
			[NullableContext(0)]
			get
			{
				if (this._CameraMotionInited)
				{
					return this._CameraMotionCache;
				}
				this._CameraMotionInited = true;
				this._CameraMotionCache = ActionReadHelper.ReadITalkItemOption_CameraMotion(this.Instance);
				return this._CameraMotionCache;
			}
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x0600E276 RID: 57974 RVA: 0x00215045 File Offset: 0x00213245
		public virtual ITalkItemAutoPlayConfig AutoPlayConfig
		{
			get
			{
				if (this._AutoPlayConfigInited)
				{
					return this._AutoPlayConfigCache;
				}
				this._AutoPlayConfigInited = true;
				this._AutoPlayConfigCache = ITalkItemAutoPlayConfig.Create(this.Instance.AutoPlayConfig);
				return this._AutoPlayConfigCache;
			}
		}

		// Token: 0x04007B29 RID: 31529
		private ITalkItemOption Instance;

		// Token: 0x04007B2A RID: 31530
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007B2B RID: 31531
		private bool _CaptionParamsInited;

		// Token: 0x04007B2C RID: 31532
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007B2D RID: 31533
		private bool _ActionsInited;

		// Token: 0x04007B2E RID: 31534
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007B2F RID: 31535
		private bool _OptionsInited;

		// Token: 0x04007B30 RID: 31536
		private PlayMontage _MontageCache;

		// Token: 0x04007B31 RID: 31537
		private bool _MontageInited;

		// Token: 0x04007B32 RID: 31538
		private ICameraData _CameraDataCache;

		// Token: 0x04007B33 RID: 31539
		private bool _CameraDataInited;

		// Token: 0x04007B34 RID: 31540
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007B35 RID: 31541
		private bool _FlowTemplateInited;

		// Token: 0x04007B36 RID: 31542
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007B37 RID: 31543
		private bool _FlowTemplateListInited;

		// Token: 0x04007B38 RID: 31544
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007B39 RID: 31545
		private bool _ActorMontageArrayInited;

		// Token: 0x04007B3A RID: 31546
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007B3B RID: 31547
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007B3C RID: 31548
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007B3D RID: 31549
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007B3E RID: 31550
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007B3F RID: 31551
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007B40 RID: 31552
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007B41 RID: 31553
		private bool _TalkAkEventInited;

		// Token: 0x04007B42 RID: 31554
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007B43 RID: 31555
		private bool _TalkEndAkEventInited;

		// Token: 0x04007B44 RID: 31556
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007B45 RID: 31557
		private bool _UniversalToneInited;

		// Token: 0x04007B46 RID: 31558
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007B47 RID: 31559
		private bool _BackgroundConfigInited;

		// Token: 0x04007B48 RID: 31560
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007B49 RID: 31561
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007B4A RID: 31562
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007B4B RID: 31563
		private bool _GamepadShakeInited;

		// Token: 0x04007B4C RID: 31564
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007B4D RID: 31565
		private bool _IntroActionsInited;

		// Token: 0x04007B4E RID: 31566
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007B4F RID: 31567
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007B50 RID: 31568
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007B51 RID: 31569
		private bool _TalkEffectArrayInited;

		// Token: 0x04007B52 RID: 31570
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007B53 RID: 31571
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007B54 RID: 31572
		[Nullable(0)]
		private IShowTalkCameraMotion _CameraMotionCache;

		// Token: 0x04007B55 RID: 31573
		private bool _CameraMotionInited;

		// Token: 0x04007B56 RID: 31574
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x04007B57 RID: 31575
		private bool _AutoPlayConfigInited;
	}
}
