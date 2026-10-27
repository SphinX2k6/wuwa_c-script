using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B5 RID: 2229
	[NullableContext(1)]
	[Nullable(0)]
	public class TargetGearComponent : IHitComponentBase
	{
		// Token: 0x06003201 RID: 12801 RVA: 0x00080398 File Offset: 0x0007E598
		private TargetGearComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TargetGearComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TargetGearComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TargetGearComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000803D0 File Offset: 0x0007E5D0
		public static TargetGearComponent Create([Nullable(2)] TargetGearComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TargetGearComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000803E3 File Offset: 0x0007E5E3
		public static TargetGearComponent CreateFromSetValue([Nullable(2)] TargetGearComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TargetGearComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000803F8 File Offset: 0x0007E5F8
		public new TargetGearComponent_SetValue ToSetValue()
		{
			return new TargetGearComponent_SetValue
			{
				Disabled = this.Disabled,
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio,
				AimParts = this.AimParts,
				EdIsLocked = this.EdIsLocked,
				Type = this.Type,
				IsCycle = this.IsCycle,
				CycleInterval = this.CycleInterval,
				CycleStates = this.CycleStates,
				HitLogicType = this.HitLogicType,
				Patrol = this.Patrol,
				HitCd = this.HitCd
			};
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x000804A8 File Offset: 0x0007E6A8
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x000804E2 File Offset: 0x0007E6E2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x000804F0 File Offset: 0x0007E6F0
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x00080517 File Offset: 0x0007E717
		[Nullable(2)]
		public override IHitBulletType HitBullet
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullet;
				}
				TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitBullet;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().HitBullet = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x00080528 File Offset: 0x0007E728
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x00080589 File Offset: 0x0007E789
		[Nullable(2)]
		public override IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
			[NullableContext(2)]
			get
			{
				if (this._AttackerHitTimeScaleRatioInited)
				{
					return this._AttackerHitTimeScaleRatioCache;
				}
				this._AttackerHitTimeScaleRatioInited = true;
				if (this.FbInstance != null)
				{
					this._AttackerHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.FbInstance.AttackerHitTimeScaleRatio);
				}
				else
				{
					TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
					this._AttackerHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.AttackerHitTimeScaleRatio : null);
				}
				return this._AttackerHitTimeScaleRatioCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AttackerHitTimeScaleRatio = value;
				this._AttackerHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x000805A0 File Offset: 0x0007E7A0
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x00080601 File Offset: 0x0007E801
		[Nullable(2)]
		public override IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
			[NullableContext(2)]
			get
			{
				if (this._VictimHitTimeScaleRatioInited)
				{
					return this._VictimHitTimeScaleRatioCache;
				}
				this._VictimHitTimeScaleRatioInited = true;
				if (this.FbInstance != null)
				{
					this._VictimHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.FbInstance.VictimHitTimeScaleRatio);
				}
				else
				{
					TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
					this._VictimHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.VictimHitTimeScaleRatio : null);
				}
				return this._VictimHitTimeScaleRatioCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().VictimHitTimeScaleRatio = value;
				this._VictimHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x00080618 File Offset: 0x0007E818
		// (set) Token: 0x0600320E RID: 12814 RVA: 0x000806AB File Offset: 0x0007E8AB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IAimPart> AimParts
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._AimPartsInited)
				{
					return this._AimPartsCache;
				}
				this._AimPartsInited = true;
				if (this.FbInstance != null)
				{
					List<IAimPart> aimParts = this.FbInstance.AimParts;
					if (aimParts != null)
					{
						this._AimPartsCache = new List<IAimPart>(aimParts.Count);
						for (int i = 0; i < aimParts.Count; i++)
						{
							this._AimPartsCache.Add(IAimPart.Create(aimParts[i]));
						}
					}
				}
				else
				{
					TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
					this._AimPartsCache = ((pocoInterface != null) ? pocoInterface.AimParts : null);
				}
				return this._AimPartsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().AimParts = value;
				this._AimPartsInited = false;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x000806C0 File Offset: 0x0007E8C0
		// (set) Token: 0x06003210 RID: 12816 RVA: 0x000806EA File Offset: 0x0007E8EA
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

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x000806F8 File Offset: 0x0007E8F8
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x00080723 File Offset: 0x0007E923
		public virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x00080731 File Offset: 0x0007E931
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x0008075C File Offset: 0x0007E95C
		public virtual bool IsCycle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCycle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCycle;
			}
			set
			{
				this.GetOrCreatePoco().IsCycle = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0008076A File Offset: 0x0007E96A
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x00080795 File Offset: 0x0007E995
		public virtual int CycleInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CycleInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CycleInterval;
			}
			set
			{
				this.GetOrCreatePoco().CycleInterval = value;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000807A3 File Offset: 0x0007E9A3
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x000807CA File Offset: 0x0007E9CA
		public virtual List<string> CycleStates
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CycleStates;
				}
				TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CycleStates;
			}
			set
			{
				this.GetOrCreatePoco().CycleStates = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000807D8 File Offset: 0x0007E9D8
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x000807FF File Offset: 0x0007E9FF
		public virtual IHitLogicType HitLogicType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitLogicType;
				}
				TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitLogicType;
			}
			set
			{
				this.GetOrCreatePoco().HitLogicType = value;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x00080810 File Offset: 0x0007EA10
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x00080871 File Offset: 0x0007EA71
		[Nullable(2)]
		public virtual ISplineMove Patrol
		{
			[NullableContext(2)]
			get
			{
				if (this._PatrolInited)
				{
					return this._PatrolCache;
				}
				this._PatrolInited = true;
				if (this.FbInstance != null)
				{
					this._PatrolCache = ISplineMove.Create(this.FbInstance.Patrol);
				}
				else
				{
					TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
					this._PatrolCache = ((pocoInterface != null) ? pocoInterface.Patrol : null);
				}
				return this._PatrolCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Patrol = value;
				this._PatrolInited = false;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x00080888 File Offset: 0x0007EA88
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x000808C2 File Offset: 0x0007EAC2
		public virtual float? HitCd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitCd;
				}
				TargetGearComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitCd;
			}
			set
			{
				this.GetOrCreatePoco().HitCd = value;
			}
		}

		// Token: 0x040020C6 RID: 8390
		[Nullable(2)]
		protected new TargetGearComponent FbInstance;

		// Token: 0x040020C7 RID: 8391
		[Nullable(2)]
		protected new TargetGearComponent_SetValue PocoInterface;

		// Token: 0x040020C8 RID: 8392
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040020C9 RID: 8393
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040020CA RID: 8394
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040020CB RID: 8395
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x040020CC RID: 8396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x040020CD RID: 8397
		private bool _AimPartsInited;

		// Token: 0x040020CE RID: 8398
		private ISplineMove _PatrolCache;

		// Token: 0x040020CF RID: 8399
		private bool _PatrolInited;
	}
}
