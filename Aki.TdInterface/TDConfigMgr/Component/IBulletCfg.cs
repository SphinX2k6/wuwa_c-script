using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000205 RID: 517
	[NullableContext(1)]
	[Nullable(0)]
	public class IBulletCfg
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x000270EC File Offset: 0x000252EC
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

		// Token: 0x06000891 RID: 2193 RVA: 0x00027124 File Offset: 0x00025324
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

		// Token: 0x06000892 RID: 2194 RVA: 0x00027137 File Offset: 0x00025337
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

		// Token: 0x06000893 RID: 2195 RVA: 0x0002714A File Offset: 0x0002534A
		public IBulletCfg_SetValue ToSetValue()
		{
			return new IBulletCfg_SetValue
			{
				CreateConditions = this.CreateConditions
			};
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0002715D File Offset: 0x0002535D
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00027184 File Offset: 0x00025384
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

		// Token: 0x04000934 RID: 2356
		[Nullable(2)]
		protected IBulletCfg FbInstance;

		// Token: 0x04000935 RID: 2357
		[Nullable(2)]
		protected IBulletCfg_SetValue PocoInterface;
	}
}
