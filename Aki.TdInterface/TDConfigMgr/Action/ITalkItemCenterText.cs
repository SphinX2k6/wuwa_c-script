using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3E RID: 7998
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemCenterText : ITalkItem
	{
		// Token: 0x0600ACB8 RID: 44216 RVA: 0x0018A12C File Offset: 0x0018832C
		[NullableContext(1)]
		private ITalkItemCenterText_SetValue GetOrCreatePoco()
		{
			ITalkItemCenterText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemCenterText_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x0018A151 File Offset: 0x00188351
		[NullableContext(1)]
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

		// Token: 0x0600ACBA RID: 44218 RVA: 0x0018A164 File Offset: 0x00188364
		[NullableContext(1)]
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

		// Token: 0x0600ACBB RID: 44219 RVA: 0x0018A178 File Offset: 0x00188378
		[NullableContext(1)]
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

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x0018A330 File Offset: 0x00188530
		// (set) Token: 0x0600ACBD RID: 44221 RVA: 0x0018A381 File Offset: 0x00188581
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

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x0018A3A0 File Offset: 0x001885A0
		// (set) Token: 0x0600ACBF RID: 44223 RVA: 0x0018A3ED File Offset: 0x001885ED
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

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600ACC0 RID: 44224 RVA: 0x0018A40C File Offset: 0x0018860C
		// (set) Token: 0x0600ACC1 RID: 44225 RVA: 0x0018A45D File Offset: 0x0018865D
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

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x0018A47A File Offset: 0x0018867A
		// (set) Token: 0x0600ACC3 RID: 44227 RVA: 0x0018A4B8 File Offset: 0x001886B8
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

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600ACC4 RID: 44228 RVA: 0x0018A4D8 File Offset: 0x001886D8
		// (set) Token: 0x0600ACC5 RID: 44229 RVA: 0x0018A526 File Offset: 0x00188726
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

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600ACC6 RID: 44230 RVA: 0x0018A544 File Offset: 0x00188744
		// (set) Token: 0x0600ACC7 RID: 44231 RVA: 0x0018A596 File Offset: 0x00188796
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

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600ACC8 RID: 44232 RVA: 0x0018A5B4 File Offset: 0x001887B4
		// (set) Token: 0x0600ACC9 RID: 44233 RVA: 0x0018A606 File Offset: 0x00188806
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

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600ACCA RID: 44234 RVA: 0x0018A624 File Offset: 0x00188824
		// (set) Token: 0x0600ACCB RID: 44235 RVA: 0x0018A679 File Offset: 0x00188879
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

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x0018A69C File Offset: 0x0018889C
		// (set) Token: 0x0600ACCD RID: 44237 RVA: 0x0018A6F1 File Offset: 0x001888F1
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

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x0018A714 File Offset: 0x00188914
		// (set) Token: 0x0600ACCF RID: 44239 RVA: 0x0018A761 File Offset: 0x00188961
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

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600ACD0 RID: 44240 RVA: 0x0018A784 File Offset: 0x00188984
		// (set) Token: 0x0600ACD1 RID: 44241 RVA: 0x0018A7D9 File Offset: 0x001889D9
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

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600ACD2 RID: 44242 RVA: 0x0018A7FC File Offset: 0x001889FC
		// (set) Token: 0x0600ACD3 RID: 44243 RVA: 0x0018A878 File Offset: 0x00188A78
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

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600ACD4 RID: 44244 RVA: 0x0018A8A0 File Offset: 0x00188AA0
		// (set) Token: 0x0600ACD5 RID: 44245 RVA: 0x0018A94E File Offset: 0x00188B4E
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600ACD6 RID: 44246 RVA: 0x0018A978 File Offset: 0x00188B78
		// (set) Token: 0x0600ACD7 RID: 44247 RVA: 0x0018AA26 File Offset: 0x00188C26
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600ACD8 RID: 44248 RVA: 0x0018AA50 File Offset: 0x00188C50
		// (set) Token: 0x0600ACD9 RID: 44249 RVA: 0x0018AACC File Offset: 0x00188CCC
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

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600ACDA RID: 44250 RVA: 0x0018AAF4 File Offset: 0x00188CF4
		// (set) Token: 0x0600ACDB RID: 44251 RVA: 0x0018AB70 File Offset: 0x00188D70
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

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600ACDC RID: 44252 RVA: 0x0018AB98 File Offset: 0x00188D98
		// (set) Token: 0x0600ACDD RID: 44253 RVA: 0x0018AC14 File Offset: 0x00188E14
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

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600ACDE RID: 44254 RVA: 0x0018AC3C File Offset: 0x00188E3C
		// (set) Token: 0x0600ACDF RID: 44255 RVA: 0x0018ACEA File Offset: 0x00188EEA
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600ACE0 RID: 44256 RVA: 0x0018AD14 File Offset: 0x00188F14
		// (set) Token: 0x0600ACE1 RID: 44257 RVA: 0x0018ADC2 File Offset: 0x00188FC2
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600ACE2 RID: 44258 RVA: 0x0018ADEC File Offset: 0x00188FEC
		// (set) Token: 0x0600ACE3 RID: 44259 RVA: 0x0018AE9A File Offset: 0x0018909A
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600ACE4 RID: 44260 RVA: 0x0018AEC4 File Offset: 0x001890C4
		// (set) Token: 0x0600ACE5 RID: 44261 RVA: 0x0018AF72 File Offset: 0x00189172
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600ACE6 RID: 44262 RVA: 0x0018AF9C File Offset: 0x0018919C
		// (set) Token: 0x0600ACE7 RID: 44263 RVA: 0x0018B04A File Offset: 0x0018924A
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600ACE8 RID: 44264 RVA: 0x0018B074 File Offset: 0x00189274
		// (set) Token: 0x0600ACE9 RID: 44265 RVA: 0x0018B0C1 File Offset: 0x001892C1
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

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x0018B0E4 File Offset: 0x001892E4
		// (set) Token: 0x0600ACEB RID: 44267 RVA: 0x0018B131 File Offset: 0x00189331
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

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600ACEC RID: 44268 RVA: 0x0018B154 File Offset: 0x00189354
		// (set) Token: 0x0600ACED RID: 44269 RVA: 0x0018B1D0 File Offset: 0x001893D0
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

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600ACEE RID: 44270 RVA: 0x0018B1F8 File Offset: 0x001893F8
		// (set) Token: 0x0600ACEF RID: 44271 RVA: 0x0018B245 File Offset: 0x00189445
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

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600ACF0 RID: 44272 RVA: 0x0018B268 File Offset: 0x00189468
		// (set) Token: 0x0600ACF1 RID: 44273 RVA: 0x0018B2BD File Offset: 0x001894BD
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

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600ACF2 RID: 44274 RVA: 0x0018B2E0 File Offset: 0x001894E0
		// (set) Token: 0x0600ACF3 RID: 44275 RVA: 0x0018B35C File Offset: 0x0018955C
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

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600ACF4 RID: 44276 RVA: 0x0018B384 File Offset: 0x00189584
		// (set) Token: 0x0600ACF5 RID: 44277 RVA: 0x0018B400 File Offset: 0x00189600
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

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600ACF6 RID: 44278 RVA: 0x0018B428 File Offset: 0x00189628
		// (set) Token: 0x0600ACF7 RID: 44279 RVA: 0x0018B4D6 File Offset: 0x001896D6
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600ACF8 RID: 44280 RVA: 0x0018B500 File Offset: 0x00189700
		// (set) Token: 0x0600ACF9 RID: 44281 RVA: 0x0018B5AE File Offset: 0x001897AE
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600ACFA RID: 44282 RVA: 0x0018B5D8 File Offset: 0x001897D8
		// (set) Token: 0x0600ACFB RID: 44283 RVA: 0x0018B625 File Offset: 0x00189825
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
				1
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600ACFC RID: 44284 RVA: 0x0018B648 File Offset: 0x00189848
		// (set) Token: 0x0600ACFD RID: 44285 RVA: 0x0018B6F9 File Offset: 0x001898F9
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
					ITalkItemCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600ACFE RID: 44286 RVA: 0x0018B724 File Offset: 0x00189924
		// (set) Token: 0x0600ACFF RID: 44287 RVA: 0x0018B7A3 File Offset: 0x001899A3
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

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600AD00 RID: 44288 RVA: 0x0018B7D0 File Offset: 0x001899D0
		// (set) Token: 0x0600AD01 RID: 44289 RVA: 0x0018B828 File Offset: 0x00189A28
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

		// Token: 0x04006752 RID: 26450
		protected new ITalkItemCenterText FbInstance;

		// Token: 0x04006753 RID: 26451
		protected new ITalkItemCenterText_SetValue PocoInterface;

		// Token: 0x04006754 RID: 26452
		private ulong _SetMark;

		// Token: 0x04006755 RID: 26453
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006756 RID: 26454
		private bool _CaptionParamsInited;

		// Token: 0x04006757 RID: 26455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006758 RID: 26456
		private bool _ActionsInited;

		// Token: 0x04006759 RID: 26457
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x0400675A RID: 26458
		private bool _OptionsInited;

		// Token: 0x0400675B RID: 26459
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x0400675C RID: 26460
		private bool _MontageInited;

		// Token: 0x0400675D RID: 26461
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x0400675E RID: 26462
		private bool _CameraDataInited;

		// Token: 0x0400675F RID: 26463
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006760 RID: 26464
		private bool _FlowTemplateInited;

		// Token: 0x04006761 RID: 26465
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006762 RID: 26466
		private bool _FlowTemplateListInited;

		// Token: 0x04006763 RID: 26467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006764 RID: 26468
		private bool _ActorMontageArrayInited;

		// Token: 0x04006765 RID: 26469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006766 RID: 26470
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006767 RID: 26471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006768 RID: 26472
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006769 RID: 26473
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x0400676A RID: 26474
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400676B RID: 26475
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400676C RID: 26476
		private bool _UniversalToneInited;

		// Token: 0x0400676D RID: 26477
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400676E RID: 26478
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400676F RID: 26479
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006770 RID: 26480
		private bool _GamepadShakeInited;

		// Token: 0x04006771 RID: 26481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006772 RID: 26482
		private bool _IntroActionsInited;

		// Token: 0x04006773 RID: 26483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006774 RID: 26484
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006775 RID: 26485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006776 RID: 26486
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006777 RID: 26487
		[Nullable(1)]
		private IShowCenterTextParams _CenterTextConfigCache;

		// Token: 0x04006778 RID: 26488
		private bool _CenterTextConfigInited;
	}
}
