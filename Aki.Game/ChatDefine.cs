using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000C46 RID: 3142
[NullableContext(1)]
[Nullable(0)]
public class ChatDefine : IStaticVariableResetter
{
	// Token: 0x06008358 RID: 33624 RVA: 0x00284D1E File Offset: 0x00282F1E
	static ChatDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatDefine.CreateStaticDefaultValue), new Action(ChatDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06008359 RID: 33625 RVA: 0x00284D3D File Offset: 0x00282F3D
	public static void CreateStaticDefaultValue()
	{
		ChatDefine.playerMarkNameColor = FColor.FromHex("81540E");
		ChatDefine.playerRealNameColor = FColor.FromHex("#000000FF");
	}

	// Token: 0x0600835A RID: 33626 RVA: 0x00284D5D File Offset: 0x00282F5D
	public static void ResetStaticDefaultValue()
	{
		ChatDefine.playerMarkNameColor = default(FColor);
		ChatDefine.playerRealNameColor = default(FColor);
	}

	// Token: 0x04005069 RID: 20585
	public const int CHAT_CONTENT_QUEUE_SIZE = 10;

	// Token: 0x0400506A RID: 20586
	public const string CHAT_CONTENT_RESOURCE_ID = "UiItem_ChatLeft_Prefab";

	// Token: 0x0400506B RID: 20587
	public const string OWN_CHAT_CONTENT_RESOURCE_ID = "UiItem_ChatRight_Prefab";

	// Token: 0x0400506C RID: 20588
	public const string TEAM_CONTENT_RESOURCE_ID = "UiItem_Zudui";

	// Token: 0x0400506D RID: 20589
	public const int CHAT_SCROLL_DELAY = 200;

	// Token: 0x0400506E RID: 20590
	public const int FIRST_CHAT_SCROLL_DELAY = 500;

	// Token: 0x0400506F RID: 20591
	public const int REFRESH_PLAYER_INFO_TIME_DOWN = 10000;

	// Token: 0x04005070 RID: 20592
	public const int CHAT_PANEL_DELAY = 500;

	// Token: 0x04005071 RID: 20593
	public static FColor playerMarkNameColor;

	// Token: 0x04005072 RID: 20594
	public static FColor playerRealNameColor;

	// Token: 0x04005073 RID: 20595
	public const int READ_HISTORY_COUNT = 10;

	// Token: 0x04005074 RID: 20596
	public const int DELAY_PRIVATE_CHAT_DATA_REQUEST_TIME = 60000;
}
