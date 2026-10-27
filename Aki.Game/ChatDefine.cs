using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200178D RID: 6029
[NullableContext(1)]
[Nullable(0)]
public class ChatDefine : IStaticVariableResetter
{
	// Token: 0x0600AF70 RID: 44912 RVA: 0x0027A89A File Offset: 0x00278A9A
	static ChatDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatDefine.CreateStaticDefaultValue), new Action(ChatDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600AF71 RID: 44913 RVA: 0x0027A8B9 File Offset: 0x00278AB9
	public static void CreateStaticDefaultValue()
	{
		ChatDefine.playerMarkNameColor = FColor.FromHex("81540E");
		ChatDefine.playerRealNameColor = FColor.FromHex("#000000FF");
	}

	// Token: 0x0600AF72 RID: 44914 RVA: 0x0027A8D9 File Offset: 0x00278AD9
	public static void ResetStaticDefaultValue()
	{
		ChatDefine.playerMarkNameColor = default(FColor);
		ChatDefine.playerRealNameColor = default(FColor);
	}

	// Token: 0x04004FBF RID: 20415
	public const int CHAT_CONTENT_QUEUE_SIZE = 10;

	// Token: 0x04004FC0 RID: 20416
	public const string CHAT_CONTENT_RESOURCE_ID = "UiItem_ChatLeft_Prefab";

	// Token: 0x04004FC1 RID: 20417
	public const string OWN_CHAT_CONTENT_RESOURCE_ID = "UiItem_ChatRight_Prefab";

	// Token: 0x04004FC2 RID: 20418
	public const string TEAM_CONTENT_RESOURCE_ID = "UiItem_Zudui";

	// Token: 0x04004FC3 RID: 20419
	public const int CHAT_SCROLL_DELAY = 200;

	// Token: 0x04004FC4 RID: 20420
	public const int FIRST_CHAT_SCROLL_DELAY = 500;

	// Token: 0x04004FC5 RID: 20421
	public const int REFRESH_PLAYER_INFO_TIME_DOWN = 10000;

	// Token: 0x04004FC6 RID: 20422
	public const int CHAT_PANEL_DELAY = 500;

	// Token: 0x04004FC7 RID: 20423
	public static FColor playerMarkNameColor;

	// Token: 0x04004FC8 RID: 20424
	public static FColor playerRealNameColor;

	// Token: 0x04004FC9 RID: 20425
	public const int READ_HISTORY_COUNT = 10;

	// Token: 0x04004FCA RID: 20426
	public const int DELAY_PRIVATE_CHAT_DATA_REQUEST_TIME = 60000;
}
