using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000679 RID: 1657
	public class IPatrolPositionRefresh
	{
		// Token: 0x060022D2 RID: 8914 RVA: 0x0005FC44 File Offset: 0x0005DE44
		private IPatrolPositionRefresh_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolPositionRefresh 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolPositionRefresh_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolPositionRefresh_SetValue());
			}
			return result;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0005FC7C File Offset: 0x0005DE7C
		public static IPatrolPositionRefresh Create([Nullable(2)] IPatrolPositionRefresh instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefresh
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0005FC8F File Offset: 0x0005DE8F
		public static IPatrolPositionRefresh CreateFromSetValue([Nullable(2)] IPatrolPositionRefresh_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolPositionRefresh
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0005FCA2 File Offset: 0x0005DEA2
		public IPatrolPositionRefresh_SetValue ToSetValue()
		{
			return new IPatrolPositionRefresh_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x0005FCB5 File Offset: 0x0005DEB5
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0005FCE0 File Offset: 0x0005DEE0
		public virtual EPatrolPositionRefreshType Type
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

		// Token: 0x04001857 RID: 6231
		[Nullable(2)]
		protected IPatrolPositionRefresh FbInstance;

		// Token: 0x04001858 RID: 6232
		[Nullable(2)]
		protected IPatrolPositionRefresh_SetValue PocoInterface;
	}
}
