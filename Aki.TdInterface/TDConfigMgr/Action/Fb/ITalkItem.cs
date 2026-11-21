using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E5 RID: 10213
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItem
	{
		// Token: 0x0600E1D8 RID: 57816 RVA: 0x00212DC2 File Offset: 0x00210FC2
		[NullableContext(0)]
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

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x0600E1D9 RID: 57817 RVA: 0x00212DE4 File Offset: 0x00210FE4
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

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x0600E1DA RID: 57818 RVA: 0x00212E1A File Offset: 0x0021101A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0600E1DB RID: 57819 RVA: 0x00212E28 File Offset: 0x00211028
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

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x0600E1DC RID: 57820 RVA: 0x00212E5E File Offset: 0x0021105E
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0600E1DD RID: 57821 RVA: 0x00212E6B File Offset: 0x0021106B
		[Nullable(0)]
		public virtual string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0600E1DE RID: 57822 RVA: 0x00212E78 File Offset: 0x00211078
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

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0600E1DF RID: 57823 RVA: 0x00212EB0 File Offset: 0x002110B0
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

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x0600E1E0 RID: 57824 RVA: 0x00212EE8 File Offset: 0x002110E8
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

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0600E1E1 RID: 57825 RVA: 0x00212F20 File Offset: 0x00211120
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

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x00212F57 File Offset: 0x00211157
		public virtual string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x0600E1E3 RID: 57827 RVA: 0x00212F64 File Offset: 0x00211164
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

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x0600E1E4 RID: 57828 RVA: 0x00212F9B File Offset: 0x0021119B
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

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x0600E1E5 RID: 57829 RVA: 0x00212FD0 File Offset: 0x002111D0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
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

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x0600E1E6 RID: 57830 RVA: 0x00213050 File Offset: 0x00211250
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ITalkOption> Options
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

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0600E1E7 RID: 57831 RVA: 0x002130CE File Offset: 0x002112CE
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

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0600E1E8 RID: 57832 RVA: 0x00213102 File Offset: 0x00211302
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

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x0600E1E9 RID: 57833 RVA: 0x00213136 File Offset: 0x00211336
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

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x0021316C File Offset: 0x0021136C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<SetFlowTemplate> FlowTemplateList
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

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x0600E1EB RID: 57835 RVA: 0x002131EC File Offset: 0x002113EC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMontageData> ActorMontageArray
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

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x0600E1EC RID: 57836 RVA: 0x0021326C File Offset: 0x0021146C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IActorFaceExpression> ActorFaceExpressionArray
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

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x0600E1ED RID: 57837 RVA: 0x002132EC File Offset: 0x002114EC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IActorLookAt> ActorLookAtArray
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

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x0600E1EE RID: 57838 RVA: 0x0021336C File Offset: 0x0021156C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IActorTurnTo> ActorTurnToArray
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

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x0600E1EF RID: 57839 RVA: 0x002133EA File Offset: 0x002115EA
		[Nullable(0)]
		public virtual IPostAkEventType TalkAkEvent
		{
			[NullableContext(0)]
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

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0600E1F0 RID: 57840 RVA: 0x00213419 File Offset: 0x00211619
		[Nullable(0)]
		public virtual IPostAkEventType TalkEndAkEvent
		{
			[NullableContext(0)]
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

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0600E1F1 RID: 57841 RVA: 0x00213448 File Offset: 0x00211648
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

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0600E1F2 RID: 57842 RVA: 0x0021347C File Offset: 0x0021167C
		[Nullable(0)]
		public virtual ITalkBackground BackgroundConfig
		{
			[NullableContext(0)]
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

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x0600E1F3 RID: 57843 RVA: 0x002134AC File Offset: 0x002116AC
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

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x0600E1F4 RID: 57844 RVA: 0x002134E6 File Offset: 0x002116E6
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

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0600E1F5 RID: 57845 RVA: 0x0021351A File Offset: 0x0021171A
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

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0600E1F6 RID: 57846 RVA: 0x00213550 File Offset: 0x00211750
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> IntroActions
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

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0600E1F7 RID: 57847 RVA: 0x002135D0 File Offset: 0x002117D0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IActorFxEmote> ActorFxEmoteArray
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

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x0600E1F8 RID: 57848 RVA: 0x00213650 File Offset: 0x00211850
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ITalkEffectActionType> TalkEffectArray
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItem_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x002136A0 File Offset: 0x002118A0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IActorVisibility> ActorVisibilityArray
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

		// Token: 0x04007AB5 RID: 31413
		private ITalkItem Instance;

		// Token: 0x04007AB6 RID: 31414
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007AB7 RID: 31415
		private bool _CaptionParamsInited;

		// Token: 0x04007AB8 RID: 31416
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007AB9 RID: 31417
		private bool _ActionsInited;

		// Token: 0x04007ABA RID: 31418
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007ABB RID: 31419
		private bool _OptionsInited;

		// Token: 0x04007ABC RID: 31420
		private PlayMontage _MontageCache;

		// Token: 0x04007ABD RID: 31421
		private bool _MontageInited;

		// Token: 0x04007ABE RID: 31422
		private ICameraData _CameraDataCache;

		// Token: 0x04007ABF RID: 31423
		private bool _CameraDataInited;

		// Token: 0x04007AC0 RID: 31424
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007AC1 RID: 31425
		private bool _FlowTemplateInited;

		// Token: 0x04007AC2 RID: 31426
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007AC3 RID: 31427
		private bool _FlowTemplateListInited;

		// Token: 0x04007AC4 RID: 31428
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007AC5 RID: 31429
		private bool _ActorMontageArrayInited;

		// Token: 0x04007AC6 RID: 31430
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007AC7 RID: 31431
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007AC8 RID: 31432
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007AC9 RID: 31433
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007ACA RID: 31434
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007ACB RID: 31435
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007ACC RID: 31436
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007ACD RID: 31437
		private bool _TalkAkEventInited;

		// Token: 0x04007ACE RID: 31438
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007ACF RID: 31439
		private bool _TalkEndAkEventInited;

		// Token: 0x04007AD0 RID: 31440
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007AD1 RID: 31441
		private bool _UniversalToneInited;

		// Token: 0x04007AD2 RID: 31442
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007AD3 RID: 31443
		private bool _BackgroundConfigInited;

		// Token: 0x04007AD4 RID: 31444
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007AD5 RID: 31445
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007AD6 RID: 31446
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007AD7 RID: 31447
		private bool _GamepadShakeInited;

		// Token: 0x04007AD8 RID: 31448
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007AD9 RID: 31449
		private bool _IntroActionsInited;

		// Token: 0x04007ADA RID: 31450
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007ADB RID: 31451
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007ADC RID: 31452
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007ADD RID: 31453
		private bool _TalkEffectArrayInited;

		// Token: 0x04007ADE RID: 31454
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007ADF RID: 31455
		private bool _ActorVisibilityArrayInited;
	}
}
