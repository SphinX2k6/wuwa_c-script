using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200255A RID: 9562
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgTalk : ITalkItem
	{
		// Token: 0x0600D5FD RID: 54781 RVA: 0x001FCC96 File Offset: 0x001FAE96
		[NullableContext(1)]
		public static ITalkItemAvgTalk Create(ITalkItemAvgTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x001FCCB8 File Offset: 0x001FAEB8
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

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0600D5FF RID: 54783 RVA: 0x001FCCEE File Offset: 0x001FAEEE
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600D600 RID: 54784 RVA: 0x001FCCFC File Offset: 0x001FAEFC
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

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600D601 RID: 54785 RVA: 0x001FCD32 File Offset: 0x001FAF32
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600D602 RID: 54786 RVA: 0x001FCD3F File Offset: 0x001FAF3F
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600D603 RID: 54787 RVA: 0x001FCD4C File Offset: 0x001FAF4C
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

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600D604 RID: 54788 RVA: 0x001FCD84 File Offset: 0x001FAF84
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

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600D605 RID: 54789 RVA: 0x001FCDBC File Offset: 0x001FAFBC
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

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600D606 RID: 54790 RVA: 0x001FCDF4 File Offset: 0x001FAFF4
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

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600D607 RID: 54791 RVA: 0x001FCE2B File Offset: 0x001FB02B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x0600D608 RID: 54792 RVA: 0x001FCE38 File Offset: 0x001FB038
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

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600D609 RID: 54793 RVA: 0x001FCE6F File Offset: 0x001FB06F
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

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600D60A RID: 54794 RVA: 0x001FCEA4 File Offset: 0x001FB0A4
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

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600D60B RID: 54795 RVA: 0x001FCF24 File Offset: 0x001FB124
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

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600D60C RID: 54796 RVA: 0x001FCFA2 File Offset: 0x001FB1A2
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

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600D60D RID: 54797 RVA: 0x001FCFD6 File Offset: 0x001FB1D6
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

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600D60E RID: 54798 RVA: 0x001FD00A File Offset: 0x001FB20A
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

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600D60F RID: 54799 RVA: 0x001FD040 File Offset: 0x001FB240
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

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600D610 RID: 54800 RVA: 0x001FD0C0 File Offset: 0x001FB2C0
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

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600D611 RID: 54801 RVA: 0x001FD140 File Offset: 0x001FB340
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

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600D612 RID: 54802 RVA: 0x001FD1C0 File Offset: 0x001FB3C0
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

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600D613 RID: 54803 RVA: 0x001FD240 File Offset: 0x001FB440
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

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600D614 RID: 54804 RVA: 0x001FD2BE File Offset: 0x001FB4BE
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgTalk_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600D615 RID: 54805 RVA: 0x001FD2ED File Offset: 0x001FB4ED
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgTalk_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600D616 RID: 54806 RVA: 0x001FD31C File Offset: 0x001FB51C
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

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600D617 RID: 54807 RVA: 0x001FD350 File Offset: 0x001FB550
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgTalk_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600D618 RID: 54808 RVA: 0x001FD380 File Offset: 0x001FB580
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

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600D619 RID: 54809 RVA: 0x001FD3BA File Offset: 0x001FB5BA
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

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600D61A RID: 54810 RVA: 0x001FD3EE File Offset: 0x001FB5EE
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

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0600D61B RID: 54811 RVA: 0x001FD424 File Offset: 0x001FB624
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

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0600D61C RID: 54812 RVA: 0x001FD4A4 File Offset: 0x001FB6A4
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

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600D61D RID: 54813 RVA: 0x001FD524 File Offset: 0x001FB724
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgTalk_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600D61E RID: 54814 RVA: 0x001FD574 File Offset: 0x001FB774
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

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0600D61F RID: 54815 RVA: 0x001FD5F2 File Offset: 0x001FB7F2
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

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x0600D620 RID: 54816 RVA: 0x001FD626 File Offset: 0x001FB826
		public virtual EAvgRolePosition PositionConfig
		{
			get
			{
				return (EAvgRolePosition)this.Instance.PositionConfig;
			}
		}

		// Token: 0x040075F6 RID: 30198
		private ITalkItemAvgTalk Instance;

		// Token: 0x040075F7 RID: 30199
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040075F8 RID: 30200
		private bool _CaptionParamsInited;

		// Token: 0x040075F9 RID: 30201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040075FA RID: 30202
		private bool _ActionsInited;

		// Token: 0x040075FB RID: 30203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040075FC RID: 30204
		private bool _OptionsInited;

		// Token: 0x040075FD RID: 30205
		private PlayMontage _MontageCache;

		// Token: 0x040075FE RID: 30206
		private bool _MontageInited;

		// Token: 0x040075FF RID: 30207
		private ICameraData _CameraDataCache;

		// Token: 0x04007600 RID: 30208
		private bool _CameraDataInited;

		// Token: 0x04007601 RID: 30209
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007602 RID: 30210
		private bool _FlowTemplateInited;

		// Token: 0x04007603 RID: 30211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007604 RID: 30212
		private bool _FlowTemplateListInited;

		// Token: 0x04007605 RID: 30213
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007606 RID: 30214
		private bool _ActorMontageArrayInited;

		// Token: 0x04007607 RID: 30215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007608 RID: 30216
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007609 RID: 30217
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x0400760A RID: 30218
		private bool _ActorLookAtArrayInited;

		// Token: 0x0400760B RID: 30219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x0400760C RID: 30220
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400760D RID: 30221
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x0400760E RID: 30222
		private bool _TalkAkEventInited;

		// Token: 0x0400760F RID: 30223
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007610 RID: 30224
		private bool _TalkEndAkEventInited;

		// Token: 0x04007611 RID: 30225
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007612 RID: 30226
		private bool _UniversalToneInited;

		// Token: 0x04007613 RID: 30227
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007614 RID: 30228
		private bool _BackgroundConfigInited;

		// Token: 0x04007615 RID: 30229
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007616 RID: 30230
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007617 RID: 30231
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007618 RID: 30232
		private bool _GamepadShakeInited;

		// Token: 0x04007619 RID: 30233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x0400761A RID: 30234
		private bool _IntroActionsInited;

		// Token: 0x0400761B RID: 30235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x0400761C RID: 30236
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x0400761D RID: 30237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x0400761E RID: 30238
		private bool _TalkEffectArrayInited;

		// Token: 0x0400761F RID: 30239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007620 RID: 30240
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007621 RID: 30241
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x04007622 RID: 30242
		private bool _AvgRoleConfigInited;
	}
}
