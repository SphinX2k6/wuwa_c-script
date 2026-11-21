using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002808 RID: 10248
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgCenterText : ITalkItem
	{
		// Token: 0x0600E41B RID: 58395 RVA: 0x0021B83A File Offset: 0x00219A3A
		[NullableContext(0)]
		public static ITalkItemAvgCenterText Create(ITalkItemAvgCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x0600E41C RID: 58396 RVA: 0x0021B85C File Offset: 0x00219A5C
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

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x0600E41D RID: 58397 RVA: 0x0021B892 File Offset: 0x00219A92
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x0600E41E RID: 58398 RVA: 0x0021B8A0 File Offset: 0x00219AA0
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

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0600E41F RID: 58399 RVA: 0x0021B8D6 File Offset: 0x00219AD6
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0600E420 RID: 58400 RVA: 0x0021B8E3 File Offset: 0x00219AE3
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x0600E421 RID: 58401 RVA: 0x0021B8F0 File Offset: 0x00219AF0
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

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x0600E422 RID: 58402 RVA: 0x0021B928 File Offset: 0x00219B28
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

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x0600E423 RID: 58403 RVA: 0x0021B960 File Offset: 0x00219B60
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

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x0600E424 RID: 58404 RVA: 0x0021B998 File Offset: 0x00219B98
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

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x0600E425 RID: 58405 RVA: 0x0021B9CF File Offset: 0x00219BCF
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x0021B9DC File Offset: 0x00219BDC
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

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x0600E427 RID: 58407 RVA: 0x0021BA13 File Offset: 0x00219C13
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

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x0600E428 RID: 58408 RVA: 0x0021BA48 File Offset: 0x00219C48
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

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x0600E429 RID: 58409 RVA: 0x0021BAC8 File Offset: 0x00219CC8
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

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x0600E42A RID: 58410 RVA: 0x0021BB46 File Offset: 0x00219D46
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

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x0600E42B RID: 58411 RVA: 0x0021BB7A File Offset: 0x00219D7A
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

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x0600E42C RID: 58412 RVA: 0x0021BBAE File Offset: 0x00219DAE
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

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x0600E42D RID: 58413 RVA: 0x0021BBE4 File Offset: 0x00219DE4
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

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x0600E42E RID: 58414 RVA: 0x0021BC64 File Offset: 0x00219E64
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

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x0600E42F RID: 58415 RVA: 0x0021BCE4 File Offset: 0x00219EE4
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

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x0600E430 RID: 58416 RVA: 0x0021BD64 File Offset: 0x00219F64
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

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x0600E431 RID: 58417 RVA: 0x0021BDE4 File Offset: 0x00219FE4
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

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x0600E432 RID: 58418 RVA: 0x0021BE62 File Offset: 0x0021A062
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgCenterText_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x0600E433 RID: 58419 RVA: 0x0021BE91 File Offset: 0x0021A091
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgCenterText_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x0600E434 RID: 58420 RVA: 0x0021BEC0 File Offset: 0x0021A0C0
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

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x0600E435 RID: 58421 RVA: 0x0021BEF4 File Offset: 0x0021A0F4
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgCenterText_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x0600E436 RID: 58422 RVA: 0x0021BF24 File Offset: 0x0021A124
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

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x0600E437 RID: 58423 RVA: 0x0021BF5E File Offset: 0x0021A15E
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

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x0600E438 RID: 58424 RVA: 0x0021BF92 File Offset: 0x0021A192
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

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x0600E439 RID: 58425 RVA: 0x0021BFC8 File Offset: 0x0021A1C8
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

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x0600E43A RID: 58426 RVA: 0x0021C048 File Offset: 0x0021A248
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

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x0600E43B RID: 58427 RVA: 0x0021C0C8 File Offset: 0x0021A2C8
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgCenterText_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x0600E43C RID: 58428 RVA: 0x0021C118 File Offset: 0x0021A318
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

		// Token: 0x04007D30 RID: 32048
		private ITalkItemAvgCenterText Instance;

		// Token: 0x04007D31 RID: 32049
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007D32 RID: 32050
		private bool _CaptionParamsInited;

		// Token: 0x04007D33 RID: 32051
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007D34 RID: 32052
		private bool _ActionsInited;

		// Token: 0x04007D35 RID: 32053
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007D36 RID: 32054
		private bool _OptionsInited;

		// Token: 0x04007D37 RID: 32055
		private PlayMontage _MontageCache;

		// Token: 0x04007D38 RID: 32056
		private bool _MontageInited;

		// Token: 0x04007D39 RID: 32057
		private ICameraData _CameraDataCache;

		// Token: 0x04007D3A RID: 32058
		private bool _CameraDataInited;

		// Token: 0x04007D3B RID: 32059
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007D3C RID: 32060
		private bool _FlowTemplateInited;

		// Token: 0x04007D3D RID: 32061
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007D3E RID: 32062
		private bool _FlowTemplateListInited;

		// Token: 0x04007D3F RID: 32063
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007D40 RID: 32064
		private bool _ActorMontageArrayInited;

		// Token: 0x04007D41 RID: 32065
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007D42 RID: 32066
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007D43 RID: 32067
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007D44 RID: 32068
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007D45 RID: 32069
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007D46 RID: 32070
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007D47 RID: 32071
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007D48 RID: 32072
		private bool _TalkAkEventInited;

		// Token: 0x04007D49 RID: 32073
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007D4A RID: 32074
		private bool _TalkEndAkEventInited;

		// Token: 0x04007D4B RID: 32075
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007D4C RID: 32076
		private bool _UniversalToneInited;

		// Token: 0x04007D4D RID: 32077
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007D4E RID: 32078
		private bool _BackgroundConfigInited;

		// Token: 0x04007D4F RID: 32079
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007D50 RID: 32080
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007D51 RID: 32081
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007D52 RID: 32082
		private bool _GamepadShakeInited;

		// Token: 0x04007D53 RID: 32083
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007D54 RID: 32084
		private bool _IntroActionsInited;

		// Token: 0x04007D55 RID: 32085
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007D56 RID: 32086
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007D57 RID: 32087
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007D58 RID: 32088
		private bool _TalkEffectArrayInited;

		// Token: 0x04007D59 RID: 32089
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007D5A RID: 32090
		private bool _ActorVisibilityArrayInited;
	}
}
