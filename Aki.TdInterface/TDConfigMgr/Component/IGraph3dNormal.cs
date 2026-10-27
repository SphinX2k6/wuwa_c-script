using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E6 RID: 998
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dNormal : IGraph3dBase
	{
		// Token: 0x0600140F RID: 5135 RVA: 0x00040708 File Offset: 0x0003E908
		private IGraph3dNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGraph3dNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGraph3dNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGraph3dNormal_SetValue());
			}
			return result;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00040740 File Offset: 0x0003E940
		public static IGraph3dNormal Create([Nullable(2)] IGraph3dNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00040753 File Offset: 0x0003E953
		public static IGraph3dNormal CreateFromSetValue([Nullable(2)] IGraph3dNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGraph3dNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00040766 File Offset: 0x0003E966
		public new IGraph3dNormal_SetValue ToSetValue()
		{
			return new IGraph3dNormal_SetValue
			{
				Type = this.Type,
				Nodes = this.Nodes,
				Edges = this.Edges
			};
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00040791 File Offset: 0x0003E991
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x000407BC File Offset: 0x0003E9BC
		public override EGraph3dType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGraph3dType.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000407CC File Offset: 0x0003E9CC
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0004085F File Offset: 0x0003EA5F
		public override List<IGraph3dNodeBase> Nodes
		{
			get
			{
				if (this._NodesInited)
				{
					return this._NodesCache;
				}
				this._NodesInited = true;
				if (this.FbInstance != null)
				{
					List<IGraph3dNodeBase> nodes = this.FbInstance.Nodes;
					if (nodes != null)
					{
						this._NodesCache = new List<IGraph3dNodeBase>(nodes.Count);
						for (int i = 0; i < nodes.Count; i++)
						{
							this._NodesCache.Add(IGraph3dNodeBase.Create(nodes[i]));
						}
					}
				}
				else
				{
					IGraph3dNormal_SetValue pocoInterface = this.PocoInterface;
					this._NodesCache = ((pocoInterface != null) ? pocoInterface.Nodes : null);
				}
				return this._NodesCache;
			}
			set
			{
				this.GetOrCreatePoco().Nodes = value;
				this._NodesInited = false;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00040874 File Offset: 0x0003EA74
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00040907 File Offset: 0x0003EB07
		public override List<IGraph3dEdgeBase> Edges
		{
			get
			{
				if (this._EdgesInited)
				{
					return this._EdgesCache;
				}
				this._EdgesInited = true;
				if (this.FbInstance != null)
				{
					List<IGraph3dEdgeBase> edges = this.FbInstance.Edges;
					if (edges != null)
					{
						this._EdgesCache = new List<IGraph3dEdgeBase>(edges.Count);
						for (int i = 0; i < edges.Count; i++)
						{
							this._EdgesCache.Add(IGraph3dEdgeBase.Create(edges[i]));
						}
					}
				}
				else
				{
					IGraph3dNormal_SetValue pocoInterface = this.PocoInterface;
					this._EdgesCache = ((pocoInterface != null) ? pocoInterface.Edges : null);
				}
				return this._EdgesCache;
			}
			set
			{
				this.GetOrCreatePoco().Edges = value;
				this._EdgesInited = false;
			}
		}

		// Token: 0x04000FD7 RID: 4055
		[Nullable(2)]
		protected new IGraph3dNormal FbInstance;

		// Token: 0x04000FD8 RID: 4056
		[Nullable(2)]
		protected new IGraph3dNormal_SetValue PocoInterface;

		// Token: 0x04000FD9 RID: 4057
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x04000FDA RID: 4058
		private bool _NodesInited;

		// Token: 0x04000FDB RID: 4059
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x04000FDC RID: 4060
		private bool _EdgesInited;
	}
}
