using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006047 RID: 24647
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorDefine : IStaticVariableResetter
	{
		// Token: 0x0603E5C7 RID: 255431 RVA: 0x00F0FD6A File Offset: 0x00F0DF6A
		static SpringManorDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorDefine.CreateStaticDefaultValue), new Action(SpringManorDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603E5C8 RID: 255432 RVA: 0x00F0FD8C File Offset: 0x00F0DF8C
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

		// Token: 0x0603E5C9 RID: 255433 RVA: 0x00F0FE1D File Offset: 0x00F0E01D
		public static void ResetStaticDefaultValue()
		{
			SpringManorDefine.gameTypeList = null;
			SpringManorDefine.furnitureFunctionTypeList = null;
			SpringManorDefine.atmosphereLevelList = null;
			SpringManorDefine.atmosphereLevelUpSeqName = null;
		}

		// Token: 0x0402095A RID: 133466
		[Nullable(1)]
		public const string TEXT_ID_ATMOSPHERER_MAX = "Spring26_Atmosphere_Max";

		// Token: 0x0402095B RID: 133467
		public const int WEAPON_EXHIBIT_HELP_ID = 496;

		// Token: 0x0402095C RID: 133468
		public const int PHANTOM_EXHIBIT_HELP_ID = 497;

		// Token: 0x0402095D RID: 133469
		public const int ATMOSPHERE_HELP_ID = 495;

		// Token: 0x0402095E RID: 133470
		public const int LIMIT_TIME_REWARD_HELP_ID = 502;

		// Token: 0x0402095F RID: 133471
		public const int SPRING_QUEST_HELP_ID = 515;

		// Token: 0x04020960 RID: 133472
		public static List<ESpringFunctionType> gameTypeList;

		// Token: 0x04020961 RID: 133473
		public static List<ESpringFunctionType> furnitureFunctionTypeList;

		// Token: 0x04020962 RID: 133474
		public static List<int> atmosphereLevelList;

		// Token: 0x04020963 RID: 133475
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<string> atmosphereLevelUpSeqName;

		// Token: 0x04020964 RID: 133476
		public const int AUTO_END_TRACK_DISTANCE = 3;
	}
}
