using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000032 RID: 50
	[NullableContext(1)]
	[Nullable(0)]
	public class BubbleComponent : IComponentBase
	{
		// Token: 0x060001BE RID: 446 RVA: 0x00017E08 File Offset: 0x00016008
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

		// Token: 0x060001BF RID: 447 RVA: 0x00017E40 File Offset: 0x00016040
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

		// Token: 0x060001C0 RID: 448 RVA: 0x00017E53 File Offset: 0x00016053
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

		// Token: 0x060001C1 RID: 449 RVA: 0x00017E68 File Offset: 0x00016068
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00017F0C File Offset: 0x0001610C
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00017F46 File Offset: 0x00016146
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00017F54 File Offset: 0x00016154
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00017F7E File Offset: 0x0001617E
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00017F8C File Offset: 0x0001618C
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00017FB3 File Offset: 0x000161B3
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00017FC1 File Offset: 0x000161C1
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00017FF0 File Offset: 0x000161F0
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00017FFE File Offset: 0x000161FE
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0001802D File Offset: 0x0001622D
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0001803C File Offset: 0x0001623C
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00018076 File Offset: 0x00016276
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00018084 File Offset: 0x00016284
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00018117 File Offset: 0x00016317
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001812C File Offset: 0x0001632C
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00018166 File Offset: 0x00016366
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00018174 File Offset: 0x00016374
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000181AE File Offset: 0x000163AE
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000181BC File Offset: 0x000163BC
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000181F6 File Offset: 0x000163F6
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00018204 File Offset: 0x00016404
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00018265 File Offset: 0x00016465
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0001827C File Offset: 0x0001647C
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000182B6 File Offset: 0x000164B6
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

		// Token: 0x04000123 RID: 291
		[Nullable(2)]
		protected new BubbleComponent FbInstance;

		// Token: 0x04000124 RID: 292
		[Nullable(2)]
		protected new BubbleComponent_SetValue PocoInterface;

		// Token: 0x04000125 RID: 293
		private List<IConditionBubbleData> _FlowsCache;

		// Token: 0x04000126 RID: 294
		private bool _FlowsInited;

		// Token: 0x04000127 RID: 295
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04000128 RID: 296
		private bool _TriggerCylinderConfigInited;
	}
}
