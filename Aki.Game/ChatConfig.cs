using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000C41 RID: 3137
[NullableContext(2)]
[Nullable(0)]
public class ChatConfig : ConfigBase
{
	// Token: 0x06008316 RID: 33558 RVA: 0x00283831 File Offset: 0x00281A31
	public Chat? GetChatConfig(int configId)
	{
		return ConfigChatById.GetConfig(configId, true);
	}

	// Token: 0x06008317 RID: 33559 RVA: 0x0028383A File Offset: 0x00281A3A
	public IReadOnlyList<QuickChat> GetAllQuickChatConfigList()
	{
		return ConfigQuickChatAll.GetConfigList(true);
	}

	// Token: 0x06008318 RID: 33560 RVA: 0x00283842 File Offset: 0x00281A42
	public IReadOnlyList<ChatExpression> GetAllExpressionConfigByGroupId(int expressionGroupId)
	{
		return ConfigChatExpressionByGroupId.GetConfigList(expressionGroupId, true);
	}

	// Token: 0x06008319 RID: 33561 RVA: 0x0028384B File Offset: 0x00281A4B
	public IReadOnlyList<ChatExpressionGroup> GetAllExpressionGroupConfig()
	{
		return ConfigChatExpressionGroupAll.GetConfigList(true);
	}

	// Token: 0x0600831A RID: 33562 RVA: 0x00283853 File Offset: 0x00281A53
	public ChatExpressionGroup? GetExpressionGroupConfig(int groupId)
	{
		return ConfigChatExpressionGroupById.GetConfig(groupId, true);
	}

	// Token: 0x0600831B RID: 33563 RVA: 0x0028385C File Offset: 0x00281A5C
	public ChatExpression? GetExpressionConfig(int expressionId)
	{
		return ConfigChatExpressionById.GetConfig(expressionId, true);
	}

	// Token: 0x0600831C RID: 33564 RVA: 0x00283865 File Offset: 0x00281A65
	public IReadOnlyList<ChatExpression> GetAllExpressionConfig()
	{
		return ConfigChatExpressionAll.GetConfigList(true);
	}

	// Token: 0x17000EA6 RID: 3750
	// (get) Token: 0x0600831D RID: 33565 RVA: 0x0028386D File Offset: 0x00281A6D
	[Nullable(1)]
	public static ChatConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ChatConfig._Instance;
		}
	}

	// Token: 0x0600831E RID: 33566 RVA: 0x00283874 File Offset: 0x00281A74
	[NullableContext(1)]
	public static ChatConfig GetOrCreateInstance()
	{
		if (ChatConfig._Instance == null)
		{
			ChatConfig.CreateInstance();
		}
		return ChatConfig._Instance;
	}

	// Token: 0x0600831F RID: 33567 RVA: 0x00283888 File Offset: 0x00281A88
	public static bool CreateInstance()
	{
		if (ChatConfig._Instance != null)
		{
			return true;
		}
		ChatConfig._Instance = new ChatConfig();
		return true;
	}

	// Token: 0x06008320 RID: 33568 RVA: 0x0028389E File Offset: 0x00281A9E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008321 RID: 33569 RVA: 0x002838A0 File Offset: 0x00281AA0
	public static void ResetStaticDefaultValue()
	{
		ChatConfig._Instance = null;
	}

	// Token: 0x06008322 RID: 33570 RVA: 0x002838A8 File Offset: 0x00281AA8
	static ChatConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatConfig.CreateStaticDefaultValue), new Action(ChatConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400504B RID: 20555
	private static ChatConfig _Instance;
}
