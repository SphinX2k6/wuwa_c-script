using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001788 RID: 6024
[NullableContext(2)]
[Nullable(0)]
public class ChatConfig : ConfigBase
{
	// Token: 0x0600AF2E RID: 44846 RVA: 0x002792FD File Offset: 0x002774FD
	public Chat? GetChatConfig(int configId)
	{
		return ConfigChatById.GetConfig(configId, true);
	}

	// Token: 0x0600AF2F RID: 44847 RVA: 0x00279306 File Offset: 0x00277506
	public IReadOnlyList<QuickChat> GetAllQuickChatConfigList()
	{
		return ConfigQuickChatAll.GetConfigList(true);
	}

	// Token: 0x0600AF30 RID: 44848 RVA: 0x0027930E File Offset: 0x0027750E
	public IReadOnlyList<ChatExpression> GetAllExpressionConfigByGroupId(int expressionGroupId)
	{
		return ConfigChatExpressionByGroupId.GetConfigList(expressionGroupId, true);
	}

	// Token: 0x0600AF31 RID: 44849 RVA: 0x00279317 File Offset: 0x00277517
	public IReadOnlyList<ChatExpressionGroup> GetAllExpressionGroupConfig()
	{
		return ConfigChatExpressionGroupAll.GetConfigList(true);
	}

	// Token: 0x0600AF32 RID: 44850 RVA: 0x0027931F File Offset: 0x0027751F
	public ChatExpressionGroup? GetExpressionGroupConfig(int groupId)
	{
		return ConfigChatExpressionGroupById.GetConfig(groupId, true);
	}

	// Token: 0x0600AF33 RID: 44851 RVA: 0x00279328 File Offset: 0x00277528
	public ChatExpression? GetExpressionConfig(int expressionId)
	{
		return ConfigChatExpressionById.GetConfig(expressionId, true);
	}

	// Token: 0x0600AF34 RID: 44852 RVA: 0x00279331 File Offset: 0x00277531
	public IReadOnlyList<ChatExpression> GetAllExpressionConfig()
	{
		return ConfigChatExpressionAll.GetConfigList(true);
	}

	// Token: 0x17000E83 RID: 3715
	// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x00279339 File Offset: 0x00277539
	[Nullable(1)]
	public static ChatConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ChatConfig._Instance;
		}
	}

	// Token: 0x0600AF36 RID: 44854 RVA: 0x00279340 File Offset: 0x00277540
	[NullableContext(1)]
	public static ChatConfig GetOrCreateInstance()
	{
		if (ChatConfig._Instance == null)
		{
			ChatConfig.CreateInstance();
		}
		return ChatConfig._Instance;
	}

	// Token: 0x0600AF37 RID: 44855 RVA: 0x00279354 File Offset: 0x00277554
	public static bool CreateInstance()
	{
		if (ChatConfig._Instance != null)
		{
			return true;
		}
		ChatConfig._Instance = new ChatConfig();
		return true;
	}

	// Token: 0x0600AF38 RID: 44856 RVA: 0x0027936A File Offset: 0x0027756A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AF39 RID: 44857 RVA: 0x0027936C File Offset: 0x0027756C
	public static void ResetStaticDefaultValue()
	{
		ChatConfig._Instance = null;
	}

	// Token: 0x0600AF3A RID: 44858 RVA: 0x00279374 File Offset: 0x00277574
	static ChatConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatConfig.CreateStaticDefaultValue), new Action(ChatConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004FA1 RID: 20385
	private static ChatConfig _Instance;
}
