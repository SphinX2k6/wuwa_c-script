using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F40 RID: 8000
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDialog : ITalkItem
	{
		// Token: 0x0600AD04 RID: 44292 RVA: 0x0018B85C File Offset: 0x00189A5C
		[NullableContext(1)]
		private ITalkItemDialog_SetValue GetOrCreatePoco()
		{
			ITalkItemDialog_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemDialog_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x0018B881 File Offset: 0x00189A81
		[NullableContext(1)]
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

		// Token: 0x0600AD06 RID: 44294 RVA: 0x0018B894 File Offset: 0x00189A94
		[NullableContext(1)]
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

		// Token: 0x0600AD07 RID: 44295 RVA: 0x0018B8A8 File Offset: 0x00189AA8
		[NullableContext(1)]
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

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600AD08 RID: 44296 RVA: 0x0018BA84 File Offset: 0x00189C84
		// (set) Token: 0x0600AD09 RID: 44297 RVA: 0x0018BAD5 File Offset: 0x00189CD5
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

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600AD0A RID: 44298 RVA: 0x0018BAF4 File Offset: 0x00189CF4
		// (set) Token: 0x0600AD0B RID: 44299 RVA: 0x0018BB41 File Offset: 0x00189D41
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

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600AD0C RID: 44300 RVA: 0x0018BB60 File Offset: 0x00189D60
		// (set) Token: 0x0600AD0D RID: 44301 RVA: 0x0018BBB1 File Offset: 0x00189DB1
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

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600AD0E RID: 44302 RVA: 0x0018BBCE File Offset: 0x00189DCE
		// (set) Token: 0x0600AD0F RID: 44303 RVA: 0x0018BC0C File Offset: 0x00189E0C
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

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600AD10 RID: 44304 RVA: 0x0018BC2C File Offset: 0x00189E2C
		// (set) Token: 0x0600AD11 RID: 44305 RVA: 0x0018BC7A File Offset: 0x00189E7A
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

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600AD12 RID: 44306 RVA: 0x0018BC98 File Offset: 0x00189E98
		// (set) Token: 0x0600AD13 RID: 44307 RVA: 0x0018BCEA File Offset: 0x00189EEA
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

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600AD14 RID: 44308 RVA: 0x0018BD08 File Offset: 0x00189F08
		// (set) Token: 0x0600AD15 RID: 44309 RVA: 0x0018BD5A File Offset: 0x00189F5A
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

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600AD16 RID: 44310 RVA: 0x0018BD78 File Offset: 0x00189F78
		// (set) Token: 0x0600AD17 RID: 44311 RVA: 0x0018BDCD File Offset: 0x00189FCD
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

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600AD18 RID: 44312 RVA: 0x0018BDF0 File Offset: 0x00189FF0
		// (set) Token: 0x0600AD19 RID: 44313 RVA: 0x0018BE45 File Offset: 0x0018A045
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

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x0018BE68 File Offset: 0x0018A068
		// (set) Token: 0x0600AD1B RID: 44315 RVA: 0x0018BEB5 File Offset: 0x0018A0B5
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

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600AD1C RID: 44316 RVA: 0x0018BED8 File Offset: 0x0018A0D8
		// (set) Token: 0x0600AD1D RID: 44317 RVA: 0x0018BF2D File Offset: 0x0018A12D
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

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600AD1E RID: 44318 RVA: 0x0018BF50 File Offset: 0x0018A150
		// (set) Token: 0x0600AD1F RID: 44319 RVA: 0x0018BFCC File Offset: 0x0018A1CC
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

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600AD20 RID: 44320 RVA: 0x0018BFF4 File Offset: 0x0018A1F4
		// (set) Token: 0x0600AD21 RID: 44321 RVA: 0x0018C0A2 File Offset: 0x0018A2A2
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600AD22 RID: 44322 RVA: 0x0018C0CC File Offset: 0x0018A2CC
		// (set) Token: 0x0600AD23 RID: 44323 RVA: 0x0018C17A File Offset: 0x0018A37A
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600AD24 RID: 44324 RVA: 0x0018C1A4 File Offset: 0x0018A3A4
		// (set) Token: 0x0600AD25 RID: 44325 RVA: 0x0018C220 File Offset: 0x0018A420
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

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600AD26 RID: 44326 RVA: 0x0018C248 File Offset: 0x0018A448
		// (set) Token: 0x0600AD27 RID: 44327 RVA: 0x0018C2C4 File Offset: 0x0018A4C4
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

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600AD28 RID: 44328 RVA: 0x0018C2EC File Offset: 0x0018A4EC
		// (set) Token: 0x0600AD29 RID: 44329 RVA: 0x0018C368 File Offset: 0x0018A568
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

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600AD2A RID: 44330 RVA: 0x0018C390 File Offset: 0x0018A590
		// (set) Token: 0x0600AD2B RID: 44331 RVA: 0x0018C43E File Offset: 0x0018A63E
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600AD2C RID: 44332 RVA: 0x0018C468 File Offset: 0x0018A668
		// (set) Token: 0x0600AD2D RID: 44333 RVA: 0x0018C516 File Offset: 0x0018A716
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600AD2E RID: 44334 RVA: 0x0018C540 File Offset: 0x0018A740
		// (set) Token: 0x0600AD2F RID: 44335 RVA: 0x0018C5EE File Offset: 0x0018A7EE
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600AD30 RID: 44336 RVA: 0x0018C618 File Offset: 0x0018A818
		// (set) Token: 0x0600AD31 RID: 44337 RVA: 0x0018C6C6 File Offset: 0x0018A8C6
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x0018C6F0 File Offset: 0x0018A8F0
		// (set) Token: 0x0600AD33 RID: 44339 RVA: 0x0018C79E File Offset: 0x0018A99E
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600AD34 RID: 44340 RVA: 0x0018C7C8 File Offset: 0x0018A9C8
		// (set) Token: 0x0600AD35 RID: 44341 RVA: 0x0018C815 File Offset: 0x0018AA15
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

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600AD36 RID: 44342 RVA: 0x0018C838 File Offset: 0x0018AA38
		// (set) Token: 0x0600AD37 RID: 44343 RVA: 0x0018C885 File Offset: 0x0018AA85
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

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600AD38 RID: 44344 RVA: 0x0018C8A8 File Offset: 0x0018AAA8
		// (set) Token: 0x0600AD39 RID: 44345 RVA: 0x0018C924 File Offset: 0x0018AB24
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

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600AD3A RID: 44346 RVA: 0x0018C94C File Offset: 0x0018AB4C
		// (set) Token: 0x0600AD3B RID: 44347 RVA: 0x0018C999 File Offset: 0x0018AB99
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

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600AD3C RID: 44348 RVA: 0x0018C9BC File Offset: 0x0018ABBC
		// (set) Token: 0x0600AD3D RID: 44349 RVA: 0x0018CA11 File Offset: 0x0018AC11
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

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600AD3E RID: 44350 RVA: 0x0018CA34 File Offset: 0x0018AC34
		// (set) Token: 0x0600AD3F RID: 44351 RVA: 0x0018CAB0 File Offset: 0x0018ACB0
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

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600AD40 RID: 44352 RVA: 0x0018CAD8 File Offset: 0x0018ACD8
		// (set) Token: 0x0600AD41 RID: 44353 RVA: 0x0018CB54 File Offset: 0x0018AD54
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

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600AD42 RID: 44354 RVA: 0x0018CB7C File Offset: 0x0018AD7C
		// (set) Token: 0x0600AD43 RID: 44355 RVA: 0x0018CC2A File Offset: 0x0018AE2A
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600AD44 RID: 44356 RVA: 0x0018CC54 File Offset: 0x0018AE54
		// (set) Token: 0x0600AD45 RID: 44357 RVA: 0x0018CD02 File Offset: 0x0018AF02
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600AD46 RID: 44358 RVA: 0x0018CD2C File Offset: 0x0018AF2C
		// (set) Token: 0x0600AD47 RID: 44359 RVA: 0x0018CD79 File Offset: 0x0018AF79
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
				1
			})]
			set
			{
				this._SetMark |= (ulong)int.MinValue;
				this.GetOrCreatePoco().TalkEffectArray = value;
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600AD48 RID: 44360 RVA: 0x0018CD9C File Offset: 0x0018AF9C
		// (set) Token: 0x0600AD49 RID: 44361 RVA: 0x0018CE4D File Offset: 0x0018B04D
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
					ITalkItemDialog_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x0018CE78 File Offset: 0x0018B078
		// (set) Token: 0x0600AD4B RID: 44363 RVA: 0x0018CEC8 File Offset: 0x0018B0C8
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

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600AD4C RID: 44364 RVA: 0x0018CEEC File Offset: 0x0018B0EC
		// (set) Token: 0x0600AD4D RID: 44365 RVA: 0x0018CF3C File Offset: 0x0018B13C
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

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600AD4E RID: 44366 RVA: 0x0018CF60 File Offset: 0x0018B160
		// (set) Token: 0x0600AD4F RID: 44367 RVA: 0x0018CFDF File Offset: 0x0018B1DF
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

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x0018D00C File Offset: 0x0018B20C
		// (set) Token: 0x0600AD51 RID: 44369 RVA: 0x0018D064 File Offset: 0x0018B264
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

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x0018D088 File Offset: 0x0018B288
		// (set) Token: 0x0600AD53 RID: 44371 RVA: 0x0018D0E0 File Offset: 0x0018B2E0
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

		// Token: 0x0400679C RID: 26524
		protected new ITalkItemDialog FbInstance;

		// Token: 0x0400679D RID: 26525
		protected new ITalkItemDialog_SetValue PocoInterface;

		// Token: 0x0400679E RID: 26526
		private ulong _SetMark;

		// Token: 0x0400679F RID: 26527
		[Nullable(1)]
		private ICaptionParam _CaptionParamsCache;

		// Token: 0x040067A0 RID: 26528
		private bool _CaptionParamsInited;

		// Token: 0x040067A1 RID: 26529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040067A2 RID: 26530
		private bool _ActionsInited;

		// Token: 0x040067A3 RID: 26531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkOption> _OptionsCache;

		// Token: 0x040067A4 RID: 26532
		private bool _OptionsInited;

		// Token: 0x040067A5 RID: 26533
		[Nullable(1)]
		private PlayMontage _MontageCache;

		// Token: 0x040067A6 RID: 26534
		private bool _MontageInited;

		// Token: 0x040067A7 RID: 26535
		[Nullable(1)]
		private ICameraData _CameraDataCache;

		// Token: 0x040067A8 RID: 26536
		private bool _CameraDataInited;

		// Token: 0x040067A9 RID: 26537
		[Nullable(1)]
		private SetFlowTemplate _FlowTemplateCache;

		// Token: 0x040067AA RID: 26538
		private bool _FlowTemplateInited;

		// Token: 0x040067AB RID: 26539
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SetFlowTemplate> _FlowTemplateListCache;

		// Token: 0x040067AC RID: 26540
		private bool _FlowTemplateListInited;

		// Token: 0x040067AD RID: 26541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMontageData> _ActorMontageArrayCache;

		// Token: 0x040067AE RID: 26542
		private bool _ActorMontageArrayInited;

		// Token: 0x040067AF RID: 26543
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFaceExpression> _ActorFaceExpressionArrayCache;

		// Token: 0x040067B0 RID: 26544
		private bool _ActorFaceExpressionArrayInited;

		// Token: 0x040067B1 RID: 26545
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorLookAt> _ActorLookAtArrayCache;

		// Token: 0x040067B2 RID: 26546
		private bool _ActorLookAtArrayInited;

		// Token: 0x040067B3 RID: 26547
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorTurnTo> _ActorTurnToArrayCache;

		// Token: 0x040067B4 RID: 26548
		private bool _ActorTurnToArrayInited;

		// Token: 0x040067B5 RID: 26549
		[Nullable(1)]
		private IUniversalTone _UniversalToneCache;

		// Token: 0x040067B6 RID: 26550
		private bool _UniversalToneInited;

		// Token: 0x040067B7 RID: 26551
		[Nullable(1)]
		private ITimeLimitOptionGroup _TimeLimitOptionGroupCache;

		// Token: 0x040067B8 RID: 26552
		private bool _TimeLimitOptionGroupInited;

		// Token: 0x040067B9 RID: 26553
		[Nullable(1)]
		private IGamepadShakeInTalk _GamepadShakeCache;

		// Token: 0x040067BA RID: 26554
		private bool _GamepadShakeInited;

		// Token: 0x040067BB RID: 26555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _IntroActionsCache;

		// Token: 0x040067BC RID: 26556
		private bool _IntroActionsInited;

		// Token: 0x040067BD RID: 26557
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmote> _ActorFxEmoteArrayCache;

		// Token: 0x040067BE RID: 26558
		private bool _ActorFxEmoteArrayInited;

		// Token: 0x040067BF RID: 26559
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorVisibility> _ActorVisibilityArrayCache;

		// Token: 0x040067C0 RID: 26560
		private bool _ActorVisibilityArrayInited;

		// Token: 0x040067C1 RID: 26561
		[Nullable(1)]
		private ITalkItemAutoPlayConfig _AutoPlayConfigCache;

		// Token: 0x040067C2 RID: 26562
		private bool _AutoPlayConfigInited;
	}
}
