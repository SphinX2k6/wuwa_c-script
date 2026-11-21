using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000156 RID: 342
	[NullableContext(1)]
	[Nullable(0)]
	public class Graph<[Nullable(2)] TVec>
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x000386D8 File Offset: 0x000368D8
		public Graph(IGraphSpace<TVec> Space, bool Directed = false)
		{
			this.Space = Space;
			this.Directed = Directed;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00038704 File Offset: 0x00036904
		public bool IsDirected
		{
			get
			{
				return this.Directed;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003870C File Offset: 0x0003690C
		public int NodeCount
		{
			get
			{
				return this.NodeMap.Count;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00038719 File Offset: 0x00036919
		public int EdgeCount
		{
			get
			{
				return this.EdgeList.Count;
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00038728 File Offset: 0x00036928
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

		// Token: 0x06000C11 RID: 3089 RVA: 0x0003877C File Offset: 0x0003697C
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

		// Token: 0x06000C12 RID: 3090 RVA: 0x00038811 File Offset: 0x00036A11
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IGraphRuntimeNode<TVec> GetNode(int id)
		{
			return this.NodeMap.GetValueOrDefault(id);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00038820 File Offset: 0x00036A20
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

		// Token: 0x06000C14 RID: 3092 RVA: 0x00038850 File Offset: 0x00036A50
		public List<int> GetNeighborNodeIds(int id)
		{
			IGraphRuntimeNode<TVec> graphRuntimeNode;
			if (!this.NodeMap.TryGetValue(id, out graphRuntimeNode))
			{
				return new List<int>();
			}
			return new List<int>(this.Directed ? graphRuntimeNode.OutNeighbors : graphRuntimeNode.Neighbors);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00038890 File Offset: 0x00036A90
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

		// Token: 0x06000C16 RID: 3094 RVA: 0x000388D0 File Offset: 0x00036AD0
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

		// Token: 0x06000C17 RID: 3095 RVA: 0x00038958 File Offset: 0x00036B58
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

		// Token: 0x06000C18 RID: 3096 RVA: 0x000389E4 File Offset: 0x00036BE4
		public double? GetNearestNodeDistSquared(TVec location)
		{
			int? nearestNodeId = this.GetNearestNodeId(location);
			if (nearestNodeId == null)
			{
				return null;
			}
			return new double?(this.Space.DistSquared(location, this.NodeMap[nearestNodeId.Value].Location));
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00038A34 File Offset: 0x00036C34
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

		// Token: 0x06000C1A RID: 3098 RVA: 0x00038B30 File Offset: 0x00036D30
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

		// Token: 0x06000C1B RID: 3099 RVA: 0x00038C04 File Offset: 0x00036E04
		public bool IsFullyConnected()
		{
			if (this.NodeMap.Count == 0)
			{
				return true;
			}
			int startId = 0;
			using (Dictionary<int, IGraphRuntimeNode<TVec>>.KeyCollection.Enumerator enumerator = this.NodeMap.Keys.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					startId = enumerator.Current;
				}
			}
			return this.CollectConnectedNodeIds(startId).Count == this.NodeMap.Count;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00038C84 File Offset: 0x00036E84
		public IEnumerable<IGraphRuntimeNode<TVec>> GetAllNodes()
		{
			Graph<TVec>.<GetAllNodes>d__23 <GetAllNodes>d__ = new Graph<TVec>.<GetAllNodes>d__23(-2);
			<GetAllNodes>d__.<>4__this = this;
			return <GetAllNodes>d__;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00038C94 File Offset: 0x00036E94
		public IReadOnlyList<IGraphRuntimeEdge> GetAllEdges()
		{
			return this.EdgeList;
		}

		// Token: 0x040006FE RID: 1790
		private readonly Dictionary<int, IGraphRuntimeNode<TVec>> NodeMap = new Dictionary<int, IGraphRuntimeNode<TVec>>();

		// Token: 0x040006FF RID: 1791
		private readonly List<IGraphRuntimeEdge> EdgeList = new List<IGraphRuntimeEdge>();

		// Token: 0x04000700 RID: 1792
		private readonly IGraphSpace<TVec> Space;

		// Token: 0x04000701 RID: 1793
		private readonly bool Directed;
	}
}
