using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005CC RID: 1484
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcSpawnBase
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x00058298 File Offset: 0x00056498
		private IPasserbyNpcSpawnBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSpawnBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSpawnBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSpawnBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000582D0 File Offset: 0x000564D0
		public static IPasserbyNpcSpawnBase Create([Nullable(2)] IPasserbyNpcSpawnBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000582E3 File Offset: 0x000564E3
		public static IPasserbyNpcSpawnBase CreateFromSetValue([Nullable(2)] IPasserbyNpcSpawnBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000582F6 File Offset: 0x000564F6
		public IPasserbyNpcSpawnBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcSpawnBase_SetValue
			{
				Type = this.Type,
				MaxSpawnCount = this.MaxSpawnCount,
				MinDistance = this.MinDistance
			};
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00058321 File Offset: 0x00056521
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0005834C File Offset: 0x0005654C
		public virtual EPasserbyNpcSpawnType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSpawnType.FixInterval;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0005835A File Offset: 0x0005655A
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00058385 File Offset: 0x00056585
		public virtual int MaxSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpawnCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpawnCount = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00058394 File Offset: 0x00056594
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x000583CE File Offset: 0x000565CE
		public virtual int? MinDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinDistance;
				}
				IPasserbyNpcSpawnBase_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MinDistance;
			}
			set
			{
				this.GetOrCreatePoco().MinDistance = value;
			}
		}

		// Token: 0x04001635 RID: 5685
		[Nullable(2)]
		protected IPasserbyNpcSpawnBase FbInstance;

		// Token: 0x04001636 RID: 5686
		[Nullable(2)]
		protected IPasserbyNpcSpawnBase_SetValue PocoInterface;
	}
}
