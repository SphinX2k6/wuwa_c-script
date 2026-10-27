using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014DE RID: 5342
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityScratchTicketConfig : ConfigBase
{
	// Token: 0x06009821 RID: 38945 RVA: 0x0020E394 File Offset: 0x0020C594
	public ScratchCardActivityRe? GetScratchTicketConfig(int activityId)
	{
		ScratchCardActivityRe? config = ConfigScratchCardActivityReById.GetConfig(activityId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScratchTicket;
			ELogAuthor author = ELogAuthor.BB;
			string message = "ScratchCardActivityRe读表失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06009822 RID: 38946 RVA: 0x0020E3E4 File Offset: 0x0020C5E4
	public ScratchCardRoundRe? GetScratchTicketRoundConfig(int id)
	{
		ScratchCardRoundRe? config = ConfigScratchCardRoundReByRoundId.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScratchTicket;
			ELogAuthor author = ELogAuthor.BB;
			string message = "ScratchCardRoundRe读表失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06009823 RID: 38947 RVA: 0x0020E434 File Offset: 0x0020C634
	public ScratchCardRewardRe? GetScratchTicketRewardConfig(int id)
	{
		ScratchCardRewardRe? config = ConfigScratchCardRewardReById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScratchTicket;
			ELogAuthor author = ELogAuthor.BB;
			string message = "ScratchCardRewardRe读表失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06009824 RID: 38948 RVA: 0x0020E484 File Offset: 0x0020C684
	[NullableContext(2)]
	public IReadOnlyList<ScratchCardRewardRe> GetScratchTicketRewardConfigList(int roundId)
	{
		IReadOnlyList<ScratchCardRewardRe> configList = ConfigScratchCardRewardReByType.GetConfigList(roundId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScratchTicket;
			ELogAuthor author = ELogAuthor.BB;
			string message = "ScratchCardRewardRe读表失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roundId", roundId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return configList;
	}

	// Token: 0x06009825 RID: 38949 RVA: 0x0020E4CC File Offset: 0x0020C6CC
	public ScratchCardTimesRe? GetScratchTicketConditionConfig(int id)
	{
		ScratchCardTimesRe? config = ConfigScratchCardTimesReByTaskId.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScratchTicket;
			ELogAuthor author = ELogAuthor.BB;
			string message = "ScratchCardTimesRe读表失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x17000D1C RID: 3356
	// (get) Token: 0x06009826 RID: 38950 RVA: 0x0020E51A File Offset: 0x0020C71A
	public static ActivityScratchTicketConfig Instance
	{
		get
		{
			return ActivityScratchTicketConfig._Instance;
		}
	}

	// Token: 0x06009827 RID: 38951 RVA: 0x0020E521 File Offset: 0x0020C721
	public static ActivityScratchTicketConfig GetOrCreateInstance()
	{
		if (ActivityScratchTicketConfig._Instance == null)
		{
			ActivityScratchTicketConfig.CreateInstance();
		}
		return ActivityScratchTicketConfig._Instance;
	}

	// Token: 0x06009828 RID: 38952 RVA: 0x0020E535 File Offset: 0x0020C735
	public static bool CreateInstance()
	{
		if (ActivityScratchTicketConfig._Instance != null)
		{
			return true;
		}
		ActivityScratchTicketConfig._Instance = new ActivityScratchTicketConfig();
		return true;
	}

	// Token: 0x06009829 RID: 38953 RVA: 0x0020E54B File Offset: 0x0020C74B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600982A RID: 38954 RVA: 0x0020E54D File Offset: 0x0020C74D
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketConfig._Instance = null;
	}

	// Token: 0x0600982B RID: 38955 RVA: 0x0020E555 File Offset: 0x0020C755
	static ActivityScratchTicketConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketConfig.CreateStaticDefaultValue), new Action(ActivityScratchTicketConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040042E8 RID: 17128
	[Nullable(2)]
	private static ActivityScratchTicketConfig _Instance;
}
