using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200459F RID: 17823
	[NullableContext(1)]
	[Nullable(0)]
	public class Grids
	{
		// Token: 0x0602CE8F RID: 183951 RVA: 0x00C902DC File Offset: 0x00C8E4DC
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

		// Token: 0x0602CE90 RID: 183952 RVA: 0x00C903B9 File Offset: 0x00C8E5B9
		public Node GetNodeAt(IPos position)
		{
			return this.GridNodes[position.Y][position.X];
		}

		// Token: 0x0602CE91 RID: 183953 RVA: 0x00C903D8 File Offset: 0x00C8E5D8
		public Node GetNodeByIndex(int index)
		{
			int width = this.Width;
			int index2 = index % width;
			int index3 = (int)Math.Floor((double)index / (double)width);
			return this.GridNodes[index3][index2];
		}

		// Token: 0x0602CE92 RID: 183954 RVA: 0x00C9040E File Offset: 0x00C8E60E
		public bool IsWalkableAt(IPos position)
		{
			return this.GridNodes[position.Y][position.X].IsWalkable;
		}

		// Token: 0x0602CE93 RID: 183955 RVA: 0x00C90431 File Offset: 0x00C8E631
		private bool IsOnTheGrid(IPos position)
		{
			return position.X >= 0 && position.X < this.Width && position.Y >= 0 && position.Y < this.Height;
		}

		// Token: 0x0602CE94 RID: 183956 RVA: 0x00C90464 File Offset: 0x00C8E664
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

		// Token: 0x0602CE95 RID: 183957 RVA: 0x00C90550 File Offset: 0x00C8E750
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

		// Token: 0x040180EF RID: 98543
		public int Width;

		// Token: 0x040180F0 RID: 98544
		public int Height;

		// Token: 0x040180F1 RID: 98545
		public List<List<Node>> GridNodes = new List<List<Node>>();
	}
}
