using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F46 RID: 8006
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemOption : ITalkItem
	{
		// Token: 0x0600ADAA RID: 44458 RVA: 0x0018E890 File Offset: 0x0018CA90
		[NullableContext(1)]
		private ITalkItemOption_SetValue GetOrCreatePoco()
		{
			ITalkItemOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x0018E8B5 File Offset: 0x0018CAB5
		[NullableContext(1)]
		public static ITalkItemOption Create([Nullable(2)] ITalkItemOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x0018E8C8 File Offset: 0x0018CAC8
		[NullableContext(1)]
		public static ITalkItemOption CreateFromSetValue([Nullable(2)] ITalkItemOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x0018E8DC File Offset: 0x0018CADC
		[NullableContext(1)]
		public new ITalkItemOption_SetValue ToSetValue()
		{
			return new ITalkItemOption_SetValue
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
				ActorVisibilityArray = this.ActorVisibilityArray,
				CameraMotion = this.CameraMotion,
				AutoPlayConfig = this.AutoPlayConfig
			};
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x0018EA94 File Offset: 0x0018CC94
		// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x0018EAE5 File Offset: 0x0018CCE5
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x0018EB04 File Offset: 0x0018CD04
		// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x0018EB51 File Offset: 0x0018CD51
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

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x0018EB70 File Offset: 0x0018CD70
		// (set) Token: 0x0600ADB3 RID: 44467 RVA: 0x0018EBC1 File Offset: 0x0018CDC1
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600ADB4 RID: 44468 RVA: 0x0018EBDE File Offset: 0x0018CDDE
		// (set) Token: 0x0600ADB5 RID: 44469 RVA: 0x0018EC1C File Offset: 0x0018CE1C
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600ADB6 RID: 44470 RVA: 0x0018EC3C File Offset: 0x0018CE3C
		// (set) Token: 0x0600ADB7 RID: 44471 RVA: 0x0018EC8A File Offset: 0x0018CE8A
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

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x0018ECA8 File Offset: 0x0018CEA8
		// (set) Token: 0x0600ADB9 RID: 44473 RVA: 0x0018ECFA File Offset: 0x0018CEFA
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600ADBA RID: 44474 RVA: 0x0018ED18 File Offset: 0x0018CF18
		// (set) Token: 0x0600ADBB RID: 44475 RVA: 0x0018ED6A File Offset: 0x0018CF6A
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600ADBC RID: 44476 RVA: 0x0018ED88 File Offset: 0x0018CF88
		// (set) Token: 0x0600ADBD RID: 44477 RVA: 0x0018EDDD File Offset: 0x0018CFDD
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600ADBE RID: 44478 RVA: 0x0018EE00 File Offset: 0x0018D000
		// (set) Token: 0x0600ADBF RID: 44479 RVA: 0x0018EE55 File Offset: 0x0018D055
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600ADC0 RID: 44480 RVA: 0x0018EE78 File Offset: 0x0018D078
		// (set) Token: 0x0600ADC1 RID: 44481 RVA: 0x0018EEC5 File Offset: 0x0018D0C5
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x0018EEE8 File Offset: 0x0018D0E8
		// (set) Token: 0x0600ADC3 RID: 44483 RVA: 0x0018EF3D File Offset: 0x0018D13D
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600ADC4 RID: 44484 RVA: 0x0018EF60 File Offset: 0x0018D160
		// (set) Token: 0x0600ADC5 RID: 44485 RVA: 0x0018EFDC File Offset: 0x0018D1DC
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600ADC6 RID: 44486 RVA: 0x0018F004 File Offset: 0x0018D204
		// (set) Token: 0x0600ADC7 RID: 44487 RVA: 0x0018F0B2 File Offset: 0x0018D2B2
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600ADC8 RID: 44488 RVA: 0x0018F0DC File Offset: 0x0018D2DC
		// (set) Token: 0x0600ADC9 RID: 44489 RVA: 0x0018F18A File Offset: 0x0018D38A
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600ADCA RID: 44490 RVA: 0x0018F1B4 File Offset: 0x0018D3B4
		// (set) Token: 0x0600ADCB RID: 44491 RVA: 0x0018F230 File Offset: 0x0018D430
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600ADCC RID: 44492 RVA: 0x0018F258 File Offset: 0x0018D458
		// (set) Token: 0x0600ADCD RID: 44493 RVA: 0x0018F2D4 File Offset: 0x0018D4D4
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600ADCE RID: 44494 RVA: 0x0018F2FC File Offset: 0x0018D4FC
		// (set) Token: 0x0600ADCF RID: 44495 RVA: 0x0018F378 File Offset: 0x0018D578
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x0018F3A0 File Offset: 0x0018D5A0
		// (set) Token: 0x0600ADD1 RID: 44497 RVA: 0x0018F44E File Offset: 0x0018D64E
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600ADD2 RID: 44498 RVA: 0x0018F478 File Offset: 0x0018D678
		// (set) Token: 0x0600ADD3 RID: 44499 RVA: 0x0018F526 File Offset: 0x0018D726
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600ADD4 RID: 44500 RVA: 0x0018F550 File Offset: 0x0018D750
		// (set) Token: 0x0600ADD5 RID: 44501 RVA: 0x0018F5FE File Offset: 0x0018D7FE
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600ADD6 RID: 44502 RVA: 0x0018F628 File Offset: 0x0018D828
		// (set) Token: 0x0600ADD7 RID: 44503 RVA: 0x0018F6D6 File Offset: 0x0018D8D6
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x0018F700 File Offset: 0x0018D900
		// (set) Token: 0x0600ADD9 RID: 44505 RVA: 0x0018F7AE File Offset: 0x0018D9AE
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600ADDA RID: 44506 RVA: 0x0018F7D8 File Offset: 0x0018D9D8
		// (set) Token: 0x0600ADDB RID: 44507 RVA: 0x0018F825 File Offset: 0x0018DA25
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600ADDC RID: 44508 RVA: 0x0018F848 File Offset: 0x0018DA48
		// (set) Token: 0x0600ADDD RID: 44509 RVA: 0x0018F895 File Offset: 0x0018DA95
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600ADDE RID: 44510 RVA: 0x0018F8B8 File Offset: 0x0018DAB8
		// (set) Token: 0x0600ADDF RID: 44511 RVA: 0x0018F934 File Offset: 0x0018DB34
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x0018F95C File Offset: 0x0018DB5C
		// (set) Token: 0x0600ADE1 RID: 44513 RVA: 0x0018F9A9 File Offset: 0x0018DBA9
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x0018F9CC File Offset: 0x0018DBCC
		// (set) Token: 0x0600ADE3 RID: 44515 RVA: 0x0018FA21 File Offset: 0x0018DC21
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x0018FA44 File Offset: 0x0018DC44
		// (set) Token: 0x0600ADE5 RID: 44517 RVA: 0x0018FAC0 File Offset: 0x0018DCC0
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x0018FAE8 File Offset: 0x0018DCE8
		// (set) Token: 0x0600ADE7 RID: 44519 RVA: 0x0018FB64 File Offset: 0x0018DD64
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x0018FB8C File Offset: 0x0018DD8C
		// (set) Token: 0x0600ADE9 RID: 44521 RVA: 0x0018FC3A File Offset: 0x0018DE3A
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x0018FC64 File Offset: 0x0018DE64
		// (set) Token: 0x0600ADEB RID: 44523 RVA: 0x0018FD12 File Offset: 0x0018DF12
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x0018FD3C File Offset: 0x0018DF3C
		// (set) Token: 0x0600ADED RID: 44525 RVA: 0x0018FD89 File Offset: 0x0018DF89
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
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x0018FDAC File Offset: 0x0018DFAC
		// (set) Token: 0x0600ADEF RID: 44527 RVA: 0x0018FE5D File Offset: 0x0018E05D
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
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x0018FE88 File Offset: 0x0018E088
		// (set) Token: 0x0600ADF1 RID: 44529 RVA: 0x0018FED8 File Offset: 0x0018E0D8
		public virtual IShowTalkCameraMotion CameraMotion
		{
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.CameraMotion;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraMotion;
				}
				ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraMotion;
			}
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().CameraMotion = value;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x0018FEFC File Offset: 0x0018E0FC
		// (set) Token: 0x0600ADF3 RID: 44531 RVA: 0x0018FF7B File Offset: 0x0018E17B
		public virtual ITalkItemAutoPlayConfig AutoPlayConfig
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface.AutoPlayConfig;
				}
				if (this._AutoPlayConfigInited)
				{
					return this._AutoPlayConfigCache;
				}
				this._AutoPlayConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AutoPlayConfigCache = ITalkItemAutoPlayConfig.Create(this.FbInstance.AutoPlayConfig);
				}
				else
				{
					ITalkItemOption_SetValue pocoInterface = this.PocoInterface;
					this._AutoPlayConfigCache = ((pocoInterface != null) ? pocoInterface.AutoPlayConfig : null);
				}
				return this._AutoPlayConfigCache;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco().AutoPlayConfig = value;
				this._AutoPlayConfigInited = false;
			}
		}

		// Token: 0x04006834 RID: 26676
		protected new ITalkItemOption FbInstance;

		// Token: 0x04006835 RID: 26677
		protected new ITalkItemOption_SetValue PocoInterface;

		// Token: 0x04006836 RID: 26678
		private ulong _SetMark;

		// Token: 0x04006837 RID: 26679
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006838 RID: 26680
		private bool _CaptionParamsInited;

		// Token: 0x04006839 RID: 26681
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400683A RID: 26682
		private bool _ActionsInited;

		// Token: 0x0400683B RID: 26683
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x0400683C RID: 26684
		private bool _OptionsInited;

		// Token: 0x0400683D RID: 26685
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x0400683E RID: 26686
		private bool _MontageInited;

		// Token: 0x0400683F RID: 26687
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006840 RID: 26688
		private bool _CameraDataInited;

		// Token: 0x04006841 RID: 26689
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006842 RID: 26690
		private bool _FlowTemplateInited;

		// Token: 0x04006843 RID: 26691
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006844 RID: 26692
		private bool _FlowTemplateListInited;

		// Token: 0x04006845 RID: 26693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006846 RID: 26694
		private bool _ActorMontageArrayInited;

		// Token: 0x04006847 RID: 26695
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006848 RID: 26696
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006849 RID: 26697
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x0400684A RID: 26698
		private bool _ActorLookAtArrayInited;

		// Token: 0x0400684B RID: 26699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x0400684C RID: 26700
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400684D RID: 26701
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400684E RID: 26702
		private bool _UniversalToneInited;

		// Token: 0x0400684F RID: 26703
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006850 RID: 26704
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006851 RID: 26705
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006852 RID: 26706
		private bool _GamepadShakeInited;

		// Token: 0x04006853 RID: 26707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006854 RID: 26708
		private bool _IntroActionsInited;

		// Token: 0x04006855 RID: 26709
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006856 RID: 26710
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006857 RID: 26711
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006858 RID: 26712
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006859 RID: 26713
		[Nullable(1)]
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x0400685A RID: 26714
		private bool _AutoPlayConfigInited;
	}
}
