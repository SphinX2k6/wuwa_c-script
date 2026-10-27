using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3C RID: 7996
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgTalk : ITalkItem
	{
		// Token: 0x0600AC6C RID: 44140 RVA: 0x00188A00 File Offset: 0x00186C00
		[NullableContext(1)]
		private ITalkItemAvgTalk_SetValue GetOrCreatePoco()
		{
			ITalkItemAvgTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAvgTalk_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x00188A25 File Offset: 0x00186C25
		[NullableContext(1)]
		public static ITalkItemAvgTalk Create([Nullable(2)] ITalkItemAvgTalk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgTalk
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x00188A38 File Offset: 0x00186C38
		[NullableContext(1)]
		public static ITalkItemAvgTalk CreateFromSetValue([Nullable(2)] ITalkItemAvgTalk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemAvgTalk
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x00188A4C File Offset: 0x00186C4C
		[NullableContext(1)]
		public new ITalkItemAvgTalk_SetValue ToSetValue()
		{
			return new ITalkItemAvgTalk_SetValue
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
				AvgRoleConfig = this.AvgRoleConfig,
				PositionConfig = this.PositionConfig
			};
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x00188C04 File Offset: 0x00186E04
		// (set) Token: 0x0600AC71 RID: 44145 RVA: 0x00188C55 File Offset: 0x00186E55
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x00188C74 File Offset: 0x00186E74
		// (set) Token: 0x0600AC73 RID: 44147 RVA: 0x00188CC1 File Offset: 0x00186EC1
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

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x00188CE0 File Offset: 0x00186EE0
		// (set) Token: 0x0600AC75 RID: 44149 RVA: 0x00188D31 File Offset: 0x00186F31
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x00188D4E File Offset: 0x00186F4E
		// (set) Token: 0x0600AC77 RID: 44151 RVA: 0x00188D8C File Offset: 0x00186F8C
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x00188DAC File Offset: 0x00186FAC
		// (set) Token: 0x0600AC79 RID: 44153 RVA: 0x00188DFA File Offset: 0x00186FFA
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

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600AC7A RID: 44154 RVA: 0x00188E18 File Offset: 0x00187018
		// (set) Token: 0x0600AC7B RID: 44155 RVA: 0x00188E6A File Offset: 0x0018706A
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x00188E88 File Offset: 0x00187088
		// (set) Token: 0x0600AC7D RID: 44157 RVA: 0x00188EDA File Offset: 0x001870DA
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x00188EF8 File Offset: 0x001870F8
		// (set) Token: 0x0600AC7F RID: 44159 RVA: 0x00188F4D File Offset: 0x0018714D
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600AC80 RID: 44160 RVA: 0x00188F70 File Offset: 0x00187170
		// (set) Token: 0x0600AC81 RID: 44161 RVA: 0x00188FC5 File Offset: 0x001871C5
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600AC82 RID: 44162 RVA: 0x00188FE8 File Offset: 0x001871E8
		// (set) Token: 0x0600AC83 RID: 44163 RVA: 0x00189035 File Offset: 0x00187235
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600AC84 RID: 44164 RVA: 0x00189058 File Offset: 0x00187258
		// (set) Token: 0x0600AC85 RID: 44165 RVA: 0x001890AD File Offset: 0x001872AD
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600AC86 RID: 44166 RVA: 0x001890D0 File Offset: 0x001872D0
		// (set) Token: 0x0600AC87 RID: 44167 RVA: 0x0018914C File Offset: 0x0018734C
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600AC88 RID: 44168 RVA: 0x00189174 File Offset: 0x00187374
		// (set) Token: 0x0600AC89 RID: 44169 RVA: 0x00189222 File Offset: 0x00187422
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600AC8A RID: 44170 RVA: 0x0018924C File Offset: 0x0018744C
		// (set) Token: 0x0600AC8B RID: 44171 RVA: 0x001892FA File Offset: 0x001874FA
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600AC8C RID: 44172 RVA: 0x00189324 File Offset: 0x00187524
		// (set) Token: 0x0600AC8D RID: 44173 RVA: 0x001893A0 File Offset: 0x001875A0
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600AC8E RID: 44174 RVA: 0x001893C8 File Offset: 0x001875C8
		// (set) Token: 0x0600AC8F RID: 44175 RVA: 0x00189444 File Offset: 0x00187644
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600AC90 RID: 44176 RVA: 0x0018946C File Offset: 0x0018766C
		// (set) Token: 0x0600AC91 RID: 44177 RVA: 0x001894E8 File Offset: 0x001876E8
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600AC92 RID: 44178 RVA: 0x00189510 File Offset: 0x00187710
		// (set) Token: 0x0600AC93 RID: 44179 RVA: 0x001895BE File Offset: 0x001877BE
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600AC94 RID: 44180 RVA: 0x001895E8 File Offset: 0x001877E8
		// (set) Token: 0x0600AC95 RID: 44181 RVA: 0x00189696 File Offset: 0x00187896
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600AC96 RID: 44182 RVA: 0x001896C0 File Offset: 0x001878C0
		// (set) Token: 0x0600AC97 RID: 44183 RVA: 0x0018976E File Offset: 0x0018796E
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600AC98 RID: 44184 RVA: 0x00189798 File Offset: 0x00187998
		// (set) Token: 0x0600AC99 RID: 44185 RVA: 0x00189846 File Offset: 0x00187A46
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600AC9A RID: 44186 RVA: 0x00189870 File Offset: 0x00187A70
		// (set) Token: 0x0600AC9B RID: 44187 RVA: 0x0018991E File Offset: 0x00187B1E
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600AC9C RID: 44188 RVA: 0x00189948 File Offset: 0x00187B48
		// (set) Token: 0x0600AC9D RID: 44189 RVA: 0x00189995 File Offset: 0x00187B95
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600AC9E RID: 44190 RVA: 0x001899B8 File Offset: 0x00187BB8
		// (set) Token: 0x0600AC9F RID: 44191 RVA: 0x00189A05 File Offset: 0x00187C05
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600ACA0 RID: 44192 RVA: 0x00189A28 File Offset: 0x00187C28
		// (set) Token: 0x0600ACA1 RID: 44193 RVA: 0x00189AA4 File Offset: 0x00187CA4
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600ACA2 RID: 44194 RVA: 0x00189ACC File Offset: 0x00187CCC
		// (set) Token: 0x0600ACA3 RID: 44195 RVA: 0x00189B19 File Offset: 0x00187D19
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x00189B3C File Offset: 0x00187D3C
		// (set) Token: 0x0600ACA5 RID: 44197 RVA: 0x00189B91 File Offset: 0x00187D91
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600ACA6 RID: 44198 RVA: 0x00189BB4 File Offset: 0x00187DB4
		// (set) Token: 0x0600ACA7 RID: 44199 RVA: 0x00189C30 File Offset: 0x00187E30
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600ACA8 RID: 44200 RVA: 0x00189C58 File Offset: 0x00187E58
		// (set) Token: 0x0600ACA9 RID: 44201 RVA: 0x00189CD4 File Offset: 0x00187ED4
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600ACAA RID: 44202 RVA: 0x00189CFC File Offset: 0x00187EFC
		// (set) Token: 0x0600ACAB RID: 44203 RVA: 0x00189DAA File Offset: 0x00187FAA
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600ACAC RID: 44204 RVA: 0x00189DD4 File Offset: 0x00187FD4
		// (set) Token: 0x0600ACAD RID: 44205 RVA: 0x00189E82 File Offset: 0x00188082
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x00189EAC File Offset: 0x001880AC
		// (set) Token: 0x0600ACAF RID: 44207 RVA: 0x00189EF9 File Offset: 0x001880F9
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
				ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x00189F1C File Offset: 0x0018811C
		// (set) Token: 0x0600ACB1 RID: 44209 RVA: 0x00189FCD File Offset: 0x001881CD
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x00189FF8 File Offset: 0x001881F8
		// (set) Token: 0x0600ACB3 RID: 44211 RVA: 0x0018A077 File Offset: 0x00188277
		[Nullable(1)]
		public virtual ITalkItemAvgRoleConfig AvgRoleConfig
		{
			[NullableContext(1)]
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.AvgRoleConfig;
				}
				if (this._AvgRoleConfigInited)
				{
					return this._AvgRoleConfigCache;
				}
				this._AvgRoleConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AvgRoleConfigCache = ITalkItemAvgRoleConfig.Create(this.FbInstance.AvgRoleConfig);
				}
				else
				{
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
					this._AvgRoleConfigCache = ((pocoInterface != null) ? pocoInterface.AvgRoleConfig : null);
				}
				return this._AvgRoleConfigCache;
			}
			[NullableContext(1)]
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().AvgRoleConfig = value;
				this._AvgRoleConfigInited = false;
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x0018A0A4 File Offset: 0x001882A4
		// (set) Token: 0x0600ACB5 RID: 44213 RVA: 0x0018A0F8 File Offset: 0x001882F8
		public virtual EAvgRolePosition PositionConfig
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface.PositionConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionConfig;
				}
				if (this.PocoInterface == null)
				{
					return EAvgRolePosition.Center;
				}
				return this.PocoInterface.PositionConfig;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco().PositionConfig = value;
			}
		}

		// Token: 0x04006708 RID: 26376
		protected new ITalkItemAvgTalk FbInstance;

		// Token: 0x04006709 RID: 26377
		protected new ITalkItemAvgTalk_SetValue PocoInterface;

		// Token: 0x0400670A RID: 26378
		private ulong _SetMark;

		// Token: 0x0400670B RID: 26379
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x0400670C RID: 26380
		private bool _CaptionParamsInited;

		// Token: 0x0400670D RID: 26381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400670E RID: 26382
		private bool _ActionsInited;

		// Token: 0x0400670F RID: 26383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006710 RID: 26384
		private bool _OptionsInited;

		// Token: 0x04006711 RID: 26385
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x04006712 RID: 26386
		private bool _MontageInited;

		// Token: 0x04006713 RID: 26387
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006714 RID: 26388
		private bool _CameraDataInited;

		// Token: 0x04006715 RID: 26389
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006716 RID: 26390
		private bool _FlowTemplateInited;

		// Token: 0x04006717 RID: 26391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006718 RID: 26392
		private bool _FlowTemplateListInited;

		// Token: 0x04006719 RID: 26393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x0400671A RID: 26394
		private bool _ActorMontageArrayInited;

		// Token: 0x0400671B RID: 26395
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x0400671C RID: 26396
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x0400671D RID: 26397
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x0400671E RID: 26398
		private bool _ActorLookAtArrayInited;

		// Token: 0x0400671F RID: 26399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006720 RID: 26400
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006721 RID: 26401
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006722 RID: 26402
		private bool _UniversalToneInited;

		// Token: 0x04006723 RID: 26403
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006724 RID: 26404
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006725 RID: 26405
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006726 RID: 26406
		private bool _GamepadShakeInited;

		// Token: 0x04006727 RID: 26407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006728 RID: 26408
		private bool _IntroActionsInited;

		// Token: 0x04006729 RID: 26409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x0400672A RID: 26410
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x0400672B RID: 26411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x0400672C RID: 26412
		private bool _ActorVisibilityArrayInited;

		// Token: 0x0400672D RID: 26413
		[Nullable(1)]
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x0400672E RID: 26414
		private bool _AvgRoleConfigInited;
	}
}
