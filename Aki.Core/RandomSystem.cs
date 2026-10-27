using System;

// Token: 0x020000CA RID: 202
public class RandomSystem
{
	// Token: 0x0600062F RID: 1583 RVA: 0x00020E12 File Offset: 0x0001F012
	private static float GetRandom()
	{
		return (float)(new Random().NextDouble() * (double)RandomSystem.RAND_MAX);
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00020E26 File Offset: 0x0001F026
	public static float GetRandomInteger()
	{
		return RandomSystem.GetRandom();
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00020E2D File Offset: 0x0001F02D
	public static float GetRandomPercent()
	{
		return (float)(new Random().NextDouble() * (double)RandomSystem.RAND_PERCENT);
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00020E41 File Offset: 0x0001F041
	private static int NextXorShift32(int x)
	{
		int num = x ^ x << 13;
		int num2 = num ^ num >> 17;
		return num2 ^ num2 << 5;
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00020E52 File Offset: 0x0001F052
	public static int GetNextRandomSeed(int seed, ERandomReason reason)
	{
		return RandomSystem.NextXorShift32(seed);
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00020E5A File Offset: 0x0001F05A
	public static int IterateRandomSeed(int seed, ERandomReason reason)
	{
		return RandomSystem.NextXorShift32(seed);
	}

	// Token: 0x04000502 RID: 1282
	public static readonly int RAND_MAX = int.MaxValue;

	// Token: 0x04000503 RID: 1283
	public static readonly int RAND_PERCENT = 10000;
}
