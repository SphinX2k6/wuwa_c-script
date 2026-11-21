using System;
using System.Runtime.CompilerServices;

// Token: 0x02001904 RID: 6404
public class PhantomBattleDefine : IStaticVariableResetter
{
	// Token: 0x0600FCDA RID: 64730 RVA: 0x0049CB97 File Offset: 0x0049AD97
	static PhantomBattleDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleDefine.CreateStaticDefaultValue), new Action(PhantomBattleDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600FCDB RID: 64731 RVA: 0x0049CBB6 File Offset: 0x0049ADB6
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleDefine.costListRecommendHighLevel = null;
		PhantomBattleDefine.costListRecommendLowLevel = null;
	}

	// Token: 0x0600FCDC RID: 64732 RVA: 0x0049CBC4 File Offset: 0x0049ADC4
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

	// Token: 0x04008CEE RID: 36078
	public const int MINEXP = 20;

	// Token: 0x04008CEF RID: 36079
	public const int PROPOFFSET = 10000;

	// Token: 0x04008CF0 RID: 36080
	public const int BLACKSTONEIDNUM = 2;

	// Token: 0x04008CF1 RID: 36081
	public const int MAX_EQUIP_COUNT = 5;

	// Token: 0x04008CF2 RID: 36082
	[Nullable(1)]
	public static int[] costListRecommendHighLevel;

	// Token: 0x04008CF3 RID: 36083
	[Nullable(1)]
	public static int[] costListRecommendLowLevel;

	// Token: 0x02007B2A RID: 31530
	public enum ETipsType
	{
		// Token: 0x04027EB1 RID: 163505
		Preview,
		// Token: 0x04027EB2 RID: 163506
		Equip
	}
}
