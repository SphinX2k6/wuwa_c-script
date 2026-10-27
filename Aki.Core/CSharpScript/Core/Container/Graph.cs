using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000152 RID: 338
	[NullableContext(1)]
	[Nullable(0)]
	public class Graph<[Nullable(2)] TVec>
	{
		// Token: 0x06000BB0 RID: 2992 RVA: 0x00037B08 File Offset: 0x00035D08
		public Graph(IGraphSpace<TVec> Space, bool Directed = false)
		{
			this.Space = Space;
			this.Directed = Directed;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00037B34 File Offset: 0x00035D34
		public bool IsDirected
		{
			get
			{
				return this.Directed;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00037B3C File Offset: 0x00035D3C
		public int NodeCount
		{
			get
			{
				return this.NodeMap.Count;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00037B49 File Offset: 0x00035D49
		public int EdgeCount
		{
			get
			{
				return this.EdgeList.Count;
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00037B58 File Offset: 0x00035D58
		public void AddNode(int id, TVec location)
		{
			if (this.NodeMap.ContainsKey(id))
			{
				return;
			}
			this.NodeMap[id] = new GraphRuntimeNode<TVec>
			{
				Id = id,
				Location = location,
				OutNeighbors = new HashSet<int>(),
				Neighbors = new HashSet<int>()
			};
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00037BAC File Offset: 0x00035DAC
		public void AddEdge(int id, int from, int to)
		{
			IGraphRuntimeNode<TVec> graphRuntimeNode;
			bool flag = this.NodeMap.TryGetValue(from, out graphRuntimeNode);
			IGraphRuntimeNode<TVec> graphRuntimeNode2;
			bool flag2 = this.NodeMap.TryGetValue(to, out graphRuntimeNode2);
			if (!flag || !flag2 || from == to)
			{
				return;
			}
			this.EdgeList.Add(new GraphRuntimeEdge
			{
				Id = id,
				From = from,
				To = to
			});
			graphRuntimeNode.OutNeighbors.Add(to);
			graphRuntimeNode.Neighbors.Add(to);
			graphRuntimeNode2.Neighbors.Add(from);
			if (!this.Directed)
			{
				graphRuntimeNode2.OutNeighbors.Add(from);
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00037C41 File Offset: 0x00035E41
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IGraphRuntimeNode<TVec> GetNode(int id)
		{
			return this.NodeMap.GetValueOrDefault(id);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00037C50 File Offset: 0x00035E50
		[NullableContext(2)]
		public TVec GetNodeLocation(int id)
		{
			IGraphRuntimeNode<TVec> graphRuntimeNode;
			if (!this.NodeMap.TryGetValue(id, out graphRuntimeNode))
			{
				return default(TVec);
			}
			return graphRuntimeNode.Location;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00037C80 File Offset: 0x00035E80
		public List<int> GetNeighborNodeIds(int id)
		{
			IGraphRuntimeNode<TVec> graphRuntimeNode;
			if (!this.NodeMap.TryGetValue(id, out graphRuntimeNode))
			{
				return new List<int>();
			}
			return new List<int>(this.Directed ? graphRuntimeNode.OutNeighbors : graphRuntimeNode.Neighbors);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00037CC0 File Offset: 0x00035EC0
		public bool HasEdge(int from, int to)
		{
			IGraphRuntimeNode<TVec> graphRuntimeNode;
			if (!this.NodeMap.TryGetValue(from, out graphRuntimeNode))
			{
				return false;
			}
			if (!this.Directed)
			{
				return graphRuntimeNode.Neighbors.Contains(to);
			}
			return graphRuntimeNode.OutNeighbors.Contains(to);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00037D00 File Offset: 0x00035F00
		public int? GetNodeIdAtLocation(TVec location, double radius)
		{
			double num = radius * radius;
			int? result = null;
			double num2 = num;
			foreach (IGraphRuntimeNode<TVec> graphRuntimeNode in this.NodeMap.Values)
			{
				double num3 = this.Space.DistSquared(location, graphRuntimeNode.Location);
				if (num3 <= num2)
				{
					num2 = num3;
					result = new int?(graphRuntimeNode.Id);
				}
			}
			return result;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00037D88 File Offset: 0x00035F88
		public int? GetNearestNodeId(TVec location)
		{
			int? result = null;
			double num = double.MaxValue;
			foreach (IGraphRuntimeNode<TVec> graphRuntimeNode in this.NodeMap.Values)
			{
				double num2 = this.Space.DistSquared(location, graphRuntimeNode.Location);
				if (num2 < num)
				{
					num = num2;
					result = new int?(graphRuntimeNode.Id);
				}
			}
			return result;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00037E14 File Offset: 0x00036014
		public double? GetNearestNodeDistSquared(TVec location)
		{
			int? nearestNodeId = this.GetNearestNodeId(location);
			if (nearestNodeId == null)
			{
				return null;
			}
			return new double?(this.Space.DistSquared(location, this.NodeMap[nearestNodeId.Value].Location));
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00037E64 File Offset: 0x00036064
		[NullableContext(0)]
		public ValueTuple<int, int>? GetCurrentEdge([Nullable(1)] TVec location)
		{
			ValueTuple<int, int>? result = null;
			double num = double.MaxValue;
			foreach (IGraphRuntimeEdge graphRuntimeEdge in this.EdgeList)
			{
				IGraphRuntimeNode<TVec> graphRuntimeNode;
				TVec tvec = this.NodeMap.TryGetValue(graphRuntimeEdge.From, out graphRuntimeNode) ? graphRuntimeNode.Location : default(TVec);
				IGraphRuntimeNode<TVec> graphRuntimeNode2;
				TVec tvec2 = this.NodeMap.TryGetValue(graphRuntimeEdge.To, out graphRuntimeNode2) ? graphRuntimeNode2.Location : default(TVec);
				if (tvec != null && tvec2 != null)
				{
					double num2 = this.Space.DistSquaredPointToSegment(location, tvec, tvec2);
					if (num2 < num)
					{
						num = num2;
						result = new ValueTuple<int, int>?(new ValueTuple<int, int>(graphRuntimeEdge.From, graphRuntimeEdge.To));
					}
				}
			}
			return result;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00037F60 File Offset: 0x00036160
		public HashSet<int> CollectConnectedNodeIds(int startId)
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (!this.NodeMap.ContainsKey(startId))
			{
				return hashSet;
			}
			List<int> list = new List<int>
			{
				startId
			};
			hashSet.Add(startId);
			while (list.Count > 0)
			{
				int key = list[0];
				list.RemoveAt(0);
				IGraphRuntimeNode<TVec> graphRuntimeNode;
				if (this.NodeMap.TryGetValue(key, out graphRuntimeNode))
				{
					foreach (int item in (this.Directed ? graphRuntimeNode.OutNeighbors : graphRuntimeNode.Neighbors))
					{
						if (!hashSet.Contains(item))
						{
							hashSet.Add(item);
							list.Add(item);
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00038034 File Offset: 0x00036234
		public bool IsFullyConnected()
		{
			if (this.NodeMap.Count == 0)
			{
				return true;
			}
			int startId = this.NodeMap.Keys.First<int>();
			return this.CollectConnectedNodeIds(startId).Count == this.NodeMap.Count;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0003807A File Offset: 0x0003627A
		public IEnumerable<IGraphRuntimeNode<TVec>> GetAllNodes()
		{
			Graph<TVec>.<GetAllNodes>d__23 <GetAllNodes>d__ = new Graph<TVec>.<GetAllNodes>d__23(-2);
			<GetAllNodes>d__.<>4__this = this;
			return <GetAllNodes>d__;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0003808A File Offset: 0x0003628A
		public IReadOnlyList<IGraphRuntimeEdge> GetAllEdges()
		{
			return this.EdgeList;
		}

		// Token: 0x040006F0 RID: 1776
		private readonly Dictionary<int, IGraphRuntimeNode<TVec>> NodeMap = new Dictionary<int, IGraphRuntimeNode<TVec>>();

		// Token: 0x040006F1 RID: 1777
		private readonly List<IGraphRuntimeEdge> EdgeList = new List<IGraphRuntimeEdge>();

		// Token: 0x040006F2 RID: 1778
		private readonly IGraphSpace<TVec> Space;

		// Token: 0x040006F3 RID: 1779
		private readonly bool Directed;
	}
}
