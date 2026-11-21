using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001E92 RID: 7826
public class RouletteDefine : IStaticVariableResetter
{
	// Token: 0x060134F9 RID: 79097 RVA: 0x005A361F File Offset: 0x005A181F
	static RouletteDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteDefine.CreateStaticDefaultValue), new Action(RouletteDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060134FA RID: 79098 RVA: 0x005A363E File Offset: 0x005A183E
	public static void CreateStaticDefaultValue()
	{
		RouletteDefine.rouletteTypeDefine = new Dictionary<ERouletteType, RouletteType>
		{
			{
				ERouletteType.Explore,
				RouletteType.Explore
			},
			{
				ERouletteType.Function,
				RouletteType.Function
			},
			{
				ERouletteType.Motor,
				RouletteType.Motorcycle
			}
		};
	}

	// Token: 0x060134FB RID: 79099 RVA: 0x005A3662 File Offset: 0x005A1862
	public static void ResetStaticDefaultValue()
	{
		RouletteDefine.rouletteTypeDefine = null;
	}

	// Token: 0x0400A58A RID: 42378
	[Nullable(2)]
	public static Dictionary<ERouletteType, RouletteType> rouletteTypeDefine;

	// Token: 0x0400A58B RID: 42379
	[Nullable(1)]
	public const string ROULETTE_TEXT_EMPTY = "Text_ProbeToolFunctionNotice2_Text";

	// Token: 0x0400A58C RID: 42380
	public const int DEFAULT_ITEM_ROULETTE_GRID_INDEX = 7;

	// Token: 0x0400A58D RID: 42381
	public const int ROULETTE_NUM = 8;

	// Token: 0x0400A58E RID: 42382
	public const int ROULETTE_EXPLORE_IN_USE = 7;

	// Token: 0x0400A58F RID: 42383
	public const int ROULETTE_FUNCTION_IN_USE = 8;
}
