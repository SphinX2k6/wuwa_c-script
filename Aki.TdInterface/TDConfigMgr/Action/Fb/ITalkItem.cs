using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200253E RID: 9534
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItem
	{
		// Token: 0x0600D478 RID: 54392 RVA: 0x001F7362 File Offset: 0x001F5562
		[NullableContext(1)]
		public static ITalkItem Create(ITalkItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600D479 RID: 54393 RVA: 0x001F7384 File Offset: 0x001F5584
		public virtual ETalkItemType? Type
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

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600D47A RID: 54394 RVA: 0x001F73BA File Offset: 0x001F55BA
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600D47B RID: 54395 RVA: 0x001F73C8 File Offset: 0x001F55C8
		public virtual int? PlotLineId
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

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600D47C RID: 54396 RVA: 0x001F73FE File Offset: 0x001F55FE
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600D47D RID: 54397 RVA: 0x001F740B File Offset: 0x001F560B
		[Nullable(1)]
		public virtual string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0600D47E RID: 54398 RVA: 0x001F7418 File Offset: 0x001F5618
		public virtual bool? _Folded
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

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0600D47F RID: 54399 RVA: 0x001F7450 File Offset: 0x001F5650
		public virtual EEditFlag? _EditFlag
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

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0600D480 RID: 54400 RVA: 0x001F7488 File Offset: 0x001F5688
		public virtual int? WhoId
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

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600D481 RID: 54401 RVA: 0x001F74C0 File Offset: 0x001F56C0
		public virtual int? TextId
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

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0600D482 RID: 54402 RVA: 0x001F74F7 File Offset: 0x001F56F7
		public virtual string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0600D483 RID: 54403 RVA: 0x001F7504 File Offset: 0x001F5704
		public virtual float? WaitTime
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

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0600D484 RID: 54404 RVA: 0x001F753B File Offset: 0x001F573B
		public virtual ICaptionParam CaptionParams
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

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600D485 RID: 54405 RVA: 0x001F7570 File Offset: 0x001F5770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
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

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600D486 RID: 54406 RVA: 0x001F75F0 File Offset: 0x001F57F0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITalkOption> Options
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

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600D487 RID: 54407 RVA: 0x001F766E File Offset: 0x001F586E
		public virtual PlayMontage Montage
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

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600D488 RID: 54408 RVA: 0x001F76A2 File Offset: 0x001F58A2
		public virtual ICameraData CameraData
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

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600D489 RID: 54409 RVA: 0x001F76D6 File Offset: 0x001F58D6
		public virtual SetFlowTemplate FlowTemplate
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

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600D48A RID: 54410 RVA: 0x001F770C File Offset: 0x001F590C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<SetFlowTemplate> FlowTemplateList
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

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600D48B RID: 54411 RVA: 0x001F778C File Offset: 0x001F598C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMontageData> ActorMontageArray
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

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600D48C RID: 54412 RVA: 0x001F780C File Offset: 0x001F5A0C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorFaceExpression> ActorFaceExpressionArray
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

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600D48D RID: 54413 RVA: 0x001F788C File Offset: 0x001F5A8C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorLookAt> ActorLookAtArray
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

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600D48E RID: 54414 RVA: 0x001F790C File Offset: 0x001F5B0C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorTurnTo> ActorTurnToArray
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

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600D48F RID: 54415 RVA: 0x001F798A File Offset: 0x001F5B8A
		[Nullable(1)]
		public virtual IPostAkEventType TalkAkEvent
		{
			[NullableContext(1)]
			get
			{
				if (this._TalkAkEventInited)
				{
					return this._TalkAkEventCache;
				}
				this._TalkAkEventInited = true;
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItem_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x001F79B9 File Offset: 0x001F5BB9
		[Nullable(1)]
		public virtual IPostAkEventType TalkEndAkEvent
		{
			[NullableContext(1)]
			get
			{
				if (this._TalkEndAkEventInited)
				{
					return this._TalkEndAkEventCache;
				}
				this._TalkEndAkEventInited = true;
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItem_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600D491 RID: 54417 RVA: 0x001F79E8 File Offset: 0x001F5BE8
		public virtual IUniversalTone UniversalTone
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

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600D492 RID: 54418 RVA: 0x001F7A1C File Offset: 0x001F5C1C
		[Nullable(1)]
		public virtual ITalkBackground BackgroundConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._BackgroundConfigInited)
				{
					return this._BackgroundConfigCache;
				}
				this._BackgroundConfigInited = true;
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItem_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600D493 RID: 54419 RVA: 0x001F7A4C File Offset: 0x001F5C4C
		public virtual bool? PlayVoice
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

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600D494 RID: 54420 RVA: 0x001F7A86 File Offset: 0x001F5C86
		public virtual ITimeLimitOptionGroup TimeLimitOptionGroup
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

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600D495 RID: 54421 RVA: 0x001F7ABA File Offset: 0x001F5CBA
		public virtual IGamepadShakeInTalk GamepadShake
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

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600D496 RID: 54422 RVA: 0x001F7AF0 File Offset: 0x001F5CF0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> IntroActions
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

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600D497 RID: 54423 RVA: 0x001F7B70 File Offset: 0x001F5D70
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorFxEmote> ActorFxEmoteArray
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

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600D498 RID: 54424 RVA: 0x001F7BF0 File Offset: 0x001F5DF0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITalkEffectActionType> TalkEffectArray
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItem_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0600D499 RID: 54425 RVA: 0x001F7C40 File Offset: 0x001F5E40
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorVisibility> ActorVisibilityArray
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

		// Token: 0x04007460 RID: 29792
		private ITalkItem Instance;

		// Token: 0x04007461 RID: 29793
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007462 RID: 29794
		private bool _CaptionParamsInited;

		// Token: 0x04007463 RID: 29795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007464 RID: 29796
		private bool _ActionsInited;

		// Token: 0x04007465 RID: 29797
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007466 RID: 29798
		private bool _OptionsInited;

		// Token: 0x04007467 RID: 29799
		private PlayMontage _MontageCache;

		// Token: 0x04007468 RID: 29800
		private bool _MontageInited;

		// Token: 0x04007469 RID: 29801
		private ICameraData _CameraDataCache;

		// Token: 0x0400746A RID: 29802
		private bool _CameraDataInited;

		// Token: 0x0400746B RID: 29803
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400746C RID: 29804
		private bool _FlowTemplateInited;

		// Token: 0x0400746D RID: 29805
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400746E RID: 29806
		private bool _FlowTemplateListInited;

		// Token: 0x0400746F RID: 29807
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007470 RID: 29808
		private bool _ActorMontageArrayInited;

		// Token: 0x04007471 RID: 29809
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007472 RID: 29810
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007473 RID: 29811
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007474 RID: 29812
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007475 RID: 29813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007476 RID: 29814
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007477 RID: 29815
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007478 RID: 29816
		private bool _TalkAkEventInited;

		// Token: 0x04007479 RID: 29817
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x0400747A RID: 29818
		private bool _TalkEndAkEventInited;

		// Token: 0x0400747B RID: 29819
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400747C RID: 29820
		private bool _UniversalToneInited;

		// Token: 0x0400747D RID: 29821
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400747E RID: 29822
		private bool _BackgroundConfigInited;

		// Token: 0x0400747F RID: 29823
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007480 RID: 29824
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007481 RID: 29825
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007482 RID: 29826
		private bool _GamepadShakeInited;

		// Token: 0x04007483 RID: 29827
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007484 RID: 29828
		private bool _IntroActionsInited;

		// Token: 0x04007485 RID: 29829
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007486 RID: 29830
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007487 RID: 29831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007488 RID: 29832
		private bool _TalkEffectArrayInited;

		// Token: 0x04007489 RID: 29833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x0400748A RID: 29834
		private bool _ActorVisibilityArrayInited;
	}
}
