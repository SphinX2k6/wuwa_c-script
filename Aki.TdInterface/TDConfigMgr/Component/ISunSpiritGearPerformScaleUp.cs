using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200073D RID: 1853
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunSpiritGearPerformScaleUp : ISunSpiritGearPerformConfig
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x0006A124 File Offset: 0x00068324
		private ISunSpiritGearPerformScaleUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritGearPerformScaleUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritGearPerformScaleUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritGearPerformScaleUp_SetValue());
			}
			return result;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x0006A15C File Offset: 0x0006835C
		public static ISunSpiritGearPerformScaleUp Create([Nullable(2)] ISunSpiritGearPerformScaleUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformScaleUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0006A16F File Offset: 0x0006836F
		public static ISunSpiritGearPerformScaleUp CreateFromSetValue([Nullable(2)] ISunSpiritGearPerformScaleUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformScaleUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0006A182 File Offset: 0x00068382
		public new ISunSpiritGearPerformScaleUp_SetValue ToSetValue()
		{
			return new ISunSpiritGearPerformScaleUp_SetValue
			{
				Type = this.Type,
				Scale = this.Scale,
				ScaleUpPerformConfig = this.ScaleUpPerformConfig
			};
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0006A1AD File Offset: 0x000683AD
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x0006A1D8 File Offset: 0x000683D8
		public override ESunSpiritGearPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESunSpiritGearPerformType.ToGearRelativePos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x0006A1E6 File Offset: 0x000683E6
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x0006A215 File Offset: 0x00068415
		public virtual float Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x0006A224 File Offset: 0x00068424
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x0006A285 File Offset: 0x00068485
		[Nullable(2)]
		public virtual IScaleUpSpiritPerformConfig ScaleUpPerformConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._ScaleUpPerformConfigInited)
				{
					return this._ScaleUpPerformConfigCache;
				}
				this._ScaleUpPerformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ScaleUpPerformConfigCache = IScaleUpSpiritPerformConfig.Create(this.FbInstance.ScaleUpPerformConfig);
				}
				else
				{
					ISunSpiritGearPerformScaleUp_SetValue pocoInterface = this.PocoInterface;
					this._ScaleUpPerformConfigCache = ((pocoInterface != null) ? pocoInterface.ScaleUpPerformConfig : null);
				}
				return this._ScaleUpPerformConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ScaleUpPerformConfig = value;
				this._ScaleUpPerformConfigInited = false;
			}
		}

		// Token: 0x04001AEB RID: 6891
		[Nullable(2)]
		protected new ISunSpiritGearPerformScaleUp FbInstance;

		// Token: 0x04001AEC RID: 6892
		[Nullable(2)]
		protected new ISunSpiritGearPerformScaleUp_SetValue PocoInterface;

		// Token: 0x04001AED RID: 6893
		private IScaleUpSpiritPerformConfig _ScaleUpPerformConfigCache;

		// Token: 0x04001AEE RID: 6894
		private bool _ScaleUpPerformConfigInited;
	}
}
