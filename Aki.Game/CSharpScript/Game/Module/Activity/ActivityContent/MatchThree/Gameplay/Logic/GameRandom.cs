using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005473 RID: 21619
	public class GameRandom
	{
		// Token: 0x06035ADF RID: 219871 RVA: 0x00F00C69 File Offset: 0x00EFEE69
		public GameRandom(int seed)
		{
		}

		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x06035AE0 RID: 219872 RVA: 0x00F00C84 File Offset: 0x00EFEE84
		// (set) Token: 0x06035AE1 RID: 219873 RVA: 0x00F00C8C File Offset: 0x00EFEE8C
		public int Seed { get; private set; } = seed;

		// Token: 0x17006857 RID: 26711
		// (get) Token: 0x06035AE2 RID: 219874 RVA: 0x00F00C95 File Offset: 0x00EFEE95
		// (set) Token: 0x06035AE3 RID: 219875 RVA: 0x00F00C9D File Offset: 0x00EFEE9D
		public int Calls { get; private set; }

		// Token: 0x06035AE4 RID: 219876 RVA: 0x00F00CA6 File Offset: 0x00EFEEA6
		public void Reseed(int seed)
		{
			this.Seed = seed;
			this.Calls = 0;
			this.Random = new Random(seed);
		}

		// Token: 0x06035AE5 RID: 219877 RVA: 0x00F00CC4 File Offset: 0x00EFEEC4
		public int Next(int maxExclusive)
		{
			int calls = this.Calls;
			this.Calls = calls + 1;
			return this.Random.Next(maxExclusive);
		}

		// Token: 0x06035AE6 RID: 219878 RVA: 0x00F00CF0 File Offset: 0x00EFEEF0
		public double NextDouble()
		{
			int calls = this.Calls;
			this.Calls = calls + 1;
			return this.Random.NextDouble();
		}

		// Token: 0x0401C652 RID: 116306
		[Nullable(1)]
		private Random Random = new Random(seed);
	}
}
