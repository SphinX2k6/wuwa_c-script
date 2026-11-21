using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02000F63 RID: 3939
[NullableContext(2)]
[Nullable(0)]
public class ExploreProgressDefine : IStaticVariableResetter
{
	// Token: 0x06009E03 RID: 40451 RVA: 0x002EC894 File Offset: 0x002EAA94
	static ExploreProgressDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressDefine.CreateStaticDefaultValue), new Action(ExploreProgressDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06009E04 RID: 40452 RVA: 0x002EC8B4 File Offset: 0x002EAAB4
	public static void CreateStaticDefaultValue()
	{
		Dictionary<int, EMarkType> dictionary = new Dictionary<int, EMarkType>();
		dictionary[4] = EMarkType.SightSpot;
		dictionary[5] = EMarkType.FlyingHunter;
		dictionary[9] = EMarkType.Frostbite;
		ExploreProgressDefine.exploreType2MarkType = dictionary;
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		dictionary2[4] = 10;
		dictionary2[5] = 11;
		dictionary2[9] = 12;
		ExploreProgressDefine.exploreType2Config = dictionary2;
		Dictionary<EExploratoryDegree, EMarkType> dictionary3 = new Dictionary<EExploratoryDegree, EMarkType>();
		dictionary3[EExploratoryDegree.FlyingHunter] = EMarkType.FlyingHunter;
		dictionary3[EExploratoryDegree.Frostbite] = EMarkType.Frostbite;
		ExploreProgressDefine.exploratoryDegree2MarkType = dictionary3;
	}

	// Token: 0x06009E05 RID: 40453 RVA: 0x002EC92A File Offset: 0x002EAB2A
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressDefine.exploreType2MarkType = null;
		ExploreProgressDefine.exploreType2Config = null;
		ExploreProgressDefine.exploratoryDegree2MarkType = null;
	}

	// Token: 0x04005DCF RID: 24015
	public static Dictionary<int, EMarkType> exploreType2MarkType;

	// Token: 0x04005DD0 RID: 24016
	public static Dictionary<int, int> exploreType2Config;

	// Token: 0x04005DD1 RID: 24017
	public static Dictionary<EExploratoryDegree, EMarkType> exploratoryDegree2MarkType;

	// Token: 0x04005DD2 RID: 24018
	public const int DEFAULT_COUNTRY_ID = 1;

	// Token: 0x04005DD3 RID: 24019
	public const int MAP_MARK_ID = 3;

	// Token: 0x04005DD4 RID: 24020
	public const int MAP_MARK_TYPE = 8;

	// Token: 0x04005DD5 RID: 24021
	public const int AREA_LEVEL = 2;

	// Token: 0x04005DD6 RID: 24022
	public const int NONE_STATE_ID = 0;

	// Token: 0x04005DD7 RID: 24023
	public const int AREA_ICON_UNLOCK_COUNT = 4;

	// Token: 0x04005DD8 RID: 24024
	public const float AREA_ICON_UNLOCK_PERCENT = 25f;

	// Token: 0x04005DD9 RID: 24025
	public const int MAX_RECOMMEND_PLAY_POINT_SHOW_NUM = 2;

	// Token: 0x04005DDA RID: 24026
	public const int RECOMMEND_PLAY_DELAY_TIME = 20;
}
