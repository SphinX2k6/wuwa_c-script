using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B38 RID: 6968
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class QuestNewConfig : ConfigBase
{
	// Token: 0x0601160C RID: 71180 RVA: 0x0051E1E5 File Offset: 0x0051C3E5
	protected override bool OnInit()
	{
		this.InitQuestAreaConfigs();
		return true;
	}

	// Token: 0x0601160D RID: 71181 RVA: 0x0051E1F0 File Offset: 0x0051C3F0
	private void InitQuestAreaConfigs()
	{
	}

	// Token: 0x0601160E RID: 71182 RVA: 0x0051E200 File Offset: 0x0051C400
	[return: Nullable(2)]
	public unsafe string GetTrackEffectPath(string trackEffectEnum)
	{
		if (StringUtils.IsEmpty(trackEffectEnum))
		{
			return null;
		}
		string item = "Name = 'ETrackEffect." + trackEffectEnum + "'";
		GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig("ETrackEffect." + trackEffectEnum, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到全局配置表的配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("全局表路径", "Source/Config/Raw/Tables/q.全局配置");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("查询条件", item);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return config.Value.Value;
	}

	// Token: 0x0601160F RID: 71183 RVA: 0x0051E2AC File Offset: 0x0051C4AC
	[return: Nullable(2)]
	public unsafe string GetGlobalConfig(string paramName)
	{
		if (StringUtils.IsEmpty(paramName))
		{
			return null;
		}
		string item = "Name = '" + paramName + "'";
		GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig(paramName, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到全局配置表的配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("全局表路径", "Source/Config/Raw/Tables/q.全局配置");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("查询条件", item);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return config.Value.Value;
	}

	// Token: 0x06011610 RID: 71184 RVA: 0x0051E350 File Offset: 0x0051C550
	public DropPackage? GetDropConfig(int? rewardId)
	{
		bool flag = (rewardId ?? 0) == 0;
		if (flag)
		{
			return null;
		}
		DropPackage? config = ConfigDropPackageById.GetConfig(rewardId.Value, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "DropPackage表配置没找到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rewardId", rewardId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06011611 RID: 71185 RVA: 0x0051E3C8 File Offset: 0x0051C5C8
	public ItemInfo? GetItemInfoConfig(int itemId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "ItemInfo表配置没找到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06011612 RID: 71186 RVA: 0x0051E413 File Offset: 0x0051C613
	[NullableContext(2)]
	public IReadOnlyList<QuestType> GetQuestTypeConfigs()
	{
		return ConfigQuestTypeAll.GetConfigList(true);
	}

	// Token: 0x06011613 RID: 71187 RVA: 0x0051E41C File Offset: 0x0051C61C
	public QuestType? GetQuestTypeConfig(int questType)
	{
		QuestType? config = ConfigQuestTypeById.GetConfig(questType, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "QuestType表配置没找到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", questType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06011614 RID: 71188 RVA: 0x0051E468 File Offset: 0x0051C668
	public QuestMainType? GetQuestMainTypeConfig(int mainTypeId)
	{
		QuestMainType? config = ConfigQuestMainTypeById.GetConfig(mainTypeId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "QuestMainType表配置没找到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", mainTypeId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06011615 RID: 71189 RVA: 0x0051E4B3 File Offset: 0x0051C6B3
	[NullableContext(2)]
	public IReadOnlyList<QuestType> GetQuesTypesByMainType(int questType)
	{
		return ConfigQuestTypeByMainId.GetConfigList(questType, true);
	}

	// Token: 0x06011616 RID: 71190 RVA: 0x0051E4BC File Offset: 0x0051C6BC
	public string GetQuestMainTypeName(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(questMainTypeConfig.Value.MainTypeName, null) ?? "";
	}

	// Token: 0x06011617 RID: 71191 RVA: 0x0051E500 File Offset: 0x0051C700
	public string GetQuestTabIcon(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return "";
		}
		return questMainTypeConfig.Value.QuestTabIcon;
	}

	// Token: 0x06011618 RID: 71192 RVA: 0x0051E534 File Offset: 0x0051C734
	public string GetQuestTypeMark(int markId)
	{
		TaskMark? config = ConfigTaskMarkByMarkId.GetConfig(markId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "地图标记表TaskMark：MarkId = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "";
		}
		if (StringUtils.IsBlank(config.Value.MarkPic))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Quest;
			ELogAuthor author2 = ELogAuthor.JLY;
			string message2 = "地图标记表MarkPic为空";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("markId", markId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return config.Value.MarkPic;
	}

	// Token: 0x06011619 RID: 71193 RVA: 0x0051E5D8 File Offset: 0x0051C7D8
	public TaskMark? GetQuestMarkConfig(int markId)
	{
		TaskMark? config = ConfigTaskMarkByMarkId.GetConfig(markId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "地图标记表TaskMark：MarkId = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0601161A RID: 71194 RVA: 0x0051E624 File Offset: 0x0051C824
	public int? GetQuestTypeMarkId(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return null;
		}
		return new int?(questMainTypeConfig.Value.TrackIconId);
	}

	// Token: 0x0601161B RID: 71195 RVA: 0x0051E660 File Offset: 0x0051C860
	public QuestChapter? GetChapterConfig(int chapterId)
	{
		QuestChapter? config = ConfigQuestChapterById.GetConfig(chapterId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "任务章节表：id = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("chapterId", chapterId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new QuestChapter?(config.Value);
	}

	// Token: 0x0601161C RID: 71196 RVA: 0x0051E6C0 File Offset: 0x0051C8C0
	public unsafe OccupationConfig? GetOccupationConfig(string occupationId)
	{
		OccupationConfig? config = ConfigOccupationConfigById.GetConfig(occupationId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到占用配置表的配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("全局表路径", "Source/Config/Raw/Tables/k.可视化编辑/z.占用组配置");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", occupationId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x0601161D RID: 71197 RVA: 0x0051E738 File Offset: 0x0051C938
	public unsafe NewOccupationConfig? GetNewOccupationConfig(string occupationId)
	{
		NewOccupationConfig? config = ConfigNewOccupationConfigById.GetConfig(occupationId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到占用配置表的配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("全局表路径", "Source/Config/Raw/Tables/k.可视化编辑/z.占用组配置");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", occupationId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x0601161E RID: 71198 RVA: 0x0051E7B0 File Offset: 0x0051C9B0
	[return: Nullable(2)]
	public string GetOccupationResourceName(string occupationId)
	{
		OccupationConfig? occupationConfig = this.GetOccupationConfig(occupationId);
		if (occupationConfig == null)
		{
			return "";
		}
		return PublicUtil.Instance.GetConfigTextByTable(ETableText.OccupationConfigName, occupationConfig.Value.Id);
	}

	// Token: 0x0601161F RID: 71199 RVA: 0x0051E7F0 File Offset: 0x0051C9F0
	[return: Nullable(2)]
	public string GetOccupationType(string occupationId)
	{
		OccupationConfig? occupationConfig = this.GetOccupationConfig(occupationId);
		if (occupationConfig == null)
		{
			return "";
		}
		return occupationConfig.Value.OccupationType;
	}

	// Token: 0x06011620 RID: 71200 RVA: 0x0051E824 File Offset: 0x0051CA24
	public QuestData? GetQuestConfig(int questId)
	{
		QuestData? config = ConfigQuestDataById.GetConfig(questId, false);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到任务配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", questId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06011621 RID: 71201 RVA: 0x0051E870 File Offset: 0x0051CA70
	public unsafe QuestNodeData? GetQuestNodeConfig(int questId, int nodeId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
		QuestNodeData? config = ConfigQuestNodeDataByKey.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到任务节点配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", questId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", nodeId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x06011622 RID: 71202 RVA: 0x0051E918 File Offset: 0x0051CB18
	[NullableContext(2)]
	public string GetQuestTypeColor(int questType)
	{
		QuestType? questTypeConfig = this.GetQuestTypeConfig(questType);
		if (questTypeConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "任务类型表：id = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questType", questType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return questTypeConfig.Value.TypeColor;
	}

	// Token: 0x06011623 RID: 71203 RVA: 0x0051E974 File Offset: 0x0051CB74
	[NullableContext(2)]
	public string GetQuestMainTypeCircleColor(int questType)
	{
		QuestType? questTypeConfig = this.GetQuestTypeConfig(questType);
		if (questTypeConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "任务类型表：id = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questType", questType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.GetQuestMainTypeConfig(questTypeConfig.Value.MainId).Value.CircleColor;
	}

	// Token: 0x06011624 RID: 71204 RVA: 0x0051E9E8 File Offset: 0x0051CBE8
	[NullableContext(2)]
	public string GetQuestMainTypeTrackBgColor(int questType)
	{
		QuestType? questTypeConfig = this.GetQuestTypeConfig(questType);
		if (questTypeConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "任务类型表：id = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questType", questType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.GetQuestMainTypeConfig(questTypeConfig.Value.MainId).Value.TrackBgColor;
	}

	// Token: 0x06011625 RID: 71205 RVA: 0x0051EA5C File Offset: 0x0051CC5C
	[NullableContext(2)]
	public string GetQuestTypeTextColor(int questType)
	{
		QuestType? questTypeConfig = this.GetQuestTypeConfig(questType);
		if (questTypeConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "任务类型表：id = 的配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questType", questType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return questTypeConfig.Value.TextColor;
	}

	// Token: 0x06011626 RID: 71206 RVA: 0x0051EAB8 File Offset: 0x0051CCB8
	public int? GetNewTipsShowTime(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return new int?(0);
		}
		return new int?(questMainTypeConfig.Value.NewQuestTipTime);
	}

	// Token: 0x06011627 RID: 71207 RVA: 0x0051EAF4 File Offset: 0x0051CCF4
	public int? GetQuestUpdateShowTime(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return new int?(0);
		}
		return new int?(questMainTypeConfig.Value.QuestUpdateTipsTime);
	}

	// Token: 0x06011628 RID: 71208 RVA: 0x0051EB30 File Offset: 0x0051CD30
	[NullableContext(2)]
	public unsafe List<int> GetQuestNodeAreaInfo(int questId, int nodeId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
		string p0Id = defaultInterpolatedStringHandler.ToStringAndClear();
		AreaQuestTracking? config = ConfigAreaQuestTrackingById.GetConfig(p0Id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到任务节点所在的区域信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", questId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", nodeId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new List<int>(config.Value.GetAreaListArray());
	}

	// Token: 0x170019CD RID: 6605
	// (get) Token: 0x06011629 RID: 71209 RVA: 0x0051EBEF File Offset: 0x0051CDEF
	public static QuestNewConfig Instance
	{
		get
		{
			return QuestNewConfig._Instance;
		}
	}

	// Token: 0x0601162A RID: 71210 RVA: 0x0051EBF6 File Offset: 0x0051CDF6
	public static QuestNewConfig GetOrCreateInstance()
	{
		if (QuestNewConfig._Instance == null)
		{
			QuestNewConfig.CreateInstance();
		}
		return QuestNewConfig._Instance;
	}

	// Token: 0x0601162B RID: 71211 RVA: 0x0051EC0A File Offset: 0x0051CE0A
	public static bool CreateInstance()
	{
		if (QuestNewConfig._Instance != null)
		{
			return true;
		}
		QuestNewConfig._Instance = new QuestNewConfig();
		return true;
	}

	// Token: 0x0601162C RID: 71212 RVA: 0x0051EC20 File Offset: 0x0051CE20
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601162D RID: 71213 RVA: 0x0051EC22 File Offset: 0x0051CE22
	public static void ResetStaticDefaultValue()
	{
		QuestNewConfig._Instance = null;
	}

	// Token: 0x0601162E RID: 71214 RVA: 0x0051EC2A File Offset: 0x0051CE2A
	static QuestNewConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestNewConfig.CreateStaticDefaultValue), new Action(QuestNewConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040098A3 RID: 39075
	private readonly Dictionary<string, List<int>> AreaQuestTrackingList = new Dictionary<string, List<int>>();

	// Token: 0x040098A4 RID: 39076
	[Nullable(2)]
	private static QuestNewConfig _Instance;
}
