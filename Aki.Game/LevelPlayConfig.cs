using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200205D RID: 8285
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LevelPlayConfig : ConfigBase
{
	// Token: 0x060104B5 RID: 66741 RVA: 0x003F8E28 File Offset: 0x003F7028
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

	// Token: 0x060104B6 RID: 66742 RVA: 0x003F8EA4 File Offset: 0x003F70A4
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

	// Token: 0x060104B7 RID: 66743 RVA: 0x003F8EF0 File Offset: 0x003F70F0
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

	// Token: 0x17001418 RID: 5144
	// (get) Token: 0x060104B8 RID: 66744 RVA: 0x003F8F97 File Offset: 0x003F7197
	public static LevelPlayConfig Instance
	{
		get
		{
			return LevelPlayConfig._Instance;
		}
	}

	// Token: 0x060104B9 RID: 66745 RVA: 0x003F8F9E File Offset: 0x003F719E
	public static LevelPlayConfig GetOrCreateInstance()
	{
		if (LevelPlayConfig._Instance == null)
		{
			LevelPlayConfig.CreateInstance();
		}
		return LevelPlayConfig._Instance;
	}

	// Token: 0x060104BA RID: 66746 RVA: 0x003F8FB2 File Offset: 0x003F71B2
	public static bool CreateInstance()
	{
		if (LevelPlayConfig._Instance != null)
		{
			return true;
		}
		LevelPlayConfig._Instance = new LevelPlayConfig();
		return true;
	}

	// Token: 0x060104BB RID: 66747 RVA: 0x003F8FC8 File Offset: 0x003F71C8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060104BC RID: 66748 RVA: 0x003F8FCA File Offset: 0x003F71CA
	public static void ResetStaticDefaultValue()
	{
		LevelPlayConfig._Instance = null;
	}

	// Token: 0x060104BD RID: 66749 RVA: 0x003F8FD2 File Offset: 0x003F71D2
	static LevelPlayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelPlayConfig.CreateStaticDefaultValue), new Action(LevelPlayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007875 RID: 30837
	[Nullable(2)]
	private static LevelPlayConfig _Instance;
}
