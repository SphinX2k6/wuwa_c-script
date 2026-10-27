using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000752 RID: 1874
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleControlBaseCfg
	{
		// Token: 0x06002875 RID: 10357 RVA: 0x0006B288 File Offset: 0x00069488
		private ITeleControlBaseCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleControlBaseCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleControlBaseCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleControlBaseCfg_SetValue());
			}
			return result;
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0006B2C0 File Offset: 0x000694C0
		public static ITeleControlBaseCfg Create([Nullable(2)] ITeleControlBaseCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlBaseCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0006B2D3 File Offset: 0x000694D3
		public static ITeleControlBaseCfg CreateFromSetValue([Nullable(2)] ITeleControlBaseCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleControlBaseCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0006B2E6 File Offset: 0x000694E6
		public ITeleControlBaseCfg_SetValue ToSetValue()
		{
			return new ITeleControlBaseCfg_SetValue
			{
				CommonConfig = this.CommonConfig,
				CanRotate = this.CanRotate,
				InitialGravity = this.InitialGravity
			};
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x0006B311 File Offset: 0x00069511
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x0006B33C File Offset: 0x0006953C
		public virtual string CommonConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CommonConfig;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CommonConfig;
			}
			set
			{
				this.GetOrCreatePoco().CommonConfig = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x0006B34C File Offset: 0x0006954C
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x0006B386 File Offset: 0x00069586
		public virtual bool? CanRotate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanRotate;
				}
				ITeleControlBaseCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanRotate;
			}
			set
			{
				this.GetOrCreatePoco().CanRotate = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x0006B394 File Offset: 0x00069594
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x0006B3CE File Offset: 0x000695CE
		public virtual bool? InitialGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialGravity;
				}
				ITeleControlBaseCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialGravity;
			}
			set
			{
				this.GetOrCreatePoco().InitialGravity = value;
			}
		}

		// Token: 0x04001B37 RID: 6967
		[Nullable(2)]
		protected ITeleControlBaseCfg FbInstance;

		// Token: 0x04001B38 RID: 6968
		[Nullable(2)]
		protected ITeleControlBaseCfg_SetValue PocoInterface;
	}
}
