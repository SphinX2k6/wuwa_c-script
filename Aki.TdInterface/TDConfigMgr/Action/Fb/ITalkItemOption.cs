using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002549 RID: 9545
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemOption : ITalkItem
	{
		// Token: 0x0600D4EF RID: 54511 RVA: 0x001F8BFA File Offset: 0x001F6DFA
		[NullableContext(1)]
		public static ITalkItemOption Create(ITalkItemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600D4F0 RID: 54512 RVA: 0x001F8C1C File Offset: 0x001F6E1C
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

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600D4F1 RID: 54513 RVA: 0x001F8C52 File Offset: 0x001F6E52
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600D4F2 RID: 54514 RVA: 0x001F8C60 File Offset: 0x001F6E60
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

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600D4F3 RID: 54515 RVA: 0x001F8C96 File Offset: 0x001F6E96
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0600D4F4 RID: 54516 RVA: 0x001F8CA3 File Offset: 0x001F6EA3
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600D4F5 RID: 54517 RVA: 0x001F8CB0 File Offset: 0x001F6EB0
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

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x001F8CE8 File Offset: 0x001F6EE8
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

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600D4F7 RID: 54519 RVA: 0x001F8D20 File Offset: 0x001F6F20
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

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600D4F8 RID: 54520 RVA: 0x001F8D58 File Offset: 0x001F6F58
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

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600D4F9 RID: 54521 RVA: 0x001F8D8F File Offset: 0x001F6F8F
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x001F8D9C File Offset: 0x001F6F9C
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

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x001F8DD3 File Offset: 0x001F6FD3
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

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600D4FC RID: 54524 RVA: 0x001F8E08 File Offset: 0x001F7008
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

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600D4FD RID: 54525 RVA: 0x001F8E88 File Offset: 0x001F7088
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

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600D4FE RID: 54526 RVA: 0x001F8F06 File Offset: 0x001F7106
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

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600D4FF RID: 54527 RVA: 0x001F8F3A File Offset: 0x001F713A
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

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600D500 RID: 54528 RVA: 0x001F8F6E File Offset: 0x001F716E
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

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600D501 RID: 54529 RVA: 0x001F8FA4 File Offset: 0x001F71A4
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

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600D502 RID: 54530 RVA: 0x001F9024 File Offset: 0x001F7224
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

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0600D503 RID: 54531 RVA: 0x001F90A4 File Offset: 0x001F72A4
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

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0600D504 RID: 54532 RVA: 0x001F9124 File Offset: 0x001F7324
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

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0600D505 RID: 54533 RVA: 0x001F91A4 File Offset: 0x001F73A4
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

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0600D506 RID: 54534 RVA: 0x001F9222 File Offset: 0x001F7422
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0600D507 RID: 54535 RVA: 0x001F9251 File Offset: 0x001F7451
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600D508 RID: 54536 RVA: 0x001F9280 File Offset: 0x001F7480
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

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600D509 RID: 54537 RVA: 0x001F92B4 File Offset: 0x001F74B4
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600D50A RID: 54538 RVA: 0x001F92E4 File Offset: 0x001F74E4
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

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600D50B RID: 54539 RVA: 0x001F931E File Offset: 0x001F751E
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

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0600D50C RID: 54540 RVA: 0x001F9352 File Offset: 0x001F7552
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

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600D50D RID: 54541 RVA: 0x001F9388 File Offset: 0x001F7588
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

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x001F9408 File Offset: 0x001F7608
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

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600D50F RID: 54543 RVA: 0x001F9488 File Offset: 0x001F7688
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600D510 RID: 54544 RVA: 0x001F94D8 File Offset: 0x001F76D8
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

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0600D511 RID: 54545 RVA: 0x001F9556 File Offset: 0x001F7756
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
				this._CameraMotionCache = ActionReadHelper.ReadITalkItemOption_CameraMotion(this.Instance);
				return this._CameraMotionCache;
			}
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600D512 RID: 54546 RVA: 0x001F9585 File Offset: 0x001F7785
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

		// Token: 0x040074D1 RID: 29905
		private ITalkItemOption Instance;

		// Token: 0x040074D2 RID: 29906
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040074D3 RID: 29907
		private bool _CaptionParamsInited;

		// Token: 0x040074D4 RID: 29908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040074D5 RID: 29909
		private bool _ActionsInited;

		// Token: 0x040074D6 RID: 29910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040074D7 RID: 29911
		private bool _OptionsInited;

		// Token: 0x040074D8 RID: 29912
		private PlayMontage _MontageCache;

		// Token: 0x040074D9 RID: 29913
		private bool _MontageInited;

		// Token: 0x040074DA RID: 29914
		private ICameraData _CameraDataCache;

		// Token: 0x040074DB RID: 29915
		private bool _CameraDataInited;

		// Token: 0x040074DC RID: 29916
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040074DD RID: 29917
		private bool _FlowTemplateInited;

		// Token: 0x040074DE RID: 29918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040074DF RID: 29919
		private bool _FlowTemplateListInited;

		// Token: 0x040074E0 RID: 29920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040074E1 RID: 29921
		private bool _ActorMontageArrayInited;

		// Token: 0x040074E2 RID: 29922
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040074E3 RID: 29923
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040074E4 RID: 29924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040074E5 RID: 29925
		private bool _ActorLookAtArrayInited;

		// Token: 0x040074E6 RID: 29926
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040074E7 RID: 29927
		private bool _ActorTurnToArrayInited;

		// Token: 0x040074E8 RID: 29928
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040074E9 RID: 29929
		private bool _TalkAkEventInited;

		// Token: 0x040074EA RID: 29930
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040074EB RID: 29931
		private bool _TalkEndAkEventInited;

		// Token: 0x040074EC RID: 29932
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040074ED RID: 29933
		private bool _UniversalToneInited;

		// Token: 0x040074EE RID: 29934
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040074EF RID: 29935
		private bool _BackgroundConfigInited;

		// Token: 0x040074F0 RID: 29936
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040074F1 RID: 29937
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040074F2 RID: 29938
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040074F3 RID: 29939
		private bool _GamepadShakeInited;

		// Token: 0x040074F4 RID: 29940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040074F5 RID: 29941
		private bool _IntroActionsInited;

		// Token: 0x040074F6 RID: 29942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040074F7 RID: 29943
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040074F8 RID: 29944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040074F9 RID: 29945
		private bool _TalkEffectArrayInited;

		// Token: 0x040074FA RID: 29946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040074FB RID: 29947
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040074FC RID: 29948
		[Nullable(1)]
		private IShowTalkCameraMotion _CameraMotionCache;

		// Token: 0x040074FD RID: 29949
		private bool _CameraMotionInited;

		// Token: 0x040074FE RID: 29950
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x040074FF RID: 29951
		private bool _AutoPlayConfigInited;
	}
}
