using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C77 RID: 7287
[NullableContext(1)]
[Nullable(0)]
public class GachaDefine
{
	// Token: 0x0600DBE0 RID: 56288 RVA: 0x00332C2C File Offset: 0x00330E2C
	// Note: this type is marked as 'beforefieldinit'.
	static GachaDefine()
	{
		Dictionary<GachaDefine.EAwardType, string> dictionary = new Dictionary<GachaDefine.EAwardType, string>();
		dictionary[GachaDefine.EAwardType.Role] = "Role";
		dictionary[GachaDefine.EAwardType.Weapon] = "Weapon";
		GachaDefine.textKeyMap = dictionary;
	}

	// Token: 0x040064CA RID: 25802
	public const string GACHA_ROLE_CAMERA = "1035";

	// Token: 0x040064CB RID: 25803
	public const string GACHA_ROLE_CAMERA_TARGET = "-1035";

	// Token: 0x040064CC RID: 25804
	public const string GACHA_RECORD_CAMERA = "1040";

	// Token: 0x040064CD RID: 25805
	public const string GACHA_WEAPON_CAMERA = "1041_New";

	// Token: 0x040064CE RID: 25806
	public const string GACHA_WEAPON_CAMERA_TARGET = "-1041";

	// Token: 0x040064CF RID: 25807
	public const string CACHA_RESUOT_CAMERA = "1043";

	// Token: 0x040064D0 RID: 25808
	public const string GACHA_BLEND_CAMERA = "10007";

	// Token: 0x040064D1 RID: 25809
	public const string GACHA_ROLE_CASE = "RoleCase";

	// Token: 0x040064D2 RID: 25810
	public const string GACHA_WEAPON_CASE = "WeaponCase";

	// Token: 0x040064D3 RID: 25811
	public const string GACHA_3D_SCENE_PATH = "/Game/Aki/Map/Level/Function/ChouKa/Art/Instance_ChouKa_01";

	// Token: 0x040064D4 RID: 25812
	public const int ROLE_FUNCTION_ITEM = 5;

	// Token: 0x040064D5 RID: 25813
	public const int GACHA_ONE = 1;

	// Token: 0x040064D6 RID: 25814
	public const int GACHA_TEN = 10;

	// Token: 0x040064D7 RID: 25815
	public const string TOTAL_REST_COUNT = "GachaTotalRestCount";

	// Token: 0x040064D8 RID: 25816
	public const string POOL_TODAY_REST_COUNT = "GachaPoolTodayRestCount";

	// Token: 0x040064D9 RID: 25817
	public const string POOL_TOTAL_REST_COUNT = "GachaPoolTotalRestCount";

	// Token: 0x040064DA RID: 25818
	public const string POOL_RESIDENT = "PoolResident";

	// Token: 0x040064DB RID: 25819
	public const string POOL_TIME_LIMIT = "PoolTimeLimit";

	// Token: 0x040064DC RID: 25820
	public const string GACHA_TEXT = "GachaText";

	// Token: 0x040064DD RID: 25821
	public const string GACHA_RECORD = "GachaRecord";

	// Token: 0x040064DE RID: 25822
	public const string GACHA_TYPE = "GachaType";

	// Token: 0x040064DF RID: 25823
	public const string GACHA_RECORD_LIMIT = "GachaRecordLimit";

	// Token: 0x040064E0 RID: 25824
	public const string GACHA_NO_RECORD = "GachaNoRecord";

	// Token: 0x040064E1 RID: 25825
	public static readonly IReadOnlyDictionary<GachaDefine.EAwardType, string> textKeyMap;

	// Token: 0x02008236 RID: 33334
	[NullableContext(0)]
	public enum EAwardType
	{
		// Token: 0x0402A7B7 RID: 174007
		Role,
		// Token: 0x0402A7B8 RID: 174008
		Weapon
	}

	// Token: 0x02008237 RID: 33335
	[NullableContext(0)]
	public enum EGachaViewType
	{
		// Token: 0x0402A7BA RID: 174010
		None,
		// Token: 0x0402A7BB RID: 174011
		NewPlayer,
		// Token: 0x0402A7BC RID: 174012
		RoleUp,
		// Token: 0x0402A7BD RID: 174013
		WeaponUp,
		// Token: 0x0402A7BE RID: 174014
		RoleCommon,
		// Token: 0x0402A7BF RID: 174015
		WeaponCommon,
		// Token: 0x0402A7C0 RID: 174016
		NewPlayerCustom,
		// Token: 0x0402A7C1 RID: 174017
		AnniversaryRole,
		// Token: 0x0402A7C2 RID: 174018
		AnniversaryWeapon,
		// Token: 0x0402A7C3 RID: 174019
		CarnivalRole,
		// Token: 0x0402A7C4 RID: 174020
		CarnivalWeapon,
		// Token: 0x0402A7C5 RID: 174021
		CyberRole,
		// Token: 0x0402A7C6 RID: 174022
		CyberWeapon,
		// Token: 0x0402A7C7 RID: 174023
		OldCarnivalRole,
		// Token: 0x0402A7C8 RID: 174024
		OldCarnivalWeapon
	}

	// Token: 0x02008238 RID: 33336
	[NullableContext(0)]
	public enum EItemQuality
	{
		// Token: 0x0402A7CA RID: 174026
		White = 1,
		// Token: 0x0402A7CB RID: 174027
		Green,
		// Token: 0x0402A7CC RID: 174028
		Blue,
		// Token: 0x0402A7CD RID: 174029
		Purple,
		// Token: 0x0402A7CE RID: 174030
		Gold
	}
}
