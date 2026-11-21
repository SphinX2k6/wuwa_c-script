using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A5 RID: 1189
	public class IIgnoreEntityIdsCollision
	{
		// Token: 0x060017E1 RID: 6113 RVA: 0x00048D18 File Offset: 0x00046F18
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

		// Token: 0x060017E2 RID: 6114 RVA: 0x00048D50 File Offset: 0x00046F50
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

		// Token: 0x060017E3 RID: 6115 RVA: 0x00048D63 File Offset: 0x00046F63
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

		// Token: 0x060017E4 RID: 6116 RVA: 0x00048D76 File Offset: 0x00046F76
		public IIgnoreEntityIdsCollision_SetValue ToSetValue()
		{
			return new IIgnoreEntityIdsCollision_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00048D89 File Offset: 0x00046F89
		// (set) Token: 0x060017E6 RID: 6118 RVA: 0x00048DB0 File Offset: 0x00046FB0
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

		// Token: 0x0400122E RID: 4654
		[Nullable(2)]
		protected IIgnoreEntityIdsCollision FbInstance;

		// Token: 0x0400122F RID: 4655
		[Nullable(2)]
		protected IIgnoreEntityIdsCollision_SetValue PocoInterface;
	}
}
