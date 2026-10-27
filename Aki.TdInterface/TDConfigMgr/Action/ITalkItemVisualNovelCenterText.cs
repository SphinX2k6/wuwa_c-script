using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5E RID: 8030
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelCenterText : ITalkItem
	{
		// Token: 0x0600AF20 RID: 44832 RVA: 0x00194B24 File Offset: 0x00192D24
		[NullableContext(1)]
		private ITalkItemVisualNovelCenterText_SetValue GetOrCreatePoco()
		{
			ITalkItemVisualNovelCenterText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemVisualNovelCenterText_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x00194B49 File Offset: 0x00192D49
		[NullableContext(1)]
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

		// Token: 0x0600AF22 RID: 44834 RVA: 0x00194B5C File Offset: 0x00192D5C
		[NullableContext(1)]
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

		// Token: 0x0600AF23 RID: 44835 RVA: 0x00194B70 File Offset: 0x00192D70
		[NullableContext(1)]
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

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600AF24 RID: 44836 RVA: 0x00194D34 File Offset: 0x00192F34
		// (set) Token: 0x0600AF25 RID: 44837 RVA: 0x00194D85 File Offset: 0x00192F85
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

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x00194DA4 File Offset: 0x00192FA4
		// (set) Token: 0x0600AF27 RID: 44839 RVA: 0x00194DF1 File Offset: 0x00192FF1
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

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x00194E10 File Offset: 0x00193010
		// (set) Token: 0x0600AF29 RID: 44841 RVA: 0x00194E61 File Offset: 0x00193061
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

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x00194E7E File Offset: 0x0019307E
		// (set) Token: 0x0600AF2B RID: 44843 RVA: 0x00194EBC File Offset: 0x001930BC
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

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600AF2C RID: 44844 RVA: 0x00194EDC File Offset: 0x001930DC
		// (set) Token: 0x0600AF2D RID: 44845 RVA: 0x00194F2A File Offset: 0x0019312A
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

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600AF2E RID: 44846 RVA: 0x00194F48 File Offset: 0x00193148
		// (set) Token: 0x0600AF2F RID: 44847 RVA: 0x00194F9A File Offset: 0x0019319A
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

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x00194FB8 File Offset: 0x001931B8
		// (set) Token: 0x0600AF31 RID: 44849 RVA: 0x0019500A File Offset: 0x0019320A
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

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600AF32 RID: 44850 RVA: 0x00195028 File Offset: 0x00193228
		// (set) Token: 0x0600AF33 RID: 44851 RVA: 0x0019507D File Offset: 0x0019327D
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

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x001950A0 File Offset: 0x001932A0
		// (set) Token: 0x0600AF35 RID: 44853 RVA: 0x001950F5 File Offset: 0x001932F5
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

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x00195118 File Offset: 0x00193318
		// (set) Token: 0x0600AF37 RID: 44855 RVA: 0x00195165 File Offset: 0x00193365
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

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600AF38 RID: 44856 RVA: 0x00195188 File Offset: 0x00193388
		// (set) Token: 0x0600AF39 RID: 44857 RVA: 0x001951DD File Offset: 0x001933DD
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

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x00195200 File Offset: 0x00193400
		// (set) Token: 0x0600AF3B RID: 44859 RVA: 0x0019527C File Offset: 0x0019347C
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

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x001952A4 File Offset: 0x001934A4
		// (set) Token: 0x0600AF3D RID: 44861 RVA: 0x00195352 File Offset: 0x00193552
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x0019537C File Offset: 0x0019357C
		// (set) Token: 0x0600AF3F RID: 44863 RVA: 0x0019542A File Offset: 0x0019362A
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x00195454 File Offset: 0x00193654
		// (set) Token: 0x0600AF41 RID: 44865 RVA: 0x001954D0 File Offset: 0x001936D0
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

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600AF42 RID: 44866 RVA: 0x001954F8 File Offset: 0x001936F8
		// (set) Token: 0x0600AF43 RID: 44867 RVA: 0x00195574 File Offset: 0x00193774
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

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600AF44 RID: 44868 RVA: 0x0019559C File Offset: 0x0019379C
		// (set) Token: 0x0600AF45 RID: 44869 RVA: 0x00195618 File Offset: 0x00193818
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

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600AF46 RID: 44870 RVA: 0x00195640 File Offset: 0x00193840
		// (set) Token: 0x0600AF47 RID: 44871 RVA: 0x001956EE File Offset: 0x001938EE
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600AF48 RID: 44872 RVA: 0x00195718 File Offset: 0x00193918
		// (set) Token: 0x0600AF49 RID: 44873 RVA: 0x001957C6 File Offset: 0x001939C6
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x001957F0 File Offset: 0x001939F0
		// (set) Token: 0x0600AF4B RID: 44875 RVA: 0x0019589E File Offset: 0x00193A9E
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x001958C8 File Offset: 0x00193AC8
		// (set) Token: 0x0600AF4D RID: 44877 RVA: 0x00195976 File Offset: 0x00193B76
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x001959A0 File Offset: 0x00193BA0
		// (set) Token: 0x0600AF4F RID: 44879 RVA: 0x00195A4E File Offset: 0x00193C4E
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600AF50 RID: 44880 RVA: 0x00195A78 File Offset: 0x00193C78
		// (set) Token: 0x0600AF51 RID: 44881 RVA: 0x00195AC5 File Offset: 0x00193CC5
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

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x00195AE8 File Offset: 0x00193CE8
		// (set) Token: 0x0600AF53 RID: 44883 RVA: 0x00195B35 File Offset: 0x00193D35
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

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x00195B58 File Offset: 0x00193D58
		// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x00195BD4 File Offset: 0x00193DD4
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

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x00195BFC File Offset: 0x00193DFC
		// (set) Token: 0x0600AF57 RID: 44887 RVA: 0x00195C49 File Offset: 0x00193E49
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

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x00195C6C File Offset: 0x00193E6C
		// (set) Token: 0x0600AF59 RID: 44889 RVA: 0x00195CC1 File Offset: 0x00193EC1
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

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600AF5A RID: 44890 RVA: 0x00195CE4 File Offset: 0x00193EE4
		// (set) Token: 0x0600AF5B RID: 44891 RVA: 0x00195D60 File Offset: 0x00193F60
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

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600AF5C RID: 44892 RVA: 0x00195D88 File Offset: 0x00193F88
		// (set) Token: 0x0600AF5D RID: 44893 RVA: 0x00195E04 File Offset: 0x00194004
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

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600AF5E RID: 44894 RVA: 0x00195E2C File Offset: 0x0019402C
		// (set) Token: 0x0600AF5F RID: 44895 RVA: 0x00195EDA File Offset: 0x001940DA
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600AF60 RID: 44896 RVA: 0x00195F04 File Offset: 0x00194104
		// (set) Token: 0x0600AF61 RID: 44897 RVA: 0x00195FB2 File Offset: 0x001941B2
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600AF62 RID: 44898 RVA: 0x00195FDC File Offset: 0x001941DC
		// (set) Token: 0x0600AF63 RID: 44899 RVA: 0x00196029 File Offset: 0x00194229
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
				1
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600AF64 RID: 44900 RVA: 0x0019604C File Offset: 0x0019424C
		// (set) Token: 0x0600AF65 RID: 44901 RVA: 0x001960FD File Offset: 0x001942FD
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600AF66 RID: 44902 RVA: 0x00196128 File Offset: 0x00194328
		// (set) Token: 0x0600AF67 RID: 44903 RVA: 0x00196180 File Offset: 0x00194380
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

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x001961A4 File Offset: 0x001943A4
		// (set) Token: 0x0600AF69 RID: 44905 RVA: 0x00196223 File Offset: 0x00194423
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
					ITalkItemVisualNovelCenterText_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600AF6A RID: 44906 RVA: 0x00196250 File Offset: 0x00194450
		// (set) Token: 0x0600AF6B RID: 44907 RVA: 0x001962A8 File Offset: 0x001944A8
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

		// Token: 0x04006971 RID: 26993
		protected new ITalkItemVisualNovelCenterText FbInstance;

		// Token: 0x04006972 RID: 26994
		protected new ITalkItemVisualNovelCenterText_SetValue PocoInterface;

		// Token: 0x04006973 RID: 26995
		private ulong _SetMark;

		// Token: 0x04006974 RID: 26996
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006975 RID: 26997
		private bool _CaptionParamsInited;

		// Token: 0x04006976 RID: 26998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006977 RID: 26999
		private bool _ActionsInited;

		// Token: 0x04006978 RID: 27000
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006979 RID: 27001
		private bool _OptionsInited;

		// Token: 0x0400697A RID: 27002
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x0400697B RID: 27003
		private bool _MontageInited;

		// Token: 0x0400697C RID: 27004
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x0400697D RID: 27005
		private bool _CameraDataInited;

		// Token: 0x0400697E RID: 27006
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400697F RID: 27007
		private bool _FlowTemplateInited;

		// Token: 0x04006980 RID: 27008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006981 RID: 27009
		private bool _FlowTemplateListInited;

		// Token: 0x04006982 RID: 27010
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006983 RID: 27011
		private bool _ActorMontageArrayInited;

		// Token: 0x04006984 RID: 27012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006985 RID: 27013
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006986 RID: 27014
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006987 RID: 27015
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006988 RID: 27016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006989 RID: 27017
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400698A RID: 27018
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400698B RID: 27019
		private bool _UniversalToneInited;

		// Token: 0x0400698C RID: 27020
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400698D RID: 27021
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400698E RID: 27022
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400698F RID: 27023
		private bool _GamepadShakeInited;

		// Token: 0x04006990 RID: 27024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006991 RID: 27025
		private bool _IntroActionsInited;

		// Token: 0x04006992 RID: 27026
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006993 RID: 27027
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006994 RID: 27028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006995 RID: 27029
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006996 RID: 27030
		[Nullable(1)]
		private IVisualNovelOptionGroupSolarSchoolExam _OptionGroupCache;

		// Token: 0x04006997 RID: 27031
		private bool _OptionGroupInited;
	}
}
