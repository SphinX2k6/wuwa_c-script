using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000433 RID: 1075
	public class IGraph3dBase
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x00043C68 File Offset: 0x00041E68
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

		// Token: 0x0600156A RID: 5482 RVA: 0x00043CA0 File Offset: 0x00041EA0
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

		// Token: 0x0600156B RID: 5483 RVA: 0x00043CB3 File Offset: 0x00041EB3
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

		// Token: 0x0600156C RID: 5484 RVA: 0x00043CC6 File Offset: 0x00041EC6
		public IGraph3dBase_SetValue ToSetValue()
		{
			return new IGraph3dBase_SetValue
			{
				Type = this.Type,
				Nodes = this.Nodes,
				Edges = this.Edges
			};
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00043CF1 File Offset: 0x00041EF1
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00043D1C File Offset: 0x00041F1C
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00043D2C File Offset: 0x00041F2C
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00043DBF File Offset: 0x00041FBF
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

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00043DD4 File Offset: 0x00041FD4
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00043E67 File Offset: 0x00042067
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

		// Token: 0x040010D7 RID: 4311
		[Nullable(2)]
		protected IGraph3dBase FbInstance;

		// Token: 0x040010D8 RID: 4312
		[Nullable(2)]
		protected IGraph3dBase_SetValue PocoInterface;

		// Token: 0x040010D9 RID: 4313
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x040010DA RID: 4314
		private bool _NodesInited;

		// Token: 0x040010DB RID: 4315
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x040010DC RID: 4316
		private bool _EdgesInited;
	}
}
