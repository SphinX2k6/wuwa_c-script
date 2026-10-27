using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD4 RID: 3284
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcSplineMove : IPasserbyNpcMoveBase
	{
		// Token: 0x06004B16 RID: 19222 RVA: 0x000BBC0A File Offset: 0x000B9E0A
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

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x000BBC29 File Offset: 0x000B9E29
		public override EPasserbyNpcMoveType Type
		{
			get
			{
				return (EPasserbyNpcMoveType)this.Instance.Type;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x000BBC38 File Offset: 0x000B9E38
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

		// Token: 0x04002AF5 RID: 10997
		private IPasserbyNpcSplineMove Instance;

		// Token: 0x04002AF6 RID: 10998
		private List<IPasserbyNpcSpline> _RoutesCache;

		// Token: 0x04002AF7 RID: 10999
		private bool _RoutesInited;
	}
}
