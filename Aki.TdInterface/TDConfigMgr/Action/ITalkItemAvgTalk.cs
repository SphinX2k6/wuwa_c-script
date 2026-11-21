using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002175 RID: 8565
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgTalk : ITalkItem
	{
		// Token: 0x0600B73E RID: 46910 RVA: 0x0019E9F8 File Offset: 0x0019CBF8
		[NullableContext(0)]
		private ITalkItemAvgTalk_SetValue GetOrCreatePoco()
		{
			ITalkItemAvgTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAvgTalk_SetValue());
			}
			return result;
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x0019EA1D File Offset: 0x0019CC1D
		[NullableContext(0)]
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

		// Token: 0x0600B740 RID: 46912 RVA: 0x0019EA30 File Offset: 0x0019CC30
		[NullableContext(0)]
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

		// Token: 0x0600B741 RID: 46913 RVA: 0x0019EA44 File Offset: 0x0019CC44
		[NullableContext(0)]
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

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600B742 RID: 46914 RVA: 0x0019EBFC File Offset: 0x0019CDFC
		// (set) Token: 0x0600B743 RID: 46915 RVA: 0x0019EC4D File Offset: 0x0019CE4D
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

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600B744 RID: 46916 RVA: 0x0019EC6C File Offset: 0x0019CE6C
		// (set) Token: 0x0600B745 RID: 46917 RVA: 0x0019ECB9 File Offset: 0x0019CEB9
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

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600B746 RID: 46918 RVA: 0x0019ECD8 File Offset: 0x0019CED8
		// (set) Token: 0x0600B747 RID: 46919 RVA: 0x0019ED29 File Offset: 0x0019CF29
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

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600B748 RID: 46920 RVA: 0x0019ED46 File Offset: 0x0019CF46
		// (set) Token: 0x0600B749 RID: 46921 RVA: 0x0019ED84 File Offset: 0x0019CF84
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

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600B74A RID: 46922 RVA: 0x0019EDA4 File Offset: 0x0019CFA4
		// (set) Token: 0x0600B74B RID: 46923 RVA: 0x0019EDF2 File Offset: 0x0019CFF2
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

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600B74C RID: 46924 RVA: 0x0019EE10 File Offset: 0x0019D010
		// (set) Token: 0x0600B74D RID: 46925 RVA: 0x0019EE62 File Offset: 0x0019D062
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

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x0019EE80 File Offset: 0x0019D080
		// (set) Token: 0x0600B74F RID: 46927 RVA: 0x0019EED2 File Offset: 0x0019D0D2
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

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x0019EEF0 File Offset: 0x0019D0F0
		// (set) Token: 0x0600B751 RID: 46929 RVA: 0x0019EF45 File Offset: 0x0019D145
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

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600B752 RID: 46930 RVA: 0x0019EF68 File Offset: 0x0019D168
		// (set) Token: 0x0600B753 RID: 46931 RVA: 0x0019EFBD File Offset: 0x0019D1BD
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

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600B754 RID: 46932 RVA: 0x0019EFE0 File Offset: 0x0019D1E0
		// (set) Token: 0x0600B755 RID: 46933 RVA: 0x0019F02D File Offset: 0x0019D22D
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

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600B756 RID: 46934 RVA: 0x0019F050 File Offset: 0x0019D250
		// (set) Token: 0x0600B757 RID: 46935 RVA: 0x0019F0A5 File Offset: 0x0019D2A5
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

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600B758 RID: 46936 RVA: 0x0019F0C8 File Offset: 0x0019D2C8
		// (set) Token: 0x0600B759 RID: 46937 RVA: 0x0019F144 File Offset: 0x0019D344
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

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600B75A RID: 46938 RVA: 0x0019F16C File Offset: 0x0019D36C
		// (set) Token: 0x0600B75B RID: 46939 RVA: 0x0019F21A File Offset: 0x0019D41A
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600B75C RID: 46940 RVA: 0x0019F244 File Offset: 0x0019D444
		// (set) Token: 0x0600B75D RID: 46941 RVA: 0x0019F2F2 File Offset: 0x0019D4F2
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600B75E RID: 46942 RVA: 0x0019F31C File Offset: 0x0019D51C
		// (set) Token: 0x0600B75F RID: 46943 RVA: 0x0019F398 File Offset: 0x0019D598
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

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x0019F3C0 File Offset: 0x0019D5C0
		// (set) Token: 0x0600B761 RID: 46945 RVA: 0x0019F43C File Offset: 0x0019D63C
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

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600B762 RID: 46946 RVA: 0x0019F464 File Offset: 0x0019D664
		// (set) Token: 0x0600B763 RID: 46947 RVA: 0x0019F4E0 File Offset: 0x0019D6E0
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

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x0019F508 File Offset: 0x0019D708
		// (set) Token: 0x0600B765 RID: 46949 RVA: 0x0019F5B6 File Offset: 0x0019D7B6
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x0019F5E0 File Offset: 0x0019D7E0
		// (set) Token: 0x0600B767 RID: 46951 RVA: 0x0019F68E File Offset: 0x0019D88E
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x0019F6B8 File Offset: 0x0019D8B8
		// (set) Token: 0x0600B769 RID: 46953 RVA: 0x0019F766 File Offset: 0x0019D966
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600B76A RID: 46954 RVA: 0x0019F790 File Offset: 0x0019D990
		// (set) Token: 0x0600B76B RID: 46955 RVA: 0x0019F83E File Offset: 0x0019DA3E
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600B76C RID: 46956 RVA: 0x0019F868 File Offset: 0x0019DA68
		// (set) Token: 0x0600B76D RID: 46957 RVA: 0x0019F916 File Offset: 0x0019DB16
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600B76E RID: 46958 RVA: 0x0019F940 File Offset: 0x0019DB40
		// (set) Token: 0x0600B76F RID: 46959 RVA: 0x0019F98D File Offset: 0x0019DB8D
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

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600B770 RID: 46960 RVA: 0x0019F9B0 File Offset: 0x0019DBB0
		// (set) Token: 0x0600B771 RID: 46961 RVA: 0x0019F9FD File Offset: 0x0019DBFD
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

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x0019FA20 File Offset: 0x0019DC20
		// (set) Token: 0x0600B773 RID: 46963 RVA: 0x0019FA9C File Offset: 0x0019DC9C
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

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600B774 RID: 46964 RVA: 0x0019FAC4 File Offset: 0x0019DCC4
		// (set) Token: 0x0600B775 RID: 46965 RVA: 0x0019FB11 File Offset: 0x0019DD11
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

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600B776 RID: 46966 RVA: 0x0019FB34 File Offset: 0x0019DD34
		// (set) Token: 0x0600B777 RID: 46967 RVA: 0x0019FB89 File Offset: 0x0019DD89
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

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600B778 RID: 46968 RVA: 0x0019FBAC File Offset: 0x0019DDAC
		// (set) Token: 0x0600B779 RID: 46969 RVA: 0x0019FC28 File Offset: 0x0019DE28
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

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600B77A RID: 46970 RVA: 0x0019FC50 File Offset: 0x0019DE50
		// (set) Token: 0x0600B77B RID: 46971 RVA: 0x0019FCCC File Offset: 0x0019DECC
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

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600B77C RID: 46972 RVA: 0x0019FCF4 File Offset: 0x0019DEF4
		// (set) Token: 0x0600B77D RID: 46973 RVA: 0x0019FDA2 File Offset: 0x0019DFA2
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600B77E RID: 46974 RVA: 0x0019FDCC File Offset: 0x0019DFCC
		// (set) Token: 0x0600B77F RID: 46975 RVA: 0x0019FE7A File Offset: 0x0019E07A
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600B780 RID: 46976 RVA: 0x0019FEA4 File Offset: 0x0019E0A4
		// (set) Token: 0x0600B781 RID: 46977 RVA: 0x0019FEF1 File Offset: 0x0019E0F1
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
				0
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600B782 RID: 46978 RVA: 0x0019FF14 File Offset: 0x0019E114
		// (set) Token: 0x0600B783 RID: 46979 RVA: 0x0019FFC5 File Offset: 0x0019E1C5
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
					ITalkItemAvgTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600B784 RID: 46980 RVA: 0x0019FFF0 File Offset: 0x0019E1F0
		// (set) Token: 0x0600B785 RID: 46981 RVA: 0x001A006F File Offset: 0x0019E26F
		[Nullable(0)]
		public virtual ITalkItemAvgRoleConfig AvgRoleConfig
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().AvgRoleConfig = value;
				this._AvgRoleConfigInited = false;
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600B786 RID: 46982 RVA: 0x001A009C File Offset: 0x0019E29C
		// (set) Token: 0x0600B787 RID: 46983 RVA: 0x001A00F0 File Offset: 0x0019E2F0
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

		// Token: 0x04006CF7 RID: 27895
		protected new ITalkItemAvgTalk FbInstance;

		// Token: 0x04006CF8 RID: 27896
		protected new ITalkItemAvgTalk_SetValue PocoInterface;

		// Token: 0x04006CF9 RID: 27897
		private ulong _SetMark;

		// Token: 0x04006CFA RID: 27898
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006CFB RID: 27899
		private bool _CaptionParamsInited;

		// Token: 0x04006CFC RID: 27900
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006CFD RID: 27901
		private bool _ActionsInited;

		// Token: 0x04006CFE RID: 27902
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006CFF RID: 27903
		private bool _OptionsInited;

		// Token: 0x04006D00 RID: 27904
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006D01 RID: 27905
		private bool _MontageInited;

		// Token: 0x04006D02 RID: 27906
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006D03 RID: 27907
		private bool _CameraDataInited;

		// Token: 0x04006D04 RID: 27908
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006D05 RID: 27909
		private bool _FlowTemplateInited;

		// Token: 0x04006D06 RID: 27910
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006D07 RID: 27911
		private bool _FlowTemplateListInited;

		// Token: 0x04006D08 RID: 27912
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006D09 RID: 27913
		private bool _ActorMontageArrayInited;

		// Token: 0x04006D0A RID: 27914
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006D0B RID: 27915
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006D0C RID: 27916
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006D0D RID: 27917
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006D0E RID: 27918
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006D0F RID: 27919
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006D10 RID: 27920
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006D11 RID: 27921
		private bool _UniversalToneInited;

		// Token: 0x04006D12 RID: 27922
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006D13 RID: 27923
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006D14 RID: 27924
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006D15 RID: 27925
		private bool _GamepadShakeInited;

		// Token: 0x04006D16 RID: 27926
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006D17 RID: 27927
		private bool _IntroActionsInited;

		// Token: 0x04006D18 RID: 27928
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006D19 RID: 27929
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006D1A RID: 27930
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006D1B RID: 27931
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006D1C RID: 27932
		[Nullable(0)]
		private ITalkItemAvgRoleConfig _AvgRoleConfigCache;

		// Token: 0x04006D1D RID: 27933
		private bool _AvgRoleConfigInited;
	}
}
