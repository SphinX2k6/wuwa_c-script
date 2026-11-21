using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002805 RID: 10245
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgExit : ITalkItem
	{
		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00219BDB File Offset: 0x00217DDB
		[NullableContext(0)]
		public static ITalkItemAvgExit Create(ITalkItemAvgExit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgExit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x00219BFC File Offset: 0x00217DFC
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

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x0600E3B3 RID: 58291 RVA: 0x00219C32 File Offset: 0x00217E32
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x00219C40 File Offset: 0x00217E40
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

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x0600E3B5 RID: 58293 RVA: 0x00219C76 File Offset: 0x00217E76
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x00219C83 File Offset: 0x00217E83
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x00219C90 File Offset: 0x00217E90
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

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x00219CC8 File Offset: 0x00217EC8
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

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0600E3B9 RID: 58297 RVA: 0x00219D00 File Offset: 0x00217F00
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

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x00219D38 File Offset: 0x00217F38
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

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x0600E3BB RID: 58299 RVA: 0x00219D6F File Offset: 0x00217F6F
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x00219D7C File Offset: 0x00217F7C
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

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x00219DB3 File Offset: 0x00217FB3
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

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x00219DE8 File Offset: 0x00217FE8
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

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0600E3BF RID: 58303 RVA: 0x00219E68 File Offset: 0x00218068
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

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x00219EE6 File Offset: 0x002180E6
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

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x0600E3C1 RID: 58305 RVA: 0x00219F1A File Offset: 0x0021811A
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

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x00219F4E File Offset: 0x0021814E
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

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x0600E3C3 RID: 58307 RVA: 0x00219F84 File Offset: 0x00218184
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

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x0021A004 File Offset: 0x00218204
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

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x0600E3C5 RID: 58309 RVA: 0x0021A084 File Offset: 0x00218284
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

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x0021A104 File Offset: 0x00218304
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

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x0600E3C7 RID: 58311 RVA: 0x0021A184 File Offset: 0x00218384
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

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x0021A202 File Offset: 0x00218402
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgExit_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x0600E3C9 RID: 58313 RVA: 0x0021A231 File Offset: 0x00218431
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgExit_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x0021A260 File Offset: 0x00218460
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

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x0600E3CB RID: 58315 RVA: 0x0021A294 File Offset: 0x00218494
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgExit_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x0021A2C4 File Offset: 0x002184C4
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

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x0600E3CD RID: 58317 RVA: 0x0021A2FE File Offset: 0x002184FE
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

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x0021A332 File Offset: 0x00218532
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

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x0600E3CF RID: 58319 RVA: 0x0021A368 File Offset: 0x00218568
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

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x0600E3D0 RID: 58320 RVA: 0x0021A3E8 File Offset: 0x002185E8
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

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x0600E3D1 RID: 58321 RVA: 0x0021A468 File Offset: 0x00218668
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgExit_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x0600E3D2 RID: 58322 RVA: 0x0021A4B8 File Offset: 0x002186B8
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

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x0600E3D3 RID: 58323 RVA: 0x0021A536 File Offset: 0x00218736
		[Nullable(0)]
		public virtual ITalkItemAvgRoleConfig AvgRoleConfig
		{
			[NullableContext(0)]
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

		// Token: 0x04007CAD RID: 31917
		private ITalkItemAvgExit Instance;

		// Token: 0x04007CAE RID: 31918
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007CAF RID: 31919
		private bool _CaptionParamsInited;

		// Token: 0x04007CB0 RID: 31920
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007CB1 RID: 31921
		private bool _ActionsInited;

		// Token: 0x04007CB2 RID: 31922
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007CB3 RID: 31923
		private bool _OptionsInited;

		// Token: 0x04007CB4 RID: 31924
		private PlayMontage _MontageCache;

		// Token: 0x04007CB5 RID: 31925
		private bool _MontageInited;

		// Token: 0x04007CB6 RID: 31926
		private ICameraData _CameraDataCache;

		// Token: 0x04007CB7 RID: 31927
		private bool _CameraDataInited;

		// Token: 0x04007CB8 RID: 31928
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007CB9 RID: 31929
		private bool _FlowTemplateInited;

		// Token: 0x04007CBA RID: 31930
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007CBB RID: 31931
		private bool _FlowTemplateListInited;

		// Token: 0x04007CBC RID: 31932
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007CBD RID: 31933
		private bool _ActorMontageArrayInited;

		// Token: 0x04007CBE RID: 31934
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007CBF RID: 31935
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007CC0 RID: 31936
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007CC1 RID: 31937
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007CC2 RID: 31938
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007CC3 RID: 31939
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007CC4 RID: 31940
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007CC5 RID: 31941
		private bool _TalkAkEventInited;

		// Token: 0x04007CC6 RID: 31942
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007CC7 RID: 31943
		private bool _TalkEndAkEventInited;

		// Token: 0x04007CC8 RID: 31944
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007CC9 RID: 31945
		private bool _UniversalToneInited;

		// Token: 0x04007CCA RID: 31946
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007CCB RID: 31947
		private bool _BackgroundConfigInited;

		// Token: 0x04007CCC RID: 31948
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007CCD RID: 31949
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007CCE RID: 31950
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007CCF RID: 31951
		private bool _GamepadShakeInited;

		// Token: 0x04007CD0 RID: 31952
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007CD1 RID: 31953
		private bool _IntroActionsInited;

		// Token: 0x04007CD2 RID: 31954
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007CD3 RID: 31955
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007CD4 RID: 31956
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007CD5 RID: 31957
		private bool _TalkEffectArrayInited;

		// Token: 0x04007CD6 RID: 31958
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007CD7 RID: 31959
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007CD8 RID: 31960
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x04007CD9 RID: 31961
		private bool _AvgRoleConfigInited;
	}
}
