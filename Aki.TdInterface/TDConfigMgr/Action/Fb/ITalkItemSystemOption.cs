using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200254F RID: 9551
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemSystemOption : ITalkItem
	{
		// Token: 0x0600D52E RID: 54574 RVA: 0x001F9A02 File Offset: 0x001F7C02
		[NullableContext(1)]
		public static ITalkItemSystemOption Create(ITalkItemSystemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemSystemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600D52F RID: 54575 RVA: 0x001F9A24 File Offset: 0x001F7C24
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

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0600D530 RID: 54576 RVA: 0x001F9A5A File Offset: 0x001F7C5A
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600D531 RID: 54577 RVA: 0x001F9A68 File Offset: 0x001F7C68
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

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600D532 RID: 54578 RVA: 0x001F9A9E File Offset: 0x001F7C9E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600D533 RID: 54579 RVA: 0x001F9AAB File Offset: 0x001F7CAB
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x001F9AB8 File Offset: 0x001F7CB8
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

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600D535 RID: 54581 RVA: 0x001F9AF0 File Offset: 0x001F7CF0
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

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0600D536 RID: 54582 RVA: 0x001F9B28 File Offset: 0x001F7D28
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

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600D537 RID: 54583 RVA: 0x001F9B60 File Offset: 0x001F7D60
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

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600D538 RID: 54584 RVA: 0x001F9B97 File Offset: 0x001F7D97
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600D539 RID: 54585 RVA: 0x001F9BA4 File Offset: 0x001F7DA4
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

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600D53A RID: 54586 RVA: 0x001F9BDB File Offset: 0x001F7DDB
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

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0600D53B RID: 54587 RVA: 0x001F9C10 File Offset: 0x001F7E10
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

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600D53C RID: 54588 RVA: 0x001F9C90 File Offset: 0x001F7E90
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

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600D53D RID: 54589 RVA: 0x001F9D0E File Offset: 0x001F7F0E
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

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600D53E RID: 54590 RVA: 0x001F9D42 File Offset: 0x001F7F42
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

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600D53F RID: 54591 RVA: 0x001F9D76 File Offset: 0x001F7F76
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

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600D540 RID: 54592 RVA: 0x001F9DAC File Offset: 0x001F7FAC
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

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600D541 RID: 54593 RVA: 0x001F9E2C File Offset: 0x001F802C
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

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x001F9EAC File Offset: 0x001F80AC
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

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600D543 RID: 54595 RVA: 0x001F9F2C File Offset: 0x001F812C
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

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600D544 RID: 54596 RVA: 0x001F9FAC File Offset: 0x001F81AC
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

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600D545 RID: 54597 RVA: 0x001FA02A File Offset: 0x001F822A
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemSystemOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x001FA059 File Offset: 0x001F8259
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemSystemOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600D547 RID: 54599 RVA: 0x001FA088 File Offset: 0x001F8288
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

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600D548 RID: 54600 RVA: 0x001FA0BC File Offset: 0x001F82BC
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemSystemOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600D549 RID: 54601 RVA: 0x001FA0EC File Offset: 0x001F82EC
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

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600D54A RID: 54602 RVA: 0x001FA126 File Offset: 0x001F8326
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

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0600D54B RID: 54603 RVA: 0x001FA15A File Offset: 0x001F835A
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

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600D54C RID: 54604 RVA: 0x001FA190 File Offset: 0x001F8390
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

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600D54D RID: 54605 RVA: 0x001FA210 File Offset: 0x001F8410
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

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600D54E RID: 54606 RVA: 0x001FA290 File Offset: 0x001F8490
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemSystemOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0600D54F RID: 54607 RVA: 0x001FA2E0 File Offset: 0x001F84E0
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

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0600D550 RID: 54608 RVA: 0x001FA35E File Offset: 0x001F855E
		[Nullable(1)]
		public virtual ISystemOptionType OptionConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._OptionConfigInited)
				{
					return this._OptionConfigCache;
				}
				this._OptionConfigInited = true;
				this._OptionConfigCache = ActionReadHelper.ReadITalkItemSystemOption_OptionConfig(this.Instance);
				return this._OptionConfigCache;
			}
		}

		// Token: 0x0400750F RID: 29967
		private ITalkItemSystemOption Instance;

		// Token: 0x04007510 RID: 29968
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007511 RID: 29969
		private bool _CaptionParamsInited;

		// Token: 0x04007512 RID: 29970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007513 RID: 29971
		private bool _ActionsInited;

		// Token: 0x04007514 RID: 29972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007515 RID: 29973
		private bool _OptionsInited;

		// Token: 0x04007516 RID: 29974
		private PlayMontage _MontageCache;

		// Token: 0x04007517 RID: 29975
		private bool _MontageInited;

		// Token: 0x04007518 RID: 29976
		private ICameraData _CameraDataCache;

		// Token: 0x04007519 RID: 29977
		private bool _CameraDataInited;

		// Token: 0x0400751A RID: 29978
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400751B RID: 29979
		private bool _FlowTemplateInited;

		// Token: 0x0400751C RID: 29980
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400751D RID: 29981
		private bool _FlowTemplateListInited;

		// Token: 0x0400751E RID: 29982
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x0400751F RID: 29983
		private bool _ActorMontageArrayInited;

		// Token: 0x04007520 RID: 29984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007521 RID: 29985
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007522 RID: 29986
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007523 RID: 29987
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007524 RID: 29988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007525 RID: 29989
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007526 RID: 29990
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007527 RID: 29991
		private bool _TalkAkEventInited;

		// Token: 0x04007528 RID: 29992
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007529 RID: 29993
		private bool _TalkEndAkEventInited;

		// Token: 0x0400752A RID: 29994
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400752B RID: 29995
		private bool _UniversalToneInited;

		// Token: 0x0400752C RID: 29996
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400752D RID: 29997
		private bool _BackgroundConfigInited;

		// Token: 0x0400752E RID: 29998
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400752F RID: 29999
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007530 RID: 30000
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007531 RID: 30001
		private bool _GamepadShakeInited;

		// Token: 0x04007532 RID: 30002
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007533 RID: 30003
		private bool _IntroActionsInited;

		// Token: 0x04007534 RID: 30004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007535 RID: 30005
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007536 RID: 30006
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007537 RID: 30007
		private bool _TalkEffectArrayInited;

		// Token: 0x04007538 RID: 30008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007539 RID: 30009
		private bool _ActorVisibilityArrayInited;

		// Token: 0x0400753A RID: 30010
		[Nullable(1)]
		private ISystemOptionType _OptionConfigCache;

		// Token: 0x0400753B RID: 30011
		private bool _OptionConfigInited;
	}
}
