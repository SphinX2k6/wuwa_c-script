using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F62 RID: 8034
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNoTextItem : ITalkItem
	{
		// Token: 0x0600AFCA RID: 45002 RVA: 0x00197E24 File Offset: 0x00196024
		[NullableContext(1)]
		private ITalkItemVisualNovelNoTextItem_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelNoTextItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelNoTextItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x00197E49 File Offset: 0x00196049
		[NullableContext(1)]
		public static ITalkItemVisualNovelNoTextItem Create([Nullable(2)] ITalkItemVisualNovelNoTextItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNoTextItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x00197E5C File Offset: 0x0019605C
		[NullableContext(1)]
		public static ITalkItemVisualNovelNoTextItem CreateFromSetValue([Nullable(2)] ITalkItemVisualNovelNoTextItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNoTextItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x00197E70 File Offset: 0x00196070
		[NullableContext(1)]
		public new ITalkItemVisualNovelNoTextItem_SetValue ToSetValue()
		{
			return new ITalkItemVisualNovelNoTextItem_SetValue
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
				OptionInteractionType = this.OptionInteractionType,
				OptionGroup = this.OptionGroup,
				VisualNovelBackgroundConfig = this.VisualNovelBackgroundConfig,
				CgConfig = this.CgConfig,
				DisplayItemConfig = this.DisplayItemConfig,
				PlotKeyId = this.PlotKeyId,
				StartPerformances = this.StartPerformances,
				EndPerformances = this.EndPerformances
			};
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600AFCE RID: 45006 RVA: 0x00198070 File Offset: 0x00196270
		// (set) Token: 0x0600AFCF RID: 45007 RVA: 0x001980C1 File Offset: 0x001962C1
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600AFD0 RID: 45008 RVA: 0x001980E0 File Offset: 0x001962E0
		// (set) Token: 0x0600AFD1 RID: 45009 RVA: 0x0019812D File Offset: 0x0019632D
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

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600AFD2 RID: 45010 RVA: 0x0019814C File Offset: 0x0019634C
		// (set) Token: 0x0600AFD3 RID: 45011 RVA: 0x0019819D File Offset: 0x0019639D
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600AFD4 RID: 45012 RVA: 0x001981BA File Offset: 0x001963BA
		// (set) Token: 0x0600AFD5 RID: 45013 RVA: 0x001981F8 File Offset: 0x001963F8
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600AFD6 RID: 45014 RVA: 0x00198218 File Offset: 0x00196418
		// (set) Token: 0x0600AFD7 RID: 45015 RVA: 0x00198266 File Offset: 0x00196466
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

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600AFD8 RID: 45016 RVA: 0x00198284 File Offset: 0x00196484
		// (set) Token: 0x0600AFD9 RID: 45017 RVA: 0x001982D6 File Offset: 0x001964D6
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600AFDA RID: 45018 RVA: 0x001982F4 File Offset: 0x001964F4
		// (set) Token: 0x0600AFDB RID: 45019 RVA: 0x00198346 File Offset: 0x00196546
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600AFDC RID: 45020 RVA: 0x00198364 File Offset: 0x00196564
		// (set) Token: 0x0600AFDD RID: 45021 RVA: 0x001983B9 File Offset: 0x001965B9
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600AFDE RID: 45022 RVA: 0x001983DC File Offset: 0x001965DC
		// (set) Token: 0x0600AFDF RID: 45023 RVA: 0x00198431 File Offset: 0x00196631
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600AFE0 RID: 45024 RVA: 0x00198454 File Offset: 0x00196654
		// (set) Token: 0x0600AFE1 RID: 45025 RVA: 0x001984A1 File Offset: 0x001966A1
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600AFE2 RID: 45026 RVA: 0x001984C4 File Offset: 0x001966C4
		// (set) Token: 0x0600AFE3 RID: 45027 RVA: 0x00198519 File Offset: 0x00196719
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600AFE4 RID: 45028 RVA: 0x0019853C File Offset: 0x0019673C
		// (set) Token: 0x0600AFE5 RID: 45029 RVA: 0x001985B8 File Offset: 0x001967B8
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600AFE6 RID: 45030 RVA: 0x001985E0 File Offset: 0x001967E0
		// (set) Token: 0x0600AFE7 RID: 45031 RVA: 0x0019868E File Offset: 0x0019688E
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600AFE8 RID: 45032 RVA: 0x001986B8 File Offset: 0x001968B8
		// (set) Token: 0x0600AFE9 RID: 45033 RVA: 0x00198766 File Offset: 0x00196966
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600AFEA RID: 45034 RVA: 0x00198790 File Offset: 0x00196990
		// (set) Token: 0x0600AFEB RID: 45035 RVA: 0x0019880C File Offset: 0x00196A0C
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600AFEC RID: 45036 RVA: 0x00198834 File Offset: 0x00196A34
		// (set) Token: 0x0600AFED RID: 45037 RVA: 0x001988B0 File Offset: 0x00196AB0
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600AFEE RID: 45038 RVA: 0x001988D8 File Offset: 0x00196AD8
		// (set) Token: 0x0600AFEF RID: 45039 RVA: 0x00198954 File Offset: 0x00196B54
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600AFF0 RID: 45040 RVA: 0x0019897C File Offset: 0x00196B7C
		// (set) Token: 0x0600AFF1 RID: 45041 RVA: 0x00198A2A File Offset: 0x00196C2A
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600AFF2 RID: 45042 RVA: 0x00198A54 File Offset: 0x00196C54
		// (set) Token: 0x0600AFF3 RID: 45043 RVA: 0x00198B02 File Offset: 0x00196D02
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x00198B2C File Offset: 0x00196D2C
		// (set) Token: 0x0600AFF5 RID: 45045 RVA: 0x00198BDA File Offset: 0x00196DDA
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600AFF6 RID: 45046 RVA: 0x00198C04 File Offset: 0x00196E04
		// (set) Token: 0x0600AFF7 RID: 45047 RVA: 0x00198CB2 File Offset: 0x00196EB2
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600AFF8 RID: 45048 RVA: 0x00198CDC File Offset: 0x00196EDC
		// (set) Token: 0x0600AFF9 RID: 45049 RVA: 0x00198D8A File Offset: 0x00196F8A
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600AFFA RID: 45050 RVA: 0x00198DB4 File Offset: 0x00196FB4
		// (set) Token: 0x0600AFFB RID: 45051 RVA: 0x00198E01 File Offset: 0x00197001
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600AFFC RID: 45052 RVA: 0x00198E24 File Offset: 0x00197024
		// (set) Token: 0x0600AFFD RID: 45053 RVA: 0x00198E71 File Offset: 0x00197071
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600AFFE RID: 45054 RVA: 0x00198E94 File Offset: 0x00197094
		// (set) Token: 0x0600AFFF RID: 45055 RVA: 0x00198F10 File Offset: 0x00197110
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600B000 RID: 45056 RVA: 0x00198F38 File Offset: 0x00197138
		// (set) Token: 0x0600B001 RID: 45057 RVA: 0x00198F85 File Offset: 0x00197185
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600B002 RID: 45058 RVA: 0x00198FA8 File Offset: 0x001971A8
		// (set) Token: 0x0600B003 RID: 45059 RVA: 0x00198FFD File Offset: 0x001971FD
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600B004 RID: 45060 RVA: 0x00199020 File Offset: 0x00197220
		// (set) Token: 0x0600B005 RID: 45061 RVA: 0x0019909C File Offset: 0x0019729C
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600B006 RID: 45062 RVA: 0x001990C4 File Offset: 0x001972C4
		// (set) Token: 0x0600B007 RID: 45063 RVA: 0x00199140 File Offset: 0x00197340
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600B008 RID: 45064 RVA: 0x00199168 File Offset: 0x00197368
		// (set) Token: 0x0600B009 RID: 45065 RVA: 0x00199216 File Offset: 0x00197416
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x00199240 File Offset: 0x00197440
		// (set) Token: 0x0600B00B RID: 45067 RVA: 0x001992EE File Offset: 0x001974EE
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600B00C RID: 45068 RVA: 0x00199318 File Offset: 0x00197518
		// (set) Token: 0x0600B00D RID: 45069 RVA: 0x00199365 File Offset: 0x00197565
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
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600B00E RID: 45070 RVA: 0x00199388 File Offset: 0x00197588
		// (set) Token: 0x0600B00F RID: 45071 RVA: 0x00199439 File Offset: 0x00197639
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
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600B010 RID: 45072 RVA: 0x00199464 File Offset: 0x00197664
		// (set) Token: 0x0600B011 RID: 45073 RVA: 0x001994BC File Offset: 0x001976BC
		public virtual EVisualNovelOptionInteractionType? OptionInteractionType
		{
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.OptionInteractionType;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionInteractionType;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionInteractionType;
			}
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().OptionInteractionType = value;
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600B012 RID: 45074 RVA: 0x001994E0 File Offset: 0x001976E0
		// (set) Token: 0x0600B013 RID: 45075 RVA: 0x0019955F File Offset: 0x0019775F
		public virtual IVisualNovelOptionGroupSolarSchoolExam OptionGroup
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface.OptionGroup;
				}
				if (this._OptionGroupInited)
				{
					return this._OptionGroupCache;
				}
				this._OptionGroupInited = true;
				if (this.FbInstance != null)
				{
					this._OptionGroupCache = IVisualNovelOptionGroupSolarSchoolExam.Create(this.FbInstance.OptionGroup);
				}
				else
				{
					ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
					this._OptionGroupCache = ((pocoInterface != null) ? pocoInterface.OptionGroup : null);
				}
				return this._OptionGroupCache;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco().OptionGroup = value;
				this._OptionGroupInited = false;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600B014 RID: 45076 RVA: 0x0019958C File Offset: 0x0019778C
		// (set) Token: 0x0600B015 RID: 45077 RVA: 0x001995DC File Offset: 0x001977DC
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			get
			{
				if ((this._SetMark & 34359738368UL) != 0UL)
				{
					return this.PocoInterface.VisualNovelBackgroundConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualNovelBackgroundConfig;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisualNovelBackgroundConfig;
			}
			set
			{
				this._SetMark |= 34359738368UL;
				this.GetOrCreatePoco().VisualNovelBackgroundConfig = value;
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600B016 RID: 45078 RVA: 0x00199600 File Offset: 0x00197800
		// (set) Token: 0x0600B017 RID: 45079 RVA: 0x00199650 File Offset: 0x00197850
		public virtual IVisualNovelCgBase CgConfig
		{
			get
			{
				if ((this._SetMark & 68719476736UL) != 0UL)
				{
					return this.PocoInterface.CgConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.CgConfig;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CgConfig;
			}
			set
			{
				this._SetMark |= 68719476736UL;
				this.GetOrCreatePoco().CgConfig = value;
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600B018 RID: 45080 RVA: 0x00199674 File Offset: 0x00197874
		// (set) Token: 0x0600B019 RID: 45081 RVA: 0x001996C4 File Offset: 0x001978C4
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			get
			{
				if ((this._SetMark & 137438953472UL) != 0UL)
				{
					return this.PocoInterface.DisplayItemConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayItemConfig;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayItemConfig;
			}
			set
			{
				this._SetMark |= 137438953472UL;
				this.GetOrCreatePoco().DisplayItemConfig = value;
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600B01A RID: 45082 RVA: 0x001996E8 File Offset: 0x001978E8
		// (set) Token: 0x0600B01B RID: 45083 RVA: 0x00199740 File Offset: 0x00197940
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this._SetMark & 274877906944UL) != 0UL)
				{
					return this.PocoInterface.PlotKeyId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotKeyId;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotKeyId;
			}
			set
			{
				this._SetMark |= 274877906944UL;
				this.GetOrCreatePoco().PlotKeyId = value;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600B01C RID: 45084 RVA: 0x00199764 File Offset: 0x00197964
		// (set) Token: 0x0600B01D RID: 45085 RVA: 0x001997B4 File Offset: 0x001979B4
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
				if ((this._SetMark & 549755813888UL) != 0UL)
				{
					return this.PocoInterface.StartPerformances;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartPerformances;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartPerformances;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 549755813888UL;
				this.GetOrCreatePoco().StartPerformances = value;
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600B01E RID: 45086 RVA: 0x001997D8 File Offset: 0x001979D8
		// (set) Token: 0x0600B01F RID: 45087 RVA: 0x00199828 File Offset: 0x00197A28
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
				if ((this._SetMark & 1099511627776UL) != 0UL)
				{
					return this.PocoInterface.EndPerformances;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPerformances;
				}
				ITalkItemVisualNovelNoTextItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndPerformances;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._SetMark |= 1099511627776UL;
				this.GetOrCreatePoco().EndPerformances = value;
			}
		}

		// Token: 0x04006A0E RID: 27150
		protected new ITalkItemVisualNovelNoTextItem FbInstance;

		// Token: 0x04006A0F RID: 27151
		protected new ITalkItemVisualNovelNoTextItem_SetValue PocoInterface;

		// Token: 0x04006A10 RID: 27152
		private ulong _SetMark;

		// Token: 0x04006A11 RID: 27153
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006A12 RID: 27154
		private bool _CaptionParamsInited;

		// Token: 0x04006A13 RID: 27155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006A14 RID: 27156
		private bool _ActionsInited;

		// Token: 0x04006A15 RID: 27157
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006A16 RID: 27158
		private bool _OptionsInited;

		// Token: 0x04006A17 RID: 27159
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x04006A18 RID: 27160
		private bool _MontageInited;

		// Token: 0x04006A19 RID: 27161
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006A1A RID: 27162
		private bool _CameraDataInited;

		// Token: 0x04006A1B RID: 27163
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006A1C RID: 27164
		private bool _FlowTemplateInited;

		// Token: 0x04006A1D RID: 27165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006A1E RID: 27166
		private bool _FlowTemplateListInited;

		// Token: 0x04006A1F RID: 27167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006A20 RID: 27168
		private bool _ActorMontageArrayInited;

		// Token: 0x04006A21 RID: 27169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006A22 RID: 27170
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006A23 RID: 27171
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006A24 RID: 27172
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006A25 RID: 27173
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006A26 RID: 27174
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006A27 RID: 27175
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006A28 RID: 27176
		private bool _UniversalToneInited;

		// Token: 0x04006A29 RID: 27177
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006A2A RID: 27178
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006A2B RID: 27179
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006A2C RID: 27180
		private bool _GamepadShakeInited;

		// Token: 0x04006A2D RID: 27181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006A2E RID: 27182
		private bool _IntroActionsInited;

		// Token: 0x04006A2F RID: 27183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006A30 RID: 27184
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006A31 RID: 27185
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006A32 RID: 27186
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006A33 RID: 27187
		[Nullable(1)]
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x04006A34 RID: 27188
		private bool _OptionGroupInited;
	}
}
