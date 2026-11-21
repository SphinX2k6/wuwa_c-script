using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F3B RID: 3899
	public class IGraph3dBase
	{
		// Token: 0x06005790 RID: 22416 RVA: 0x000D6727 File Offset: 0x000D4927
		public static IGraph3dBase Create(IGraph3dBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x000D6746 File Offset: 0x000D4946
		public virtual EGraph3dType Type
		{
			get
			{
				return (EGraph3dType)this.Instance.Type;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06005792 RID: 22418 RVA: 0x000D6754 File Offset: 0x000D4954
		public virtual List<IGraph3dNodeBase> Nodes
		{
			get
			{
				if (this._NodesInited)
				{
					return this._NodesCache;
				}
				this._NodesInited = true;
				int nodesLength = this.Instance.NodesLength;
				this._NodesCache = new List<IGraph3dNodeBase>(nodesLength);
				for (int i = 0; i < nodesLength; i++)
				{
					this._NodesCache.Add(IGraph3dNodeBase.Create(this.Instance.Nodes(i)));
				}
				return this._NodesCache;
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06005793 RID: 22419 RVA: 0x000D67C0 File Offset: 0x000D49C0
		public virtual List<IGraph3dEdgeBase> Edges
		{
			get
			{
				if (this._EdgesInited)
				{
					return this._EdgesCache;
				}
				this._EdgesInited = true;
				int edgesLength = this.Instance.EdgesLength;
				this._EdgesCache = new List<IGraph3dEdgeBase>(edgesLength);
				for (int i = 0; i < edgesLength; i++)
				{
					this._EdgesCache.Add(IGraph3dEdgeBase.Create(this.Instance.Edges(i)));
				}
				return this._EdgesCache;
			}
		}

		// Token: 0x04003246 RID: 12870
		private IGraph3dBase Instance;

		// Token: 0x04003247 RID: 12871
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x04003248 RID: 12872
		private bool _NodesInited;

		// Token: 0x04003249 RID: 12873
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x0400324A RID: 12874
		private bool _EdgesInited;
	}
}
