using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064FA RID: 25850
	public class EnergyPool
	{
		// Token: 0x17009502 RID: 38146
		// (get) Token: 0x06040E64 RID: 265828 RVA: 0x00FBADE9 File Offset: 0x00FB8FE9
		// (set) Token: 0x06040E65 RID: 265829 RVA: 0x00FBADF1 File Offset: 0x00FB8FF1
		public int Energy { get; private set; }

		// Token: 0x06040E66 RID: 265830 RVA: 0x00FBADFA File Offset: 0x00FB8FFA
		public void Charge(int amount)
		{
			this.Energy += amount;
		}

		// Token: 0x06040E67 RID: 265831 RVA: 0x00FBAE0A File Offset: 0x00FB900A
		public bool Reached(int node)
		{
			return this.Energy >= node;
		}

		// Token: 0x06040E68 RID: 265832 RVA: 0x00FBAE18 File Offset: 0x00FB9018
		public void Reset()
		{
			this.Energy = 0;
		}

		// Token: 0x06040E69 RID: 265833 RVA: 0x00FBAE21 File Offset: 0x00FB9021
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
