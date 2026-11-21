using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200459E RID: 17822
	[NullableContext(1)]
	[Nullable(0)]
	public class Node
	{
		// Token: 0x0602CE8A RID: 183946 RVA: 0x00C901F4 File Offset: 0x00C8E3F4
		public Node(INodeConstructor aParams)
		{
			this.Id = aParams.GridId;
			this.Position = aParams.Position;
			this.Cost = aParams.Cost;
			this.H = 0;
			this.G = 0;
			this.F = 0;
			this.ParentNode = null;
			this.IsOnClosedList = false;
			this.IsOnOpenList = false;
			this.IsWalkable = aParams.Walkable;
		}

		// Token: 0x0602CE8B RID: 183947 RVA: 0x00C90281 File Offset: 0x00C8E481
		private void CalculateF()
		{
			this.F = this.G + this.H;
		}

		// Token: 0x0602CE8C RID: 183948 RVA: 0x00C90296 File Offset: 0x00C8E496
		public void SetG(int gValue)
		{
			this.G = gValue;
			this.CalculateF();
		}

		// Token: 0x0602CE8D RID: 183949 RVA: 0x00C902A5 File Offset: 0x00C8E4A5
		public void SetH(int hValue)
		{
			this.H = hValue;
			this.CalculateF();
		}

		// Token: 0x0602CE8E RID: 183950 RVA: 0x00C902B4 File Offset: 0x00C8E4B4
		public void SetValueToZero()
		{
			this.F = (this.G = (this.H = 0));
		}

		// Token: 0x040180E5 RID: 98533
		public int Id;

		// Token: 0x040180E6 RID: 98534
		public IPos Position = new Pos
		{
			X = 0,
			Y = 0
		};

		// Token: 0x040180E7 RID: 98535
		public int F;

		// Token: 0x040180E8 RID: 98536
		public int G;

		// Token: 0x040180E9 RID: 98537
		public int H;

		// Token: 0x040180EA RID: 98538
		public int Cost;

		// Token: 0x040180EB RID: 98539
		[Nullable(2)]
		public Node ParentNode;

		// Token: 0x040180EC RID: 98540
		public bool IsOnClosedList;

		// Token: 0x040180ED RID: 98541
		public bool IsOnOpenList;

		// Token: 0x040180EE RID: 98542
		public bool IsWalkable = true;
	}
}
