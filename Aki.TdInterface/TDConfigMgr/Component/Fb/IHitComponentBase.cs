using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C68 RID: 3176
	[NullableContext(2)]
	[Nullable(0)]
	public class IHitComponentBase : IComponentBase
	{
		// Token: 0x0600488F RID: 18575 RVA: 0x000B765B File Offset: 0x000B585B
		[NullableContext(0)]
		public static IHitComponentBase Create(IHitComponentBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitComponentBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x000B767C File Offset: 0x000B587C
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

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x000B76B4 File Offset: 0x000B58B4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x000B76CA File Offset: 0x000B58CA
		[Nullable(0)]
		public virtual IHitBulletType HitBullet
		{
			[NullableContext(0)]
			get
			{
				if (this._HitBulletInited)
				{
					return this._HitBulletCache;
				}
				this._HitBulletInited = true;
				this._HitBulletCache = ComponentReadHelper.ReadIHitComponentBase_HitBullet(this.Instance);
				return this._HitBulletCache;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x000B76F9 File Offset: 0x000B58F9
		public virtual IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
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

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x000B772D File Offset: 0x000B592D
		public virtual IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
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

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x000B7764 File Offset: 0x000B5964
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IAimPart> AimParts
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

		// Token: 0x040028C3 RID: 10435
		private IHitComponentBase Instance;

		// Token: 0x040028C4 RID: 10436
		[Nullable(0)]
		private IHitBulletType _HitBulletCache;

		// Token: 0x040028C5 RID: 10437
		private bool _HitBulletInited;

		// Token: 0x040028C6 RID: 10438
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040028C7 RID: 10439
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040028C8 RID: 10440
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040028C9 RID: 10441
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x040028CA RID: 10442
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x040028CB RID: 10443
		private bool _AimPartsInited;
	}
}
