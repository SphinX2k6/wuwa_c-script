using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D2 RID: 1490
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcSplineMove : IPasserbyNpcMoveBase
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x00058744 File Offset: 0x00056944
		private IPasserbyNpcSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0005877C File Offset: 0x0005697C
		public static IPasserbyNpcSplineMove Create([Nullable(2)] IPasserbyNpcSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0005878F File Offset: 0x0005698F
		public static IPasserbyNpcSplineMove CreateFromSetValue([Nullable(2)] IPasserbyNpcSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000587A2 File Offset: 0x000569A2
		public new IPasserbyNpcSplineMove_SetValue ToSetValue()
		{
			return new IPasserbyNpcSplineMove_SetValue
			{
				Type = this.Type,
				Routes = this.Routes
			};
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x000587C1 File Offset: 0x000569C1
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x000587EC File Offset: 0x000569EC
		public override EPasserbyNpcMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x000587FC File Offset: 0x000569FC
		// (set) Token: 0x06001F95 RID: 8085 RVA: 0x0005888F File Offset: 0x00056A8F
		public virtual List<IPasserbyNpcSpline> Routes
		{
			get
			{
				if (this._RoutesInited)
				{
					return this._RoutesCache;
				}
				this._RoutesInited = true;
				if (this.FbInstance != null)
				{
					List<IPasserbyNpcSpline> routes = this.FbInstance.Routes;
					if (routes != null)
					{
						this._RoutesCache = new List<IPasserbyNpcSpline>(routes.Count);
						for (int i = 0; i < routes.Count; i++)
						{
							this._RoutesCache.Add(IPasserbyNpcSpline.Create(routes[i]));
						}
					}
				}
				else
				{
					IPasserbyNpcSplineMove_SetValue pocoInterface = this.PocoInterface;
					this._RoutesCache = ((pocoInterface != null) ? pocoInterface.Routes : null);
				}
				return this._RoutesCache;
			}
			set
			{
				this.GetOrCreatePoco().Routes = value;
				this._RoutesInited = false;
			}
		}

		// Token: 0x04001647 RID: 5703
		[Nullable(2)]
		protected new IPasserbyNpcSplineMove FbInstance;

		// Token: 0x04001648 RID: 5704
		[Nullable(2)]
		protected new IPasserbyNpcSplineMove_SetValue PocoInterface;

		// Token: 0x04001649 RID: 5705
		private List<IPasserbyNpcSpline> _RoutesCache;

		// Token: 0x0400164A RID: 5706
		private bool _RoutesInited;
	}
}
