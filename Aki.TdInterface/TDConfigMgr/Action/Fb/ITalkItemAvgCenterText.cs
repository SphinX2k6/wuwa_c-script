using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200255F RID: 9567
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgCenterText : ITalkItem
	{
		// Token: 0x0600D6B1 RID: 54961 RVA: 0x001FFC3E File Offset: 0x001FDE3E
		[NullableContext(1)]
		public static ITalkItemAvgCenterText Create(ITalkItemAvgCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x001FFC60 File Offset: 0x001FDE60
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

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600D6B3 RID: 54963 RVA: 0x001FFC96 File Offset: 0x001FDE96
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600D6B4 RID: 54964 RVA: 0x001FFCA4 File Offset: 0x001FDEA4
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

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x001FFCDA File Offset: 0x001FDEDA
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x001FFCE7 File Offset: 0x001FDEE7
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600D6B7 RID: 54967 RVA: 0x001FFCF4 File Offset: 0x001FDEF4
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

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x001FFD2C File Offset: 0x001FDF2C
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

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600D6B9 RID: 54969 RVA: 0x001FFD64 File Offset: 0x001FDF64
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

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600D6BA RID: 54970 RVA: 0x001FFD9C File Offset: 0x001FDF9C
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

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0600D6BB RID: 54971 RVA: 0x001FFDD3 File Offset: 0x001FDFD3
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x001FFDE0 File Offset: 0x001FDFE0
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

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600D6BD RID: 54973 RVA: 0x001FFE17 File Offset: 0x001FE017
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

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x001FFE4C File Offset: 0x001FE04C
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

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600D6BF RID: 54975 RVA: 0x001FFECC File Offset: 0x001FE0CC
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

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x001FFF4A File Offset: 0x001FE14A
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

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x001FFF7E File Offset: 0x001FE17E
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

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x001FFFB2 File Offset: 0x001FE1B2
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

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600D6C3 RID: 54979 RVA: 0x001FFFE8 File Offset: 0x001FE1E8
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

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600D6C4 RID: 54980 RVA: 0x00200068 File Offset: 0x001FE268
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

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600D6C5 RID: 54981 RVA: 0x002000E8 File Offset: 0x001FE2E8
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

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x00200168 File Offset: 0x001FE368
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

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600D6C7 RID: 54983 RVA: 0x002001E8 File Offset: 0x001FE3E8
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

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600D6C8 RID: 54984 RVA: 0x00200266 File Offset: 0x001FE466
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgCenterText_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600D6C9 RID: 54985 RVA: 0x00200295 File Offset: 0x001FE495
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgCenterText_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600D6CA RID: 54986 RVA: 0x002002C4 File Offset: 0x001FE4C4
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

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600D6CB RID: 54987 RVA: 0x002002F8 File Offset: 0x001FE4F8
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgCenterText_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600D6CC RID: 54988 RVA: 0x00200328 File Offset: 0x001FE528
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

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600D6CD RID: 54989 RVA: 0x00200362 File Offset: 0x001FE562
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

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600D6CE RID: 54990 RVA: 0x00200396 File Offset: 0x001FE596
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

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600D6CF RID: 54991 RVA: 0x002003CC File Offset: 0x001FE5CC
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

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600D6D0 RID: 54992 RVA: 0x0020044C File Offset: 0x001FE64C
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

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600D6D1 RID: 54993 RVA: 0x002004CC File Offset: 0x001FE6CC
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgCenterText_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600D6D2 RID: 54994 RVA: 0x0020051C File Offset: 0x001FE71C
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

		// Token: 0x040076D3 RID: 30419
		private ITalkItemAvgCenterText Instance;

		// Token: 0x040076D4 RID: 30420
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040076D5 RID: 30421
		private bool _CaptionParamsInited;

		// Token: 0x040076D6 RID: 30422
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040076D7 RID: 30423
		private bool _ActionsInited;

		// Token: 0x040076D8 RID: 30424
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040076D9 RID: 30425
		private bool _OptionsInited;

		// Token: 0x040076DA RID: 30426
		private PlayMontage _MontageCache;

		// Token: 0x040076DB RID: 30427
		private bool _MontageInited;

		// Token: 0x040076DC RID: 30428
		private ICameraData _CameraDataCache;

		// Token: 0x040076DD RID: 30429
		private bool _CameraDataInited;

		// Token: 0x040076DE RID: 30430
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040076DF RID: 30431
		private bool _FlowTemplateInited;

		// Token: 0x040076E0 RID: 30432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040076E1 RID: 30433
		private bool _FlowTemplateListInited;

		// Token: 0x040076E2 RID: 30434
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040076E3 RID: 30435
		private bool _ActorMontageArrayInited;

		// Token: 0x040076E4 RID: 30436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040076E5 RID: 30437
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040076E6 RID: 30438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040076E7 RID: 30439
		private bool _ActorLookAtArrayInited;

		// Token: 0x040076E8 RID: 30440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040076E9 RID: 30441
		private bool _ActorTurnToArrayInited;

		// Token: 0x040076EA RID: 30442
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x040076EB RID: 30443
		private bool _TalkAkEventInited;

		// Token: 0x040076EC RID: 30444
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x040076ED RID: 30445
		private bool _TalkEndAkEventInited;

		// Token: 0x040076EE RID: 30446
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040076EF RID: 30447
		private bool _UniversalToneInited;

		// Token: 0x040076F0 RID: 30448
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x040076F1 RID: 30449
		private bool _BackgroundConfigInited;

		// Token: 0x040076F2 RID: 30450
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040076F3 RID: 30451
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040076F4 RID: 30452
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040076F5 RID: 30453
		private bool _GamepadShakeInited;

		// Token: 0x040076F6 RID: 30454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040076F7 RID: 30455
		private bool _IntroActionsInited;

		// Token: 0x040076F8 RID: 30456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040076F9 RID: 30457
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040076FA RID: 30458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x040076FB RID: 30459
		private bool _TalkEffectArrayInited;

		// Token: 0x040076FC RID: 30460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040076FD RID: 30461
		private bool _ActorVisibilityArrayInited;
	}
}
