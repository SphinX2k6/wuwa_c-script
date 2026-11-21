using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C7 RID: 9159
	public class RestoreAiBehaviorTree : ActionParams
	{
		// Token: 0x0600C7AA RID: 51114 RVA: 0x001C9080 File Offset: 0x001C7280
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

		// Token: 0x0600C7AB RID: 51115 RVA: 0x001C90B8 File Offset: 0x001C72B8
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

		// Token: 0x0600C7AC RID: 51116 RVA: 0x001C90CB File Offset: 0x001C72CB
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

		// Token: 0x0600C7AD RID: 51117 RVA: 0x001C90DE File Offset: 0x001C72DE
		public RestoreAiBehaviorTree_SetValue ToSetValue()
		{
			return new RestoreAiBehaviorTree_SetValue
			{
				Key = this.Key
			};
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x001C90F1 File Offset: 0x001C72F1
		// (set) Token: 0x0600C7AF RID: 51119 RVA: 0x001C911C File Offset: 0x001C731C
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

		// Token: 0x04007697 RID: 30359
		[Nullable(2)]
		protected new RestoreAiBehaviorTree FbInstance;

		// Token: 0x04007698 RID: 30360
		[Nullable(2)]
		protected RestoreAiBehaviorTree_SetValue PocoInterface;
	}
}
