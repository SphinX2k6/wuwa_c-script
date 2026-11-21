using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219B RID: 8603
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNarration : ITalkItem
	{
		// Token: 0x0600BA4A RID: 47690 RVA: 0x001AC398 File Offset: 0x001AA598
		[NullableContext(0)]
		private ITalkItemVisualNovelNarration_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelNarration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelNarration_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x001AC3BD File Offset: 0x001AA5BD
		[NullableContext(0)]
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

		// Token: 0x0600BA4C RID: 47692 RVA: 0x001AC3D0 File Offset: 0x001AA5D0
		[NullableContext(0)]
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

		// Token: 0x0600BA4D RID: 47693 RVA: 0x001AC3E4 File Offset: 0x001AA5E4
		[NullableContext(0)]
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

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x001AC5FC File Offset: 0x001AA7FC
		// (set) Token: 0x0600BA4F RID: 47695 RVA: 0x001AC64D File Offset: 0x001AA84D
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

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x001AC66C File Offset: 0x001AA86C
		// (set) Token: 0x0600BA51 RID: 47697 RVA: 0x001AC6B9 File Offset: 0x001AA8B9
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

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x001AC6D8 File Offset: 0x001AA8D8
		// (set) Token: 0x0600BA53 RID: 47699 RVA: 0x001AC729 File Offset: 0x001AA929
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

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x001AC746 File Offset: 0x001AA946
		// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x001AC784 File Offset: 0x001AA984
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

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x001AC7A4 File Offset: 0x001AA9A4
		// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x001AC7F2 File Offset: 0x001AA9F2
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

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x001AC810 File Offset: 0x001AAA10
		// (set) Token: 0x0600BA59 RID: 47705 RVA: 0x001AC862 File Offset: 0x001AAA62
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

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600BA5A RID: 47706 RVA: 0x001AC880 File Offset: 0x001AAA80
		// (set) Token: 0x0600BA5B RID: 47707 RVA: 0x001AC8D2 File Offset: 0x001AAAD2
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

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x001AC8F0 File Offset: 0x001AAAF0
		// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x001AC945 File Offset: 0x001AAB45
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

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x001AC968 File Offset: 0x001AAB68
		// (set) Token: 0x0600BA5F RID: 47711 RVA: 0x001AC9BD File Offset: 0x001AABBD
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

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600BA60 RID: 47712 RVA: 0x001AC9E0 File Offset: 0x001AABE0
		// (set) Token: 0x0600BA61 RID: 47713 RVA: 0x001ACA2D File Offset: 0x001AAC2D
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

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x001ACA50 File Offset: 0x001AAC50
		// (set) Token: 0x0600BA63 RID: 47715 RVA: 0x001ACAA5 File Offset: 0x001AACA5
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

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600BA64 RID: 47716 RVA: 0x001ACAC8 File Offset: 0x001AACC8
		// (set) Token: 0x0600BA65 RID: 47717 RVA: 0x001ACB44 File Offset: 0x001AAD44
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

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600BA66 RID: 47718 RVA: 0x001ACB6C File Offset: 0x001AAD6C
		// (set) Token: 0x0600BA67 RID: 47719 RVA: 0x001ACC1A File Offset: 0x001AAE1A
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600BA68 RID: 47720 RVA: 0x001ACC44 File Offset: 0x001AAE44
		// (set) Token: 0x0600BA69 RID: 47721 RVA: 0x001ACCF2 File Offset: 0x001AAEF2
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600BA6A RID: 47722 RVA: 0x001ACD1C File Offset: 0x001AAF1C
		// (set) Token: 0x0600BA6B RID: 47723 RVA: 0x001ACD98 File Offset: 0x001AAF98
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

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x001ACDC0 File Offset: 0x001AAFC0
		// (set) Token: 0x0600BA6D RID: 47725 RVA: 0x001ACE3C File Offset: 0x001AB03C
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

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x001ACE64 File Offset: 0x001AB064
		// (set) Token: 0x0600BA6F RID: 47727 RVA: 0x001ACEE0 File Offset: 0x001AB0E0
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

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x001ACF08 File Offset: 0x001AB108
		// (set) Token: 0x0600BA71 RID: 47729 RVA: 0x001ACFB6 File Offset: 0x001AB1B6
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600BA72 RID: 47730 RVA: 0x001ACFE0 File Offset: 0x001AB1E0
		// (set) Token: 0x0600BA73 RID: 47731 RVA: 0x001AD08E File Offset: 0x001AB28E
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x001AD0B8 File Offset: 0x001AB2B8
		// (set) Token: 0x0600BA75 RID: 47733 RVA: 0x001AD166 File Offset: 0x001AB366
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600BA76 RID: 47734 RVA: 0x001AD190 File Offset: 0x001AB390
		// (set) Token: 0x0600BA77 RID: 47735 RVA: 0x001AD23E File Offset: 0x001AB43E
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600BA78 RID: 47736 RVA: 0x001AD268 File Offset: 0x001AB468
		// (set) Token: 0x0600BA79 RID: 47737 RVA: 0x001AD316 File Offset: 0x001AB516
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x001AD340 File Offset: 0x001AB540
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x001AD38D File Offset: 0x001AB58D
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

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x001AD3B0 File Offset: 0x001AB5B0
		// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x001AD3FD File Offset: 0x001AB5FD
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

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x001AD420 File Offset: 0x001AB620
		// (set) Token: 0x0600BA7F RID: 47743 RVA: 0x001AD49C File Offset: 0x001AB69C
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

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x001AD4C4 File Offset: 0x001AB6C4
		// (set) Token: 0x0600BA81 RID: 47745 RVA: 0x001AD511 File Offset: 0x001AB711
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

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600BA82 RID: 47746 RVA: 0x001AD534 File Offset: 0x001AB734
		// (set) Token: 0x0600BA83 RID: 47747 RVA: 0x001AD589 File Offset: 0x001AB789
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600BA84 RID: 47748 RVA: 0x001AD5AC File Offset: 0x001AB7AC
		// (set) Token: 0x0600BA85 RID: 47749 RVA: 0x001AD628 File Offset: 0x001AB828
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

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x001AD650 File Offset: 0x001AB850
		// (set) Token: 0x0600BA87 RID: 47751 RVA: 0x001AD6CC File Offset: 0x001AB8CC
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

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600BA88 RID: 47752 RVA: 0x001AD6F4 File Offset: 0x001AB8F4
		// (set) Token: 0x0600BA89 RID: 47753 RVA: 0x001AD7A2 File Offset: 0x001AB9A2
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x001AD7CC File Offset: 0x001AB9CC
		// (set) Token: 0x0600BA8B RID: 47755 RVA: 0x001AD87A File Offset: 0x001ABA7A
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600BA8C RID: 47756 RVA: 0x001AD8A4 File Offset: 0x001ABAA4
		// (set) Token: 0x0600BA8D RID: 47757 RVA: 0x001AD8F1 File Offset: 0x001ABAF1
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
				0
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600BA8E RID: 47758 RVA: 0x001AD914 File Offset: 0x001ABB14
		// (set) Token: 0x0600BA8F RID: 47759 RVA: 0x001AD9C5 File Offset: 0x001ABBC5
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
					ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x001AD9F0 File Offset: 0x001ABBF0
		// (set) Token: 0x0600BA91 RID: 47761 RVA: 0x001ADA48 File Offset: 0x001ABC48
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

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x001ADA6C File Offset: 0x001ABC6C
		// (set) Token: 0x0600BA93 RID: 47763 RVA: 0x001ADABC File Offset: 0x001ABCBC
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
				ITalkItemVisualNovelNarration_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600BA94 RID: 47764 RVA: 0x001ADAE0 File Offset: 0x001ABCE0
		// (set) Token: 0x0600BA95 RID: 47765 RVA: 0x001ADB38 File Offset: 0x001ABD38
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

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x001ADB5C File Offset: 0x001ABD5C
		// (set) Token: 0x0600BA97 RID: 47767 RVA: 0x001ADBB4 File Offset: 0x001ABDB4
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

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x001ADBD8 File Offset: 0x001ABDD8
		// (set) Token: 0x0600BA99 RID: 47769 RVA: 0x001ADC28 File Offset: 0x001ABE28
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

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x001ADC4C File Offset: 0x001ABE4C
		// (set) Token: 0x0600BA9B RID: 47771 RVA: 0x001ADC9C File Offset: 0x001ABE9C
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

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600BA9C RID: 47772 RVA: 0x001ADCC0 File Offset: 0x001ABEC0
		// (set) Token: 0x0600BA9D RID: 47773 RVA: 0x001ADD10 File Offset: 0x001ABF10
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

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x001ADD34 File Offset: 0x001ABF34
		// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x001ADD8C File Offset: 0x001ABF8C
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

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x001ADDB0 File Offset: 0x001ABFB0
		// (set) Token: 0x0600BAA1 RID: 47777 RVA: 0x001ADE00 File Offset: 0x001AC000
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
				0
			})]
			set
			{
				this._SetMark |= 2199023255552UL;
				this.GetOrCreatePoco().StartPerformances = value;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600BAA2 RID: 47778 RVA: 0x001ADE24 File Offset: 0x001AC024
		// (set) Token: 0x0600BAA3 RID: 47779 RVA: 0x001ADE74 File Offset: 0x001AC074
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
				0
			})]
			set
			{
				this._SetMark |= 4398046511104UL;
				this.GetOrCreatePoco().EndPerformances = value;
			}
		}

		// Token: 0x04006FAD RID: 28589
		protected new ITalkItemVisualNovelNarration FbInstance;

		// Token: 0x04006FAE RID: 28590
		protected new ITalkItemVisualNovelNarration_SetValue PocoInterface;

		// Token: 0x04006FAF RID: 28591
		private ulong _SetMark;

		// Token: 0x04006FB0 RID: 28592
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006FB1 RID: 28593
		private bool _CaptionParamsInited;

		// Token: 0x04006FB2 RID: 28594
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006FB3 RID: 28595
		private bool _ActionsInited;

		// Token: 0x04006FB4 RID: 28596
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006FB5 RID: 28597
		private bool _OptionsInited;

		// Token: 0x04006FB6 RID: 28598
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006FB7 RID: 28599
		private bool _MontageInited;

		// Token: 0x04006FB8 RID: 28600
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006FB9 RID: 28601
		private bool _CameraDataInited;

		// Token: 0x04006FBA RID: 28602
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006FBB RID: 28603
		private bool _FlowTemplateInited;

		// Token: 0x04006FBC RID: 28604
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006FBD RID: 28605
		private bool _FlowTemplateListInited;

		// Token: 0x04006FBE RID: 28606
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006FBF RID: 28607
		private bool _ActorMontageArrayInited;

		// Token: 0x04006FC0 RID: 28608
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006FC1 RID: 28609
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006FC2 RID: 28610
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006FC3 RID: 28611
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006FC4 RID: 28612
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006FC5 RID: 28613
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006FC6 RID: 28614
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006FC7 RID: 28615
		private bool _UniversalToneInited;

		// Token: 0x04006FC8 RID: 28616
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006FC9 RID: 28617
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006FCA RID: 28618
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006FCB RID: 28619
		private bool _GamepadShakeInited;

		// Token: 0x04006FCC RID: 28620
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006FCD RID: 28621
		private bool _IntroActionsInited;

		// Token: 0x04006FCE RID: 28622
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006FCF RID: 28623
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006FD0 RID: 28624
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006FD1 RID: 28625
		private bool _ActorVisibilityArrayInited;
	}
}
