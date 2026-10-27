using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055CD RID: 21965
	[NullableContext(1)]
	[Nullable(0)]
	public class SeedRandomUtil
	{
		// Token: 0x06037FAA RID: 229290 RVA: 0x00D42DDF File Offset: 0x00D40FDF
		public void SetSeed(long seed)
		{
			this.Seed = seed;
		}

		// Token: 0x06037FAB RID: 229291 RVA: 0x00D42DE8 File Offset: 0x00D40FE8
		public double GetFraction()
		{
			this.Seed = (this.A * this.Seed + this.C) % this.M;
			return (double)this.Seed / (double)this.M;
		}

		// Token: 0x06037FAC RID: 229292 RVA: 0x00D42E1C File Offset: 0x00D4101C
		public int SeedRandomRangeInt(int min, int max)
		{
			double fraction = this.GetFraction();
			return Math.Min(max, (int)Math.Floor((double)min + fraction * (double)(max - min + 1)));
		}

		// Token: 0x06037FAD RID: 229293 RVA: 0x00D42E48 File Offset: 0x00D41048
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

		// Token: 0x06037FAE RID: 229294 RVA: 0x00D42EA8 File Offset: 0x00D410A8
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

		// Token: 0x0401D671 RID: 120433
		private readonly long A = 1664525L;

		// Token: 0x0401D672 RID: 120434
		private readonly long C = 1013904223L;

		// Token: 0x0401D673 RID: 120435
		private readonly long M = (long)Math.Pow(2.0, 32.0);

		// Token: 0x0401D674 RID: 120436
		private long Seed;
	}
}
