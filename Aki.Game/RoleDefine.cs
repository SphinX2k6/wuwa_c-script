using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D37 RID: 7479
[NullableContext(1)]
[Nullable(0)]
public class RoleDefine : IStaticVariableResetter
{
	// Token: 0x060128E6 RID: 76006 RVA: 0x0057B69D File Offset: 0x0057989D
	static RoleDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDefine.CreateStaticDefaultValue), new Action(RoleDefine.ResetStaticDefaultValue));
	}

	// Token: 0x17001B84 RID: 7044
	// (get) Token: 0x060128E7 RID: 76007 RVA: 0x0057B6BC File Offset: 0x005798BC
	public static EUiTabViewName[] UI_ROLE_CAN_ROTATE_TABVIEW
	{
		get
		{
			return RoleDefine._UI_ROLE_CAN_ROTATE_TABVIEW;
		}
	}

	// Token: 0x17001B85 RID: 7045
	// (get) Token: 0x060128E8 RID: 76008 RVA: 0x0057B6C3 File Offset: 0x005798C3
	public static Dictionary<ETrialRoleType, string> trialRoleHexColor
	{
		get
		{
			return RoleDefine._trialRoleHexColor;
		}
	}

	// Token: 0x17001B86 RID: 7046
	// (get) Token: 0x060128E9 RID: 76009 RVA: 0x0057B6CA File Offset: 0x005798CA
	public static Dictionary<ERoleViewSource, bool> RoleViewSourceHideRoleChange
	{
		get
		{
			return RoleDefine._RoleViewSourceHideRoleChange;
		}
	}

	// Token: 0x17001B87 RID: 7047
	// (get) Token: 0x060128EA RID: 76010 RVA: 0x0057B6D1 File Offset: 0x005798D1
	public static Dictionary<ERoleViewSource, bool> RoleViewSourceHideHomeInInstance
	{
		get
		{
			return RoleDefine._RoleViewSourceHideHomeInInstance;
		}
	}

	// Token: 0x17001B88 RID: 7048
	// (get) Token: 0x060128EB RID: 76011 RVA: 0x0057B6D8 File Offset: 0x005798D8
	public static string[] ROLE_ELEMENT_PRELOAD_EFFECT_KEYS
	{
		get
		{
			return RoleDefine._ROLE_ELEMENT_PRELOAD_EFFECT_KEYS;
		}
	}

	// Token: 0x060128EC RID: 76012 RVA: 0x0057B6E0 File Offset: 0x005798E0
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
		RoleDefine._ROLE_ELEMENT_PRELOAD_EFFECT_KEYS = new string[]
		{
			"AttributePreviewHandEffect",
			"AttributePreviewDissipateHandEffect",
			"AttributePreviewBodyEffect",
			"AttributeSwitchBodyEffect",
			"AttributeSwitchHandEffect"
		};
	}

	// Token: 0x060128ED RID: 76013 RVA: 0x0057B80C File Offset: 0x00579A0C
	public static void ResetStaticDefaultValue()
	{
		RoleDefine.UI_SCENE_ROLE_TAG = default(FName);
		RoleDefine.UI_SKELETAL_OBSERVER_TAG = default(FName);
		RoleDefine.UI_CAMERA_TAG = default(FName);
		RoleDefine._UI_ROLE_CAN_ROTATE_TABVIEW = null;
		RoleDefine._trialRoleHexColor = null;
		RoleDefine._RoleViewSourceHideRoleChange = null;
		RoleDefine._RoleViewSourceHideHomeInInstance = null;
		RoleDefine._ROLE_ELEMENT_PRELOAD_EFFECT_KEYS = null;
	}

	// Token: 0x0400A106 RID: 41222
	public const int HP_ATTR_ID = 2;

	// Token: 0x0400A107 RID: 41223
	public const int ATTACK_ATTR_ID = 7;

	// Token: 0x0400A108 RID: 41224
	public const int CRIT_ATTR_ID = 8;

	// Token: 0x0400A109 RID: 41225
	public const int DEF_ATTR_ID = 10;

	// Token: 0x0400A10A RID: 41226
	public const int RESPONSE_PROFICIENCY_ID = 13;

	// Token: 0x0400A10B RID: 41227
	public const int STRENGTH_MAX_ID = 69;

	// Token: 0x0400A10C RID: 41228
	public const int ROBOT_DATA_MIN_ID = 100000;

	// Token: 0x0400A10D RID: 41229
	public const int PROP_RATIO_PER = 10000;

	// Token: 0x0400A10E RID: 41230
	public const float MUL_RATIO = 0.0001f;

	// Token: 0x0400A10F RID: 41231
	public const string UI_ABP_PATH = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C";

	// Token: 0x0400A110 RID: 41232
	public const string ROLE_CAMERA_SETTING_NAME = "1020";

	// Token: 0x0400A111 RID: 41233
	public const string ROLE_CHANGEROLE_BLENDNAME = "10007";

	// Token: 0x0400A112 RID: 41234
	public const int ROLE_CLOSE_CONFIRM = 591;

	// Token: 0x0400A113 RID: 41235
	[Nullable(2)]
	private static EUiTabViewName[] _UI_ROLE_CAN_ROTATE_TABVIEW;

	// Token: 0x0400A114 RID: 41236
	public static FName UI_SCENE_ROLE_TAG;

	// Token: 0x0400A115 RID: 41237
	public static FName UI_SKELETAL_OBSERVER_TAG;

	// Token: 0x0400A116 RID: 41238
	public static FName UI_CAMERA_TAG;

	// Token: 0x0400A117 RID: 41239
	public const string ROLE_MUTE_NATURE_AUDIO_GROUP = "mute_nature_voice";

	// Token: 0x0400A118 RID: 41240
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ETrialRoleType, string> _trialRoleHexColor;

	// Token: 0x0400A119 RID: 41241
	[Nullable(2)]
	private static Dictionary<ERoleViewSource, bool> _RoleViewSourceHideRoleChange;

	// Token: 0x0400A11A RID: 41242
	[Nullable(2)]
	private static Dictionary<ERoleViewSource, bool> _RoleViewSourceHideHomeInInstance;

	// Token: 0x0400A11B RID: 41243
	public const string ROLE_ELEMENT_PREVIEW_AUDIO = "play_ui_switchelement_buttorn_click";

	// Token: 0x0400A11C RID: 41244
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static string[] _ROLE_ELEMENT_PRELOAD_EFFECT_KEYS;
}
