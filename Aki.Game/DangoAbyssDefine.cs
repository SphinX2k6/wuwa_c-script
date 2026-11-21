using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000EDC RID: 3804
public class DangoAbyssDefine : IStaticVariableResetter
{
	// Token: 0x06009845 RID: 38981 RVA: 0x002D1D79 File Offset: 0x002CFF79
	static DangoAbyssDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssDefine.CreateStaticDefaultValue), new Action(DangoAbyssDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06009846 RID: 38982 RVA: 0x002D1D98 File Offset: 0x002CFF98
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

	// Token: 0x06009847 RID: 38983 RVA: 0x002D1E26 File Offset: 0x002D0026
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssDefine.textSlotType = null;
		DangoAbyssDefine.textPluginType = null;
		DangoAbyssDefine.iconSizeBySlotType = null;
	}

	// Token: 0x04005B62 RID: 23394
	public const int BADDANGOID = 999;

	// Token: 0x04005B63 RID: 23395
	public const int SLOT_COUNT = 9;

	// Token: 0x04005B64 RID: 23396
	public const int CURRENCY_ITEM_EXP_ID = 80200001;

	// Token: 0x04005B65 RID: 23397
	public const int CURRENCY_ITEM_TOKEN_ID = 80200002;

	// Token: 0x04005B66 RID: 23398
	public const int CURRENCY_ITEM_KEY_ID = 80200003;

	// Token: 0x04005B67 RID: 23399
	[Nullable(1)]
	public static Dictionary<DangoAbyssDefine.ESlotType, string> textSlotType;

	// Token: 0x04005B68 RID: 23400
	[Nullable(1)]
	public static Dictionary<DangoAbyssDefine.ESlotType, string> textPluginType;

	// Token: 0x04005B69 RID: 23401
	[Nullable(1)]
	public const string TEXT_EQUIP_ERROR_DANGO = "Text_DangoEquipErrorDango_Text";

	// Token: 0x04005B6A RID: 23402
	[Nullable(1)]
	public const string TEXT_EQUIP_SAME = "Text_DangoEquipSame_Text";

	// Token: 0x04005B6B RID: 23403
	[Nullable(1)]
	public const string TEXT_EQUIP_REPEAT = "Text_DangoEquipRepeat_Text";

	// Token: 0x04005B6C RID: 23404
	[Nullable(1)]
	public const string TEXT_DANGO_LEVEL = "Text_DangoLevel_Text";

	// Token: 0x04005B6D RID: 23405
	[Nullable(1)]
	public const string TEXT_PLUGIN_COUNT = "Text_DangoPluginCount_Text";

	// Token: 0x04005B6E RID: 23406
	[Nullable(1)]
	public const string TEXT_RECOVERY_SELECT = "Text_RecoverySelect_Text";

	// Token: 0x04005B6F RID: 23407
	[Nullable(1)]
	public const string TEXT_RECOVERY_TIMES = "Text_RecoveryTimes_Text";

	// Token: 0x04005B70 RID: 23408
	public const int RECOVERY_NEEDS_COUNT = 1;

	// Token: 0x04005B71 RID: 23409
	public const int ROLE_ATTRIBUTE_LENGTH = 6;

	// Token: 0x04005B72 RID: 23410
	[Nullable(1)]
	public static Dictionary<DangoAbyssDefine.ESlotType, int> iconSizeBySlotType;

	// Token: 0x020070E6 RID: 28902
	public class DangoListRoleData
	{
		// Token: 0x04024C70 RID: 150640
		public int Id;

		// Token: 0x04024C71 RID: 150641
		[Nullable(2)]
		public AbyssDangoRoleData Data;

		// Token: 0x04024C72 RID: 150642
		[Nullable(1)]
		public Action<DangoAbyssDefine.DangoListRoleData> OnClickCallBack = delegate(DangoAbyssDefine.DangoListRoleData data)
		{
		};
	}

	// Token: 0x020070E7 RID: 28903
	public enum EAbyssItemTipsState
	{
		// Token: 0x04024C74 RID: 150644
		None,
		// Token: 0x04024C75 RID: 150645
		ErrorDango,
		// Token: 0x04024C76 RID: 150646
		DiffDango,
		// Token: 0x04024C77 RID: 150647
		TakeOff,
		// Token: 0x04024C78 RID: 150648
		Switch,
		// Token: 0x04024C79 RID: 150649
		Move,
		// Token: 0x04024C7A RID: 150650
		Replace,
		// Token: 0x04024C7B RID: 150651
		PutOn,
		// Token: 0x04024C7C RID: 150652
		Same,
		// Token: 0x04024C7D RID: 150653
		Repeat
	}

	// Token: 0x020070E8 RID: 28904
	public class IAbyssItemTipsData
	{
		// Token: 0x04024C7E RID: 150654
		public int DangoId;

		// Token: 0x04024C7F RID: 150655
		public int SlotIndex;

		// Token: 0x04024C80 RID: 150656
		public int IncId;
	}

	// Token: 0x020070E9 RID: 28905
	public enum ETagAddType
	{
		// Token: 0x04024C82 RID: 150658
		Value = 1,
		// Token: 0x04024C83 RID: 150659
		Ratio,
		// Token: 0x04024C84 RID: 150660
		Seconds,
		// Token: 0x04024C85 RID: 150661
		Level,
		// Token: 0x04024C86 RID: 150662
		Name
	}

	// Token: 0x020070EA RID: 28906
	public enum ESlotType
	{
		// Token: 0x04024C88 RID: 150664
		Normal,
		// Token: 0x04024C89 RID: 150665
		Core,
		// Token: 0x04024C8A RID: 150666
		Passive
	}

	// Token: 0x020070EB RID: 28907
	public class DangoAbyssTagData
	{
		// Token: 0x04024C8B RID: 150667
		public int TagId;

		// Token: 0x04024C8C RID: 150668
		public int Value;
	}

	// Token: 0x020070EC RID: 28908
	public enum ETagDataGetType
	{
		// Token: 0x04024C8E RID: 150670
		All,
		// Token: 0x04024C8F RID: 150671
		Valid,
		// Token: 0x04024C90 RID: 150672
		InValid
	}

	// Token: 0x020070ED RID: 28909
	[NullableContext(2)]
	[Nullable(0)]
	public class EquipViewAttributeData
	{
		// Token: 0x04024C91 RID: 150673
		public bool IsValid;

		// Token: 0x04024C92 RID: 150674
		public AttrListScrollData Attribute;

		// Token: 0x04024C93 RID: 150675
		public DangoAbyssDefine.DangoAbyssTagData Tag;

		// Token: 0x04024C94 RID: 150676
		public bool IsChange;
	}

	// Token: 0x020070EE RID: 28910
	[NullableContext(1)]
	[Nullable(0)]
	public class IDangoAbyssActorData
	{
		// Token: 0x04024C95 RID: 150677
		public int DangoId;

		// Token: 0x04024C96 RID: 150678
		public int MeshId;

		// Token: 0x04024C97 RID: 150679
		public string DangoPointCase;

		// Token: 0x04024C98 RID: 150680
		public FTransform? Transform;

		// Token: 0x04024C99 RID: 150681
		public string StandAnimationName;
	}

	// Token: 0x020070EF RID: 28911
	[NullableContext(1)]
	[Nullable(0)]
	public class IDangoUnlockData
	{
		// Token: 0x04024C9A RID: 150682
		public int DangoId;

		// Token: 0x04024C9B RID: 150683
		public int DangoLevel;

		// Token: 0x04024C9C RID: 150684
		public string UnlockTitle;

		// Token: 0x04024C9D RID: 150685
		public string UnlockSubTitle;

		// Token: 0x04024C9E RID: 150686
		public string UnlockWutheringWaveTitleSpritePath;

		// Token: 0x04024C9F RID: 150687
		public string DetailName;

		// Token: 0x04024CA0 RID: 150688
		public string DetailDialog;
	}

	// Token: 0x020070F0 RID: 28912
	public enum ESlotSwitchType
	{
		// Token: 0x04024CA2 RID: 150690
		None,
		// Token: 0x04024CA3 RID: 150691
		TakeOff,
		// Token: 0x04024CA4 RID: 150692
		Replace,
		// Token: 0x04024CA5 RID: 150693
		PutOn
	}

	// Token: 0x020070F1 RID: 28913
	public class IRecoveryRewardData
	{
		// Token: 0x04024CA6 RID: 150694
		public int ItemId;

		// Token: 0x04024CA7 RID: 150695
		public int Count;

		// Token: 0x04024CA8 RID: 150696
		public int? IncId;
	}

	// Token: 0x020070F2 RID: 28914
	public class IAbyssLikeRecord
	{
		// Token: 0x04024CA9 RID: 150697
		public int PlayerId;

		// Token: 0x04024CAA RID: 150698
		[Nullable(1)]
		public List<int> LikedPlayerIdList;
	}
}
