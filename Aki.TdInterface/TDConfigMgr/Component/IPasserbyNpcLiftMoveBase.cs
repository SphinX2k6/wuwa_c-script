using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200063F RID: 1599
	public class IPasserbyNpcLiftMoveBase
	{
		// Token: 0x06002198 RID: 8600 RVA: 0x0005D644 File Offset: 0x0005B844
		private IPasserbyNpcLiftMoveBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcLiftMoveBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcLiftMoveBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcLiftMoveBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0005D67C File Offset: 0x0005B87C
		public static IPasserbyNpcLiftMoveBase Create([Nullable(2)] IPasserbyNpcLiftMoveBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftMoveBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0005D68F File Offset: 0x0005B88F
		public static IPasserbyNpcLiftMoveBase CreateFromSetValue([Nullable(2)] IPasserbyNpcLiftMoveBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftMoveBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0005D6A2 File Offset: 0x0005B8A2
		public IPasserbyNpcLiftMoveBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcLiftMoveBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0005D6B5 File Offset: 0x0005B8B5
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
		public virtual EPasserbyNpcLiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040017BB RID: 6075
		[Nullable(2)]
		protected IPasserbyNpcLiftMoveBase FbInstance;

		// Token: 0x040017BC RID: 6076
		[Nullable(2)]
		protected IPasserbyNpcLiftMoveBase_SetValue PocoInterface;
	}
}
