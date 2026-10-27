using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020CD RID: 8397
	[NullableContext(1)]
	[Nullable(0)]
	public class LockEntity : ActionParams
	{
		// Token: 0x0600B88A RID: 47242 RVA: 0x001AAEFC File Offset: 0x001A90FC
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

		// Token: 0x0600B88B RID: 47243 RVA: 0x001AAF34 File Offset: 0x001A9134
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

		// Token: 0x0600B88C RID: 47244 RVA: 0x001AAF47 File Offset: 0x001A9147
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

		// Token: 0x0600B88D RID: 47245 RVA: 0x001AAF5A File Offset: 0x001A915A
		public LockEntity_SetValue ToSetValue()
		{
			return new LockEntity_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600B88E RID: 47246 RVA: 0x001AAF6D File Offset: 0x001A916D
		// (set) Token: 0x0600B88F RID: 47247 RVA: 0x001AAF94 File Offset: 0x001A9194
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

		// Token: 0x04006E95 RID: 28309
		[Nullable(2)]
		protected new LockEntity FbInstance;

		// Token: 0x04006E96 RID: 28310
		[Nullable(2)]
		protected LockEntity_SetValue PocoInterface;
	}
}
