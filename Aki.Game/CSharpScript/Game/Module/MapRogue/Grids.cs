using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C9 RID: 21961
	[NullableContext(1)]
	[Nullable(0)]
	public class Grids
	{
		// Token: 0x06037F91 RID: 229265 RVA: 0x00D42594 File Offset: 0x00D40794
		public Grids(IGridsConstructor gridsData)
		{
			this.Width = gridsData.Width;
			this.Height = gridsData.Height;
			this.GridNodes = new List<List<Node>>();
			int num = 0;
			for (int i = 0; i < this.Height; i++)
			{
				List<Node> list = new List<Node>();
				for (int j = 0; j < this.Width; j++)
				{
					IPathNode pathNode = gridsData.Matrix[num];
					Node item = new Node(new NodeConstructor
					{
						GridId = num,
						Position = new Pos
						{
							X = j,
							Y = i
						},
						Cost = pathNode.Cost,
						Walkable = pathNode.Walkable
					});
					list.Add(item);
					num++;
				}
				this.GridNodes.Add(list);
			}
		}

		// Token: 0x06037F92 RID: 229266 RVA: 0x00D42671 File Offset: 0x00D40871
		public Node GetNodeAt(IPos position)
		{
			return this.GridNodes[position.Y][position.X];
		}

		// Token: 0x06037F93 RID: 229267 RVA: 0x00D42690 File Offset: 0x00D40890
		public Node GetNodeByIndex(int index)
		{
			int width = this.Width;
			int index2 = index % width;
			int index3 = (int)Math.Floor((double)index / (double)width);
			return this.GridNodes[index3][index2];
		}

		// Token: 0x06037F94 RID: 229268 RVA: 0x00D426C6 File Offset: 0x00D408C6
		public bool IsWalkableAt(IPos position)
		{
			return this.GridNodes[position.Y][position.X].IsWalkable;
		}

		// Token: 0x06037F95 RID: 229269 RVA: 0x00D426E9 File Offset: 0x00D408E9
		private bool IsOnTheGrid(IPos position)
		{
			return position.X >= 0 && position.X < this.Width && position.Y >= 0 && position.Y < this.Height;
		}

		// Token: 0x06037F96 RID: 229270 RVA: 0x00D4271C File Offset: 0x00D4091C
		public List<Node> GetSurroundingNodes(IPos currentPosition)
		{
			List<Node> list = new List<Node>();
			Pos pos = new Pos
			{
				X = currentPosition.X,
				Y = currentPosition.Y + 1
			};
			Pos pos2 = new Pos
			{
				X = currentPosition.X + 1,
				Y = currentPosition.Y
			};
			Pos pos3 = new Pos
			{
				X = currentPosition.X,
				Y = currentPosition.Y - 1
			};
			Pos pos4 = new Pos
			{
				X = currentPosition.X - 1,
				Y = currentPosition.Y
			};
			foreach (IPos position in new IPos[]
			{
				pos,
				pos2,
				pos3,
				pos4
			})
			{
				if (this.IsOnTheGrid(position) && this.IsWalkableAt(position))
				{
					list.Add(this.GetNodeAt(position));
				}
			}
			return list;
		}

		// Token: 0x06037F97 RID: 229271 RVA: 0x00D42808 File Offset: 0x00D40A08
		public void ResetGrids()
		{
			foreach (List<Node> list in this.GridNodes)
			{
				foreach (Node node in list)
				{
					node.IsOnClosedList = false;
					node.IsOnOpenList = false;
					node.ParentNode = null;
					node.SetValueToZero();
				}
			}
		}

		// Token: 0x0401D664 RID: 120420
		public int Width;

		// Token: 0x0401D665 RID: 120421
		public int Height;

		// Token: 0x0401D666 RID: 120422
		public List<List<Node>> GridNodes = new List<List<Node>>();
	}
}
