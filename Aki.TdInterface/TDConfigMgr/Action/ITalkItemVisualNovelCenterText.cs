using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002199 RID: 8601
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelCenterText : ITalkItem
	{
		// Token: 0x0600B9FC RID: 47612 RVA: 0x001AAC18 File Offset: 0x001A8E18
		[NullableContext(0)]
		private ITalkItemVisualNovelCenterText_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelCenterText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelCenterText_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x001AAC3D File Offset: 0x001A8E3D
		[NullableContext(0)]
		public static ITalkItemVisualNovelCenterText Create([Nullable(2)] ITalkItemVisualNovelCenterText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelCenterText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x001AAC50 File Offset: 0x001A8E50
		[NullableContext(0)]
		public static ITalkItemVisualNovelCenterText CreateFromSetValue([Nullable(2)] ITalkItemVisualNovelCenterText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemVisualNovelCenterText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x001AAC64 File Offset: 0x001A8E64
		[NullableContext(0)]
		public new ITalkItemVisualNovelCenterText_SetValue ToSetValue()
		{
			return new ITalkItemVisualNovelCenterText_SetValue
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
				PlotKeyId = this.PlotKeyId
			};
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x001AAE28 File Offset: 0x001A9028
		// (set) Token: 0x0600BA01 RID: 47617 RVA: 0x001AAE79 File Offset: 0x001A9079
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600BA02 RID: 47618 RVA: 0x001AAE98 File Offset: 0x001A9098
		// (set) Token: 0x0600BA03 RID: 47619 RVA: 0x001AAEE5 File Offset: 0x001A90E5
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

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x001AAF04 File Offset: 0x001A9104
		// (set) Token: 0x0600BA05 RID: 47621 RVA: 0x001AAF55 File Offset: 0x001A9155
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600BA06 RID: 47622 RVA: 0x001AAF72 File Offset: 0x001A9172
		// (set) Token: 0x0600BA07 RID: 47623 RVA: 0x001AAFB0 File Offset: 0x001A91B0
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600BA08 RID: 47624 RVA: 0x001AAFD0 File Offset: 0x001A91D0
		// (set) Token: 0x0600BA09 RID: 47625 RVA: 0x001AB01E File Offset: 0x001A921E
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

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600BA0A RID: 47626 RVA: 0x001AB03C File Offset: 0x001A923C
		// (set) Token: 0x0600BA0B RID: 47627 RVA: 0x001AB08E File Offset: 0x001A928E
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600BA0C RID: 47628 RVA: 0x001AB0AC File Offset: 0x001A92AC
		// (set) Token: 0x0600BA0D RID: 47629 RVA: 0x001AB0FE File Offset: 0x001A92FE
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600BA0E RID: 47630 RVA: 0x001AB11C File Offset: 0x001A931C
		// (set) Token: 0x0600BA0F RID: 47631 RVA: 0x001AB171 File Offset: 0x001A9371
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600BA10 RID: 47632 RVA: 0x001AB194 File Offset: 0x001A9394
		// (set) Token: 0x0600BA11 RID: 47633 RVA: 0x001AB1E9 File Offset: 0x001A93E9
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x001AB20C File Offset: 0x001A940C
		// (set) Token: 0x0600BA13 RID: 47635 RVA: 0x001AB259 File Offset: 0x001A9459
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600BA14 RID: 47636 RVA: 0x001AB27C File Offset: 0x001A947C
		// (set) Token: 0x0600BA15 RID: 47637 RVA: 0x001AB2D1 File Offset: 0x001A94D1
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600BA16 RID: 47638 RVA: 0x001AB2F4 File Offset: 0x001A94F4
		// (set) Token: 0x0600BA17 RID: 47639 RVA: 0x001AB370 File Offset: 0x001A9570
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600BA18 RID: 47640 RVA: 0x001AB398 File Offset: 0x001A9598
		// (set) Token: 0x0600BA19 RID: 47641 RVA: 0x001AB446 File Offset: 0x001A9646
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600BA1A RID: 47642 RVA: 0x001AB470 File Offset: 0x001A9670
		// (set) Token: 0x0600BA1B RID: 47643 RVA: 0x001AB51E File Offset: 0x001A971E
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x001AB548 File Offset: 0x001A9748
		// (set) Token: 0x0600BA1D RID: 47645 RVA: 0x001AB5C4 File Offset: 0x001A97C4
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600BA1E RID: 47646 RVA: 0x001AB5EC File Offset: 0x001A97EC
		// (set) Token: 0x0600BA1F RID: 47647 RVA: 0x001AB668 File Offset: 0x001A9868
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x001AB690 File Offset: 0x001A9890
		// (set) Token: 0x0600BA21 RID: 47649 RVA: 0x001AB70C File Offset: 0x001A990C
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x001AB734 File Offset: 0x001A9934
		// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x001AB7E2 File Offset: 0x001A99E2
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x001AB80C File Offset: 0x001A9A0C
		// (set) Token: 0x0600BA25 RID: 47653 RVA: 0x001AB8BA File Offset: 0x001A9ABA
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x001AB8E4 File Offset: 0x001A9AE4
		// (set) Token: 0x0600BA27 RID: 47655 RVA: 0x001AB992 File Offset: 0x001A9B92
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x001AB9BC File Offset: 0x001A9BBC
		// (set) Token: 0x0600BA29 RID: 47657 RVA: 0x001ABA6A File Offset: 0x001A9C6A
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600BA2A RID: 47658 RVA: 0x001ABA94 File Offset: 0x001A9C94
		// (set) Token: 0x0600BA2B RID: 47659 RVA: 0x001ABB42 File Offset: 0x001A9D42
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x001ABB6C File Offset: 0x001A9D6C
		// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x001ABBB9 File Offset: 0x001A9DB9
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x001ABBDC File Offset: 0x001A9DDC
		// (set) Token: 0x0600BA2F RID: 47663 RVA: 0x001ABC29 File Offset: 0x001A9E29
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600BA30 RID: 47664 RVA: 0x001ABC4C File Offset: 0x001A9E4C
		// (set) Token: 0x0600BA31 RID: 47665 RVA: 0x001ABCC8 File Offset: 0x001A9EC8
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x001ABCF0 File Offset: 0x001A9EF0
		// (set) Token: 0x0600BA33 RID: 47667 RVA: 0x001ABD3D File Offset: 0x001A9F3D
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600BA34 RID: 47668 RVA: 0x001ABD60 File Offset: 0x001A9F60
		// (set) Token: 0x0600BA35 RID: 47669 RVA: 0x001ABDB5 File Offset: 0x001A9FB5
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600BA36 RID: 47670 RVA: 0x001ABDD8 File Offset: 0x001A9FD8
		// (set) Token: 0x0600BA37 RID: 47671 RVA: 0x001ABE54 File Offset: 0x001AA054
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x001ABE7C File Offset: 0x001AA07C
		// (set) Token: 0x0600BA39 RID: 47673 RVA: 0x001ABEF8 File Offset: 0x001AA0F8
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600BA3A RID: 47674 RVA: 0x001ABF20 File Offset: 0x001AA120
		// (set) Token: 0x0600BA3B RID: 47675 RVA: 0x001ABFCE File Offset: 0x001AA1CE
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600BA3C RID: 47676 RVA: 0x001ABFF8 File Offset: 0x001AA1F8
		// (set) Token: 0x0600BA3D RID: 47677 RVA: 0x001AC0A6 File Offset: 0x001AA2A6
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600BA3E RID: 47678 RVA: 0x001AC0D0 File Offset: 0x001AA2D0
		// (set) Token: 0x0600BA3F RID: 47679 RVA: 0x001AC11D File Offset: 0x001AA31D
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600BA40 RID: 47680 RVA: 0x001AC140 File Offset: 0x001AA340
		// (set) Token: 0x0600BA41 RID: 47681 RVA: 0x001AC1F1 File Offset: 0x001AA3F1
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600BA42 RID: 47682 RVA: 0x001AC21C File Offset: 0x001AA41C
		// (set) Token: 0x0600BA43 RID: 47683 RVA: 0x001AC274 File Offset: 0x001AA474
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600BA44 RID: 47684 RVA: 0x001AC298 File Offset: 0x001AA498
		// (set) Token: 0x0600BA45 RID: 47685 RVA: 0x001AC2E8 File Offset: 0x001AA4E8
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
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x001AC30C File Offset: 0x001AA50C
		// (set) Token: 0x0600BA47 RID: 47687 RVA: 0x001AC364 File Offset: 0x001AA564
		public virtual int? PlotKeyId
		{
			get
			{
				if ((this._SetMark & 34359738368UL) != 0UL)
				{
					return this.PocoInterface.PlotKeyId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotKeyId;
				}
				ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotKeyId;
			}
			set
			{
				this._SetMark |= 34359738368UL;
				this.GetOrCreatePoco().PlotKeyId = value;
			}
		}

		// Token: 0x04006F64 RID: 28516
		protected new ITalkItemVisualNovelCenterText FbInstance;

		// Token: 0x04006F65 RID: 28517
		protected new ITalkItemVisualNovelCenterText_SetValue PocoInterface;

		// Token: 0x04006F66 RID: 28518
		private ulong _SetMark;

		// Token: 0x04006F67 RID: 28519
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006F68 RID: 28520
		private bool _CaptionParamsInited;

		// Token: 0x04006F69 RID: 28521
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006F6A RID: 28522
		private bool _ActionsInited;

		// Token: 0x04006F6B RID: 28523
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006F6C RID: 28524
		private bool _OptionsInited;

		// Token: 0x04006F6D RID: 28525
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006F6E RID: 28526
		private bool _MontageInited;

		// Token: 0x04006F6F RID: 28527
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006F70 RID: 28528
		private bool _CameraDataInited;

		// Token: 0x04006F71 RID: 28529
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006F72 RID: 28530
		private bool _FlowTemplateInited;

		// Token: 0x04006F73 RID: 28531
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006F74 RID: 28532
		private bool _FlowTemplateListInited;

		// Token: 0x04006F75 RID: 28533
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006F76 RID: 28534
		private bool _ActorMontageArrayInited;

		// Token: 0x04006F77 RID: 28535
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006F78 RID: 28536
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006F79 RID: 28537
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006F7A RID: 28538
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006F7B RID: 28539
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006F7C RID: 28540
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006F7D RID: 28541
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006F7E RID: 28542
		private bool _UniversalToneInited;

		// Token: 0x04006F7F RID: 28543
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006F80 RID: 28544
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006F81 RID: 28545
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006F82 RID: 28546
		private bool _GamepadShakeInited;

		// Token: 0x04006F83 RID: 28547
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006F84 RID: 28548
		private bool _IntroActionsInited;

		// Token: 0x04006F85 RID: 28549
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006F86 RID: 28550
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006F87 RID: 28551
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006F88 RID: 28552
		private bool _ActorVisibilityArrayInited;
	}
}
