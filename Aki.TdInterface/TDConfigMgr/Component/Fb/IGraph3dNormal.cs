using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E42 RID: 3650
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dNormal : IGraph3dBase
	{
		// Token: 0x06005277 RID: 21111 RVA: 0x000CB01F File Offset: 0x000C921F
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

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x000CB03E File Offset: 0x000C923E
		public override EGraph3dType Type
		{
			get
			{
				return (EGraph3dType)this.Instance.Type;
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x000CB04C File Offset: 0x000C924C
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

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x000CB0B8 File Offset: 0x000C92B8
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

		// Token: 0x04002F87 RID: 12167
		private IGraph3dNormal Instance;

		// Token: 0x04002F88 RID: 12168
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x04002F89 RID: 12169
		private bool _NodesInited;

		// Token: 0x04002F8A RID: 12170
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x04002F8B RID: 12171
		private bool _EdgesInited;
	}
}
