using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003545 RID: 13637
[NullableContext(1)]
[Nullable(0)]
public static class TaskUtils
{
	// Token: 0x0601DF42 RID: 122690 RVA: 0x00864F80 File Offset: 0x00863180
	public static List<string> GetNodesWithNoDependencies(Dictionary<string, IGraphNodeWithDependencies> graphDependencyMap)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, IGraphNodeWithDependencies> keyValuePair in graphDependencyMap)
		{
			if (keyValuePair.Value.DependsOn.Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x0601DF43 RID: 122691 RVA: 0x00864FF0 File Offset: 0x008631F0
	private static Dictionary<string, HashSet<string>> GetNewDependsOnMap(Dictionary<string, IGraphNodeWithDependencies> graphDependencyMap)
	{
		Dictionary<string, HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>();
		foreach (KeyValuePair<string, IGraphNodeWithDependencies> keyValuePair in graphDependencyMap)
		{
			dictionary[keyValuePair.Key] = new HashSet<string>(keyValuePair.Value.DependsOn);
		}
		return dictionary;
	}

	// Token: 0x0601DF44 RID: 122692 RVA: 0x0086505C File Offset: 0x0086325C
	private static List<string> TopologicalSort(Dictionary<string, IGraphNodeWithDependencies> graphDependencyMap, List<string> nodesWithNoDependencies)
	{
		List<string> list = new List<string>();
		Dictionary<string, HashSet<string>> newDependsOnMap = TaskUtils.GetNewDependsOnMap(graphDependencyMap);
		List<string> list2 = new List<string>(nodesWithNoDependencies);
		while (list2.Count > 0)
		{
			string text = list2[list2.Count - 1];
			list2.RemoveAt(list2.Count - 1);
			list.Add(text);
			foreach (string text2 in graphDependencyMap[text].DependedOnBy)
			{
				HashSet<string> hashSet = newDependsOnMap[text2];
				hashSet.Remove(text);
				if (hashSet.Count == 0)
				{
					list2.Add(text2);
				}
			}
		}
		return list;
	}

	// Token: 0x0601DF45 RID: 122693 RVA: 0x00865118 File Offset: 0x00863318
	public static Dictionary<string, int> GetNodeCumulativePriorities(Dictionary<string, IGraphNodeWithDependencies> graphDependencyMap, List<string> nodesWithNoDependencies)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		List<string> list = TaskUtils.TopologicalSort(graphDependencyMap, nodesWithNoDependencies);
		while (list.Count > 0)
		{
			string key = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			IGraphNodeWithDependencies graphNodeWithDependencies = graphDependencyMap[key];
			int valueOrDefault = graphNodeWithDependencies.Priority.GetValueOrDefault();
			int num = 0;
			foreach (string text in graphNodeWithDependencies.DependedOnBy)
			{
				if (!dictionary.ContainsKey(text))
				{
					throw new Exception("Expected to have already computed the cumulative priority for node " + text);
				}
				int num2 = dictionary[text];
				if (num2 > num)
				{
					num = num2;
				}
			}
			int value = valueOrDefault + num;
			dictionary[key] = value;
		}
		return dictionary;
	}

	// Token: 0x0601DF46 RID: 122694 RVA: 0x008651FC File Offset: 0x008633FC
	private static List<string> SearchForCycleDFS(Dictionary<string, IGraphNodeWithDependencies> graph, Dictionary<string, bool> visitMap, string nodeId)
	{
		List<StackElement> list = new List<StackElement>
		{
			new StackElement
			{
				Node = nodeId,
				Traversing = false
			}
		};
		while (list.Count > 0)
		{
			StackElement stackElement = list[list.Count - 1];
			if (!stackElement.Traversing)
			{
				if (visitMap.ContainsKey(stackElement.Node))
				{
					if (!visitMap[stackElement.Node])
					{
						list.RemoveAt(list.Count - 1);
						continue;
					}
					List<string> list2 = new List<string>();
					foreach (StackElement stackElement2 in list)
					{
						if (stackElement2.Traversing)
						{
							list2.Add(stackElement2.Node);
						}
					}
					int num = -1;
					for (int i = 0; i < list2.Count; i++)
					{
						if (list2[i] == stackElement.Node)
						{
							num = i;
							break;
						}
					}
					if (num >= 0)
					{
						List<string> list3 = new List<string>();
						for (int j = num; j < list2.Count; j++)
						{
							list3.Add(list2[j]);
						}
						return list3;
					}
					return list2;
				}
				else
				{
					visitMap[stackElement.Node] = true;
					list[list.Count - 1] = new StackElement
					{
						Node = stackElement.Node,
						Traversing = true
					};
					if (!graph.ContainsKey(stackElement.Node))
					{
						throw new Exception("Could not find node \"" + stackElement.Node + "\" in the graph");
					}
					using (HashSet<string>.Enumerator enumerator2 = graph[stackElement.Node].DependedOnBy.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string node = enumerator2.Current;
							list.Add(new StackElement
							{
								Node = node,
								Traversing = false
							});
						}
						continue;
					}
				}
			}
			visitMap[stackElement.Node] = false;
			list.RemoveAt(list.Count - 1);
		}
		return new List<string>();
	}

	// Token: 0x0601DF47 RID: 122695 RVA: 0x00865424 File Offset: 0x00863624
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static OneOf<IGraphNodeWithCyclicDependency, IGraphNodeWithNoCyclicDependency> GraphHasCycles(Dictionary<string, IGraphNodeWithDependencies> graphDependencyMap)
	{
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
		foreach (KeyValuePair<string, IGraphNodeWithDependencies> keyValuePair in graphDependencyMap)
		{
			if (!dictionary.ContainsKey(keyValuePair.Key))
			{
				List<string> list = TaskUtils.SearchForCycleDFS(graphDependencyMap, dictionary, keyValuePair.Key);
				if (list.Count > 0)
				{
					return new GraphNodeWithCyclicDependency
					{
						HasCycle = true,
						Cycle = list.ToArray()
					};
				}
			}
		}
		return new GraphNodeWithNoCyclicDependency
		{
			HasCycle = false
		};
	}
}
