using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000454 RID: 1108
	[NullableContext(1)]
	[Nullable(0)]
	public class IIndependentSystemRewardType
	{
		// Token: 0x06001669 RID: 5737 RVA: 0x0004536C File Offset: 0x0004356C
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

		// Token: 0x0600166A RID: 5738 RVA: 0x000453A4 File Offset: 0x000435A4
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

		// Token: 0x0600166B RID: 5739 RVA: 0x000453B7 File Offset: 0x000435B7
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

		// Token: 0x0600166C RID: 5740 RVA: 0x000453CA File Offset: 0x000435CA
		public IIndependentSystemRewardType_SetValue ToSetValue()
		{
			return new IIndependentSystemRewardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x000453DD File Offset: 0x000435DD
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00045408 File Offset: 0x00043608
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

		// Token: 0x0400111B RID: 4379
		[Nullable(2)]
		protected IIndependentSystemRewardType FbInstance;

		// Token: 0x0400111C RID: 4380
		[Nullable(2)]
		protected IIndependentSystemRewardType_SetValue PocoInterface;
	}
}
