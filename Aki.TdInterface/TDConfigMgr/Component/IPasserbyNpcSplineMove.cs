using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000661 RID: 1633
	public class IPasserbyNpcSplineMove : IPasserbyNpcMoveBase
	{
		// Token: 0x06002250 RID: 8784 RVA: 0x0005EC90 File Offset: 0x0005CE90
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

		// Token: 0x06002251 RID: 8785 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
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

		// Token: 0x06002252 RID: 8786 RVA: 0x0005ECDB File Offset: 0x0005CEDB
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

		// Token: 0x06002253 RID: 8787 RVA: 0x0005ECEE File Offset: 0x0005CEEE
		public new IPasserbyNpcSplineMove_SetValue ToSetValue()
		{
			return new IPasserbyNpcSplineMove_SetValue
			{
				Type = this.Type,
				Routes = this.Routes
			};
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x0005ED0D File Offset: 0x0005CF0D
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x0005ED38 File Offset: 0x0005CF38
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

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x0005ED48 File Offset: 0x0005CF48
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x0005EDDB File Offset: 0x0005CFDB
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

		// Token: 0x04001818 RID: 6168
		[Nullable(2)]
		protected new IPasserbyNpcSplineMove FbInstance;

		// Token: 0x04001819 RID: 6169
		[Nullable(2)]
		protected new IPasserbyNpcSplineMove_SetValue PocoInterface;

		// Token: 0x0400181A RID: 6170
		private List<IPasserbyNpcSpline> _RoutesCache;

		// Token: 0x0400181B RID: 6171
		private bool _RoutesInited;
	}
}
