using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B20 RID: 23328
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandDefine
	{
		// Token: 0x06039628 RID: 235048 RVA: 0x0101A618 File Offset: 0x01018818
		// Note: this type is marked as 'beforefieldinit'.
		static TuningStandDefine()
		{
			Dictionary<ETuningStandGridType, int> dictionary = new Dictionary<ETuningStandGridType, int>();
			dictionary[ETuningStandGridType.Start1] = 0;
			dictionary[ETuningStandGridType.Start2] = 0;
			dictionary[ETuningStandGridType.Number1] = 1;
			dictionary[ETuningStandGridType.Number2] = 2;
			dictionary[ETuningStandGridType.Number3] = 3;
			dictionary[ETuningStandGridType.Number4] = 4;
			dictionary[ETuningStandGridType.End1] = 5;
			dictionary[ETuningStandGridType.End2] = 5;
			dictionary[ETuningStandGridType.Empty] = -1;
			TuningStandDefine.gridValueMap = dictionary;
			Dictionary<ETuningStandGridType, EGridMainType> dictionary2 = new Dictionary<ETuningStandGridType, EGridMainType>();
			dictionary2[ETuningStandGridType.Start1] = EGridMainType.Start;
			dictionary2[ETuningStandGridType.Start2] = EGridMainType.Start;
			dictionary2[ETuningStandGridType.Number1] = EGridMainType.Path;
			dictionary2[ETuningStandGridType.Number2] = EGridMainType.Path;
			dictionary2[ETuningStandGridType.Number3] = EGridMainType.Path;
			dictionary2[ETuningStandGridType.Number4] = EGridMainType.Path;
			dictionary2[ETuningStandGridType.End1] = EGridMainType.End;
			dictionary2[ETuningStandGridType.End2] = EGridMainType.End;
			dictionary2[ETuningStandGridType.Empty] = EGridMainType.Empty;
			TuningStandDefine.gridMainTypeMap = dictionary2;
			Dictionary<ETuningStandGridType, string[]> dictionary3 = new Dictionary<ETuningStandGridType, string[]>();
			dictionary3[ETuningStandGridType.Number1] = new string[]
			{
				"SP_DigitalMazeNum01Nml",
				"SP_DigitalMazeNum01Red",
				"SP_DigitalMazeNum01Blue"
			};
			dictionary3[ETuningStandGridType.Number2] = new string[]
			{
				"SP_DigitalMazeNum02Nml",
				"SP_DigitalMazeNum02Red",
				"SP_DigitalMazeNum02Blue"
			};
			dictionary3[ETuningStandGridType.Number3] = new string[]
			{
				"SP_DigitalMazeNum03Nml",
				"SP_DigitalMazeNum03Red",
				"SP_DigitalMazeNum03Blue"
			};
			dictionary3[ETuningStandGridType.Number4] = new string[]
			{
				"SP_DigitalMazeNum04Nml",
				"SP_DigitalMazeNum04Red",
				"SP_DigitalMazeNum04Blue"
			};
			dictionary3[ETuningStandGridType.End1] = new string[]
			{
				"SP_DigitalMazeNum05Nml",
				"SP_DigitalMazeNum05Red",
				"SP_DigitalMazeNum05Blue"
			};
			dictionary3[ETuningStandGridType.End2] = new string[]
			{
				"SP_DigitalMazeNum05Nml",
				"SP_DigitalMazeNum05Red",
				"SP_DigitalMazeNum05Blue"
			};
			TuningStandDefine.gridSpriteMap = dictionary3;
		}

		// Token: 0x0401E436 RID: 123958
		public const int MAX_ROW = 5;

		// Token: 0x0401E437 RID: 123959
		public const int MAX_LINE = 7;

		// Token: 0x0401E438 RID: 123960
		public const int ANIM_IN_TIME = 330;

		// Token: 0x0401E439 RID: 123961
		public const int RESET_TIMES_THREDHOLD = 3;

		// Token: 0x0401E43A RID: 123962
		public const int RESET_COOL_DOWN = 3;

		// Token: 0x0401E43B RID: 123963
		public const int TOOLONG_DELAY = 60000;

		// Token: 0x0401E43C RID: 123964
		public const int TOOLONG_DELAY_MIN = 3;

		// Token: 0x0401E43D RID: 123965
		public const int TUNINGSTAND_HELP_ID = 346;

		// Token: 0x0401E43E RID: 123966
		public const int FX_FLYING_TIME = 1;

		// Token: 0x0401E43F RID: 123967
		public const float AK_COOL_DOWN = 0.05f;

		// Token: 0x0401E440 RID: 123968
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ETuningStandGridType, int> gridValueMap;

		// Token: 0x0401E441 RID: 123969
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ETuningStandGridType, EGridMainType> gridMainTypeMap;

		// Token: 0x0401E442 RID: 123970
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ETuningStandGridType, string[]> gridSpriteMap;
	}
}
