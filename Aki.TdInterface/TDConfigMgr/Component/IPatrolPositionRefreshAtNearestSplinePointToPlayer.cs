using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200067B RID: 1659
	public class IPatrolPositionRefreshAtNearestSplinePointToPlayer : IPatrolPositionRefresh
	{
		// Token: 0x060022DA RID: 8922 RVA: 0x0005FD00 File Offset: 0x0005DF00
		private IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolPositionRefreshAtNearestSplinePointToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0005FD38 File Offset: 0x0005DF38
		public static IPatrolPositionRefreshAtNearestSplinePointToPlayer Create([Nullable(2)] IPatrolPositionRefreshAtNearestSplinePointToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshAtNearestSplinePointToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0005FD4B File Offset: 0x0005DF4B
		public static IPatrolPositionRefreshAtNearestSplinePointToPlayer CreateFromSetValue([Nullable(2)] IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshAtNearestSplinePointToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0005FD5E File Offset: 0x0005DF5E
		public new IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue ToSetValue()
		{
			return new IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x0005FD71 File Offset: 0x0005DF71
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x0005FD9C File Offset: 0x0005DF9C
		public override EPatrolPositionRefreshType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPatrolPositionRefreshType.NearestSplinePointToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400185A RID: 6234
		[Nullable(2)]
		protected new IPatrolPositionRefreshAtNearestSplinePointToPlayer FbInstance;

		// Token: 0x0400185B RID: 6235
		[Nullable(2)]
		protected new IPatrolPositionRefreshAtNearestSplinePointToPlayer_SetValue PocoInterface;
	}
}
