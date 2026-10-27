using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041C RID: 1052
	[NullableContext(2)]
	[Nullable(0)]
	public class IHitComponentBase : IComponentBase
	{
		// Token: 0x06001533 RID: 5427 RVA: 0x00042ACC File Offset: 0x00040CCC
		[NullableContext(1)]
		private IHitComponentBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitComponentBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitComponentBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitComponentBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00042B04 File Offset: 0x00040D04
		[NullableContext(1)]
		public static IHitComponentBase Create([Nullable(2)] IHitComponentBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitComponentBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00042B17 File Offset: 0x00040D17
		[NullableContext(1)]
		public static IHitComponentBase CreateFromSetValue([Nullable(2)] IHitComponentBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitComponentBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00042B2C File Offset: 0x00040D2C
		[NullableContext(1)]
		public new IHitComponentBase_SetValue ToSetValue()
		{
			return new IHitComponentBase_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio,
				AimParts = this.AimParts
			};
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x00042B88 File Offset: 0x00040D88
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x00042BC2 File Offset: 0x00040DC2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x00042BD0 File Offset: 0x00040DD0
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x00042BFA File Offset: 0x00040DFA
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

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x00042C08 File Offset: 0x00040E08
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x00042C2F File Offset: 0x00040E2F
		public virtual IHitBulletType HitBullet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullet;
				}
				IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00042C40 File Offset: 0x00040E40
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x00042CA1 File Offset: 0x00040EA1
		public virtual IHitTimeScaleRatio AttackerHitTimeScaleRatio
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
					IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00042CB8 File Offset: 0x00040EB8
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x00042D19 File Offset: 0x00040F19
		public virtual IHitTimeScaleRatio VictimHitTimeScaleRatio
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
					IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00042D30 File Offset: 0x00040F30
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x00042DC3 File Offset: 0x00040FC3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IAimPart> AimParts
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
					IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001070 RID: 4208
		protected new IHitComponentBase FbInstance;

		// Token: 0x04001071 RID: 4209
		protected new IHitComponentBase_SetValue PocoInterface;

		// Token: 0x04001072 RID: 4210
		[Nullable(1)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04001073 RID: 4211
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04001074 RID: 4212
		[Nullable(1)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04001075 RID: 4213
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04001076 RID: 4214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04001077 RID: 4215
		private bool _AimPartsInited;
	}
}
