using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000958 RID: 2392
	public class TargetGearComponent : IHitComponentBase
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x00087880 File Offset: 0x00085A80
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

		// Token: 0x0600353E RID: 13630 RVA: 0x000878B8 File Offset: 0x00085AB8
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

		// Token: 0x0600353F RID: 13631 RVA: 0x000878CB File Offset: 0x00085ACB
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

		// Token: 0x06003540 RID: 13632 RVA: 0x000878E0 File Offset: 0x00085AE0
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

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x00087990 File Offset: 0x00085B90
		// (set) Token: 0x06003542 RID: 13634 RVA: 0x000879CA File Offset: 0x00085BCA
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x000879D8 File Offset: 0x00085BD8
		// (set) Token: 0x06003544 RID: 13636 RVA: 0x000879FF File Offset: 0x00085BFF
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

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x00087A10 File Offset: 0x00085C10
		// (set) Token: 0x06003546 RID: 13638 RVA: 0x00087A71 File Offset: 0x00085C71
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x00087A88 File Offset: 0x00085C88
		// (set) Token: 0x06003548 RID: 13640 RVA: 0x00087AE9 File Offset: 0x00085CE9
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

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x00087B00 File Offset: 0x00085D00
		// (set) Token: 0x0600354A RID: 13642 RVA: 0x00087B93 File Offset: 0x00085D93
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IAimPart> AimParts
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().AimParts = value;
				this._AimPartsInited = false;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x00087BA8 File Offset: 0x00085DA8
		// (set) Token: 0x0600354C RID: 13644 RVA: 0x00087BD2 File Offset: 0x00085DD2
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

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x00087BE0 File Offset: 0x00085DE0
		// (set) Token: 0x0600354E RID: 13646 RVA: 0x00087C0B File Offset: 0x00085E0B
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

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x00087C19 File Offset: 0x00085E19
		// (set) Token: 0x06003550 RID: 13648 RVA: 0x00087C44 File Offset: 0x00085E44
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

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x00087C52 File Offset: 0x00085E52
		// (set) Token: 0x06003552 RID: 13650 RVA: 0x00087C7D File Offset: 0x00085E7D
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

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003553 RID: 13651 RVA: 0x00087C8B File Offset: 0x00085E8B
		// (set) Token: 0x06003554 RID: 13652 RVA: 0x00087CB2 File Offset: 0x00085EB2
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

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x00087CC0 File Offset: 0x00085EC0
		// (set) Token: 0x06003556 RID: 13654 RVA: 0x00087CE7 File Offset: 0x00085EE7
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

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x00087CF8 File Offset: 0x00085EF8
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x00087D59 File Offset: 0x00085F59
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

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x00087D70 File Offset: 0x00085F70
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x00087DAA File Offset: 0x00085FAA
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

		// Token: 0x040022D8 RID: 8920
		[Nullable(2)]
		protected new TargetGearComponent FbInstance;

		// Token: 0x040022D9 RID: 8921
		[Nullable(2)]
		protected new TargetGearComponent_SetValue PocoInterface;

		// Token: 0x040022DA RID: 8922
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040022DB RID: 8923
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040022DC RID: 8924
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040022DD RID: 8925
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x040022DE RID: 8926
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x040022DF RID: 8927
		private bool _AimPartsInited;

		// Token: 0x040022E0 RID: 8928
		private ISplineMove _PatrolCache;

		// Token: 0x040022E1 RID: 8929
		private bool _PatrolInited;
	}
}
