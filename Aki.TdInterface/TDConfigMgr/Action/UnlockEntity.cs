using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002263 RID: 8803
	[NullableContext(1)]
	[Nullable(0)]
	public class UnlockEntity : ActionParams
	{
		// Token: 0x0600C11C RID: 49436 RVA: 0x001BB448 File Offset: 0x001B9648
		private UnlockEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UnlockEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UnlockEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UnlockEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C11D RID: 49437 RVA: 0x001BB480 File Offset: 0x001B9680
		public static UnlockEntity Create([Nullable(2)] UnlockEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C11E RID: 49438 RVA: 0x001BB493 File Offset: 0x001B9693
		public static UnlockEntity CreateFromSetValue([Nullable(2)] UnlockEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UnlockEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C11F RID: 49439 RVA: 0x001BB4A6 File Offset: 0x001B96A6
		public UnlockEntity_SetValue ToSetValue()
		{
			return new UnlockEntity_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600C120 RID: 49440 RVA: 0x001BB4B9 File Offset: 0x001B96B9
		// (set) Token: 0x0600C121 RID: 49441 RVA: 0x001BB4E0 File Offset: 0x001B96E0
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				UnlockEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04007314 RID: 29460
		[Nullable(2)]
		protected new UnlockEntity FbInstance;

		// Token: 0x04007315 RID: 29461
		[Nullable(2)]
		protected UnlockEntity_SetValue PocoInterface;
	}
}
