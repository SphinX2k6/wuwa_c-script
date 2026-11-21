using System;

// Token: 0x020000CC RID: 204
public class RandomSystem
{
	// Token: 0x06000670 RID: 1648 RVA: 0x000212F0 File Offset: 0x0001F4F0
	private static int GetRandom()
	{
		return Random.Shared.Next();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x000212FC File Offset: 0x0001F4FC
	public static int GetRandomInteger()
	{
		return RandomSystem.GetRandom();
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00021303 File Offset: 0x0001F503
	public static float GetRandomPercent()
	{
		return (float)(new Random().NextDouble() * (double)RandomSystem.RAND_PERCENT);
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00021317 File Offset: 0x0001F517
	private static int NextXorShift32(int x)
	{
		int num = x ^ x << 13;
		int num2 = num ^ num >> 17;
		return num2 ^ num2 << 5;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00021328 File Offset: 0x0001F528
	public static int GetNextRandomSeed(int seed, ERandomReason reason)
	{
		return RandomSystem.NextXorShift32(seed);
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00021330 File Offset: 0x0001F530
	public static int IterateRandomSeed(int seed, ERandomReason reason)
	{
		return RandomSystem.NextXorShift32(seed);
	}

	// Token: 0x04000510 RID: 1296
	public static readonly int RAND_MAX = int.MaxValue;

	// Token: 0x04000511 RID: 1297
	public static readonly int RAND_PERCENT = 10000;
}
