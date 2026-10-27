using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F48 RID: 8008
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemPhoneMessage : ITalkItem
	{
		// Token: 0x0600ADF6 RID: 44534 RVA: 0x0018FFB8 File Offset: 0x0018E1B8
		[NullableContext(1)]
		private ITalkItemPhoneMessage_SetValue GetOrCreatePoco()
		{
			ITalkItemPhoneMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessage_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x0018FFDD File Offset: 0x0018E1DD
		[NullableContext(1)]
		public static ITalkItemPhoneMessage Create([Nullable(2)] ITalkItemPhoneMessage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x0018FFF0 File Offset: 0x0018E1F0
		[NullableContext(1)]
		public static ITalkItemPhoneMessage CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x00190004 File Offset: 0x0018E204
		[NullableContext(1)]
		public new ITalkItemPhoneMessage_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessage_SetValue
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
				MessageType = this.MessageType,
				Style = this.Style,
				OtherIsTypingDuration = this.OtherIsTypingDuration
			};
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x001901C8 File Offset: 0x0018E3C8
		// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x00190219 File Offset: 0x0018E419
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x00190238 File Offset: 0x0018E438
		// (set) Token: 0x0600ADFD RID: 44541 RVA: 0x00190285 File Offset: 0x0018E485
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

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x001902A4 File Offset: 0x0018E4A4
		// (set) Token: 0x0600ADFF RID: 44543 RVA: 0x001902F5 File Offset: 0x0018E4F5
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x00190312 File Offset: 0x0018E512
		// (set) Token: 0x0600AE01 RID: 44545 RVA: 0x00190350 File Offset: 0x0018E550
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600AE02 RID: 44546 RVA: 0x00190370 File Offset: 0x0018E570
		// (set) Token: 0x0600AE03 RID: 44547 RVA: 0x001903BE File Offset: 0x0018E5BE
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

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600AE04 RID: 44548 RVA: 0x001903DC File Offset: 0x0018E5DC
		// (set) Token: 0x0600AE05 RID: 44549 RVA: 0x0019042E File Offset: 0x0018E62E
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600AE06 RID: 44550 RVA: 0x0019044C File Offset: 0x0018E64C
		// (set) Token: 0x0600AE07 RID: 44551 RVA: 0x0019049E File Offset: 0x0018E69E
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600AE08 RID: 44552 RVA: 0x001904BC File Offset: 0x0018E6BC
		// (set) Token: 0x0600AE09 RID: 44553 RVA: 0x00190511 File Offset: 0x0018E711
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600AE0A RID: 44554 RVA: 0x00190534 File Offset: 0x0018E734
		// (set) Token: 0x0600AE0B RID: 44555 RVA: 0x00190589 File Offset: 0x0018E789
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600AE0C RID: 44556 RVA: 0x001905AC File Offset: 0x0018E7AC
		// (set) Token: 0x0600AE0D RID: 44557 RVA: 0x001905F9 File Offset: 0x0018E7F9
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x0019061C File Offset: 0x0018E81C
		// (set) Token: 0x0600AE0F RID: 44559 RVA: 0x00190671 File Offset: 0x0018E871
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x00190694 File Offset: 0x0018E894
		// (set) Token: 0x0600AE11 RID: 44561 RVA: 0x00190710 File Offset: 0x0018E910
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600AE12 RID: 44562 RVA: 0x00190738 File Offset: 0x0018E938
		// (set) Token: 0x0600AE13 RID: 44563 RVA: 0x001907E6 File Offset: 0x0018E9E6
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x00190810 File Offset: 0x0018EA10
		// (set) Token: 0x0600AE15 RID: 44565 RVA: 0x001908BE File Offset: 0x0018EABE
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600AE16 RID: 44566 RVA: 0x001908E8 File Offset: 0x0018EAE8
		// (set) Token: 0x0600AE17 RID: 44567 RVA: 0x00190964 File Offset: 0x0018EB64
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600AE18 RID: 44568 RVA: 0x0019098C File Offset: 0x0018EB8C
		// (set) Token: 0x0600AE19 RID: 44569 RVA: 0x00190A08 File Offset: 0x0018EC08
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600AE1A RID: 44570 RVA: 0x00190A30 File Offset: 0x0018EC30
		// (set) Token: 0x0600AE1B RID: 44571 RVA: 0x00190AAC File Offset: 0x0018ECAC
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600AE1C RID: 44572 RVA: 0x00190AD4 File Offset: 0x0018ECD4
		// (set) Token: 0x0600AE1D RID: 44573 RVA: 0x00190B82 File Offset: 0x0018ED82
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x00190BAC File Offset: 0x0018EDAC
		// (set) Token: 0x0600AE1F RID: 44575 RVA: 0x00190C5A File Offset: 0x0018EE5A
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600AE20 RID: 44576 RVA: 0x00190C84 File Offset: 0x0018EE84
		// (set) Token: 0x0600AE21 RID: 44577 RVA: 0x00190D32 File Offset: 0x0018EF32
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600AE22 RID: 44578 RVA: 0x00190D5C File Offset: 0x0018EF5C
		// (set) Token: 0x0600AE23 RID: 44579 RVA: 0x00190E0A File Offset: 0x0018F00A
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600AE24 RID: 44580 RVA: 0x00190E34 File Offset: 0x0018F034
		// (set) Token: 0x0600AE25 RID: 44581 RVA: 0x00190EE2 File Offset: 0x0018F0E2
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600AE26 RID: 44582 RVA: 0x00190F0C File Offset: 0x0018F10C
		// (set) Token: 0x0600AE27 RID: 44583 RVA: 0x00190F59 File Offset: 0x0018F159
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600AE28 RID: 44584 RVA: 0x00190F7C File Offset: 0x0018F17C
		// (set) Token: 0x0600AE29 RID: 44585 RVA: 0x00190FC9 File Offset: 0x0018F1C9
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600AE2A RID: 44586 RVA: 0x00190FEC File Offset: 0x0018F1EC
		// (set) Token: 0x0600AE2B RID: 44587 RVA: 0x00191068 File Offset: 0x0018F268
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600AE2C RID: 44588 RVA: 0x00191090 File Offset: 0x0018F290
		// (set) Token: 0x0600AE2D RID: 44589 RVA: 0x001910DD File Offset: 0x0018F2DD
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600AE2E RID: 44590 RVA: 0x00191100 File Offset: 0x0018F300
		// (set) Token: 0x0600AE2F RID: 44591 RVA: 0x00191155 File Offset: 0x0018F355
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600AE30 RID: 44592 RVA: 0x00191178 File Offset: 0x0018F378
		// (set) Token: 0x0600AE31 RID: 44593 RVA: 0x001911F4 File Offset: 0x0018F3F4
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600AE32 RID: 44594 RVA: 0x0019121C File Offset: 0x0018F41C
		// (set) Token: 0x0600AE33 RID: 44595 RVA: 0x00191298 File Offset: 0x0018F498
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600AE34 RID: 44596 RVA: 0x001912C0 File Offset: 0x0018F4C0
		// (set) Token: 0x0600AE35 RID: 44597 RVA: 0x0019136E File Offset: 0x0018F56E
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x00191398 File Offset: 0x0018F598
		// (set) Token: 0x0600AE37 RID: 44599 RVA: 0x00191446 File Offset: 0x0018F646
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600AE38 RID: 44600 RVA: 0x00191470 File Offset: 0x0018F670
		// (set) Token: 0x0600AE39 RID: 44601 RVA: 0x001914BD File Offset: 0x0018F6BD
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
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600AE3A RID: 44602 RVA: 0x001914E0 File Offset: 0x0018F6E0
		// (set) Token: 0x0600AE3B RID: 44603 RVA: 0x00191591 File Offset: 0x0018F791
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600AE3C RID: 44604 RVA: 0x001915BC File Offset: 0x0018F7BC
		// (set) Token: 0x0600AE3D RID: 44605 RVA: 0x0019160C File Offset: 0x0018F80C
		[Nullable(1)]
		public virtual ITalkItemPhoneMessageBase MessageType
		{
			[NullableContext(1)]
			get
			{
				if ((this._SetMark & 8589934592UL) != 0UL)
				{
					return this.PocoInterface.MessageType;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.MessageType;
				}
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MessageType;
			}
			[NullableContext(1)]
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().MessageType = value;
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600AE3E RID: 44606 RVA: 0x00191630 File Offset: 0x0018F830
		// (set) Token: 0x0600AE3F RID: 44607 RVA: 0x00191680 File Offset: 0x0018F880
		public virtual ITalkItemStyle Style
		{
			get
			{
				if ((this._SetMark & 17179869184UL) != 0UL)
				{
					return this.PocoInterface.Style;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.Style;
				}
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Style;
			}
			set
			{
				this._SetMark |= 17179869184UL;
				this.GetOrCreatePoco().Style = value;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x001916A4 File Offset: 0x0018F8A4
		// (set) Token: 0x0600AE41 RID: 44609 RVA: 0x001916FC File Offset: 0x0018F8FC
		public virtual float? OtherIsTypingDuration
		{
			get
			{
				if ((this._SetMark & 34359738368UL) != 0UL)
				{
					return this.PocoInterface.OtherIsTypingDuration;
				}
				if (this.FbInstance != null)
				{
					return this.FbInstance.OtherIsTypingDuration;
				}
				ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OtherIsTypingDuration;
			}
			set
			{
				this._SetMark |= 34359738368UL;
				this.GetOrCreatePoco().OtherIsTypingDuration = value;
			}
		}

		// Token: 0x0400687E RID: 26750
		protected new ITalkItemPhoneMessage FbInstance;

		// Token: 0x0400687F RID: 26751
		protected new ITalkItemPhoneMessage_SetValue PocoInterface;

		// Token: 0x04006880 RID: 26752
		private ulong _SetMark;

		// Token: 0x04006881 RID: 26753
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006882 RID: 26754
		private bool _CaptionParamsInited;

		// Token: 0x04006883 RID: 26755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006884 RID: 26756
		private bool _ActionsInited;

		// Token: 0x04006885 RID: 26757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006886 RID: 26758
		private bool _OptionsInited;

		// Token: 0x04006887 RID: 26759
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x04006888 RID: 26760
		private bool _MontageInited;

		// Token: 0x04006889 RID: 26761
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x0400688A RID: 26762
		private bool _CameraDataInited;

		// Token: 0x0400688B RID: 26763
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x0400688C RID: 26764
		private bool _FlowTemplateInited;

		// Token: 0x0400688D RID: 26765
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x0400688E RID: 26766
		private bool _FlowTemplateListInited;

		// Token: 0x0400688F RID: 26767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006890 RID: 26768
		private bool _ActorMontageArrayInited;

		// Token: 0x04006891 RID: 26769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006892 RID: 26770
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006893 RID: 26771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006894 RID: 26772
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006895 RID: 26773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006896 RID: 26774
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006897 RID: 26775
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006898 RID: 26776
		private bool _UniversalToneInited;

		// Token: 0x04006899 RID: 26777
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x0400689A RID: 26778
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x0400689B RID: 26779
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x0400689C RID: 26780
		private bool _GamepadShakeInited;

		// Token: 0x0400689D RID: 26781
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x0400689E RID: 26782
		private bool _IntroActionsInited;

		// Token: 0x0400689F RID: 26783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040068A0 RID: 26784
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040068A1 RID: 26785
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040068A2 RID: 26786
		private bool _ActorVisibilityArrayInited;
	}
}
