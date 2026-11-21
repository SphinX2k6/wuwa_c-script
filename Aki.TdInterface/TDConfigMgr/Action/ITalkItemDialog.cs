using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002179 RID: 8569
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDialog : ITalkItem
	{
		// Token: 0x0600B7D6 RID: 47062 RVA: 0x001A1854 File Offset: 0x0019FA54
		[NullableContext(0)]
		private ITalkItemDialog_SetValue GetOrCreatePoco()
		{
			ITalkItemDialog_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemDialog_SetValue());
			}
			return result;
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x001A1879 File Offset: 0x0019FA79
		[NullableContext(0)]
		public static ITalkItemDialog Create([Nullable(2)] ITalkItemDialog instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemDialog
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x001A188C File Offset: 0x0019FA8C
		[NullableContext(0)]
		public static ITalkItemDialog CreateFromSetValue([Nullable(2)] ITalkItemDialog_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemDialog
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x001A18A0 File Offset: 0x0019FAA0
		[NullableContext(0)]
		public new ITalkItemDialog_SetValue ToSetValue()
		{
			return new ITalkItemDialog_SetValue
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
				Style = this.Style,
				CameraMotion = this.CameraMotion,
				AutoPlayConfig = this.AutoPlayConfig,
				NoMouthAnim = this.NoMouthAnim,
				OtherIsTypingDuration = this.OtherIsTypingDuration
			};
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x001A1A7C File Offset: 0x0019FC7C
		// (set) Token: 0x0600B7DB RID: 47067 RVA: 0x001A1ACD File Offset: 0x0019FCCD
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600B7DC RID: 47068 RVA: 0x001A1AEC File Offset: 0x0019FCEC
		// (set) Token: 0x0600B7DD RID: 47069 RVA: 0x001A1B39 File Offset: 0x0019FD39
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

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600B7DE RID: 47070 RVA: 0x001A1B58 File Offset: 0x0019FD58
		// (set) Token: 0x0600B7DF RID: 47071 RVA: 0x001A1BA9 File Offset: 0x0019FDA9
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x001A1BC6 File Offset: 0x0019FDC6
		// (set) Token: 0x0600B7E1 RID: 47073 RVA: 0x001A1C04 File Offset: 0x0019FE04
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x001A1C24 File Offset: 0x0019FE24
		// (set) Token: 0x0600B7E3 RID: 47075 RVA: 0x001A1C72 File Offset: 0x0019FE72
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

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600B7E4 RID: 47076 RVA: 0x001A1C90 File Offset: 0x0019FE90
		// (set) Token: 0x0600B7E5 RID: 47077 RVA: 0x001A1CE2 File Offset: 0x0019FEE2
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600B7E6 RID: 47078 RVA: 0x001A1D00 File Offset: 0x0019FF00
		// (set) Token: 0x0600B7E7 RID: 47079 RVA: 0x001A1D52 File Offset: 0x0019FF52
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x001A1D70 File Offset: 0x0019FF70
		// (set) Token: 0x0600B7E9 RID: 47081 RVA: 0x001A1DC5 File Offset: 0x0019FFC5
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x001A1DE8 File Offset: 0x0019FFE8
		// (set) Token: 0x0600B7EB RID: 47083 RVA: 0x001A1E3D File Offset: 0x001A003D
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600B7EC RID: 47084 RVA: 0x001A1E60 File Offset: 0x001A0060
		// (set) Token: 0x0600B7ED RID: 47085 RVA: 0x001A1EAD File Offset: 0x001A00AD
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600B7EE RID: 47086 RVA: 0x001A1ED0 File Offset: 0x001A00D0
		// (set) Token: 0x0600B7EF RID: 47087 RVA: 0x001A1F25 File Offset: 0x001A0125
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600B7F0 RID: 47088 RVA: 0x001A1F48 File Offset: 0x001A0148
		// (set) Token: 0x0600B7F1 RID: 47089 RVA: 0x001A1FC4 File Offset: 0x001A01C4
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600B7F2 RID: 47090 RVA: 0x001A1FEC File Offset: 0x001A01EC
		// (set) Token: 0x0600B7F3 RID: 47091 RVA: 0x001A209A File Offset: 0x001A029A
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600B7F4 RID: 47092 RVA: 0x001A20C4 File Offset: 0x001A02C4
		// (set) Token: 0x0600B7F5 RID: 47093 RVA: 0x001A2172 File Offset: 0x001A0372
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600B7F6 RID: 47094 RVA: 0x001A219C File Offset: 0x001A039C
		// (set) Token: 0x0600B7F7 RID: 47095 RVA: 0x001A2218 File Offset: 0x001A0418
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600B7F8 RID: 47096 RVA: 0x001A2240 File Offset: 0x001A0440
		// (set) Token: 0x0600B7F9 RID: 47097 RVA: 0x001A22BC File Offset: 0x001A04BC
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600B7FA RID: 47098 RVA: 0x001A22E4 File Offset: 0x001A04E4
		// (set) Token: 0x0600B7FB RID: 47099 RVA: 0x001A2360 File Offset: 0x001A0560
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600B7FC RID: 47100 RVA: 0x001A2388 File Offset: 0x001A0588
		// (set) Token: 0x0600B7FD RID: 47101 RVA: 0x001A2436 File Offset: 0x001A0636
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x001A2460 File Offset: 0x001A0660
		// (set) Token: 0x0600B7FF RID: 47103 RVA: 0x001A250E File Offset: 0x001A070E
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x001A2538 File Offset: 0x001A0738
		// (set) Token: 0x0600B801 RID: 47105 RVA: 0x001A25E6 File Offset: 0x001A07E6
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x001A2610 File Offset: 0x001A0810
		// (set) Token: 0x0600B803 RID: 47107 RVA: 0x001A26BE File Offset: 0x001A08BE
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600B804 RID: 47108 RVA: 0x001A26E8 File Offset: 0x001A08E8
		// (set) Token: 0x0600B805 RID: 47109 RVA: 0x001A2796 File Offset: 0x001A0996
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600B806 RID: 47110 RVA: 0x001A27C0 File Offset: 0x001A09C0
		// (set) Token: 0x0600B807 RID: 47111 RVA: 0x001A280D File Offset: 0x001A0A0D
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600B808 RID: 47112 RVA: 0x001A2830 File Offset: 0x001A0A30
		// (set) Token: 0x0600B809 RID: 47113 RVA: 0x001A287D File Offset: 0x001A0A7D
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600B80A RID: 47114 RVA: 0x001A28A0 File Offset: 0x001A0AA0
		// (set) Token: 0x0600B80B RID: 47115 RVA: 0x001A291C File Offset: 0x001A0B1C
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600B80C RID: 47116 RVA: 0x001A2944 File Offset: 0x001A0B44
		// (set) Token: 0x0600B80D RID: 47117 RVA: 0x001A2991 File Offset: 0x001A0B91
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600B80E RID: 47118 RVA: 0x001A29B4 File Offset: 0x001A0BB4
		// (set) Token: 0x0600B80F RID: 47119 RVA: 0x001A2A09 File Offset: 0x001A0C09
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600B810 RID: 47120 RVA: 0x001A2A2C File Offset: 0x001A0C2C
		// (set) Token: 0x0600B811 RID: 47121 RVA: 0x001A2AA8 File Offset: 0x001A0CA8
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600B812 RID: 47122 RVA: 0x001A2AD0 File Offset: 0x001A0CD0
		// (set) Token: 0x0600B813 RID: 47123 RVA: 0x001A2B4C File Offset: 0x001A0D4C
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x001A2B74 File Offset: 0x001A0D74
		// (set) Token: 0x0600B815 RID: 47125 RVA: 0x001A2C22 File Offset: 0x001A0E22
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600B816 RID: 47126 RVA: 0x001A2C4C File Offset: 0x001A0E4C
		// (set) Token: 0x0600B817 RID: 47127 RVA: 0x001A2CFA File Offset: 0x001A0EFA
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600B818 RID: 47128 RVA: 0x001A2D24 File Offset: 0x001A0F24
		// (set) Token: 0x0600B819 RID: 47129 RVA: 0x001A2D71 File Offset: 0x001A0F71
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
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600B81A RID: 47130 RVA: 0x001A2D94 File Offset: 0x001A0F94
		// (set) Token: 0x0600B81B RID: 47131 RVA: 0x001A2E45 File Offset: 0x001A1045
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600B81C RID: 47132 RVA: 0x001A2E70 File Offset: 0x001A1070
		// (set) Token: 0x0600B81D RID: 47133 RVA: 0x001A2EC0 File Offset: 0x001A10C0
		public virtual ITalkItemStyle Style
		{
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.Style;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.Style;
				}
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Style;
			}
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().Style = value;
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600B81E RID: 47134 RVA: 0x001A2EE4 File Offset: 0x001A10E4
		// (set) Token: 0x0600B81F RID: 47135 RVA: 0x001A2F34 File Offset: 0x001A1134
		public virtual IShowTalkCameraMotion CameraMotion
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface.CameraMotion;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraMotion;
				}
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraMotion;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco().CameraMotion = value;
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600B820 RID: 47136 RVA: 0x001A2F58 File Offset: 0x001A1158
		// (set) Token: 0x0600B821 RID: 47137 RVA: 0x001A2FD7 File Offset: 0x001A11D7
		public virtual ITalkItemAutoPlayConfig AutoPlayConfig
		{
			get
			{
				if ((this._SetMark & 34359738368UL) != 0UL)
				{
					return this.PocoInterface.AutoPlayConfig;
				}
				if (this._AutoPlayConfigInited)
				{
					return this._AutoPlayConfigCache;
				}
				this._AutoPlayConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AutoPlayConfigCache = ITalkItemAutoPlayConfig.Create(this.FbInstance.AutoPlayConfig);
				}
				else
				{
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
					this._AutoPlayConfigCache = ((pocoInterface != null) ? pocoInterface.AutoPlayConfig : null);
				}
				return this._AutoPlayConfigCache;
			}
			set
			{
				this._SetMark |= 34359738368UL;
				this.GetOrCreatePoco().AutoPlayConfig = value;
				this._AutoPlayConfigInited = false;
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x001A3004 File Offset: 0x001A1204
		// (set) Token: 0x0600B823 RID: 47139 RVA: 0x001A305C File Offset: 0x001A125C
		public virtual bool? NoMouthAnim
		{
			get
			{
				if ((this._SetMark & 68719476736UL) != 0UL)
				{
					return this.PocoInterface.NoMouthAnim;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.NoMouthAnim;
				}
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NoMouthAnim;
			}
			set
			{
				this._SetMark |= 68719476736UL;
				this.GetOrCreatePoco().NoMouthAnim = value;
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600B824 RID: 47140 RVA: 0x001A3080 File Offset: 0x001A1280
		// (set) Token: 0x0600B825 RID: 47141 RVA: 0x001A30D8 File Offset: 0x001A12D8
		public virtual float? OtherIsTypingDuration
		{
			get
			{
				if ((this._SetMark & 137438953472UL) != 0UL)
				{
					return this.PocoInterface.OtherIsTypingDuration;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.OtherIsTypingDuration;
				}
				ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OtherIsTypingDuration;
			}
			set
			{
				this._SetMark |= 137438953472UL;
				this.GetOrCreatePoco().OtherIsTypingDuration = value;
			}
		}

		// Token: 0x04006D8B RID: 28043
		protected new ITalkItemDialog FbInstance;

		// Token: 0x04006D8C RID: 28044
		protected new ITalkItemDialog_SetValue PocoInterface;

		// Token: 0x04006D8D RID: 28045
		private ulong _SetMark;

		// Token: 0x04006D8E RID: 28046
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006D8F RID: 28047
		private bool _CaptionParamsInited;

		// Token: 0x04006D90 RID: 28048
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006D91 RID: 28049
		private bool _ActionsInited;

		// Token: 0x04006D92 RID: 28050
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006D93 RID: 28051
		private bool _OptionsInited;

		// Token: 0x04006D94 RID: 28052
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006D95 RID: 28053
		private bool _MontageInited;

		// Token: 0x04006D96 RID: 28054
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006D97 RID: 28055
		private bool _CameraDataInited;

		// Token: 0x04006D98 RID: 28056
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006D99 RID: 28057
		private bool _FlowTemplateInited;

		// Token: 0x04006D9A RID: 28058
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006D9B RID: 28059
		private bool _FlowTemplateListInited;

		// Token: 0x04006D9C RID: 28060
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006D9D RID: 28061
		private bool _ActorMontageArrayInited;

		// Token: 0x04006D9E RID: 28062
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006D9F RID: 28063
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006DA0 RID: 28064
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006DA1 RID: 28065
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006DA2 RID: 28066
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006DA3 RID: 28067
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006DA4 RID: 28068
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006DA5 RID: 28069
		private bool _UniversalToneInited;

		// Token: 0x04006DA6 RID: 28070
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006DA7 RID: 28071
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006DA8 RID: 28072
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006DA9 RID: 28073
		private bool _GamepadShakeInited;

		// Token: 0x04006DAA RID: 28074
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006DAB RID: 28075
		private bool _IntroActionsInited;

		// Token: 0x04006DAC RID: 28076
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006DAD RID: 28077
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006DAE RID: 28078
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006DAF RID: 28079
		private bool _ActorVisibilityArrayInited;

		// Token: 0x04006DB0 RID: 28080
		[Nullable(0)]
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x04006DB1 RID: 28081
		private bool _AutoPlayConfigInited;
	}
}
