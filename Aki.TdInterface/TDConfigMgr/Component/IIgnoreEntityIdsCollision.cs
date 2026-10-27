using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200044C RID: 1100
	[NullableContext(1)]
	[Nullable(0)]
	public class IIgnoreEntityIdsCollision
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x00044FD0 File Offset: 0x000431D0
		private IIgnoreEntityIdsCollision_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IIgnoreEntityIdsCollision 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IIgnoreEntityIdsCollision_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IIgnoreEntityIdsCollision_SetValue());
			}
			return result;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00045008 File Offset: 0x00043208
		public static IIgnoreEntityIdsCollision Create([Nullable(2)] IIgnoreEntityIdsCollision instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIgnoreEntityIdsCollision
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0004501B File Offset: 0x0004321B
		public static IIgnoreEntityIdsCollision CreateFromSetValue([Nullable(2)] IIgnoreEntityIdsCollision_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IIgnoreEntityIdsCollision
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0004502E File Offset: 0x0004322E
		public IIgnoreEntityIdsCollision_SetValue ToSetValue()
		{
			return new IIgnoreEntityIdsCollision_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00045041 File Offset: 0x00043241
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x00045068 File Offset: 0x00043268
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IIgnoreEntityIdsCollision_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400110C RID: 4364
		[Nullable(2)]
		protected IIgnoreEntityIdsCollision FbInstance;

		// Token: 0x0400110D RID: 4365
		[Nullable(2)]
		protected IIgnoreEntityIdsCollision_SetValue PocoInterface;
	}
}
