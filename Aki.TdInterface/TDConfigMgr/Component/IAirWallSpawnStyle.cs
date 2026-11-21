using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D8 RID: 472
	public class IAirWallSpawnStyle
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x00025180 File Offset: 0x00023380
		private IAirWallSpawnStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirWallSpawnStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirWallSpawnStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirWallSpawnStyle_SetValue());
			}
			return result;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000251B8 File Offset: 0x000233B8
		public static IAirWallSpawnStyle Create([Nullable(2)] IAirWallSpawnStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallSpawnStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000251CB File Offset: 0x000233CB
		public static IAirWallSpawnStyle CreateFromSetValue([Nullable(2)] IAirWallSpawnStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirWallSpawnStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000251DE File Offset: 0x000233DE
		public IAirWallSpawnStyle_SetValue ToSetValue()
		{
			return new IAirWallSpawnStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000251F1 File Offset: 0x000233F1
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0002521C File Offset: 0x0002341C
		public virtual EAirWallSpawnStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAirWallSpawnStyle.AlongSpline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040008CE RID: 2254
		[Nullable(2)]
		protected IAirWallSpawnStyle FbInstance;

		// Token: 0x040008CF RID: 2255
		[Nullable(2)]
		protected IAirWallSpawnStyle_SetValue PocoInterface;
	}
}
