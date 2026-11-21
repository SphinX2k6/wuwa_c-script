using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C69 RID: 3177
	public class TargetGearComponent : IHitComponentBase
	{
		// Token: 0x06004897 RID: 18583 RVA: 0x000B77E6 File Offset: 0x000B59E6
		public static TargetGearComponent Create(ITargetGearComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TargetGearComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x000B7808 File Offset: 0x000B5A08
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x000B783E File Offset: 0x000B5A3E
		public override IHitBulletType HitBullet
		{
			get
			{
				if (this._HitBulletInited)
				{
					return this._HitBulletCache;
				}
				this._HitBulletInited = true;
				this._HitBulletCache = ComponentReadHelper.ReadTargetGearComponent_HitBullet(this.Instance);
				return this._HitBulletCache;
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x000B786D File Offset: 0x000B5A6D
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
				this._AttackerHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.Instance.AttackerHitTimeScaleRatio);
				return this._AttackerHitTimeScaleRatioCache;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x000B78A1 File Offset: 0x000B5AA1
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
				this._VictimHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.Instance.VictimHitTimeScaleRatio);
				return this._VictimHitTimeScaleRatioCache;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x000B78D8 File Offset: 0x000B5AD8
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int aimPartsLength = this.Instance.AimPartsLength;
				this._AimPartsCache = new List<IAimPart>(aimPartsLength);
				for (int i = 0; i < aimPartsLength; i++)
				{
					this._AimPartsCache.Add(IAimPart.Create(this.Instance.AimParts(i)));
				}
				return this._AimPartsCache;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x000B7954 File Offset: 0x000B5B54
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x000B796A File Offset: 0x000B5B6A
		public virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x000B7977 File Offset: 0x000B5B77
		public virtual bool IsCycle
		{
			get
			{
				return this.Instance.IsCycle;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x000B7984 File Offset: 0x000B5B84
		public virtual int CycleInterval
		{
			get
			{
				return this.Instance.CycleInterval;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x000B7994 File Offset: 0x000B5B94
		public virtual List<string> CycleStates
		{
			get
			{
				if (this._CycleStatesInited)
				{
					return this._CycleStatesCache;
				}
				this._CycleStatesInited = true;
				int cycleStatesLength = this.Instance.CycleStatesLength;
				this._CycleStatesCache = new List<string>(cycleStatesLength);
				for (int i = 0; i < cycleStatesLength; i++)
				{
					this._CycleStatesCache.Add(this.Instance.CycleStates(i));
				}
				return this._CycleStatesCache;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x000B79F8 File Offset: 0x000B5BF8
		public virtual IHitLogicType HitLogicType
		{
			get
			{
				if (this._HitLogicTypeInited)
				{
					return this._HitLogicTypeCache;
				}
				this._HitLogicTypeInited = true;
				this._HitLogicTypeCache = ComponentReadHelper.ReadTargetGearComponent_HitLogicType(this.Instance);
				return this._HitLogicTypeCache;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x000B7A27 File Offset: 0x000B5C27
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
				this._PatrolCache = ISplineMove.Create(this.Instance.Patrol);
				return this._PatrolCache;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x000B7A5C File Offset: 0x000B5C5C
		public virtual float? HitCd
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.HitCd);
			}
		}

		// Token: 0x040028CC RID: 10444
		private ITargetGearComponent Instance;

		// Token: 0x040028CD RID: 10445
		private IHitBulletType _HitBulletCache;

		// Token: 0x040028CE RID: 10446
		private bool _HitBulletInited;

		// Token: 0x040028CF RID: 10447
		[Nullable(2)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040028D0 RID: 10448
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040028D1 RID: 10449
		[Nullable(2)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040028D2 RID: 10450
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x040028D3 RID: 10451
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x040028D4 RID: 10452
		private bool _AimPartsInited;

		// Token: 0x040028D5 RID: 10453
		private List<string> _CycleStatesCache;

		// Token: 0x040028D6 RID: 10454
		private bool _CycleStatesInited;

		// Token: 0x040028D7 RID: 10455
		private IHitLogicType _HitLogicTypeCache;

		// Token: 0x040028D8 RID: 10456
		private bool _HitLogicTypeInited;

		// Token: 0x040028D9 RID: 10457
		[Nullable(2)]
		private ISplineMove _PatrolCache;

		// Token: 0x040028DA RID: 10458
		private bool _PatrolInited;
	}
}
