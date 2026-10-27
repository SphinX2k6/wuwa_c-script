using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2C RID: 7980
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItem
	{
		// Token: 0x0600AAA2 RID: 43682 RVA: 0x00180208 File Offset: 0x0017E408
		[NullableContext(1)]
		private ITalkItem_SetValue GetOrCreatePoco()
		{
			ITalkItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x0018022D File Offset: 0x0017E42D
		[NullableContext(1)]
		public static ITalkItem Create([Nullable(2)] ITalkItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAA4 RID: 43684 RVA: 0x00180240 File Offset: 0x0017E440
		[NullableContext(1)]
		public static ITalkItem CreateFromSetValue([Nullable(2)] ITalkItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x00180254 File Offset: 0x0017E454
		[NullableContext(1)]
		public ITalkItem_SetValue ToSetValue()
		{
			return new ITalkItem_SetValue
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
				ActorVisibilityArray = this.ActorVisibilityArray
			};
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x001803F4 File Offset: 0x0017E5F4
		// (set) Token: 0x0600AAA7 RID: 43687 RVA: 0x00180445 File Offset: 0x0017E645
		public virtual ETalkItemType? Type
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x00180464 File Offset: 0x0017E664
		// (set) Token: 0x0600AAA9 RID: 43689 RVA: 0x001804B1 File Offset: 0x0017E6B1
		public virtual int Id
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

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x001804D0 File Offset: 0x0017E6D0
		// (set) Token: 0x0600AAAB RID: 43691 RVA: 0x00180521 File Offset: 0x0017E721
		public virtual int? PlotLineId
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600AAAC RID: 43692 RVA: 0x0018053E File Offset: 0x0017E73E
		// (set) Token: 0x0600AAAD RID: 43693 RVA: 0x0018057C File Offset: 0x0017E77C
		public virtual string PlotLineKey
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600AAAE RID: 43694 RVA: 0x0018059C File Offset: 0x0017E79C
		// (set) Token: 0x0600AAAF RID: 43695 RVA: 0x001805EA File Offset: 0x0017E7EA
		[Nullable(1)]
		public virtual string Name
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

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600AAB0 RID: 43696 RVA: 0x00180608 File Offset: 0x0017E808
		// (set) Token: 0x0600AAB1 RID: 43697 RVA: 0x0018065A File Offset: 0x0017E85A
		public virtual bool? _Folded
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600AAB2 RID: 43698 RVA: 0x00180678 File Offset: 0x0017E878
		// (set) Token: 0x0600AAB3 RID: 43699 RVA: 0x001806CA File Offset: 0x0017E8CA
		public virtual EEditFlag? _EditFlag
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600AAB4 RID: 43700 RVA: 0x001806E8 File Offset: 0x0017E8E8
		// (set) Token: 0x0600AAB5 RID: 43701 RVA: 0x0018073D File Offset: 0x0017E93D
		public virtual int? WhoId
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600AAB6 RID: 43702 RVA: 0x00180760 File Offset: 0x0017E960
		// (set) Token: 0x0600AAB7 RID: 43703 RVA: 0x001807B5 File Offset: 0x0017E9B5
		public virtual int? TextId
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600AAB8 RID: 43704 RVA: 0x001807D8 File Offset: 0x0017E9D8
		// (set) Token: 0x0600AAB9 RID: 43705 RVA: 0x00180825 File Offset: 0x0017EA25
		public virtual string TidTalk
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600AABA RID: 43706 RVA: 0x00180848 File Offset: 0x0017EA48
		// (set) Token: 0x0600AABB RID: 43707 RVA: 0x0018089D File Offset: 0x0017EA9D
		public virtual float? WaitTime
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600AABC RID: 43708 RVA: 0x001808C0 File Offset: 0x0017EAC0
		// (set) Token: 0x0600AABD RID: 43709 RVA: 0x0018093C File Offset: 0x0017EB3C
		public virtual ICaptionParam CaptionParams
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600AABE RID: 43710 RVA: 0x00180964 File Offset: 0x0017EB64
		// (set) Token: 0x0600AABF RID: 43711 RVA: 0x00180A12 File Offset: 0x0017EC12
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x00180A3C File Offset: 0x0017EC3C
		// (set) Token: 0x0600AAC1 RID: 43713 RVA: 0x00180AEA File Offset: 0x0017ECEA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITalkOption> Options
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x00180B14 File Offset: 0x0017ED14
		// (set) Token: 0x0600AAC3 RID: 43715 RVA: 0x00180B90 File Offset: 0x0017ED90
		public virtual PlayMontage Montage
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600AAC4 RID: 43716 RVA: 0x00180BB8 File Offset: 0x0017EDB8
		// (set) Token: 0x0600AAC5 RID: 43717 RVA: 0x00180C34 File Offset: 0x0017EE34
		public virtual ICameraData CameraData
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x00180C5C File Offset: 0x0017EE5C
		// (set) Token: 0x0600AAC7 RID: 43719 RVA: 0x00180CD8 File Offset: 0x0017EED8
		public virtual SetFlowTemplate FlowTemplate
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600AAC8 RID: 43720 RVA: 0x00180D00 File Offset: 0x0017EF00
		// (set) Token: 0x0600AAC9 RID: 43721 RVA: 0x00180DAE File Offset: 0x0017EFAE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<SetFlowTemplate> FlowTemplateList
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600AACA RID: 43722 RVA: 0x00180DD8 File Offset: 0x0017EFD8
		// (set) Token: 0x0600AACB RID: 43723 RVA: 0x00180E86 File Offset: 0x0017F086
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMontageData> ActorMontageArray
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600AACC RID: 43724 RVA: 0x00180EB0 File Offset: 0x0017F0B0
		// (set) Token: 0x0600AACD RID: 43725 RVA: 0x00180F5E File Offset: 0x0017F15E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorFaceExpression> ActorFaceExpressionArray
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600AACE RID: 43726 RVA: 0x00180F88 File Offset: 0x0017F188
		// (set) Token: 0x0600AACF RID: 43727 RVA: 0x00181036 File Offset: 0x0017F236
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorLookAt> ActorLookAtArray
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x00181060 File Offset: 0x0017F260
		// (set) Token: 0x0600AAD1 RID: 43729 RVA: 0x0018110E File Offset: 0x0017F30E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorTurnTo> ActorTurnToArray
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600AAD2 RID: 43730 RVA: 0x00181138 File Offset: 0x0017F338
		// (set) Token: 0x0600AAD3 RID: 43731 RVA: 0x00181185 File Offset: 0x0017F385
		public virtual IPostAkEventType TalkAkEvent
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600AAD4 RID: 43732 RVA: 0x001811A8 File Offset: 0x0017F3A8
		// (set) Token: 0x0600AAD5 RID: 43733 RVA: 0x001811F5 File Offset: 0x0017F3F5
		public virtual IPostAkEventType TalkEndAkEvent
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600AAD6 RID: 43734 RVA: 0x00181218 File Offset: 0x0017F418
		// (set) Token: 0x0600AAD7 RID: 43735 RVA: 0x00181294 File Offset: 0x0017F494
		public virtual IUniversalTone UniversalTone
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600AAD8 RID: 43736 RVA: 0x001812BC File Offset: 0x0017F4BC
		// (set) Token: 0x0600AAD9 RID: 43737 RVA: 0x00181309 File Offset: 0x0017F509
		public virtual ITalkBackground BackgroundConfig
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600AADA RID: 43738 RVA: 0x0018132C File Offset: 0x0017F52C
		// (set) Token: 0x0600AADB RID: 43739 RVA: 0x00181381 File Offset: 0x0017F581
		public virtual bool? PlayVoice
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600AADC RID: 43740 RVA: 0x001813A4 File Offset: 0x0017F5A4
		// (set) Token: 0x0600AADD RID: 43741 RVA: 0x00181420 File Offset: 0x0017F620
		public virtual ITimeLimitOptionGroup TimeLimitOptionGroup
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600AADE RID: 43742 RVA: 0x00181448 File Offset: 0x0017F648
		// (set) Token: 0x0600AADF RID: 43743 RVA: 0x001814C4 File Offset: 0x0017F6C4
		public virtual IGamepadShakeInTalk GamepadShake
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600AAE0 RID: 43744 RVA: 0x001814EC File Offset: 0x0017F6EC
		// (set) Token: 0x0600AAE1 RID: 43745 RVA: 0x0018159A File Offset: 0x0017F79A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> IntroActions
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x001815C4 File Offset: 0x0017F7C4
		// (set) Token: 0x0600AAE3 RID: 43747 RVA: 0x00181672 File Offset: 0x0017F872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorFxEmote> ActorFxEmoteArray
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600AAE4 RID: 43748 RVA: 0x0018169C File Offset: 0x0017F89C
		// (set) Token: 0x0600AAE5 RID: 43749 RVA: 0x001816E9 File Offset: 0x0017F8E9
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITalkEffectActionType> TalkEffectArray
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
				ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600AAE6 RID: 43750 RVA: 0x0018170C File Offset: 0x0017F90C
		// (set) Token: 0x0600AAE7 RID: 43751 RVA: 0x001817BD File Offset: 0x0017F9BD
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorVisibility> ActorVisibilityArray
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
					ITalkItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006553 RID: 25939
		protected ITalkItem FbInstance;

		// Token: 0x04006554 RID: 25940
		protected ITalkItem_SetValue PocoInterface;

		// Token: 0x04006555 RID: 25941
		private ulong _SetMark;

		// Token: 0x04006556 RID: 25942
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006557 RID: 25943
		private bool _CaptionParamsInited;

		// Token: 0x04006558 RID: 25944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006559 RID: 25945
		private bool _ActionsInited;

		// Token: 0x0400655A RID: 25946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x0400655B RID: 25947
		private bool _OptionsInited;

		// Token: 0x0400655C RID: 25948
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x0400655D RID: 25949
		private bool _MontageInited;

		// Token: 0x0400655E RID: 25950
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x0400655F RID: 25951
		private bool _CameraDataInited;

		// Token: 0x04006560 RID: 25952
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006561 RID: 25953
		private bool _FlowTemplateInited;

		// Token: 0x04006562 RID: 25954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006563 RID: 25955
		private bool _FlowTemplateListInited;

		// Token: 0x04006564 RID: 25956
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006565 RID: 25957
		private bool _ActorMontageArrayInited;

		// Token: 0x04006566 RID: 25958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006567 RID: 25959
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006568 RID: 25960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006569 RID: 25961
		private bool _ActorLookAtArrayInited;

		// Token: 0x0400656A RID: 25962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x0400656B RID: 25963
		private bool _ActorTurnToArrayInited;

		// Token: 0x0400656C RID: 25964
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x0400656D RID: 25965
		private bool _UniversalToneInited;

		// Token: 0x0400656E RID: 25966
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400656F RID: 25967
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006570 RID: 25968
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006571 RID: 25969
		private bool _GamepadShakeInited;

		// Token: 0x04006572 RID: 25970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006573 RID: 25971
		private bool _IntroActionsInited;

		// Token: 0x04006574 RID: 25972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006575 RID: 25973
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006576 RID: 25974
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006577 RID: 25975
		private bool _ActorVisibilityArrayInited;
	}
}
