using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A1 RID: 8609
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelTalk : ITalkItem
	{
		// Token: 0x0600BB54 RID: 47956 RVA: 0x001B1228 File Offset: 0x001AF428
		[NullableContext(0)]
		private ITalkItemVisualNovelTalk_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelTalk_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB55 RID: 47957 RVA: 0x001B124D File Offset: 0x001AF44D
		[NullableContext(0)]
		public static ITalkItemVisualNovelTalk Create([Nullable(2)] ITalkItemVisualNovelTalk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelTalk
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x001B1260 File Offset: 0x001AF460
		[NullableContext(0)]
		public static ITalkItemVisualNovelTalk CreateFromSetValue([Nullable(2)] ITalkItemVisualNovelTalk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelTalk
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x001B1274 File Offset: 0x001AF474
		[NullableContext(0)]
		public new ITalkItemVisualNovelTalk_SetValue ToSetValue()
		{
			return new ITalkItemVisualNovelTalk_SetValue
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
				DialogDelay = this.DialogDelay,
				ClickShowFull = this.ClickShowFull,
				Interjection = this.Interjection,
				Transform = this.Transform,
				RoleConfig = this.RoleConfig,
				VisualNovelBackgroundConfig = this.VisualNovelBackgroundConfig,
				CgConfig = this.CgConfig,
				DisplayItemConfig = this.DisplayItemConfig,
				PlotKeyId = this.PlotKeyId,
				StartPerformances = this.StartPerformances,
				EndPerformances = this.EndPerformances
			};
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600BB58 RID: 47960 RVA: 0x001B14B0 File Offset: 0x001AF6B0
		// (set) Token: 0x0600BB59 RID: 47961 RVA: 0x001B1501 File Offset: 0x001AF701
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x001B1520 File Offset: 0x001AF720
		// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x001B156D File Offset: 0x001AF76D
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

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600BB5C RID: 47964 RVA: 0x001B158C File Offset: 0x001AF78C
		// (set) Token: 0x0600BB5D RID: 47965 RVA: 0x001B15DD File Offset: 0x001AF7DD
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600BB5E RID: 47966 RVA: 0x001B15FA File Offset: 0x001AF7FA
		// (set) Token: 0x0600BB5F RID: 47967 RVA: 0x001B1638 File Offset: 0x001AF838
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600BB60 RID: 47968 RVA: 0x001B1658 File Offset: 0x001AF858
		// (set) Token: 0x0600BB61 RID: 47969 RVA: 0x001B16A6 File Offset: 0x001AF8A6
		[Nullable(0)]
		public override string Name
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this._SetMark |= 16UL;
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x001B16C4 File Offset: 0x001AF8C4
		// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x001B1716 File Offset: 0x001AF916
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x001B1734 File Offset: 0x001AF934
		// (set) Token: 0x0600BB65 RID: 47973 RVA: 0x001B1786 File Offset: 0x001AF986
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x001B17A4 File Offset: 0x001AF9A4
		// (set) Token: 0x0600BB67 RID: 47975 RVA: 0x001B17F9 File Offset: 0x001AF9F9
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x001B181C File Offset: 0x001AFA1C
		// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x001B1871 File Offset: 0x001AFA71
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x001B1894 File Offset: 0x001AFA94
		// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x001B18E1 File Offset: 0x001AFAE1
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x001B1904 File Offset: 0x001AFB04
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x001B1959 File Offset: 0x001AFB59
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x001B197C File Offset: 0x001AFB7C
		// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x001B19F8 File Offset: 0x001AFBF8
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600BB70 RID: 47984 RVA: 0x001B1A20 File Offset: 0x001AFC20
		// (set) Token: 0x0600BB71 RID: 47985 RVA: 0x001B1ACE File Offset: 0x001AFCCE
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 4096UL;
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x001B1AF8 File Offset: 0x001AFCF8
		// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x001B1BA6 File Offset: 0x001AFDA6
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._OptionsCache = ((pocoInterface != null) ? pocoInterface.Options : null);
				}
				return this._OptionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 8192UL;
				this.GetOrCreatePoco().Options = value;
				this._OptionsInited = false;
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x001B1BD0 File Offset: 0x001AFDD0
		// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x001B1C4C File Offset: 0x001AFE4C
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x001B1C74 File Offset: 0x001AFE74
		// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x001B1CF0 File Offset: 0x001AFEF0
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x001B1D18 File Offset: 0x001AFF18
		// (set) Token: 0x0600BB79 RID: 47993 RVA: 0x001B1D94 File Offset: 0x001AFF94
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x001B1DBC File Offset: 0x001AFFBC
		// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x001B1E6A File Offset: 0x001B006A
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._FlowTemplateListCache = ((pocoInterface != null) ? pocoInterface.FlowTemplateList : null);
				}
				return this._FlowTemplateListCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 131072UL;
				this.GetOrCreatePoco().FlowTemplateList = value;
				this._FlowTemplateListInited = false;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x001B1E94 File Offset: 0x001B0094
		// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x001B1F42 File Offset: 0x001B0142
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActorMontageArrayCache = ((pocoInterface != null) ? pocoInterface.ActorMontageArray : null);
				}
				return this._ActorMontageArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 262144UL;
				this.GetOrCreatePoco().ActorMontageArray = value;
				this._ActorMontageArrayInited = false;
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x001B1F6C File Offset: 0x001B016C
		// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x001B201A File Offset: 0x001B021A
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActorFaceExpressionArrayCache = ((pocoInterface != null) ? pocoInterface.ActorFaceExpressionArray : null);
				}
				return this._ActorFaceExpressionArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 524288UL;
				this.GetOrCreatePoco().ActorFaceExpressionArray = value;
				this._ActorFaceExpressionArrayInited = false;
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x001B2044 File Offset: 0x001B0244
		// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x001B20F2 File Offset: 0x001B02F2
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActorLookAtArrayCache = ((pocoInterface != null) ? pocoInterface.ActorLookAtArray : null);
				}
				return this._ActorLookAtArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 1048576UL;
				this.GetOrCreatePoco().ActorLookAtArray = value;
				this._ActorLookAtArrayInited = false;
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x001B211C File Offset: 0x001B031C
		// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x001B21CA File Offset: 0x001B03CA
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActorTurnToArrayCache = ((pocoInterface != null) ? pocoInterface.ActorTurnToArray : null);
				}
				return this._ActorTurnToArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 2097152UL;
				this.GetOrCreatePoco().ActorTurnToArray = value;
				this._ActorTurnToArrayInited = false;
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x001B21F4 File Offset: 0x001B03F4
		// (set) Token: 0x0600BB85 RID: 48005 RVA: 0x001B2241 File Offset: 0x001B0441
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x001B2264 File Offset: 0x001B0464
		// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x001B22B1 File Offset: 0x001B04B1
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600BB88 RID: 48008 RVA: 0x001B22D4 File Offset: 0x001B04D4
		// (set) Token: 0x0600BB89 RID: 48009 RVA: 0x001B2350 File Offset: 0x001B0550
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x001B2378 File Offset: 0x001B0578
		// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x001B23C5 File Offset: 0x001B05C5
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x001B23E8 File Offset: 0x001B05E8
		// (set) Token: 0x0600BB8D RID: 48013 RVA: 0x001B243D File Offset: 0x001B063D
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x001B2460 File Offset: 0x001B0660
		// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x001B24DC File Offset: 0x001B06DC
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x001B2504 File Offset: 0x001B0704
		// (set) Token: 0x0600BB91 RID: 48017 RVA: 0x001B2580 File Offset: 0x001B0780
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x001B25A8 File Offset: 0x001B07A8
		// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x001B2656 File Offset: 0x001B0856
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._IntroActionsCache = ((pocoInterface != null) ? pocoInterface.IntroActions : null);
				}
				return this._IntroActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 536870912UL;
				this.GetOrCreatePoco().IntroActions = value;
				this._IntroActionsInited = false;
			}
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x001B2680 File Offset: 0x001B0880
		// (set) Token: 0x0600BB95 RID: 48021 RVA: 0x001B272E File Offset: 0x001B092E
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActorFxEmoteArrayCache = ((pocoInterface != null) ? pocoInterface.ActorFxEmoteArray : null);
				}
				return this._ActorFxEmoteArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 1073741824UL;
				this.GetOrCreatePoco().ActorFxEmoteArray = value;
				this._ActorFxEmoteArrayInited = false;
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x001B2758 File Offset: 0x001B0958
		// (set) Token: 0x0600BB97 RID: 48023 RVA: 0x001B27A5 File Offset: 0x001B09A5
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
				if ((this._SetMark & (ulong)-2147483648) != 0UL)
				{
					return this.PocoInterface.TalkEffectArray;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkEffectArray;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkEffectArray;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600BB98 RID: 48024 RVA: 0x001B27C8 File Offset: 0x001B09C8
		// (set) Token: 0x0600BB99 RID: 48025 RVA: 0x001B2879 File Offset: 0x001B0A79
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._ActorVisibilityArrayCache = ((pocoInterface != null) ? pocoInterface.ActorVisibilityArray : null);
				}
				return this._ActorVisibilityArrayCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 4294967296UL;
				this.GetOrCreatePoco().ActorVisibilityArray = value;
				this._ActorVisibilityArrayInited = false;
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x001B28A4 File Offset: 0x001B0AA4
		// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x001B28FC File Offset: 0x001B0AFC
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
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x001B2920 File Offset: 0x001B0B20
		// (set) Token: 0x0600BB9D RID: 48029 RVA: 0x001B2970 File Offset: 0x001B0B70
		public virtual IVisualNovelOptionGroupConfigBase OptionGroup
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface.OptionGroup;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionGroup;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionGroup;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco().OptionGroup = value;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x001B2994 File Offset: 0x001B0B94
		// (set) Token: 0x0600BB9F RID: 48031 RVA: 0x001B29EC File Offset: 0x001B0BEC
		public virtual float? DialogDelay
		{
			get
			{
				if ((this._SetMark & 34359738368UL) != 0UL)
				{
					return this.PocoInterface.DialogDelay;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.DialogDelay;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DialogDelay;
			}
			set
			{
				this._SetMark |= 34359738368UL;
				this.GetOrCreatePoco().DialogDelay = value;
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600BBA0 RID: 48032 RVA: 0x001B2A10 File Offset: 0x001B0C10
		// (set) Token: 0x0600BBA1 RID: 48033 RVA: 0x001B2A68 File Offset: 0x001B0C68
		public virtual bool? ClickShowFull
		{
			get
			{
				if ((this._SetMark & 68719476736UL) != 0UL)
				{
					return this.PocoInterface.ClickShowFull;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.ClickShowFull;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ClickShowFull;
			}
			set
			{
				this._SetMark |= 68719476736UL;
				this.GetOrCreatePoco().ClickShowFull = value;
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x001B2A8C File Offset: 0x001B0C8C
		// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x001B2ADC File Offset: 0x001B0CDC
		public virtual string Interjection
		{
			get
			{
				if ((this._SetMark & 137438953472UL) != 0UL)
				{
					return this.PocoInterface.Interjection;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interjection;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Interjection;
			}
			set
			{
				this._SetMark |= 137438953472UL;
				this.GetOrCreatePoco().Interjection = value;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x001B2B00 File Offset: 0x001B0D00
		// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x001B2B7F File Offset: 0x001B0D7F
		public virtual IVisualNovelPortraitTransform Transform
		{
			get
			{
				if ((this._SetMark & 274877906944UL) != 0UL)
				{
					return this.PocoInterface.Transform;
				}
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				if (this.FbInstance != null)
				{
					this._TransformCache = IVisualNovelPortraitTransform.Create(this.FbInstance.Transform);
				}
				else
				{
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._TransformCache = ((pocoInterface != null) ? pocoInterface.Transform : null);
				}
				return this._TransformCache;
			}
			set
			{
				this._SetMark |= 274877906944UL;
				this.GetOrCreatePoco().Transform = value;
				this._TransformInited = false;
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x001B2BAC File Offset: 0x001B0DAC
		// (set) Token: 0x0600BBA7 RID: 48039 RVA: 0x001B2C2B File Offset: 0x001B0E2B
		public virtual IVisualNovelRoleConfig RoleConfig
		{
			get
			{
				if ((this._SetMark & 549755813888UL) != 0UL)
				{
					return this.PocoInterface.RoleConfig;
				}
				if (this._RoleConfigInited)
				{
					return this._RoleConfigCache;
				}
				this._RoleConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RoleConfigCache = IVisualNovelRoleConfig.Create(this.FbInstance.RoleConfig);
				}
				else
				{
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
					this._RoleConfigCache = ((pocoInterface != null) ? pocoInterface.RoleConfig : null);
				}
				return this._RoleConfigCache;
			}
			set
			{
				this._SetMark |= 549755813888UL;
				this.GetOrCreatePoco().RoleConfig = value;
				this._RoleConfigInited = false;
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x001B2C58 File Offset: 0x001B0E58
		// (set) Token: 0x0600BBA9 RID: 48041 RVA: 0x001B2CA8 File Offset: 0x001B0EA8
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			get
			{
				if ((this._SetMark & 1099511627776UL) != 0UL)
				{
					return this.PocoInterface.VisualNovelBackgroundConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualNovelBackgroundConfig;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisualNovelBackgroundConfig;
			}
			set
			{
				this._SetMark |= 1099511627776UL;
				this.GetOrCreatePoco().VisualNovelBackgroundConfig = value;
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600BBAA RID: 48042 RVA: 0x001B2CCC File Offset: 0x001B0ECC
		// (set) Token: 0x0600BBAB RID: 48043 RVA: 0x001B2D1C File Offset: 0x001B0F1C
		public virtual IVisualNovelCgBase CgConfig
		{
			get
			{
				if ((this._SetMark & 2199023255552UL) != 0UL)
				{
					return this.PocoInterface.CgConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.CgConfig;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CgConfig;
			}
			set
			{
				this._SetMark |= 2199023255552UL;
				this.GetOrCreatePoco().CgConfig = value;
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600BBAC RID: 48044 RVA: 0x001B2D40 File Offset: 0x001B0F40
		// (set) Token: 0x0600BBAD RID: 48045 RVA: 0x001B2D90 File Offset: 0x001B0F90
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			get
			{
				if ((this._SetMark & 4398046511104UL) != 0UL)
				{
					return this.PocoInterface.DisplayItemConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayItemConfig;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayItemConfig;
			}
			set
			{
				this._SetMark |= 4398046511104UL;
				this.GetOrCreatePoco().DisplayItemConfig = value;
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600BBAE RID: 48046 RVA: 0x001B2DB4 File Offset: 0x001B0FB4
		// (set) Token: 0x0600BBAF RID: 48047 RVA: 0x001B2E0C File Offset: 0x001B100C
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this._SetMark & 8796093022208UL) != 0UL)
				{
					return this.PocoInterface.PlotKeyId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotKeyId;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotKeyId;
			}
			set
			{
				this._SetMark |= 8796093022208UL;
				this.GetOrCreatePoco().PlotKeyId = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x001B2E30 File Offset: 0x001B1030
		// (set) Token: 0x0600BBB1 RID: 48049 RVA: 0x001B2E80 File Offset: 0x001B1080
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IVisualNovelPerformanceBase> StartPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if ((this._SetMark & 17592186044416UL) != 0UL)
				{
					return this.PocoInterface.StartPerformances;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartPerformances;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartPerformances;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 17592186044416UL;
				this.GetOrCreatePoco().StartPerformances = value;
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600BBB2 RID: 48050 RVA: 0x001B2EA4 File Offset: 0x001B10A4
		// (set) Token: 0x0600BBB3 RID: 48051 RVA: 0x001B2EF4 File Offset: 0x001B10F4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IVisualNovelPerformanceBase> EndPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if ((this._SetMark & 35184372088832UL) != 0UL)
				{
					return this.PocoInterface.EndPerformances;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPerformances;
				}
				ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndPerformances;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this._SetMark |= 35184372088832UL;
				this.GetOrCreatePoco().EndPerformances = value;
			}
		}

		// Token: 0x04007098 RID: 28824
		protected new ITalkItemVisualNovelTalk FbInstance;

		// Token: 0x04007099 RID: 28825
		protected new ITalkItemVisualNovelTalk_SetValue PocoInterface;

		// Token: 0x0400709A RID: 28826
		private ulong _SetMark;

		// Token: 0x0400709B RID: 28827
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x0400709C RID: 28828
		private bool _CaptionParamsInited;

		// Token: 0x0400709D RID: 28829
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400709E RID: 28830
		private bool _ActionsInited;

		// Token: 0x0400709F RID: 28831
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040070A0 RID: 28832
		private bool _OptionsInited;

		// Token: 0x040070A1 RID: 28833
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x040070A2 RID: 28834
		private bool _MontageInited;

		// Token: 0x040070A3 RID: 28835
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x040070A4 RID: 28836
		private bool _CameraDataInited;

		// Token: 0x040070A5 RID: 28837
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040070A6 RID: 28838
		private bool _FlowTemplateInited;

		// Token: 0x040070A7 RID: 28839
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040070A8 RID: 28840
		private bool _FlowTemplateListInited;

		// Token: 0x040070A9 RID: 28841
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040070AA RID: 28842
		private bool _ActorMontageArrayInited;

		// Token: 0x040070AB RID: 28843
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040070AC RID: 28844
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040070AD RID: 28845
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040070AE RID: 28846
		private bool _ActorLookAtArrayInited;

		// Token: 0x040070AF RID: 28847
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040070B0 RID: 28848
		private bool _ActorTurnToArrayInited;

		// Token: 0x040070B1 RID: 28849
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040070B2 RID: 28850
		private bool _UniversalToneInited;

		// Token: 0x040070B3 RID: 28851
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040070B4 RID: 28852
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040070B5 RID: 28853
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040070B6 RID: 28854
		private bool _GamepadShakeInited;

		// Token: 0x040070B7 RID: 28855
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040070B8 RID: 28856
		private bool _IntroActionsInited;

		// Token: 0x040070B9 RID: 28857
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040070BA RID: 28858
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040070BB RID: 28859
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040070BC RID: 28860
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040070BD RID: 28861
		[Nullable(0)]
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x040070BE RID: 28862
		private bool _TransformInited;

		// Token: 0x040070BF RID: 28863
		[Nullable(0)]
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x040070C0 RID: 28864
		private bool _RoleConfigInited;
	}
}
