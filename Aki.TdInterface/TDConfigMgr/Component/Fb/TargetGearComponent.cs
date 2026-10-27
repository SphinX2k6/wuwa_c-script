using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9B RID: 2971
	[NullableContext(1)]
	[Nullable(0)]
	public class TargetGearComponent : IHitComponentBase
	{
		// Token: 0x0600443E RID: 17470 RVA: 0x000AD722 File Offset: 0x000AB922
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

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x000AD744 File Offset: 0x000AB944
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

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x000AD77A File Offset: 0x000AB97A
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

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x000AD7A9 File Offset: 0x000AB9A9
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

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x000AD7DD File Offset: 0x000AB9DD
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

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x000AD814 File Offset: 0x000ABA14
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

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x000AD890 File Offset: 0x000ABA90
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x000AD8A6 File Offset: 0x000ABAA6
		public virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x000AD8B3 File Offset: 0x000ABAB3
		public virtual bool IsCycle
		{
			get
			{
				return this.Instance.IsCycle;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x000AD8C0 File Offset: 0x000ABAC0
		public virtual int CycleInterval
		{
			get
			{
				return this.Instance.CycleInterval;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x000AD8D0 File Offset: 0x000ABAD0
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

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x000AD934 File Offset: 0x000ABB34
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

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x000AD963 File Offset: 0x000ABB63
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

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x000AD998 File Offset: 0x000ABB98
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

		// Token: 0x04002684 RID: 9860
		private ITargetGearComponent Instance;

		// Token: 0x04002685 RID: 9861
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002686 RID: 9862
		private bool _HitBulletInited;

		// Token: 0x04002687 RID: 9863
		[Nullable(2)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002688 RID: 9864
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002689 RID: 9865
		[Nullable(2)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x0400268A RID: 9866
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x0400268B RID: 9867
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x0400268C RID: 9868
		private bool _AimPartsInited;

		// Token: 0x0400268D RID: 9869
		private List<string> _CycleStatesCache;

		// Token: 0x0400268E RID: 9870
		private bool _CycleStatesInited;

		// Token: 0x0400268F RID: 9871
		private IHitLogicType _HitLogicTypeCache;

		// Token: 0x04002690 RID: 9872
		private bool _HitLogicTypeInited;

		// Token: 0x04002691 RID: 9873
		[Nullable(2)]
		private ISplineMove _PatrolCache;

		// Token: 0x04002692 RID: 9874
		private bool _PatrolInited;
	}
}
