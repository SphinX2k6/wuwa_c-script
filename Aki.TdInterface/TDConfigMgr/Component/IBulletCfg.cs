using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200022E RID: 558
	public class IBulletCfg
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x00028A40 File Offset: 0x00026C40
		private IBulletCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBulletCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBulletCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBulletCfg_SetValue());
			}
			return result;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00028A78 File Offset: 0x00026C78
		public static IBulletCfg Create([Nullable(2)] IBulletCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBulletCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00028A8B File Offset: 0x00026C8B
		public static IBulletCfg CreateFromSetValue([Nullable(2)] IBulletCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBulletCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00028A9E File Offset: 0x00026C9E
		public IBulletCfg_SetValue ToSetValue()
		{
			return new IBulletCfg_SetValue
			{
				CreateConditions = this.CreateConditions
			};
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00028AB1 File Offset: 0x00026CB1
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00028AD8 File Offset: 0x00026CD8
		public virtual List<IBulletCreateCondition> CreateConditions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CreateConditions;
				}
				IBulletCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CreateConditions;
			}
			set
			{
				this.GetOrCreatePoco().CreateConditions = value;
			}
		}

		// Token: 0x040009C5 RID: 2501
		[Nullable(2)]
		protected IBulletCfg FbInstance;

		// Token: 0x040009C6 RID: 2502
		[Nullable(2)]
		protected IBulletCfg_SetValue PocoInterface;
	}
}
