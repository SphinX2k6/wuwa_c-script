using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F3E RID: 3902
	public class IGraph3dNormal : IGraph3dBase
	{
		// Token: 0x0600579E RID: 22430 RVA: 0x000D68E7 File Offset: 0x000D4AE7
		public static IGraph3dNormal Create(IGraph3dNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x000D6906 File Offset: 0x000D4B06
		public override EGraph3dType Type
		{
			get
			{
				return (EGraph3dType)this.Instance.Type;
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x060057A0 RID: 22432 RVA: 0x000D6914 File Offset: 0x000D4B14
		public override List<IGraph3dNodeBase> Nodes
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

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x000D6980 File Offset: 0x000D4B80
		public override List<IGraph3dEdgeBase> Edges
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

		// Token: 0x0400324F RID: 12879
		private IGraph3dNormal Instance;

		// Token: 0x04003250 RID: 12880
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x04003251 RID: 12881
		private bool _NodesInited;

		// Token: 0x04003252 RID: 12882
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x04003253 RID: 12883
		private bool _EdgesInited;
	}
}
