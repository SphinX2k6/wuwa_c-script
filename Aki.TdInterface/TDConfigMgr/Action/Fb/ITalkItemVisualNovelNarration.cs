using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002844 RID: 10308
	public class ITalkItemVisualNovelNarration : ITalkItem
	{
		// Token: 0x0600E5A6 RID: 58790 RVA: 0x0021F543 File Offset: 0x0021D743
		public static ITalkItemVisualNovelNarration Create(ITalkItemVisualNovelNarration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNarration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x0021F564 File Offset: 0x0021D764
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

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x0600E5A8 RID: 58792 RVA: 0x0021F59A File Offset: 0x0021D79A
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x0600E5A9 RID: 58793 RVA: 0x0021F5A8 File Offset: 0x0021D7A8
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

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x0600E5AA RID: 58794 RVA: 0x0021F5DE File Offset: 0x0021D7DE
		[Nullable(2)]
		public override string PlotLineKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x0600E5AB RID: 58795 RVA: 0x0021F5EB File Offset: 0x0021D7EB
		public override string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x0600E5AC RID: 58796 RVA: 0x0021F5F8 File Offset: 0x0021D7F8
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

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x0021F630 File Offset: 0x0021D830
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

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x0600E5AE RID: 58798 RVA: 0x0021F668 File Offset: 0x0021D868
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

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x0021F6A0 File Offset: 0x0021D8A0
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

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x0600E5B0 RID: 58800 RVA: 0x0021F6D7 File Offset: 0x0021D8D7
		[Nullable(2)]
		public override string TidTalk
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x0600E5B1 RID: 58801 RVA: 0x0021F6E4 File Offset: 0x0021D8E4
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

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x0600E5B2 RID: 58802 RVA: 0x0021F71B File Offset: 0x0021D91B
		[Nullable(2)]
		public override ICaptionParam CaptionParams
		{
			[NullableContext(2)]
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

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x0600E5B3 RID: 58803 RVA: 0x0021F750 File Offset: 0x0021D950
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

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x0600E5B4 RID: 58804 RVA: 0x0021F7D0 File Offset: 0x0021D9D0
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

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x0600E5B5 RID: 58805 RVA: 0x0021F84E File Offset: 0x0021DA4E
		[Nullable(2)]
		public override PlayMontage Montage
		{
			[NullableContext(2)]
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

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x0600E5B6 RID: 58806 RVA: 0x0021F882 File Offset: 0x0021DA82
		[Nullable(2)]
		public override ICameraData CameraData
		{
			[NullableContext(2)]
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

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x0600E5B7 RID: 58807 RVA: 0x0021F8B6 File Offset: 0x0021DAB6
		[Nullable(2)]
		public override SetFlowTemplate FlowTemplate
		{
			[NullableContext(2)]
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

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x0600E5B8 RID: 58808 RVA: 0x0021F8EC File Offset: 0x0021DAEC
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

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x0600E5B9 RID: 58809 RVA: 0x0021F96C File Offset: 0x0021DB6C
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

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x0021F9EC File Offset: 0x0021DBEC
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

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x0600E5BB RID: 58811 RVA: 0x0021FA6C File Offset: 0x0021DC6C
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

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x0021FAEC File Offset: 0x0021DCEC
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

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x0021FB6A File Offset: 0x0021DD6A
		public override IPostAkEventType TalkAkEvent
		{
			get
			{
				if (this._TalkAkEventInited)
				{
					return this._TalkAkEventCache;
				}
				this._TalkAkEventInited = true;
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x0021FB99 File Offset: 0x0021DD99
		public override IPostAkEventType TalkEndAkEvent
		{
			get
			{
				if (this._TalkEndAkEventInited)
				{
					return this._TalkEndAkEventCache;
				}
				this._TalkEndAkEventInited = true;
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x0021FBC8 File Offset: 0x0021DDC8
		[Nullable(2)]
		public override IUniversalTone UniversalTone
		{
			[NullableContext(2)]
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

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x0021FBFC File Offset: 0x0021DDFC
		public override ITalkBackground BackgroundConfig
		{
			get
			{
				if (this._BackgroundConfigInited)
				{
					return this._BackgroundConfigCache;
				}
				this._BackgroundConfigInited = true;
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x0021FC2C File Offset: 0x0021DE2C
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

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x0021FC66 File Offset: 0x0021DE66
		[Nullable(2)]
		public override ITimeLimitOptionGroup TimeLimitOptionGroup
		{
			[NullableContext(2)]
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

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x0021FC9A File Offset: 0x0021DE9A
		[Nullable(2)]
		public override IGamepadShakeInTalk GamepadShake
		{
			[NullableContext(2)]
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

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x0600E5C4 RID: 58820 RVA: 0x0021FCD0 File Offset: 0x0021DED0
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

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x0021FD50 File Offset: 0x0021DF50
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

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x0021FDD0 File Offset: 0x0021DFD0
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x0600E5C7 RID: 58823 RVA: 0x0021FE20 File Offset: 0x0021E020
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

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x0600E5C8 RID: 58824 RVA: 0x0021FEA0 File Offset: 0x0021E0A0
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

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x0021FEDA File Offset: 0x0021E0DA
		public virtual IVisualNovelOptionGroupConfigBase OptionGroup
		{
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_OptionGroup(this.Instance);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x0600E5CA RID: 58826 RVA: 0x0021FF0C File Offset: 0x0021E10C
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

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x0021FF48 File Offset: 0x0021E148
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

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x0600E5CC RID: 58828 RVA: 0x0021FF82 File Offset: 0x0021E182
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			get
			{
				if (this._VisualNovelBackgroundConfigInited)
				{
					return this._VisualNovelBackgroundConfigCache;
				}
				this._VisualNovelBackgroundConfigInited = true;
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x0021FFB1 File Offset: 0x0021E1B1
		public virtual IVisualNovelCgBase CgConfig
		{
			get
			{
				if (this._CgConfigInited)
				{
					return this._CgConfigCache;
				}
				this._CgConfigInited = true;
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x0021FFE0 File Offset: 0x0021E1E0
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			get
			{
				if (this._DisplayItemConfigInited)
				{
					return this._DisplayItemConfigCache;
				}
				this._DisplayItemConfigInited = true;
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x00220010 File Offset: 0x0021E210
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

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x0600E5D0 RID: 58832 RVA: 0x0022004C File Offset: 0x0021E24C
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
				this._StartPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_StartPerformances(this.Instance);
				return this._StartPerformancesCache;
			}
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x0022009C File Offset: 0x0021E29C
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
				this._EndPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelNarration_EndPerformances(this.Instance);
				return this._EndPerformancesCache;
			}
		}

		// Token: 0x04007E3C RID: 32316
		private ITalkItemVisualNovelNarration Instance;

		// Token: 0x04007E3D RID: 32317
		[Nullable(2)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007E3E RID: 32318
		private bool _CaptionParamsInited;

		// Token: 0x04007E3F RID: 32319
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007E40 RID: 32320
		private bool _ActionsInited;

		// Token: 0x04007E41 RID: 32321
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007E42 RID: 32322
		private bool _OptionsInited;

		// Token: 0x04007E43 RID: 32323
		[Nullable(2)]
		private PlayMontage _MontageCache;

		// Token: 0x04007E44 RID: 32324
		private bool _MontageInited;

		// Token: 0x04007E45 RID: 32325
		[Nullable(2)]
		private ICameraData _CameraDataCache;

		// Token: 0x04007E46 RID: 32326
		private bool _CameraDataInited;

		// Token: 0x04007E47 RID: 32327
		[Nullable(2)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007E48 RID: 32328
		private bool _FlowTemplateInited;

		// Token: 0x04007E49 RID: 32329
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007E4A RID: 32330
		private bool _FlowTemplateListInited;

		// Token: 0x04007E4B RID: 32331
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007E4C RID: 32332
		private bool _ActorMontageArrayInited;

		// Token: 0x04007E4D RID: 32333
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007E4E RID: 32334
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007E4F RID: 32335
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007E50 RID: 32336
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007E51 RID: 32337
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007E52 RID: 32338
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007E53 RID: 32339
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007E54 RID: 32340
		private bool _TalkAkEventInited;

		// Token: 0x04007E55 RID: 32341
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007E56 RID: 32342
		private bool _TalkEndAkEventInited;

		// Token: 0x04007E57 RID: 32343
		[Nullable(2)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007E58 RID: 32344
		private bool _UniversalToneInited;

		// Token: 0x04007E59 RID: 32345
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007E5A RID: 32346
		private bool _BackgroundConfigInited;

		// Token: 0x04007E5B RID: 32347
		[Nullable(2)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007E5C RID: 32348
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007E5D RID: 32349
		[Nullable(2)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007E5E RID: 32350
		private bool _GamepadShakeInited;

		// Token: 0x04007E5F RID: 32351
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007E60 RID: 32352
		private bool _IntroActionsInited;

		// Token: 0x04007E61 RID: 32353
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007E62 RID: 32354
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007E63 RID: 32355
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007E64 RID: 32356
		private bool _TalkEffectArrayInited;

		// Token: 0x04007E65 RID: 32357
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007E66 RID: 32358
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007E67 RID: 32359
		private IVisualNovelOptionGroupConfigBase _OptionGroupCache;

		// Token: 0x04007E68 RID: 32360
		private bool _OptionGroupInited;

		// Token: 0x04007E69 RID: 32361
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x04007E6A RID: 32362
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x04007E6B RID: 32363
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x04007E6C RID: 32364
		private bool _CgConfigInited;

		// Token: 0x04007E6D RID: 32365
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x04007E6E RID: 32366
		private bool _DisplayItemConfigInited;

		// Token: 0x04007E6F RID: 32367
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _StartPerformancesCache;

		// Token: 0x04007E70 RID: 32368
		private bool _StartPerformancesInited;

		// Token: 0x04007E71 RID: 32369
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _EndPerformancesCache;

		// Token: 0x04007E72 RID: 32370
		private bool _EndPerformancesInited;
	}
}
