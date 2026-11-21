using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000032 RID: 50
	public class BubbleComponent : IComponentBase
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x0001877C File Offset: 0x0001697C
		private BubbleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BubbleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BubbleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BubbleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000187B4 File Offset: 0x000169B4
		public static BubbleComponent Create([Nullable(2)] BubbleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BubbleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000187C7 File Offset: 0x000169C7
		public static BubbleComponent CreateFromSetValue([Nullable(2)] BubbleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BubbleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000187DC File Offset: 0x000169DC
		public new BubbleComponent_SetValue ToSetValue()
		{
			return new BubbleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				NpcIds = this.NpcIds,
				EnterRange = this.EnterRange,
				LeaveRange = this.LeaveRange,
				IsRangeFollowEntity = this.IsRangeFollowEntity,
				Flows = this.Flows,
				TimberId = this.TimberId,
				Scale = this.Scale,
				IsAudioOccludedByScene = this.IsAudioOccludedByScene,
				TriggerCylinderConfig = this.TriggerCylinderConfig,
				IsPlayMouthAnim = this.IsPlayMouthAnim
			};
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00018880 File Offset: 0x00016A80
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x000188BA File Offset: 0x00016ABA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000188C8 File Offset: 0x00016AC8
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000188F2 File Offset: 0x00016AF2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00018900 File Offset: 0x00016B00
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00018927 File Offset: 0x00016B27
		public virtual List<int> NpcIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcIds;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NpcIds;
			}
			set
			{
				this.GetOrCreatePoco().NpcIds = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00018935 File Offset: 0x00016B35
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00018964 File Offset: 0x00016B64
		public virtual float EnterRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterRange;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EnterRange;
			}
			set
			{
				this.GetOrCreatePoco().EnterRange = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00018972 File Offset: 0x00016B72
		// (set) Token: 0x060001CF RID: 463 RVA: 0x000189A1 File Offset: 0x00016BA1
		public virtual float LeaveRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveRange;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.LeaveRange;
			}
			set
			{
				this.GetOrCreatePoco().LeaveRange = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000189B0 File Offset: 0x00016BB0
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x000189EA File Offset: 0x00016BEA
		public virtual bool? IsRangeFollowEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRangeFollowEntity;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRangeFollowEntity;
			}
			set
			{
				this.GetOrCreatePoco().IsRangeFollowEntity = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000189F8 File Offset: 0x00016BF8
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00018A8B File Offset: 0x00016C8B
		public virtual List<IConditionBubbleData> Flows
		{
			get
			{
				if (this._FlowsInited)
				{
					return this._FlowsCache;
				}
				this._FlowsInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionBubbleData> flows = this.FbInstance.Flows;
					if (flows != null)
					{
						this._FlowsCache = new List<IConditionBubbleData>(flows.Count);
						for (int i = 0; i < flows.Count; i++)
						{
							this._FlowsCache.Add(IConditionBubbleData.Create(flows[i]));
						}
					}
				}
				else
				{
					BubbleComponent_SetValue pocoInterface = this.PocoInterface;
					this._FlowsCache = ((pocoInterface != null) ? pocoInterface.Flows : null);
				}
				return this._FlowsCache;
			}
			set
			{
				this.GetOrCreatePoco().Flows = value;
				this._FlowsInited = false;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00018AA0 File Offset: 0x00016CA0
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00018ADA File Offset: 0x00016CDA
		public virtual int? TimberId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimberId;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimberId;
			}
			set
			{
				this.GetOrCreatePoco().TimberId = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00018AE8 File Offset: 0x00016CE8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00018B22 File Offset: 0x00016D22
		public virtual float? Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00018B30 File Offset: 0x00016D30
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00018B6A File Offset: 0x00016D6A
		public virtual bool? IsAudioOccludedByScene
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAudioOccludedByScene;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAudioOccludedByScene;
			}
			set
			{
				this.GetOrCreatePoco().IsAudioOccludedByScene = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00018B78 File Offset: 0x00016D78
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00018BD9 File Offset: 0x00016DD9
		[Nullable(2)]
		public virtual IBubbleRangeCylinderConfig TriggerCylinderConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._TriggerCylinderConfigInited)
				{
					return this._TriggerCylinderConfigCache;
				}
				this._TriggerCylinderConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TriggerCylinderConfigCache = IBubbleRangeCylinderConfig.Create(this.FbInstance.TriggerCylinderConfig);
				}
				else
				{
					BubbleComponent_SetValue pocoInterface = this.PocoInterface;
					this._TriggerCylinderConfigCache = ((pocoInterface != null) ? pocoInterface.TriggerCylinderConfig : null);
				}
				return this._TriggerCylinderConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TriggerCylinderConfig = value;
				this._TriggerCylinderConfigInited = false;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00018BF0 File Offset: 0x00016DF0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00018C2A File Offset: 0x00016E2A
		public virtual bool? IsPlayMouthAnim
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayMouthAnim;
				}
				BubbleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPlayMouthAnim;
			}
			set
			{
				this.GetOrCreatePoco().IsPlayMouthAnim = value;
			}
		}

		// Token: 0x04000128 RID: 296
		[Nullable(2)]
		protected new BubbleComponent FbInstance;

		// Token: 0x04000129 RID: 297
		[Nullable(2)]
		protected new BubbleComponent_SetValue PocoInterface;

		// Token: 0x0400012A RID: 298
		private List<IConditionBubbleData> _FlowsCache;

		// Token: 0x0400012B RID: 299
		private bool _FlowsInited;

		// Token: 0x0400012C RID: 300
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x0400012D RID: 301
		private bool _TriggerCylinderConfigInited;
	}
}
