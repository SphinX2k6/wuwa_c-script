using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001A1D RID: 6685
public class DangoAbyssDefine : IStaticVariableResetter
{
	// Token: 0x0600C435 RID: 50229 RVA: 0x002C6CC5 File Offset: 0x002C4EC5
	static DangoAbyssDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssDefine.CreateStaticDefaultValue), new Action(DangoAbyssDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600C436 RID: 50230 RVA: 0x002C6CE4 File Offset: 0x002C4EE4
	public static void CreateStaticDefaultValue()
	{
		DangoAbyssDefine.textSlotType = new Dictionary<DangoAbyssDefine.ESlotType, string>
		{
			{
				DangoAbyssDefine.ESlotType.Normal,
				"Text_NormalPlugin_Text"
			},
			{
				DangoAbyssDefine.ESlotType.Core,
				"Text_CorePlugin_Text"
			},
			{
				DangoAbyssDefine.ESlotType.Passive,
				"Text_PassivePlugin_Text"
			}
		};
		DangoAbyssDefine.textPluginType = new Dictionary<DangoAbyssDefine.ESlotType, string>
		{
			{
				DangoAbyssDefine.ESlotType.Normal,
				"Text_NormalPluginType_Text"
			},
			{
				DangoAbyssDefine.ESlotType.Core,
				"Text_CorePluginType_Text"
			},
			{
				DangoAbyssDefine.ESlotType.Passive,
				"Text_PassivePluginType_Text"
			}
		};
		DangoAbyssDefine.iconSizeBySlotType = new Dictionary<DangoAbyssDefine.ESlotType, int>
		{
			{
				DangoAbyssDefine.ESlotType.Normal,
				64
			},
			{
				DangoAbyssDefine.ESlotType.Core,
				96
			},
			{
				DangoAbyssDefine.ESlotType.Passive,
				87
			}
		};
	}

	// Token: 0x0600C437 RID: 50231 RVA: 0x002C6D72 File Offset: 0x002C4F72
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssDefine.textSlotType = null;
		DangoAbyssDefine.textPluginType = null;
		DangoAbyssDefine.iconSizeBySlotType = null;
	}

	// Token: 0x04005A93 RID: 23187
	public const int BADDANGOID = 999;

	// Token: 0x04005A94 RID: 23188
	public const int SLOT_COUNT = 9;

	// Token: 0x04005A95 RID: 23189
	public const int CURRENCY_ITEM_EXP_ID = 80200001;

	// Token: 0x04005A96 RID: 23190
	public const int CURRENCY_ITEM_TOKEN_ID = 80200002;

	// Token: 0x04005A97 RID: 23191
	public const int CURRENCY_ITEM_KEY_ID = 80200003;

	// Token: 0x04005A98 RID: 23192
	[Nullable(1)]
	public static Dictionary<DangoAbyssDefine.ESlotType, string> textSlotType;

	// Token: 0x04005A99 RID: 23193
	[Nullable(1)]
	public static Dictionary<DangoAbyssDefine.ESlotType, string> textPluginType;

	// Token: 0x04005A9A RID: 23194
	[Nullable(1)]
	public const string TEXT_EQUIP_ERROR_DANGO = "Text_DangoEquipErrorDango_Text";

	// Token: 0x04005A9B RID: 23195
	[Nullable(1)]
	public const string TEXT_EQUIP_SAME = "Text_DangoEquipSame_Text";

	// Token: 0x04005A9C RID: 23196
	[Nullable(1)]
	public const string TEXT_EQUIP_REPEAT = "Text_DangoEquipRepeat_Text";

	// Token: 0x04005A9D RID: 23197
	[Nullable(1)]
	public const string TEXT_DANGO_LEVEL = "Text_DangoLevel_Text";

	// Token: 0x04005A9E RID: 23198
	[Nullable(1)]
	public const string TEXT_PLUGIN_COUNT = "Text_DangoPluginCount_Text";

	// Token: 0x04005A9F RID: 23199
	[Nullable(1)]
	public const string TEXT_RECOVERY_SELECT = "Text_RecoverySelect_Text";

	// Token: 0x04005AA0 RID: 23200
	[Nullable(1)]
	public const string TEXT_RECOVERY_TIMES = "Text_RecoveryTimes_Text";

	// Token: 0x04005AA1 RID: 23201
	public const int RECOVERY_NEEDS_COUNT = 1;

	// Token: 0x04005AA2 RID: 23202
	public const int ROLE_ATTRIBUTE_LENGTH = 6;

	// Token: 0x04005AA3 RID: 23203
	[Nullable(1)]
	public static Dictionary<DangoAbyssDefine.ESlotType, int> iconSizeBySlotType;

	// Token: 0x02007F57 RID: 32599
	public class DangoListRoleData
	{
		// Token: 0x04029933 RID: 170291
		public int Id;

		// Token: 0x04029934 RID: 170292
		[Nullable(2)]
		public AbyssDangoRoleData Data;

		// Token: 0x04029935 RID: 170293
		[Nullable(1)]
		public Action<DangoAbyssDefine.DangoListRoleData> OnClickCallBack = delegate(DangoAbyssDefine.DangoListRoleData data)
		{
		};
	}

	// Token: 0x02007F58 RID: 32600
	public enum EAbyssItemTipsState
	{
		// Token: 0x04029937 RID: 170295
		None,
		// Token: 0x04029938 RID: 170296
		ErrorDango,
		// Token: 0x04029939 RID: 170297
		DiffDango,
		// Token: 0x0402993A RID: 170298
		TakeOff,
		// Token: 0x0402993B RID: 170299
		Switch,
		// Token: 0x0402993C RID: 170300
		Move,
		// Token: 0x0402993D RID: 170301
		Replace,
		// Token: 0x0402993E RID: 170302
		PutOn,
		// Token: 0x0402993F RID: 170303
		Same,
		// Token: 0x04029940 RID: 170304
		Repeat
	}

	// Token: 0x02007F59 RID: 32601
	public class IAbyssItemTipsData
	{
		// Token: 0x04029941 RID: 170305
		public int DangoId;

		// Token: 0x04029942 RID: 170306
		public int SlotIndex;

		// Token: 0x04029943 RID: 170307
		public int IncId;
	}

	// Token: 0x02007F5A RID: 32602
	public enum ETagAddType
	{
		// Token: 0x04029945 RID: 170309
		Value = 1,
		// Token: 0x04029946 RID: 170310
		Ratio,
		// Token: 0x04029947 RID: 170311
		Seconds,
		// Token: 0x04029948 RID: 170312
		Level,
		// Token: 0x04029949 RID: 170313
		Name
	}

	// Token: 0x02007F5B RID: 32603
	public enum ESlotType
	{
		// Token: 0x0402994B RID: 170315
		Normal,
		// Token: 0x0402994C RID: 170316
		Core,
		// Token: 0x0402994D RID: 170317
		Passive
	}

	// Token: 0x02007F5C RID: 32604
	public class DangoAbyssTagData
	{
		// Token: 0x0402994E RID: 170318
		public int TagId;

		// Token: 0x0402994F RID: 170319
		public int Value;
	}

	// Token: 0x02007F5D RID: 32605
	public enum ETagDataGetType
	{
		// Token: 0x04029951 RID: 170321
		All,
		// Token: 0x04029952 RID: 170322
		Valid,
		// Token: 0x04029953 RID: 170323
		InValid
	}

	// Token: 0x02007F5E RID: 32606
	[NullableContext(2)]
	[Nullable(0)]
	public class EquipViewAttributeData
	{
		// Token: 0x04029954 RID: 170324
		public bool IsValid;

		// Token: 0x04029955 RID: 170325
		public AttrListScrollData Attribute;

		// Token: 0x04029956 RID: 170326
		public DangoAbyssDefine.DangoAbyssTagData Tag;

		// Token: 0x04029957 RID: 170327
		public bool IsChange;
	}

	// Token: 0x02007F5F RID: 32607
	[NullableContext(1)]
	[Nullable(0)]
	public class IDangoAbyssActorData
	{
		// Token: 0x04029958 RID: 170328
		public int DangoId;

		// Token: 0x04029959 RID: 170329
		public int MeshId;

		// Token: 0x0402995A RID: 170330
		public string DangoPointCase;

		// Token: 0x0402995B RID: 170331
		public FTransform? Transform;

		// Token: 0x0402995C RID: 170332
		public string StandAnimationName;
	}

	// Token: 0x02007F60 RID: 32608
	[NullableContext(1)]
	[Nullable(0)]
	public class IDangoUnlockData
	{
		// Token: 0x0402995D RID: 170333
		public int DangoId;

		// Token: 0x0402995E RID: 170334
		public int DangoLevel;

		// Token: 0x0402995F RID: 170335
		public string UnlockTitle;

		// Token: 0x04029960 RID: 170336
		public string UnlockSubTitle;

		// Token: 0x04029961 RID: 170337
		public string UnlockWutheringWaveTitleSpritePath;

		// Token: 0x04029962 RID: 170338
		public string DetailName;

		// Token: 0x04029963 RID: 170339
		public string DetailDialog;
	}

	// Token: 0x02007F61 RID: 32609
	public enum ESlotSwitchType
	{
		// Token: 0x04029965 RID: 170341
		None,
		// Token: 0x04029966 RID: 170342
		TakeOff,
		// Token: 0x04029967 RID: 170343
		Replace,
		// Token: 0x04029968 RID: 170344
		PutOn
	}

	// Token: 0x02007F62 RID: 32610
	public class IRecoveryRewardData
	{
		// Token: 0x04029969 RID: 170345
		public int ItemId;

		// Token: 0x0402996A RID: 170346
		public int Count;

		// Token: 0x0402996B RID: 170347
		public int? IncId;
	}

	// Token: 0x02007F63 RID: 32611
	public class IAbyssLikeRecord
	{
		// Token: 0x0402996C RID: 170348
		public int PlayerId;

		// Token: 0x0402996D RID: 170349
		[Nullable(1)]
		public List<int> LikedPlayerIdList;
	}
}
