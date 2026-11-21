using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002843 RID: 10307
	public class ITalkItemVisualNovelNoTextItem : ITalkItem
	{
		// Token: 0x0600E57B RID: 58747 RVA: 0x0021EA0B File Offset: 0x0021CC0B
		public static ITalkItemVisualNovelNoTextItem Create(ITalkItemVisualNovelNoTextItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNoTextItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x0600E57C RID: 58748 RVA: 0x0021EA2C File Offset: 0x0021CC2C
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

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x0600E57D RID: 58749 RVA: 0x0021EA62 File Offset: 0x0021CC62
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x0600E57E RID: 58750 RVA: 0x0021EA70 File Offset: 0x0021CC70
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

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x0600E57F RID: 58751 RVA: 0x0021EAA6 File Offset: 0x0021CCA6
		[Nullable(2)]
		public override string PlotLineKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x0600E580 RID: 58752 RVA: 0x0021EAB3 File Offset: 0x0021CCB3
		public override string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x0021EAC0 File Offset: 0x0021CCC0
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

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x0600E582 RID: 58754 RVA: 0x0021EAF8 File Offset: 0x0021CCF8
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

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x0600E583 RID: 58755 RVA: 0x0021EB30 File Offset: 0x0021CD30
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

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x0600E584 RID: 58756 RVA: 0x0021EB68 File Offset: 0x0021CD68
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

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x0600E585 RID: 58757 RVA: 0x0021EB9F File Offset: 0x0021CD9F
		[Nullable(2)]
		public override string TidTalk
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x0600E586 RID: 58758 RVA: 0x0021EBAC File Offset: 0x0021CDAC
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

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x0600E587 RID: 58759 RVA: 0x0021EBE3 File Offset: 0x0021CDE3
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

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x0600E588 RID: 58760 RVA: 0x0021EC18 File Offset: 0x0021CE18
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

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x0600E589 RID: 58761 RVA: 0x0021EC98 File Offset: 0x0021CE98
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

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x0600E58A RID: 58762 RVA: 0x0021ED16 File Offset: 0x0021CF16
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

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x0600E58B RID: 58763 RVA: 0x0021ED4A File Offset: 0x0021CF4A
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

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x0600E58C RID: 58764 RVA: 0x0021ED7E File Offset: 0x0021CF7E
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

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x0600E58D RID: 58765 RVA: 0x0021EDB4 File Offset: 0x0021CFB4
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

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x0600E58E RID: 58766 RVA: 0x0021EE34 File Offset: 0x0021D034
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

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x0600E58F RID: 58767 RVA: 0x0021EEB4 File Offset: 0x0021D0B4
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

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x0600E590 RID: 58768 RVA: 0x0021EF34 File Offset: 0x0021D134
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

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x0600E591 RID: 58769 RVA: 0x0021EFB4 File Offset: 0x0021D1B4
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

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x0600E592 RID: 58770 RVA: 0x0021F032 File Offset: 0x0021D232
		public override IPostAkEventType TalkAkEvent
		{
			get
			{
				if (this._TalkAkEventInited)
				{
					return this._TalkAkEventCache;
				}
				this._TalkAkEventInited = true;
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0600E593 RID: 58771 RVA: 0x0021F061 File Offset: 0x0021D261
		public override IPostAkEventType TalkEndAkEvent
		{
			get
			{
				if (this._TalkEndAkEventInited)
				{
					return this._TalkEndAkEventCache;
				}
				this._TalkEndAkEventInited = true;
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x0600E594 RID: 58772 RVA: 0x0021F090 File Offset: 0x0021D290
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

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x0600E595 RID: 58773 RVA: 0x0021F0C4 File Offset: 0x0021D2C4
		public override ITalkBackground BackgroundConfig
		{
			get
			{
				if (this._BackgroundConfigInited)
				{
					return this._BackgroundConfigCache;
				}
				this._BackgroundConfigInited = true;
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x0600E596 RID: 58774 RVA: 0x0021F0F4 File Offset: 0x0021D2F4
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

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x0600E597 RID: 58775 RVA: 0x0021F12E File Offset: 0x0021D32E
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

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x0600E598 RID: 58776 RVA: 0x0021F162 File Offset: 0x0021D362
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

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x0600E599 RID: 58777 RVA: 0x0021F198 File Offset: 0x0021D398
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

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x0600E59A RID: 58778 RVA: 0x0021F218 File Offset: 0x0021D418
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

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x0600E59B RID: 58779 RVA: 0x0021F298 File Offset: 0x0021D498
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x0600E59C RID: 58780 RVA: 0x0021F2E8 File Offset: 0x0021D4E8
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

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x0600E59D RID: 58781 RVA: 0x0021F368 File Offset: 0x0021D568
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

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x0600E59E RID: 58782 RVA: 0x0021F3A2 File Offset: 0x0021D5A2
		public virtual IVisualNovelOptionGroupConfigBase OptionGroup
		{
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_OptionGroup(this.Instance);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x0600E59F RID: 58783 RVA: 0x0021F3D1 File Offset: 0x0021D5D1
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			get
			{
				if (this._VisualNovelBackgroundConfigInited)
				{
					return this._VisualNovelBackgroundConfigCache;
				}
				this._VisualNovelBackgroundConfigInited = true;
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x0600E5A0 RID: 58784 RVA: 0x0021F400 File Offset: 0x0021D600
		public virtual IVisualNovelCgBase CgConfig
		{
			get
			{
				if (this._CgConfigInited)
				{
					return this._CgConfigCache;
				}
				this._CgConfigInited = true;
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x0600E5A1 RID: 58785 RVA: 0x0021F42F File Offset: 0x0021D62F
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			get
			{
				if (this._DisplayItemConfigInited)
				{
					return this._DisplayItemConfigCache;
				}
				this._DisplayItemConfigInited = true;
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x0021F460 File Offset: 0x0021D660
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotKeyId);
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x0021F49C File Offset: 0x0021D69C
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
				if ((this.Instance.NullMask & 2097152U) == 0U)
				{
					return null;
				}
				this._StartPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_StartPerformances(this.Instance);
				return this._StartPerformancesCache;
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x0021F4EC File Offset: 0x0021D6EC
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
				if ((this.Instance.NullMask & 4194304U) == 0U)
				{
					return null;
				}
				this._EndPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_EndPerformances(this.Instance);
				return this._EndPerformancesCache;
			}
		}

		// Token: 0x04007E05 RID: 32261
		private ITalkItemVisualNovelNoTextItem Instance;

		// Token: 0x04007E06 RID: 32262
		[Nullable(2)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007E07 RID: 32263
		private bool _CaptionParamsInited;

		// Token: 0x04007E08 RID: 32264
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007E09 RID: 32265
		private bool _ActionsInited;

		// Token: 0x04007E0A RID: 32266
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007E0B RID: 32267
		private bool _OptionsInited;

		// Token: 0x04007E0C RID: 32268
		[Nullable(2)]
		private PlayMontage _MontageCache;

		// Token: 0x04007E0D RID: 32269
		private bool _MontageInited;

		// Token: 0x04007E0E RID: 32270
		[Nullable(2)]
		private ICameraData _CameraDataCache;

		// Token: 0x04007E0F RID: 32271
		private bool _CameraDataInited;

		// Token: 0x04007E10 RID: 32272
		[Nullable(2)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007E11 RID: 32273
		private bool _FlowTemplateInited;

		// Token: 0x04007E12 RID: 32274
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007E13 RID: 32275
		private bool _FlowTemplateListInited;

		// Token: 0x04007E14 RID: 32276
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007E15 RID: 32277
		private bool _ActorMontageArrayInited;

		// Token: 0x04007E16 RID: 32278
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007E17 RID: 32279
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007E18 RID: 32280
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007E19 RID: 32281
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007E1A RID: 32282
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007E1B RID: 32283
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007E1C RID: 32284
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007E1D RID: 32285
		private bool _TalkAkEventInited;

		// Token: 0x04007E1E RID: 32286
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007E1F RID: 32287
		private bool _TalkEndAkEventInited;

		// Token: 0x04007E20 RID: 32288
		[Nullable(2)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007E21 RID: 32289
		private bool _UniversalToneInited;

		// Token: 0x04007E22 RID: 32290
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007E23 RID: 32291
		private bool _BackgroundConfigInited;

		// Token: 0x04007E24 RID: 32292
		[Nullable(2)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007E25 RID: 32293
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007E26 RID: 32294
		[Nullable(2)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007E27 RID: 32295
		private bool _GamepadShakeInited;

		// Token: 0x04007E28 RID: 32296
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007E29 RID: 32297
		private bool _IntroActionsInited;

		// Token: 0x04007E2A RID: 32298
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007E2B RID: 32299
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007E2C RID: 32300
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007E2D RID: 32301
		private bool _TalkEffectArrayInited;

		// Token: 0x04007E2E RID: 32302
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007E2F RID: 32303
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007E30 RID: 32304
		private IVisualNovelOptionGroupConfigBase _OptionGroupCache;

		// Token: 0x04007E31 RID: 32305
		private bool _OptionGroupInited;

		// Token: 0x04007E32 RID: 32306
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x04007E33 RID: 32307
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x04007E34 RID: 32308
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x04007E35 RID: 32309
		private bool _CgConfigInited;

		// Token: 0x04007E36 RID: 32310
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x04007E37 RID: 32311
		private bool _DisplayItemConfigInited;

		// Token: 0x04007E38 RID: 32312
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _StartPerformancesCache;

		// Token: 0x04007E39 RID: 32313
		private bool _StartPerformancesInited;

		// Token: 0x04007E3A RID: 32314
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _EndPerformancesCache;

		// Token: 0x04007E3B RID: 32315
		private bool _EndPerformancesInited;
	}
}
