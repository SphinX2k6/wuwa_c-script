using System;
using System.Runtime.CompilerServices;

// Token: 0x0200241F RID: 9247
public class PhantomBattleDefine : IStaticVariableResetter
{
	// Token: 0x06012824 RID: 75812 RVA: 0x0048F57B File Offset: 0x0048D77B
	static PhantomBattleDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleDefine.CreateStaticDefaultValue), new Action(PhantomBattleDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06012825 RID: 75813 RVA: 0x0048F59A File Offset: 0x0048D79A
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleDefine.costListRecommendHighLevel = null;
		PhantomBattleDefine.costListRecommendLowLevel = null;
	}

	// Token: 0x06012826 RID: 75814 RVA: 0x0048F5A8 File Offset: 0x0048D7A8
	public static void CreateStaticDefaultValue()
	{
		PhantomBattleDefine.costListRecommendHighLevel = new int[]
		{
			4,
			3,
			3,
			1,
			1
		};
		PhantomBattleDefine.costListRecommendLowLevel = new int[]
		{
			4,
			3,
			1,
			1,
			1
		};
	}

	// Token: 0x04008BA7 RID: 35751
	public const int MINEXP = 20;

	// Token: 0x04008BA8 RID: 35752
	public const int PROPOFFSET = 10000;

	// Token: 0x04008BA9 RID: 35753
	public const int BLACKSTONEIDNUM = 2;

	// Token: 0x04008BAA RID: 35754
	public const int MAX_EQUIP_COUNT = 5;

	// Token: 0x04008BAB RID: 35755
	[Nullable(1)]
	public static int[] costListRecommendHighLevel;

	// Token: 0x04008BAC RID: 35756
	[Nullable(1)]
	public static int[] costListRecommendLowLevel;

	// Token: 0x020089A3 RID: 35235
	public enum ETipsType
	{
		// Token: 0x0402CB9B RID: 183195
		Preview,
		// Token: 0x0402CB9C RID: 183196
		Equip
	}
}
