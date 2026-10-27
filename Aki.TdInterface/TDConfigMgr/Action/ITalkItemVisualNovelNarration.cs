using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F60 RID: 8032
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNarration : ITalkItem
	{
		// Token: 0x0600AF6E RID: 44910 RVA: 0x001962DC File Offset: 0x001944DC
		[NullableContext(1)]
		private ITalkItemVisualNovelNarration_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelNarration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelNarration_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF6F RID: 44911 RVA: 0x00196301 File Offset: 0x00194501
		[NullableContext(1)]
		public static ITalkItemVisualNovelNarration Create([Nullable(2)] ITalkItemVisualNovelNarration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNarration
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x00196314 File Offset: 0x00194514
		[NullableContext(1)]
		public static ITalkItemVisualNovelNarration CreateFromSetValue([Nullable(2)] ITalkItemVisualNovelNarration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelNarration
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF71 RID: 44913 RVA: 0x00196328 File Offset: 0x00194528
		[NullableContext(1)]
		public new ITalkItemVisualNovelNarration_SetValue ToSetValue()
		{
			return new ITalkItemVisualNovelNarration_SetValue
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
				VisualNovelBackgroundConfig = this.VisualNovelBackgroundConfig,
				CgConfig = this.CgConfig,
				DisplayItemConfig = this.DisplayItemConfig,
				PlotKeyId = this.PlotKeyId,
				StartPerformances = this.StartPerformances,
				EndPerformances = this.EndPerformances
			};
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600AF72 RID: 44914 RVA: 0x00196540 File Offset: 0x00194740
		// (set) Token: 0x0600AF73 RID: 44915 RVA: 0x00196591 File Offset: 0x00194791
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600AF74 RID: 44916 RVA: 0x001965B0 File Offset: 0x001947B0
		// (set) Token: 0x0600AF75 RID: 44917 RVA: 0x001965FD File Offset: 0x001947FD
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

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x0019661C File Offset: 0x0019481C
		// (set) Token: 0x0600AF77 RID: 44919 RVA: 0x0019666D File Offset: 0x0019486D
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600AF78 RID: 44920 RVA: 0x0019668A File Offset: 0x0019488A
		// (set) Token: 0x0600AF79 RID: 44921 RVA: 0x001966C8 File Offset: 0x001948C8
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x001966E8 File Offset: 0x001948E8
		// (set) Token: 0x0600AF7B RID: 44923 RVA: 0x00196736 File Offset: 0x00194936
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

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x00196754 File Offset: 0x00194954
		// (set) Token: 0x0600AF7D RID: 44925 RVA: 0x001967A6 File Offset: 0x001949A6
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x001967C4 File Offset: 0x001949C4
		// (set) Token: 0x0600AF7F RID: 44927 RVA: 0x00196816 File Offset: 0x00194A16
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600AF80 RID: 44928 RVA: 0x00196834 File Offset: 0x00194A34
		// (set) Token: 0x0600AF81 RID: 44929 RVA: 0x00196889 File Offset: 0x00194A89
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x001968AC File Offset: 0x00194AAC
		// (set) Token: 0x0600AF83 RID: 44931 RVA: 0x00196901 File Offset: 0x00194B01
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x00196924 File Offset: 0x00194B24
		// (set) Token: 0x0600AF85 RID: 44933 RVA: 0x00196971 File Offset: 0x00194B71
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x00196994 File Offset: 0x00194B94
		// (set) Token: 0x0600AF87 RID: 44935 RVA: 0x001969E9 File Offset: 0x00194BE9
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x00196A0C File Offset: 0x00194C0C
		// (set) Token: 0x0600AF89 RID: 44937 RVA: 0x00196A88 File Offset: 0x00194C88
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600AF8A RID: 44938 RVA: 0x00196AB0 File Offset: 0x00194CB0
		// (set) Token: 0x0600AF8B RID: 44939 RVA: 0x00196B5E File Offset: 0x00194D5E
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600AF8C RID: 44940 RVA: 0x00196B88 File Offset: 0x00194D88
		// (set) Token: 0x0600AF8D RID: 44941 RVA: 0x00196C36 File Offset: 0x00194E36
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600AF8E RID: 44942 RVA: 0x00196C60 File Offset: 0x00194E60
		// (set) Token: 0x0600AF8F RID: 44943 RVA: 0x00196CDC File Offset: 0x00194EDC
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600AF90 RID: 44944 RVA: 0x00196D04 File Offset: 0x00194F04
		// (set) Token: 0x0600AF91 RID: 44945 RVA: 0x00196D80 File Offset: 0x00194F80
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600AF92 RID: 44946 RVA: 0x00196DA8 File Offset: 0x00194FA8
		// (set) Token: 0x0600AF93 RID: 44947 RVA: 0x00196E24 File Offset: 0x00195024
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600AF94 RID: 44948 RVA: 0x00196E4C File Offset: 0x0019504C
		// (set) Token: 0x0600AF95 RID: 44949 RVA: 0x00196EFA File Offset: 0x001950FA
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600AF96 RID: 44950 RVA: 0x00196F24 File Offset: 0x00195124
		// (set) Token: 0x0600AF97 RID: 44951 RVA: 0x00196FD2 File Offset: 0x001951D2
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600AF98 RID: 44952 RVA: 0x00196FFC File Offset: 0x001951FC
		// (set) Token: 0x0600AF99 RID: 44953 RVA: 0x001970AA File Offset: 0x001952AA
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600AF9A RID: 44954 RVA: 0x001970D4 File Offset: 0x001952D4
		// (set) Token: 0x0600AF9B RID: 44955 RVA: 0x00197182 File Offset: 0x00195382
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600AF9C RID: 44956 RVA: 0x001971AC File Offset: 0x001953AC
		// (set) Token: 0x0600AF9D RID: 44957 RVA: 0x0019725A File Offset: 0x0019545A
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x00197284 File Offset: 0x00195484
		// (set) Token: 0x0600AF9F RID: 44959 RVA: 0x001972D1 File Offset: 0x001954D1
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600AFA0 RID: 44960 RVA: 0x001972F4 File Offset: 0x001954F4
		// (set) Token: 0x0600AFA1 RID: 44961 RVA: 0x00197341 File Offset: 0x00195541
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600AFA2 RID: 44962 RVA: 0x00197364 File Offset: 0x00195564
		// (set) Token: 0x0600AFA3 RID: 44963 RVA: 0x001973E0 File Offset: 0x001955E0
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600AFA4 RID: 44964 RVA: 0x00197408 File Offset: 0x00195608
		// (set) Token: 0x0600AFA5 RID: 44965 RVA: 0x00197455 File Offset: 0x00195655
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x00197478 File Offset: 0x00195678
		// (set) Token: 0x0600AFA7 RID: 44967 RVA: 0x001974CD File Offset: 0x001956CD
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600AFA8 RID: 44968 RVA: 0x001974F0 File Offset: 0x001956F0
		// (set) Token: 0x0600AFA9 RID: 44969 RVA: 0x0019756C File Offset: 0x0019576C
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x00197594 File Offset: 0x00195794
		// (set) Token: 0x0600AFAB RID: 44971 RVA: 0x00197610 File Offset: 0x00195810
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x00197638 File Offset: 0x00195838
		// (set) Token: 0x0600AFAD RID: 44973 RVA: 0x001976E6 File Offset: 0x001958E6
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x00197710 File Offset: 0x00195910
		// (set) Token: 0x0600AFAF RID: 44975 RVA: 0x001977BE File Offset: 0x001959BE
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x001977E8 File Offset: 0x001959E8
		// (set) Token: 0x0600AFB1 RID: 44977 RVA: 0x00197835 File Offset: 0x00195A35
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x00197858 File Offset: 0x00195A58
		// (set) Token: 0x0600AFB3 RID: 44979 RVA: 0x00197909 File Offset: 0x00195B09
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x00197934 File Offset: 0x00195B34
		// (set) Token: 0x0600AFB5 RID: 44981 RVA: 0x0019798C File Offset: 0x00195B8C
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600AFB6 RID: 44982 RVA: 0x001979B0 File Offset: 0x00195BB0
		// (set) Token: 0x0600AFB7 RID: 44983 RVA: 0x00197A2F File Offset: 0x00195C2F
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600AFB8 RID: 44984 RVA: 0x00197A5C File Offset: 0x00195C5C
		// (set) Token: 0x0600AFB9 RID: 44985 RVA: 0x00197AB4 File Offset: 0x00195CB4
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600AFBA RID: 44986 RVA: 0x00197AD8 File Offset: 0x00195CD8
		// (set) Token: 0x0600AFBB RID: 44987 RVA: 0x00197B30 File Offset: 0x00195D30
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600AFBC RID: 44988 RVA: 0x00197B54 File Offset: 0x00195D54
		// (set) Token: 0x0600AFBD RID: 44989 RVA: 0x00197BA4 File Offset: 0x00195DA4
		public virtual IVisualNovelBackgroundBase VisualNovelBackgroundConfig
		{
			get
			{
				if ((this._SetMark & 137438953472UL) != 0UL)
				{
					return this.PocoInterface.VisualNovelBackgroundConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualNovelBackgroundConfig;
				}
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisualNovelBackgroundConfig;
			}
			set
			{
				this._SetMark |= 137438953472UL;
				this.GetOrCreatePoco().VisualNovelBackgroundConfig = value;
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600AFBE RID: 44990 RVA: 0x00197BC8 File Offset: 0x00195DC8
		// (set) Token: 0x0600AFBF RID: 44991 RVA: 0x00197C18 File Offset: 0x00195E18
		public virtual IVisualNovelCgBase CgConfig
		{
			get
			{
				if ((this._SetMark & 274877906944UL) != 0UL)
				{
					return this.PocoInterface.CgConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.CgConfig;
				}
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CgConfig;
			}
			set
			{
				this._SetMark |= 274877906944UL;
				this.GetOrCreatePoco().CgConfig = value;
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x00197C3C File Offset: 0x00195E3C
		// (set) Token: 0x0600AFC1 RID: 44993 RVA: 0x00197C8C File Offset: 0x00195E8C
		public virtual IVisualNovelDisplayItemBase DisplayItemConfig
		{
			get
			{
				if ((this._SetMark & 549755813888UL) != 0UL)
				{
					return this.PocoInterface.DisplayItemConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayItemConfig;
				}
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayItemConfig;
			}
			set
			{
				this._SetMark |= 549755813888UL;
				this.GetOrCreatePoco().DisplayItemConfig = value;
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x00197CB0 File Offset: 0x00195EB0
		// (set) Token: 0x0600AFC3 RID: 44995 RVA: 0x00197D08 File Offset: 0x00195F08
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this._SetMark & 1099511627776UL) != 0UL)
				{
					return this.PocoInterface.PlotKeyId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotKeyId;
				}
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotKeyId;
			}
			set
			{
				this._SetMark |= 1099511627776UL;
				this.GetOrCreatePoco().PlotKeyId = value;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600AFC4 RID: 44996 RVA: 0x00197D2C File Offset: 0x00195F2C
		// (set) Token: 0x0600AFC5 RID: 44997 RVA: 0x00197D7C File Offset: 0x00195F7C
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
				if ((this._SetMark & 2199023255552UL) != 0UL)
				{
					return this.PocoInterface.StartPerformances;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartPerformances;
				}
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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
				this._SetMark |= 2199023255552UL;
				this.GetOrCreatePoco().StartPerformances = value;
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600AFC6 RID: 44998 RVA: 0x00197DA0 File Offset: 0x00195FA0
		// (set) Token: 0x0600AFC7 RID: 44999 RVA: 0x00197DF0 File Offset: 0x00195FF0
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
				if ((this._SetMark & 4398046511104UL) != 0UL)
				{
					return this.PocoInterface.EndPerformances;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPerformances;
				}
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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
				this._SetMark |= 4398046511104UL;
				this.GetOrCreatePoco().EndPerformances = value;
			}
		}

		// Token: 0x040069BC RID: 27068
		protected new ITalkItemVisualNovelNarration FbInstance;

		// Token: 0x040069BD RID: 27069
		protected new ITalkItemVisualNovelNarration_SetValue PocoInterface;

		// Token: 0x040069BE RID: 27070
		private ulong _SetMark;

		// Token: 0x040069BF RID: 27071
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040069C0 RID: 27072
		private bool _CaptionParamsInited;

		// Token: 0x040069C1 RID: 27073
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040069C2 RID: 27074
		private bool _ActionsInited;

		// Token: 0x040069C3 RID: 27075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040069C4 RID: 27076
		private bool _OptionsInited;

		// Token: 0x040069C5 RID: 27077
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x040069C6 RID: 27078
		private bool _MontageInited;

		// Token: 0x040069C7 RID: 27079
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x040069C8 RID: 27080
		private bool _CameraDataInited;

		// Token: 0x040069C9 RID: 27081
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040069CA RID: 27082
		private bool _FlowTemplateInited;

		// Token: 0x040069CB RID: 27083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040069CC RID: 27084
		private bool _FlowTemplateListInited;

		// Token: 0x040069CD RID: 27085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040069CE RID: 27086
		private bool _ActorMontageArrayInited;

		// Token: 0x040069CF RID: 27087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040069D0 RID: 27088
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040069D1 RID: 27089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040069D2 RID: 27090
		private bool _ActorLookAtArrayInited;

		// Token: 0x040069D3 RID: 27091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040069D4 RID: 27092
		private bool _ActorTurnToArrayInited;

		// Token: 0x040069D5 RID: 27093
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040069D6 RID: 27094
		private bool _UniversalToneInited;

		// Token: 0x040069D7 RID: 27095
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040069D8 RID: 27096
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040069D9 RID: 27097
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040069DA RID: 27098
		private bool _GamepadShakeInited;

		// Token: 0x040069DB RID: 27099
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040069DC RID: 27100
		private bool _IntroActionsInited;

		// Token: 0x040069DD RID: 27101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040069DE RID: 27102
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040069DF RID: 27103
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040069E0 RID: 27104
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040069E1 RID: 27105
		[Nullable(1)]
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x040069E2 RID: 27106
		private bool _OptionGroupInited;
	}
}
