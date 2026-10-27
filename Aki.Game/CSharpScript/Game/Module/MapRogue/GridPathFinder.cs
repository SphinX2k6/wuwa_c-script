using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055BF RID: 21951
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPathFinder
	{
		// Token: 0x06037F5F RID: 229215 RVA: 0x00D420DD File Offset: 0x00D402DD
		public GridPathFinder(IGridsConstructor gridConstructor, bool includeStartNode = true, bool includeEndNode = true, EHeuristicFunction heuristic = EHeuristicFunction.Manhattan)
		{
			this.IncludeStartNode = includeStartNode;
			this.IncludeEndNode = includeEndNode;
			this.Heuristic = heuristic;
			this.GridsInternal = new Grids(gridConstructor);
		}

		// Token: 0x06037F60 RID: 229216 RVA: 0x00D42120 File Offset: 0x00D40320
		public List<int> FindPath(IPos startPosition, IPos endPosition)
		{
			this.ClosedList = new List<Node>();
			this.OpenList = new List<Node>();
			this.GridsInternal.ResetGrids();
			Node nodeAt = this.GridsInternal.GetNodeAt(startPosition);
			Node nodeAt2 = this.GridsInternal.GetNodeAt(endPosition);
			if (!this.GridsInternal.IsWalkableAt(endPosition) || !this.GridsInternal.IsWalkableAt(startPosition))
			{
				return new List<int>();
			}
			nodeAt.IsOnOpenList = true;
			this.OpenList.Add(nodeAt);
			for (int i = 0; i < this.GridsInternal.Height; i++)
			{
				for (int j = 0; j < this.GridsInternal.Width; j++)
				{
					Node nodeAt3 = this.GridsInternal.GetNodeAt(new Pos
					{
						X = j,
						Y = i
					});
					if (!nodeAt3.IsWalkable)
					{
						nodeAt3.SetValueToZero();
						nodeAt3.IsOnClosedList = true;
						this.ClosedList.Add(nodeAt3);
					}
					else
					{
						nodeAt3.SetH(GridPathFinderDefine.CalculateHeuristic(this.Heuristic, nodeAt3.Position, nodeAt2.Position));
					}
				}
			}
			long num = 0L;
			while (this.OpenList.Count != 0)
			{
				int index = 0;
				Node node = this.OpenList[0];
				for (int k = 0; k < this.OpenList.Count; k++)
				{
					Node node2 = this.OpenList[k];
					if (node2.F < node.F)
					{
						node = node2;
						index = k;
					}
				}
				node.IsOnOpenList = false;
				this.OpenList.RemoveAt(index);
				node.IsOnClosedList = true;
				this.ClosedList.Add(node);
				if (node == nodeAt2)
				{
					return GridPathFinderDefine.BackTrace(nodeAt2, this.IncludeStartNode, this.IncludeEndNode);
				}
				foreach (Node node3 in this.GridsInternal.GetSurroundingNodes(node.Position))
				{
					if (!node3.IsOnClosedList)
					{
						int num2 = node.G + node3.Cost;
						if (!node3.IsOnOpenList || num2 < node3.G)
						{
							node3.SetG(num2);
							node3.ParentNode = node;
							if (!node3.IsOnOpenList)
							{
								node3.IsOnOpenList = true;
								this.OpenList.Add(node3);
							}
							else
							{
								node3.ParentNode = node;
							}
						}
					}
				}
				num += 1L;
				if (num > 2147483647L)
				{
					Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.YYZ, "[GridPathFinder] 寻路搜索次数过多中止", default(ReadOnlySpan<ValueTuple<string, object>>));
					break;
				}
			}
			return new List<int>();
		}

		// Token: 0x06037F61 RID: 229217 RVA: 0x00D423D0 File Offset: 0x00D405D0
		public void UpdateGrid(IPathNode grid)
		{
			Node nodeByIndex = this.GridsInternal.GetNodeByIndex(grid.GridIndex);
			nodeByIndex.IsWalkable = grid.Walkable;
			nodeByIndex.Cost = grid.Cost;
		}

		// Token: 0x0401D646 RID: 120390
		private readonly Grids GridsInternal;

		// Token: 0x0401D647 RID: 120391
		private List<Node> ClosedList = new List<Node>();

		// Token: 0x0401D648 RID: 120392
		private List<Node> OpenList = new List<Node>();

		// Token: 0x0401D649 RID: 120393
		private readonly bool IncludeStartNode;

		// Token: 0x0401D64A RID: 120394
		private readonly bool IncludeEndNode;

		// Token: 0x0401D64B RID: 120395
		private readonly EHeuristicFunction Heuristic;
	}
}
