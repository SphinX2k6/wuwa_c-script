using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001AA RID: 426
	[NullableContext(2)]
	[Nullable(0)]
	public class HitComponent : IHitComponentBase
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x00022074 File Offset: 0x00020274
		[NullableContext(0)]
		private HitComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HitComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HitComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HitComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000220AC File Offset: 0x000202AC
		[NullableContext(0)]
		public static HitComponent Create([Nullable(2)] HitComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HitComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000220BF File Offset: 0x000202BF
		[NullableContext(0)]
		public static HitComponent CreateFromSetValue([Nullable(2)] HitComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HitComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000220D4 File Offset: 0x000202D4
		[NullableContext(0)]
		public new HitComponent_SetValue ToSetValue()
		{
			return new HitComponent_SetValue
			{
				Disabled = this.Disabled,
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio,
				AimParts = this.AimParts,
				EdIsLocked = this.EdIsLocked,
				BulletHitConfigs = this.BulletHitConfigs
			};
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0002213C File Offset: 0x0002033C
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00022176 File Offset: 0x00020376
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				HitComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00022184 File Offset: 0x00020384
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x000221AB File Offset: 0x000203AB
		public override IHitBulletType HitBullet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullet;
				}
				HitComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitBullet;
			}
			set
			{
				this.GetOrCreatePoco().HitBullet = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x000221BC File Offset: 0x000203BC
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0002221D File Offset: 0x0002041D
		public override IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
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
					HitComponent_SetValue pocoInterface = this.PocoInterface;
					this._AttackerHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.AttackerHitTimeScaleRatio : null);
				}
				return this._AttackerHitTimeScaleRatioCache;
			}
			set
			{
				this.GetOrCreatePoco().AttackerHitTimeScaleRatio = value;
				this._AttackerHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00022234 File Offset: 0x00020434
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00022295 File Offset: 0x00020495
		public override IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
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
					HitComponent_SetValue pocoInterface = this.PocoInterface;
					this._VictimHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.VictimHitTimeScaleRatio : null);
				}
				return this._VictimHitTimeScaleRatioCache;
			}
			set
			{
				this.GetOrCreatePoco().VictimHitTimeScaleRatio = value;
				this._VictimHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x000222AC File Offset: 0x000204AC
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0002233F File Offset: 0x0002053F
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
					HitComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00022354 File Offset: 0x00020554
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0002237E File Offset: 0x0002057E
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0002238C File Offset: 0x0002058C
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0002241F File Offset: 0x0002061F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IBulletHitConfig> BulletHitConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._BulletHitConfigsInited)
				{
					return this._BulletHitConfigsCache;
				}
				this._BulletHitConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IBulletHitConfig> bulletHitConfigs = this.FbInstance.BulletHitConfigs;
					if (bulletHitConfigs != null)
					{
						this._BulletHitConfigsCache = new List<IBulletHitConfig>(bulletHitConfigs.Count);
						for (int i = 0; i < bulletHitConfigs.Count; i++)
						{
							this._BulletHitConfigsCache.Add(IBulletHitConfig.Create(bulletHitConfigs[i]));
						}
					}
				}
				else
				{
					HitComponent_SetValue pocoInterface = this.PocoInterface;
					this._BulletHitConfigsCache = ((pocoInterface != null) ? pocoInterface.BulletHitConfigs : null);
				}
				return this._BulletHitConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().BulletHitConfigs = value;
				this._BulletHitConfigsInited = false;
			}
		}

		// Token: 0x040007F6 RID: 2038
		protected new HitComponent FbInstance;

		// Token: 0x040007F7 RID: 2039
		protected new HitComponent_SetValue PocoInterface;

		// Token: 0x040007F8 RID: 2040
		[Nullable(0)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040007F9 RID: 2041
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040007FA RID: 2042
		[Nullable(0)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040007FB RID: 2043
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x040007FC RID: 2044
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x040007FD RID: 2045
		private bool _AimPartsInited;

		// Token: 0x040007FE RID: 2046
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IBulletHitConfig> _BulletHitConfigsCache;

		// Token: 0x040007FF RID: 2047
		private bool _BulletHitConfigsInited;
	}
}
