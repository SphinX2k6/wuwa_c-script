using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E6 RID: 2278
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponComponent : IComponentBase
	{
		// Token: 0x060033B1 RID: 13233 RVA: 0x0008451C File Offset: 0x0008271C
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

		// Token: 0x060033B2 RID: 13234 RVA: 0x00084554 File Offset: 0x00082754
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

		// Token: 0x060033B3 RID: 13235 RVA: 0x00084567 File Offset: 0x00082767
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

		// Token: 0x060033B4 RID: 13236 RVA: 0x0008457A File Offset: 0x0008277A
		public new WeaponComponent_SetValue ToSetValue()
		{
			return new WeaponComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WeaponId = this.WeaponId
			};
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000845A8 File Offset: 0x000827A8
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x000845E2 File Offset: 0x000827E2
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

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000845F0 File Offset: 0x000827F0
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x0008461A File Offset: 0x0008281A
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

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x00084628 File Offset: 0x00082828
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x00084653 File Offset: 0x00082853
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

		// Token: 0x040021DA RID: 8666
		[Nullable(2)]
		protected new WeaponComponent FbInstance;

		// Token: 0x040021DB RID: 8667
		[Nullable(2)]
		protected new WeaponComponent_SetValue PocoInterface;
	}
}
