using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002807 RID: 10247
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgNarration : ITalkItem
	{
		// Token: 0x0600E3F8 RID: 58360 RVA: 0x0021AED6 File Offset: 0x002190D6
		[NullableContext(0)]
		public static ITalkItemAvgNarration Create(ITalkItemAvgNarration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgNarration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x0600E3F9 RID: 58361 RVA: 0x0021AEF8 File Offset: 0x002190F8
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

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x0600E3FA RID: 58362 RVA: 0x0021AF2E File Offset: 0x0021912E
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x0600E3FB RID: 58363 RVA: 0x0021AF3C File Offset: 0x0021913C
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

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x0600E3FC RID: 58364 RVA: 0x0021AF72 File Offset: 0x00219172
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x0600E3FD RID: 58365 RVA: 0x0021AF7F File Offset: 0x0021917F
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x0600E3FE RID: 58366 RVA: 0x0021AF8C File Offset: 0x0021918C
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

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x0021AFC4 File Offset: 0x002191C4
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

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x0600E400 RID: 58368 RVA: 0x0021AFFC File Offset: 0x002191FC
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

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x0600E401 RID: 58369 RVA: 0x0021B034 File Offset: 0x00219234
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

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x0600E402 RID: 58370 RVA: 0x0021B06B File Offset: 0x0021926B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x0600E403 RID: 58371 RVA: 0x0021B078 File Offset: 0x00219278
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

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x0600E404 RID: 58372 RVA: 0x0021B0AF File Offset: 0x002192AF
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

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x0600E405 RID: 58373 RVA: 0x0021B0E4 File Offset: 0x002192E4
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

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x0600E406 RID: 58374 RVA: 0x0021B164 File Offset: 0x00219364
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

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x0600E407 RID: 58375 RVA: 0x0021B1E2 File Offset: 0x002193E2
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

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x0600E408 RID: 58376 RVA: 0x0021B216 File Offset: 0x00219416
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

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x0600E409 RID: 58377 RVA: 0x0021B24A File Offset: 0x0021944A
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

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x0600E40A RID: 58378 RVA: 0x0021B280 File Offset: 0x00219480
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

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0600E40B RID: 58379 RVA: 0x0021B300 File Offset: 0x00219500
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

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x0600E40C RID: 58380 RVA: 0x0021B380 File Offset: 0x00219580
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

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x0600E40D RID: 58381 RVA: 0x0021B400 File Offset: 0x00219600
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

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x0600E40E RID: 58382 RVA: 0x0021B480 File Offset: 0x00219680
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

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x0600E40F RID: 58383 RVA: 0x0021B4FE File Offset: 0x002196FE
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgNarration_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x0600E410 RID: 58384 RVA: 0x0021B52D File Offset: 0x0021972D
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgNarration_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x0600E411 RID: 58385 RVA: 0x0021B55C File Offset: 0x0021975C
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

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x0600E412 RID: 58386 RVA: 0x0021B590 File Offset: 0x00219790
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgNarration_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x0600E413 RID: 58387 RVA: 0x0021B5C0 File Offset: 0x002197C0
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

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x0600E414 RID: 58388 RVA: 0x0021B5FA File Offset: 0x002197FA
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

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x0600E415 RID: 58389 RVA: 0x0021B62E File Offset: 0x0021982E
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

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x0600E416 RID: 58390 RVA: 0x0021B664 File Offset: 0x00219864
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

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x0600E417 RID: 58391 RVA: 0x0021B6E4 File Offset: 0x002198E4
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

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x0600E418 RID: 58392 RVA: 0x0021B764 File Offset: 0x00219964
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgNarration_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x0600E419 RID: 58393 RVA: 0x0021B7B4 File Offset: 0x002199B4
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

		// Token: 0x04007D05 RID: 32005
		private ITalkItemAvgNarration Instance;

		// Token: 0x04007D06 RID: 32006
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007D07 RID: 32007
		private bool _CaptionParamsInited;

		// Token: 0x04007D08 RID: 32008
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007D09 RID: 32009
		private bool _ActionsInited;

		// Token: 0x04007D0A RID: 32010
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007D0B RID: 32011
		private bool _OptionsInited;

		// Token: 0x04007D0C RID: 32012
		private PlayMontage _MontageCache;

		// Token: 0x04007D0D RID: 32013
		private bool _MontageInited;

		// Token: 0x04007D0E RID: 32014
		private ICameraData _CameraDataCache;

		// Token: 0x04007D0F RID: 32015
		private bool _CameraDataInited;

		// Token: 0x04007D10 RID: 32016
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007D11 RID: 32017
		private bool _FlowTemplateInited;

		// Token: 0x04007D12 RID: 32018
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007D13 RID: 32019
		private bool _FlowTemplateListInited;

		// Token: 0x04007D14 RID: 32020
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007D15 RID: 32021
		private bool _ActorMontageArrayInited;

		// Token: 0x04007D16 RID: 32022
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007D17 RID: 32023
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007D18 RID: 32024
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007D19 RID: 32025
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007D1A RID: 32026
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007D1B RID: 32027
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007D1C RID: 32028
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007D1D RID: 32029
		private bool _TalkAkEventInited;

		// Token: 0x04007D1E RID: 32030
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007D1F RID: 32031
		private bool _TalkEndAkEventInited;

		// Token: 0x04007D20 RID: 32032
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007D21 RID: 32033
		private bool _UniversalToneInited;

		// Token: 0x04007D22 RID: 32034
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007D23 RID: 32035
		private bool _BackgroundConfigInited;

		// Token: 0x04007D24 RID: 32036
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007D25 RID: 32037
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007D26 RID: 32038
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007D27 RID: 32039
		private bool _GamepadShakeInited;

		// Token: 0x04007D28 RID: 32040
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007D29 RID: 32041
		private bool _IntroActionsInited;

		// Token: 0x04007D2A RID: 32042
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007D2B RID: 32043
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007D2C RID: 32044
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007D2D RID: 32045
		private bool _TalkEffectArrayInited;

		// Token: 0x04007D2E RID: 32046
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007D2F RID: 32047
		private bool _ActorVisibilityArrayInited;
	}
}
