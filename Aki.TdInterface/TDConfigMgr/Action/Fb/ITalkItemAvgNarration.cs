using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200255E RID: 9566
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgNarration : ITalkItem
	{
		// Token: 0x0600D68E RID: 54926 RVA: 0x001FF2DA File Offset: 0x001FD4DA
		[NullableContext(1)]
		public static ITalkItemAvgNarration Create(ITalkItemAvgNarration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgNarration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600D68F RID: 54927 RVA: 0x001FF2FC File Offset: 0x001FD4FC
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

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600D690 RID: 54928 RVA: 0x001FF332 File Offset: 0x001FD532
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x0600D691 RID: 54929 RVA: 0x001FF340 File Offset: 0x001FD540
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

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600D692 RID: 54930 RVA: 0x001FF376 File Offset: 0x001FD576
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600D693 RID: 54931 RVA: 0x001FF383 File Offset: 0x001FD583
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600D694 RID: 54932 RVA: 0x001FF390 File Offset: 0x001FD590
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

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600D695 RID: 54933 RVA: 0x001FF3C8 File Offset: 0x001FD5C8
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

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600D696 RID: 54934 RVA: 0x001FF400 File Offset: 0x001FD600
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

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600D697 RID: 54935 RVA: 0x001FF438 File Offset: 0x001FD638
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

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600D698 RID: 54936 RVA: 0x001FF46F File Offset: 0x001FD66F
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600D699 RID: 54937 RVA: 0x001FF47C File Offset: 0x001FD67C
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

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600D69A RID: 54938 RVA: 0x001FF4B3 File Offset: 0x001FD6B3
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

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600D69B RID: 54939 RVA: 0x001FF4E8 File Offset: 0x001FD6E8
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

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600D69C RID: 54940 RVA: 0x001FF568 File Offset: 0x001FD768
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

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600D69D RID: 54941 RVA: 0x001FF5E6 File Offset: 0x001FD7E6
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

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600D69E RID: 54942 RVA: 0x001FF61A File Offset: 0x001FD81A
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

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x0600D69F RID: 54943 RVA: 0x001FF64E File Offset: 0x001FD84E
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

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x001FF684 File Offset: 0x001FD884
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

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600D6A1 RID: 54945 RVA: 0x001FF704 File Offset: 0x001FD904
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

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600D6A2 RID: 54946 RVA: 0x001FF784 File Offset: 0x001FD984
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

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600D6A3 RID: 54947 RVA: 0x001FF804 File Offset: 0x001FDA04
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

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600D6A4 RID: 54948 RVA: 0x001FF884 File Offset: 0x001FDA84
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

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600D6A5 RID: 54949 RVA: 0x001FF902 File Offset: 0x001FDB02
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgNarration_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600D6A6 RID: 54950 RVA: 0x001FF931 File Offset: 0x001FDB31
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgNarration_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600D6A7 RID: 54951 RVA: 0x001FF960 File Offset: 0x001FDB60
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

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600D6A8 RID: 54952 RVA: 0x001FF994 File Offset: 0x001FDB94
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgNarration_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x0600D6A9 RID: 54953 RVA: 0x001FF9C4 File Offset: 0x001FDBC4
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

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x0600D6AA RID: 54954 RVA: 0x001FF9FE File Offset: 0x001FDBFE
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

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x0600D6AB RID: 54955 RVA: 0x001FFA32 File Offset: 0x001FDC32
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

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x0600D6AC RID: 54956 RVA: 0x001FFA68 File Offset: 0x001FDC68
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

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600D6AD RID: 54957 RVA: 0x001FFAE8 File Offset: 0x001FDCE8
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

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600D6AE RID: 54958 RVA: 0x001FFB68 File Offset: 0x001FDD68
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgNarration_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x001FFBB8 File Offset: 0x001FDDB8
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

		// Token: 0x040076A8 RID: 30376
		private ITalkItemAvgNarration Instance;

		// Token: 0x040076A9 RID: 30377
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040076AA RID: 30378
		private bool _CaptionParamsInited;

		// Token: 0x040076AB RID: 30379
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040076AC RID: 30380
		private bool _ActionsInited;

		// Token: 0x040076AD RID: 30381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040076AE RID: 30382
		private bool _OptionsInited;

		// Token: 0x040076AF RID: 30383
		private PlayMontage _MontageCache;

		// Token: 0x040076B0 RID: 30384
		private bool _MontageInited;

		// Token: 0x040076B1 RID: 30385
		private ICameraData _CameraDataCache;

		// Token: 0x040076B2 RID: 30386
		private bool _CameraDataInited;

		// Token: 0x040076B3 RID: 30387
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040076B4 RID: 30388
		private bool _FlowTemplateInited;

		// Token: 0x040076B5 RID: 30389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040076B6 RID: 30390
		private bool _FlowTemplateListInited;

		// Token: 0x040076B7 RID: 30391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040076B8 RID: 30392
		private bool _ActorMontageArrayInited;

		// Token: 0x040076B9 RID: 30393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040076BA RID: 30394
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040076BB RID: 30395
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040076BC RID: 30396
		private bool _ActorLookAtArrayInited;

		// Token: 0x040076BD RID: 30397
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040076BE RID: 30398
		private bool _ActorTurnToArrayInited;

		// Token: 0x040076BF RID: 30399
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040076C0 RID: 30400
		private bool _TalkAkEventInited;

		// Token: 0x040076C1 RID: 30401
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040076C2 RID: 30402
		private bool _TalkEndAkEventInited;

		// Token: 0x040076C3 RID: 30403
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040076C4 RID: 30404
		private bool _UniversalToneInited;

		// Token: 0x040076C5 RID: 30405
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040076C6 RID: 30406
		private bool _BackgroundConfigInited;

		// Token: 0x040076C7 RID: 30407
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040076C8 RID: 30408
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040076C9 RID: 30409
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040076CA RID: 30410
		private bool _GamepadShakeInited;

		// Token: 0x040076CB RID: 30411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040076CC RID: 30412
		private bool _IntroActionsInited;

		// Token: 0x040076CD RID: 30413
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040076CE RID: 30414
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040076CF RID: 30415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040076D0 RID: 30416
		private bool _TalkEffectArrayInited;

		// Token: 0x040076D1 RID: 30417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040076D2 RID: 30418
		private bool _ActorVisibilityArrayInited;
	}
}
