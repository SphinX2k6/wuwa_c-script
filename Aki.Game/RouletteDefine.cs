using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002917 RID: 10519
public class RouletteDefine : IStaticVariableResetter
{
	// Token: 0x06015AF5 RID: 88821 RVA: 0x0057872B File Offset: 0x0057692B
	static RouletteDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteDefine.CreateStaticDefaultValue), new Action(RouletteDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06015AF6 RID: 88822 RVA: 0x0057874A File Offset: 0x0057694A
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

	// Token: 0x06015AF7 RID: 88823 RVA: 0x0057876E File Offset: 0x0057696E
	public static void ResetStaticDefaultValue()
	{
		RouletteDefine.rouletteTypeDefine = null;
	}

	// Token: 0x0400A19F RID: 41375
	[Nullable(2)]
	public static Dictionary<ERouletteType, RouletteType> rouletteTypeDefine;

	// Token: 0x0400A1A0 RID: 41376
	[Nullable(1)]
	public const string ROULETTE_TEXT_EMPTY = "Text_ProbeToolFunctionNotice2_Text";

	// Token: 0x0400A1A1 RID: 41377
	public const int DEFAULT_ITEM_ROULETTE_GRID_INDEX = 7;

	// Token: 0x0400A1A2 RID: 41378
	public const int ROULETTE_NUM = 8;

	// Token: 0x0400A1A3 RID: 41379
	public const int ROULETTE_EXPLORE_IN_USE = 7;

	// Token: 0x0400A1A4 RID: 41380
	public const int ROULETTE_FUNCTION_IN_USE = 8;
}
