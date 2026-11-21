using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002804 RID: 10244
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgEnter : ITalkItem
	{
		// Token: 0x0600E38C RID: 58252 RVA: 0x00219237 File Offset: 0x00217437
		[NullableContext(0)]
		public static ITalkItemAvgEnter Create(ITalkItemAvgEnter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgEnter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x0600E38D RID: 58253 RVA: 0x00219258 File Offset: 0x00217458
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

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x0600E38E RID: 58254 RVA: 0x0021928E File Offset: 0x0021748E
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x0600E38F RID: 58255 RVA: 0x0021929C File Offset: 0x0021749C
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

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x0600E390 RID: 58256 RVA: 0x002192D2 File Offset: 0x002174D2
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x0600E391 RID: 58257 RVA: 0x002192DF File Offset: 0x002174DF
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x0600E392 RID: 58258 RVA: 0x002192EC File Offset: 0x002174EC
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

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x0600E393 RID: 58259 RVA: 0x00219324 File Offset: 0x00217524
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

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x0600E394 RID: 58260 RVA: 0x0021935C File Offset: 0x0021755C
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

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x0600E395 RID: 58261 RVA: 0x00219394 File Offset: 0x00217594
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

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x0600E396 RID: 58262 RVA: 0x002193CB File Offset: 0x002175CB
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x0600E397 RID: 58263 RVA: 0x002193D8 File Offset: 0x002175D8
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

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x0600E398 RID: 58264 RVA: 0x0021940F File Offset: 0x0021760F
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

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x0600E399 RID: 58265 RVA: 0x00219444 File Offset: 0x00217644
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

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x0600E39A RID: 58266 RVA: 0x002194C4 File Offset: 0x002176C4
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

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x0600E39B RID: 58267 RVA: 0x00219542 File Offset: 0x00217742
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

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x0600E39C RID: 58268 RVA: 0x00219576 File Offset: 0x00217776
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

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x0600E39D RID: 58269 RVA: 0x002195AA File Offset: 0x002177AA
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

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x002195E0 File Offset: 0x002177E0
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

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x0600E39F RID: 58271 RVA: 0x00219660 File Offset: 0x00217860
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

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x002196E0 File Offset: 0x002178E0
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

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x0600E3A1 RID: 58273 RVA: 0x00219760 File Offset: 0x00217960
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

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x0600E3A2 RID: 58274 RVA: 0x002197E0 File Offset: 0x002179E0
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

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x0600E3A3 RID: 58275 RVA: 0x0021985E File Offset: 0x00217A5E
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgEnter_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x0600E3A4 RID: 58276 RVA: 0x0021988D File Offset: 0x00217A8D
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgEnter_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x0600E3A5 RID: 58277 RVA: 0x002198BC File Offset: 0x00217ABC
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

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x002198F0 File Offset: 0x00217AF0
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgEnter_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x0600E3A7 RID: 58279 RVA: 0x00219920 File Offset: 0x00217B20
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

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x0021995A File Offset: 0x00217B5A
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

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x0600E3A9 RID: 58281 RVA: 0x0021998E File Offset: 0x00217B8E
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

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x0600E3AA RID: 58282 RVA: 0x002199C4 File Offset: 0x00217BC4
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

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x0600E3AB RID: 58283 RVA: 0x00219A44 File Offset: 0x00217C44
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

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x0600E3AC RID: 58284 RVA: 0x00219AC4 File Offset: 0x00217CC4
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgEnter_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x0600E3AD RID: 58285 RVA: 0x00219B14 File Offset: 0x00217D14
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

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x00219B92 File Offset: 0x00217D92
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

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x0600E3AF RID: 58287 RVA: 0x00219BC6 File Offset: 0x00217DC6
		public virtual EAvgRolePosition PositionConfig
		{
			get
			{
				return (EAvgRolePosition)this.Instance.PositionConfig;
			}
		}

		// Token: 0x04007C80 RID: 31872
		private ITalkItemAvgEnter Instance;

		// Token: 0x04007C81 RID: 31873
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007C82 RID: 31874
		private bool _CaptionParamsInited;

		// Token: 0x04007C83 RID: 31875
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007C84 RID: 31876
		private bool _ActionsInited;

		// Token: 0x04007C85 RID: 31877
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007C86 RID: 31878
		private bool _OptionsInited;

		// Token: 0x04007C87 RID: 31879
		private PlayMontage _MontageCache;

		// Token: 0x04007C88 RID: 31880
		private bool _MontageInited;

		// Token: 0x04007C89 RID: 31881
		private ICameraData _CameraDataCache;

		// Token: 0x04007C8A RID: 31882
		private bool _CameraDataInited;

		// Token: 0x04007C8B RID: 31883
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007C8C RID: 31884
		private bool _FlowTemplateInited;

		// Token: 0x04007C8D RID: 31885
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007C8E RID: 31886
		private bool _FlowTemplateListInited;

		// Token: 0x04007C8F RID: 31887
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007C90 RID: 31888
		private bool _ActorMontageArrayInited;

		// Token: 0x04007C91 RID: 31889
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007C92 RID: 31890
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007C93 RID: 31891
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007C94 RID: 31892
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007C95 RID: 31893
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007C96 RID: 31894
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007C97 RID: 31895
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007C98 RID: 31896
		private bool _TalkAkEventInited;

		// Token: 0x04007C99 RID: 31897
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007C9A RID: 31898
		private bool _TalkEndAkEventInited;

		// Token: 0x04007C9B RID: 31899
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007C9C RID: 31900
		private bool _UniversalToneInited;

		// Token: 0x04007C9D RID: 31901
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007C9E RID: 31902
		private bool _BackgroundConfigInited;

		// Token: 0x04007C9F RID: 31903
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007CA0 RID: 31904
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007CA1 RID: 31905
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007CA2 RID: 31906
		private bool _GamepadShakeInited;

		// Token: 0x04007CA3 RID: 31907
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007CA4 RID: 31908
		private bool _IntroActionsInited;

		// Token: 0x04007CA5 RID: 31909
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007CA6 RID: 31910
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007CA7 RID: 31911
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007CA8 RID: 31912
		private bool _TalkEffectArrayInited;

		// Token: 0x04007CA9 RID: 31913
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007CAA RID: 31914
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007CAB RID: 31915
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x04007CAC RID: 31916
		private bool _AvgRoleConfigInited;
	}
}
