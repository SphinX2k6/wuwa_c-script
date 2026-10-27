using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055CA RID: 21962
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPathFinderDefine
	{
		// Token: 0x06037F98 RID: 229272 RVA: 0x00D428A4 File Offset: 0x00D40AA4
		public static int CalculateHeuristic(EHeuristicFunction heuristicFunction, IPos p0, IPos p1)
		{
			int num = Math.Abs(p1.X - p0.X);
			int num2 = Math.Abs(p1.Y - p0.Y);
			switch (heuristicFunction)
			{
			case EHeuristicFunction.Manhattan:
				return num + num2;
			case EHeuristicFunction.Euclidean:
				return (int)Math.Sqrt((double)(num * num + num2 * num2));
			case EHeuristicFunction.Chebyshev:
				return Math.Max(num, num2);
			case EHeuristicFunction.Octile:
				return (int)((double)(num + num2) - 0.58 * (double)Math.Min(num, num2));
			default:
				return 0;
			}
		}

		// Token: 0x06037F99 RID: 229273 RVA: 0x00D42924 File Offset: 0x00D40B24
		public static List<int> BackTrace(Node node, bool includeStartNode, bool includeEndNode)
		{
			List<int> list = new List<int>();
			Node node2 = includeEndNode ? node : node.ParentNode;
			while (node2.ParentNode != null)
			{
				list.Add(node2.Id);
				node2 = node2.ParentNode;
			}
			if (includeStartNode)
			{
				list.Add(node2.Id);
			}
			list.Reverse();
			return list;
		}
	}
}
