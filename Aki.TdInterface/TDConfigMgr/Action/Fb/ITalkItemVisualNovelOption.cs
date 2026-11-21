using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002845 RID: 10309
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelOption : ITalkItem
	{
		// Token: 0x0600E5D3 RID: 58835 RVA: 0x002200F3 File Offset: 0x0021E2F3
		[NullableContext(0)]
		public static ITalkItemVisualNovelOption Create(ITalkItemVisualNovelOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x00220114 File Offset: 0x0021E314
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

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x0022014A File Offset: 0x0021E34A
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x00220158 File Offset: 0x0021E358
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

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x0022018E File Offset: 0x0021E38E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x0022019B File Offset: 0x0021E39B
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x0600E5D9 RID: 58841 RVA: 0x002201A8 File Offset: 0x0021E3A8
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

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x002201E0 File Offset: 0x0021E3E0
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

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x00220218 File Offset: 0x0021E418
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

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x00220250 File Offset: 0x0021E450
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

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x0600E5DD RID: 58845 RVA: 0x00220287 File Offset: 0x0021E487
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x0600E5DE RID: 58846 RVA: 0x00220294 File Offset: 0x0021E494
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

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x0600E5DF RID: 58847 RVA: 0x002202CB File Offset: 0x0021E4CB
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

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x0600E5E0 RID: 58848 RVA: 0x00220300 File Offset: 0x0021E500
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

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x0600E5E1 RID: 58849 RVA: 0x00220380 File Offset: 0x0021E580
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

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x002203FE File Offset: 0x0021E5FE
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

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x0600E5E3 RID: 58851 RVA: 0x00220432 File Offset: 0x0021E632
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

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x0600E5E4 RID: 58852 RVA: 0x00220466 File Offset: 0x0021E666
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

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x0022049C File Offset: 0x0021E69C
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

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x0022051C File Offset: 0x0021E71C
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

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x0600E5E7 RID: 58855 RVA: 0x0022059C File Offset: 0x0021E79C
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

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x0022061C File Offset: 0x0021E81C
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

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x0600E5E9 RID: 58857 RVA: 0x0022069C File Offset: 0x0021E89C
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

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x0600E5EA RID: 58858 RVA: 0x0022071A File Offset: 0x0021E91A
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelOption_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x0600E5EB RID: 58859 RVA: 0x00220749 File Offset: 0x0021E949
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelOption_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x0600E5EC RID: 58860 RVA: 0x00220778 File Offset: 0x0021E978
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

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x0600E5ED RID: 58861 RVA: 0x002207AC File Offset: 0x0021E9AC
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x0600E5EE RID: 58862 RVA: 0x002207DC File Offset: 0x0021E9DC
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

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x0600E5EF RID: 58863 RVA: 0x00220816 File Offset: 0x0021EA16
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

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x0600E5F0 RID: 58864 RVA: 0x0022084A File Offset: 0x0021EA4A
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

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x0600E5F1 RID: 58865 RVA: 0x00220880 File Offset: 0x0021EA80
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

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x0600E5F2 RID: 58866 RVA: 0x00220900 File Offset: 0x0021EB00
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

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x0600E5F3 RID: 58867 RVA: 0x00220980 File Offset: 0x0021EB80
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelOption_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x0600E5F4 RID: 58868 RVA: 0x002209D0 File Offset: 0x0021EBD0
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

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x0600E5F5 RID: 58869 RVA: 0x00220A50 File Offset: 0x0021EC50
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

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x0600E5F6 RID: 58870 RVA: 0x00220A8A File Offset: 0x0021EC8A
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
				this._OptionGroupCache = ActionReadHelper.ReadITalkItemVisualNovelOption_OptionGroup(this.Instance);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x0600E5F7 RID: 58871 RVA: 0x00220AB9 File Offset: 0x0021ECB9
		public virtual string TidCustomDescText
		{
			get
			{
				return this.Instance.TidCustomDescText;
			}
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x0600E5F8 RID: 58872 RVA: 0x00220AC6 File Offset: 0x0021ECC6
		[Nullable(0)]
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._VisualNovelBackgroundConfigInited)
				{
					return this._VisualNovelBackgroundConfigCache;
				}
				this._VisualNovelBackgroundConfigInited = true;
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x00220AF5 File Offset: 0x0021ECF5
		[Nullable(0)]
		public virtual IVisualNovelCgBase CgConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._CgConfigInited)
				{
					return this._CgConfigCache;
				}
				this._CgConfigInited = true;
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x00220B24 File Offset: 0x0021ED24
		[Nullable(0)]
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._DisplayItemConfigInited)
				{
					return this._DisplayItemConfigCache;
				}
				this._DisplayItemConfigInited = true;
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelOption_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x00220B54 File Offset: 0x0021ED54
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

		// Token: 0x04007E73 RID: 32371
		private ITalkItemVisualNovelOption Instance;

		// Token: 0x04007E74 RID: 32372
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007E75 RID: 32373
		private bool _CaptionParamsInited;

		// Token: 0x04007E76 RID: 32374
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007E77 RID: 32375
		private bool _ActionsInited;

		// Token: 0x04007E78 RID: 32376
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007E79 RID: 32377
		private bool _OptionsInited;

		// Token: 0x04007E7A RID: 32378
		private PlayMontage _MontageCache;

		// Token: 0x04007E7B RID: 32379
		private bool _MontageInited;

		// Token: 0x04007E7C RID: 32380
		private ICameraData _CameraDataCache;

		// Token: 0x04007E7D RID: 32381
		private bool _CameraDataInited;

		// Token: 0x04007E7E RID: 32382
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04007E7F RID: 32383
		private bool _FlowTemplateInited;

		// Token: 0x04007E80 RID: 32384
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007E81 RID: 32385
		private bool _FlowTemplateListInited;

		// Token: 0x04007E82 RID: 32386
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007E83 RID: 32387
		private bool _ActorMontageArrayInited;

		// Token: 0x04007E84 RID: 32388
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007E85 RID: 32389
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007E86 RID: 32390
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007E87 RID: 32391
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007E88 RID: 32392
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007E89 RID: 32393
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007E8A RID: 32394
		[Nullable(0)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007E8B RID: 32395
		private bool _TalkAkEventInited;

		// Token: 0x04007E8C RID: 32396
		[Nullable(0)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x04007E8D RID: 32397
		private bool _TalkEndAkEventInited;

		// Token: 0x04007E8E RID: 32398
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04007E8F RID: 32399
		private bool _UniversalToneInited;

		// Token: 0x04007E90 RID: 32400
		[Nullable(0)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007E91 RID: 32401
		private bool _BackgroundConfigInited;

		// Token: 0x04007E92 RID: 32402
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007E93 RID: 32403
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007E94 RID: 32404
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007E95 RID: 32405
		private bool _GamepadShakeInited;

		// Token: 0x04007E96 RID: 32406
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007E97 RID: 32407
		private bool _IntroActionsInited;

		// Token: 0x04007E98 RID: 32408
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007E99 RID: 32409
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007E9A RID: 32410
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007E9B RID: 32411
		private bool _TalkEffectArrayInited;

		// Token: 0x04007E9C RID: 32412
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04007E9D RID: 32413
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04007E9E RID: 32414
		[Nullable(0)]
		private IVisualNovelOptionGroupConfigBase _OptionGroupCache;

		// Token: 0x04007E9F RID: 32415
		private bool _OptionGroupInited;

		// Token: 0x04007EA0 RID: 32416
		[Nullable(0)]
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x04007EA1 RID: 32417
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x04007EA2 RID: 32418
		[Nullable(0)]
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x04007EA3 RID: 32419
		private bool _CgConfigInited;

		// Token: 0x04007EA4 RID: 32420
		[Nullable(0)]
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x04007EA5 RID: 32421
		private bool _DisplayItemConfigInited;
	}
}
