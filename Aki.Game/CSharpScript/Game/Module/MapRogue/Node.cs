using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C8 RID: 21960
	[NullableContext(1)]
	[Nullable(0)]
	public class Node
	{
		// Token: 0x06037F8C RID: 229260 RVA: 0x00D424AC File Offset: 0x00D406AC
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

		// Token: 0x06037F8D RID: 229261 RVA: 0x00D42539 File Offset: 0x00D40739
		private void CalculateF()
		{
			this.F = this.G + this.H;
		}

		// Token: 0x06037F8E RID: 229262 RVA: 0x00D4254E File Offset: 0x00D4074E
		public void SetG(int gValue)
		{
			this.G = gValue;
			this.CalculateF();
		}

		// Token: 0x06037F8F RID: 229263 RVA: 0x00D4255D File Offset: 0x00D4075D
		public void SetH(int hValue)
		{
			this.H = hValue;
			this.CalculateF();
		}

		// Token: 0x06037F90 RID: 229264 RVA: 0x00D4256C File Offset: 0x00D4076C
		public void SetValueToZero()
		{
			this.F = (this.G = (this.H = 0));
		}

		// Token: 0x0401D65A RID: 120410
		public int Id;

		// Token: 0x0401D65B RID: 120411
		public IPos Position = new Pos
		{
			X = 0,
			Y = 0
		};

		// Token: 0x0401D65C RID: 120412
		public int F;

		// Token: 0x0401D65D RID: 120413
		public int G;

		// Token: 0x0401D65E RID: 120414
		public int H;

		// Token: 0x0401D65F RID: 120415
		public int Cost;

		// Token: 0x0401D660 RID: 120416
		[Nullable(2)]
		public Node ParentNode;

		// Token: 0x0401D661 RID: 120417
		public bool IsOnClosedList;

		// Token: 0x0401D662 RID: 120418
		public bool IsOnOpenList;

		// Token: 0x0401D663 RID: 120419
		public bool IsWalkable = true;
	}
}
