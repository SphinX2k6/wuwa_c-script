using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200255D RID: 9565
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgOption : ITalkItem
	{
		// Token: 0x0600D66B RID: 54891 RVA: 0x001FE976 File Offset: 0x001FCB76
		[NullableContext(1)]
		public static ITalkItemAvgOption Create(ITalkItemAvgOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600D66C RID: 54892 RVA: 0x001FE998 File Offset: 0x001FCB98
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

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0600D66D RID: 54893 RVA: 0x001FE9CE File Offset: 0x001FCBCE
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600D66E RID: 54894 RVA: 0x001FE9DC File Offset: 0x001FCBDC
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

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600D66F RID: 54895 RVA: 0x001FEA12 File Offset: 0x001FCC12
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600D670 RID: 54896 RVA: 0x001FEA1F File Offset: 0x001FCC1F
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600D671 RID: 54897 RVA: 0x001FEA2C File Offset: 0x001FCC2C
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

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600D672 RID: 54898 RVA: 0x001FEA64 File Offset: 0x001FCC64
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

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600D673 RID: 54899 RVA: 0x001FEA9C File Offset: 0x001FCC9C
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

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600D674 RID: 54900 RVA: 0x001FEAD4 File Offset: 0x001FCCD4
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

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600D675 RID: 54901 RVA: 0x001FEB0B File Offset: 0x001FCD0B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600D676 RID: 54902 RVA: 0x001FEB18 File Offset: 0x001FCD18
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

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x0600D677 RID: 54903 RVA: 0x001FEB4F File Offset: 0x001FCD4F
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

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0600D678 RID: 54904 RVA: 0x001FEB84 File Offset: 0x001FCD84
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

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600D679 RID: 54905 RVA: 0x001FEC04 File Offset: 0x001FCE04
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

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600D67A RID: 54906 RVA: 0x001FEC82 File Offset: 0x001FCE82
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

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600D67B RID: 54907 RVA: 0x001FECB6 File Offset: 0x001FCEB6
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

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600D67C RID: 54908 RVA: 0x001FECEA File Offset: 0x001FCEEA
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

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600D67D RID: 54909 RVA: 0x001FED20 File Offset: 0x001FCF20
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

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600D67E RID: 54910 RVA: 0x001FEDA0 File Offset: 0x001FCFA0
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

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600D67F RID: 54911 RVA: 0x001FEE20 File Offset: 0x001FD020
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

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600D680 RID: 54912 RVA: 0x001FEEA0 File Offset: 0x001FD0A0
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

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600D681 RID: 54913 RVA: 0x001FEF20 File Offset: 0x001FD120
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

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x0600D682 RID: 54914 RVA: 0x001FEF9E File Offset: 0x001FD19E
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x0600D683 RID: 54915 RVA: 0x001FEFCD File Offset: 0x001FD1CD
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600D684 RID: 54916 RVA: 0x001FEFFC File Offset: 0x001FD1FC
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

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600D685 RID: 54917 RVA: 0x001FF030 File Offset: 0x001FD230
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600D686 RID: 54918 RVA: 0x001FF060 File Offset: 0x001FD260
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

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600D687 RID: 54919 RVA: 0x001FF09A File Offset: 0x001FD29A
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

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600D688 RID: 54920 RVA: 0x001FF0CE File Offset: 0x001FD2CE
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

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600D689 RID: 54921 RVA: 0x001FF104 File Offset: 0x001FD304
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

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600D68A RID: 54922 RVA: 0x001FF184 File Offset: 0x001FD384
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

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600D68B RID: 54923 RVA: 0x001FF204 File Offset: 0x001FD404
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600D68C RID: 54924 RVA: 0x001FF254 File Offset: 0x001FD454
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

		// Token: 0x0400767D RID: 30333
		private ITalkItemAvgOption Instance;

		// Token: 0x0400767E RID: 30334
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x0400767F RID: 30335
		private bool _CaptionParamsInited;

		// Token: 0x04007680 RID: 30336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007681 RID: 30337
		private bool _ActionsInited;

		// Token: 0x04007682 RID: 30338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007683 RID: 30339
		private bool _OptionsInited;

		// Token: 0x04007684 RID: 30340
		private PlayMontage _MontageCache;

		// Token: 0x04007685 RID: 30341
		private bool _MontageInited;

		// Token: 0x04007686 RID: 30342
		private ICameraData _CameraDataCache;

		// Token: 0x04007687 RID: 30343
		private bool _CameraDataInited;

		// Token: 0x04007688 RID: 30344
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007689 RID: 30345
		private bool _FlowTemplateInited;

		// Token: 0x0400768A RID: 30346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400768B RID: 30347
		private bool _FlowTemplateListInited;

		// Token: 0x0400768C RID: 30348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x0400768D RID: 30349
		private bool _ActorMontageArrayInited;

		// Token: 0x0400768E RID: 30350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x0400768F RID: 30351
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007690 RID: 30352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007691 RID: 30353
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007692 RID: 30354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007693 RID: 30355
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007694 RID: 30356
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007695 RID: 30357
		private bool _TalkAkEventInited;

		// Token: 0x04007696 RID: 30358
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007697 RID: 30359
		private bool _TalkEndAkEventInited;

		// Token: 0x04007698 RID: 30360
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007699 RID: 30361
		private bool _UniversalToneInited;

		// Token: 0x0400769A RID: 30362
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400769B RID: 30363
		private bool _BackgroundConfigInited;

		// Token: 0x0400769C RID: 30364
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400769D RID: 30365
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400769E RID: 30366
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400769F RID: 30367
		private bool _GamepadShakeInited;

		// Token: 0x040076A0 RID: 30368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040076A1 RID: 30369
		private bool _IntroActionsInited;

		// Token: 0x040076A2 RID: 30370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040076A3 RID: 30371
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040076A4 RID: 30372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040076A5 RID: 30373
		private bool _TalkEffectArrayInited;

		// Token: 0x040076A6 RID: 30374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040076A7 RID: 30375
		private bool _ActorVisibilityArrayInited;
	}
}
