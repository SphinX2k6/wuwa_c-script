using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000996 RID: 2454
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityScratchTicketConfig : ConfigBase
{
	// Token: 0x06006BFB RID: 27643 RVA: 0x002180D4 File Offset: 0x002162D4
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

	// Token: 0x06006BFC RID: 27644 RVA: 0x00218124 File Offset: 0x00216324
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

	// Token: 0x06006BFD RID: 27645 RVA: 0x00218174 File Offset: 0x00216374
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

	// Token: 0x06006BFE RID: 27646 RVA: 0x002181C4 File Offset: 0x002163C4
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

	// Token: 0x06006BFF RID: 27647 RVA: 0x0021820C File Offset: 0x0021640C
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

	// Token: 0x17000D3D RID: 3389
	// (get) Token: 0x06006C00 RID: 27648 RVA: 0x0021825A File Offset: 0x0021645A
	public static ActivityScratchTicketConfig Instance
	{
		get
		{
			return ActivityScratchTicketConfig._Instance;
		}
	}

	// Token: 0x06006C01 RID: 27649 RVA: 0x00218261 File Offset: 0x00216461
	public static ActivityScratchTicketConfig GetOrCreateInstance()
	{
		if (ActivityScratchTicketConfig._Instance == null)
		{
			ActivityScratchTicketConfig.CreateInstance();
		}
		return ActivityScratchTicketConfig._Instance;
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x00218275 File Offset: 0x00216475
	public static bool CreateInstance()
	{
		if (ActivityScratchTicketConfig._Instance != null)
		{
			return true;
		}
		ActivityScratchTicketConfig._Instance = new ActivityScratchTicketConfig();
		return true;
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x0021828B File Offset: 0x0021648B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x0021828D File Offset: 0x0021648D
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketConfig._Instance = null;
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x00218295 File Offset: 0x00216495
	static ActivityScratchTicketConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketConfig.CreateStaticDefaultValue), new Action(ActivityScratchTicketConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400438D RID: 17293
	[Nullable(2)]
	private static ActivityScratchTicketConfig _Instance;
}
