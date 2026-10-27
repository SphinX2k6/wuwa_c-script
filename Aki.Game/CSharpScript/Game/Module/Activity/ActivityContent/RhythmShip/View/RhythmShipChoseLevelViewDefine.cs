using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006217 RID: 25111
	public class RhythmShipChoseLevelViewDefine : IStaticVariableResetter
	{
		// Token: 0x0603F576 RID: 259446 RVA: 0x00F4E662 File Offset: 0x00F4C862
		static RhythmShipChoseLevelViewDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipChoseLevelViewDefine.CreateStaticDefaultValue), new Action(RhythmShipChoseLevelViewDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603F577 RID: 259447 RVA: 0x00F4E684 File Offset: 0x00F4C884
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

		// Token: 0x0603F578 RID: 259448 RVA: 0x00F4E83C File Offset: 0x00F4CA3C
		public static void ResetStaticDefaultValue()
		{
			RhythmShipChoseLevelViewDefine.rhythmShipLevelItemShow = null;
			RhythmShipChoseLevelViewDefine.rhythmShipLevelItemSequenceName = null;
		}

		// Token: 0x040210E2 RID: 135394
		public const int LINKAGE_PLANET_ID = 5;

		// Token: 0x040210E3 RID: 135395
		public const int LINKAGE_BTN_CD = 1;

		// Token: 0x040210E4 RID: 135396
		public const int REFRESH_TIME = 500;

		// Token: 0x040210E5 RID: 135397
		[Nullable(1)]
		public static Dictionary<int, List<int>> rhythmShipLevelItemShow;

		// Token: 0x040210E6 RID: 135398
		[Nullable(1)]
		public static Dictionary<int, List<string>> rhythmShipLevelItemSequenceName;
	}
}
