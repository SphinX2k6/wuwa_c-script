using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002842 RID: 10306
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelTalk : ITalkItem
	{
		// Token: 0x0600E54B RID: 58699 RVA: 0x0021DDE6 File Offset: 0x0021BFE6
		[NullableContext(0)]
		public static ITalkItemVisualNovelTalk Create(ITalkItemVisualNovelTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x0600E54C RID: 58700 RVA: 0x0021DE08 File Offset: 0x0021C008
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

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x0600E54D RID: 58701 RVA: 0x0021DE3E File Offset: 0x0021C03E
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x0600E54E RID: 58702 RVA: 0x0021DE4C File Offset: 0x0021C04C
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

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x0600E54F RID: 58703 RVA: 0x0021DE82 File Offset: 0x0021C082
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x0600E550 RID: 58704 RVA: 0x0021DE8F File Offset: 0x0021C08F
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x0600E551 RID: 58705 RVA: 0x0021DE9C File Offset: 0x0021C09C
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

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x0600E552 RID: 58706 RVA: 0x0021DED4 File Offset: 0x0021C0D4
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

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x0600E553 RID: 58707 RVA: 0x0021DF0C File Offset: 0x0021C10C
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

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x0600E554 RID: 58708 RVA: 0x0021DF44 File Offset: 0x0021C144
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

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x0600E555 RID: 58709 RVA: 0x0021DF7B File Offset: 0x0021C17B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x0600E556 RID: 58710 RVA: 0x0021DF88 File Offset: 0x0021C188
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

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x0600E557 RID: 58711 RVA: 0x0021DFBF File Offset: 0x0021C1BF
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

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x0600E558 RID: 58712 RVA: 0x0021DFF4 File Offset: 0x0021C1F4
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

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x0600E559 RID: 58713 RVA: 0x0021E074 File Offset: 0x0021C274
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

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x0600E55A RID: 58714 RVA: 0x0021E0F2 File Offset: 0x0021C2F2
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

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x0600E55B RID: 58715 RVA: 0x0021E126 File Offset: 0x0021C326
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

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x0600E55C RID: 58716 RVA: 0x0021E15A File Offset: 0x0021C35A
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

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x0600E55D RID: 58717 RVA: 0x0021E190 File Offset: 0x0021C390
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

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x0600E55E RID: 58718 RVA: 0x0021E210 File Offset: 0x0021C410
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

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x0600E55F RID: 58719 RVA: 0x0021E290 File Offset: 0x0021C490
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

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x0600E560 RID: 58720 RVA: 0x0021E310 File Offset: 0x0021C510
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

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x0600E561 RID: 58721 RVA: 0x0021E390 File Offset: 0x0021C590
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

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x0600E562 RID: 58722 RVA: 0x0021E40E File Offset: 0x0021C60E
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x0600E563 RID: 58723 RVA: 0x0021E43D File Offset: 0x0021C63D
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x0600E564 RID: 58724 RVA: 0x0021E46C File Offset: 0x0021C66C
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

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x0600E565 RID: 58725 RVA: 0x0021E4A0 File Offset: 0x0021C6A0
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x0600E566 RID: 58726 RVA: 0x0021E4D0 File Offset: 0x0021C6D0
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

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x0600E567 RID: 58727 RVA: 0x0021E50A File Offset: 0x0021C70A
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

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x0600E568 RID: 58728 RVA: 0x0021E53E File Offset: 0x0021C73E
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

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x0600E569 RID: 58729 RVA: 0x0021E574 File Offset: 0x0021C774
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

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x0600E56A RID: 58730 RVA: 0x0021E5F4 File Offset: 0x0021C7F4
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

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x0600E56B RID: 58731 RVA: 0x0021E674 File Offset: 0x0021C874
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x0600E56C RID: 58732 RVA: 0x0021E6C4 File Offset: 0x0021C8C4
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

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x0600E56D RID: 58733 RVA: 0x0021E744 File Offset: 0x0021C944
		public virtual EVisualNovelOptionInteractionType? OptionInteractionType
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new EVisualNovelOptionInteractionType?((EVisualNovelOptionInteractionType)this.Instance.OptionInteractionType);
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x0600E56E RID: 58734 RVA: 0x0021E77E File Offset: 0x0021C97E
		[Nullable(0)]
		public virtual IVisualNovelOptionGroupConfigBase OptionGroup
		{
			[NullableContext(0)]
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_OptionGroup(this.Instance);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x0600E56F RID: 58735 RVA: 0x0021E7B0 File Offset: 0x0021C9B0
		public virtual float? DialogDelay
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new float?(this.Instance.DialogDelay);
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x0600E570 RID: 58736 RVA: 0x0021E7EC File Offset: 0x0021C9EC
		public virtual bool? ClickShowFull
		{
			get
			{
				if ((this.Instance.NullMask & 2097152U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance.ClickShowFull);
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x0600E571 RID: 58737 RVA: 0x0021E826 File Offset: 0x0021CA26
		public virtual string Interjection
		{
			get
			{
				return this.Instance.Interjection;
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x0600E572 RID: 58738 RVA: 0x0021E833 File Offset: 0x0021CA33
		public virtual IVisualNovelPortraitTransform Transform
		{
			get
			{
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				this._TransformCache = IVisualNovelPortraitTransform.Create(this.Instance.Transform);
				return this._TransformCache;
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x0600E573 RID: 58739 RVA: 0x0021E867 File Offset: 0x0021CA67
		public virtual IVisualNovelRoleConfig RoleConfig
		{
			get
			{
				if (this._RoleConfigInited)
				{
					return this._RoleConfigCache;
				}
				this._RoleConfigInited = true;
				this._RoleConfigCache = IVisualNovelRoleConfig.Create(this.Instance.RoleConfig);
				return this._RoleConfigCache;
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x0600E574 RID: 58740 RVA: 0x0021E89B File Offset: 0x0021CA9B
		[Nullable(0)]
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._VisualNovelBackgroundConfigInited)
				{
					return this._VisualNovelBackgroundConfigCache;
				}
				this._VisualNovelBackgroundConfigInited = true;
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x0600E575 RID: 58741 RVA: 0x0021E8CA File Offset: 0x0021CACA
		[Nullable(0)]
		public virtual IVisualNovelCgBase CgConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._CgConfigInited)
				{
					return this._CgConfigCache;
				}
				this._CgConfigInited = true;
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x0600E576 RID: 58742 RVA: 0x0021E8F9 File Offset: 0x0021CAF9
		[Nullable(0)]
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._DisplayItemConfigInited)
				{
					return this._DisplayItemConfigCache;
				}
				this._DisplayItemConfigInited = true;
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x0600E577 RID: 58743 RVA: 0x0021E928 File Offset: 0x0021CB28
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this.Instance.NullMask & 4194304U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotKeyId);
			}
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x0600E578 RID: 58744 RVA: 0x0021E964 File Offset: 0x0021CB64
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IVisualNovelPerformanceBase> StartPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._StartPerformancesInited)
				{
					return this._StartPerformancesCache;
				}
				this._StartPerformancesInited = true;
				if ((this.Instance.NullMask & 8388608U) == 0U)
				{
					return null;
				}
				this._StartPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_StartPerformances(this.Instance);
				return this._StartPerformancesCache;
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x0600E579 RID: 58745 RVA: 0x0021E9B4 File Offset: 0x0021CBB4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IVisualNovelPerformanceBase> EndPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._EndPerformancesInited)
				{
					return this._EndPerformancesCache;
				}
				this._EndPerformancesInited = true;
				if ((this.Instance.NullMask & 16777216U) == 0U)
				{
					return null;
				}
				this._EndPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_EndPerformances(this.Instance);
				return this._EndPerformancesCache;
			}
		}

		// Token: 0x04007DCA RID: 32202
		private ITalkItemVisualNovelTalk Instance;

		// Token: 0x04007DCB RID: 32203
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007DCC RID: 32204
		private bool _CaptionParamsInited;

		// Token: 0x04007DCD RID: 32205
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007DCE RID: 32206
		private bool _ActionsInited;

		// Token: 0x04007DCF RID: 32207
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007DD0 RID: 32208
		private bool _OptionsInited;

		// Token: 0x04007DD1 RID: 32209
		private PlayMontage _MontageCache;

		// Token: 0x04007DD2 RID: 32210
		private bool _MontageInited;

		// Token: 0x04007DD3 RID: 32211
		private ICameraData _CameraDataCache;

		// Token: 0x04007DD4 RID: 32212
		private bool _CameraDataInited;

		// Token: 0x04007DD5 RID: 32213
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007DD6 RID: 32214
		private bool _FlowTemplateInited;

		// Token: 0x04007DD7 RID: 32215
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007DD8 RID: 32216
		private bool _FlowTemplateListInited;

		// Token: 0x04007DD9 RID: 32217
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007DDA RID: 32218
		private bool _ActorMontageArrayInited;

		// Token: 0x04007DDB RID: 32219
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007DDC RID: 32220
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007DDD RID: 32221
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007DDE RID: 32222
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007DDF RID: 32223
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007DE0 RID: 32224
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007DE1 RID: 32225
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007DE2 RID: 32226
		private bool _TalkAkEventInited;

		// Token: 0x04007DE3 RID: 32227
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007DE4 RID: 32228
		private bool _TalkEndAkEventInited;

		// Token: 0x04007DE5 RID: 32229
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007DE6 RID: 32230
		private bool _UniversalToneInited;

		// Token: 0x04007DE7 RID: 32231
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007DE8 RID: 32232
		private bool _BackgroundConfigInited;

		// Token: 0x04007DE9 RID: 32233
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007DEA RID: 32234
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007DEB RID: 32235
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007DEC RID: 32236
		private bool _GamepadShakeInited;

		// Token: 0x04007DED RID: 32237
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007DEE RID: 32238
		private bool _IntroActionsInited;

		// Token: 0x04007DEF RID: 32239
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007DF0 RID: 32240
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007DF1 RID: 32241
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007DF2 RID: 32242
		private bool _TalkEffectArrayInited;

		// Token: 0x04007DF3 RID: 32243
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007DF4 RID: 32244
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007DF5 RID: 32245
		[Nullable(0)]
		private IVisualNovelOptionGroupConfigBase _OptionGroupCache;

		// Token: 0x04007DF6 RID: 32246
		private bool _OptionGroupInited;

		// Token: 0x04007DF7 RID: 32247
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04007DF8 RID: 32248
		private bool _TransformInited;

		// Token: 0x04007DF9 RID: 32249
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04007DFA RID: 32250
		private bool _RoleConfigInited;

		// Token: 0x04007DFB RID: 32251
		[Nullable(0)]
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x04007DFC RID: 32252
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x04007DFD RID: 32253
		[Nullable(0)]
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x04007DFE RID: 32254
		private bool _CgConfigInited;

		// Token: 0x04007DFF RID: 32255
		[Nullable(0)]
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x04007E00 RID: 32256
		private bool _DisplayItemConfigInited;

		// Token: 0x04007E01 RID: 32257
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _StartPerformancesCache;

		// Token: 0x04007E02 RID: 32258
		private bool _StartPerformancesInited;

		// Token: 0x04007E03 RID: 32259
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _EndPerformancesCache;

		// Token: 0x04007E04 RID: 32260
		private bool _EndPerformancesInited;
	}
}
