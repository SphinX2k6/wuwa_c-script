using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098B RID: 2443
	public class WeaponComponent : IComponentBase
	{
		// Token: 0x060036F9 RID: 14073 RVA: 0x0008BB58 File Offset: 0x00089D58
		private WeaponComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("WeaponComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			WeaponComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new WeaponComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x0008BB90 File Offset: 0x00089D90
		public static WeaponComponent Create([Nullable(2)] WeaponComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WeaponComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x0008BBA3 File Offset: 0x00089DA3
		public static WeaponComponent CreateFromSetValue([Nullable(2)] WeaponComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new WeaponComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x0008BBB6 File Offset: 0x00089DB6
		public new WeaponComponent_SetValue ToSetValue()
		{
			return new WeaponComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WeaponId = this.WeaponId
			};
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x0008BBE4 File Offset: 0x00089DE4
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x0008BC1E File Offset: 0x00089E1E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				WeaponComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x0008BC2C File Offset: 0x00089E2C
		// (set) Token: 0x06003700 RID: 14080 RVA: 0x0008BC56 File Offset: 0x00089E56
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

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x0008BC64 File Offset: 0x00089E64
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x0008BC8F File Offset: 0x00089E8F
		public virtual int WeaponId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeaponId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WeaponId;
			}
			set
			{
				this.GetOrCreatePoco().WeaponId = value;
			}
		}

		// Token: 0x040023F1 RID: 9201
		[Nullable(2)]
		protected new WeaponComponent FbInstance;

		// Token: 0x040023F2 RID: 9202
		[Nullable(2)]
		protected new WeaponComponent_SetValue PocoInterface;
	}
}
