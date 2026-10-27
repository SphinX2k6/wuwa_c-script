using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002597 RID: 9623
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelCenterText : ITalkItem
	{
		// Token: 0x0600D883 RID: 55427 RVA: 0x00204EBE File Offset: 0x002030BE
		[NullableContext(1)]
		public static ITalkItemVisualNovelCenterText Create(ITalkItemVisualNovelCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0600D884 RID: 55428 RVA: 0x00204EE0 File Offset: 0x002030E0
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

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0600D885 RID: 55429 RVA: 0x00204F16 File Offset: 0x00203116
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0600D886 RID: 55430 RVA: 0x00204F24 File Offset: 0x00203124
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

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0600D887 RID: 55431 RVA: 0x00204F5A File Offset: 0x0020315A
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0600D888 RID: 55432 RVA: 0x00204F67 File Offset: 0x00203167
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0600D889 RID: 55433 RVA: 0x00204F74 File Offset: 0x00203174
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

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0600D88A RID: 55434 RVA: 0x00204FAC File Offset: 0x002031AC
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

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0600D88B RID: 55435 RVA: 0x00204FE4 File Offset: 0x002031E4
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

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0600D88C RID: 55436 RVA: 0x0020501C File Offset: 0x0020321C
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

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0600D88D RID: 55437 RVA: 0x00205053 File Offset: 0x00203253
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0600D88E RID: 55438 RVA: 0x00205060 File Offset: 0x00203260
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

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x0600D88F RID: 55439 RVA: 0x00205097 File Offset: 0x00203297
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

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0600D890 RID: 55440 RVA: 0x002050CC File Offset: 0x002032CC
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

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0600D891 RID: 55441 RVA: 0x0020514C File Offset: 0x0020334C
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

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0600D892 RID: 55442 RVA: 0x002051CA File Offset: 0x002033CA
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

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0600D893 RID: 55443 RVA: 0x002051FE File Offset: 0x002033FE
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

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x0600D894 RID: 55444 RVA: 0x00205232 File Offset: 0x00203432
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

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0600D895 RID: 55445 RVA: 0x00205268 File Offset: 0x00203468
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

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x0600D896 RID: 55446 RVA: 0x002052E8 File Offset: 0x002034E8
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

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0600D897 RID: 55447 RVA: 0x00205368 File Offset: 0x00203568
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

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0600D898 RID: 55448 RVA: 0x002053E8 File Offset: 0x002035E8
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

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0600D899 RID: 55449 RVA: 0x00205468 File Offset: 0x00203668
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

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0600D89A RID: 55450 RVA: 0x002054E6 File Offset: 0x002036E6
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x0600D89B RID: 55451 RVA: 0x00205515 File Offset: 0x00203715
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0600D89C RID: 55452 RVA: 0x00205544 File Offset: 0x00203744
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

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x0600D89D RID: 55453 RVA: 0x00205578 File Offset: 0x00203778
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x0600D89E RID: 55454 RVA: 0x002055A8 File Offset: 0x002037A8
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

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x0600D89F RID: 55455 RVA: 0x002055E2 File Offset: 0x002037E2
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

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0600D8A0 RID: 55456 RVA: 0x00205616 File Offset: 0x00203816
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

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x0600D8A1 RID: 55457 RVA: 0x0020564C File Offset: 0x0020384C
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

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x002056CC File Offset: 0x002038CC
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

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0600D8A3 RID: 55459 RVA: 0x0020574C File Offset: 0x0020394C
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x0020579C File Offset: 0x0020399C
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

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0600D8A5 RID: 55461 RVA: 0x0020581C File Offset: 0x00203A1C
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

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0600D8A6 RID: 55462 RVA: 0x00205856 File Offset: 0x00203A56
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

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x0600D8A7 RID: 55463 RVA: 0x0020588C File Offset: 0x00203A8C
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

		// Token: 0x0400783F RID: 30783
		private ITalkItemVisualNovelCenterText Instance;

		// Token: 0x04007840 RID: 30784
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007841 RID: 30785
		private bool _CaptionParamsInited;

		// Token: 0x04007842 RID: 30786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007843 RID: 30787
		private bool _ActionsInited;

		// Token: 0x04007844 RID: 30788
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007845 RID: 30789
		private bool _OptionsInited;

		// Token: 0x04007846 RID: 30790
		private PlayMontage _MontageCache;

		// Token: 0x04007847 RID: 30791
		private bool _MontageInited;

		// Token: 0x04007848 RID: 30792
		private ICameraData _CameraDataCache;

		// Token: 0x04007849 RID: 30793
		private bool _CameraDataInited;

		// Token: 0x0400784A RID: 30794
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400784B RID: 30795
		private bool _FlowTemplateInited;

		// Token: 0x0400784C RID: 30796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400784D RID: 30797
		private bool _FlowTemplateListInited;

		// Token: 0x0400784E RID: 30798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x0400784F RID: 30799
		private bool _ActorMontageArrayInited;

		// Token: 0x04007850 RID: 30800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007851 RID: 30801
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007852 RID: 30802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007853 RID: 30803
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007854 RID: 30804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007855 RID: 30805
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007856 RID: 30806
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007857 RID: 30807
		private bool _TalkAkEventInited;

		// Token: 0x04007858 RID: 30808
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007859 RID: 30809
		private bool _TalkEndAkEventInited;

		// Token: 0x0400785A RID: 30810
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400785B RID: 30811
		private bool _UniversalToneInited;

		// Token: 0x0400785C RID: 30812
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400785D RID: 30813
		private bool _BackgroundConfigInited;

		// Token: 0x0400785E RID: 30814
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400785F RID: 30815
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007860 RID: 30816
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007861 RID: 30817
		private bool _GamepadShakeInited;

		// Token: 0x04007862 RID: 30818
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007863 RID: 30819
		private bool _IntroActionsInited;

		// Token: 0x04007864 RID: 30820
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007865 RID: 30821
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007866 RID: 30822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007867 RID: 30823
		private bool _TalkEffectArrayInited;

		// Token: 0x04007868 RID: 30824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007869 RID: 30825
		private bool _ActorVisibilityArrayInited;

		// Token: 0x0400786A RID: 30826
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x0400786B RID: 30827
		private bool _OptionGroupInited;
	}
}
