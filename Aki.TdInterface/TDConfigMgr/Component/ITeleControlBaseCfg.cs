using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F3 RID: 2035
	public class ITeleControlBaseCfg
	{
		// Token: 0x06002B99 RID: 11161 RVA: 0x00072430 File Offset: 0x00070630
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

		// Token: 0x06002B9A RID: 11162 RVA: 0x00072468 File Offset: 0x00070668
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

		// Token: 0x06002B9B RID: 11163 RVA: 0x0007247B File Offset: 0x0007067B
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

		// Token: 0x06002B9C RID: 11164 RVA: 0x0007248E File Offset: 0x0007068E
		public ITeleControlBaseCfg_SetValue ToSetValue()
		{
			return new ITeleControlBaseCfg_SetValue
			{
				CommonConfig = this.CommonConfig,
				CanRotate = this.CanRotate,
				InitialGravity = this.InitialGravity
			};
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000724B9 File Offset: 0x000706B9
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x000724E4 File Offset: 0x000706E4
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000724F4 File Offset: 0x000706F4
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x0007252E File Offset: 0x0007072E
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

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x0007253C File Offset: 0x0007073C
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00072576 File Offset: 0x00070776
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

		// Token: 0x04001D3C RID: 7484
		[Nullable(2)]
		protected ITeleControlBaseCfg FbInstance;

		// Token: 0x04001D3D RID: 7485
		[Nullable(2)]
		protected ITeleControlBaseCfg_SetValue PocoInterface;
	}
}
