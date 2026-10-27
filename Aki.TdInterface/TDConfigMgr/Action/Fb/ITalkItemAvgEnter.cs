using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200255B RID: 9563
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgEnter : ITalkItem
	{
		// Token: 0x0600D622 RID: 54818 RVA: 0x001FD63B File Offset: 0x001FB83B
		[NullableContext(1)]
		public static ITalkItemAvgEnter Create(ITalkItemAvgEnter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgEnter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x0600D623 RID: 54819 RVA: 0x001FD65C File Offset: 0x001FB85C
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

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x0600D624 RID: 54820 RVA: 0x001FD692 File Offset: 0x001FB892
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0600D625 RID: 54821 RVA: 0x001FD6A0 File Offset: 0x001FB8A0
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

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0600D626 RID: 54822 RVA: 0x001FD6D6 File Offset: 0x001FB8D6
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600D627 RID: 54823 RVA: 0x001FD6E3 File Offset: 0x001FB8E3
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600D628 RID: 54824 RVA: 0x001FD6F0 File Offset: 0x001FB8F0
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

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600D629 RID: 54825 RVA: 0x001FD728 File Offset: 0x001FB928
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

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600D62A RID: 54826 RVA: 0x001FD760 File Offset: 0x001FB960
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

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600D62B RID: 54827 RVA: 0x001FD798 File Offset: 0x001FB998
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

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600D62C RID: 54828 RVA: 0x001FD7CF File Offset: 0x001FB9CF
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600D62D RID: 54829 RVA: 0x001FD7DC File Offset: 0x001FB9DC
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

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0600D62E RID: 54830 RVA: 0x001FD813 File Offset: 0x001FBA13
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

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0600D62F RID: 54831 RVA: 0x001FD848 File Offset: 0x001FBA48
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

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600D630 RID: 54832 RVA: 0x001FD8C8 File Offset: 0x001FBAC8
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

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600D631 RID: 54833 RVA: 0x001FD946 File Offset: 0x001FBB46
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

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600D632 RID: 54834 RVA: 0x001FD97A File Offset: 0x001FBB7A
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

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600D633 RID: 54835 RVA: 0x001FD9AE File Offset: 0x001FBBAE
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

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600D634 RID: 54836 RVA: 0x001FD9E4 File Offset: 0x001FBBE4
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

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600D635 RID: 54837 RVA: 0x001FDA64 File Offset: 0x001FBC64
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

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600D636 RID: 54838 RVA: 0x001FDAE4 File Offset: 0x001FBCE4
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

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600D637 RID: 54839 RVA: 0x001FDB64 File Offset: 0x001FBD64
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

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600D638 RID: 54840 RVA: 0x001FDBE4 File Offset: 0x001FBDE4
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

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600D639 RID: 54841 RVA: 0x001FDC62 File Offset: 0x001FBE62
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgEnter_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600D63A RID: 54842 RVA: 0x001FDC91 File Offset: 0x001FBE91
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgEnter_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600D63B RID: 54843 RVA: 0x001FDCC0 File Offset: 0x001FBEC0
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

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600D63C RID: 54844 RVA: 0x001FDCF4 File Offset: 0x001FBEF4
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgEnter_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600D63D RID: 54845 RVA: 0x001FDD24 File Offset: 0x001FBF24
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

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600D63E RID: 54846 RVA: 0x001FDD5E File Offset: 0x001FBF5E
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

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600D63F RID: 54847 RVA: 0x001FDD92 File Offset: 0x001FBF92
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

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600D640 RID: 54848 RVA: 0x001FDDC8 File Offset: 0x001FBFC8
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

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600D641 RID: 54849 RVA: 0x001FDE48 File Offset: 0x001FC048
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

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600D642 RID: 54850 RVA: 0x001FDEC8 File Offset: 0x001FC0C8
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgEnter_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600D643 RID: 54851 RVA: 0x001FDF18 File Offset: 0x001FC118
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

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600D644 RID: 54852 RVA: 0x001FDF96 File Offset: 0x001FC196
		[Nullable(1)]
		public virtual ITalkItemAvgRoleConfig AvgRoleConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._AvgRoleConfigInited)
				{
					return this._AvgRoleConfigCache;
				}
				this._AvgRoleConfigInited = true;
				this._AvgRoleConfigCache = ITalkItemAvgRoleConfig.Create(this.Instance.AvgRoleConfig);
				return this._AvgRoleConfigCache;
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600D645 RID: 54853 RVA: 0x001FDFCA File Offset: 0x001FC1CA
		public virtual EAvgRolePosition PositionConfig
		{
			get
			{
				return (EAvgRolePosition)this.Instance.PositionConfig;
			}
		}

		// Token: 0x04007623 RID: 30243
		private ITalkItemAvgEnter Instance;

		// Token: 0x04007624 RID: 30244
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007625 RID: 30245
		private bool _CaptionParamsInited;

		// Token: 0x04007626 RID: 30246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007627 RID: 30247
		private bool _ActionsInited;

		// Token: 0x04007628 RID: 30248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007629 RID: 30249
		private bool _OptionsInited;

		// Token: 0x0400762A RID: 30250
		private PlayMontage _MontageCache;

		// Token: 0x0400762B RID: 30251
		private bool _MontageInited;

		// Token: 0x0400762C RID: 30252
		private ICameraData _CameraDataCache;

		// Token: 0x0400762D RID: 30253
		private bool _CameraDataInited;

		// Token: 0x0400762E RID: 30254
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400762F RID: 30255
		private bool _FlowTemplateInited;

		// Token: 0x04007630 RID: 30256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007631 RID: 30257
		private bool _FlowTemplateListInited;

		// Token: 0x04007632 RID: 30258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007633 RID: 30259
		private bool _ActorMontageArrayInited;

		// Token: 0x04007634 RID: 30260
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007635 RID: 30261
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007636 RID: 30262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007637 RID: 30263
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007638 RID: 30264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007639 RID: 30265
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400763A RID: 30266
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x0400763B RID: 30267
		private bool _TalkAkEventInited;

		// Token: 0x0400763C RID: 30268
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x0400763D RID: 30269
		private bool _TalkEndAkEventInited;

		// Token: 0x0400763E RID: 30270
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400763F RID: 30271
		private bool _UniversalToneInited;

		// Token: 0x04007640 RID: 30272
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007641 RID: 30273
		private bool _BackgroundConfigInited;

		// Token: 0x04007642 RID: 30274
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007643 RID: 30275
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007644 RID: 30276
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007645 RID: 30277
		private bool _GamepadShakeInited;

		// Token: 0x04007646 RID: 30278
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007647 RID: 30279
		private bool _IntroActionsInited;

		// Token: 0x04007648 RID: 30280
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007649 RID: 30281
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x0400764A RID: 30282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x0400764B RID: 30283
		private bool _TalkEffectArrayInited;

		// Token: 0x0400764C RID: 30284
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x0400764D RID: 30285
		private bool _ActorVisibilityArrayInited;

		// Token: 0x0400764E RID: 30286
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x0400764F RID: 30287
		private bool _AvgRoleConfigInited;
	}
}
