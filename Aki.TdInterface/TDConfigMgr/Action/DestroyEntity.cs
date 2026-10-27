using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200155E RID: 5470
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyEntity : ActionParams
	{
		// Token: 0x06007B91 RID: 31633 RVA: 0x00129AD0 File Offset: 0x00127CD0
		private DestroyEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroyEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroyEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroyEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x00129B08 File Offset: 0x00127D08
		public static DestroyEntity Create([Nullable(2)] DestroyEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x00129B1B File Offset: 0x00127D1B
		public static DestroyEntity CreateFromSetValue([Nullable(2)] DestroyEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroyEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x00129B2E File Offset: 0x00127D2E
		public DestroyEntity_SetValue ToSetValue()
		{
			return new DestroyEntity_SetValue
			{
				EntityIds = this.EntityIds,
				DelayDestroy = this.DelayDestroy
			};
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06007B95 RID: 31637 RVA: 0x00129B4D File Offset: 0x00127D4D
		// (set) Token: 0x06007B96 RID: 31638 RVA: 0x00129B74 File Offset: 0x00127D74
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				DestroyEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x00129B84 File Offset: 0x00127D84
		// (set) Token: 0x06007B98 RID: 31640 RVA: 0x00129BBE File Offset: 0x00127DBE
		public virtual bool? DelayDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDestroy;
				}
				DestroyEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayDestroy;
			}
			set
			{
				this.GetOrCreatePoco().DelayDestroy = value;
			}
		}

		// Token: 0x0400472A RID: 18218
		[Nullable(2)]
		protected new DestroyEntity FbInstance;

		// Token: 0x0400472B RID: 18219
		[Nullable(2)]
		protected DestroyEntity_SetValue PocoInterface;
	}
}
