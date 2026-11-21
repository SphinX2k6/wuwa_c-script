using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015BD RID: 5565
	public class IPlotHandBookItem
	{
		// Token: 0x06007D9B RID: 32155 RVA: 0x0012ABBF File Offset: 0x00128DBF
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

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06007D9C RID: 32156 RVA: 0x0012ABDE File Offset: 0x00128DDE
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0012ABEC File Offset: 0x00128DEC
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

		// Token: 0x040048A9 RID: 18601
		private IPlotHandBookItem Instance;

		// Token: 0x040048AA RID: 18602
		private List<IPlotHandBookNode> _NodesCache;

		// Token: 0x040048AB RID: 18603
		private bool _NodesInited;
	}
}
