using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002181 RID: 8577
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemPhoneMessage : ITalkItem
	{
		// Token: 0x0600B8C8 RID: 47304 RVA: 0x001A5FB0 File Offset: 0x001A41B0
		[NullableContext(0)]
		private ITalkItemPhoneMessage_SetValue GetOrCreatePoco()
		{
			ITalkItemPhoneMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessage_SetValue());
			}
			return result;
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x001A5FD5 File Offset: 0x001A41D5
		[NullableContext(0)]
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

		// Token: 0x0600B8CA RID: 47306 RVA: 0x001A5FE8 File Offset: 0x001A41E8
		[NullableContext(0)]
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

		// Token: 0x0600B8CB RID: 47307 RVA: 0x001A5FFC File Offset: 0x001A41FC
		[NullableContext(0)]
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

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x001A61C0 File Offset: 0x001A43C0
		// (set) Token: 0x0600B8CD RID: 47309 RVA: 0x001A6211 File Offset: 0x001A4411
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

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x001A6230 File Offset: 0x001A4430
		// (set) Token: 0x0600B8CF RID: 47311 RVA: 0x001A627D File Offset: 0x001A447D
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

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600B8D0 RID: 47312 RVA: 0x001A629C File Offset: 0x001A449C
		// (set) Token: 0x0600B8D1 RID: 47313 RVA: 0x001A62ED File Offset: 0x001A44ED
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

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x001A630A File Offset: 0x001A450A
		// (set) Token: 0x0600B8D3 RID: 47315 RVA: 0x001A6348 File Offset: 0x001A4548
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

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600B8D4 RID: 47316 RVA: 0x001A6368 File Offset: 0x001A4568
		// (set) Token: 0x0600B8D5 RID: 47317 RVA: 0x001A63B6 File Offset: 0x001A45B6
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

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600B8D6 RID: 47318 RVA: 0x001A63D4 File Offset: 0x001A45D4
		// (set) Token: 0x0600B8D7 RID: 47319 RVA: 0x001A6426 File Offset: 0x001A4626
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

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x001A6444 File Offset: 0x001A4644
		// (set) Token: 0x0600B8D9 RID: 47321 RVA: 0x001A6496 File Offset: 0x001A4696
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

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x001A64B4 File Offset: 0x001A46B4
		// (set) Token: 0x0600B8DB RID: 47323 RVA: 0x001A6509 File Offset: 0x001A4709
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

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600B8DC RID: 47324 RVA: 0x001A652C File Offset: 0x001A472C
		// (set) Token: 0x0600B8DD RID: 47325 RVA: 0x001A6581 File Offset: 0x001A4781
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

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x001A65A4 File Offset: 0x001A47A4
		// (set) Token: 0x0600B8DF RID: 47327 RVA: 0x001A65F1 File Offset: 0x001A47F1
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

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600B8E0 RID: 47328 RVA: 0x001A6614 File Offset: 0x001A4814
		// (set) Token: 0x0600B8E1 RID: 47329 RVA: 0x001A6669 File Offset: 0x001A4869
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

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600B8E2 RID: 47330 RVA: 0x001A668C File Offset: 0x001A488C
		// (set) Token: 0x0600B8E3 RID: 47331 RVA: 0x001A6708 File Offset: 0x001A4908
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

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600B8E4 RID: 47332 RVA: 0x001A6730 File Offset: 0x001A4930
		// (set) Token: 0x0600B8E5 RID: 47333 RVA: 0x001A67DE File Offset: 0x001A49DE
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600B8E6 RID: 47334 RVA: 0x001A6808 File Offset: 0x001A4A08
		// (set) Token: 0x0600B8E7 RID: 47335 RVA: 0x001A68B6 File Offset: 0x001A4AB6
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600B8E8 RID: 47336 RVA: 0x001A68E0 File Offset: 0x001A4AE0
		// (set) Token: 0x0600B8E9 RID: 47337 RVA: 0x001A695C File Offset: 0x001A4B5C
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

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600B8EA RID: 47338 RVA: 0x001A6984 File Offset: 0x001A4B84
		// (set) Token: 0x0600B8EB RID: 47339 RVA: 0x001A6A00 File Offset: 0x001A4C00
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

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600B8EC RID: 47340 RVA: 0x001A6A28 File Offset: 0x001A4C28
		// (set) Token: 0x0600B8ED RID: 47341 RVA: 0x001A6AA4 File Offset: 0x001A4CA4
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

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x001A6ACC File Offset: 0x001A4CCC
		// (set) Token: 0x0600B8EF RID: 47343 RVA: 0x001A6B7A File Offset: 0x001A4D7A
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600B8F0 RID: 47344 RVA: 0x001A6BA4 File Offset: 0x001A4DA4
		// (set) Token: 0x0600B8F1 RID: 47345 RVA: 0x001A6C52 File Offset: 0x001A4E52
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600B8F2 RID: 47346 RVA: 0x001A6C7C File Offset: 0x001A4E7C
		// (set) Token: 0x0600B8F3 RID: 47347 RVA: 0x001A6D2A File Offset: 0x001A4F2A
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x001A6D54 File Offset: 0x001A4F54
		// (set) Token: 0x0600B8F5 RID: 47349 RVA: 0x001A6E02 File Offset: 0x001A5002
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x001A6E2C File Offset: 0x001A502C
		// (set) Token: 0x0600B8F7 RID: 47351 RVA: 0x001A6EDA File Offset: 0x001A50DA
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x001A6F04 File Offset: 0x001A5104
		// (set) Token: 0x0600B8F9 RID: 47353 RVA: 0x001A6F51 File Offset: 0x001A5151
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

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x001A6F74 File Offset: 0x001A5174
		// (set) Token: 0x0600B8FB RID: 47355 RVA: 0x001A6FC1 File Offset: 0x001A51C1
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

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x001A6FE4 File Offset: 0x001A51E4
		// (set) Token: 0x0600B8FD RID: 47357 RVA: 0x001A7060 File Offset: 0x001A5260
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

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x001A7088 File Offset: 0x001A5288
		// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x001A70D5 File Offset: 0x001A52D5
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

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x001A70F8 File Offset: 0x001A52F8
		// (set) Token: 0x0600B901 RID: 47361 RVA: 0x001A714D File Offset: 0x001A534D
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

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x001A7170 File Offset: 0x001A5370
		// (set) Token: 0x0600B903 RID: 47363 RVA: 0x001A71EC File Offset: 0x001A53EC
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

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600B904 RID: 47364 RVA: 0x001A7214 File Offset: 0x001A5414
		// (set) Token: 0x0600B905 RID: 47365 RVA: 0x001A7290 File Offset: 0x001A5490
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

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600B906 RID: 47366 RVA: 0x001A72B8 File Offset: 0x001A54B8
		// (set) Token: 0x0600B907 RID: 47367 RVA: 0x001A7366 File Offset: 0x001A5566
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600B908 RID: 47368 RVA: 0x001A7390 File Offset: 0x001A5590
		// (set) Token: 0x0600B909 RID: 47369 RVA: 0x001A743E File Offset: 0x001A563E
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600B90A RID: 47370 RVA: 0x001A7468 File Offset: 0x001A5668
		// (set) Token: 0x0600B90B RID: 47371 RVA: 0x001A74B5 File Offset: 0x001A56B5
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
				0
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600B90C RID: 47372 RVA: 0x001A74D8 File Offset: 0x001A56D8
		// (set) Token: 0x0600B90D RID: 47373 RVA: 0x001A7589 File Offset: 0x001A5789
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
					ITalkItemPhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600B90E RID: 47374 RVA: 0x001A75B4 File Offset: 0x001A57B4
		// (set) Token: 0x0600B90F RID: 47375 RVA: 0x001A7604 File Offset: 0x001A5804
		[Nullable(0)]
		public virtual ITalkItemPhoneMessageBase MessageType
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this._SetMark |= 8589934592UL;
				this.GetOrCreatePoco().MessageType = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600B910 RID: 47376 RVA: 0x001A7628 File Offset: 0x001A5828
		// (set) Token: 0x0600B911 RID: 47377 RVA: 0x001A7678 File Offset: 0x001A5878
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

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600B912 RID: 47378 RVA: 0x001A769C File Offset: 0x001A589C
		// (set) Token: 0x0600B913 RID: 47379 RVA: 0x001A76F4 File Offset: 0x001A58F4
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

		// Token: 0x04006E6D RID: 28269
		protected new ITalkItemPhoneMessage FbInstance;

		// Token: 0x04006E6E RID: 28270
		protected new ITalkItemPhoneMessage_SetValue PocoInterface;

		// Token: 0x04006E6F RID: 28271
		private ulong _SetMark;

		// Token: 0x04006E70 RID: 28272
		[Nullable(0)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x04006E71 RID: 28273
		private bool _CaptionParamsInited;

		// Token: 0x04006E72 RID: 28274
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006E73 RID: 28275
		private bool _ActionsInited;

		// Token: 0x04006E74 RID: 28276
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x04006E75 RID: 28277
		private bool _OptionsInited;

		// Token: 0x04006E76 RID: 28278
		[Nullable(0)]
		private PlayMontage _MontageCache;

		// Token: 0x04006E77 RID: 28279
		private bool _MontageInited;

		// Token: 0x04006E78 RID: 28280
		[Nullable(0)]
		private ICameraData _CameraDataCache;

		// Token: 0x04006E79 RID: 28281
		private bool _CameraDataInited;

		// Token: 0x04006E7A RID: 28282
		[Nullable(0)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x04006E7B RID: 28283
		private bool _FlowTemplateInited;

		// Token: 0x04006E7C RID: 28284
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x04006E7D RID: 28285
		private bool _FlowTemplateListInited;

		// Token: 0x04006E7E RID: 28286
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x04006E7F RID: 28287
		private bool _ActorMontageArrayInited;

		// Token: 0x04006E80 RID: 28288
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x04006E81 RID: 28289
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x04006E82 RID: 28290
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x04006E83 RID: 28291
		private bool _ActorLookAtArrayInited;

		// Token: 0x04006E84 RID: 28292
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x04006E85 RID: 28293
		private bool _ActorTurnToArrayInited;

		// Token: 0x04006E86 RID: 28294
		[Nullable(0)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x04006E87 RID: 28295
		private bool _UniversalToneInited;

		// Token: 0x04006E88 RID: 28296
		[Nullable(0)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x04006E89 RID: 28297
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x04006E8A RID: 28298
		[Nullable(0)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x04006E8B RID: 28299
		private bool _GamepadShakeInited;

		// Token: 0x04006E8C RID: 28300
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x04006E8D RID: 28301
		private bool _IntroActionsInited;

		// Token: 0x04006E8E RID: 28302
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x04006E8F RID: 28303
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x04006E90 RID: 28304
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x04006E91 RID: 28305
		private bool _ActorVisibilityArrayInited;
	}
}
