using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015F RID: 351
	[NullableContext(1)]
	[Nullable(0)]
	public class GraphEulerStroke
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x00038204 File Offset: 0x00036404
		public static IEulerStrokeJudge Judge<[Nullable(2)] TVec>(Graph<TVec> graph)
		{
			IAdjacency adjacency = GraphEulerStroke.BuildAdjacency<TVec>(graph);
			int? suggestedStartId = null;
			foreach (int num in adjacency.NodeIds)
			{
				int num2;
				if ((adjacency.Degree.TryGetValue(num, out num2) ? num2 : 0) > 0)
				{
					suggestedStartId = new int?(num);
					break;
				}
			}
			if (suggestedStartId == null)
			{
				return new EulerStrokeJudge
				{
					Kind = EEulerStrokeKind.Circuit,
					CanDrawInOneStroke = true,
					Connected = true,
					OddNodeIds = new List<int>(),
					SuggestedStartId = null
				};
			}
			bool flag = GraphEulerStroke.IsEdgeConnected(suggestedStartId.Value, adjacency.Adj, adjacency.Degree);
			List<int> list = new List<int>();
			foreach (int num3 in adjacency.NodeIds)
			{
				int num4;
				if ((adjacency.Degree.TryGetValue(num3, out num4) ? num4 : 0) % 2 == 1)
				{
					list.Add(num3);
				}
			}
			if (!flag)
			{
				return new EulerStrokeJudge
				{
					Kind = EEulerStrokeKind.None,
					CanDrawInOneStroke = false,
					Connected = false,
					OddNodeIds = list,
					SuggestedStartId = suggestedStartId
				};
			}
			if (list.Count == 0)
			{
				return new EulerStrokeJudge
				{
					Kind = EEulerStrokeKind.Circuit,
					CanDrawInOneStroke = true,
					Connected = true,
					OddNodeIds = list,
					SuggestedStartId = suggestedStartId
				};
			}
			if (list.Count == 2)
			{
				return new EulerStrokeJudge
				{
					Kind = EEulerStrokeKind.Path,
					CanDrawInOneStroke = true,
					Connected = true,
					OddNodeIds = list,
					SuggestedStartId = new int?(list[0])
				};
			}
			return new EulerStrokeJudge
			{
				Kind = EEulerStrokeKind.None,
				CanDrawInOneStroke = false,
				Connected = true,
				OddNodeIds = list,
				SuggestedStartId = suggestedStartId
			};
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00038404 File Offset: 0x00036604
		[NullableContext(2)]
		public static List<int> TryGetSingleStroke<TVec>([Nullable(1)] Graph<TVec> graph)
		{
			IEulerStrokeJudge eulerStrokeJudge = GraphEulerStroke.Judge<TVec>(graph);
			if (!eulerStrokeJudge.CanDrawInOneStroke)
			{
				return null;
			}
			if (eulerStrokeJudge.SuggestedStartId == null)
			{
				return new List<int>();
			}
			IAdjacency adjacency = GraphEulerStroke.BuildAdjacency<TVec>(graph);
			int edgeCount = graph.EdgeCount;
			List<ISequence> list = GraphEulerStroke.Hierholzer(eulerStrokeJudge.SuggestedStartId.Value, adjacency.Adj, edgeCount);
			List<int> list2 = new List<int>();
			foreach (ISequence sequence in list)
			{
				list2.Add(sequence.Node);
			}
			return list2;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000384B4 File Offset: 0x000366B4
		public static List<List<int>> DecomposeToStrokes<[Nullable(2)] TVec>(Graph<TVec> graph)
		{
			List<IComponent> list = GraphEulerStroke.SplitEdgeConnectedComponents<TVec>(graph);
			List<List<int>> list2 = new List<List<int>>();
			foreach (IComponent component in list)
			{
				foreach (List<int> list3 in GraphEulerStroke.DecomposeComponent(component.Degree, component.Adj, component.EdgeCount))
				{
					if (list3.Count >= 2)
					{
						list2.Add(list3);
					}
				}
			}
			return list2;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00038568 File Offset: 0x00036768
		public static List<List<int>> SplitToEdges<[Nullable(2)] TVec>(Graph<TVec> graph)
		{
			List<List<int>> list = new List<List<int>>();
			foreach (IGraphRuntimeEdge graphRuntimeEdge in graph.GetAllEdges())
			{
				if (graphRuntimeEdge.From != graphRuntimeEdge.To)
				{
					list.Add(new List<int>
					{
						graphRuntimeEdge.From,
						graphRuntimeEdge.To
					});
				}
			}
			return list;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000385E8 File Offset: 0x000367E8
		public unsafe static List<TVec> StrokeToLocations<[Nullable(2)] TVec>(Graph<TVec> graph, List<int> stroke)
		{
			List<TVec> list = new List<TVec>();
			foreach (int num in stroke)
			{
				TVec nodeLocation = graph.GetNodeLocation(num);
				if (nodeLocation == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Container;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "StrokeToLocations: NodeId has no location.";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Graph", graph);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NodeId", num);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					list.Add(nodeLocation);
				}
			}
			return list;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000386B0 File Offset: 0x000368B0
		private static IAdjacency BuildAdjacency<[Nullable(2)] TVec>(Graph<TVec> graph)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			Dictionary<int, List<IAdjItem>> dictionary2 = new Dictionary<int, List<IAdjItem>>();
			List<int> list = new List<int>();
			foreach (IGraphRuntimeNode<TVec> graphRuntimeNode in graph.GetAllNodes())
			{
				dictionary2[graphRuntimeNode.Id] = new List<IAdjItem>();
				dictionary[graphRuntimeNode.Id] = 0;
				list.Add(graphRuntimeNode.Id);
			}
			foreach (IGraphRuntimeEdge edge in graph.GetAllEdges())
			{
				GraphEulerStroke.AddUndirectedEdge(dictionary, dictionary2, edge);
			}
			return new Adjacency
			{
				Degree = dictionary,
				Adj = dictionary2,
				NodeIds = list
			};
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00038794 File Offset: 0x00036994
		private static void AddUndirectedEdge(Dictionary<int, int> degree, Dictionary<int, List<IAdjItem>> adj, IGraphRuntimeEdge edge)
		{
			if (edge.From == edge.To)
			{
				return;
			}
			if (!adj.ContainsKey(edge.From) || !adj.ContainsKey(edge.To))
			{
				return;
			}
			adj[edge.From].Add(new AdjItem
			{
				To = edge.To,
				EdgeId = edge.Id
			});
			adj[edge.To].Add(new AdjItem
			{
				To = edge.From,
				EdgeId = edge.Id
			});
			int num;
			degree[edge.From] = (degree.TryGetValue(edge.From, out num) ? num : 0) + 1;
			int num2;
			degree[edge.To] = (degree.TryGetValue(edge.To, out num2) ? num2 : 0) + 1;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00038870 File Offset: 0x00036A70
		private static bool IsEdgeConnected(int startId, Dictionary<int, List<IAdjItem>> adj, Dictionary<int, int> degree)
		{
			HashSet<int> hashSet = new HashSet<int>();
			List<int> list = new List<int>
			{
				startId
			};
			hashSet.Add(startId);
			while (list.Count > 0)
			{
				int key = list[list.Count - 1];
				list.RemoveAt(list.Count - 1);
				List<IAdjItem> list2;
				foreach (IAdjItem adjItem in (adj.TryGetValue(key, out list2) ? list2 : new List<IAdjItem>()))
				{
					if (!hashSet.Contains(adjItem.To))
					{
						hashSet.Add(adjItem.To);
						list.Add(adjItem.To);
					}
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair in degree)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int item = num;
				if (num2 > 0 && !hashSet.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000389A0 File Offset: 0x00036BA0
		private static List<IComponent> SplitEdgeConnectedComponents<[Nullable(2)] TVec>(Graph<TVec> graph)
		{
			IAdjacency adjacency = GraphEulerStroke.BuildAdjacency<TVec>(graph);
			HashSet<int> hashSet = new HashSet<int>();
			List<IComponent> list = new List<IComponent>();
			foreach (int num in adjacency.NodeIds)
			{
				int num2;
				if (!hashSet.Contains(num) && (adjacency.Degree.TryGetValue(num, out num2) && num2 != 0))
				{
					HashSet<int> hashSet2 = new HashSet<int>();
					List<int> list2 = new List<int>
					{
						num
					};
					hashSet.Add(num);
					hashSet2.Add(num);
					while (list2.Count > 0)
					{
						int key = list2[list2.Count - 1];
						list2.RemoveAt(list2.Count - 1);
						List<IAdjItem> list3;
						foreach (IAdjItem adjItem in (adjacency.Adj.TryGetValue(key, out list3) ? list3 : new List<IAdjItem>()))
						{
							if (!hashSet.Contains(adjItem.To))
							{
								hashSet.Add(adjItem.To);
								hashSet2.Add(adjItem.To);
								list2.Add(adjItem.To);
							}
						}
					}
					Dictionary<int, List<IAdjItem>> dictionary = new Dictionary<int, List<IAdjItem>>();
					Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
					HashSet<int> hashSet3 = new HashSet<int>();
					int num3 = 0;
					foreach (int key2 in hashSet2)
					{
						List<IAdjItem> list5;
						List<IAdjItem> list4 = adjacency.Adj.TryGetValue(key2, out list5) ? list5 : new List<IAdjItem>();
						dictionary[key2] = new List<IAdjItem>(list4);
						int num4;
						dictionary2[key2] = (adjacency.Degree.TryGetValue(key2, out num4) ? num4 : 0);
						foreach (IAdjItem adjItem2 in list4)
						{
							if (!hashSet3.Contains(adjItem2.EdgeId))
							{
								hashSet3.Add(adjItem2.EdgeId);
								num3++;
							}
						}
					}
					list.Add(new Component
					{
						Degree = dictionary2,
						Adj = dictionary,
						EdgeCount = num3
					});
				}
			}
			return list;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00038C6C File Offset: 0x00036E6C
		private static List<List<int>> DecomposeComponent(Dictionary<int, int> degree, Dictionary<int, List<IAdjItem>> adj, int realEdgeCount)
		{
			Dictionary<int, List<IAdjItem>> dictionary = new Dictionary<int, List<IAdjItem>>();
			foreach (KeyValuePair<int, List<IAdjItem>> keyValuePair in adj)
			{
				int num;
				List<IAdjItem> list;
				keyValuePair.Deconstruct(out num, out list);
				int key = num;
				List<IAdjItem> collection = list;
				dictionary[key] = new List<IAdjItem>(collection);
			}
			List<int> list2 = new List<int>();
			foreach (KeyValuePair<int, int> keyValuePair2 in degree)
			{
				int num;
				int num2;
				keyValuePair2.Deconstruct(out num, out num2);
				int item = num;
				if (num2 % 2 == 1)
				{
					list2.Add(item);
				}
			}
			HashSet<int> hashSet = new HashSet<int>();
			int num3 = -1;
			int num4 = 0;
			while (num4 + 1 < list2.Count)
			{
				int num5 = list2[num4];
				int num6 = list2[num4 + 1];
				int num7 = num3;
				num3--;
				hashSet.Add(num7);
				dictionary[num5].Add(new AdjItem
				{
					To = num6,
					EdgeId = num7
				});
				dictionary[num6].Add(new AdjItem
				{
					To = num5,
					EdgeId = num7
				});
				num4 += 2;
			}
			int? num8 = null;
			foreach (KeyValuePair<int, List<IAdjItem>> keyValuePair in dictionary)
			{
				List<IAdjItem> list;
				int num2;
				keyValuePair.Deconstruct(out num2, out list);
				int value = num2;
				if (list.Count > 0)
				{
					num8 = new int?(value);
					break;
				}
			}
			if (num8 == null)
			{
				return new List<List<int>>();
			}
			int edgeCount = realEdgeCount + hashSet.Count;
			List<ISequence> list3 = GraphEulerStroke.Hierholzer(num8.Value, dictionary, edgeCount);
			List<List<int>> list4 = new List<List<int>>();
			List<int> list5;
			if (list3.Count <= 0)
			{
				list5 = new List<int>();
			}
			else
			{
				(list5 = new List<int>()).Add(list3[0].Node);
			}
			List<int> list6 = list5;
			for (int i = 1; i < list3.Count; i++)
			{
				ISequence sequence = list3[i];
				if (sequence.ArrivedByEdgeId != null && hashSet.Contains(sequence.ArrivedByEdgeId.Value))
				{
					if (list6.Count >= 2)
					{
						list4.Add(list6);
					}
					list6 = new List<int>
					{
						sequence.Node
					};
				}
				else
				{
					list6.Add(sequence.Node);
				}
			}
			if (list6.Count >= 2)
			{
				list4.Add(list6);
			}
			return list4;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00038F1C File Offset: 0x0003711C
		private static List<ISequence> Hierholzer(int startId, Dictionary<int, List<IAdjItem>> adj, int edgeCount)
		{
			HashSet<int> hashSet = new HashSet<int>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (int key in adj.Keys)
			{
				dictionary[key] = 0;
			}
			List<ISequence> list = new List<ISequence>
			{
				new Sequence
				{
					Node = startId,
					ArrivedByEdgeId = null
				}
			};
			List<ISequence> list2 = new List<ISequence>();
			while (list.Count > 0)
			{
				ISequence sequence = list[list.Count - 1];
				List<IAdjItem> list4;
				List<IAdjItem> list3 = adj.TryGetValue(sequence.Node, out list4) ? list4 : new List<IAdjItem>();
				bool flag = false;
				int num;
				int i = dictionary.TryGetValue(sequence.Node, out num) ? num : 0;
				while (i < list3.Count)
				{
					IAdjItem adjItem = list3[i];
					i++;
					if (!hashSet.Contains(adjItem.EdgeId))
					{
						hashSet.Add(adjItem.EdgeId);
						list.Add(new Sequence
						{
							Node = adjItem.To,
							ArrivedByEdgeId = new int?(adjItem.EdgeId)
						});
						flag = true;
						break;
					}
				}
				dictionary[sequence.Node] = i;
				if (!flag)
				{
					ISequence item = list[list.Count - 1];
					list.RemoveAt(list.Count - 1);
					list2.Add(item);
				}
			}
			list2.Reverse();
			return list2;
		}
	}
}
