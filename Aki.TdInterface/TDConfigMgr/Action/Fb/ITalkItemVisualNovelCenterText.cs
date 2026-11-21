using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002846 RID: 10310
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelCenterText : ITalkItem
	{
		// Token: 0x0600E5FD RID: 58877 RVA: 0x00220B96 File Offset: 0x0021ED96
		[NullableContext(0)]
		public static ITalkItemVisualNovelCenterText Create(ITalkItemVisualNovelCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x00220BB8 File Offset: 0x0021EDB8
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

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x00220BEE File Offset: 0x0021EDEE
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x0600E600 RID: 58880 RVA: 0x00220BFC File Offset: 0x0021EDFC
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

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x0600E601 RID: 58881 RVA: 0x00220C32 File Offset: 0x0021EE32
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x0600E602 RID: 58882 RVA: 0x00220C3F File Offset: 0x0021EE3F
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x0600E603 RID: 58883 RVA: 0x00220C4C File Offset: 0x0021EE4C
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

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x0600E604 RID: 58884 RVA: 0x00220C84 File Offset: 0x0021EE84
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

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x0600E605 RID: 58885 RVA: 0x00220CBC File Offset: 0x0021EEBC
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

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x0600E606 RID: 58886 RVA: 0x00220CF4 File Offset: 0x0021EEF4
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

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x0600E607 RID: 58887 RVA: 0x00220D2B File Offset: 0x0021EF2B
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x0600E608 RID: 58888 RVA: 0x00220D38 File Offset: 0x0021EF38
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

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x0600E609 RID: 58889 RVA: 0x00220D6F File Offset: 0x0021EF6F
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

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x0600E60A RID: 58890 RVA: 0x00220DA4 File Offset: 0x0021EFA4
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

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0600E60B RID: 58891 RVA: 0x00220E24 File Offset: 0x0021F024
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

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x0600E60C RID: 58892 RVA: 0x00220EA2 File Offset: 0x0021F0A2
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

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x0600E60D RID: 58893 RVA: 0x00220ED6 File Offset: 0x0021F0D6
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

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x0600E60E RID: 58894 RVA: 0x00220F0A File Offset: 0x0021F10A
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

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x0600E60F RID: 58895 RVA: 0x00220F40 File Offset: 0x0021F140
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

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x0600E610 RID: 58896 RVA: 0x00220FC0 File Offset: 0x0021F1C0
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

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x0600E611 RID: 58897 RVA: 0x00221040 File Offset: 0x0021F240
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

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x0600E612 RID: 58898 RVA: 0x002210C0 File Offset: 0x0021F2C0
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

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x0600E613 RID: 58899 RVA: 0x00221140 File Offset: 0x0021F340
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

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x0600E614 RID: 58900 RVA: 0x002211BE File Offset: 0x0021F3BE
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x0600E615 RID: 58901 RVA: 0x002211ED File Offset: 0x0021F3ED
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x0600E616 RID: 58902 RVA: 0x0022121C File Offset: 0x0021F41C
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

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x0600E617 RID: 58903 RVA: 0x00221250 File Offset: 0x0021F450
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x0600E618 RID: 58904 RVA: 0x00221280 File Offset: 0x0021F480
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

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x0600E619 RID: 58905 RVA: 0x002212BA File Offset: 0x0021F4BA
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

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x0600E61A RID: 58906 RVA: 0x002212EE File Offset: 0x0021F4EE
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

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0600E61B RID: 58907 RVA: 0x00221324 File Offset: 0x0021F524
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

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x0600E61C RID: 58908 RVA: 0x002213A4 File Offset: 0x0021F5A4
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

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x0600E61D RID: 58909 RVA: 0x00221424 File Offset: 0x0021F624
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x0600E61E RID: 58910 RVA: 0x00221474 File Offset: 0x0021F674
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

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x0600E61F RID: 58911 RVA: 0x002214F4 File Offset: 0x0021F6F4
		public virtual EVisualNovelOptionInteractionType? OptionInteractionType
		{
			get
			{
				if ((this.Instance.NullMask & 524288U) == 0U)
				{
					return null;
				}
				return new EVisualNovelOptionInteractionType?((EVisualNovelOptionInteractionType)this.Instance.OptionInteractionType);
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x0600E620 RID: 58912 RVA: 0x0022152E File Offset: 0x0021F72E
		[Nullable(0)]
		public virtual IVisualNovelOptionGroupConfigBase OptionGroup
		{
			[NullableContext(0)]
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = ActionReadHelper.ReadITalkItemVisualNovelCenterText_OptionGroup(this.Instance);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x0600E621 RID: 58913 RVA: 0x00221560 File Offset: 0x0021F760
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotKeyId);
			}
		}

		// Token: 0x04007EA6 RID: 32422
		private ITalkItemVisualNovelCenterText Instance;

		// Token: 0x04007EA7 RID: 32423
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007EA8 RID: 32424
		private bool _CaptionParamsInited;

		// Token: 0x04007EA9 RID: 32425
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007EAA RID: 32426
		private bool _ActionsInited;

		// Token: 0x04007EAB RID: 32427
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007EAC RID: 32428
		private bool _OptionsInited;

		// Token: 0x04007EAD RID: 32429
		private PlayMontage _MontageCache;

		// Token: 0x04007EAE RID: 32430
		private bool _MontageInited;

		// Token: 0x04007EAF RID: 32431
		private ICameraData _CameraDataCache;

		// Token: 0x04007EB0 RID: 32432
		private bool _CameraDataInited;

		// Token: 0x04007EB1 RID: 32433
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007EB2 RID: 32434
		private bool _FlowTemplateInited;

		// Token: 0x04007EB3 RID: 32435
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007EB4 RID: 32436
		private bool _FlowTemplateListInited;

		// Token: 0x04007EB5 RID: 32437
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007EB6 RID: 32438
		private bool _ActorMontageArrayInited;

		// Token: 0x04007EB7 RID: 32439
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007EB8 RID: 32440
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007EB9 RID: 32441
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007EBA RID: 32442
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007EBB RID: 32443
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007EBC RID: 32444
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007EBD RID: 32445
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007EBE RID: 32446
		private bool _TalkAkEventInited;

		// Token: 0x04007EBF RID: 32447
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007EC0 RID: 32448
		private bool _TalkEndAkEventInited;

		// Token: 0x04007EC1 RID: 32449
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007EC2 RID: 32450
		private bool _UniversalToneInited;

		// Token: 0x04007EC3 RID: 32451
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007EC4 RID: 32452
		private bool _BackgroundConfigInited;

		// Token: 0x04007EC5 RID: 32453
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007EC6 RID: 32454
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007EC7 RID: 32455
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007EC8 RID: 32456
		private bool _GamepadShakeInited;

		// Token: 0x04007EC9 RID: 32457
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007ECA RID: 32458
		private bool _IntroActionsInited;

		// Token: 0x04007ECB RID: 32459
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007ECC RID: 32460
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007ECD RID: 32461
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007ECE RID: 32462
		private bool _TalkEffectArrayInited;

		// Token: 0x04007ECF RID: 32463
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007ED0 RID: 32464
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007ED1 RID: 32465
		[Nullable(0)]
		private IVisualNovelOptionGroupConfigBase _OptionGroupCache;

		// Token: 0x04007ED2 RID: 32466
		private bool _OptionGroupInited;
	}
}
