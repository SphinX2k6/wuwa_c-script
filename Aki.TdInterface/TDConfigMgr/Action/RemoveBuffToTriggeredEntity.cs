using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002148 RID: 8520
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x0600BB8E RID: 48014 RVA: 0x001B0F90 File Offset: 0x001AF190
		private RemoveBuffToTriggeredEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveBuffToTriggeredEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveBuffToTriggeredEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveBuffToTriggeredEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB8F RID: 48015 RVA: 0x001B0FC8 File Offset: 0x001AF1C8
		public static RemoveBuffToTriggeredEntity Create([Nullable(2)] RemoveBuffToTriggeredEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffToTriggeredEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB90 RID: 48016 RVA: 0x001B0FDB File Offset: 0x001AF1DB
		public static RemoveBuffToTriggeredEntity CreateFromSetValue([Nullable(2)] RemoveBuffToTriggeredEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveBuffToTriggeredEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x001B0FEE File Offset: 0x001AF1EE
		public RemoveBuffToTriggeredEntity_SetValue ToSetValue()
		{
			return new RemoveBuffToTriggeredEntity_SetValue
			{
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x001B1001 File Offset: 0x001AF201
		// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x001B1028 File Offset: 0x001AF228
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				RemoveBuffToTriggeredEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007022 RID: 28706
		[Nullable(2)]
		protected new RemoveBuffToTriggeredEntity FbInstance;

		// Token: 0x04007023 RID: 28707
		[Nullable(2)]
		protected RemoveBuffToTriggeredEntity_SetValue PocoInterface;
	}
}
