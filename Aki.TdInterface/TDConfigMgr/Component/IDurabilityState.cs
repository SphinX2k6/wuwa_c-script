using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200031C RID: 796
	public class IDurabilityState
	{
		// Token: 0x06000F07 RID: 3847 RVA: 0x00036018 File Offset: 0x00034218
		private IDurabilityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurabilityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurabilityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurabilityState_SetValue());
			}
			return result;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00036050 File Offset: 0x00034250
		public static IDurabilityState Create([Nullable(2)] IDurabilityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00036063 File Offset: 0x00034263
		public static IDurabilityState CreateFromSetValue([Nullable(2)] IDurabilityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurabilityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00036076 File Offset: 0x00034276
		public IDurabilityState_SetValue ToSetValue()
		{
			return new IDurabilityState_SetValue
			{
				Durability = this.Durability,
				State = this.State
			};
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00036095 File Offset: 0x00034295
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x000360C0 File Offset: 0x000342C0
		public virtual int Durability
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Durability;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Durability;
			}
			set
			{
				this.GetOrCreatePoco().Durability = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000360CE File Offset: 0x000342CE
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x000360F9 File Offset: 0x000342F9
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04000D56 RID: 3414
		[Nullable(2)]
		protected IDurabilityState FbInstance;

		// Token: 0x04000D57 RID: 3415
		[Nullable(2)]
		protected IDurabilityState_SetValue PocoInterface;
	}
}
