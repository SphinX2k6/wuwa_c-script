using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002177 RID: 8567
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemCenterText : ITalkItem
	{
		// Token: 0x0600B78A RID: 46986 RVA: 0x001A0124 File Offset: 0x0019E324
		[NullableContext(0)]
		private ITalkItemCenterText_SetValue GetOrCreatePoco()
		{
			ITalkItemCenterText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemCenterText_SetValue());
			}
			return result;
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x001A0149 File Offset: 0x0019E349
		[NullableContext(0)]
		public static ITalkItemCenterText Create([Nullable(2)] ITalkItemCenterText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemCenterText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x001A015C File Offset: 0x0019E35C
		[NullableContext(0)]
		public static ITalkItemCenterText CreateFromSetValue([Nullable(2)] ITalkItemCenterText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemCenterText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x001A0170 File Offset: 0x0019E370
		[NullableContext(0)]
		public new ITalkItemCenterText_SetValue ToSetValue()
		{
			return new ITalkItemCenterText_SetValue
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
				CenterTextConfig = this.CenterTextConfig,
				_IsPlotActionForPreview = this._IsPlotActionForPreview
			};
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600B78E RID: 46990 RVA: 0x001A0328 File Offset: 0x0019E528
		// (set) Token: 0x0600B78F RID: 46991 RVA: 0x001A0379 File Offset: 0x0019E579
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600B790 RID: 46992 RVA: 0x001A0398 File Offset: 0x0019E598
		// (set) Token: 0x0600B791 RID: 46993 RVA: 0x001A03E5 File Offset: 0x0019E5E5
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

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600B792 RID: 46994 RVA: 0x001A0404 File Offset: 0x0019E604
		// (set) Token: 0x0600B793 RID: 46995 RVA: 0x001A0455 File Offset: 0x0019E655
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600B794 RID: 46996 RVA: 0x001A0472 File Offset: 0x0019E672
		// (set) Token: 0x0600B795 RID: 46997 RVA: 0x001A04B0 File Offset: 0x0019E6B0
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600B796 RID: 46998 RVA: 0x001A04D0 File Offset: 0x0019E6D0
		// (set) Token: 0x0600B797 RID: 46999 RVA: 0x001A051E File Offset: 0x0019E71E
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

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600B798 RID: 47000 RVA: 0x001A053C File Offset: 0x0019E73C
		// (set) Token: 0x0600B799 RID: 47001 RVA: 0x001A058E File Offset: 0x0019E78E
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x001A05AC File Offset: 0x0019E7AC
		// (set) Token: 0x0600B79B RID: 47003 RVA: 0x001A05FE File Offset: 0x0019E7FE
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600B79C RID: 47004 RVA: 0x001A061C File Offset: 0x0019E81C
		// (set) Token: 0x0600B79D RID: 47005 RVA: 0x001A0671 File Offset: 0x0019E871
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600B79E RID: 47006 RVA: 0x001A0694 File Offset: 0x0019E894
		// (set) Token: 0x0600B79F RID: 47007 RVA: 0x001A06E9 File Offset: 0x0019E8E9
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600B7A0 RID: 47008 RVA: 0x001A070C File Offset: 0x0019E90C
		// (set) Token: 0x0600B7A1 RID: 47009 RVA: 0x001A0759 File Offset: 0x0019E959
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600B7A2 RID: 47010 RVA: 0x001A077C File Offset: 0x0019E97C
		// (set) Token: 0x0600B7A3 RID: 47011 RVA: 0x001A07D1 File Offset: 0x0019E9D1
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600B7A4 RID: 47012 RVA: 0x001A07F4 File Offset: 0x0019E9F4
		// (set) Token: 0x0600B7A5 RID: 47013 RVA: 0x001A0870 File Offset: 0x0019EA70
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x001A0898 File Offset: 0x0019EA98
		// (set) Token: 0x0600B7A7 RID: 47015 RVA: 0x001A0946 File Offset: 0x0019EB46
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600B7A8 RID: 47016 RVA: 0x001A0970 File Offset: 0x0019EB70
		// (set) Token: 0x0600B7A9 RID: 47017 RVA: 0x001A0A1E File Offset: 0x0019EC1E
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600B7AA RID: 47018 RVA: 0x001A0A48 File Offset: 0x0019EC48
		// (set) Token: 0x0600B7AB RID: 47019 RVA: 0x001A0AC4 File Offset: 0x0019ECC4
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B7AC RID: 47020 RVA: 0x001A0AEC File Offset: 0x0019ECEC
		// (set) Token: 0x0600B7AD RID: 47021 RVA: 0x001A0B68 File Offset: 0x0019ED68
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B7AE RID: 47022 RVA: 0x001A0B90 File Offset: 0x0019ED90
		// (set) Token: 0x0600B7AF RID: 47023 RVA: 0x001A0C0C File Offset: 0x0019EE0C
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B7B0 RID: 47024 RVA: 0x001A0C34 File Offset: 0x0019EE34
		// (set) Token: 0x0600B7B1 RID: 47025 RVA: 0x001A0CE2 File Offset: 0x0019EEE2
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B7B2 RID: 47026 RVA: 0x001A0D0C File Offset: 0x0019EF0C
		// (set) Token: 0x0600B7B3 RID: 47027 RVA: 0x001A0DBA File Offset: 0x0019EFBA
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600B7B4 RID: 47028 RVA: 0x001A0DE4 File Offset: 0x0019EFE4
		// (set) Token: 0x0600B7B5 RID: 47029 RVA: 0x001A0E92 File Offset: 0x0019F092
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600B7B6 RID: 47030 RVA: 0x001A0EBC File Offset: 0x0019F0BC
		// (set) Token: 0x0600B7B7 RID: 47031 RVA: 0x001A0F6A File Offset: 0x0019F16A
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600B7B8 RID: 47032 RVA: 0x001A0F94 File Offset: 0x0019F194
		// (set) Token: 0x0600B7B9 RID: 47033 RVA: 0x001A1042 File Offset: 0x0019F242
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600B7BA RID: 47034 RVA: 0x001A106C File Offset: 0x0019F26C
		// (set) Token: 0x0600B7BB RID: 47035 RVA: 0x001A10B9 File Offset: 0x0019F2B9
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600B7BC RID: 47036 RVA: 0x001A10DC File Offset: 0x0019F2DC
		// (set) Token: 0x0600B7BD RID: 47037 RVA: 0x001A1129 File Offset: 0x0019F329
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x001A114C File Offset: 0x0019F34C
		// (set) Token: 0x0600B7BF RID: 47039 RVA: 0x001A11C8 File Offset: 0x0019F3C8
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600B7C0 RID: 47040 RVA: 0x001A11F0 File Offset: 0x0019F3F0
		// (set) Token: 0x0600B7C1 RID: 47041 RVA: 0x001A123D File Offset: 0x0019F43D
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600B7C2 RID: 47042 RVA: 0x001A1260 File Offset: 0x0019F460
		// (set) Token: 0x0600B7C3 RID: 47043 RVA: 0x001A12B5 File Offset: 0x0019F4B5
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600B7C4 RID: 47044 RVA: 0x001A12D8 File Offset: 0x0019F4D8
		// (set) Token: 0x0600B7C5 RID: 47045 RVA: 0x001A1354 File Offset: 0x0019F554
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600B7C6 RID: 47046 RVA: 0x001A137C File Offset: 0x0019F57C
		// (set) Token: 0x0600B7C7 RID: 47047 RVA: 0x001A13F8 File Offset: 0x0019F5F8
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600B7C8 RID: 47048 RVA: 0x001A1420 File Offset: 0x0019F620
		// (set) Token: 0x0600B7C9 RID: 47049 RVA: 0x001A14CE File Offset: 0x0019F6CE
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600B7CA RID: 47050 RVA: 0x001A14F8 File Offset: 0x0019F6F8
		// (set) Token: 0x0600B7CB RID: 47051 RVA: 0x001A15A6 File Offset: 0x0019F7A6
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600B7CC RID: 47052 RVA: 0x001A15D0 File Offset: 0x0019F7D0
		// (set) Token: 0x0600B7CD RID: 47053 RVA: 0x001A161D File Offset: 0x0019F81D
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
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600B7CE RID: 47054 RVA: 0x001A1640 File Offset: 0x0019F840
		// (set) Token: 0x0600B7CF RID: 47055 RVA: 0x001A16F1 File Offset: 0x0019F8F1
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600B7D0 RID: 47056 RVA: 0x001A171C File Offset: 0x0019F91C
		// (set) Token: 0x0600B7D1 RID: 47057 RVA: 0x001A179B File Offset: 0x0019F99B
		public virtual IShowCenterTextParams CenterTextConfig
		{
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.CenterTextConfig;
				}
				if (this._CenterTextConfigInited)
				{
					return this._CenterTextConfigCache;
				}
				this._CenterTextConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CenterTextConfigCache = IShowCenterTextParams.Create(this.FbInstance.CenterTextConfig);
				}
				else
				{
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
					this._CenterTextConfigCache = ((pocoInterface != null) ? pocoInterface.CenterTextConfig : null);
				}
				return this._CenterTextConfigCache;
			}
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().CenterTextConfig = value;
				this._CenterTextConfigInited = false;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600B7D2 RID: 47058 RVA: 0x001A17C8 File Offset: 0x0019F9C8
		// (set) Token: 0x0600B7D3 RID: 47059 RVA: 0x001A1820 File Offset: 0x0019FA20
		public virtual bool? _IsPlotActionForPreview
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface._IsPlotActionForPreview;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance._IsPlotActionForPreview;
				}
				ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._IsPlotActionForPreview;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco()._IsPlotActionForPreview = value;
			}
		}

		// Token: 0x04006D41 RID: 27969
		protected new ITalkItemCenterText FbInstance;

		// Token: 0x04006D42 RID: 27970
		protected new ITalkItemCenterText_SetValue PocoInterface;

		// Token: 0x04006D43 RID: 27971
		private ulong _SetMark;

		// Token: 0x04006D44 RID: 27972
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006D45 RID: 27973
		private bool _CaptionParamsInited;

		// Token: 0x04006D46 RID: 27974
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006D47 RID: 27975
		private bool _ActionsInited;

		// Token: 0x04006D48 RID: 27976
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006D49 RID: 27977
		private bool _OptionsInited;

		// Token: 0x04006D4A RID: 27978
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006D4B RID: 27979
		private bool _MontageInited;

		// Token: 0x04006D4C RID: 27980
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006D4D RID: 27981
		private bool _CameraDataInited;

		// Token: 0x04006D4E RID: 27982
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006D4F RID: 27983
		private bool _FlowTemplateInited;

		// Token: 0x04006D50 RID: 27984
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006D51 RID: 27985
		private bool _FlowTemplateListInited;

		// Token: 0x04006D52 RID: 27986
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006D53 RID: 27987
		private bool _ActorMontageArrayInited;

		// Token: 0x04006D54 RID: 27988
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006D55 RID: 27989
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006D56 RID: 27990
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006D57 RID: 27991
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006D58 RID: 27992
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006D59 RID: 27993
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006D5A RID: 27994
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006D5B RID: 27995
		private bool _UniversalToneInited;

		// Token: 0x04006D5C RID: 27996
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006D5D RID: 27997
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006D5E RID: 27998
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006D5F RID: 27999
		private bool _GamepadShakeInited;

		// Token: 0x04006D60 RID: 28000
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006D61 RID: 28001
		private bool _IntroActionsInited;

		// Token: 0x04006D62 RID: 28002
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006D63 RID: 28003
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006D64 RID: 28004
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006D65 RID: 28005
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006D66 RID: 28006
		[Nullable(0)]
		private IShowCenterTextParams _CenterTextConfigCache;

		// Token: 0x04006D67 RID: 28007
		private bool _CenterTextConfigInited;
	}
}
