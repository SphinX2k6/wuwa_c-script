using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A5 RID: 9125
	public class RemoveBuffFromEntity : ActionParams
	{
		// Token: 0x0600C708 RID: 50952 RVA: 0x001C7F3C File Offset: 0x001C613C
		private RemoveBuffFromEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveBuffFromEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveBuffFromEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveBuffFromEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C709 RID: 50953 RVA: 0x001C7F74 File Offset: 0x001C6174
		public static RemoveBuffFromEntity Create([Nullable(2)] RemoveBuffFromEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffFromEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x001C7F87 File Offset: 0x001C6187
		public static RemoveBuffFromEntity CreateFromSetValue([Nullable(2)] RemoveBuffFromEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveBuffFromEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x001C7F9A File Offset: 0x001C619A
		public RemoveBuffFromEntity_SetValue ToSetValue()
		{
			return new RemoveBuffFromEntity_SetValue
			{
				EntityId = this.EntityId,
				EntityIds = this.EntityIds,
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600C70C RID: 50956 RVA: 0x001C7FC8 File Offset: 0x001C61C8
		// (set) Token: 0x0600C70D RID: 50957 RVA: 0x001C8002 File Offset: 0x001C6202
		public virtual int? EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				RemoveBuffFromEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600C70E RID: 50958 RVA: 0x001C8010 File Offset: 0x001C6210
		// (set) Token: 0x0600C70F RID: 50959 RVA: 0x001C8037 File Offset: 0x001C6237
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
				RemoveBuffFromEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0600C710 RID: 50960 RVA: 0x001C8045 File Offset: 0x001C6245
		// (set) Token: 0x0600C711 RID: 50961 RVA: 0x001C806C File Offset: 0x001C626C
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				RemoveBuffFromEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400764F RID: 30287
		[Nullable(2)]
		protected new RemoveBuffFromEntity FbInstance;

		// Token: 0x04007650 RID: 30288
		[Nullable(2)]
		protected RemoveBuffFromEntity_SetValue PocoInterface;
	}
}
