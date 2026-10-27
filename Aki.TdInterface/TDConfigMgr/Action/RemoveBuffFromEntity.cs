using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002144 RID: 8516
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveBuffFromEntity : ActionParams
	{
		// Token: 0x0600BB7A RID: 47994 RVA: 0x001B0D88 File Offset: 0x001AEF88
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

		// Token: 0x0600BB7B RID: 47995 RVA: 0x001B0DC0 File Offset: 0x001AEFC0
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

		// Token: 0x0600BB7C RID: 47996 RVA: 0x001B0DD3 File Offset: 0x001AEFD3
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

		// Token: 0x0600BB7D RID: 47997 RVA: 0x001B0DE6 File Offset: 0x001AEFE6
		public RemoveBuffFromEntity_SetValue ToSetValue()
		{
			return new RemoveBuffFromEntity_SetValue
			{
				EntityId = this.EntityId,
				EntityIds = this.EntityIds,
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x001B0E14 File Offset: 0x001AF014
		// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x001B0E4E File Offset: 0x001AF04E
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

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x001B0E5C File Offset: 0x001AF05C
		// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x001B0E83 File Offset: 0x001AF083
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

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x001B0E91 File Offset: 0x001AF091
		// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x001B0EB8 File Offset: 0x001AF0B8
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

		// Token: 0x0400701A RID: 28698
		[Nullable(2)]
		protected new RemoveBuffFromEntity FbInstance;

		// Token: 0x0400701B RID: 28699
		[Nullable(2)]
		protected RemoveBuffFromEntity_SetValue PocoInterface;
	}
}
