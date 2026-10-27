using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F54 RID: 8020
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemQte : ITalkItem
	{
		// Token: 0x0600AE74 RID: 44660 RVA: 0x00191C0C File Offset: 0x0018FE0C
		[NullableContext(1)]
		private ITalkItemQte_SetValue GetOrCreatePoco()
		{
			ITalkItemQte_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemQte_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x00191C31 File Offset: 0x0018FE31
		[NullableContext(1)]
		public static ITalkItemQte Create([Nullable(2)] ITalkItemQte instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemQte
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x00191C44 File Offset: 0x0018FE44
		[NullableContext(1)]
		public static ITalkItemQte CreateFromSetValue([Nullable(2)] ITalkItemQte_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemQte
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x00191C58 File Offset: 0x0018FE58
		[NullableContext(1)]
		public new ITalkItemQte_SetValue ToSetValue()
		{
			return new ITalkItemQte_SetValue
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
				QteId = this.QteId
			};
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600AE78 RID: 44664 RVA: 0x00191E04 File Offset: 0x00190004
		// (set) Token: 0x0600AE79 RID: 44665 RVA: 0x00191E55 File Offset: 0x00190055
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600AE7A RID: 44666 RVA: 0x00191E74 File Offset: 0x00190074
		// (set) Token: 0x0600AE7B RID: 44667 RVA: 0x00191EC1 File Offset: 0x001900C1
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

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600AE7C RID: 44668 RVA: 0x00191EE0 File Offset: 0x001900E0
		// (set) Token: 0x0600AE7D RID: 44669 RVA: 0x00191F31 File Offset: 0x00190131
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600AE7E RID: 44670 RVA: 0x00191F4E File Offset: 0x0019014E
		// (set) Token: 0x0600AE7F RID: 44671 RVA: 0x00191F8C File Offset: 0x0019018C
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600AE80 RID: 44672 RVA: 0x00191FAC File Offset: 0x001901AC
		// (set) Token: 0x0600AE81 RID: 44673 RVA: 0x00191FFA File Offset: 0x001901FA
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

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600AE82 RID: 44674 RVA: 0x00192018 File Offset: 0x00190218
		// (set) Token: 0x0600AE83 RID: 44675 RVA: 0x0019206A File Offset: 0x0019026A
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x00192088 File Offset: 0x00190288
		// (set) Token: 0x0600AE85 RID: 44677 RVA: 0x001920DA File Offset: 0x001902DA
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x001920F8 File Offset: 0x001902F8
		// (set) Token: 0x0600AE87 RID: 44679 RVA: 0x0019214D File Offset: 0x0019034D
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600AE88 RID: 44680 RVA: 0x00192170 File Offset: 0x00190370
		// (set) Token: 0x0600AE89 RID: 44681 RVA: 0x001921C5 File Offset: 0x001903C5
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x001921E8 File Offset: 0x001903E8
		// (set) Token: 0x0600AE8B RID: 44683 RVA: 0x00192235 File Offset: 0x00190435
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x00192258 File Offset: 0x00190458
		// (set) Token: 0x0600AE8D RID: 44685 RVA: 0x001922AD File Offset: 0x001904AD
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600AE8E RID: 44686 RVA: 0x001922D0 File Offset: 0x001904D0
		// (set) Token: 0x0600AE8F RID: 44687 RVA: 0x0019234C File Offset: 0x0019054C
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x00192374 File Offset: 0x00190574
		// (set) Token: 0x0600AE91 RID: 44689 RVA: 0x00192422 File Offset: 0x00190622
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600AE92 RID: 44690 RVA: 0x0019244C File Offset: 0x0019064C
		// (set) Token: 0x0600AE93 RID: 44691 RVA: 0x001924FA File Offset: 0x001906FA
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x00192524 File Offset: 0x00190724
		// (set) Token: 0x0600AE95 RID: 44693 RVA: 0x001925A0 File Offset: 0x001907A0
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x001925C8 File Offset: 0x001907C8
		// (set) Token: 0x0600AE97 RID: 44695 RVA: 0x00192644 File Offset: 0x00190844
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x0019266C File Offset: 0x0019086C
		// (set) Token: 0x0600AE99 RID: 44697 RVA: 0x001926E8 File Offset: 0x001908E8
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600AE9A RID: 44698 RVA: 0x00192710 File Offset: 0x00190910
		// (set) Token: 0x0600AE9B RID: 44699 RVA: 0x001927BE File Offset: 0x001909BE
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600AE9C RID: 44700 RVA: 0x001927E8 File Offset: 0x001909E8
		// (set) Token: 0x0600AE9D RID: 44701 RVA: 0x00192896 File Offset: 0x00190A96
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600AE9E RID: 44702 RVA: 0x001928C0 File Offset: 0x00190AC0
		// (set) Token: 0x0600AE9F RID: 44703 RVA: 0x0019296E File Offset: 0x00190B6E
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600AEA0 RID: 44704 RVA: 0x00192998 File Offset: 0x00190B98
		// (set) Token: 0x0600AEA1 RID: 44705 RVA: 0x00192A46 File Offset: 0x00190C46
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600AEA2 RID: 44706 RVA: 0x00192A70 File Offset: 0x00190C70
		// (set) Token: 0x0600AEA3 RID: 44707 RVA: 0x00192B1E File Offset: 0x00190D1E
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600AEA4 RID: 44708 RVA: 0x00192B48 File Offset: 0x00190D48
		// (set) Token: 0x0600AEA5 RID: 44709 RVA: 0x00192B95 File Offset: 0x00190D95
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600AEA6 RID: 44710 RVA: 0x00192BB8 File Offset: 0x00190DB8
		// (set) Token: 0x0600AEA7 RID: 44711 RVA: 0x00192C05 File Offset: 0x00190E05
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600AEA8 RID: 44712 RVA: 0x00192C28 File Offset: 0x00190E28
		// (set) Token: 0x0600AEA9 RID: 44713 RVA: 0x00192CA4 File Offset: 0x00190EA4
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600AEAA RID: 44714 RVA: 0x00192CCC File Offset: 0x00190ECC
		// (set) Token: 0x0600AEAB RID: 44715 RVA: 0x00192D19 File Offset: 0x00190F19
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x00192D3C File Offset: 0x00190F3C
		// (set) Token: 0x0600AEAD RID: 44717 RVA: 0x00192D91 File Offset: 0x00190F91
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600AEAE RID: 44718 RVA: 0x00192DB4 File Offset: 0x00190FB4
		// (set) Token: 0x0600AEAF RID: 44719 RVA: 0x00192E30 File Offset: 0x00191030
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600AEB0 RID: 44720 RVA: 0x00192E58 File Offset: 0x00191058
		// (set) Token: 0x0600AEB1 RID: 44721 RVA: 0x00192ED4 File Offset: 0x001910D4
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x00192EFC File Offset: 0x001910FC
		// (set) Token: 0x0600AEB3 RID: 44723 RVA: 0x00192FAA File Offset: 0x001911AA
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x00192FD4 File Offset: 0x001911D4
		// (set) Token: 0x0600AEB5 RID: 44725 RVA: 0x00193082 File Offset: 0x00191282
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x001930AC File Offset: 0x001912AC
		// (set) Token: 0x0600AEB7 RID: 44727 RVA: 0x001930F9 File Offset: 0x001912F9
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
				ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x0019311C File Offset: 0x0019131C
		// (set) Token: 0x0600AEB9 RID: 44729 RVA: 0x001931CD File Offset: 0x001913CD
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
					ITalkItemQte_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x001931F8 File Offset: 0x001913F8
		// (set) Token: 0x0600AEBB RID: 44731 RVA: 0x0019324C File Offset: 0x0019144C
		public virtual int QteId
		{
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.QteId;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.QteId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QteId;
			}
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().QteId = value;
			}
		}

		// Token: 0x040068DA RID: 26842
		protected new ITalkItemQte FbInstance;

		// Token: 0x040068DB RID: 26843
		protected new ITalkItemQte_SetValue PocoInterface;

		// Token: 0x040068DC RID: 26844
		private ulong _SetMark;

		// Token: 0x040068DD RID: 26845
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040068DE RID: 26846
		private bool _CaptionParamsInited;

		// Token: 0x040068DF RID: 26847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040068E0 RID: 26848
		private bool _ActionsInited;

		// Token: 0x040068E1 RID: 26849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040068E2 RID: 26850
		private bool _OptionsInited;

		// Token: 0x040068E3 RID: 26851
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x040068E4 RID: 26852
		private bool _MontageInited;

		// Token: 0x040068E5 RID: 26853
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x040068E6 RID: 26854
		private bool _CameraDataInited;

		// Token: 0x040068E7 RID: 26855
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040068E8 RID: 26856
		private bool _FlowTemplateInited;

		// Token: 0x040068E9 RID: 26857
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040068EA RID: 26858
		private bool _FlowTemplateListInited;

		// Token: 0x040068EB RID: 26859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040068EC RID: 26860
		private bool _ActorMontageArrayInited;

		// Token: 0x040068ED RID: 26861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040068EE RID: 26862
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040068EF RID: 26863
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040068F0 RID: 26864
		private bool _ActorLookAtArrayInited;

		// Token: 0x040068F1 RID: 26865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040068F2 RID: 26866
		private bool _ActorTurnToArrayInited;

		// Token: 0x040068F3 RID: 26867
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040068F4 RID: 26868
		private bool _UniversalToneInited;

		// Token: 0x040068F5 RID: 26869
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040068F6 RID: 26870
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040068F7 RID: 26871
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040068F8 RID: 26872
		private bool _GamepadShakeInited;

		// Token: 0x040068F9 RID: 26873
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040068FA RID: 26874
		private bool _IntroActionsInited;

		// Token: 0x040068FB RID: 26875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040068FC RID: 26876
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040068FD RID: 26877
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040068FE RID: 26878
		private bool _ActorVisibilityArrayInited;
	}
}
