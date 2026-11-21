using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000904 RID: 2308
	public class PullingFoundation : IComponentBase
	{
		// Token: 0x060032A9 RID: 12969 RVA: 0x00081B20 File Offset: 0x0007FD20
		private PullingFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PullingFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PullingFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PullingFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00081B58 File Offset: 0x0007FD58
		public static PullingFoundation Create([Nullable(2)] PullingFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PullingFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x00081B6B File Offset: 0x0007FD6B
		public static PullingFoundation CreateFromSetValue([Nullable(2)] PullingFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PullingFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x00081B7E File Offset: 0x0007FD7E
		public new PullingFoundation_SetValue ToSetValue()
		{
			return new PullingFoundation_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x00081BAC File Offset: 0x0007FDAC
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x00081BE6 File Offset: 0x0007FDE6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				PullingFoundation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x00081BF4 File Offset: 0x0007FDF4
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x00081C1E File Offset: 0x0007FE1E
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

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x00081C2C File Offset: 0x0007FE2C
		// (set) Token: 0x060032B2 RID: 12978 RVA: 0x00081C8D File Offset: 0x0007FE8D
		public virtual IPullingCategoryMatchingFoundation Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IPullingCategoryMatchingFoundation.Create(this.FbInstance.Config);
				}
				else
				{
					PullingFoundation_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x0400215C RID: 8540
		[Nullable(2)]
		protected new PullingFoundation FbInstance;

		// Token: 0x0400215D RID: 8541
		[Nullable(2)]
		protected new PullingFoundation_SetValue PocoInterface;

		// Token: 0x0400215E RID: 8542
		private IPullingCategoryMatchingFoundation _ConfigCache;

		// Token: 0x0400215F RID: 8543
		private bool _ConfigInited;
	}
}
