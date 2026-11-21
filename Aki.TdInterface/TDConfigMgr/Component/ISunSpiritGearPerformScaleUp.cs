using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007DE RID: 2014
	public class ISunSpiritGearPerformScaleUp : ISunSpiritGearPerformConfig
	{
		// Token: 0x06002B1D RID: 11037 RVA: 0x000712CC File Offset: 0x0006F4CC
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

		// Token: 0x06002B1E RID: 11038 RVA: 0x00071304 File Offset: 0x0006F504
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

		// Token: 0x06002B1F RID: 11039 RVA: 0x00071317 File Offset: 0x0006F517
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

		// Token: 0x06002B20 RID: 11040 RVA: 0x0007132A File Offset: 0x0006F52A
		public new ISunSpiritGearPerformScaleUp_SetValue ToSetValue()
		{
			return new ISunSpiritGearPerformScaleUp_SetValue
			{
				Type = this.Type,
				Scale = this.Scale,
				ScaleUpPerformConfig = this.ScaleUpPerformConfig
			};
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x00071355 File Offset: 0x0006F555
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x00071380 File Offset: 0x0006F580
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

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0007138E File Offset: 0x0006F58E
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x000713BD File Offset: 0x0006F5BD
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000713CC File Offset: 0x0006F5CC
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x0007142D File Offset: 0x0006F62D
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

		// Token: 0x04001CF0 RID: 7408
		[Nullable(2)]
		protected new ISunSpiritGearPerformScaleUp FbInstance;

		// Token: 0x04001CF1 RID: 7409
		[Nullable(2)]
		protected new ISunSpiritGearPerformScaleUp_SetValue PocoInterface;

		// Token: 0x04001CF2 RID: 7410
		private IScaleUpSpiritPerformConfig _ScaleUpPerformConfigCache;

		// Token: 0x04001CF3 RID: 7411
		private bool _ScaleUpPerformConfigInited;
	}
}
