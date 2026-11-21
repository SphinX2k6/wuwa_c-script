using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001530 RID: 5424
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LevelPlayConfig : ConfigBase
{
	// Token: 0x0600D91D RID: 55581 RVA: 0x00405394 File Offset: 0x00403594
	public unsafe ExchangeReward? GetExchangeRewardInfo(int id)
	{
		ExchangeReward? config = ConfigExchangeRewardById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneGameplay;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到兑换奖励表配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("配置表路径", "Source/Config/Raw/Tables/d.兑换奖励配置");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x0600D91E RID: 55582 RVA: 0x00405410 File Offset: 0x00403610
	public LevelPlayData? GetLevelPlayConfig(int levelPlayId)
	{
		LevelPlayData? config = ConfigLevelPlayDataById.GetConfig(levelPlayId, false);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneGameplay;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到任务配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("玩法Id", levelPlayId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0600D91F RID: 55583 RVA: 0x0040545C File Offset: 0x0040365C
	public unsafe LevelPlayNodeData? GetLevelPlayNodeConfig(int levelPlayId, int nodeId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(levelPlayId);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
		LevelPlayNodeData? config = ConfigLevelPlayNodeDataByKey.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到玩法节点配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("玩法Id", levelPlayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("节点Id", nodeId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x17001445 RID: 5189
	// (get) Token: 0x0600D920 RID: 55584 RVA: 0x00405503 File Offset: 0x00403703
	public static LevelPlayConfig Instance
	{
		get
		{
			return LevelPlayConfig._Instance;
		}
	}

	// Token: 0x0600D921 RID: 55585 RVA: 0x0040550A File Offset: 0x0040370A
	public static LevelPlayConfig GetOrCreateInstance()
	{
		if (LevelPlayConfig._Instance == null)
		{
			LevelPlayConfig.CreateInstance();
		}
		return LevelPlayConfig._Instance;
	}

	// Token: 0x0600D922 RID: 55586 RVA: 0x0040551E File Offset: 0x0040371E
	public static bool CreateInstance()
	{
		if (LevelPlayConfig._Instance != null)
		{
			return true;
		}
		LevelPlayConfig._Instance = new LevelPlayConfig();
		return true;
	}

	// Token: 0x0600D923 RID: 55587 RVA: 0x00405534 File Offset: 0x00403734
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D924 RID: 55588 RVA: 0x00405536 File Offset: 0x00403736
	public static void ResetStaticDefaultValue()
	{
		LevelPlayConfig._Instance = null;
	}

	// Token: 0x0600D925 RID: 55589 RVA: 0x0040553E File Offset: 0x0040373E
	static LevelPlayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelPlayConfig.CreateStaticDefaultValue), new Action(LevelPlayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400795E RID: 31070
	[Nullable(2)]
	private static LevelPlayConfig _Instance;
}
