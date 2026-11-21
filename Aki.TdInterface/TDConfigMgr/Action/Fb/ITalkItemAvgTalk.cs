using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002803 RID: 10243
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgTalk : ITalkItem
	{
		// Token: 0x0600E367 RID: 58215 RVA: 0x00218892 File Offset: 0x00216A92
		[NullableContext(0)]
		public static ITalkItemAvgTalk Create(ITalkItemAvgTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x002188B4 File Offset: 0x00216AB4
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

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x0600E369 RID: 58217 RVA: 0x002188EA File Offset: 0x00216AEA
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x0600E36A RID: 58218 RVA: 0x002188F8 File Offset: 0x00216AF8
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

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x0600E36B RID: 58219 RVA: 0x0021892E File Offset: 0x00216B2E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x0600E36C RID: 58220 RVA: 0x0021893B File Offset: 0x00216B3B
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x0600E36D RID: 58221 RVA: 0x00218948 File Offset: 0x00216B48
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

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x0600E36E RID: 58222 RVA: 0x00218980 File Offset: 0x00216B80
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

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x002189B8 File Offset: 0x00216BB8
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

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x0600E370 RID: 58224 RVA: 0x002189F0 File Offset: 0x00216BF0
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

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x0600E371 RID: 58225 RVA: 0x00218A27 File Offset: 0x00216C27
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0600E372 RID: 58226 RVA: 0x00218A34 File Offset: 0x00216C34
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

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x0600E373 RID: 58227 RVA: 0x00218A6B File Offset: 0x00216C6B
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

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x0600E374 RID: 58228 RVA: 0x00218AA0 File Offset: 0x00216CA0
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

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x0600E375 RID: 58229 RVA: 0x00218B20 File Offset: 0x00216D20
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

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x0600E376 RID: 58230 RVA: 0x00218B9E File Offset: 0x00216D9E
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

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x0600E377 RID: 58231 RVA: 0x00218BD2 File Offset: 0x00216DD2
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

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x0600E378 RID: 58232 RVA: 0x00218C06 File Offset: 0x00216E06
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

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x0600E379 RID: 58233 RVA: 0x00218C3C File Offset: 0x00216E3C
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

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x0600E37A RID: 58234 RVA: 0x00218CBC File Offset: 0x00216EBC
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

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x0600E37B RID: 58235 RVA: 0x00218D3C File Offset: 0x00216F3C
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

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x0600E37C RID: 58236 RVA: 0x00218DBC File Offset: 0x00216FBC
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

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0600E37D RID: 58237 RVA: 0x00218E3C File Offset: 0x0021703C
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

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0600E37E RID: 58238 RVA: 0x00218EBA File Offset: 0x002170BA
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgTalk_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x0600E37F RID: 58239 RVA: 0x00218EE9 File Offset: 0x002170E9
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgTalk_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x0600E380 RID: 58240 RVA: 0x00218F18 File Offset: 0x00217118
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

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x0600E381 RID: 58241 RVA: 0x00218F4C File Offset: 0x0021714C
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgTalk_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x0600E382 RID: 58242 RVA: 0x00218F7C File Offset: 0x0021717C
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

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x0600E383 RID: 58243 RVA: 0x00218FB6 File Offset: 0x002171B6
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

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x0600E384 RID: 58244 RVA: 0x00218FEA File Offset: 0x002171EA
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

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x0600E385 RID: 58245 RVA: 0x00219020 File Offset: 0x00217220
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

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x0600E386 RID: 58246 RVA: 0x002190A0 File Offset: 0x002172A0
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

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x0600E387 RID: 58247 RVA: 0x00219120 File Offset: 0x00217320
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgTalk_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x0600E388 RID: 58248 RVA: 0x00219170 File Offset: 0x00217370
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

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x0600E389 RID: 58249 RVA: 0x002191EE File Offset: 0x002173EE
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

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x0600E38A RID: 58250 RVA: 0x00219222 File Offset: 0x00217422
		public virtual EAvgRolePosition PositionConfig
		{
			get
			{
				return (EAvgRolePosition)this.Instance.PositionConfig;
			}
		}

		// Token: 0x04007C53 RID: 31827
		private ITalkItemAvgTalk Instance;

		// Token: 0x04007C54 RID: 31828
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007C55 RID: 31829
		private bool _CaptionParamsInited;

		// Token: 0x04007C56 RID: 31830
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007C57 RID: 31831
		private bool _ActionsInited;

		// Token: 0x04007C58 RID: 31832
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007C59 RID: 31833
		private bool _OptionsInited;

		// Token: 0x04007C5A RID: 31834
		private PlayMontage _MontageCache;

		// Token: 0x04007C5B RID: 31835
		private bool _MontageInited;

		// Token: 0x04007C5C RID: 31836
		private ICameraData _CameraDataCache;

		// Token: 0x04007C5D RID: 31837
		private bool _CameraDataInited;

		// Token: 0x04007C5E RID: 31838
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007C5F RID: 31839
		private bool _FlowTemplateInited;

		// Token: 0x04007C60 RID: 31840
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007C61 RID: 31841
		private bool _FlowTemplateListInited;

		// Token: 0x04007C62 RID: 31842
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007C63 RID: 31843
		private bool _ActorMontageArrayInited;

		// Token: 0x04007C64 RID: 31844
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007C65 RID: 31845
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007C66 RID: 31846
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007C67 RID: 31847
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007C68 RID: 31848
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007C69 RID: 31849
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007C6A RID: 31850
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007C6B RID: 31851
		private bool _TalkAkEventInited;

		// Token: 0x04007C6C RID: 31852
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007C6D RID: 31853
		private bool _TalkEndAkEventInited;

		// Token: 0x04007C6E RID: 31854
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007C6F RID: 31855
		private bool _UniversalToneInited;

		// Token: 0x04007C70 RID: 31856
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007C71 RID: 31857
		private bool _BackgroundConfigInited;

		// Token: 0x04007C72 RID: 31858
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007C73 RID: 31859
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007C74 RID: 31860
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007C75 RID: 31861
		private bool _GamepadShakeInited;

		// Token: 0x04007C76 RID: 31862
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007C77 RID: 31863
		private bool _IntroActionsInited;

		// Token: 0x04007C78 RID: 31864
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007C79 RID: 31865
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007C7A RID: 31866
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007C7B RID: 31867
		private bool _TalkEffectArrayInited;

		// Token: 0x04007C7C RID: 31868
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007C7D RID: 31869
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007C7E RID: 31870
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x04007C7F RID: 31871
		private bool _AvgRoleConfigInited;
	}
}
