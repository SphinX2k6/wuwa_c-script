using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001464 RID: 5220
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotHandBookItem
	{
		// Token: 0x060076CD RID: 30413 RVA: 0x0011BFA7 File Offset: 0x0011A1A7
		public static IPlotHandBookItem Create(IPlotHandBookItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotHandBookItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x060076CE RID: 30414 RVA: 0x0011BFC6 File Offset: 0x0011A1C6
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x060076CF RID: 30415 RVA: 0x0011BFD4 File Offset: 0x0011A1D4
		public virtual List<IPlotHandBookNode> Nodes
		{
			get
			{
				if (this._NodesInited)
				{
					return this._NodesCache;
				}
				this._NodesInited = true;
				int nodesLength = this.Instance.NodesLength;
				this._NodesCache = new List<IPlotHandBookNode>(nodesLength);
				for (int i = 0; i < nodesLength; i++)
				{
					this._NodesCache.Add(IPlotHandBookNode.Create(this.Instance.Nodes(i)));
				}
				return this._NodesCache;
			}
		}

		// Token: 0x0400450E RID: 17678
		private IPlotHandBookItem Instance;

		// Token: 0x0400450F RID: 17679
		private List<IPlotHandBookNode> _NodesCache;

		// Token: 0x04004510 RID: 17680
		private bool _NodesInited;
	}
}
