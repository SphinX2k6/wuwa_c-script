using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02001AA4 RID: 6820
[NullableContext(2)]
[Nullable(0)]
public class ExploreProgressDefine : IStaticVariableResetter
{
	// Token: 0x0600C9F2 RID: 51698 RVA: 0x002E1744 File Offset: 0x002DF944
	static ExploreProgressDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressDefine.CreateStaticDefaultValue), new Action(ExploreProgressDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600C9F3 RID: 51699 RVA: 0x002E1764 File Offset: 0x002DF964
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

	// Token: 0x0600C9F4 RID: 51700 RVA: 0x002E17DA File Offset: 0x002DF9DA
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressDefine.exploreType2MarkType = null;
		ExploreProgressDefine.exploreType2Config = null;
		ExploreProgressDefine.exploratoryDegree2MarkType = null;
	}

	// Token: 0x04005D00 RID: 23808
	public static Dictionary<int, EMarkType> exploreType2MarkType;

	// Token: 0x04005D01 RID: 23809
	public static Dictionary<int, int> exploreType2Config;

	// Token: 0x04005D02 RID: 23810
	public static Dictionary<EExploratoryDegree, EMarkType> exploratoryDegree2MarkType;

	// Token: 0x04005D03 RID: 23811
	public const int DEFAULT_COUNTRY_ID = 1;

	// Token: 0x04005D04 RID: 23812
	public const int MAP_MARK_ID = 3;

	// Token: 0x04005D05 RID: 23813
	public const int MAP_MARK_TYPE = 8;

	// Token: 0x04005D06 RID: 23814
	public const int AREA_LEVEL = 2;

	// Token: 0x04005D07 RID: 23815
	public const int NONE_STATE_ID = 0;

	// Token: 0x04005D08 RID: 23816
	public const int AREA_ICON_UNLOCK_COUNT = 4;

	// Token: 0x04005D09 RID: 23817
	public const float AREA_ICON_UNLOCK_PERCENT = 25f;

	// Token: 0x04005D0A RID: 23818
	public const int MAX_RECOMMEND_PLAY_POINT_SHOW_NUM = 2;

	// Token: 0x04005D0B RID: 23819
	public const int RECOMMEND_PLAY_DELAY_TIME = 20;
}
