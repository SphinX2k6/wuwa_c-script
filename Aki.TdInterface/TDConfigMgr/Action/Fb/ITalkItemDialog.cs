using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002548 RID: 9544
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDialog : ITalkItem
	{
		// Token: 0x0600D4C7 RID: 54471 RVA: 0x001F818E File Offset: 0x001F638E
		[NullableContext(1)]
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

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600D4C8 RID: 54472 RVA: 0x001F81B0 File Offset: 0x001F63B0
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

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600D4C9 RID: 54473 RVA: 0x001F81E6 File Offset: 0x001F63E6
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600D4CA RID: 54474 RVA: 0x001F81F4 File Offset: 0x001F63F4
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

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0600D4CB RID: 54475 RVA: 0x001F822A File Offset: 0x001F642A
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600D4CC RID: 54476 RVA: 0x001F8237 File Offset: 0x001F6437
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600D4CD RID: 54477 RVA: 0x001F8244 File Offset: 0x001F6444
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

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600D4CE RID: 54478 RVA: 0x001F827C File Offset: 0x001F647C
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

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600D4CF RID: 54479 RVA: 0x001F82B4 File Offset: 0x001F64B4
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

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x001F82EC File Offset: 0x001F64EC
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

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600D4D1 RID: 54481 RVA: 0x001F8323 File Offset: 0x001F6523
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600D4D2 RID: 54482 RVA: 0x001F8330 File Offset: 0x001F6530
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

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600D4D3 RID: 54483 RVA: 0x001F8367 File Offset: 0x001F6567
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

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0600D4D4 RID: 54484 RVA: 0x001F839C File Offset: 0x001F659C
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

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600D4D5 RID: 54485 RVA: 0x001F841C File Offset: 0x001F661C
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

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600D4D6 RID: 54486 RVA: 0x001F849A File Offset: 0x001F669A
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

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600D4D7 RID: 54487 RVA: 0x001F84CE File Offset: 0x001F66CE
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

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600D4D8 RID: 54488 RVA: 0x001F8502 File Offset: 0x001F6702
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

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0600D4D9 RID: 54489 RVA: 0x001F8538 File Offset: 0x001F6738
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

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0600D4DA RID: 54490 RVA: 0x001F85B8 File Offset: 0x001F67B8
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

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0600D4DB RID: 54491 RVA: 0x001F8638 File Offset: 0x001F6838
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

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600D4DC RID: 54492 RVA: 0x001F86B8 File Offset: 0x001F68B8
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

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0600D4DD RID: 54493 RVA: 0x001F8738 File Offset: 0x001F6938
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

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0600D4DE RID: 54494 RVA: 0x001F87B6 File Offset: 0x001F69B6
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemDialog_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600D4DF RID: 54495 RVA: 0x001F87E5 File Offset: 0x001F69E5
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemDialog_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600D4E0 RID: 54496 RVA: 0x001F8814 File Offset: 0x001F6A14
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

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600D4E1 RID: 54497 RVA: 0x001F8848 File Offset: 0x001F6A48
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemDialog_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600D4E2 RID: 54498 RVA: 0x001F8878 File Offset: 0x001F6A78
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

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600D4E3 RID: 54499 RVA: 0x001F88B2 File Offset: 0x001F6AB2
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

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600D4E4 RID: 54500 RVA: 0x001F88E6 File Offset: 0x001F6AE6
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

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600D4E5 RID: 54501 RVA: 0x001F891C File Offset: 0x001F6B1C
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

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0600D4E6 RID: 54502 RVA: 0x001F899C File Offset: 0x001F6B9C
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

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600D4E7 RID: 54503 RVA: 0x001F8A1C File Offset: 0x001F6C1C
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemDialog_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600D4E8 RID: 54504 RVA: 0x001F8A6C File Offset: 0x001F6C6C
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

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600D4E9 RID: 54505 RVA: 0x001F8AEA File Offset: 0x001F6CEA
		[Nullable(1)]
		public virtual ITalkItemStyle Style
		{
			[NullableContext(1)]
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

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x001F8B19 File Offset: 0x001F6D19
		[Nullable(1)]
		public virtual IShowTalkCameraMotion CameraMotion
		{
			[NullableContext(1)]
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

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x001F8B48 File Offset: 0x001F6D48
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

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600D4EC RID: 54508 RVA: 0x001F8B7C File Offset: 0x001F6D7C
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

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600D4ED RID: 54509 RVA: 0x001F8BB8 File Offset: 0x001F6DB8
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

		// Token: 0x040074A0 RID: 29856
		private ITalkItemDialog Instance;

		// Token: 0x040074A1 RID: 29857
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040074A2 RID: 29858
		private bool _CaptionParamsInited;

		// Token: 0x040074A3 RID: 29859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040074A4 RID: 29860
		private bool _ActionsInited;

		// Token: 0x040074A5 RID: 29861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040074A6 RID: 29862
		private bool _OptionsInited;

		// Token: 0x040074A7 RID: 29863
		private PlayMontage _MontageCache;

		// Token: 0x040074A8 RID: 29864
		private bool _MontageInited;

		// Token: 0x040074A9 RID: 29865
		private ICameraData _CameraDataCache;

		// Token: 0x040074AA RID: 29866
		private bool _CameraDataInited;

		// Token: 0x040074AB RID: 29867
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040074AC RID: 29868
		private bool _FlowTemplateInited;

		// Token: 0x040074AD RID: 29869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040074AE RID: 29870
		private bool _FlowTemplateListInited;

		// Token: 0x040074AF RID: 29871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040074B0 RID: 29872
		private bool _ActorMontageArrayInited;

		// Token: 0x040074B1 RID: 29873
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040074B2 RID: 29874
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040074B3 RID: 29875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040074B4 RID: 29876
		private bool _ActorLookAtArrayInited;

		// Token: 0x040074B5 RID: 29877
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040074B6 RID: 29878
		private bool _ActorTurnToArrayInited;

		// Token: 0x040074B7 RID: 29879
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040074B8 RID: 29880
		private bool _TalkAkEventInited;

		// Token: 0x040074B9 RID: 29881
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040074BA RID: 29882
		private bool _TalkEndAkEventInited;

		// Token: 0x040074BB RID: 29883
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040074BC RID: 29884
		private bool _UniversalToneInited;

		// Token: 0x040074BD RID: 29885
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040074BE RID: 29886
		private bool _BackgroundConfigInited;

		// Token: 0x040074BF RID: 29887
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040074C0 RID: 29888
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040074C1 RID: 29889
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040074C2 RID: 29890
		private bool _GamepadShakeInited;

		// Token: 0x040074C3 RID: 29891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040074C4 RID: 29892
		private bool _IntroActionsInited;

		// Token: 0x040074C5 RID: 29893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040074C6 RID: 29894
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040074C7 RID: 29895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040074C8 RID: 29896
		private bool _TalkEffectArrayInited;

		// Token: 0x040074C9 RID: 29897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040074CA RID: 29898
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040074CB RID: 29899
		[Nullable(1)]
		private ITalkItemStyle _StyleCache;

		// Token: 0x040074CC RID: 29900
		private bool _StyleInited;

		// Token: 0x040074CD RID: 29901
		[Nullable(1)]
		private IShowTalkCameraMotion _CameraMotionCache;

		// Token: 0x040074CE RID: 29902
		private bool _CameraMotionInited;

		// Token: 0x040074CF RID: 29903
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x040074D0 RID: 29904
		private bool _AutoPlayConfigInited;
	}
}
