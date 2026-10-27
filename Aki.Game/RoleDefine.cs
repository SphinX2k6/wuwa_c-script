using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020027BC RID: 10172
[NullableContext(1)]
[Nullable(0)]
public class RoleDefine : IStaticVariableResetter
{
	// Token: 0x06014EE7 RID: 85735 RVA: 0x00550979 File Offset: 0x0054EB79
	static RoleDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDefine.CreateStaticDefaultValue), new Action(RoleDefine.ResetStaticDefaultValue));
	}

	// Token: 0x17001B2D RID: 6957
	// (get) Token: 0x06014EE8 RID: 85736 RVA: 0x00550998 File Offset: 0x0054EB98
	public static EUiTabViewName[] UI_ROLE_CAN_ROTATE_TABVIEW
	{
		get
		{
			return RoleDefine._UI_ROLE_CAN_ROTATE_TABVIEW;
		}
	}

	// Token: 0x17001B2E RID: 6958
	// (get) Token: 0x06014EE9 RID: 85737 RVA: 0x0055099F File Offset: 0x0054EB9F
	public static Dictionary<ETrialRoleType, string> trialRoleHexColor
	{
		get
		{
			return RoleDefine._trialRoleHexColor;
		}
	}

	// Token: 0x17001B2F RID: 6959
	// (get) Token: 0x06014EEA RID: 85738 RVA: 0x005509A6 File Offset: 0x0054EBA6
	public static Dictionary<ERoleViewSource, bool> RoleViewSourceHideRoleChange
	{
		get
		{
			return RoleDefine._RoleViewSourceHideRoleChange;
		}
	}

	// Token: 0x17001B30 RID: 6960
	// (get) Token: 0x06014EEB RID: 85739 RVA: 0x005509AD File Offset: 0x0054EBAD
	public static Dictionary<ERoleViewSource, bool> RoleViewSourceHideHomeInInstance
	{
		get
		{
			return RoleDefine._RoleViewSourceHideHomeInInstance;
		}
	}

	// Token: 0x06014EEC RID: 85740 RVA: 0x005509B4 File Offset: 0x0054EBB4
	public static void CreateStaticDefaultValue()
	{
		RoleDefine.UI_SCENE_ROLE_TAG = new FName("TsUiSceneRoleActor");
		RoleDefine.UI_SKELETAL_OBSERVER_TAG = new FName("TsSkeletalObserver");
		RoleDefine.UI_CAMERA_TAG = new FName("UICineCamera");
		RoleDefine._UI_ROLE_CAN_ROTATE_TABVIEW = new EUiTabViewName[]
		{
			EUiTabViewName.RoleAttributeTabView,
			EUiTabViewName.RoleFavorTabView,
			EUiTabViewName.RolePreviewAttributeTabView
		};
		RoleDefine._trialRoleHexColor = new Dictionary<ETrialRoleType, string>
		{
			{
				ETrialRoleType.NormalTrial,
				"ffffff"
			},
			{
				ETrialRoleType.NewbieSupportTrial,
				"fffca0"
			},
			{
				ETrialRoleType.ReturnSupportTrial,
				"bcf3ff"
			},
			{
				ETrialRoleType.NewbieSupportTrialV2,
				"fffca0"
			}
		};
		RoleDefine._RoleViewSourceHideRoleChange = new Dictionary<ERoleViewSource, bool>
		{
			{
				ERoleViewSource.Normal,
				false
			},
			{
				ERoleViewSource.WheelTower,
				true
			},
			{
				ERoleViewSource.BabelTower,
				true
			},
			{
				ERoleViewSource.FarmGold,
				true
			}
		};
		RoleDefine._RoleViewSourceHideHomeInInstance = new Dictionary<ERoleViewSource, bool>
		{
			{
				ERoleViewSource.Normal,
				false
			},
			{
				ERoleViewSource.WheelTower,
				false
			},
			{
				ERoleViewSource.BabelTower,
				true
			},
			{
				ERoleViewSource.FarmGold,
				true
			}
		};
	}

	// Token: 0x06014EED RID: 85741 RVA: 0x00550AAB File Offset: 0x0054ECAB
	public static void ResetStaticDefaultValue()
	{
		RoleDefine.UI_SCENE_ROLE_TAG = default(FName);
		RoleDefine.UI_SKELETAL_OBSERVER_TAG = default(FName);
		RoleDefine.UI_CAMERA_TAG = default(FName);
		RoleDefine._UI_ROLE_CAN_ROTATE_TABVIEW = null;
		RoleDefine._trialRoleHexColor = null;
		RoleDefine._RoleViewSourceHideRoleChange = null;
		RoleDefine._RoleViewSourceHideHomeInInstance = null;
	}

	// Token: 0x04009D23 RID: 40227
	public const int HP_ATTR_ID = 2;

	// Token: 0x04009D24 RID: 40228
	public const int ATTACK_ATTR_ID = 7;

	// Token: 0x04009D25 RID: 40229
	public const int CRIT_ATTR_ID = 8;

	// Token: 0x04009D26 RID: 40230
	public const int DEF_ATTR_ID = 10;

	// Token: 0x04009D27 RID: 40231
	public const int RESPONSE_PROFICIENCY_ID = 13;

	// Token: 0x04009D28 RID: 40232
	public const int STRENGTH_MAX_ID = 69;

	// Token: 0x04009D29 RID: 40233
	public const int ROBOT_DATA_MIN_ID = 100000;

	// Token: 0x04009D2A RID: 40234
	public const int PROP_RATIO_PER = 10000;

	// Token: 0x04009D2B RID: 40235
	public const float MUL_RATIO = 0.0001f;

	// Token: 0x04009D2C RID: 40236
	public const string UI_ABP_PATH = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C";

	// Token: 0x04009D2D RID: 40237
	public const string ROLE_CAMERA_SETTING_NAME = "1020";

	// Token: 0x04009D2E RID: 40238
	public const string ROLE_CHANGEROLE_BLENDNAME = "10007";

	// Token: 0x04009D2F RID: 40239
	[Nullable(2)]
	private static EUiTabViewName[] _UI_ROLE_CAN_ROTATE_TABVIEW;

	// Token: 0x04009D30 RID: 40240
	public static FName UI_SCENE_ROLE_TAG;

	// Token: 0x04009D31 RID: 40241
	public static FName UI_SKELETAL_OBSERVER_TAG;

	// Token: 0x04009D32 RID: 40242
	public static FName UI_CAMERA_TAG;

	// Token: 0x04009D33 RID: 40243
	public const string ROLE_MUTE_NATURE_AUDIO_GROUP = "mute_nature_voice";

	// Token: 0x04009D34 RID: 40244
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ETrialRoleType, string> _trialRoleHexColor;

	// Token: 0x04009D35 RID: 40245
	[Nullable(2)]
	private static Dictionary<ERoleViewSource, bool> _RoleViewSourceHideRoleChange;

	// Token: 0x04009D36 RID: 40246
	[Nullable(2)]
	private static Dictionary<ERoleViewSource, bool> _RoleViewSourceHideHomeInInstance;
}
