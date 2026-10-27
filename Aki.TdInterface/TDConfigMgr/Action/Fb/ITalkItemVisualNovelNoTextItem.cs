using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002594 RID: 9620
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNoTextItem : ITalkItem
	{
		// Token: 0x0600D800 RID: 55296 RVA: 0x00202CEB File Offset: 0x00200EEB
		[NullableContext(1)]
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

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0600D801 RID: 55297 RVA: 0x00202D0C File Offset: 0x00200F0C
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

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0600D802 RID: 55298 RVA: 0x00202D42 File Offset: 0x00200F42
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x0600D803 RID: 55299 RVA: 0x00202D50 File Offset: 0x00200F50
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

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x0600D804 RID: 55300 RVA: 0x00202D86 File Offset: 0x00200F86
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x0600D805 RID: 55301 RVA: 0x00202D93 File Offset: 0x00200F93
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x0600D806 RID: 55302 RVA: 0x00202DA0 File Offset: 0x00200FA0
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

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x0600D807 RID: 55303 RVA: 0x00202DD8 File Offset: 0x00200FD8
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

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0600D808 RID: 55304 RVA: 0x00202E10 File Offset: 0x00201010
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

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0600D809 RID: 55305 RVA: 0x00202E48 File Offset: 0x00201048
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

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0600D80A RID: 55306 RVA: 0x00202E7F File Offset: 0x0020107F
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x0600D80B RID: 55307 RVA: 0x00202E8C File Offset: 0x0020108C
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

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x0600D80C RID: 55308 RVA: 0x00202EC3 File Offset: 0x002010C3
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

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x0600D80D RID: 55309 RVA: 0x00202EF8 File Offset: 0x002010F8
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

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0600D80E RID: 55310 RVA: 0x00202F78 File Offset: 0x00201178
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

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0600D80F RID: 55311 RVA: 0x00202FF6 File Offset: 0x002011F6
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

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0600D810 RID: 55312 RVA: 0x0020302A File Offset: 0x0020122A
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

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0600D811 RID: 55313 RVA: 0x0020305E File Offset: 0x0020125E
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

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0600D812 RID: 55314 RVA: 0x00203094 File Offset: 0x00201294
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

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0600D813 RID: 55315 RVA: 0x00203114 File Offset: 0x00201314
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

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0600D814 RID: 55316 RVA: 0x00203194 File Offset: 0x00201394
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

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0600D815 RID: 55317 RVA: 0x00203214 File Offset: 0x00201414
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

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x0600D816 RID: 55318 RVA: 0x00203294 File Offset: 0x00201494
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

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0600D817 RID: 55319 RVA: 0x00203312 File Offset: 0x00201512
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0600D818 RID: 55320 RVA: 0x00203341 File Offset: 0x00201541
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0600D819 RID: 55321 RVA: 0x00203370 File Offset: 0x00201570
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

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0600D81A RID: 55322 RVA: 0x002033A4 File Offset: 0x002015A4
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x0600D81B RID: 55323 RVA: 0x002033D4 File Offset: 0x002015D4
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

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0600D81C RID: 55324 RVA: 0x0020340E File Offset: 0x0020160E
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

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0600D81D RID: 55325 RVA: 0x00203442 File Offset: 0x00201642
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

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0600D81E RID: 55326 RVA: 0x00203478 File Offset: 0x00201678
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

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0600D81F RID: 55327 RVA: 0x002034F8 File Offset: 0x002016F8
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

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0600D820 RID: 55328 RVA: 0x00203578 File Offset: 0x00201778
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelNoTextItem_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0600D821 RID: 55329 RVA: 0x002035C8 File Offset: 0x002017C8
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

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x0600D822 RID: 55330 RVA: 0x00203648 File Offset: 0x00201848
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

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x0600D823 RID: 55331 RVA: 0x00203682 File Offset: 0x00201882
		public virtual IVisualNovelOptionGroupSolarSchoolExam OptionGroup
		{
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = IVisualNovelOptionGroupSolarSchoolExam.Create(this.Instance.OptionGroup);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x0600D824 RID: 55332 RVA: 0x002036B6 File Offset: 0x002018B6
		[Nullable(1)]
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			[NullableContext(1)]
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

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0600D825 RID: 55333 RVA: 0x002036E5 File Offset: 0x002018E5
		[Nullable(1)]
		public virtual IVisualNovelCgBase CgConfig
		{
			[NullableContext(1)]
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

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x0600D826 RID: 55334 RVA: 0x00203714 File Offset: 0x00201914
		[Nullable(1)]
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			[NullableContext(1)]
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

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0600D827 RID: 55335 RVA: 0x00203744 File Offset: 0x00201944
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

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0600D828 RID: 55336 RVA: 0x00203780 File Offset: 0x00201980
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> StartPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0600D829 RID: 55337 RVA: 0x002037D0 File Offset: 0x002019D0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> EndPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x0400779E RID: 30622
		private ITalkItemVisualNovelNoTextItem Instance;

		// Token: 0x0400779F RID: 30623
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040077A0 RID: 30624
		private bool _CaptionParamsInited;

		// Token: 0x040077A1 RID: 30625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040077A2 RID: 30626
		private bool _ActionsInited;

		// Token: 0x040077A3 RID: 30627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040077A4 RID: 30628
		private bool _OptionsInited;

		// Token: 0x040077A5 RID: 30629
		private PlayMontage _MontageCache;

		// Token: 0x040077A6 RID: 30630
		private bool _MontageInited;

		// Token: 0x040077A7 RID: 30631
		private ICameraData _CameraDataCache;

		// Token: 0x040077A8 RID: 30632
		private bool _CameraDataInited;

		// Token: 0x040077A9 RID: 30633
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040077AA RID: 30634
		private bool _FlowTemplateInited;

		// Token: 0x040077AB RID: 30635
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040077AC RID: 30636
		private bool _FlowTemplateListInited;

		// Token: 0x040077AD RID: 30637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040077AE RID: 30638
		private bool _ActorMontageArrayInited;

		// Token: 0x040077AF RID: 30639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040077B0 RID: 30640
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040077B1 RID: 30641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040077B2 RID: 30642
		private bool _ActorLookAtArrayInited;

		// Token: 0x040077B3 RID: 30643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040077B4 RID: 30644
		private bool _ActorTurnToArrayInited;

		// Token: 0x040077B5 RID: 30645
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040077B6 RID: 30646
		private bool _TalkAkEventInited;

		// Token: 0x040077B7 RID: 30647
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040077B8 RID: 30648
		private bool _TalkEndAkEventInited;

		// Token: 0x040077B9 RID: 30649
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040077BA RID: 30650
		private bool _UniversalToneInited;

		// Token: 0x040077BB RID: 30651
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040077BC RID: 30652
		private bool _BackgroundConfigInited;

		// Token: 0x040077BD RID: 30653
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040077BE RID: 30654
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040077BF RID: 30655
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040077C0 RID: 30656
		private bool _GamepadShakeInited;

		// Token: 0x040077C1 RID: 30657
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040077C2 RID: 30658
		private bool _IntroActionsInited;

		// Token: 0x040077C3 RID: 30659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040077C4 RID: 30660
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040077C5 RID: 30661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040077C6 RID: 30662
		private bool _TalkEffectArrayInited;

		// Token: 0x040077C7 RID: 30663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040077C8 RID: 30664
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040077C9 RID: 30665
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x040077CA RID: 30666
		private bool _OptionGroupInited;

		// Token: 0x040077CB RID: 30667
		[Nullable(1)]
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x040077CC RID: 30668
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x040077CD RID: 30669
		[Nullable(1)]
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x040077CE RID: 30670
		private bool _CgConfigInited;

		// Token: 0x040077CF RID: 30671
		[Nullable(1)]
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x040077D0 RID: 30672
		private bool _DisplayItemConfigInited;

		// Token: 0x040077D1 RID: 30673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _StartPerformancesCache;

		// Token: 0x040077D2 RID: 30674
		private bool _StartPerformancesInited;

		// Token: 0x040077D3 RID: 30675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _EndPerformancesCache;

		// Token: 0x040077D4 RID: 30676
		private bool _EndPerformancesInited;
	}
}
