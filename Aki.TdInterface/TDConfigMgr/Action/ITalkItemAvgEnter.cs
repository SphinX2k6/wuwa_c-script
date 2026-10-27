using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F32 RID: 7986
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgEnter : ITalkItem
	{
		// Token: 0x0600AB3A RID: 43834 RVA: 0x00182EE4 File Offset: 0x001810E4
		[NullableContext(1)]
		private ITalkItemAvgEnter_SetValue GetOrCreatePoco()
		{
			ITalkItemAvgEnter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAvgEnter_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x00182F09 File Offset: 0x00181109
		[NullableContext(1)]
		public static ITalkItemAvgEnter Create([Nullable(2)] ITalkItemAvgEnter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgEnter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x00182F1C File Offset: 0x0018111C
		[NullableContext(1)]
		public static ITalkItemAvgEnter CreateFromSetValue([Nullable(2)] ITalkItemAvgEnter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemAvgEnter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x00182F30 File Offset: 0x00181130
		[NullableContext(1)]
		public new ITalkItemAvgEnter_SetValue ToSetValue()
		{
			return new ITalkItemAvgEnter_SetValue
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

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x001830E8 File Offset: 0x001812E8
		// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x00183139 File Offset: 0x00181339
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x00183158 File Offset: 0x00181358
		// (set) Token: 0x0600AB41 RID: 43841 RVA: 0x001831A5 File Offset: 0x001813A5
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

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600AB42 RID: 43842 RVA: 0x001831C4 File Offset: 0x001813C4
		// (set) Token: 0x0600AB43 RID: 43843 RVA: 0x00183215 File Offset: 0x00181415
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x00183232 File Offset: 0x00181432
		// (set) Token: 0x0600AB45 RID: 43845 RVA: 0x00183270 File Offset: 0x00181470
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x00183290 File Offset: 0x00181490
		// (set) Token: 0x0600AB47 RID: 43847 RVA: 0x001832DE File Offset: 0x001814DE
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

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x001832FC File Offset: 0x001814FC
		// (set) Token: 0x0600AB49 RID: 43849 RVA: 0x0018334E File Offset: 0x0018154E
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x0018336C File Offset: 0x0018156C
		// (set) Token: 0x0600AB4B RID: 43851 RVA: 0x001833BE File Offset: 0x001815BE
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x001833DC File Offset: 0x001815DC
		// (set) Token: 0x0600AB4D RID: 43853 RVA: 0x00183431 File Offset: 0x00181631
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x00183454 File Offset: 0x00181654
		// (set) Token: 0x0600AB4F RID: 43855 RVA: 0x001834A9 File Offset: 0x001816A9
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600AB50 RID: 43856 RVA: 0x001834CC File Offset: 0x001816CC
		// (set) Token: 0x0600AB51 RID: 43857 RVA: 0x00183519 File Offset: 0x00181719
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x0018353C File Offset: 0x0018173C
		// (set) Token: 0x0600AB53 RID: 43859 RVA: 0x00183591 File Offset: 0x00181791
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x001835B4 File Offset: 0x001817B4
		// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x00183630 File Offset: 0x00181830
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x00183658 File Offset: 0x00181858
		// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x00183706 File Offset: 0x00181906
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x00183730 File Offset: 0x00181930
		// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x001837DE File Offset: 0x001819DE
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x00183808 File Offset: 0x00181A08
		// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x00183884 File Offset: 0x00181A84
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x001838AC File Offset: 0x00181AAC
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x00183928 File Offset: 0x00181B28
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x00183950 File Offset: 0x00181B50
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x001839CC File Offset: 0x00181BCC
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x001839F4 File Offset: 0x00181BF4
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x00183AA2 File Offset: 0x00181CA2
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x00183ACC File Offset: 0x00181CCC
		// (set) Token: 0x0600AB63 RID: 43875 RVA: 0x00183B7A File Offset: 0x00181D7A
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600AB64 RID: 43876 RVA: 0x00183BA4 File Offset: 0x00181DA4
		// (set) Token: 0x0600AB65 RID: 43877 RVA: 0x00183C52 File Offset: 0x00181E52
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x00183C7C File Offset: 0x00181E7C
		// (set) Token: 0x0600AB67 RID: 43879 RVA: 0x00183D2A File Offset: 0x00181F2A
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600AB68 RID: 43880 RVA: 0x00183D54 File Offset: 0x00181F54
		// (set) Token: 0x0600AB69 RID: 43881 RVA: 0x00183E02 File Offset: 0x00182002
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600AB6A RID: 43882 RVA: 0x00183E2C File Offset: 0x0018202C
		// (set) Token: 0x0600AB6B RID: 43883 RVA: 0x00183E79 File Offset: 0x00182079
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600AB6C RID: 43884 RVA: 0x00183E9C File Offset: 0x0018209C
		// (set) Token: 0x0600AB6D RID: 43885 RVA: 0x00183EE9 File Offset: 0x001820E9
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x00183F0C File Offset: 0x0018210C
		// (set) Token: 0x0600AB6F RID: 43887 RVA: 0x00183F88 File Offset: 0x00182188
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x00183FB0 File Offset: 0x001821B0
		// (set) Token: 0x0600AB71 RID: 43889 RVA: 0x00183FFD File Offset: 0x001821FD
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600AB72 RID: 43890 RVA: 0x00184020 File Offset: 0x00182220
		// (set) Token: 0x0600AB73 RID: 43891 RVA: 0x00184075 File Offset: 0x00182275
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x00184098 File Offset: 0x00182298
		// (set) Token: 0x0600AB75 RID: 43893 RVA: 0x00184114 File Offset: 0x00182314
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600AB76 RID: 43894 RVA: 0x0018413C File Offset: 0x0018233C
		// (set) Token: 0x0600AB77 RID: 43895 RVA: 0x001841B8 File Offset: 0x001823B8
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600AB78 RID: 43896 RVA: 0x001841E0 File Offset: 0x001823E0
		// (set) Token: 0x0600AB79 RID: 43897 RVA: 0x0018428E File Offset: 0x0018248E
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600AB7A RID: 43898 RVA: 0x001842B8 File Offset: 0x001824B8
		// (set) Token: 0x0600AB7B RID: 43899 RVA: 0x00184366 File Offset: 0x00182566
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600AB7C RID: 43900 RVA: 0x00184390 File Offset: 0x00182590
		// (set) Token: 0x0600AB7D RID: 43901 RVA: 0x001843DD File Offset: 0x001825DD
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
				ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600AB7E RID: 43902 RVA: 0x00184400 File Offset: 0x00182600
		// (set) Token: 0x0600AB7F RID: 43903 RVA: 0x001844B1 File Offset: 0x001826B1
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600AB80 RID: 43904 RVA: 0x001844DC File Offset: 0x001826DC
		// (set) Token: 0x0600AB81 RID: 43905 RVA: 0x0018455B File Offset: 0x0018275B
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
					ITalkItemAvgEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x00184588 File Offset: 0x00182788
		// (set) Token: 0x0600AB83 RID: 43907 RVA: 0x001845DC File Offset: 0x001827DC
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

		// Token: 0x040065E4 RID: 26084
		protected new ITalkItemAvgEnter FbInstance;

		// Token: 0x040065E5 RID: 26085
		protected new ITalkItemAvgEnter_SetValue PocoInterface;

		// Token: 0x040065E6 RID: 26086
		private ulong _SetMark;

		// Token: 0x040065E7 RID: 26087
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040065E8 RID: 26088
		private bool _CaptionParamsInited;

		// Token: 0x040065E9 RID: 26089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040065EA RID: 26090
		private bool _ActionsInited;

		// Token: 0x040065EB RID: 26091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040065EC RID: 26092
		private bool _OptionsInited;

		// Token: 0x040065ED RID: 26093
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x040065EE RID: 26094
		private bool _MontageInited;

		// Token: 0x040065EF RID: 26095
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x040065F0 RID: 26096
		private bool _CameraDataInited;

		// Token: 0x040065F1 RID: 26097
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040065F2 RID: 26098
		private bool _FlowTemplateInited;

		// Token: 0x040065F3 RID: 26099
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040065F4 RID: 26100
		private bool _FlowTemplateListInited;

		// Token: 0x040065F5 RID: 26101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040065F6 RID: 26102
		private bool _ActorMontageArrayInited;

		// Token: 0x040065F7 RID: 26103
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040065F8 RID: 26104
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040065F9 RID: 26105
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040065FA RID: 26106
		private bool _ActorLookAtArrayInited;

		// Token: 0x040065FB RID: 26107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040065FC RID: 26108
		private bool _ActorTurnToArrayInited;

		// Token: 0x040065FD RID: 26109
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040065FE RID: 26110
		private bool _UniversalToneInited;

		// Token: 0x040065FF RID: 26111
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006600 RID: 26112
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006601 RID: 26113
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006602 RID: 26114
		private bool _GamepadShakeInited;

		// Token: 0x04006603 RID: 26115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006604 RID: 26116
		private bool _IntroActionsInited;

		// Token: 0x04006605 RID: 26117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006606 RID: 26118
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006607 RID: 26119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006608 RID: 26120
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006609 RID: 26121
		[Nullable(1)]
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x0400660A RID: 26122
		private bool _AvgRoleConfigInited;
	}
}
