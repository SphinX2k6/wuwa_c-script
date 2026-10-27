using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F64 RID: 8036
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelOption : ITalkItem
	{
		// Token: 0x0600B022 RID: 45090 RVA: 0x0019985C File Offset: 0x00197A5C
		[NullableContext(1)]
		private ITalkItemVisualNovelOption_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x00199881 File Offset: 0x00197A81
		[NullableContext(1)]
		public static ITalkItemVisualNovelOption Create([Nullable(2)] ITalkItemVisualNovelOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x00199894 File Offset: 0x00197A94
		[NullableContext(1)]
		public static ITalkItemVisualNovelOption CreateFromSetValue([Nullable(2)] ITalkItemVisualNovelOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x001998A8 File Offset: 0x00197AA8
		[NullableContext(1)]
		public new ITalkItemVisualNovelOption_SetValue ToSetValue()
		{
			return new ITalkItemVisualNovelOption_SetValue
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
				CustomDescTextId = this.CustomDescTextId,
				TidCustomDescText = this.TidCustomDescText,
				VisualNovelBackgroundConfig = this.VisualNovelBackgroundConfig,
				CgConfig = this.CgConfig,
				DisplayItemConfig = this.DisplayItemConfig,
				PlotKeyId = this.PlotKeyId
			};
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600B026 RID: 45094 RVA: 0x00199AA8 File Offset: 0x00197CA8
		// (set) Token: 0x0600B027 RID: 45095 RVA: 0x00199AF9 File Offset: 0x00197CF9
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600B028 RID: 45096 RVA: 0x00199B18 File Offset: 0x00197D18
		// (set) Token: 0x0600B029 RID: 45097 RVA: 0x00199B65 File Offset: 0x00197D65
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

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600B02A RID: 45098 RVA: 0x00199B84 File Offset: 0x00197D84
		// (set) Token: 0x0600B02B RID: 45099 RVA: 0x00199BD5 File Offset: 0x00197DD5
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600B02C RID: 45100 RVA: 0x00199BF2 File Offset: 0x00197DF2
		// (set) Token: 0x0600B02D RID: 45101 RVA: 0x00199C30 File Offset: 0x00197E30
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600B02E RID: 45102 RVA: 0x00199C50 File Offset: 0x00197E50
		// (set) Token: 0x0600B02F RID: 45103 RVA: 0x00199C9E File Offset: 0x00197E9E
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

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600B030 RID: 45104 RVA: 0x00199CBC File Offset: 0x00197EBC
		// (set) Token: 0x0600B031 RID: 45105 RVA: 0x00199D0E File Offset: 0x00197F0E
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600B032 RID: 45106 RVA: 0x00199D2C File Offset: 0x00197F2C
		// (set) Token: 0x0600B033 RID: 45107 RVA: 0x00199D7E File Offset: 0x00197F7E
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600B034 RID: 45108 RVA: 0x00199D9C File Offset: 0x00197F9C
		// (set) Token: 0x0600B035 RID: 45109 RVA: 0x00199DF1 File Offset: 0x00197FF1
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600B036 RID: 45110 RVA: 0x00199E14 File Offset: 0x00198014
		// (set) Token: 0x0600B037 RID: 45111 RVA: 0x00199E69 File Offset: 0x00198069
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600B038 RID: 45112 RVA: 0x00199E8C File Offset: 0x0019808C
		// (set) Token: 0x0600B039 RID: 45113 RVA: 0x00199ED9 File Offset: 0x001980D9
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600B03A RID: 45114 RVA: 0x00199EFC File Offset: 0x001980FC
		// (set) Token: 0x0600B03B RID: 45115 RVA: 0x00199F51 File Offset: 0x00198151
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600B03C RID: 45116 RVA: 0x00199F74 File Offset: 0x00198174
		// (set) Token: 0x0600B03D RID: 45117 RVA: 0x00199FF0 File Offset: 0x001981F0
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600B03E RID: 45118 RVA: 0x0019A018 File Offset: 0x00198218
		// (set) Token: 0x0600B03F RID: 45119 RVA: 0x0019A0C6 File Offset: 0x001982C6
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600B040 RID: 45120 RVA: 0x0019A0F0 File Offset: 0x001982F0
		// (set) Token: 0x0600B041 RID: 45121 RVA: 0x0019A19E File Offset: 0x0019839E
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600B042 RID: 45122 RVA: 0x0019A1C8 File Offset: 0x001983C8
		// (set) Token: 0x0600B043 RID: 45123 RVA: 0x0019A244 File Offset: 0x00198444
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600B044 RID: 45124 RVA: 0x0019A26C File Offset: 0x0019846C
		// (set) Token: 0x0600B045 RID: 45125 RVA: 0x0019A2E8 File Offset: 0x001984E8
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600B046 RID: 45126 RVA: 0x0019A310 File Offset: 0x00198510
		// (set) Token: 0x0600B047 RID: 45127 RVA: 0x0019A38C File Offset: 0x0019858C
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600B048 RID: 45128 RVA: 0x0019A3B4 File Offset: 0x001985B4
		// (set) Token: 0x0600B049 RID: 45129 RVA: 0x0019A462 File Offset: 0x00198662
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600B04A RID: 45130 RVA: 0x0019A48C File Offset: 0x0019868C
		// (set) Token: 0x0600B04B RID: 45131 RVA: 0x0019A53A File Offset: 0x0019873A
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600B04C RID: 45132 RVA: 0x0019A564 File Offset: 0x00198764
		// (set) Token: 0x0600B04D RID: 45133 RVA: 0x0019A612 File Offset: 0x00198812
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600B04E RID: 45134 RVA: 0x0019A63C File Offset: 0x0019883C
		// (set) Token: 0x0600B04F RID: 45135 RVA: 0x0019A6EA File Offset: 0x001988EA
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600B050 RID: 45136 RVA: 0x0019A714 File Offset: 0x00198914
		// (set) Token: 0x0600B051 RID: 45137 RVA: 0x0019A7C2 File Offset: 0x001989C2
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600B052 RID: 45138 RVA: 0x0019A7EC File Offset: 0x001989EC
		// (set) Token: 0x0600B053 RID: 45139 RVA: 0x0019A839 File Offset: 0x00198A39
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600B054 RID: 45140 RVA: 0x0019A85C File Offset: 0x00198A5C
		// (set) Token: 0x0600B055 RID: 45141 RVA: 0x0019A8A9 File Offset: 0x00198AA9
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600B056 RID: 45142 RVA: 0x0019A8CC File Offset: 0x00198ACC
		// (set) Token: 0x0600B057 RID: 45143 RVA: 0x0019A948 File Offset: 0x00198B48
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600B058 RID: 45144 RVA: 0x0019A970 File Offset: 0x00198B70
		// (set) Token: 0x0600B059 RID: 45145 RVA: 0x0019A9BD File Offset: 0x00198BBD
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600B05A RID: 45146 RVA: 0x0019A9E0 File Offset: 0x00198BE0
		// (set) Token: 0x0600B05B RID: 45147 RVA: 0x0019AA35 File Offset: 0x00198C35
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600B05C RID: 45148 RVA: 0x0019AA58 File Offset: 0x00198C58
		// (set) Token: 0x0600B05D RID: 45149 RVA: 0x0019AAD4 File Offset: 0x00198CD4
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x0019AAFC File Offset: 0x00198CFC
		// (set) Token: 0x0600B05F RID: 45151 RVA: 0x0019AB78 File Offset: 0x00198D78
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x0019ABA0 File Offset: 0x00198DA0
		// (set) Token: 0x0600B061 RID: 45153 RVA: 0x0019AC4E File Offset: 0x00198E4E
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600B062 RID: 45154 RVA: 0x0019AC78 File Offset: 0x00198E78
		// (set) Token: 0x0600B063 RID: 45155 RVA: 0x0019AD26 File Offset: 0x00198F26
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600B064 RID: 45156 RVA: 0x0019AD50 File Offset: 0x00198F50
		// (set) Token: 0x0600B065 RID: 45157 RVA: 0x0019AD9D File Offset: 0x00198F9D
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600B066 RID: 45158 RVA: 0x0019ADC0 File Offset: 0x00198FC0
		// (set) Token: 0x0600B067 RID: 45159 RVA: 0x0019AE71 File Offset: 0x00199071
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600B068 RID: 45160 RVA: 0x0019AE9C File Offset: 0x0019909C
		// (set) Token: 0x0600B069 RID: 45161 RVA: 0x0019AEF4 File Offset: 0x001990F4
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600B06A RID: 45162 RVA: 0x0019AF18 File Offset: 0x00199118
		// (set) Token: 0x0600B06B RID: 45163 RVA: 0x0019AF97 File Offset: 0x00199197
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
					ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x0019AFC4 File Offset: 0x001991C4
		// (set) Token: 0x0600B06D RID: 45165 RVA: 0x0019B01C File Offset: 0x0019921C
		public virtual int? CustomDescTextId
		{
			get
			{
				if ((this._SetMark & 34359738368UL) != 0UL)
				{
					return this.PocoInterface.CustomDescTextId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomDescTextId;
				}
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CustomDescTextId;
			}
			set
			{
				this._SetMark |= 34359738368UL;
				this.GetOrCreatePoco().CustomDescTextId = value;
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600B06E RID: 45166 RVA: 0x0019B040 File Offset: 0x00199240
		// (set) Token: 0x0600B06F RID: 45167 RVA: 0x0019B090 File Offset: 0x00199290
		public virtual string TidCustomDescText
		{
			get
			{
				if ((this._SetMark & 68719476736UL) != 0UL)
				{
					return this.PocoInterface.TidCustomDescText;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCustomDescText;
				}
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidCustomDescText;
			}
			set
			{
				this._SetMark |= 68719476736UL;
				this.GetOrCreatePoco().TidCustomDescText = value;
			}
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600B070 RID: 45168 RVA: 0x0019B0B4 File Offset: 0x001992B4
		// (set) Token: 0x0600B071 RID: 45169 RVA: 0x0019B104 File Offset: 0x00199304
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600B072 RID: 45170 RVA: 0x0019B128 File Offset: 0x00199328
		// (set) Token: 0x0600B073 RID: 45171 RVA: 0x0019B178 File Offset: 0x00199378
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600B074 RID: 45172 RVA: 0x0019B19C File Offset: 0x0019939C
		// (set) Token: 0x0600B075 RID: 45173 RVA: 0x0019B1EC File Offset: 0x001993EC
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600B076 RID: 45174 RVA: 0x0019B210 File Offset: 0x00199410
		// (set) Token: 0x0600B077 RID: 45175 RVA: 0x0019B268 File Offset: 0x00199468
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
				ITalkItemVisualNovelOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006A5E RID: 27230
		protected new ITalkItemVisualNovelOption FbInstance;

		// Token: 0x04006A5F RID: 27231
		protected new ITalkItemVisualNovelOption_SetValue PocoInterface;

		// Token: 0x04006A60 RID: 27232
		private ulong _SetMark;

		// Token: 0x04006A61 RID: 27233
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006A62 RID: 27234
		private bool _CaptionParamsInited;

		// Token: 0x04006A63 RID: 27235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006A64 RID: 27236
		private bool _ActionsInited;

		// Token: 0x04006A65 RID: 27237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006A66 RID: 27238
		private bool _OptionsInited;

		// Token: 0x04006A67 RID: 27239
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x04006A68 RID: 27240
		private bool _MontageInited;

		// Token: 0x04006A69 RID: 27241
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006A6A RID: 27242
		private bool _CameraDataInited;

		// Token: 0x04006A6B RID: 27243
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006A6C RID: 27244
		private bool _FlowTemplateInited;

		// Token: 0x04006A6D RID: 27245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006A6E RID: 27246
		private bool _FlowTemplateListInited;

		// Token: 0x04006A6F RID: 27247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006A70 RID: 27248
		private bool _ActorMontageArrayInited;

		// Token: 0x04006A71 RID: 27249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006A72 RID: 27250
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006A73 RID: 27251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006A74 RID: 27252
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006A75 RID: 27253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006A76 RID: 27254
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006A77 RID: 27255
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006A78 RID: 27256
		private bool _UniversalToneInited;

		// Token: 0x04006A79 RID: 27257
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006A7A RID: 27258
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006A7B RID: 27259
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006A7C RID: 27260
		private bool _GamepadShakeInited;

		// Token: 0x04006A7D RID: 27261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006A7E RID: 27262
		private bool _IntroActionsInited;

		// Token: 0x04006A7F RID: 27263
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006A80 RID: 27264
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006A81 RID: 27265
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006A82 RID: 27266
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006A83 RID: 27267
		[Nullable(1)]
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x04006A84 RID: 27268
		private bool _OptionGroupInited;
	}
}
