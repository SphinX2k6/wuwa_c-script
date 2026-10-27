using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3F RID: 3647
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dBase
	{
		// Token: 0x06005269 RID: 21097 RVA: 0x000CAE5F File Offset: 0x000C905F
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

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x0600526A RID: 21098 RVA: 0x000CAE7E File Offset: 0x000C907E
		public virtual EGraph3dType Type
		{
			get
			{
				return (EGraph3dType)this.Instance.Type;
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600526B RID: 21099 RVA: 0x000CAE8C File Offset: 0x000C908C
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

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x000CAEF8 File Offset: 0x000C90F8
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

		// Token: 0x04002F7E RID: 12158
		private IGraph3dBase Instance;

		// Token: 0x04002F7F RID: 12159
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x04002F80 RID: 12160
		private bool _NodesInited;

		// Token: 0x04002F81 RID: 12161
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x04002F82 RID: 12162
		private bool _EdgesInited;
	}
}
