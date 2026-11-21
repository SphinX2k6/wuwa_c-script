using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB8 RID: 3512
	public class IPasserbyNpcSplineMove : IPasserbyNpcMoveBase
	{
		// Token: 0x06004FD1 RID: 20433 RVA: 0x000C6842 File Offset: 0x000C4A42
		public static IPasserbyNpcSplineMove Create(IPasserbyNpcSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x000C6861 File Offset: 0x000C4A61
		public override EPasserbyNpcMoveType Type
		{
			get
			{
				return (EPasserbyNpcMoveType)this.Instance.Type;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x000C6870 File Offset: 0x000C4A70
		public virtual List<IPasserbyNpcSpline> Routes
		{
			get
			{
				if (this._RoutesInited)
				{
					return this._RoutesCache;
				}
				this._RoutesInited = true;
				int routesLength = this.Instance.RoutesLength;
				this._RoutesCache = new List<IPasserbyNpcSpline>(routesLength);
				for (int i = 0; i < routesLength; i++)
				{
					this._RoutesCache.Add(IPasserbyNpcSpline.Create(this.Instance.Routes(i)));
				}
				return this._RoutesCache;
			}
		}

		// Token: 0x04002D7B RID: 11643
		private IPasserbyNpcSplineMove Instance;

		// Token: 0x04002D7C RID: 11644
		private List<IPasserbyNpcSpline> _RoutesCache;

		// Token: 0x04002D7D RID: 11645
		private bool _RoutesInited;
	}
}
