using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200109A RID: 4250
[NullableContext(1)]
[Nullable(0)]
public class FormationDefine
{
	// Token: 0x0600A8AD RID: 43181 RVA: 0x0031A158 File Offset: 0x00318358
	public static IRoleSlotDisplayData CreateEmptySlotDisplayData()
	{
		return new IRoleSlotDisplayData
		{
			ConfigId = 0,
			SkinId = 0,
			Level = 0,
			Name = "",
			OnlineIndex = 0,
			PlayerId = 0,
			ThirdPartyOnlineId = "",
			CanUseSpecialTrialRole = true,
			IsDead = false,
			IsTrialRole = false,
			IsSelf = true,
			IsMultiContext = false,
			IsThirdPartyVisible = false
		};
	}

	// Token: 0x040061F1 RID: 25073
	public const int FORMATION_MAX_SLOT_COUNT = 3;

	// Token: 0x040061F2 RID: 25074
	public const string FORMATION_DEFAULT_NAME_TEXT_KEY = "PrefabTextItem_3608949261_Text";

	// Token: 0x040061F3 RID: 25075
	public const int DELAY_SHOW_LOADING_MS = 500;

	// Token: 0x040061F4 RID: 25076
	public const int AUTO_CLOSE_FORMATION_MS = 30000;

	// Token: 0x040061F5 RID: 25077
	public const int FORMATION_DRAG_START_SHOW_TIME_MS = 250;

	// Token: 0x040061F6 RID: 25078
	public const int FORMATION_DRAG_START_MOVE_TIME_MS = 750;

	// Token: 0x040061F7 RID: 25079
	public const int GAMEPAD_DRAG_OFFSET_X = 30;

	// Token: 0x040061F8 RID: 25080
	public const int GAMEPAD_DRAG_OFFSET_Z = -50;

	// Token: 0x040061F9 RID: 25081
	public const string SELF_ONLINE_INDEX_SPRITE = "SP_Online{0}PIcon_Self";

	// Token: 0x040061FA RID: 25082
	public const string OTHER_ONLINE_INDEX_SPRITE = "SP_Online{0}PIcon";

	// Token: 0x040061FB RID: 25083
	[StaticVariableRuleIgnore]
	public static readonly string[] FormationIndexSprites = new string[]
	{
		"SP_TeamNum01",
		"SP_TeamNum02",
		"SP_TeamNum03",
		"SP_TeamNum04",
		"SP_TeamNum05",
		"SP_TeamNum06",
		"SP_TeamNum07",
		"SP_TeamNum08",
		"SP_TeamNum09",
		"SP_TeamNum10",
		"SP_TeamNum11",
		"SP_TeamNum12",
		"SP_TeamNum13",
		"SP_TeamNum14",
		"SP_TeamNum15",
		"SP_TeamNum16",
		"SP_TeamNum17",
		"SP_TeamNum18",
		"SP_TeamNum19",
		"SP_TeamNum20"
	};

	// Token: 0x040061FC RID: 25084
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<int, string> FormationPositionToCameraRecord = new Dictionary<int, string>
	{
		{
			1,
			"Formation3DRole01"
		},
		{
			2,
			"Formation3DRole02"
		},
		{
			3,
			"Formation3DRole03"
		}
	};
}
