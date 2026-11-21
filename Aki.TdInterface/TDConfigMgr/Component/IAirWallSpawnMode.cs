using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D6 RID: 470
	public class IAirWallSpawnMode
	{
		// Token: 0x0600072C RID: 1836 RVA: 0x000250C4 File Offset: 0x000232C4
		private IAirWallSpawnMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirWallSpawnMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirWallSpawnMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirWallSpawnMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000250FC File Offset: 0x000232FC
		public static IAirWallSpawnMode Create([Nullable(2)] IAirWallSpawnMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallSpawnMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0002510F File Offset: 0x0002330F
		public static IAirWallSpawnMode CreateFromSetValue([Nullable(2)] IAirWallSpawnMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirWallSpawnMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00025122 File Offset: 0x00023322
		public IAirWallSpawnMode_SetValue ToSetValue()
		{
			return new IAirWallSpawnMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00025135 File Offset: 0x00023335
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00025160 File Offset: 0x00023360
		public virtual EAirWallSpawnMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAirWallSpawnMode.Whole;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040008CB RID: 2251
		[Nullable(2)]
		protected IAirWallSpawnMode FbInstance;

		// Token: 0x040008CC RID: 2252
		[Nullable(2)]
		protected IAirWallSpawnMode_SetValue PocoInterface;
	}
}
