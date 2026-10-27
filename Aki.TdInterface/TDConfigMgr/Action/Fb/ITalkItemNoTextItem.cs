using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002552 RID: 9554
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemNoTextItem : ITalkItem
	{
		// Token: 0x0600D59B RID: 54683 RVA: 0x001FB6D7 File Offset: 0x001F98D7
		[NullableContext(1)]
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

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600D59C RID: 54684 RVA: 0x001FB6F8 File Offset: 0x001F98F8
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

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600D59D RID: 54685 RVA: 0x001FB72E File Offset: 0x001F992E
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600D59E RID: 54686 RVA: 0x001FB73C File Offset: 0x001F993C
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

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600D59F RID: 54687 RVA: 0x001FB772 File Offset: 0x001F9972
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600D5A0 RID: 54688 RVA: 0x001FB77F File Offset: 0x001F997F
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600D5A1 RID: 54689 RVA: 0x001FB78C File Offset: 0x001F998C
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

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0600D5A2 RID: 54690 RVA: 0x001FB7C4 File Offset: 0x001F99C4
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

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600D5A3 RID: 54691 RVA: 0x001FB7FC File Offset: 0x001F99FC
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

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600D5A4 RID: 54692 RVA: 0x001FB834 File Offset: 0x001F9A34
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

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600D5A5 RID: 54693 RVA: 0x001FB86B File Offset: 0x001F9A6B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600D5A6 RID: 54694 RVA: 0x001FB878 File Offset: 0x001F9A78
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

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x001FB8AF File Offset: 0x001F9AAF
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

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600D5A8 RID: 54696 RVA: 0x001FB8E4 File Offset: 0x001F9AE4
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

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600D5A9 RID: 54697 RVA: 0x001FB964 File Offset: 0x001F9B64
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

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600D5AA RID: 54698 RVA: 0x001FB9E2 File Offset: 0x001F9BE2
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

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x001FBA16 File Offset: 0x001F9C16
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

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x001FBA4A File Offset: 0x001F9C4A
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

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x0600D5AD RID: 54701 RVA: 0x001FBA80 File Offset: 0x001F9C80
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

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0600D5AE RID: 54702 RVA: 0x001FBB00 File Offset: 0x001F9D00
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

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0600D5AF RID: 54703 RVA: 0x001FBB80 File Offset: 0x001F9D80
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

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0600D5B0 RID: 54704 RVA: 0x001FBC00 File Offset: 0x001F9E00
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

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x001FBC80 File Offset: 0x001F9E80
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

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600D5B2 RID: 54706 RVA: 0x001FBCFE File Offset: 0x001F9EFE
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemNoTextItem_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600D5B3 RID: 54707 RVA: 0x001FBD2D File Offset: 0x001F9F2D
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemNoTextItem_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600D5B4 RID: 54708 RVA: 0x001FBD5C File Offset: 0x001F9F5C
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

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600D5B5 RID: 54709 RVA: 0x001FBD90 File Offset: 0x001F9F90
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemNoTextItem_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x0600D5B6 RID: 54710 RVA: 0x001FBDC0 File Offset: 0x001F9FC0
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

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x0600D5B7 RID: 54711 RVA: 0x001FBDFA File Offset: 0x001F9FFA
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

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600D5B8 RID: 54712 RVA: 0x001FBE2E File Offset: 0x001FA02E
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

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600D5B9 RID: 54713 RVA: 0x001FBE64 File Offset: 0x001FA064
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

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x001FBEE4 File Offset: 0x001FA0E4
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

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600D5BB RID: 54715 RVA: 0x001FBF64 File Offset: 0x001FA164
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemNoTextItem_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600D5BC RID: 54716 RVA: 0x001FBFB4 File Offset: 0x001FA1B4
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

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600D5BD RID: 54717 RVA: 0x001FC032 File Offset: 0x001FA232
		[Nullable(1)]
		public virtual IShowTalkCameraMotion CameraMotion
		{
			[NullableContext(1)]
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

		// Token: 0x04007594 RID: 30100
		private ITalkItemNoTextItem Instance;

		// Token: 0x04007595 RID: 30101
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007596 RID: 30102
		private bool _CaptionParamsInited;

		// Token: 0x04007597 RID: 30103
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007598 RID: 30104
		private bool _ActionsInited;

		// Token: 0x04007599 RID: 30105
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x0400759A RID: 30106
		private bool _OptionsInited;

		// Token: 0x0400759B RID: 30107
		private PlayMontage _MontageCache;

		// Token: 0x0400759C RID: 30108
		private bool _MontageInited;

		// Token: 0x0400759D RID: 30109
		private ICameraData _CameraDataCache;

		// Token: 0x0400759E RID: 30110
		private bool _CameraDataInited;

		// Token: 0x0400759F RID: 30111
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040075A0 RID: 30112
		private bool _FlowTemplateInited;

		// Token: 0x040075A1 RID: 30113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040075A2 RID: 30114
		private bool _FlowTemplateListInited;

		// Token: 0x040075A3 RID: 30115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040075A4 RID: 30116
		private bool _ActorMontageArrayInited;

		// Token: 0x040075A5 RID: 30117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040075A6 RID: 30118
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040075A7 RID: 30119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040075A8 RID: 30120
		private bool _ActorLookAtArrayInited;

		// Token: 0x040075A9 RID: 30121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040075AA RID: 30122
		private bool _ActorTurnToArrayInited;

		// Token: 0x040075AB RID: 30123
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040075AC RID: 30124
		private bool _TalkAkEventInited;

		// Token: 0x040075AD RID: 30125
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040075AE RID: 30126
		private bool _TalkEndAkEventInited;

		// Token: 0x040075AF RID: 30127
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040075B0 RID: 30128
		private bool _UniversalToneInited;

		// Token: 0x040075B1 RID: 30129
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040075B2 RID: 30130
		private bool _BackgroundConfigInited;

		// Token: 0x040075B3 RID: 30131
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040075B4 RID: 30132
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040075B5 RID: 30133
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040075B6 RID: 30134
		private bool _GamepadShakeInited;

		// Token: 0x040075B7 RID: 30135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040075B8 RID: 30136
		private bool _IntroActionsInited;

		// Token: 0x040075B9 RID: 30137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040075BA RID: 30138
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040075BB RID: 30139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040075BC RID: 30140
		private bool _TalkEffectArrayInited;

		// Token: 0x040075BD RID: 30141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040075BE RID: 30142
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040075BF RID: 30143
		[Nullable(1)]
		private IShowTalkCameraMotion _CameraMotionCache;

		// Token: 0x040075C0 RID: 30144
		private bool _CameraMotionInited;
	}
}
