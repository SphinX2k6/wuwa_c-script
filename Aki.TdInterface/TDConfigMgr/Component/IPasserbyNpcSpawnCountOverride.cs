using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005CE RID: 1486
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcSpawnCountOverride
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x000583EC File Offset: 0x000565EC
		private IPasserbyNpcSpawnCountOverride_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSpawnCountOverride 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSpawnCountOverride_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSpawnCountOverride_SetValue());
			}
			return result;
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00058424 File Offset: 0x00056624
		public static IPasserbyNpcSpawnCountOverride Create([Nullable(2)] IPasserbyNpcSpawnCountOverride instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCountOverride
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00058437 File Offset: 0x00056637
		public static IPasserbyNpcSpawnCountOverride CreateFromSetValue([Nullable(2)] IPasserbyNpcSpawnCountOverride_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCountOverride
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0005844A File Offset: 0x0005664A
		public IPasserbyNpcSpawnCountOverride_SetValue ToSetValue()
		{
			return new IPasserbyNpcSpawnCountOverride_SetValue
			{
				PcSpawnCount = this.PcSpawnCount,
				MobileSpawnCount = this.MobileSpawnCount
			};
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x0005846C File Offset: 0x0005666C
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x000584A6 File Offset: 0x000566A6
		public virtual int? PcSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PcSpawnCount;
				}
				IPasserbyNpcSpawnCountOverride_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PcSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().PcSpawnCount = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x000584B4 File Offset: 0x000566B4
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x000584EE File Offset: 0x000566EE
		public virtual int? MobileSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MobileSpawnCount;
				}
				IPasserbyNpcSpawnCountOverride_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MobileSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().MobileSpawnCount = value;
			}
		}

		// Token: 0x0400163A RID: 5690
		[Nullable(2)]
		protected IPasserbyNpcSpawnCountOverride FbInstance;

		// Token: 0x0400163B RID: 5691
		[Nullable(2)]
		protected IPasserbyNpcSpawnCountOverride_SetValue PocoInterface;
	}
}
