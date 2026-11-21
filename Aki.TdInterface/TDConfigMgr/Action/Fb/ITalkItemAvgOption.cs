using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002806 RID: 10246
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgOption : ITalkItem
	{
		// Token: 0x0600E3D5 RID: 58325 RVA: 0x0021A572 File Offset: 0x00218772
		[NullableContext(0)]
		public static ITalkItemAvgOption Create(ITalkItemAvgOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x0600E3D6 RID: 58326 RVA: 0x0021A594 File Offset: 0x00218794
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

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0600E3D7 RID: 58327 RVA: 0x0021A5CA File Offset: 0x002187CA
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x0021A5D8 File Offset: 0x002187D8
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

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x0021A60E File Offset: 0x0021880E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x0021A61B File Offset: 0x0021881B
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x0600E3DB RID: 58331 RVA: 0x0021A628 File Offset: 0x00218828
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

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x0600E3DC RID: 58332 RVA: 0x0021A660 File Offset: 0x00218860
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

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x0021A698 File Offset: 0x00218898
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

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x0600E3DE RID: 58334 RVA: 0x0021A6D0 File Offset: 0x002188D0
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

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x0021A707 File Offset: 0x00218907
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0600E3E0 RID: 58336 RVA: 0x0021A714 File Offset: 0x00218914
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

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x0021A74B File Offset: 0x0021894B
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

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x0600E3E2 RID: 58338 RVA: 0x0021A780 File Offset: 0x00218980
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

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x0600E3E3 RID: 58339 RVA: 0x0021A800 File Offset: 0x00218A00
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

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x0600E3E4 RID: 58340 RVA: 0x0021A87E File Offset: 0x00218A7E
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

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x0021A8B2 File Offset: 0x00218AB2
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

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x0021A8E6 File Offset: 0x00218AE6
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

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x0021A91C File Offset: 0x00218B1C
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

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x0600E3E8 RID: 58344 RVA: 0x0021A99C File Offset: 0x00218B9C
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

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x0021AA1C File Offset: 0x00218C1C
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

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x0600E3EA RID: 58346 RVA: 0x0021AA9C File Offset: 0x00218C9C
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

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x0600E3EB RID: 58347 RVA: 0x0021AB1C File Offset: 0x00218D1C
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

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x0600E3EC RID: 58348 RVA: 0x0021AB9A File Offset: 0x00218D9A
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x0600E3ED RID: 58349 RVA: 0x0021ABC9 File Offset: 0x00218DC9
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x0600E3EE RID: 58350 RVA: 0x0021ABF8 File Offset: 0x00218DF8
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

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x0600E3EF RID: 58351 RVA: 0x0021AC2C File Offset: 0x00218E2C
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x0600E3F0 RID: 58352 RVA: 0x0021AC5C File Offset: 0x00218E5C
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

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0600E3F1 RID: 58353 RVA: 0x0021AC96 File Offset: 0x00218E96
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

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x0600E3F2 RID: 58354 RVA: 0x0021ACCA File Offset: 0x00218ECA
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

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x0021AD00 File Offset: 0x00218F00
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

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x0600E3F4 RID: 58356 RVA: 0x0021AD80 File Offset: 0x00218F80
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

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x0600E3F5 RID: 58357 RVA: 0x0021AE00 File Offset: 0x00219000
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x0600E3F6 RID: 58358 RVA: 0x0021AE50 File Offset: 0x00219050
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

		// Token: 0x04007CDA RID: 31962
		private ITalkItemAvgOption Instance;

		// Token: 0x04007CDB RID: 31963
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007CDC RID: 31964
		private bool _CaptionParamsInited;

		// Token: 0x04007CDD RID: 31965
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007CDE RID: 31966
		private bool _ActionsInited;

		// Token: 0x04007CDF RID: 31967
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007CE0 RID: 31968
		private bool _OptionsInited;

		// Token: 0x04007CE1 RID: 31969
		private PlayMontage _MontageCache;

		// Token: 0x04007CE2 RID: 31970
		private bool _MontageInited;

		// Token: 0x04007CE3 RID: 31971
		private ICameraData _CameraDataCache;

		// Token: 0x04007CE4 RID: 31972
		private bool _CameraDataInited;

		// Token: 0x04007CE5 RID: 31973
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007CE6 RID: 31974
		private bool _FlowTemplateInited;

		// Token: 0x04007CE7 RID: 31975
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007CE8 RID: 31976
		private bool _FlowTemplateListInited;

		// Token: 0x04007CE9 RID: 31977
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007CEA RID: 31978
		private bool _ActorMontageArrayInited;

		// Token: 0x04007CEB RID: 31979
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007CEC RID: 31980
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007CED RID: 31981
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007CEE RID: 31982
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007CEF RID: 31983
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007CF0 RID: 31984
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007CF1 RID: 31985
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007CF2 RID: 31986
		private bool _TalkAkEventInited;

		// Token: 0x04007CF3 RID: 31987
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007CF4 RID: 31988
		private bool _TalkEndAkEventInited;

		// Token: 0x04007CF5 RID: 31989
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007CF6 RID: 31990
		private bool _UniversalToneInited;

		// Token: 0x04007CF7 RID: 31991
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007CF8 RID: 31992
		private bool _BackgroundConfigInited;

		// Token: 0x04007CF9 RID: 31993
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007CFA RID: 31994
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007CFB RID: 31995
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007CFC RID: 31996
		private bool _GamepadShakeInited;

		// Token: 0x04007CFD RID: 31997
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007CFE RID: 31998
		private bool _IntroActionsInited;

		// Token: 0x04007CFF RID: 31999
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007D00 RID: 32000
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007D01 RID: 32001
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007D02 RID: 32002
		private bool _TalkEffectArrayInited;

		// Token: 0x04007D03 RID: 32003
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007D04 RID: 32004
		private bool _ActorVisibilityArrayInited;
	}
}
