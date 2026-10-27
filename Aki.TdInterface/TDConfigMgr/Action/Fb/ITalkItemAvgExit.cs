using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200255C RID: 9564
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgExit : ITalkItem
	{
		// Token: 0x0600D647 RID: 54855 RVA: 0x001FDFDF File Offset: 0x001FC1DF
		[NullableContext(1)]
		public static ITalkItemAvgExit Create(ITalkItemAvgExit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgExit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600D648 RID: 54856 RVA: 0x001FE000 File Offset: 0x001FC200
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

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600D649 RID: 54857 RVA: 0x001FE036 File Offset: 0x001FC236
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600D64A RID: 54858 RVA: 0x001FE044 File Offset: 0x001FC244
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

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600D64B RID: 54859 RVA: 0x001FE07A File Offset: 0x001FC27A
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600D64C RID: 54860 RVA: 0x001FE087 File Offset: 0x001FC287
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600D64D RID: 54861 RVA: 0x001FE094 File Offset: 0x001FC294
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

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600D64E RID: 54862 RVA: 0x001FE0CC File Offset: 0x001FC2CC
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

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600D64F RID: 54863 RVA: 0x001FE104 File Offset: 0x001FC304
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

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600D650 RID: 54864 RVA: 0x001FE13C File Offset: 0x001FC33C
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

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600D651 RID: 54865 RVA: 0x001FE173 File Offset: 0x001FC373
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600D652 RID: 54866 RVA: 0x001FE180 File Offset: 0x001FC380
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

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600D653 RID: 54867 RVA: 0x001FE1B7 File Offset: 0x001FC3B7
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

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600D654 RID: 54868 RVA: 0x001FE1EC File Offset: 0x001FC3EC
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

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600D655 RID: 54869 RVA: 0x001FE26C File Offset: 0x001FC46C
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

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600D656 RID: 54870 RVA: 0x001FE2EA File Offset: 0x001FC4EA
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

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600D657 RID: 54871 RVA: 0x001FE31E File Offset: 0x001FC51E
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

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x0600D658 RID: 54872 RVA: 0x001FE352 File Offset: 0x001FC552
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

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x0600D659 RID: 54873 RVA: 0x001FE388 File Offset: 0x001FC588
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

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x0600D65A RID: 54874 RVA: 0x001FE408 File Offset: 0x001FC608
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

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x0600D65B RID: 54875 RVA: 0x001FE488 File Offset: 0x001FC688
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

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600D65C RID: 54876 RVA: 0x001FE508 File Offset: 0x001FC708
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

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0600D65D RID: 54877 RVA: 0x001FE588 File Offset: 0x001FC788
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

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600D65E RID: 54878 RVA: 0x001FE606 File Offset: 0x001FC806
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemAvgExit_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0600D65F RID: 54879 RVA: 0x001FE635 File Offset: 0x001FC835
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemAvgExit_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0600D660 RID: 54880 RVA: 0x001FE664 File Offset: 0x001FC864
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

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600D661 RID: 54881 RVA: 0x001FE698 File Offset: 0x001FC898
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemAvgExit_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x0600D662 RID: 54882 RVA: 0x001FE6C8 File Offset: 0x001FC8C8
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

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600D663 RID: 54883 RVA: 0x001FE702 File Offset: 0x001FC902
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

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0600D664 RID: 54884 RVA: 0x001FE736 File Offset: 0x001FC936
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

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x0600D665 RID: 54885 RVA: 0x001FE76C File Offset: 0x001FC96C
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

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600D666 RID: 54886 RVA: 0x001FE7EC File Offset: 0x001FC9EC
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

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600D667 RID: 54887 RVA: 0x001FE86C File Offset: 0x001FCA6C
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemAvgExit_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600D668 RID: 54888 RVA: 0x001FE8BC File Offset: 0x001FCABC
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

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600D669 RID: 54889 RVA: 0x001FE93A File Offset: 0x001FCB3A
		[Nullable(1)]
		public virtual ITalkItemAvgRoleConfig AvgRoleConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._AvgRoleConfigInited)
				{
					return this._AvgRoleConfigCache;
				}
				this._AvgRoleConfigInited = true;
				this._AvgRoleConfigCache = ITalkItemAvgRoleConfig.Create(this.Instance.AvgRoleConfig);
				return this._AvgRoleConfigCache;
			}
		}

		// Token: 0x04007650 RID: 30288
		private ITalkItemAvgExit Instance;

		// Token: 0x04007651 RID: 30289
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007652 RID: 30290
		private bool _CaptionParamsInited;

		// Token: 0x04007653 RID: 30291
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007654 RID: 30292
		private bool _ActionsInited;

		// Token: 0x04007655 RID: 30293
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007656 RID: 30294
		private bool _OptionsInited;

		// Token: 0x04007657 RID: 30295
		private PlayMontage _MontageCache;

		// Token: 0x04007658 RID: 30296
		private bool _MontageInited;

		// Token: 0x04007659 RID: 30297
		private ICameraData _CameraDataCache;

		// Token: 0x0400765A RID: 30298
		private bool _CameraDataInited;

		// Token: 0x0400765B RID: 30299
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400765C RID: 30300
		private bool _FlowTemplateInited;

		// Token: 0x0400765D RID: 30301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400765E RID: 30302
		private bool _FlowTemplateListInited;

		// Token: 0x0400765F RID: 30303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007660 RID: 30304
		private bool _ActorMontageArrayInited;

		// Token: 0x04007661 RID: 30305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007662 RID: 30306
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007663 RID: 30307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007664 RID: 30308
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007665 RID: 30309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007666 RID: 30310
		private bool _ActorTurnToArrayInited;

		// Token: 0x04007667 RID: 30311
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x04007668 RID: 30312
		private bool _TalkAkEventInited;

		// Token: 0x04007669 RID: 30313
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x0400766A RID: 30314
		private bool _TalkEndAkEventInited;

		// Token: 0x0400766B RID: 30315
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400766C RID: 30316
		private bool _UniversalToneInited;

		// Token: 0x0400766D RID: 30317
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x0400766E RID: 30318
		private bool _BackgroundConfigInited;

		// Token: 0x0400766F RID: 30319
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007670 RID: 30320
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007671 RID: 30321
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007672 RID: 30322
		private bool _GamepadShakeInited;

		// Token: 0x04007673 RID: 30323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007674 RID: 30324
		private bool _IntroActionsInited;

		// Token: 0x04007675 RID: 30325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007676 RID: 30326
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04007677 RID: 30327
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x04007678 RID: 30328
		private bool _TalkEffectArrayInited;

		// Token: 0x04007679 RID: 30329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x0400767A RID: 30330
		private bool _ActorVisibilityArrayInited;

		// Token: 0x0400767B RID: 30331
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x0400767C RID: 30332
		private bool _AvgRoleConfigInited;
	}
}
