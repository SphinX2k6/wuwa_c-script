using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002596 RID: 9622
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelOption : ITalkItem
	{
		// Token: 0x0600D858 RID: 55384 RVA: 0x002043DB File Offset: 0x002025DB
		[NullableContext(1)]
		public static ITalkItemVisualNovelOption Create(ITalkItemVisualNovelOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x0600D859 RID: 55385 RVA: 0x002043FC File Offset: 0x002025FC
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

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x0600D85A RID: 55386 RVA: 0x00204432 File Offset: 0x00202632
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0600D85B RID: 55387 RVA: 0x00204440 File Offset: 0x00202640
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

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x0600D85C RID: 55388 RVA: 0x00204476 File Offset: 0x00202676
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0600D85D RID: 55389 RVA: 0x00204483 File Offset: 0x00202683
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0600D85E RID: 55390 RVA: 0x00204490 File Offset: 0x00202690
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

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0600D85F RID: 55391 RVA: 0x002044C8 File Offset: 0x002026C8
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

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0600D860 RID: 55392 RVA: 0x00204500 File Offset: 0x00202700
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

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x0600D861 RID: 55393 RVA: 0x00204538 File Offset: 0x00202738
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

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x0600D862 RID: 55394 RVA: 0x0020456F File Offset: 0x0020276F
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x0600D863 RID: 55395 RVA: 0x0020457C File Offset: 0x0020277C
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

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x0600D864 RID: 55396 RVA: 0x002045B3 File Offset: 0x002027B3
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

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x0600D865 RID: 55397 RVA: 0x002045E8 File Offset: 0x002027E8
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

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x0600D866 RID: 55398 RVA: 0x00204668 File Offset: 0x00202868
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

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x0600D867 RID: 55399 RVA: 0x002046E6 File Offset: 0x002028E6
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

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0600D868 RID: 55400 RVA: 0x0020471A File Offset: 0x0020291A
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

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0600D869 RID: 55401 RVA: 0x0020474E File Offset: 0x0020294E
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

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x0600D86A RID: 55402 RVA: 0x00204784 File Offset: 0x00202984
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

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x0600D86B RID: 55403 RVA: 0x00204804 File Offset: 0x00202A04
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

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x0600D86C RID: 55404 RVA: 0x00204884 File Offset: 0x00202A84
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

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x0600D86D RID: 55405 RVA: 0x00204904 File Offset: 0x00202B04
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

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x0600D86E RID: 55406 RVA: 0x00204984 File Offset: 0x00202B84
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

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0600D86F RID: 55407 RVA: 0x00204A02 File Offset: 0x00202C02
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0600D870 RID: 55408 RVA: 0x00204A31 File Offset: 0x00202C31
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0600D871 RID: 55409 RVA: 0x00204A60 File Offset: 0x00202C60
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

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x0600D872 RID: 55410 RVA: 0x00204A94 File Offset: 0x00202C94
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x0600D873 RID: 55411 RVA: 0x00204AC4 File Offset: 0x00202CC4
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

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x0600D874 RID: 55412 RVA: 0x00204AFE File Offset: 0x00202CFE
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

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x0600D875 RID: 55413 RVA: 0x00204B32 File Offset: 0x00202D32
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

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x0600D876 RID: 55414 RVA: 0x00204B68 File Offset: 0x00202D68
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

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0600D877 RID: 55415 RVA: 0x00204BE8 File Offset: 0x00202DE8
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

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x0600D878 RID: 55416 RVA: 0x00204C68 File Offset: 0x00202E68
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x0600D879 RID: 55417 RVA: 0x00204CB8 File Offset: 0x00202EB8
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

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x0600D87A RID: 55418 RVA: 0x00204D38 File Offset: 0x00202F38
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

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x0600D87B RID: 55419 RVA: 0x00204D72 File Offset: 0x00202F72
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

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x0600D87C RID: 55420 RVA: 0x00204DA8 File Offset: 0x00202FA8
		public virtual int? CustomDescTextId
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.CustomDescTextId);
			}
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x0600D87D RID: 55421 RVA: 0x00204DE2 File Offset: 0x00202FE2
		public virtual string TidCustomDescText
		{
			get
			{
				return this.Instance.TidCustomDescText;
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x0600D87E RID: 55422 RVA: 0x00204DEF File Offset: 0x00202FEF
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
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x0600D87F RID: 55423 RVA: 0x00204E1E File Offset: 0x0020301E
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
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0600D880 RID: 55424 RVA: 0x00204E4D File Offset: 0x0020304D
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
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0600D881 RID: 55425 RVA: 0x00204E7C File Offset: 0x0020307C
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this.Instance.NullMask & 2097152U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotKeyId);
			}
		}

		// Token: 0x0400780C RID: 30732
		private ITalkItemVisualNovelOption Instance;

		// Token: 0x0400780D RID: 30733
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x0400780E RID: 30734
		private bool _CaptionParamsInited;

		// Token: 0x0400780F RID: 30735
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007810 RID: 30736
		private bool _ActionsInited;

		// Token: 0x04007811 RID: 30737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007812 RID: 30738
		private bool _OptionsInited;

		// Token: 0x04007813 RID: 30739
		private PlayMontage _MontageCache;

		// Token: 0x04007814 RID: 30740
		private bool _MontageInited;

		// Token: 0x04007815 RID: 30741
		private ICameraData _CameraDataCache;

		// Token: 0x04007816 RID: 30742
		private bool _CameraDataInited;

		// Token: 0x04007817 RID: 30743
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007818 RID: 30744
		private bool _FlowTemplateInited;

		// Token: 0x04007819 RID: 30745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400781A RID: 30746
		private bool _FlowTemplateListInited;

		// Token: 0x0400781B RID: 30747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x0400781C RID: 30748
		private bool _ActorMontageArrayInited;

		// Token: 0x0400781D RID: 30749
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x0400781E RID: 30750
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x0400781F RID: 30751
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007820 RID: 30752
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007821 RID: 30753
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007822 RID: 30754
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007823 RID: 30755
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007824 RID: 30756
		private bool _TalkAkEventInited;

		// Token: 0x04007825 RID: 30757
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007826 RID: 30758
		private bool _TalkEndAkEventInited;

		// Token: 0x04007827 RID: 30759
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007828 RID: 30760
		private bool _UniversalToneInited;

		// Token: 0x04007829 RID: 30761
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400782A RID: 30762
		private bool _BackgroundConfigInited;

		// Token: 0x0400782B RID: 30763
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400782C RID: 30764
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400782D RID: 30765
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400782E RID: 30766
		private bool _GamepadShakeInited;

		// Token: 0x0400782F RID: 30767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007830 RID: 30768
		private bool _IntroActionsInited;

		// Token: 0x04007831 RID: 30769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007832 RID: 30770
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007833 RID: 30771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007834 RID: 30772
		private bool _TalkEffectArrayInited;

		// Token: 0x04007835 RID: 30773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007836 RID: 30774
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007837 RID: 30775
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x04007838 RID: 30776
		private bool _OptionGroupInited;

		// Token: 0x04007839 RID: 30777
		[Nullable(1)]
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x0400783A RID: 30778
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x0400783B RID: 30779
		[Nullable(1)]
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x0400783C RID: 30780
		private bool _CgConfigInited;

		// Token: 0x0400783D RID: 30781
		[Nullable(1)]
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x0400783E RID: 30782
		private bool _DisplayItemConfigInited;
	}
}
