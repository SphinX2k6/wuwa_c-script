using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200043F RID: 1087
	public class IGraph3dNormal : IGraph3dBase
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x00044450 File Offset: 0x00042650
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

		// Token: 0x060015AA RID: 5546 RVA: 0x00044488 File Offset: 0x00042688
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

		// Token: 0x060015AB RID: 5547 RVA: 0x0004449B File Offset: 0x0004269B
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

		// Token: 0x060015AC RID: 5548 RVA: 0x000444AE File Offset: 0x000426AE
		public new IGraph3dNormal_SetValue ToSetValue()
		{
			return new IGraph3dNormal_SetValue
			{
				Type = this.Type,
				Nodes = this.Nodes,
				Edges = this.Edges
			};
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000444D9 File Offset: 0x000426D9
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x00044504 File Offset: 0x00042704
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

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00044514 File Offset: 0x00042714
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x000445A7 File Offset: 0x000427A7
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000445BC File Offset: 0x000427BC
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x0004464F File Offset: 0x0004284F
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

		// Token: 0x040010F9 RID: 4345
		[Nullable(2)]
		protected new IGraph3dNormal FbInstance;

		// Token: 0x040010FA RID: 4346
		[Nullable(2)]
		protected new IGraph3dNormal_SetValue PocoInterface;

		// Token: 0x040010FB RID: 4347
		private List<IGraph3dNodeBase> _NodesCache;

		// Token: 0x040010FC RID: 4348
		private bool _NodesInited;

		// Token: 0x040010FD RID: 4349
		private List<IGraph3dEdgeBase> _EdgesCache;

		// Token: 0x040010FE RID: 4350
		private bool _EdgesInited;
	}
}
