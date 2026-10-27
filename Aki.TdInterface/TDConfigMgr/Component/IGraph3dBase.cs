using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003DA RID: 986
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dBase
	{
		// Token: 0x060013CF RID: 5071 RVA: 0x0003FF20 File Offset: 0x0003E120
		private IGraph3dBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGraph3dBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGraph3dBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGraph3dBase_SetValue());
			}
			return result;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0003FF58 File Offset: 0x0003E158
		public static IGraph3dBase Create([Nullable(2)] IGraph3dBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0003FF6B File Offset: 0x0003E16B
		public static IGraph3dBase CreateFromSetValue([Nullable(2)] IGraph3dBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGraph3dBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0003FF7E File Offset: 0x0003E17E
		public IGraph3dBase_SetValue ToSetValue()
		{
			return new IGraph3dBase_SetValue
			{
				Type = this.Type,
				Nodes = this.Nodes,
				Edges = this.Edges
			};
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0003FFA9 File Offset: 0x0003E1A9
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		public virtual EGraph3dType Type
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0003FFE4 File Offset: 0x0003E1E4
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x00040077 File Offset: 0x0003E277
		public virtual List<IGraph3dNodeBase> Nodes
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
					IGraph3dBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0004008C File Offset: 0x0003E28C
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0004011F File Offset: 0x0003E31F
		public virtual List<IGraph3dEdgeBase> Edges
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
					IGraph3dBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000FB5 RID: 4021
		[Nullable(2)]
		protected IGraph3dBase FbInstance;

		// Token: 0x04000FB6 RID: 4022
		[Nullable(2)]
		protected IGraph3dBase_SetValue PocoInterface;

		// Token: 0x04000FB7 RID: 4023
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x04000FB8 RID: 4024
		private bool _NodesInited;

		// Token: 0x04000FB9 RID: 4025
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x04000FBA RID: 4026
		private bool _EdgesInited;
	}
}
