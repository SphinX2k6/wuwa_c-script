using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004AD RID: 1197
	public class IIndependentSystemRewardType
	{
		// Token: 0x06001803 RID: 6147 RVA: 0x000490B4 File Offset: 0x000472B4
		private IIndependentSystemRewardType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IIndependentSystemRewardType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IIndependentSystemRewardType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IIndependentSystemRewardType_SetValue());
			}
			return result;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000490EC File Offset: 0x000472EC
		public static IIndependentSystemRewardType Create([Nullable(2)] IIndependentSystemRewardType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIndependentSystemRewardType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000490FF File Offset: 0x000472FF
		public static IIndependentSystemRewardType CreateFromSetValue([Nullable(2)] IIndependentSystemRewardType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IIndependentSystemRewardType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00049112 File Offset: 0x00047312
		public IIndependentSystemRewardType_SetValue ToSetValue()
		{
			return new IIndependentSystemRewardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00049125 File Offset: 0x00047325
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00049150 File Offset: 0x00047350
		public virtual EIndependentSystemRewardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EIndependentSystemRewardType.DarkTide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400123D RID: 4669
		[Nullable(2)]
		protected IIndependentSystemRewardType FbInstance;

		// Token: 0x0400123E RID: 4670
		[Nullable(2)]
		protected IIndependentSystemRewardType_SetValue PocoInterface;
	}
}
