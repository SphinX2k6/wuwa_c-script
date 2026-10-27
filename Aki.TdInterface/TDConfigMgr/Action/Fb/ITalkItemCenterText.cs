using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002550 RID: 9552
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemCenterText : ITalkItem
	{
		// Token: 0x0600D552 RID: 54610 RVA: 0x001FA395 File Offset: 0x001F8595
		[NullableContext(1)]
		public static ITalkItemCenterText Create(ITalkItemCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0600D553 RID: 54611 RVA: 0x001FA3B4 File Offset: 0x001F85B4
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

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0600D554 RID: 54612 RVA: 0x001FA3EA File Offset: 0x001F85EA
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600D555 RID: 54613 RVA: 0x001FA3F8 File Offset: 0x001F85F8
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

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600D556 RID: 54614 RVA: 0x001FA42E File Offset: 0x001F862E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600D557 RID: 54615 RVA: 0x001FA43B File Offset: 0x001F863B
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600D558 RID: 54616 RVA: 0x001FA448 File Offset: 0x001F8648
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

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600D559 RID: 54617 RVA: 0x001FA480 File Offset: 0x001F8680
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

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0600D55A RID: 54618 RVA: 0x001FA4B8 File Offset: 0x001F86B8
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

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0600D55B RID: 54619 RVA: 0x001FA4F0 File Offset: 0x001F86F0
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

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x001FA527 File Offset: 0x001F8727
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0600D55D RID: 54621 RVA: 0x001FA534 File Offset: 0x001F8734
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

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600D55E RID: 54622 RVA: 0x001FA56B File Offset: 0x001F876B
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

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600D55F RID: 54623 RVA: 0x001FA5A0 File Offset: 0x001F87A0
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

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600D560 RID: 54624 RVA: 0x001FA620 File Offset: 0x001F8820
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

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600D561 RID: 54625 RVA: 0x001FA69E File Offset: 0x001F889E
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

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600D562 RID: 54626 RVA: 0x001FA6D2 File Offset: 0x001F88D2
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

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600D563 RID: 54627 RVA: 0x001FA706 File Offset: 0x001F8906
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

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0600D564 RID: 54628 RVA: 0x001FA73C File Offset: 0x001F893C
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

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0600D565 RID: 54629 RVA: 0x001FA7BC File Offset: 0x001F89BC
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

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0600D566 RID: 54630 RVA: 0x001FA83C File Offset: 0x001F8A3C
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

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0600D567 RID: 54631 RVA: 0x001FA8BC File Offset: 0x001F8ABC
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

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x0600D568 RID: 54632 RVA: 0x001FA93C File Offset: 0x001F8B3C
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

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600D569 RID: 54633 RVA: 0x001FA9BA File Offset: 0x001F8BBA
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemCenterText_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600D56A RID: 54634 RVA: 0x001FA9E9 File Offset: 0x001F8BE9
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemCenterText_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600D56B RID: 54635 RVA: 0x001FAA18 File Offset: 0x001F8C18
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

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600D56C RID: 54636 RVA: 0x001FAA4C File Offset: 0x001F8C4C
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemCenterText_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0600D56D RID: 54637 RVA: 0x001FAA7C File Offset: 0x001F8C7C
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

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x0600D56E RID: 54638 RVA: 0x001FAAB6 File Offset: 0x001F8CB6
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

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0600D56F RID: 54639 RVA: 0x001FAAEA File Offset: 0x001F8CEA
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

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600D570 RID: 54640 RVA: 0x001FAB20 File Offset: 0x001F8D20
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

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600D571 RID: 54641 RVA: 0x001FABA0 File Offset: 0x001F8DA0
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

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600D572 RID: 54642 RVA: 0x001FAC20 File Offset: 0x001F8E20
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemCenterText_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600D573 RID: 54643 RVA: 0x001FAC70 File Offset: 0x001F8E70
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

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600D574 RID: 54644 RVA: 0x001FACEE File Offset: 0x001F8EEE
		public virtual IShowCenterTextParams CenterTextConfig
		{
			get
			{
				if (this._CenterTextConfigInited)
				{
					return this._CenterTextConfigCache;
				}
				this._CenterTextConfigInited = true;
				this._CenterTextConfigCache = IShowCenterTextParams.Create(this.Instance.CenterTextConfig);
				return this._CenterTextConfigCache;
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600D575 RID: 54645 RVA: 0x001FAD24 File Offset: 0x001F8F24
		public virtual bool? _IsPlotActionForPreview
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance._IsPlotActionForPreview);
			}
		}

		// Token: 0x0400753C RID: 30012
		private ITalkItemCenterText Instance;

		// Token: 0x0400753D RID: 30013
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x0400753E RID: 30014
		private bool _CaptionParamsInited;

		// Token: 0x0400753F RID: 30015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007540 RID: 30016
		private bool _ActionsInited;

		// Token: 0x04007541 RID: 30017
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007542 RID: 30018
		private bool _OptionsInited;

		// Token: 0x04007543 RID: 30019
		private PlayMontage _MontageCache;

		// Token: 0x04007544 RID: 30020
		private bool _MontageInited;

		// Token: 0x04007545 RID: 30021
		private ICameraData _CameraDataCache;

		// Token: 0x04007546 RID: 30022
		private bool _CameraDataInited;

		// Token: 0x04007547 RID: 30023
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007548 RID: 30024
		private bool _FlowTemplateInited;

		// Token: 0x04007549 RID: 30025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400754A RID: 30026
		private bool _FlowTemplateListInited;

		// Token: 0x0400754B RID: 30027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x0400754C RID: 30028
		private bool _ActorMontageArrayInited;

		// Token: 0x0400754D RID: 30029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x0400754E RID: 30030
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x0400754F RID: 30031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007550 RID: 30032
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007551 RID: 30033
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007552 RID: 30034
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007553 RID: 30035
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007554 RID: 30036
		private bool _TalkAkEventInited;

		// Token: 0x04007555 RID: 30037
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007556 RID: 30038
		private bool _TalkEndAkEventInited;

		// Token: 0x04007557 RID: 30039
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007558 RID: 30040
		private bool _UniversalToneInited;

		// Token: 0x04007559 RID: 30041
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400755A RID: 30042
		private bool _BackgroundConfigInited;

		// Token: 0x0400755B RID: 30043
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400755C RID: 30044
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400755D RID: 30045
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400755E RID: 30046
		private bool _GamepadShakeInited;

		// Token: 0x0400755F RID: 30047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007560 RID: 30048
		private bool _IntroActionsInited;

		// Token: 0x04007561 RID: 30049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007562 RID: 30050
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007563 RID: 30051
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007564 RID: 30052
		private bool _TalkEffectArrayInited;

		// Token: 0x04007565 RID: 30053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007566 RID: 30054
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007567 RID: 30055
		private IShowCenterTextParams _CenterTextConfigCache;

		// Token: 0x04007568 RID: 30056
		private bool _CenterTextConfigInited;
	}
}
