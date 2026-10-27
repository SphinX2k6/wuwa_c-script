using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002551 RID: 9553
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemQte : ITalkItem
	{
		// Token: 0x0600D577 RID: 54647 RVA: 0x001FAD66 File Offset: 0x001F8F66
		[NullableContext(1)]
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

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600D578 RID: 54648 RVA: 0x001FAD88 File Offset: 0x001F8F88
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

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600D579 RID: 54649 RVA: 0x001FADBE File Offset: 0x001F8FBE
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600D57A RID: 54650 RVA: 0x001FADCC File Offset: 0x001F8FCC
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

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600D57B RID: 54651 RVA: 0x001FAE02 File Offset: 0x001F9002
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600D57C RID: 54652 RVA: 0x001FAE0F File Offset: 0x001F900F
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600D57D RID: 54653 RVA: 0x001FAE1C File Offset: 0x001F901C
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

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600D57E RID: 54654 RVA: 0x001FAE54 File Offset: 0x001F9054
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

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0600D57F RID: 54655 RVA: 0x001FAE8C File Offset: 0x001F908C
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

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0600D580 RID: 54656 RVA: 0x001FAEC4 File Offset: 0x001F90C4
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

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600D581 RID: 54657 RVA: 0x001FAEFB File Offset: 0x001F90FB
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600D582 RID: 54658 RVA: 0x001FAF08 File Offset: 0x001F9108
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

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600D583 RID: 54659 RVA: 0x001FAF3F File Offset: 0x001F913F
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

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600D584 RID: 54660 RVA: 0x001FAF74 File Offset: 0x001F9174
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

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600D585 RID: 54661 RVA: 0x001FAFF4 File Offset: 0x001F91F4
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

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x001FB072 File Offset: 0x001F9272
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

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600D587 RID: 54663 RVA: 0x001FB0A6 File Offset: 0x001F92A6
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

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600D588 RID: 54664 RVA: 0x001FB0DA File Offset: 0x001F92DA
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

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600D589 RID: 54665 RVA: 0x001FB110 File Offset: 0x001F9310
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

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600D58A RID: 54666 RVA: 0x001FB190 File Offset: 0x001F9390
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

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600D58B RID: 54667 RVA: 0x001FB210 File Offset: 0x001F9410
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

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600D58C RID: 54668 RVA: 0x001FB290 File Offset: 0x001F9490
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

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600D58D RID: 54669 RVA: 0x001FB310 File Offset: 0x001F9510
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

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600D58E RID: 54670 RVA: 0x001FB38E File Offset: 0x001F958E
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemQte_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600D58F RID: 54671 RVA: 0x001FB3BD File Offset: 0x001F95BD
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemQte_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600D590 RID: 54672 RVA: 0x001FB3EC File Offset: 0x001F95EC
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

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600D591 RID: 54673 RVA: 0x001FB420 File Offset: 0x001F9620
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemQte_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600D592 RID: 54674 RVA: 0x001FB450 File Offset: 0x001F9650
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

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600D593 RID: 54675 RVA: 0x001FB48A File Offset: 0x001F968A
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

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0600D594 RID: 54676 RVA: 0x001FB4BE File Offset: 0x001F96BE
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

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600D595 RID: 54677 RVA: 0x001FB4F4 File Offset: 0x001F96F4
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

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600D596 RID: 54678 RVA: 0x001FB574 File Offset: 0x001F9774
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

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600D597 RID: 54679 RVA: 0x001FB5F4 File Offset: 0x001F97F4
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemQte_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600D598 RID: 54680 RVA: 0x001FB644 File Offset: 0x001F9844
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

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600D599 RID: 54681 RVA: 0x001FB6C2 File Offset: 0x001F98C2
		public virtual int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x04007569 RID: 30057
		private ITalkItemQte Instance;

		// Token: 0x0400756A RID: 30058
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x0400756B RID: 30059
		private bool _CaptionParamsInited;

		// Token: 0x0400756C RID: 30060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400756D RID: 30061
		private bool _ActionsInited;

		// Token: 0x0400756E RID: 30062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x0400756F RID: 30063
		private bool _OptionsInited;

		// Token: 0x04007570 RID: 30064
		private PlayMontage _MontageCache;

		// Token: 0x04007571 RID: 30065
		private bool _MontageInited;

		// Token: 0x04007572 RID: 30066
		private ICameraData _CameraDataCache;

		// Token: 0x04007573 RID: 30067
		private bool _CameraDataInited;

		// Token: 0x04007574 RID: 30068
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007575 RID: 30069
		private bool _FlowTemplateInited;

		// Token: 0x04007576 RID: 30070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007577 RID: 30071
		private bool _FlowTemplateListInited;

		// Token: 0x04007578 RID: 30072
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007579 RID: 30073
		private bool _ActorMontageArrayInited;

		// Token: 0x0400757A RID: 30074
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x0400757B RID: 30075
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x0400757C RID: 30076
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x0400757D RID: 30077
		private bool _ActorLookAtArrayInited;

		// Token: 0x0400757E RID: 30078
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x0400757F RID: 30079
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007580 RID: 30080
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007581 RID: 30081
		private bool _TalkAkEventInited;

		// Token: 0x04007582 RID: 30082
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007583 RID: 30083
		private bool _TalkEndAkEventInited;

		// Token: 0x04007584 RID: 30084
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007585 RID: 30085
		private bool _UniversalToneInited;

		// Token: 0x04007586 RID: 30086
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007587 RID: 30087
		private bool _BackgroundConfigInited;

		// Token: 0x04007588 RID: 30088
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007589 RID: 30089
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400758A RID: 30090
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400758B RID: 30091
		private bool _GamepadShakeInited;

		// Token: 0x0400758C RID: 30092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x0400758D RID: 30093
		private bool _IntroActionsInited;

		// Token: 0x0400758E RID: 30094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x0400758F RID: 30095
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007590 RID: 30096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007591 RID: 30097
		private bool _TalkEffectArrayInited;

		// Token: 0x04007592 RID: 30098
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007593 RID: 30099
		private bool _ActorVisibilityArrayInited;
	}
}
