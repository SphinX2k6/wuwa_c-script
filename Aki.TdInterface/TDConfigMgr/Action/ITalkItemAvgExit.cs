using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F34 RID: 7988
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgExit : ITalkItem
	{
		// Token: 0x0600AB86 RID: 43910 RVA: 0x00184610 File Offset: 0x00182810
		[NullableContext(1)]
		private ITalkItemAvgExit_SetValue GetOrCreatePoco()
		{
			ITalkItemAvgExit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAvgExit_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x00184635 File Offset: 0x00182835
		[NullableContext(1)]
		public static ITalkItemAvgExit Create([Nullable(2)] ITalkItemAvgExit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgExit
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x00184648 File Offset: 0x00182848
		[NullableContext(1)]
		public static ITalkItemAvgExit CreateFromSetValue([Nullable(2)] ITalkItemAvgExit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemAvgExit
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB89 RID: 43913 RVA: 0x0018465C File Offset: 0x0018285C
		[NullableContext(1)]
		public new ITalkItemAvgExit_SetValue ToSetValue()
		{
			return new ITalkItemAvgExit_SetValue
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
				AvgRoleConfig = this.AvgRoleConfig
			};
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x00184808 File Offset: 0x00182A08
		// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x00184859 File Offset: 0x00182A59
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x00184878 File Offset: 0x00182A78
		// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x001848C5 File Offset: 0x00182AC5
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

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x001848E4 File Offset: 0x00182AE4
		// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x00184935 File Offset: 0x00182B35
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x00184952 File Offset: 0x00182B52
		// (set) Token: 0x0600AB91 RID: 43921 RVA: 0x00184990 File Offset: 0x00182B90
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x001849B0 File Offset: 0x00182BB0
		// (set) Token: 0x0600AB93 RID: 43923 RVA: 0x001849FE File Offset: 0x00182BFE
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

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600AB94 RID: 43924 RVA: 0x00184A1C File Offset: 0x00182C1C
		// (set) Token: 0x0600AB95 RID: 43925 RVA: 0x00184A6E File Offset: 0x00182C6E
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600AB96 RID: 43926 RVA: 0x00184A8C File Offset: 0x00182C8C
		// (set) Token: 0x0600AB97 RID: 43927 RVA: 0x00184ADE File Offset: 0x00182CDE
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600AB98 RID: 43928 RVA: 0x00184AFC File Offset: 0x00182CFC
		// (set) Token: 0x0600AB99 RID: 43929 RVA: 0x00184B51 File Offset: 0x00182D51
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x00184B74 File Offset: 0x00182D74
		// (set) Token: 0x0600AB9B RID: 43931 RVA: 0x00184BC9 File Offset: 0x00182DC9
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x00184BEC File Offset: 0x00182DEC
		// (set) Token: 0x0600AB9D RID: 43933 RVA: 0x00184C39 File Offset: 0x00182E39
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600AB9E RID: 43934 RVA: 0x00184C5C File Offset: 0x00182E5C
		// (set) Token: 0x0600AB9F RID: 43935 RVA: 0x00184CB1 File Offset: 0x00182EB1
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600ABA0 RID: 43936 RVA: 0x00184CD4 File Offset: 0x00182ED4
		// (set) Token: 0x0600ABA1 RID: 43937 RVA: 0x00184D50 File Offset: 0x00182F50
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x00184D78 File Offset: 0x00182F78
		// (set) Token: 0x0600ABA3 RID: 43939 RVA: 0x00184E26 File Offset: 0x00183026
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600ABA4 RID: 43940 RVA: 0x00184E50 File Offset: 0x00183050
		// (set) Token: 0x0600ABA5 RID: 43941 RVA: 0x00184EFE File Offset: 0x001830FE
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x00184F28 File Offset: 0x00183128
		// (set) Token: 0x0600ABA7 RID: 43943 RVA: 0x00184FA4 File Offset: 0x001831A4
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600ABA8 RID: 43944 RVA: 0x00184FCC File Offset: 0x001831CC
		// (set) Token: 0x0600ABA9 RID: 43945 RVA: 0x00185048 File Offset: 0x00183248
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x00185070 File Offset: 0x00183270
		// (set) Token: 0x0600ABAB RID: 43947 RVA: 0x001850EC File Offset: 0x001832EC
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600ABAC RID: 43948 RVA: 0x00185114 File Offset: 0x00183314
		// (set) Token: 0x0600ABAD RID: 43949 RVA: 0x001851C2 File Offset: 0x001833C2
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600ABAE RID: 43950 RVA: 0x001851EC File Offset: 0x001833EC
		// (set) Token: 0x0600ABAF RID: 43951 RVA: 0x0018529A File Offset: 0x0018349A
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600ABB0 RID: 43952 RVA: 0x001852C4 File Offset: 0x001834C4
		// (set) Token: 0x0600ABB1 RID: 43953 RVA: 0x00185372 File Offset: 0x00183572
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600ABB2 RID: 43954 RVA: 0x0018539C File Offset: 0x0018359C
		// (set) Token: 0x0600ABB3 RID: 43955 RVA: 0x0018544A File Offset: 0x0018364A
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600ABB4 RID: 43956 RVA: 0x00185474 File Offset: 0x00183674
		// (set) Token: 0x0600ABB5 RID: 43957 RVA: 0x00185522 File Offset: 0x00183722
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600ABB6 RID: 43958 RVA: 0x0018554C File Offset: 0x0018374C
		// (set) Token: 0x0600ABB7 RID: 43959 RVA: 0x00185599 File Offset: 0x00183799
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600ABB8 RID: 43960 RVA: 0x001855BC File Offset: 0x001837BC
		// (set) Token: 0x0600ABB9 RID: 43961 RVA: 0x00185609 File Offset: 0x00183809
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600ABBA RID: 43962 RVA: 0x0018562C File Offset: 0x0018382C
		// (set) Token: 0x0600ABBB RID: 43963 RVA: 0x001856A8 File Offset: 0x001838A8
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600ABBC RID: 43964 RVA: 0x001856D0 File Offset: 0x001838D0
		// (set) Token: 0x0600ABBD RID: 43965 RVA: 0x0018571D File Offset: 0x0018391D
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600ABBE RID: 43966 RVA: 0x00185740 File Offset: 0x00183940
		// (set) Token: 0x0600ABBF RID: 43967 RVA: 0x00185795 File Offset: 0x00183995
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600ABC0 RID: 43968 RVA: 0x001857B8 File Offset: 0x001839B8
		// (set) Token: 0x0600ABC1 RID: 43969 RVA: 0x00185834 File Offset: 0x00183A34
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600ABC2 RID: 43970 RVA: 0x0018585C File Offset: 0x00183A5C
		// (set) Token: 0x0600ABC3 RID: 43971 RVA: 0x001858D8 File Offset: 0x00183AD8
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x00185900 File Offset: 0x00183B00
		// (set) Token: 0x0600ABC5 RID: 43973 RVA: 0x001859AE File Offset: 0x00183BAE
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x001859D8 File Offset: 0x00183BD8
		// (set) Token: 0x0600ABC7 RID: 43975 RVA: 0x00185A86 File Offset: 0x00183C86
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x00185AB0 File Offset: 0x00183CB0
		// (set) Token: 0x0600ABC9 RID: 43977 RVA: 0x00185AFD File Offset: 0x00183CFD
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
				ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600ABCA RID: 43978 RVA: 0x00185B20 File Offset: 0x00183D20
		// (set) Token: 0x0600ABCB RID: 43979 RVA: 0x00185BD1 File Offset: 0x00183DD1
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600ABCC RID: 43980 RVA: 0x00185BFC File Offset: 0x00183DFC
		// (set) Token: 0x0600ABCD RID: 43981 RVA: 0x00185C7B File Offset: 0x00183E7B
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
					ITalkItemAvgExit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400662E RID: 26158
		protected new ITalkItemAvgExit FbInstance;

		// Token: 0x0400662F RID: 26159
		protected new ITalkItemAvgExit_SetValue PocoInterface;

		// Token: 0x04006630 RID: 26160
		private ulong _SetMark;

		// Token: 0x04006631 RID: 26161
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006632 RID: 26162
		private bool _CaptionParamsInited;

		// Token: 0x04006633 RID: 26163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006634 RID: 26164
		private bool _ActionsInited;

		// Token: 0x04006635 RID: 26165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006636 RID: 26166
		private bool _OptionsInited;

		// Token: 0x04006637 RID: 26167
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x04006638 RID: 26168
		private bool _MontageInited;

		// Token: 0x04006639 RID: 26169
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x0400663A RID: 26170
		private bool _CameraDataInited;

		// Token: 0x0400663B RID: 26171
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400663C RID: 26172
		private bool _FlowTemplateInited;

		// Token: 0x0400663D RID: 26173
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400663E RID: 26174
		private bool _FlowTemplateListInited;

		// Token: 0x0400663F RID: 26175
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006640 RID: 26176
		private bool _ActorMontageArrayInited;

		// Token: 0x04006641 RID: 26177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006642 RID: 26178
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006643 RID: 26179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006644 RID: 26180
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006645 RID: 26181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006646 RID: 26182
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006647 RID: 26183
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006648 RID: 26184
		private bool _UniversalToneInited;

		// Token: 0x04006649 RID: 26185
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400664A RID: 26186
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400664B RID: 26187
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400664C RID: 26188
		private bool _GamepadShakeInited;

		// Token: 0x0400664D RID: 26189
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x0400664E RID: 26190
		private bool _IntroActionsInited;

		// Token: 0x0400664F RID: 26191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006650 RID: 26192
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006651 RID: 26193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006652 RID: 26194
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006653 RID: 26195
		[Nullable(1)]
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x04006654 RID: 26196
		private bool _AvgRoleConfigInited;
	}
}
