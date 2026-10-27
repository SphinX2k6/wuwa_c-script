using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F5 RID: 25845
	public class GameRandom
	{
		// Token: 0x06040E1B RID: 265755 RVA: 0x00FB9C39 File Offset: 0x00FB7E39
		public GameRandom(int seed)
		{
		}

		// Token: 0x170094F4 RID: 38132
		// (get) Token: 0x06040E1C RID: 265756 RVA: 0x00FB9C54 File Offset: 0x00FB7E54
		// (set) Token: 0x06040E1D RID: 265757 RVA: 0x00FB9C5C File Offset: 0x00FB7E5C
		public int Seed { get; private set; } = seed;

		// Token: 0x170094F5 RID: 38133
		// (get) Token: 0x06040E1E RID: 265758 RVA: 0x00FB9C65 File Offset: 0x00FB7E65
		// (set) Token: 0x06040E1F RID: 265759 RVA: 0x00FB9C6D File Offset: 0x00FB7E6D
		public int Calls { get; private set; }

		// Token: 0x06040E20 RID: 265760 RVA: 0x00FB9C76 File Offset: 0x00FB7E76
		public void Reseed(int seed)
		{
			this.Seed = seed;
			this.Calls = 0;
			this.Random = new Random(seed);
		}

		// Token: 0x06040E21 RID: 265761 RVA: 0x00FB9C94 File Offset: 0x00FB7E94
		public int Next(int maxExclusive)
		{
			int calls = this.Calls;
			this.Calls = calls + 1;
			return this.Random.Next(maxExclusive);
		}

		// Token: 0x06040E22 RID: 265762 RVA: 0x00FB9CC0 File Offset: 0x00FB7EC0
		public double NextDouble()
		{
			int calls = this.Calls;
			this.Calls = calls + 1;
			return this.Random.NextDouble();
		}

		// Token: 0x04021D21 RID: 138529
		[Nullable(1)]
		private Random Random = new Random(seed);
	}
}
