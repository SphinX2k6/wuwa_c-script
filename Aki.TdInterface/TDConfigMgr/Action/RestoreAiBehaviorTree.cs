using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002166 RID: 8550
	[NullableContext(1)]
	[Nullable(0)]
	public class RestoreAiBehaviorTree : ActionParams
	{
		// Token: 0x0600BC1C RID: 48156 RVA: 0x001B1ECC File Offset: 0x001B00CC
		private RestoreAiBehaviorTree_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RestoreAiBehaviorTree 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RestoreAiBehaviorTree_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RestoreAiBehaviorTree_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x001B1F04 File Offset: 0x001B0104
		public static RestoreAiBehaviorTree Create([Nullable(2)] RestoreAiBehaviorTree instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestoreAiBehaviorTree
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x001B1F17 File Offset: 0x001B0117
		public static RestoreAiBehaviorTree CreateFromSetValue([Nullable(2)] RestoreAiBehaviorTree_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RestoreAiBehaviorTree
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x001B1F2A File Offset: 0x001B012A
		public RestoreAiBehaviorTree_SetValue ToSetValue()
		{
			return new RestoreAiBehaviorTree_SetValue
			{
				Key = this.Key
			};
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x001B1F3D File Offset: 0x001B013D
		// (set) Token: 0x0600BC21 RID: 48161 RVA: 0x001B1F68 File Offset: 0x001B0168
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x04007062 RID: 28770
		[Nullable(2)]
		protected new RestoreAiBehaviorTree FbInstance;

		// Token: 0x04007063 RID: 28771
		[Nullable(2)]
		protected RestoreAiBehaviorTree_SetValue PocoInterface;
	}
}
