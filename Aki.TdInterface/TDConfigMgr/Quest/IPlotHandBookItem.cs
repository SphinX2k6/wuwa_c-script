using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001055 RID: 4181
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotHandBookItem
	{
		// Token: 0x06005DAC RID: 23980 RVA: 0x000E2B00 File Offset: 0x000E0D00
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

		// Token: 0x06005DAD RID: 23981 RVA: 0x000E2B38 File Offset: 0x000E0D38
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

		// Token: 0x06005DAE RID: 23982 RVA: 0x000E2B4B File Offset: 0x000E0D4B
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

		// Token: 0x06005DAF RID: 23983 RVA: 0x000E2B5E File Offset: 0x000E0D5E
		public IPlotHandBookItem_SetValue ToSetValue()
		{
			return new IPlotHandBookItem_SetValue
			{
				Id = this.Id,
				Nodes = this.Nodes
			};
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06005DB0 RID: 23984 RVA: 0x000E2B7D File Offset: 0x000E0D7D
		// (set) Token: 0x06005DB1 RID: 23985 RVA: 0x000E2BA8 File Offset: 0x000E0DA8
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

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06005DB2 RID: 23986 RVA: 0x000E2BB8 File Offset: 0x000E0DB8
		// (set) Token: 0x06005DB3 RID: 23987 RVA: 0x000E2C4B File Offset: 0x000E0E4B
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

		// Token: 0x04003865 RID: 14437
		[Nullable(2)]
		protected IPlotHandBookItem FbInstance;

		// Token: 0x04003866 RID: 14438
		[Nullable(2)]
		protected IPlotHandBookItem_SetValue PocoInterface;

		// Token: 0x04003867 RID: 14439
		private List<IPlotHandBookNode> _NodesCache;

		// Token: 0x04003868 RID: 14440
		private bool _NodesInited;
	}
}
