using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A0 RID: 17824
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPathFinderDefine
	{
		// Token: 0x0602CE96 RID: 183958 RVA: 0x00C905EC File Offset: 0x00C8E7EC
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

		// Token: 0x0602CE97 RID: 183959 RVA: 0x00C9066C File Offset: 0x00C8E86C
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
