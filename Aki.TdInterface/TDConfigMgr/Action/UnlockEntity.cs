using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024D0 RID: 9424
	public class UnlockEntity : ActionParams
	{
		// Token: 0x0600CCE2 RID: 52450 RVA: 0x001D2BCC File Offset: 0x001D0DCC
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

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x001D2C04 File Offset: 0x001D0E04
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

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x001D2C17 File Offset: 0x001D0E17
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

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x001D2C2A File Offset: 0x001D0E2A
		public UnlockEntity_SetValue ToSetValue()
		{
			return new UnlockEntity_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600CCE6 RID: 52454 RVA: 0x001D2C3D File Offset: 0x001D0E3D
		// (set) Token: 0x0600CCE7 RID: 52455 RVA: 0x001D2C64 File Offset: 0x001D0E64
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

		// Token: 0x04007961 RID: 31073
		[Nullable(2)]
		protected new UnlockEntity FbInstance;

		// Token: 0x04007962 RID: 31074
		[Nullable(2)]
		protected UnlockEntity_SetValue PocoInterface;
	}
}
