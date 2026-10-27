using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000193 RID: 403
	[NullableContext(2)]
	[Nullable(0)]
	public class HitComponent : IHitComponentBase
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x00021498 File Offset: 0x0001F698
		[NullableContext(1)]
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

		// Token: 0x060005D3 RID: 1491 RVA: 0x000214D0 File Offset: 0x0001F6D0
		[NullableContext(1)]
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

		// Token: 0x060005D4 RID: 1492 RVA: 0x000214E3 File Offset: 0x0001F6E3
		[NullableContext(1)]
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

		// Token: 0x060005D5 RID: 1493 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[NullableContext(1)]
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00021560 File Offset: 0x0001F760
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0002159A File Offset: 0x0001F79A
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x000215A8 File Offset: 0x0001F7A8
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x000215CF File Offset: 0x0001F7CF
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000215E0 File Offset: 0x0001F7E0
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00021641 File Offset: 0x0001F841
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00021658 File Offset: 0x0001F858
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x000216B9 File Offset: 0x0001F8B9
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000216D0 File Offset: 0x0001F8D0
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00021763 File Offset: 0x0001F963
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
					HitComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00021778 File Offset: 0x0001F978
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x000217A2 File Offset: 0x0001F9A2
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000217B0 File Offset: 0x0001F9B0
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00021843 File Offset: 0x0001FA43
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IBulletHitConfig> BulletHitConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().BulletHitConfigs = value;
				this._BulletHitConfigsInited = false;
			}
		}

		// Token: 0x040007A0 RID: 1952
		protected new HitComponent FbInstance;

		// Token: 0x040007A1 RID: 1953
		protected new HitComponent_SetValue PocoInterface;

		// Token: 0x040007A2 RID: 1954
		[Nullable(1)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040007A3 RID: 1955
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040007A4 RID: 1956
		[Nullable(1)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040007A5 RID: 1957
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x040007A6 RID: 1958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x040007A7 RID: 1959
		private bool _AimPartsInited;

		// Token: 0x040007A8 RID: 1960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBulletHitConfig> _BulletHitConfigsCache;

		// Token: 0x040007A9 RID: 1961
		private bool _BulletHitConfigsInited;
	}
}
