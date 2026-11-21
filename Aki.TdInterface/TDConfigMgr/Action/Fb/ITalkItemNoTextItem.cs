using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FB RID: 10235
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemNoTextItem : ITalkItem
	{
		// Token: 0x0600E305 RID: 58117 RVA: 0x002172D3 File Offset: 0x002154D3
		[NullableContext(0)]
		public static ITalkItemNoTextItem Create(ITalkItemNoTextItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemNoTextItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x0600E306 RID: 58118 RVA: 0x002172F4 File Offset: 0x002154F4
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

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x0600E307 RID: 58119 RVA: 0x0021732A File Offset: 0x0021552A
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x00217338 File Offset: 0x00215538
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

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0600E309 RID: 58121 RVA: 0x0021736E File Offset: 0x0021556E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0600E30A RID: 58122 RVA: 0x0021737B File Offset: 0x0021557B
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0600E30B RID: 58123 RVA: 0x00217388 File Offset: 0x00215588
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

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0600E30C RID: 58124 RVA: 0x002173C0 File Offset: 0x002155C0
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

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x0600E30D RID: 58125 RVA: 0x002173F8 File Offset: 0x002155F8
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

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x00217430 File Offset: 0x00215630
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

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x0600E30F RID: 58127 RVA: 0x00217467 File Offset: 0x00215667
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x0600E310 RID: 58128 RVA: 0x00217474 File Offset: 0x00215674
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

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x0600E311 RID: 58129 RVA: 0x002174AB File Offset: 0x002156AB
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

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x0600E312 RID: 58130 RVA: 0x002174E0 File Offset: 0x002156E0
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

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0600E313 RID: 58131 RVA: 0x00217560 File Offset: 0x00215760
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

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0600E314 RID: 58132 RVA: 0x002175DE File Offset: 0x002157DE
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

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0600E315 RID: 58133 RVA: 0x00217612 File Offset: 0x00215812
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

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0600E316 RID: 58134 RVA: 0x00217646 File Offset: 0x00215846
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

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x0600E317 RID: 58135 RVA: 0x0021767C File Offset: 0x0021587C
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

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x0600E318 RID: 58136 RVA: 0x002176FC File Offset: 0x002158FC
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

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x0600E319 RID: 58137 RVA: 0x0021777C File Offset: 0x0021597C
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

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x0600E31A RID: 58138 RVA: 0x002177FC File Offset: 0x002159FC
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

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0600E31B RID: 58139 RVA: 0x0021787C File Offset: 0x00215A7C
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

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x0600E31C RID: 58140 RVA: 0x002178FA File Offset: 0x00215AFA
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemNoTextItem_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x0600E31D RID: 58141 RVA: 0x00217929 File Offset: 0x00215B29
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemNoTextItem_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x0600E31E RID: 58142 RVA: 0x00217958 File Offset: 0x00215B58
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

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x0600E31F RID: 58143 RVA: 0x0021798C File Offset: 0x00215B8C
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemNoTextItem_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x0600E320 RID: 58144 RVA: 0x002179BC File Offset: 0x00215BBC
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

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x0600E321 RID: 58145 RVA: 0x002179F6 File Offset: 0x00215BF6
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

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x0600E322 RID: 58146 RVA: 0x00217A2A File Offset: 0x00215C2A
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

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x0600E323 RID: 58147 RVA: 0x00217A60 File Offset: 0x00215C60
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

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x0600E324 RID: 58148 RVA: 0x00217AE0 File Offset: 0x00215CE0
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

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x0600E325 RID: 58149 RVA: 0x00217B60 File Offset: 0x00215D60
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemNoTextItem_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x0600E326 RID: 58150 RVA: 0x00217BB0 File Offset: 0x00215DB0
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

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x0600E327 RID: 58151 RVA: 0x00217C2E File Offset: 0x00215E2E
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
				this._CameraMotionCache = ActionReadHelper.ReadITalkItemNoTextItem_CameraMotion(this.Instance);
				return this._CameraMotionCache;
			}
		}

		// Token: 0x04007BF1 RID: 31729
		private ITalkItemNoTextItem Instance;

		// Token: 0x04007BF2 RID: 31730
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007BF3 RID: 31731
		private bool _CaptionParamsInited;

		// Token: 0x04007BF4 RID: 31732
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007BF5 RID: 31733
		private bool _ActionsInited;

		// Token: 0x04007BF6 RID: 31734
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007BF7 RID: 31735
		private bool _OptionsInited;

		// Token: 0x04007BF8 RID: 31736
		private PlayMontage _MontageCache;

		// Token: 0x04007BF9 RID: 31737
		private bool _MontageInited;

		// Token: 0x04007BFA RID: 31738
		private ICameraData _CameraDataCache;

		// Token: 0x04007BFB RID: 31739
		private bool _CameraDataInited;

		// Token: 0x04007BFC RID: 31740
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007BFD RID: 31741
		private bool _FlowTemplateInited;

		// Token: 0x04007BFE RID: 31742
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007BFF RID: 31743
		private bool _FlowTemplateListInited;

		// Token: 0x04007C00 RID: 31744
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007C01 RID: 31745
		private bool _ActorMontageArrayInited;

		// Token: 0x04007C02 RID: 31746
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007C03 RID: 31747
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007C04 RID: 31748
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007C05 RID: 31749
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007C06 RID: 31750
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007C07 RID: 31751
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007C08 RID: 31752
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007C09 RID: 31753
		private bool _TalkAkEventInited;

		// Token: 0x04007C0A RID: 31754
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007C0B RID: 31755
		private bool _TalkEndAkEventInited;

		// Token: 0x04007C0C RID: 31756
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007C0D RID: 31757
		private bool _UniversalToneInited;

		// Token: 0x04007C0E RID: 31758
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007C0F RID: 31759
		private bool _BackgroundConfigInited;

		// Token: 0x04007C10 RID: 31760
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007C11 RID: 31761
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007C12 RID: 31762
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007C13 RID: 31763
		private bool _GamepadShakeInited;

		// Token: 0x04007C14 RID: 31764
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007C15 RID: 31765
		private bool _IntroActionsInited;

		// Token: 0x04007C16 RID: 31766
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007C17 RID: 31767
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007C18 RID: 31768
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007C19 RID: 31769
		private bool _TalkEffectArrayInited;

		// Token: 0x04007C1A RID: 31770
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007C1B RID: 31771
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007C1C RID: 31772
		[Nullable(0)]
		private IShowTalkCameraMotion _CameraMotionCache;

		// Token: 0x04007C1D RID: 31773
		private bool _CameraMotionInited;
	}
}
