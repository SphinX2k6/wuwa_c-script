using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F0 RID: 10224
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDialog : ITalkItem
	{
		// Token: 0x0600E22B RID: 57899 RVA: 0x00213C51 File Offset: 0x00211E51
		[NullableContext(0)]
		public static ITalkItemDialog Create(ITalkItemDialog? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemDialog
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x0600E22C RID: 57900 RVA: 0x00213C70 File Offset: 0x00211E70
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

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x0600E22D RID: 57901 RVA: 0x00213CA6 File Offset: 0x00211EA6
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x0600E22E RID: 57902 RVA: 0x00213CB4 File Offset: 0x00211EB4
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

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x0600E22F RID: 57903 RVA: 0x00213CEA File Offset: 0x00211EEA
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0600E230 RID: 57904 RVA: 0x00213CF7 File Offset: 0x00211EF7
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0600E231 RID: 57905 RVA: 0x00213D04 File Offset: 0x00211F04
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

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x0600E232 RID: 57906 RVA: 0x00213D3C File Offset: 0x00211F3C
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

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x0600E233 RID: 57907 RVA: 0x00213D74 File Offset: 0x00211F74
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

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x0600E234 RID: 57908 RVA: 0x00213DAC File Offset: 0x00211FAC
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

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x0600E235 RID: 57909 RVA: 0x00213DE3 File Offset: 0x00211FE3
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x0600E236 RID: 57910 RVA: 0x00213DF0 File Offset: 0x00211FF0
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

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0600E237 RID: 57911 RVA: 0x00213E27 File Offset: 0x00212027
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

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0600E238 RID: 57912 RVA: 0x00213E5C File Offset: 0x0021205C
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

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0600E239 RID: 57913 RVA: 0x00213EDC File Offset: 0x002120DC
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

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x0600E23A RID: 57914 RVA: 0x00213F5A File Offset: 0x0021215A
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

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x0600E23B RID: 57915 RVA: 0x00213F8E File Offset: 0x0021218E
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

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x0600E23C RID: 57916 RVA: 0x00213FC2 File Offset: 0x002121C2
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

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x0600E23D RID: 57917 RVA: 0x00213FF8 File Offset: 0x002121F8
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

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x0600E23E RID: 57918 RVA: 0x00214078 File Offset: 0x00212278
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

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0600E23F RID: 57919 RVA: 0x002140F8 File Offset: 0x002122F8
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

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x0600E240 RID: 57920 RVA: 0x00214178 File Offset: 0x00212378
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

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x0600E241 RID: 57921 RVA: 0x002141F8 File Offset: 0x002123F8
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

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x0600E242 RID: 57922 RVA: 0x00214276 File Offset: 0x00212476
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemDialog_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x0600E243 RID: 57923 RVA: 0x002142A5 File Offset: 0x002124A5
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemDialog_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x0600E244 RID: 57924 RVA: 0x002142D4 File Offset: 0x002124D4
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

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x0600E245 RID: 57925 RVA: 0x00214308 File Offset: 0x00212508
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemDialog_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x0600E246 RID: 57926 RVA: 0x00214338 File Offset: 0x00212538
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

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x0600E247 RID: 57927 RVA: 0x00214372 File Offset: 0x00212572
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

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0600E248 RID: 57928 RVA: 0x002143A6 File Offset: 0x002125A6
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

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0600E249 RID: 57929 RVA: 0x002143DC File Offset: 0x002125DC
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

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0600E24A RID: 57930 RVA: 0x0021445C File Offset: 0x0021265C
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

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0600E24B RID: 57931 RVA: 0x002144DC File Offset: 0x002126DC
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemDialog_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0600E24C RID: 57932 RVA: 0x0021452C File Offset: 0x0021272C
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

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0600E24D RID: 57933 RVA: 0x002145AA File Offset: 0x002127AA
		[Nullable(0)]
		public virtual ITalkItemStyle Style
		{
			[NullableContext(0)]
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				this._StyleCache = ActionReadHelper.ReadITalkItemDialog_Style(this.Instance);
				return this._StyleCache;
			}
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0600E24E RID: 57934 RVA: 0x002145D9 File Offset: 0x002127D9
		[Nullable(0)]
		public virtual IShowTalkCameraMotion CameraMotion
		{
			[NullableContext(0)]
			get
			{
				if (this._CameraMotionInited)
				{
					return this._CameraMotionCache;
				}
				this._CameraMotionInited = true;
				this._CameraMotionCache = ActionReadHelper.ReadITalkItemDialog_CameraMotion(this.Instance);
				return this._CameraMotionCache;
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0600E24F RID: 57935 RVA: 0x00214608 File Offset: 0x00212808
		public virtual ITalkItemAutoPlayConfig AutoPlayConfig
		{
			get
			{
				if (this._AutoPlayConfigInited)
				{
					return this._AutoPlayConfigCache;
				}
				this._AutoPlayConfigInited = true;
				this._AutoPlayConfigCache = ITalkItemAutoPlayConfig.Create(this.Instance.AutoPlayConfig);
				return this._AutoPlayConfigCache;
			}
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0600E250 RID: 57936 RVA: 0x0021463C File Offset: 0x0021283C
		public virtual bool? NoMouthAnim
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance.NoMouthAnim);
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0600E251 RID: 57937 RVA: 0x00214678 File Offset: 0x00212878
		public virtual float? OtherIsTypingDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new float?(this.Instance.OtherIsTypingDuration);
			}
		}

		// Token: 0x04007AF8 RID: 31480
		private ITalkItemDialog Instance;

		// Token: 0x04007AF9 RID: 31481
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007AFA RID: 31482
		private bool _CaptionParamsInited;

		// Token: 0x04007AFB RID: 31483
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007AFC RID: 31484
		private bool _ActionsInited;

		// Token: 0x04007AFD RID: 31485
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007AFE RID: 31486
		private bool _OptionsInited;

		// Token: 0x04007AFF RID: 31487
		private PlayMontage _MontageCache;

		// Token: 0x04007B00 RID: 31488
		private bool _MontageInited;

		// Token: 0x04007B01 RID: 31489
		private ICameraData _CameraDataCache;

		// Token: 0x04007B02 RID: 31490
		private bool _CameraDataInited;

		// Token: 0x04007B03 RID: 31491
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007B04 RID: 31492
		private bool _FlowTemplateInited;

		// Token: 0x04007B05 RID: 31493
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007B06 RID: 31494
		private bool _FlowTemplateListInited;

		// Token: 0x04007B07 RID: 31495
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007B08 RID: 31496
		private bool _ActorMontageArrayInited;

		// Token: 0x04007B09 RID: 31497
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007B0A RID: 31498
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007B0B RID: 31499
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007B0C RID: 31500
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007B0D RID: 31501
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007B0E RID: 31502
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007B0F RID: 31503
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007B10 RID: 31504
		private bool _TalkAkEventInited;

		// Token: 0x04007B11 RID: 31505
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007B12 RID: 31506
		private bool _TalkEndAkEventInited;

		// Token: 0x04007B13 RID: 31507
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007B14 RID: 31508
		private bool _UniversalToneInited;

		// Token: 0x04007B15 RID: 31509
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007B16 RID: 31510
		private bool _BackgroundConfigInited;

		// Token: 0x04007B17 RID: 31511
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007B18 RID: 31512
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007B19 RID: 31513
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007B1A RID: 31514
		private bool _GamepadShakeInited;

		// Token: 0x04007B1B RID: 31515
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007B1C RID: 31516
		private bool _IntroActionsInited;

		// Token: 0x04007B1D RID: 31517
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007B1E RID: 31518
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007B1F RID: 31519
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007B20 RID: 31520
		private bool _TalkEffectArrayInited;

		// Token: 0x04007B21 RID: 31521
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007B22 RID: 31522
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007B23 RID: 31523
		[Nullable(0)]
		private ITalkItemStyle _StyleCache;

		// Token: 0x04007B24 RID: 31524
		private bool _StyleInited;

		// Token: 0x04007B25 RID: 31525
		[Nullable(0)]
		private IShowTalkCameraMotion _CameraMotionCache;

		// Token: 0x04007B26 RID: 31526
		private bool _CameraMotionInited;

		// Token: 0x04007B27 RID: 31527
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x04007B28 RID: 31528
		private bool _AutoPlayConfigInited;
	}
}
