using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AD RID: 2221
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritGearComponent : IComponentBase
	{
		// Token: 0x060031C7 RID: 12743 RVA: 0x0007FBB4 File Offset: 0x0007DDB4
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

		// Token: 0x060031C8 RID: 12744 RVA: 0x0007FBEC File Offset: 0x0007DDEC
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

		// Token: 0x060031C9 RID: 12745 RVA: 0x0007FBFF File Offset: 0x0007DDFF
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

		// Token: 0x060031CA RID: 12746 RVA: 0x0007FC12 File Offset: 0x0007DE12
		public new SunSpiritGearComponent_SetValue ToSetValue()
		{
			return new SunSpiritGearComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PerformConfig = this.PerformConfig
			};
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x0007FC40 File Offset: 0x0007DE40
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x0007FC7A File Offset: 0x0007DE7A
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0007FC88 File Offset: 0x0007DE88
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x0007FCB2 File Offset: 0x0007DEB2
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

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x0007FCC0 File Offset: 0x0007DEC0
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x0007FCE7 File Offset: 0x0007DEE7
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

		// Token: 0x040020A7 RID: 8359
		[Nullable(2)]
		protected new SunSpiritGearComponent FbInstance;

		// Token: 0x040020A8 RID: 8360
		[Nullable(2)]
		protected new SunSpiritGearComponent_SetValue PocoInterface;
	}
}
