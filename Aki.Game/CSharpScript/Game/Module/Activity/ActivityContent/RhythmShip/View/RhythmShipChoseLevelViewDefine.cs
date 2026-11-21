using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02005195 RID: 20885
	public class RhythmShipChoseLevelViewDefine : IStaticVariableResetter
	{
		// Token: 0x06034237 RID: 213559 RVA: 0x00E955BA File Offset: 0x00E937BA
		static RhythmShipChoseLevelViewDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipChoseLevelViewDefine.CreateStaticDefaultValue), new Action(RhythmShipChoseLevelViewDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06034238 RID: 213560 RVA: 0x00E955DC File Offset: 0x00E937DC
		public static void CreateStaticDefaultValue()
		{
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			dictionary[1] = new List<int>
			{
				4
			};
			dictionary[3] = new List<int>
			{
				1,
				2,
				5
			};
			dictionary[4] = new List<int>
			{
				1,
				2,
				4,
				5
			};
			dictionary[5] = new List<int>
			{
				1,
				2,
				3,
				4,
				5
			};
			RhythmShipChoseLevelViewDefine.rhythmShipLevelItemShow = dictionary;
			Dictionary<int, List<string>> dictionary2 = new Dictionary<int, List<string>>();
			dictionary2[1] = new List<string>
			{
				"",
				"",
				"",
				"Big",
				""
			};
			dictionary2[3] = new List<string>
			{
				"Big",
				"Big",
				"",
				"",
				"Big"
			};
			dictionary2[4] = new List<string>
			{
				"Small",
				"Big",
				"",
				"Big",
				"Small"
			};
			dictionary2[5] = new List<string>
			{
				"Small",
				"Small",
				"Small",
				"Small",
				"Small"
			};
			RhythmShipChoseLevelViewDefine.rhythmShipLevelItemSequenceName = dictionary2;
		}

		// Token: 0x06034239 RID: 213561 RVA: 0x00E95794 File Offset: 0x00E93994
		public static void ResetStaticDefaultValue()
		{
			RhythmShipChoseLevelViewDefine.rhythmShipLevelItemShow = null;
			RhythmShipChoseLevelViewDefine.rhythmShipLevelItemSequenceName = null;
		}

		// Token: 0x0401BA11 RID: 113169
		public const int LINKAGE_PLANET_ID = 5;

		// Token: 0x0401BA12 RID: 113170
		public const int LINKAGE_BTN_CD = 1;

		// Token: 0x0401BA13 RID: 113171
		public const int REFRESH_TIME = 500;

		// Token: 0x0401BA14 RID: 113172
		[Nullable(1)]
		public static Dictionary<int, List<int>> rhythmShipLevelItemShow;

		// Token: 0x0401BA15 RID: 113173
		[Nullable(1)]
		public static Dictionary<int, List<string>> rhythmShipLevelItemSequenceName;
	}
}
