using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A3 RID: 17827
	[NullableContext(1)]
	[Nullable(0)]
	public class SeedRandomUtil
	{
		// Token: 0x0602CEA8 RID: 183976 RVA: 0x00C90B27 File Offset: 0x00C8ED27
		public void SetSeed(long seed)
		{
			this.Seed = seed;
		}

		// Token: 0x0602CEA9 RID: 183977 RVA: 0x00C90B30 File Offset: 0x00C8ED30
		public double GetFraction()
		{
			this.Seed = (this.A * this.Seed + this.C) % this.M;
			return (double)this.Seed / (double)this.M;
		}

		// Token: 0x0602CEAA RID: 183978 RVA: 0x00C90B64 File Offset: 0x00C8ED64
		public int SeedRandomRangeInt(int min, int max)
		{
			double fraction = this.GetFraction();
			return Math.Min(max, (int)Math.Floor((double)min + fraction * (double)(max - min + 1)));
		}

		// Token: 0x0602CEAB RID: 183979 RVA: 0x00C90B90 File Offset: 0x00C8ED90
		public List<int> GenerateRandomSequence(int size)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < size; i++)
			{
				list.Add(i + 1);
			}
			for (int j = size - 1; j > 0; j--)
			{
				int index = this.SeedRandomRangeInt(0, j);
				int value = list[j];
				list[j] = list[index];
				list[index] = value;
			}
			return list;
		}

		// Token: 0x0602CEAC RID: 183980 RVA: 0x00C90BF0 File Offset: 0x00C8EDF0
		public int WeightedRandom(List<int> weights)
		{
			if (weights.Count == 1)
			{
				return 0;
			}
			List<int> list = new List<int>();
			int num = 0;
			foreach (int num2 in weights)
			{
				num += num2;
				list.Add(num);
			}
			int num3 = this.SeedRandomRangeInt(0, num);
			for (int i = 0; i < list.Count; i++)
			{
				if (num3 < list[i])
				{
					return i;
				}
			}
			return weights.Count - 1;
		}

		// Token: 0x040180FC RID: 98556
		private readonly long A = 1664525L;

		// Token: 0x040180FD RID: 98557
		private readonly long C = 1013904223L;

		// Token: 0x040180FE RID: 98558
		private readonly long M = (long)Math.Pow(2.0, 32.0);

		// Token: 0x040180FF RID: 98559
		private long Seed;
	}
}
