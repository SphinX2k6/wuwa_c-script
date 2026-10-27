using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F66 RID: 8038
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelTalk : ITalkItem
	{
		// Token: 0x0600B07A RID: 45178 RVA: 0x0019B29C File Offset: 0x0019949C
		[NullableContext(1)]
		private ITalkItemVisualNovelTalk_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelTalk_SetValue());
			}
			return result;
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x0019B2C1 File Offset: 0x001994C1
		[NullableContext(1)]
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

		// Token: 0x0600B07C RID: 45180 RVA: 0x0019B2D4 File Offset: 0x001994D4
		[NullableContext(1)]
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

		// Token: 0x0600B07D RID: 45181 RVA: 0x0019B2E8 File Offset: 0x001994E8
		[NullableContext(1)]
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

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600B07E RID: 45182 RVA: 0x0019B524 File Offset: 0x00199724
		// (set) Token: 0x0600B07F RID: 45183 RVA: 0x0019B575 File Offset: 0x00199775
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

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600B080 RID: 45184 RVA: 0x0019B594 File Offset: 0x00199794
		// (set) Token: 0x0600B081 RID: 45185 RVA: 0x0019B5E1 File Offset: 0x001997E1
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

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600B082 RID: 45186 RVA: 0x0019B600 File Offset: 0x00199800
		// (set) Token: 0x0600B083 RID: 45187 RVA: 0x0019B651 File Offset: 0x00199851
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

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600B084 RID: 45188 RVA: 0x0019B66E File Offset: 0x0019986E
		// (set) Token: 0x0600B085 RID: 45189 RVA: 0x0019B6AC File Offset: 0x001998AC
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

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600B086 RID: 45190 RVA: 0x0019B6CC File Offset: 0x001998CC
		// (set) Token: 0x0600B087 RID: 45191 RVA: 0x0019B71A File Offset: 0x0019991A
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

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600B088 RID: 45192 RVA: 0x0019B738 File Offset: 0x00199938
		// (set) Token: 0x0600B089 RID: 45193 RVA: 0x0019B78A File Offset: 0x0019998A
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

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600B08A RID: 45194 RVA: 0x0019B7A8 File Offset: 0x001999A8
		// (set) Token: 0x0600B08B RID: 45195 RVA: 0x0019B7FA File Offset: 0x001999FA
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

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600B08C RID: 45196 RVA: 0x0019B818 File Offset: 0x00199A18
		// (set) Token: 0x0600B08D RID: 45197 RVA: 0x0019B86D File Offset: 0x00199A6D
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

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600B08E RID: 45198 RVA: 0x0019B890 File Offset: 0x00199A90
		// (set) Token: 0x0600B08F RID: 45199 RVA: 0x0019B8E5 File Offset: 0x00199AE5
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

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600B090 RID: 45200 RVA: 0x0019B908 File Offset: 0x00199B08
		// (set) Token: 0x0600B091 RID: 45201 RVA: 0x0019B955 File Offset: 0x00199B55
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

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600B092 RID: 45202 RVA: 0x0019B978 File Offset: 0x00199B78
		// (set) Token: 0x0600B093 RID: 45203 RVA: 0x0019B9CD File Offset: 0x00199BCD
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

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600B094 RID: 45204 RVA: 0x0019B9F0 File Offset: 0x00199BF0
		// (set) Token: 0x0600B095 RID: 45205 RVA: 0x0019BA6C File Offset: 0x00199C6C
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

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600B096 RID: 45206 RVA: 0x0019BA94 File Offset: 0x00199C94
		// (set) Token: 0x0600B097 RID: 45207 RVA: 0x0019BB42 File Offset: 0x00199D42
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600B098 RID: 45208 RVA: 0x0019BB6C File Offset: 0x00199D6C
		// (set) Token: 0x0600B099 RID: 45209 RVA: 0x0019BC1A File Offset: 0x00199E1A
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600B09A RID: 45210 RVA: 0x0019BC44 File Offset: 0x00199E44
		// (set) Token: 0x0600B09B RID: 45211 RVA: 0x0019BCC0 File Offset: 0x00199EC0
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

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600B09C RID: 45212 RVA: 0x0019BCE8 File Offset: 0x00199EE8
		// (set) Token: 0x0600B09D RID: 45213 RVA: 0x0019BD64 File Offset: 0x00199F64
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

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600B09E RID: 45214 RVA: 0x0019BD8C File Offset: 0x00199F8C
		// (set) Token: 0x0600B09F RID: 45215 RVA: 0x0019BE08 File Offset: 0x0019A008
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

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600B0A0 RID: 45216 RVA: 0x0019BE30 File Offset: 0x0019A030
		// (set) Token: 0x0600B0A1 RID: 45217 RVA: 0x0019BEDE File Offset: 0x0019A0DE
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600B0A2 RID: 45218 RVA: 0x0019BF08 File Offset: 0x0019A108
		// (set) Token: 0x0600B0A3 RID: 45219 RVA: 0x0019BFB6 File Offset: 0x0019A1B6
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x0019BFE0 File Offset: 0x0019A1E0
		// (set) Token: 0x0600B0A5 RID: 45221 RVA: 0x0019C08E File Offset: 0x0019A28E
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600B0A6 RID: 45222 RVA: 0x0019C0B8 File Offset: 0x0019A2B8
		// (set) Token: 0x0600B0A7 RID: 45223 RVA: 0x0019C166 File Offset: 0x0019A366
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600B0A8 RID: 45224 RVA: 0x0019C190 File Offset: 0x0019A390
		// (set) Token: 0x0600B0A9 RID: 45225 RVA: 0x0019C23E File Offset: 0x0019A43E
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600B0AA RID: 45226 RVA: 0x0019C268 File Offset: 0x0019A468
		// (set) Token: 0x0600B0AB RID: 45227 RVA: 0x0019C2B5 File Offset: 0x0019A4B5
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

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600B0AC RID: 45228 RVA: 0x0019C2D8 File Offset: 0x0019A4D8
		// (set) Token: 0x0600B0AD RID: 45229 RVA: 0x0019C325 File Offset: 0x0019A525
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

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600B0AE RID: 45230 RVA: 0x0019C348 File Offset: 0x0019A548
		// (set) Token: 0x0600B0AF RID: 45231 RVA: 0x0019C3C4 File Offset: 0x0019A5C4
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

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600B0B0 RID: 45232 RVA: 0x0019C3EC File Offset: 0x0019A5EC
		// (set) Token: 0x0600B0B1 RID: 45233 RVA: 0x0019C439 File Offset: 0x0019A639
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

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600B0B2 RID: 45234 RVA: 0x0019C45C File Offset: 0x0019A65C
		// (set) Token: 0x0600B0B3 RID: 45235 RVA: 0x0019C4B1 File Offset: 0x0019A6B1
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

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x0019C4D4 File Offset: 0x0019A6D4
		// (set) Token: 0x0600B0B5 RID: 45237 RVA: 0x0019C550 File Offset: 0x0019A750
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

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600B0B6 RID: 45238 RVA: 0x0019C578 File Offset: 0x0019A778
		// (set) Token: 0x0600B0B7 RID: 45239 RVA: 0x0019C5F4 File Offset: 0x0019A7F4
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

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x0019C61C File Offset: 0x0019A81C
		// (set) Token: 0x0600B0B9 RID: 45241 RVA: 0x0019C6CA File Offset: 0x0019A8CA
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600B0BA RID: 45242 RVA: 0x0019C6F4 File Offset: 0x0019A8F4
		// (set) Token: 0x0600B0BB RID: 45243 RVA: 0x0019C7A2 File Offset: 0x0019A9A2
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600B0BC RID: 45244 RVA: 0x0019C7CC File Offset: 0x0019A9CC
		// (set) Token: 0x0600B0BD RID: 45245 RVA: 0x0019C819 File Offset: 0x0019AA19
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
				1
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600B0BE RID: 45246 RVA: 0x0019C83C File Offset: 0x0019AA3C
		// (set) Token: 0x0600B0BF RID: 45247 RVA: 0x0019C8ED File Offset: 0x0019AAED
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600B0C0 RID: 45248 RVA: 0x0019C918 File Offset: 0x0019AB18
		// (set) Token: 0x0600B0C1 RID: 45249 RVA: 0x0019C970 File Offset: 0x0019AB70
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

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600B0C2 RID: 45250 RVA: 0x0019C994 File Offset: 0x0019AB94
		// (set) Token: 0x0600B0C3 RID: 45251 RVA: 0x0019CA13 File Offset: 0x0019AC13
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
					ITalkItemVisualNovelTalk_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600B0C4 RID: 45252 RVA: 0x0019CA40 File Offset: 0x0019AC40
		// (set) Token: 0x0600B0C5 RID: 45253 RVA: 0x0019CA98 File Offset: 0x0019AC98
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

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600B0C6 RID: 45254 RVA: 0x0019CABC File Offset: 0x0019ACBC
		// (set) Token: 0x0600B0C7 RID: 45255 RVA: 0x0019CB14 File Offset: 0x0019AD14
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

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600B0C8 RID: 45256 RVA: 0x0019CB38 File Offset: 0x0019AD38
		// (set) Token: 0x0600B0C9 RID: 45257 RVA: 0x0019CB88 File Offset: 0x0019AD88
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

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600B0CA RID: 45258 RVA: 0x0019CBAC File Offset: 0x0019ADAC
		// (set) Token: 0x0600B0CB RID: 45259 RVA: 0x0019CC2B File Offset: 0x0019AE2B
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

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600B0CC RID: 45260 RVA: 0x0019CC58 File Offset: 0x0019AE58
		// (set) Token: 0x0600B0CD RID: 45261 RVA: 0x0019CCD7 File Offset: 0x0019AED7
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

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600B0CE RID: 45262 RVA: 0x0019CD04 File Offset: 0x0019AF04
		// (set) Token: 0x0600B0CF RID: 45263 RVA: 0x0019CD54 File Offset: 0x0019AF54
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

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600B0D0 RID: 45264 RVA: 0x0019CD78 File Offset: 0x0019AF78
		// (set) Token: 0x0600B0D1 RID: 45265 RVA: 0x0019CDC8 File Offset: 0x0019AFC8
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

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600B0D2 RID: 45266 RVA: 0x0019CDEC File Offset: 0x0019AFEC
		// (set) Token: 0x0600B0D3 RID: 45267 RVA: 0x0019CE3C File Offset: 0x0019B03C
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

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600B0D4 RID: 45268 RVA: 0x0019CE60 File Offset: 0x0019B060
		// (set) Token: 0x0600B0D5 RID: 45269 RVA: 0x0019CEB8 File Offset: 0x0019B0B8
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

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600B0D6 RID: 45270 RVA: 0x0019CEDC File Offset: 0x0019B0DC
		// (set) Token: 0x0600B0D7 RID: 45271 RVA: 0x0019CF2C File Offset: 0x0019B12C
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
				1
			})]
			set
			{
				this._SetMark |= 17592186044416UL;
				this.GetOrCreatePoco().StartPerformances = value;
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600B0D8 RID: 45272 RVA: 0x0019CF50 File Offset: 0x0019B150
		// (set) Token: 0x0600B0D9 RID: 45273 RVA: 0x0019CFA0 File Offset: 0x0019B1A0
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
				1
			})]
			set
			{
				this._SetMark |= 35184372088832UL;
				this.GetOrCreatePoco().EndPerformances = value;
			}
		}

		// Token: 0x04006AAE RID: 27310
		protected new ITalkItemVisualNovelTalk FbInstance;

		// Token: 0x04006AAF RID: 27311
		protected new ITalkItemVisualNovelTalk_SetValue PocoInterface;

		// Token: 0x04006AB0 RID: 27312
		private ulong _SetMark;

		// Token: 0x04006AB1 RID: 27313
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006AB2 RID: 27314
		private bool _CaptionParamsInited;

		// Token: 0x04006AB3 RID: 27315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006AB4 RID: 27316
		private bool _ActionsInited;

		// Token: 0x04006AB5 RID: 27317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006AB6 RID: 27318
		private bool _OptionsInited;

		// Token: 0x04006AB7 RID: 27319
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x04006AB8 RID: 27320
		private bool _MontageInited;

		// Token: 0x04006AB9 RID: 27321
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006ABA RID: 27322
		private bool _CameraDataInited;

		// Token: 0x04006ABB RID: 27323
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006ABC RID: 27324
		private bool _FlowTemplateInited;

		// Token: 0x04006ABD RID: 27325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006ABE RID: 27326
		private bool _FlowTemplateListInited;

		// Token: 0x04006ABF RID: 27327
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006AC0 RID: 27328
		private bool _ActorMontageArrayInited;

		// Token: 0x04006AC1 RID: 27329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006AC2 RID: 27330
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006AC3 RID: 27331
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006AC4 RID: 27332
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006AC5 RID: 27333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006AC6 RID: 27334
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006AC7 RID: 27335
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006AC8 RID: 27336
		private bool _UniversalToneInited;

		// Token: 0x04006AC9 RID: 27337
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006ACA RID: 27338
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006ACB RID: 27339
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006ACC RID: 27340
		private bool _GamepadShakeInited;

		// Token: 0x04006ACD RID: 27341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006ACE RID: 27342
		private bool _IntroActionsInited;

		// Token: 0x04006ACF RID: 27343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006AD0 RID: 27344
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006AD1 RID: 27345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006AD2 RID: 27346
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006AD3 RID: 27347
		[Nullable(1)]
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x04006AD4 RID: 27348
		private bool _OptionGroupInited;

		// Token: 0x04006AD5 RID: 27349
		[Nullable(1)]
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04006AD6 RID: 27350
		private bool _TransformInited;

		// Token: 0x04006AD7 RID: 27351
		[Nullable(1)]
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04006AD8 RID: 27352
		private bool _RoleConfigInited;
	}
}
