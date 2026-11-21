using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005478 RID: 21624
	public class EnergyPool
	{
		// Token: 0x17006864 RID: 26724
		// (get) Token: 0x06035B28 RID: 219944 RVA: 0x00F01E19 File Offset: 0x00F00019
		// (set) Token: 0x06035B29 RID: 219945 RVA: 0x00F01E21 File Offset: 0x00F00021
		public int Energy { get; private set; }

		// Token: 0x06035B2A RID: 219946 RVA: 0x00F01E2A File Offset: 0x00F0002A
		public void Charge(int amount)
		{
			this.Energy += amount;
		}

		// Token: 0x06035B2B RID: 219947 RVA: 0x00F01E3A File Offset: 0x00F0003A
		public bool Reached(int node)
		{
			return this.Energy >= node;
		}

		// Token: 0x06035B2C RID: 219948 RVA: 0x00F01E48 File Offset: 0x00F00048
		public void Reset()
		{
			this.Energy = 0;
		}

		// Token: 0x06035B2D RID: 219949 RVA: 0x00F01E51 File Offset: 0x00F00051
		public void StartNewCycle(int fullNode)
		{
			this.Energy -= fullNode;
			if (this.Energy < 0)
			{
				this.Energy = 0;
			}
		}
	}
}
