using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001489 RID: 5257
	[NullableContext(2)]
	[Nullable(0)]
	public class AddBuffToEntity : ActionParams
	{
		// Token: 0x06007798 RID: 30616 RVA: 0x0011F0F0 File Offset: 0x0011D2F0
		[NullableContext(1)]
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

		// Token: 0x06007799 RID: 30617 RVA: 0x0011F128 File Offset: 0x0011D328
		[NullableContext(1)]
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

		// Token: 0x0600779A RID: 30618 RVA: 0x0011F13B File Offset: 0x0011D33B
		[NullableContext(1)]
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

		// Token: 0x0600779B RID: 30619 RVA: 0x0011F14E File Offset: 0x0011D34E
		[NullableContext(1)]
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

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x0011F188 File Offset: 0x0011D388
		// (set) Token: 0x0600779D RID: 30621 RVA: 0x0011F1C2 File Offset: 0x0011D3C2
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

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x0600779E RID: 30622 RVA: 0x0011F1D0 File Offset: 0x0011D3D0
		// (set) Token: 0x0600779F RID: 30623 RVA: 0x0011F1F7 File Offset: 0x0011D3F7
		public virtual List<int> EntityIds
		{
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
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x060077A0 RID: 30624 RVA: 0x0011F205 File Offset: 0x0011D405
		// (set) Token: 0x060077A1 RID: 30625 RVA: 0x0011F22C File Offset: 0x0011D42C
		[Nullable(1)]
		public virtual List<long> BuffIds
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().BuffIds = value;
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x060077A2 RID: 30626 RVA: 0x0011F23A File Offset: 0x0011D43A
		// (set) Token: 0x060077A3 RID: 30627 RVA: 0x0011F261 File Offset: 0x0011D461
		public virtual List<long> PersistOnOfflineBuffIds
		{
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
			set
			{
				this.GetOrCreatePoco().PersistOnOfflineBuffIds = value;
			}
		}

		// Token: 0x04004590 RID: 17808
		protected new AddBuffToEntity FbInstance;

		// Token: 0x04004591 RID: 17809
		protected AddBuffToEntity_SetValue PocoInterface;
	}
}
