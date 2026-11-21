using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E2 RID: 5602
	public class AddBuffToEntity : ActionParams
	{
		// Token: 0x06007E65 RID: 32357 RVA: 0x0012DD3C File Offset: 0x0012BF3C
		private AddBuffToEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddBuffToEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddBuffToEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddBuffToEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x0012DD74 File Offset: 0x0012BF74
		public static AddBuffToEntity Create([Nullable(2)] AddBuffToEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x0012DD87 File Offset: 0x0012BF87
		public static AddBuffToEntity CreateFromSetValue([Nullable(2)] AddBuffToEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddBuffToEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x0012DD9A File Offset: 0x0012BF9A
		public AddBuffToEntity_SetValue ToSetValue()
		{
			return new AddBuffToEntity_SetValue
			{
				EntityId = this.EntityId,
				EntityIds = this.EntityIds,
				BuffIds = this.BuffIds,
				PersistOnOfflineBuffIds = this.PersistOnOfflineBuffIds
			};
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x0012DDD4 File Offset: 0x0012BFD4
		// (set) Token: 0x06007E6A RID: 32362 RVA: 0x0012DE0E File Offset: 0x0012C00E
		public virtual int? EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				AddBuffToEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x0012DE1C File Offset: 0x0012C01C
		// (set) Token: 0x06007E6C RID: 32364 RVA: 0x0012DE43 File Offset: 0x0012C043
		[Nullable(2)]
		public virtual List<int> EntityIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				AddBuffToEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x0012DE51 File Offset: 0x0012C051
		// (set) Token: 0x06007E6E RID: 32366 RVA: 0x0012DE78 File Offset: 0x0012C078
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				AddBuffToEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BuffIds;
			}
			set
			{
				this.GetOrCreatePoco().BuffIds = value;
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06007E6F RID: 32367 RVA: 0x0012DE86 File Offset: 0x0012C086
		// (set) Token: 0x06007E70 RID: 32368 RVA: 0x0012DEAD File Offset: 0x0012C0AD
		[Nullable(2)]
		public virtual List<long> PersistOnOfflineBuffIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PersistOnOfflineBuffIds;
				}
				AddBuffToEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PersistOnOfflineBuffIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PersistOnOfflineBuffIds = value;
			}
		}

		// Token: 0x0400492B RID: 18731
		[Nullable(2)]
		protected new AddBuffToEntity FbInstance;

		// Token: 0x0400492C RID: 18732
		[Nullable(2)]
		protected AddBuffToEntity_SetValue PocoInterface;
	}
}
