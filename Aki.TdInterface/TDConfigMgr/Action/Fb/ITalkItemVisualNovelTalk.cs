using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002593 RID: 9619
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelTalk : ITalkItem
	{
		// Token: 0x0600D7D0 RID: 55248 RVA: 0x002020C3 File Offset: 0x002002C3
		[NullableContext(1)]
		public static ITalkItemVisualNovelTalk Create(ITalkItemVisualNovelTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x002020E4 File Offset: 0x002002E4
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

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600D7D2 RID: 55250 RVA: 0x0020211A File Offset: 0x0020031A
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x00202128 File Offset: 0x00200328
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

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600D7D4 RID: 55252 RVA: 0x0020215E File Offset: 0x0020035E
		public override string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600D7D5 RID: 55253 RVA: 0x0020216B File Offset: 0x0020036B
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600D7D6 RID: 55254 RVA: 0x00202178 File Offset: 0x00200378
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

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600D7D7 RID: 55255 RVA: 0x002021B0 File Offset: 0x002003B0
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

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600D7D8 RID: 55256 RVA: 0x002021E8 File Offset: 0x002003E8
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

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600D7D9 RID: 55257 RVA: 0x00202220 File Offset: 0x00200420
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

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x00202257 File Offset: 0x00200457
		public override string TidTalk
		{
			get
			{
				return this.Instance.TidTalk;
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600D7DB RID: 55259 RVA: 0x00202264 File Offset: 0x00200464
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

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x0020229B File Offset: 0x0020049B
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

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0600D7DD RID: 55261 RVA: 0x002022D0 File Offset: 0x002004D0
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

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x00202350 File Offset: 0x00200550
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

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0600D7DF RID: 55263 RVA: 0x002023CE File Offset: 0x002005CE
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

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x00202402 File Offset: 0x00200602
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

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0600D7E1 RID: 55265 RVA: 0x00202436 File Offset: 0x00200636
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

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x0020246C File Offset: 0x0020066C
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

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0600D7E3 RID: 55267 RVA: 0x002024EC File Offset: 0x002006EC
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

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x0020256C File Offset: 0x0020076C
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

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0600D7E5 RID: 55269 RVA: 0x002025EC File Offset: 0x002007EC
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

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0600D7E6 RID: 55270 RVA: 0x0020266C File Offset: 0x0020086C
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

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0600D7E7 RID: 55271 RVA: 0x002026EA File Offset: 0x002008EA
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
				this._TalkAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_TalkAkEvent(this.Instance);
				return this._TalkAkEventCache;
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x00202719 File Offset: 0x00200919
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
				this._TalkEndAkEventCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_TalkEndAkEvent(this.Instance);
				return this._TalkEndAkEventCache;
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0600D7E9 RID: 55273 RVA: 0x00202748 File Offset: 0x00200948
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

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x0600D7EA RID: 55274 RVA: 0x0020277C File Offset: 0x0020097C
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
				this._BackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_BackgroundConfig(this.Instance);
				return this._BackgroundConfigCache;
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0600D7EB RID: 55275 RVA: 0x002027AC File Offset: 0x002009AC
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

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0600D7EC RID: 55276 RVA: 0x002027E6 File Offset: 0x002009E6
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

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0600D7ED RID: 55277 RVA: 0x0020281A File Offset: 0x00200A1A
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

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x00202850 File Offset: 0x00200A50
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

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0600D7EF RID: 55279 RVA: 0x002028D0 File Offset: 0x00200AD0
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

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0600D7F0 RID: 55280 RVA: 0x00202950 File Offset: 0x00200B50
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
				this._TalkEffectArrayCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_TalkEffectArray(this.Instance);
				return this._TalkEffectArrayCache;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x0600D7F1 RID: 55281 RVA: 0x002029A0 File Offset: 0x00200BA0
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

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x0600D7F2 RID: 55282 RVA: 0x00202A20 File Offset: 0x00200C20
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

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0600D7F3 RID: 55283 RVA: 0x00202A5A File Offset: 0x00200C5A
		public virtual IVisualNovelOptionGroupSolarSchoolExam OptionGroup
		{
			get
			{
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				this._OptionGroupCache = IVisualNovelOptionGroupSolarSchoolExam.Create(this.Instance.OptionGroup);
				return this._OptionGroupCache;
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x00202A90 File Offset: 0x00200C90
		public virtual float? DialogDelay
		{
			get
			{
				if ((this.Instance.NullMask & 1048576U) == 0U)
				{
					return null;
				}
				return new float?(this.Instance.DialogDelay);
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0600D7F5 RID: 55285 RVA: 0x00202ACC File Offset: 0x00200CCC
		public virtual bool? ClickShowFull
		{
			get
			{
				if ((this.Instance.NullMask & 2097152U) == 0U)
				{
					return null;
				}
				return new bool?(this.Instance.ClickShowFull);
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x00202B06 File Offset: 0x00200D06
		public virtual string Interjection
		{
			get
			{
				return this.Instance.Interjection;
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0600D7F7 RID: 55287 RVA: 0x00202B13 File Offset: 0x00200D13
		public virtual IVisualNovelPortraitTransform Transform
		{
			get
			{
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				this._TransformCache = IVisualNovelPortraitTransform.Create(this.Instance.Transform);
				return this._TransformCache;
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x00202B47 File Offset: 0x00200D47
		public virtual IVisualNovelRoleConfig RoleConfig
		{
			get
			{
				if (this._RoleConfigInited)
				{
					return this._RoleConfigCache;
				}
				this._RoleConfigInited = true;
				this._RoleConfigCache = IVisualNovelRoleConfig.Create(this.Instance.RoleConfig);
				return this._RoleConfigCache;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x0600D7F9 RID: 55289 RVA: 0x00202B7B File Offset: 0x00200D7B
		[Nullable(1)]
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._VisualNovelBackgroundConfigInited)
				{
					return this._VisualNovelBackgroundConfigCache;
				}
				this._VisualNovelBackgroundConfigInited = true;
				this._VisualNovelBackgroundConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_VisualNovelBackgroundConfig(this.Instance);
				return this._VisualNovelBackgroundConfigCache;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x0600D7FA RID: 55290 RVA: 0x00202BAA File Offset: 0x00200DAA
		[Nullable(1)]
		public virtual IVisualNovelCgBase CgConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._CgConfigInited)
				{
					return this._CgConfigCache;
				}
				this._CgConfigInited = true;
				this._CgConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_CgConfig(this.Instance);
				return this._CgConfigCache;
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x0600D7FB RID: 55291 RVA: 0x00202BD9 File Offset: 0x00200DD9
		[Nullable(1)]
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._DisplayItemConfigInited)
				{
					return this._DisplayItemConfigCache;
				}
				this._DisplayItemConfigInited = true;
				this._DisplayItemConfigCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_DisplayItemConfig(this.Instance);
				return this._DisplayItemConfigCache;
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x00202C08 File Offset: 0x00200E08
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this.Instance.NullMask & 4194304U) == 0U)
				{
					return null;
				}
				return new int?(this.Instance.PlotKeyId);
			}
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x0600D7FD RID: 55293 RVA: 0x00202C44 File Offset: 0x00200E44
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> StartPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._StartPerformancesInited)
				{
					return this._StartPerformancesCache;
				}
				this._StartPerformancesInited = true;
				if ((this.Instance.NullMask & 8388608U) == 0U)
				{
					return null;
				}
				this._StartPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_StartPerformances(this.Instance);
				return this._StartPerformancesCache;
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x00202C94 File Offset: 0x00200E94
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> EndPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._EndPerformancesInited)
				{
					return this._EndPerformancesCache;
				}
				this._EndPerformancesInited = true;
				if ((this.Instance.NullMask & 16777216U) == 0U)
				{
					return null;
				}
				this._EndPerformancesCache = ActionReadHelper.ReadITalkItemVisualNovelTalk_EndPerformances(this.Instance);
				return this._EndPerformancesCache;
			}
		}

		// Token: 0x04007763 RID: 30563
		private ITalkItemVisualNovelTalk Instance;

		// Token: 0x04007764 RID: 30564
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04007765 RID: 30565
		private bool _CaptionParamsInited;

		// Token: 0x04007766 RID: 30566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007767 RID: 30567
		private bool _ActionsInited;

		// Token: 0x04007768 RID: 30568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04007769 RID: 30569
		private bool _OptionsInited;

		// Token: 0x0400776A RID: 30570
		private PlayMontage _MontageCache;

		// Token: 0x0400776B RID: 30571
		private bool _MontageInited;

		// Token: 0x0400776C RID: 30572
		private ICameraData _CameraDataCache;

		// Token: 0x0400776D RID: 30573
		private bool _CameraDataInited;

		// Token: 0x0400776E RID: 30574
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400776F RID: 30575
		private bool _FlowTemplateInited;

		// Token: 0x04007770 RID: 30576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04007771 RID: 30577
		private bool _FlowTemplateListInited;

		// Token: 0x04007772 RID: 30578
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04007773 RID: 30579
		private bool _ActorMontageArrayInited;

		// Token: 0x04007774 RID: 30580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04007775 RID: 30581
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04007776 RID: 30582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04007777 RID: 30583
		private bool _ActorLookAtArrayInited;

		// Token: 0x04007778 RID: 30584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04007779 RID: 30585
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400777A RID: 30586
		[Nullable(1)]
		private IPostAkEventType _TalkAkEventCache;

		// Token: 0x0400777B RID: 30587
		private bool _TalkAkEventInited;

		// Token: 0x0400777C RID: 30588
		[Nullable(1)]
		private IPostAkEventType _TalkEndAkEventCache;

		// Token: 0x0400777D RID: 30589
		private bool _TalkEndAkEventInited;

		// Token: 0x0400777E RID: 30590
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400777F RID: 30591
		private bool _UniversalToneInited;

		// Token: 0x04007780 RID: 30592
		[Nullable(1)]
		private ITalkBackground _BackgroundConfigCache;

		// Token: 0x04007781 RID: 30593
		private bool _BackgroundConfigInited;

		// Token: 0x04007782 RID: 30594
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04007783 RID: 30595
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04007784 RID: 30596
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04007785 RID: 30597
		private bool _GamepadShakeInited;

		// Token: 0x04007786 RID: 30598
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04007787 RID: 30599
		private bool _IntroActionsInited;

		// Token: 0x04007788 RID: 30600
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04007789 RID: 30601
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x0400778A RID: 30602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkEffectActionType> _TalkEffectArrayCache;

		// Token: 0x0400778B RID: 30603
		private bool _TalkEffectArrayInited;

		// Token: 0x0400778C RID: 30604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x0400778D RID: 30605
		private bool _ActorVisibilityArrayInited;

		// Token: 0x0400778E RID: 30606
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x0400778F RID: 30607
		private bool _OptionGroupInited;

		// Token: 0x04007790 RID: 30608
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04007791 RID: 30609
		private bool _TransformInited;

		// Token: 0x04007792 RID: 30610
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04007793 RID: 30611
		private bool _RoleConfigInited;

		// Token: 0x04007794 RID: 30612
		[Nullable(1)]
		private IVisualNovelBackgroundBase _VisualNovelBackgroundConfigCache;

		// Token: 0x04007795 RID: 30613
		private bool _VisualNovelBackgroundConfigInited;

		// Token: 0x04007796 RID: 30614
		[Nullable(1)]
		private IVisualNovelCgBase _CgConfigCache;

		// Token: 0x04007797 RID: 30615
		private bool _CgConfigInited;

		// Token: 0x04007798 RID: 30616
		[Nullable(1)]
		private IVisualNovelDisplayItemBase _DisplayItemConfigCache;

		// Token: 0x04007799 RID: 30617
		private bool _DisplayItemConfigInited;

		// Token: 0x0400779A RID: 30618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _StartPerformancesCache;

		// Token: 0x0400779B RID: 30619
		private bool _StartPerformancesInited;

		// Token: 0x0400779C RID: 30620
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _EndPerformancesCache;

		// Token: 0x0400779D RID: 30621
		private bool _EndPerformancesInited;
	}
}
