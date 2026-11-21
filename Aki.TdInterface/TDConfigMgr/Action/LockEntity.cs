using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232A RID: 9002
	public class LockEntity : ActionParams
	{
		// Token: 0x0600C402 RID: 50178 RVA: 0x001C1E24 File Offset: 0x001C0024
		private LockEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LockEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LockEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LockEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x001C1E5C File Offset: 0x001C005C
		public static LockEntity Create([Nullable(2)] LockEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LockEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x001C1E6F File Offset: 0x001C006F
		public static LockEntity CreateFromSetValue([Nullable(2)] LockEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LockEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x001C1E82 File Offset: 0x001C0082
		public LockEntity_SetValue ToSetValue()
		{
			return new LockEntity_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600C406 RID: 50182 RVA: 0x001C1E95 File Offset: 0x001C0095
		// (set) Token: 0x0600C407 RID: 50183 RVA: 0x001C1EBC File Offset: 0x001C00BC
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				LockEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040074BF RID: 29887
		[Nullable(2)]
		protected new LockEntity FbInstance;

		// Token: 0x040074C0 RID: 29888
		[Nullable(2)]
		protected LockEntity_SetValue PocoInterface;
	}
}
