using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000950 RID: 2384
	public class SunSpiritGearComponent : IComponentBase
	{
		// Token: 0x06003503 RID: 13571 RVA: 0x0008709C File Offset: 0x0008529C
		private SunSpiritGearComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SunSpiritGearComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SunSpiritGearComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SunSpiritGearComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000870D4 File Offset: 0x000852D4
		public static SunSpiritGearComponent Create([Nullable(2)] SunSpiritGearComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritGearComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x000870E7 File Offset: 0x000852E7
		public static SunSpiritGearComponent CreateFromSetValue([Nullable(2)] SunSpiritGearComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SunSpiritGearComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000870FA File Offset: 0x000852FA
		public new SunSpiritGearComponent_SetValue ToSetValue()
		{
			return new SunSpiritGearComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PerformConfig = this.PerformConfig
			};
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x00087128 File Offset: 0x00085328
		// (set) Token: 0x06003508 RID: 13576 RVA: 0x00087162 File Offset: 0x00085362
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SunSpiritGearComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x00087170 File Offset: 0x00085370
		// (set) Token: 0x0600350A RID: 13578 RVA: 0x0008719A File Offset: 0x0008539A
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

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x000871A8 File Offset: 0x000853A8
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x000871CF File Offset: 0x000853CF
		public virtual ISunSpiritGearPerformConfig PerformConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformConfig;
				}
				SunSpiritGearComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformConfig;
			}
			set
			{
				this.GetOrCreatePoco().PerformConfig = value;
			}
		}

		// Token: 0x040022B9 RID: 8889
		[Nullable(2)]
		protected new SunSpiritGearComponent FbInstance;

		// Token: 0x040022BA RID: 8890
		[Nullable(2)]
		protected new SunSpiritGearComponent_SetValue PocoInterface;
	}
}
