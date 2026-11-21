using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002197 RID: 8599
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemSystemOption : ITalkItem
	{
		// Token: 0x0600B9B2 RID: 47538 RVA: 0x001A95A8 File Offset: 0x001A77A8
		[NullableContext(0)]
		private ITalkItemSystemOption_SetValue GetOrCreatePoco()
		{
			ITalkItemSystemOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemSystemOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x001A95CD File Offset: 0x001A77CD
		[NullableContext(0)]
		public static ITalkItemSystemOption Create([Nullable(2)] ITalkItemSystemOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemSystemOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x001A95E0 File Offset: 0x001A77E0
		[NullableContext(0)]
		public static ITalkItemSystemOption CreateFromSetValue([Nullable(2)] ITalkItemSystemOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemSystemOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x001A95F4 File Offset: 0x001A77F4
		[NullableContext(0)]
		public new ITalkItemSystemOption_SetValue ToSetValue()
		{
			return new ITalkItemSystemOption_SetValue
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
				OptionConfig = this.OptionConfig
			};
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x001A97A0 File Offset: 0x001A79A0
		// (set) Token: 0x0600B9B7 RID: 47543 RVA: 0x001A97F1 File Offset: 0x001A79F1
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600B9B8 RID: 47544 RVA: 0x001A9810 File Offset: 0x001A7A10
		// (set) Token: 0x0600B9B9 RID: 47545 RVA: 0x001A985D File Offset: 0x001A7A5D
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

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600B9BA RID: 47546 RVA: 0x001A987C File Offset: 0x001A7A7C
		// (set) Token: 0x0600B9BB RID: 47547 RVA: 0x001A98CD File Offset: 0x001A7ACD
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x001A98EA File Offset: 0x001A7AEA
		// (set) Token: 0x0600B9BD RID: 47549 RVA: 0x001A9928 File Offset: 0x001A7B28
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600B9BE RID: 47550 RVA: 0x001A9948 File Offset: 0x001A7B48
		// (set) Token: 0x0600B9BF RID: 47551 RVA: 0x001A9996 File Offset: 0x001A7B96
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

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600B9C0 RID: 47552 RVA: 0x001A99B4 File Offset: 0x001A7BB4
		// (set) Token: 0x0600B9C1 RID: 47553 RVA: 0x001A9A06 File Offset: 0x001A7C06
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600B9C2 RID: 47554 RVA: 0x001A9A24 File Offset: 0x001A7C24
		// (set) Token: 0x0600B9C3 RID: 47555 RVA: 0x001A9A76 File Offset: 0x001A7C76
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600B9C4 RID: 47556 RVA: 0x001A9A94 File Offset: 0x001A7C94
		// (set) Token: 0x0600B9C5 RID: 47557 RVA: 0x001A9AE9 File Offset: 0x001A7CE9
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600B9C6 RID: 47558 RVA: 0x001A9B0C File Offset: 0x001A7D0C
		// (set) Token: 0x0600B9C7 RID: 47559 RVA: 0x001A9B61 File Offset: 0x001A7D61
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600B9C8 RID: 47560 RVA: 0x001A9B84 File Offset: 0x001A7D84
		// (set) Token: 0x0600B9C9 RID: 47561 RVA: 0x001A9BD1 File Offset: 0x001A7DD1
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600B9CA RID: 47562 RVA: 0x001A9BF4 File Offset: 0x001A7DF4
		// (set) Token: 0x0600B9CB RID: 47563 RVA: 0x001A9C49 File Offset: 0x001A7E49
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600B9CC RID: 47564 RVA: 0x001A9C6C File Offset: 0x001A7E6C
		// (set) Token: 0x0600B9CD RID: 47565 RVA: 0x001A9CE8 File Offset: 0x001A7EE8
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600B9CE RID: 47566 RVA: 0x001A9D10 File Offset: 0x001A7F10
		// (set) Token: 0x0600B9CF RID: 47567 RVA: 0x001A9DBE File Offset: 0x001A7FBE
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600B9D0 RID: 47568 RVA: 0x001A9DE8 File Offset: 0x001A7FE8
		// (set) Token: 0x0600B9D1 RID: 47569 RVA: 0x001A9E96 File Offset: 0x001A8096
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600B9D2 RID: 47570 RVA: 0x001A9EC0 File Offset: 0x001A80C0
		// (set) Token: 0x0600B9D3 RID: 47571 RVA: 0x001A9F3C File Offset: 0x001A813C
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600B9D4 RID: 47572 RVA: 0x001A9F64 File Offset: 0x001A8164
		// (set) Token: 0x0600B9D5 RID: 47573 RVA: 0x001A9FE0 File Offset: 0x001A81E0
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600B9D6 RID: 47574 RVA: 0x001AA008 File Offset: 0x001A8208
		// (set) Token: 0x0600B9D7 RID: 47575 RVA: 0x001AA084 File Offset: 0x001A8284
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x001AA0AC File Offset: 0x001A82AC
		// (set) Token: 0x0600B9D9 RID: 47577 RVA: 0x001AA15A File Offset: 0x001A835A
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600B9DA RID: 47578 RVA: 0x001AA184 File Offset: 0x001A8384
		// (set) Token: 0x0600B9DB RID: 47579 RVA: 0x001AA232 File Offset: 0x001A8432
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600B9DC RID: 47580 RVA: 0x001AA25C File Offset: 0x001A845C
		// (set) Token: 0x0600B9DD RID: 47581 RVA: 0x001AA30A File Offset: 0x001A850A
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600B9DE RID: 47582 RVA: 0x001AA334 File Offset: 0x001A8534
		// (set) Token: 0x0600B9DF RID: 47583 RVA: 0x001AA3E2 File Offset: 0x001A85E2
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x001AA40C File Offset: 0x001A860C
		// (set) Token: 0x0600B9E1 RID: 47585 RVA: 0x001AA4BA File Offset: 0x001A86BA
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x001AA4E4 File Offset: 0x001A86E4
		// (set) Token: 0x0600B9E3 RID: 47587 RVA: 0x001AA531 File Offset: 0x001A8731
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x001AA554 File Offset: 0x001A8754
		// (set) Token: 0x0600B9E5 RID: 47589 RVA: 0x001AA5A1 File Offset: 0x001A87A1
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600B9E6 RID: 47590 RVA: 0x001AA5C4 File Offset: 0x001A87C4
		// (set) Token: 0x0600B9E7 RID: 47591 RVA: 0x001AA640 File Offset: 0x001A8840
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600B9E8 RID: 47592 RVA: 0x001AA668 File Offset: 0x001A8868
		// (set) Token: 0x0600B9E9 RID: 47593 RVA: 0x001AA6B5 File Offset: 0x001A88B5
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600B9EA RID: 47594 RVA: 0x001AA6D8 File Offset: 0x001A88D8
		// (set) Token: 0x0600B9EB RID: 47595 RVA: 0x001AA72D File Offset: 0x001A892D
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600B9EC RID: 47596 RVA: 0x001AA750 File Offset: 0x001A8950
		// (set) Token: 0x0600B9ED RID: 47597 RVA: 0x001AA7CC File Offset: 0x001A89CC
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600B9EE RID: 47598 RVA: 0x001AA7F4 File Offset: 0x001A89F4
		// (set) Token: 0x0600B9EF RID: 47599 RVA: 0x001AA870 File Offset: 0x001A8A70
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600B9F0 RID: 47600 RVA: 0x001AA898 File Offset: 0x001A8A98
		// (set) Token: 0x0600B9F1 RID: 47601 RVA: 0x001AA946 File Offset: 0x001A8B46
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600B9F2 RID: 47602 RVA: 0x001AA970 File Offset: 0x001A8B70
		// (set) Token: 0x0600B9F3 RID: 47603 RVA: 0x001AAA1E File Offset: 0x001A8C1E
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600B9F4 RID: 47604 RVA: 0x001AAA48 File Offset: 0x001A8C48
		// (set) Token: 0x0600B9F5 RID: 47605 RVA: 0x001AAA95 File Offset: 0x001A8C95
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
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600B9F6 RID: 47606 RVA: 0x001AAAB8 File Offset: 0x001A8CB8
		// (set) Token: 0x0600B9F7 RID: 47607 RVA: 0x001AAB69 File Offset: 0x001A8D69
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
					ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600B9F8 RID: 47608 RVA: 0x001AAB94 File Offset: 0x001A8D94
		// (set) Token: 0x0600B9F9 RID: 47609 RVA: 0x001AABE4 File Offset: 0x001A8DE4
		[Nullable(0)]
		public virtual ISystemOptionType OptionConfig
		{
			[NullableContext(0)]
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.OptionConfig;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionConfig;
				}
				ITalkItemSystemOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionConfig;
			}
			[NullableContext(0)]
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().OptionConfig = value;
			}
		}

		// Token: 0x04006F1D RID: 28445
		protected new ITalkItemSystemOption FbInstance;

		// Token: 0x04006F1E RID: 28446
		protected new ITalkItemSystemOption_SetValue PocoInterface;

		// Token: 0x04006F1F RID: 28447
		private ulong _SetMark;

		// Token: 0x04006F20 RID: 28448
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006F21 RID: 28449
		private bool _CaptionParamsInited;

		// Token: 0x04006F22 RID: 28450
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006F23 RID: 28451
		private bool _ActionsInited;

		// Token: 0x04006F24 RID: 28452
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006F25 RID: 28453
		private bool _OptionsInited;

		// Token: 0x04006F26 RID: 28454
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006F27 RID: 28455
		private bool _MontageInited;

		// Token: 0x04006F28 RID: 28456
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006F29 RID: 28457
		private bool _CameraDataInited;

		// Token: 0x04006F2A RID: 28458
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006F2B RID: 28459
		private bool _FlowTemplateInited;

		// Token: 0x04006F2C RID: 28460
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006F2D RID: 28461
		private bool _FlowTemplateListInited;

		// Token: 0x04006F2E RID: 28462
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006F2F RID: 28463
		private bool _ActorMontageArrayInited;

		// Token: 0x04006F30 RID: 28464
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006F31 RID: 28465
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006F32 RID: 28466
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006F33 RID: 28467
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006F34 RID: 28468
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006F35 RID: 28469
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006F36 RID: 28470
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006F37 RID: 28471
		private bool _UniversalToneInited;

		// Token: 0x04006F38 RID: 28472
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006F39 RID: 28473
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006F3A RID: 28474
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006F3B RID: 28475
		private bool _GamepadShakeInited;

		// Token: 0x04006F3C RID: 28476
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006F3D RID: 28477
		private bool _IntroActionsInited;

		// Token: 0x04006F3E RID: 28478
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006F3F RID: 28479
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006F40 RID: 28480
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006F41 RID: 28481
		private bool _ActorVisibilityArrayInited;
	}
}
