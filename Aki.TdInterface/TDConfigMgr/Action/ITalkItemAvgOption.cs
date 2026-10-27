using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F38 RID: 7992
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgOption : ITalkItem
	{
		// Token: 0x0600AC18 RID: 44056 RVA: 0x001872A8 File Offset: 0x001854A8
		[NullableContext(1)]
		private ITalkItemAvgOption_SetValue GetOrCreatePoco()
		{
			ITalkItemAvgOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAvgOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x001872CD File Offset: 0x001854CD
		[NullableContext(1)]
		public static ITalkItemAvgOption Create([Nullable(2)] ITalkItemAvgOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x001872E0 File Offset: 0x001854E0
		[NullableContext(1)]
		public static ITalkItemAvgOption CreateFromSetValue([Nullable(2)] ITalkItemAvgOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemAvgOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x001872F4 File Offset: 0x001854F4
		[NullableContext(1)]
		public new ITalkItemAvgOption_SetValue ToSetValue()
		{
			return new ITalkItemAvgOption_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				PlotLineId = this.PlotLineId,
				PlotLineKey = this.PlotLineKey,
				Name = this.Name,
				_folded = this._Folded,
				_editFlag = this._EditFlag,
				WhoId = this.WhoId,
				TextId = this.TextId,
				TidTalk = this.TidTalk,
				WaitTime = this.WaitTime,
				CaptionParams = this.CaptionParams,
				Actions = this.Actions,
				Options = this.Options,
				Montage = this.Montage,
				CameraData = this.CameraData,
				FlowTemplate = this.FlowTemplate,
				FlowTemplateList = this.FlowTemplateList,
				ActorMontageArray = this.ActorMontageArray,
				ActorFaceExpressionArray = this.ActorFaceExpressionArray,
				ActorLookAtArray = this.ActorLookAtArray,
				ActorTurnToArray = this.ActorTurnToArray,
				TalkAkEvent = this.TalkAkEvent,
				TalkEndAkEvent = this.TalkEndAkEvent,
				UniversalTone = this.UniversalTone,
				BackgroundConfig = this.BackgroundConfig,
				PlayVoice = this.PlayVoice,
				TimeLimitOptionGroup = this.TimeLimitOptionGroup,
				GamepadShake = this.GamepadShake,
				IntroActions = this.IntroActions,
				ActorFxEmoteArray = this.ActorFxEmoteArray,
				TalkEffectArray = this.TalkEffectArray,
				ActorVisibilityArray = this.ActorVisibilityArray
			};
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x00187494 File Offset: 0x00185694
		// (set) Token: 0x0600AC1D RID: 44061 RVA: 0x001874E5 File Offset: 0x001856E5
		public override ETalkItemType? Type
		{
			get
			{
				if ((this._SetMark & 1UL) != 0UL)
				{
					return this.PocoInterface.Type;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this._SetMark |= 1UL;
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600AC1E RID: 44062 RVA: 0x00187504 File Offset: 0x00185704
		// (set) Token: 0x0600AC1F RID: 44063 RVA: 0x00187551 File Offset: 0x00185751
		public override int Id
		{
			get
			{
				if ((this._SetMark & 2UL) != 0UL)
				{
					return this.PocoInterface.Id;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this._SetMark |= 2UL;
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600AC20 RID: 44064 RVA: 0x00187570 File Offset: 0x00185770
		// (set) Token: 0x0600AC21 RID: 44065 RVA: 0x001875C1 File Offset: 0x001857C1
		public override int? PlotLineId
		{
			get
			{
				if ((this._SetMark & 4UL) != 0UL)
				{
					return this.PocoInterface.PlotLineId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineId;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineId;
			}
			set
			{
				this._SetMark |= 4UL;
				this.GetOrCreatePoco().PlotLineId = value;
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600AC22 RID: 44066 RVA: 0x001875DE File Offset: 0x001857DE
		// (set) Token: 0x0600AC23 RID: 44067 RVA: 0x0018761C File Offset: 0x0018581C
		public override string PlotLineKey
		{
			get
			{
				if ((this._SetMark & 8UL) != 0UL)
				{
					return this.PocoInterface.PlotLineKey;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineKey;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineKey;
			}
			set
			{
				this._SetMark |= 8UL;
				this.GetOrCreatePoco().PlotLineKey = value;
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600AC24 RID: 44068 RVA: 0x0018763C File Offset: 0x0018583C
		// (set) Token: 0x0600AC25 RID: 44069 RVA: 0x0018768A File Offset: 0x0018588A
		[Nullable(1)]
		public override string Name
		{
			[NullableContext(1)]
			get
			{
				if ((this._SetMark & 16UL) != 0UL)
				{
					return this.PocoInterface.Name;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			[NullableContext(1)]
			set
			{
				this._SetMark |= 16UL;
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600AC26 RID: 44070 RVA: 0x001876A8 File Offset: 0x001858A8
		// (set) Token: 0x0600AC27 RID: 44071 RVA: 0x001876FA File Offset: 0x001858FA
		public override bool? _Folded
		{
			get
			{
				if ((this._SetMark & 32UL) != 0UL)
				{
					return this.PocoInterface._folded;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._folded;
			}
			set
			{
				this._SetMark |= 32UL;
				this.GetOrCreatePoco()._folded = value;
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600AC28 RID: 44072 RVA: 0x00187718 File Offset: 0x00185918
		// (set) Token: 0x0600AC29 RID: 44073 RVA: 0x0018776A File Offset: 0x0018596A
		public override EEditFlag? _EditFlag
		{
			get
			{
				if ((this._SetMark & 64UL) != 0UL)
				{
					return this.PocoInterface._editFlag;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance._EditFlag;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._editFlag;
			}
			set
			{
				this._SetMark |= 64UL;
				this.GetOrCreatePoco()._editFlag = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x00187788 File Offset: 0x00185988
		// (set) Token: 0x0600AC2B RID: 44075 RVA: 0x001877DD File Offset: 0x001859DD
		public override int? WhoId
		{
			get
			{
				if ((this._SetMark & 128UL) != 0UL)
				{
					return this.PocoInterface.WhoId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WhoId;
			}
			set
			{
				this._SetMark |= 128UL;
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600AC2C RID: 44076 RVA: 0x00187800 File Offset: 0x00185A00
		// (set) Token: 0x0600AC2D RID: 44077 RVA: 0x00187855 File Offset: 0x00185A55
		public override int? TextId
		{
			get
			{
				if ((this._SetMark & 256UL) != 0UL)
				{
					return this.PocoInterface.TextId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextId;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextId;
			}
			set
			{
				this._SetMark |= 256UL;
				this.GetOrCreatePoco().TextId = value;
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x00187878 File Offset: 0x00185A78
		// (set) Token: 0x0600AC2F RID: 44079 RVA: 0x001878C5 File Offset: 0x00185AC5
		public override string TidTalk
		{
			get
			{
				if ((this._SetMark & 512UL) != 0UL)
				{
					return this.PocoInterface.TidTalk;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTalk;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTalk;
			}
			set
			{
				this._SetMark |= 512UL;
				this.GetOrCreatePoco().TidTalk = value;
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x001878E8 File Offset: 0x00185AE8
		// (set) Token: 0x0600AC31 RID: 44081 RVA: 0x0018793D File Offset: 0x00185B3D
		public override float? WaitTime
		{
			get
			{
				if ((this._SetMark & 1024UL) != 0UL)
				{
					return this.PocoInterface.WaitTime;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitTime;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WaitTime;
			}
			set
			{
				this._SetMark |= 1024UL;
				this.GetOrCreatePoco().WaitTime = value;
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600AC32 RID: 44082 RVA: 0x00187960 File Offset: 0x00185B60
		// (set) Token: 0x0600AC33 RID: 44083 RVA: 0x001879DC File Offset: 0x00185BDC
		public override ICaptionParam CaptionParams
		{
			get
			{
				if ((this._SetMark & 2048UL) != 0UL)
				{
					return this.PocoInterface.CaptionParams;
				}
				if (this._CaptionParamsInited)
				{
					return this._CaptionParamsCache;
				}
				this._CaptionParamsInited = true;
				if (this.FbInstance != null)
				{
					this._CaptionParamsCache = ICaptionParam.Create(this.FbInstance.CaptionParams);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._CaptionParamsCache = ((pocoInterface != null) ? pocoInterface.CaptionParams : null);
				}
				return this._CaptionParamsCache;
			}
			set
			{
				this._SetMark |= 2048UL;
				this.GetOrCreatePoco().CaptionParams = value;
				this._CaptionParamsInited = false;
			}
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600AC34 RID: 44084 RVA: 0x00187A04 File Offset: 0x00185C04
		// (set) Token: 0x0600AC35 RID: 44085 RVA: 0x00187AB2 File Offset: 0x00185CB2
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
				if ((this._SetMark & 4096UL) != 0UL)
				{
					return this.PocoInterface.Actions;
				}
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 4096UL;
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x00187ADC File Offset: 0x00185CDC
		// (set) Token: 0x0600AC37 RID: 44087 RVA: 0x00187B8A File Offset: 0x00185D8A
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
				if ((this._SetMark & 8192UL) != 0UL)
				{
					return this.PocoInterface.Options;
				}
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				if (this.FbInstance != null)
				{
					List<ITalkOption> options = this.FbInstance.Options;
					if (options != null)
					{
						this._OptionsCache = new List<ITalkOption>(options.Count);
						for (int i = 0; i < options.Count; i++)
						{
							this._OptionsCache.Add(ITalkOption.Create(options[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._OptionsCache = ((pocoInterface != null) ? pocoInterface.Options : null);
				}
				return this._OptionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 8192UL;
				this.GetOrCreatePoco().Options = value;
				this._OptionsInited = false;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600AC38 RID: 44088 RVA: 0x00187BB4 File Offset: 0x00185DB4
		// (set) Token: 0x0600AC39 RID: 44089 RVA: 0x00187C30 File Offset: 0x00185E30
		public override PlayMontage Montage
		{
			get
			{
				if ((this._SetMark & 16384UL) != 0UL)
				{
					return this.PocoInterface.Montage;
				}
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				if (this.FbInstance != null)
				{
					this._MontageCache = PlayMontage.Create(this.FbInstance.Montage);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._MontageCache = ((pocoInterface != null) ? pocoInterface.Montage : null);
				}
				return this._MontageCache;
			}
			set
			{
				this._SetMark |= 16384UL;
				this.GetOrCreatePoco().Montage = value;
				this._MontageInited = false;
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600AC3A RID: 44090 RVA: 0x00187C58 File Offset: 0x00185E58
		// (set) Token: 0x0600AC3B RID: 44091 RVA: 0x00187CD4 File Offset: 0x00185ED4
		public override ICameraData CameraData
		{
			get
			{
				if ((this._SetMark & 32768UL) != 0UL)
				{
					return this.PocoInterface.CameraData;
				}
				if (this._CameraDataInited)
				{
					return this._CameraDataCache;
				}
				this._CameraDataInited = true;
				if (this.FbInstance != null)
				{
					this._CameraDataCache = ICameraData.Create(this.FbInstance.CameraData);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._CameraDataCache = ((pocoInterface != null) ? pocoInterface.CameraData : null);
				}
				return this._CameraDataCache;
			}
			set
			{
				this._SetMark |= 32768UL;
				this.GetOrCreatePoco().CameraData = value;
				this._CameraDataInited = false;
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x00187CFC File Offset: 0x00185EFC
		// (set) Token: 0x0600AC3D RID: 44093 RVA: 0x00187D78 File Offset: 0x00185F78
		public override SetFlowTemplate FlowTemplate
		{
			get
			{
				if ((this._SetMark & 65536UL) != 0UL)
				{
					return this.PocoInterface.FlowTemplate;
				}
				if (this._FlowTemplateInited)
				{
					return this._FlowTemplateCache;
				}
				this._FlowTemplateInited = true;
				if (this.FbInstance != null)
				{
					this._FlowTemplateCache = SetFlowTemplate.Create(this.FbInstance.FlowTemplate);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._FlowTemplateCache = ((pocoInterface != null) ? pocoInterface.FlowTemplate : null);
				}
				return this._FlowTemplateCache;
			}
			set
			{
				this._SetMark |= 65536UL;
				this.GetOrCreatePoco().FlowTemplate = value;
				this._FlowTemplateInited = false;
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600AC3E RID: 44094 RVA: 0x00187DA0 File Offset: 0x00185FA0
		// (set) Token: 0x0600AC3F RID: 44095 RVA: 0x00187E4E File Offset: 0x0018604E
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
				if ((this._SetMark & 131072UL) != 0UL)
				{
					return this.PocoInterface.FlowTemplateList;
				}
				if (this._FlowTemplateListInited)
				{
					return this._FlowTemplateListCache;
				}
				this._FlowTemplateListInited = true;
				if (this.FbInstance != null)
				{
					List<SetFlowTemplate> flowTemplateList = this.FbInstance.FlowTemplateList;
					if (flowTemplateList != null)
					{
						this._FlowTemplateListCache = new List<SetFlowTemplate>(flowTemplateList.Count);
						for (int i = 0; i < flowTemplateList.Count; i++)
						{
							this._FlowTemplateListCache.Add(SetFlowTemplate.Create(flowTemplateList[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._FlowTemplateListCache = ((pocoInterface != null) ? pocoInterface.FlowTemplateList : null);
				}
				return this._FlowTemplateListCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 131072UL;
				this.GetOrCreatePoco().FlowTemplateList = value;
				this._FlowTemplateListInited = false;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600AC40 RID: 44096 RVA: 0x00187E78 File Offset: 0x00186078
		// (set) Token: 0x0600AC41 RID: 44097 RVA: 0x00187F26 File Offset: 0x00186126
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
				if ((this._SetMark & 262144UL) != 0UL)
				{
					return this.PocoInterface.ActorMontageArray;
				}
				if (this._ActorMontageArrayInited)
				{
					return this._ActorMontageArrayCache;
				}
				this._ActorMontageArrayInited = true;
				if (this.FbInstance != null)
				{
					List<IMontageData> actorMontageArray = this.FbInstance.ActorMontageArray;
					if (actorMontageArray != null)
					{
						this._ActorMontageArrayCache = new List<IMontageData>(actorMontageArray.Count);
						for (int i = 0; i < actorMontageArray.Count; i++)
						{
							this._ActorMontageArrayCache.Add(IMontageData.Create(actorMontageArray[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActorMontageArrayCache = ((pocoInterface != null) ? pocoInterface.ActorMontageArray : null);
				}
				return this._ActorMontageArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 262144UL;
				this.GetOrCreatePoco().ActorMontageArray = value;
				this._ActorMontageArrayInited = false;
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600AC42 RID: 44098 RVA: 0x00187F50 File Offset: 0x00186150
		// (set) Token: 0x0600AC43 RID: 44099 RVA: 0x00187FFE File Offset: 0x001861FE
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
				if ((this._SetMark & 524288UL) != 0UL)
				{
					return this.PocoInterface.ActorFaceExpressionArray;
				}
				if (this._ActorFaceExpressionArrayInited)
				{
					return this._ActorFaceExpressionArrayCache;
				}
				this._ActorFaceExpressionArrayInited = true;
				if (this.FbInstance != null)
				{
					List<IActorFaceExpression> actorFaceExpressionArray = this.FbInstance.ActorFaceExpressionArray;
					if (actorFaceExpressionArray != null)
					{
						this._ActorFaceExpressionArrayCache = new List<IActorFaceExpression>(actorFaceExpressionArray.Count);
						for (int i = 0; i < actorFaceExpressionArray.Count; i++)
						{
							this._ActorFaceExpressionArrayCache.Add(IActorFaceExpression.Create(actorFaceExpressionArray[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActorFaceExpressionArrayCache = ((pocoInterface != null) ? pocoInterface.ActorFaceExpressionArray : null);
				}
				return this._ActorFaceExpressionArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 524288UL;
				this.GetOrCreatePoco().ActorFaceExpressionArray = value;
				this._ActorFaceExpressionArrayInited = false;
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600AC44 RID: 44100 RVA: 0x00188028 File Offset: 0x00186228
		// (set) Token: 0x0600AC45 RID: 44101 RVA: 0x001880D6 File Offset: 0x001862D6
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
				if ((this._SetMark & 1048576UL) != 0UL)
				{
					return this.PocoInterface.ActorLookAtArray;
				}
				if (this._ActorLookAtArrayInited)
				{
					return this._ActorLookAtArrayCache;
				}
				this._ActorLookAtArrayInited = true;
				if (this.FbInstance != null)
				{
					List<IActorLookAt> actorLookAtArray = this.FbInstance.ActorLookAtArray;
					if (actorLookAtArray != null)
					{
						this._ActorLookAtArrayCache = new List<IActorLookAt>(actorLookAtArray.Count);
						for (int i = 0; i < actorLookAtArray.Count; i++)
						{
							this._ActorLookAtArrayCache.Add(IActorLookAt.Create(actorLookAtArray[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActorLookAtArrayCache = ((pocoInterface != null) ? pocoInterface.ActorLookAtArray : null);
				}
				return this._ActorLookAtArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 1048576UL;
				this.GetOrCreatePoco().ActorLookAtArray = value;
				this._ActorLookAtArrayInited = false;
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x00188100 File Offset: 0x00186300
		// (set) Token: 0x0600AC47 RID: 44103 RVA: 0x001881AE File Offset: 0x001863AE
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
				if ((this._SetMark & 2097152UL) != 0UL)
				{
					return this.PocoInterface.ActorTurnToArray;
				}
				if (this._ActorTurnToArrayInited)
				{
					return this._ActorTurnToArrayCache;
				}
				this._ActorTurnToArrayInited = true;
				if (this.FbInstance != null)
				{
					List<IActorTurnTo> actorTurnToArray = this.FbInstance.ActorTurnToArray;
					if (actorTurnToArray != null)
					{
						this._ActorTurnToArrayCache = new List<IActorTurnTo>(actorTurnToArray.Count);
						for (int i = 0; i < actorTurnToArray.Count; i++)
						{
							this._ActorTurnToArrayCache.Add(IActorTurnTo.Create(actorTurnToArray[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActorTurnToArrayCache = ((pocoInterface != null) ? pocoInterface.ActorTurnToArray : null);
				}
				return this._ActorTurnToArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 2097152UL;
				this.GetOrCreatePoco().ActorTurnToArray = value;
				this._ActorTurnToArrayInited = false;
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600AC48 RID: 44104 RVA: 0x001881D8 File Offset: 0x001863D8
		// (set) Token: 0x0600AC49 RID: 44105 RVA: 0x00188225 File Offset: 0x00186425
		public override IPostAkEventType TalkAkEvent
		{
			get
			{
				if ((this._SetMark & 4194304UL) != 0UL)
				{
					return this.PocoInterface.TalkAkEvent;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkAkEvent;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkAkEvent;
			}
			set
			{
				this._SetMark |= 4194304UL;
				this.GetOrCreatePoco().TalkAkEvent = value;
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600AC4A RID: 44106 RVA: 0x00188248 File Offset: 0x00186448
		// (set) Token: 0x0600AC4B RID: 44107 RVA: 0x00188295 File Offset: 0x00186495
		public override IPostAkEventType TalkEndAkEvent
		{
			get
			{
				if ((this._SetMark & 8388608UL) != 0UL)
				{
					return this.PocoInterface.TalkEndAkEvent;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkEndAkEvent;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkEndAkEvent;
			}
			set
			{
				this._SetMark |= 8388608UL;
				this.GetOrCreatePoco().TalkEndAkEvent = value;
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600AC4C RID: 44108 RVA: 0x001882B8 File Offset: 0x001864B8
		// (set) Token: 0x0600AC4D RID: 44109 RVA: 0x00188334 File Offset: 0x00186534
		public override IUniversalTone UniversalTone
		{
			get
			{
				if ((this._SetMark & 16777216UL) != 0UL)
				{
					return this.PocoInterface.UniversalTone;
				}
				if (this._UniversalToneInited)
				{
					return this._UniversalToneCache;
				}
				this._UniversalToneInited = true;
				if (this.FbInstance != null)
				{
					this._UniversalToneCache = IUniversalTone.Create(this.FbInstance.UniversalTone);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._UniversalToneCache = ((pocoInterface != null) ? pocoInterface.UniversalTone : null);
				}
				return this._UniversalToneCache;
			}
			set
			{
				this._SetMark |= 16777216UL;
				this.GetOrCreatePoco().UniversalTone = value;
				this._UniversalToneInited = false;
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600AC4E RID: 44110 RVA: 0x0018835C File Offset: 0x0018655C
		// (set) Token: 0x0600AC4F RID: 44111 RVA: 0x001883A9 File Offset: 0x001865A9
		public override ITalkBackground BackgroundConfig
		{
			get
			{
				if ((this._SetMark & 33554432UL) != 0UL)
				{
					return this.PocoInterface.BackgroundConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.BackgroundConfig;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BackgroundConfig;
			}
			set
			{
				this._SetMark |= 33554432UL;
				this.GetOrCreatePoco().BackgroundConfig = value;
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600AC50 RID: 44112 RVA: 0x001883CC File Offset: 0x001865CC
		// (set) Token: 0x0600AC51 RID: 44113 RVA: 0x00188421 File Offset: 0x00186621
		public override bool? PlayVoice
		{
			get
			{
				if ((this._SetMark & 67108864UL) != 0UL)
				{
					return this.PocoInterface.PlayVoice;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayVoice;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayVoice;
			}
			set
			{
				this._SetMark |= 67108864UL;
				this.GetOrCreatePoco().PlayVoice = value;
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600AC52 RID: 44114 RVA: 0x00188444 File Offset: 0x00186644
		// (set) Token: 0x0600AC53 RID: 44115 RVA: 0x001884C0 File Offset: 0x001866C0
		public override ITimeLimitOptionGroup TimeLimitOptionGroup
		{
			get
			{
				if ((this._SetMark & 134217728UL) != 0UL)
				{
					return this.PocoInterface.TimeLimitOptionGroup;
				}
				if (this._TimeLimitOptionGroupInited)
				{
					return this._TimeLimitOptionGroupCache;
				}
				this._TimeLimitOptionGroupInited = true;
				if (this.FbInstance != null)
				{
					this._TimeLimitOptionGroupCache = ITimeLimitOptionGroup.Create(this.FbInstance.TimeLimitOptionGroup);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._TimeLimitOptionGroupCache = ((pocoInterface != null) ? pocoInterface.TimeLimitOptionGroup : null);
				}
				return this._TimeLimitOptionGroupCache;
			}
			set
			{
				this._SetMark |= 134217728UL;
				this.GetOrCreatePoco().TimeLimitOptionGroup = value;
				this._TimeLimitOptionGroupInited = false;
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x001884E8 File Offset: 0x001866E8
		// (set) Token: 0x0600AC55 RID: 44117 RVA: 0x00188564 File Offset: 0x00186764
		public override IGamepadShakeInTalk GamepadShake
		{
			get
			{
				if ((this._SetMark & 268435456UL) != 0UL)
				{
					return this.PocoInterface.GamepadShake;
				}
				if (this._GamepadShakeInited)
				{
					return this._GamepadShakeCache;
				}
				this._GamepadShakeInited = true;
				if (this.FbInstance != null)
				{
					this._GamepadShakeCache = IGamepadShakeInTalk.Create(this.FbInstance.GamepadShake);
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._GamepadShakeCache = ((pocoInterface != null) ? pocoInterface.GamepadShake : null);
				}
				return this._GamepadShakeCache;
			}
			set
			{
				this._SetMark |= 268435456UL;
				this.GetOrCreatePoco().GamepadShake = value;
				this._GamepadShakeInited = false;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600AC56 RID: 44118 RVA: 0x0018858C File Offset: 0x0018678C
		// (set) Token: 0x0600AC57 RID: 44119 RVA: 0x0018863A File Offset: 0x0018683A
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
				if ((this._SetMark & 536870912UL) != 0UL)
				{
					return this.PocoInterface.IntroActions;
				}
				if (this._IntroActionsInited)
				{
					return this._IntroActionsCache;
				}
				this._IntroActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> introActions = this.FbInstance.IntroActions;
					if (introActions != null)
					{
						this._IntroActionsCache = new List<ActionInfo>(introActions.Count);
						for (int i = 0; i < introActions.Count; i++)
						{
							this._IntroActionsCache.Add(ActionInfo.Create(introActions[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._IntroActionsCache = ((pocoInterface != null) ? pocoInterface.IntroActions : null);
				}
				return this._IntroActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 536870912UL;
				this.GetOrCreatePoco().IntroActions = value;
				this._IntroActionsInited = false;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x00188664 File Offset: 0x00186864
		// (set) Token: 0x0600AC59 RID: 44121 RVA: 0x00188712 File Offset: 0x00186912
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
				if ((this._SetMark & 1073741824UL) != 0UL)
				{
					return this.PocoInterface.ActorFxEmoteArray;
				}
				if (this._ActorFxEmoteArrayInited)
				{
					return this._ActorFxEmoteArrayCache;
				}
				this._ActorFxEmoteArrayInited = true;
				if (this.FbInstance != null)
				{
					List<IActorFxEmote> actorFxEmoteArray = this.FbInstance.ActorFxEmoteArray;
					if (actorFxEmoteArray != null)
					{
						this._ActorFxEmoteArrayCache = new List<IActorFxEmote>(actorFxEmoteArray.Count);
						for (int i = 0; i < actorFxEmoteArray.Count; i++)
						{
							this._ActorFxEmoteArrayCache.Add(IActorFxEmote.Create(actorFxEmoteArray[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActorFxEmoteArrayCache = ((pocoInterface != null) ? pocoInterface.ActorFxEmoteArray : null);
				}
				return this._ActorFxEmoteArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 1073741824UL;
				this.GetOrCreatePoco().ActorFxEmoteArray = value;
				this._ActorFxEmoteArrayInited = false;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x0018873C File Offset: 0x0018693C
		// (set) Token: 0x0600AC5B RID: 44123 RVA: 0x00188789 File Offset: 0x00186989
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
				if ((this._SetMark & (ulong)-2147483648) != 0UL)
				{
					return this.PocoInterface.TalkEffectArray;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkEffectArray;
				}
				ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkEffectArray;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x001887AC File Offset: 0x001869AC
		// (set) Token: 0x0600AC5D RID: 44125 RVA: 0x0018885D File Offset: 0x00186A5D
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
				if ((this._SetMark & 4294967296UL) != 0UL)
				{
					return this.PocoInterface.ActorVisibilityArray;
				}
				if (this._ActorVisibilityArrayInited)
				{
					return this._ActorVisibilityArrayCache;
				}
				this._ActorVisibilityArrayInited = true;
				if (this.FbInstance != null)
				{
					List<IActorVisibility> actorVisibilityArray = this.FbInstance.ActorVisibilityArray;
					if (actorVisibilityArray != null)
					{
						this._ActorVisibilityArrayCache = new List<IActorVisibility>(actorVisibilityArray.Count);
						for (int i = 0; i < actorVisibilityArray.Count; i++)
						{
							this._ActorVisibilityArrayCache.Add(IActorVisibility.Create(actorVisibilityArray[i]));
						}
					}
				}
				else
				{
					ITalkItemAvgOption_SetValue pocoInterface = this.PocoInterface;
					this._ActorVisibilityArrayCache = ((pocoInterface != null) ? pocoInterface.ActorVisibilityArray : null);
				}
				return this._ActorVisibilityArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 4294967296UL;
				this.GetOrCreatePoco().ActorVisibilityArray = value;
				this._ActorVisibilityArrayInited = false;
			}
		}

		// Token: 0x040066BD RID: 26301
		protected new ITalkItemAvgOption FbInstance;

		// Token: 0x040066BE RID: 26302
		protected new ITalkItemAvgOption_SetValue PocoInterface;

		// Token: 0x040066BF RID: 26303
		private ulong _SetMark;

		// Token: 0x040066C0 RID: 26304
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040066C1 RID: 26305
		private bool _CaptionParamsInited;

		// Token: 0x040066C2 RID: 26306
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040066C3 RID: 26307
		private bool _ActionsInited;

		// Token: 0x040066C4 RID: 26308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040066C5 RID: 26309
		private bool _OptionsInited;

		// Token: 0x040066C6 RID: 26310
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x040066C7 RID: 26311
		private bool _MontageInited;

		// Token: 0x040066C8 RID: 26312
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x040066C9 RID: 26313
		private bool _CameraDataInited;

		// Token: 0x040066CA RID: 26314
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040066CB RID: 26315
		private bool _FlowTemplateInited;

		// Token: 0x040066CC RID: 26316
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040066CD RID: 26317
		private bool _FlowTemplateListInited;

		// Token: 0x040066CE RID: 26318
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040066CF RID: 26319
		private bool _ActorMontageArrayInited;

		// Token: 0x040066D0 RID: 26320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040066D1 RID: 26321
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040066D2 RID: 26322
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040066D3 RID: 26323
		private bool _ActorLookAtArrayInited;

		// Token: 0x040066D4 RID: 26324
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040066D5 RID: 26325
		private bool _ActorTurnToArrayInited;

		// Token: 0x040066D6 RID: 26326
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040066D7 RID: 26327
		private bool _UniversalToneInited;

		// Token: 0x040066D8 RID: 26328
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040066D9 RID: 26329
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040066DA RID: 26330
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040066DB RID: 26331
		private bool _GamepadShakeInited;

		// Token: 0x040066DC RID: 26332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040066DD RID: 26333
		private bool _IntroActionsInited;

		// Token: 0x040066DE RID: 26334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040066DF RID: 26335
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040066E0 RID: 26336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040066E1 RID: 26337
		private bool _ActorVisibilityArrayInited;
	}
}
