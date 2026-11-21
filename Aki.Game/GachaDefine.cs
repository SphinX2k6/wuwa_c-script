using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001136 RID: 4406
[NullableContext(1)]
[Nullable(0)]
public class GachaDefine
{
	// Token: 0x0600AFF6 RID: 45046 RVA: 0x0033E08C File Offset: 0x0033C28C
	// Note: this type is marked as 'beforefieldinit'.
	static GachaDefine()
	{
		Dictionary<GachaDefine.EAwardType, string> dictionary = new Dictionary<GachaDefine.EAwardType, string>();
		dictionary[GachaDefine.EAwardType.Role] = "Role";
		dictionary[GachaDefine.EAwardType.Weapon] = "Weapon";
		GachaDefine.textKeyMap = dictionary;
	}

	// Token: 0x0400659C RID: 26012
	public const string GACHA_ROLE_CAMERA = "1035";

	// Token: 0x0400659D RID: 26013
	public const string GACHA_ROLE_CAMERA_TARGET = "-1035";

	// Token: 0x0400659E RID: 26014
	public const string GACHA_RECORD_CAMERA = "1040";

	// Token: 0x0400659F RID: 26015
	public const string GACHA_WEAPON_CAMERA = "1041_New";

	// Token: 0x040065A0 RID: 26016
	public const string GACHA_WEAPON_CAMERA_TARGET = "-1041";

	// Token: 0x040065A1 RID: 26017
	public const string CACHA_RESUOT_CAMERA = "1043";

	// Token: 0x040065A2 RID: 26018
	public const string GACHA_BLEND_CAMERA = "10007";

	// Token: 0x040065A3 RID: 26019
	public const string GACHA_ROLE_CASE = "RoleCase";

	// Token: 0x040065A4 RID: 26020
	public const string GACHA_WEAPON_CASE = "WeaponCase";

	// Token: 0x040065A5 RID: 26021
	public const string GACHA_3D_SCENE_PATH = "/Game/Aki/Map/Level/Function/ChouKa/Art/Instance_ChouKa_01";

	// Token: 0x040065A6 RID: 26022
	public const int ROLE_FUNCTION_ITEM = 5;

	// Token: 0x040065A7 RID: 26023
	public const int GACHA_ONE = 1;

	// Token: 0x040065A8 RID: 26024
	public const int GACHA_TEN = 10;

	// Token: 0x040065A9 RID: 26025
	public const string TOTAL_REST_COUNT = "GachaTotalRestCount";

	// Token: 0x040065AA RID: 26026
	public const string POOL_TODAY_REST_COUNT = "GachaPoolTodayRestCount";

	// Token: 0x040065AB RID: 26027
	public const string POOL_TOTAL_REST_COUNT = "GachaPoolTotalRestCount";

	// Token: 0x040065AC RID: 26028
	public const string POOL_RESIDENT = "PoolResident";

	// Token: 0x040065AD RID: 26029
	public const string POOL_TIME_LIMIT = "PoolTimeLimit";

	// Token: 0x040065AE RID: 26030
	public const string GACHA_TEXT = "GachaText";

	// Token: 0x040065AF RID: 26031
	public const string GACHA_RECORD = "GachaRecord";

	// Token: 0x040065B0 RID: 26032
	public const string GACHA_TYPE = "GachaType";

	// Token: 0x040065B1 RID: 26033
	public const string GACHA_RECORD_LIMIT = "GachaRecordLimit";

	// Token: 0x040065B2 RID: 26034
	public const string GACHA_NO_RECORD = "GachaNoRecord";

	// Token: 0x040065B3 RID: 26035
	public static readonly IReadOnlyDictionary<GachaDefine.EAwardType, string> textKeyMap;

	// Token: 0x020073BF RID: 29631
	[NullableContext(0)]
	public enum EAwardType
	{
		// Token: 0x04025ADD RID: 154333
		Role,
		// Token: 0x04025ADE RID: 154334
		Weapon
	}

	// Token: 0x020073C0 RID: 29632
	[NullableContext(0)]
	public enum EGachaViewType
	{
		// Token: 0x04025AE0 RID: 154336
		None,
		// Token: 0x04025AE1 RID: 154337
		NewPlayer,
		// Token: 0x04025AE2 RID: 154338
		RoleUp,
		// Token: 0x04025AE3 RID: 154339
		WeaponUp,
		// Token: 0x04025AE4 RID: 154340
		RoleCommon,
		// Token: 0x04025AE5 RID: 154341
		WeaponCommon,
		// Token: 0x04025AE6 RID: 154342
		NewPlayerCustom,
		// Token: 0x04025AE7 RID: 154343
		AnniversaryRole,
		// Token: 0x04025AE8 RID: 154344
		AnniversaryWeapon,
		// Token: 0x04025AE9 RID: 154345
		CarnivalRole,
		// Token: 0x04025AEA RID: 154346
		CarnivalWeapon,
		// Token: 0x04025AEB RID: 154347
		CyberRole,
		// Token: 0x04025AEC RID: 154348
		CyberWeapon,
		// Token: 0x04025AED RID: 154349
		OldCarnivalRole,
		// Token: 0x04025AEE RID: 154350
		OldCarnivalWeapon
	}

	// Token: 0x020073C1 RID: 29633
	[NullableContext(0)]
	public enum EItemQuality
	{
		// Token: 0x04025AF0 RID: 154352
		White = 1,
		// Token: 0x04025AF1 RID: 154353
		Green,
		// Token: 0x04025AF2 RID: 154354
		Blue,
		// Token: 0x04025AF3 RID: 154355
		Purple,
		// Token: 0x04025AF4 RID: 154356
		Gold
	}
}
