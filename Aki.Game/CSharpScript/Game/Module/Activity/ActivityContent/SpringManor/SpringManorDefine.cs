using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FC5 RID: 20421
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorDefine : IStaticVariableResetter
	{
		// Token: 0x0603328B RID: 209547 RVA: 0x00E56B2E File Offset: 0x00E54D2E
		static SpringManorDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorDefine.CreateStaticDefaultValue), new Action(SpringManorDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603328C RID: 209548 RVA: 0x00E56B50 File Offset: 0x00E54D50
		public static void CreateStaticDefaultValue()
		{
			SpringManorDefine.gameTypeList = new List<ESpringFunctionType>
			{
				ESpringFunctionType.Card,
				ESpringFunctionType.Drink,
				ESpringFunctionType.Publicity,
				ESpringFunctionType.Draw
			};
			SpringManorDefine.furnitureFunctionTypeList = new List<ESpringFunctionType>
			{
				ESpringFunctionType.DIY,
				ESpringFunctionType.DIYShop,
				ESpringFunctionType.Preset,
				ESpringFunctionType.Exhibition
			};
			SpringManorDefine.atmosphereLevelList = new List<int>
			{
				3,
				6
			};
			SpringManorDefine.atmosphereLevelUpSeqName = new List<string>
			{
				"LevelUp1",
				"LevelUp2"
			};
		}

		// Token: 0x0603328D RID: 209549 RVA: 0x00E56BE1 File Offset: 0x00E54DE1
		public static void ResetStaticDefaultValue()
		{
			SpringManorDefine.gameTypeList = null;
			SpringManorDefine.furnitureFunctionTypeList = null;
			SpringManorDefine.atmosphereLevelList = null;
			SpringManorDefine.atmosphereLevelUpSeqName = null;
		}

		// Token: 0x0401B287 RID: 111239
		[Nullable(1)]
		public const string TEXT_ID_ATMOSPHERER_MAX = "Spring26_Atmosphere_Max";

		// Token: 0x0401B288 RID: 111240
		public const int WEAPON_EXHIBIT_HELP_ID = 496;

		// Token: 0x0401B289 RID: 111241
		public const int PHANTOM_EXHIBIT_HELP_ID = 497;

		// Token: 0x0401B28A RID: 111242
		public const int ATMOSPHERE_HELP_ID = 495;

		// Token: 0x0401B28B RID: 111243
		public const int LIMIT_TIME_REWARD_HELP_ID = 502;

		// Token: 0x0401B28C RID: 111244
		public const int SPRING_QUEST_HELP_ID = 515;

		// Token: 0x0401B28D RID: 111245
		public static List<ESpringFunctionType> gameTypeList;

		// Token: 0x0401B28E RID: 111246
		public static List<ESpringFunctionType> furnitureFunctionTypeList;

		// Token: 0x0401B28F RID: 111247
		public static List<int> atmosphereLevelList;

		// Token: 0x0401B290 RID: 111248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<string> atmosphereLevelUpSeqName;

		// Token: 0x0401B291 RID: 111249
		public const int AUTO_END_TRACK_DISTANCE = 3;
	}
}
