using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001183 RID: 4483
	public class IPlotHandBookItem
	{
		// Token: 0x0600639E RID: 25502 RVA: 0x000EFAD4 File Offset: 0x000EDCD4
		private IPlotHandBookItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotHandBookItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotHandBookItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotHandBookItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x000EFB0C File Offset: 0x000EDD0C
		public static IPlotHandBookItem Create([Nullable(2)] IPlotHandBookItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotHandBookItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x000EFB1F File Offset: 0x000EDD1F
		public static IPlotHandBookItem CreateFromSetValue([Nullable(2)] IPlotHandBookItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotHandBookItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x000EFB32 File Offset: 0x000EDD32
		public IPlotHandBookItem_SetValue ToSetValue()
		{
			return new IPlotHandBookItem_SetValue
			{
				Id = this.Id,
				Nodes = this.Nodes
			};
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x060063A2 RID: 25506 RVA: 0x000EFB51 File Offset: 0x000EDD51
		// (set) Token: 0x060063A3 RID: 25507 RVA: 0x000EFB7C File Offset: 0x000EDD7C
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x060063A4 RID: 25508 RVA: 0x000EFB8C File Offset: 0x000EDD8C
		// (set) Token: 0x060063A5 RID: 25509 RVA: 0x000EFC1F File Offset: 0x000EDE1F
		public virtual List<IPlotHandBookNode> Nodes
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
					List<IPlotHandBookNode> nodes = this.FbInstance.Nodes;
					if (nodes != null)
					{
						this._NodesCache = new List<IPlotHandBookNode>(nodes.Count);
						for (int i = 0; i < nodes.Count; i++)
						{
							this._NodesCache.Add(IPlotHandBookNode.Create(nodes[i]));
						}
					}
				}
				else
				{
					IPlotHandBookItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003BAD RID: 15277
		[Nullable(2)]
		protected IPlotHandBookItem FbInstance;

		// Token: 0x04003BAE RID: 15278
		[Nullable(2)]
		protected IPlotHandBookItem_SetValue PocoInterface;

		// Token: 0x04003BAF RID: 15279
		private List<IPlotHandBookNode> _NodesCache;

		// Token: 0x04003BB0 RID: 15280
		private bool _NodesInited;
	}
}
