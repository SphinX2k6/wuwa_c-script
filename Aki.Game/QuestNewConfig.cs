using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x0200264D RID: 9805
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class QuestNewConfig : ConfigBase
{
	// Token: 0x0601412A RID: 82218 RVA: 0x0050F425 File Offset: 0x0050D625
	protected override bool OnInit()
	{
		this.InitQuestAreaConfigs();
		return true;
	}

	// Token: 0x0601412B RID: 82219 RVA: 0x0050F430 File Offset: 0x0050D630
	private void InitQuestAreaConfigs()
	{
		if (PublicUtil.Instance.UseDbConfig())
		{
			return;
		}
		string text = UKismetSystemLibrary.ConvertToAbsolutePath(UKismetSystemLibrary.ConvertToAbsolutePath(UBlueprintPathsLibrary.ProjectDir()) + "../Config/Raw/Tables/k.可视化编辑/AreaQuestTracking.json");
		if (!UBlueprintPathsLibrary.FileExists(text))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Editor;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "globalConfigTemp文件不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", text);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text2 = "";
		UKuroStaticLibrary.LoadFileToString(ref text2, text);
		foreach (IAreaQuestTracking areaQuestTracking in Json.Decode<List<IAreaQuestTracking>>(text2, null))
		{
			Dictionary<string, List<int>> areaQuestTrackingList = this.AreaQuestTrackingList;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(areaQuestTracking.QuestId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(areaQuestTracking.NodeId);
			areaQuestTrackingList[defaultInterpolatedStringHandler.ToStringAndClear()] = areaQuestTracking.AreaIds;
		}
	}

	// Token: 0x0601412C RID: 82220 RVA: 0x0050F530 File Offset: 0x0050D730
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

	// Token: 0x0601412D RID: 82221 RVA: 0x0050F5DC File Offset: 0x0050D7DC
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

	// Token: 0x0601412E RID: 82222 RVA: 0x0050F680 File Offset: 0x0050D880
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

	// Token: 0x0601412F RID: 82223 RVA: 0x0050F6F8 File Offset: 0x0050D8F8
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

	// Token: 0x06014130 RID: 82224 RVA: 0x0050F743 File Offset: 0x0050D943
	[NullableContext(2)]
	public IReadOnlyList<QuestType> GetQuestTypeConfigs()
	{
		return ConfigQuestTypeAll.GetConfigList(true);
	}

	// Token: 0x06014131 RID: 82225 RVA: 0x0050F74C File Offset: 0x0050D94C
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

	// Token: 0x06014132 RID: 82226 RVA: 0x0050F798 File Offset: 0x0050D998
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

	// Token: 0x06014133 RID: 82227 RVA: 0x0050F7E3 File Offset: 0x0050D9E3
	[NullableContext(2)]
	public IReadOnlyList<QuestType> GetQuesTypesByMainType(int questType)
	{
		return ConfigQuestTypeByMainId.GetConfigList(questType, true);
	}

	// Token: 0x06014134 RID: 82228 RVA: 0x0050F7EC File Offset: 0x0050D9EC
	public string GetQuestMainTypeName(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(questMainTypeConfig.Value.MainTypeName, null) ?? "";
	}

	// Token: 0x06014135 RID: 82229 RVA: 0x0050F830 File Offset: 0x0050DA30
	public string GetQuestTabIcon(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return "";
		}
		return questMainTypeConfig.Value.QuestTabIcon;
	}

	// Token: 0x06014136 RID: 82230 RVA: 0x0050F864 File Offset: 0x0050DA64
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

	// Token: 0x06014137 RID: 82231 RVA: 0x0050F908 File Offset: 0x0050DB08
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

	// Token: 0x06014138 RID: 82232 RVA: 0x0050F954 File Offset: 0x0050DB54
	public int? GetQuestTypeMarkId(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return null;
		}
		return new int?(questMainTypeConfig.Value.TrackIconId);
	}

	// Token: 0x06014139 RID: 82233 RVA: 0x0050F990 File Offset: 0x0050DB90
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

	// Token: 0x0601413A RID: 82234 RVA: 0x0050F9F0 File Offset: 0x0050DBF0
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

	// Token: 0x0601413B RID: 82235 RVA: 0x0050FA68 File Offset: 0x0050DC68
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

	// Token: 0x0601413C RID: 82236 RVA: 0x0050FAE0 File Offset: 0x0050DCE0
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

	// Token: 0x0601413D RID: 82237 RVA: 0x0050FB20 File Offset: 0x0050DD20
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

	// Token: 0x0601413E RID: 82238 RVA: 0x0050FB54 File Offset: 0x0050DD54
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

	// Token: 0x0601413F RID: 82239 RVA: 0x0050FBA0 File Offset: 0x0050DDA0
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

	// Token: 0x06014140 RID: 82240 RVA: 0x0050FC48 File Offset: 0x0050DE48
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

	// Token: 0x06014141 RID: 82241 RVA: 0x0050FCA4 File Offset: 0x0050DEA4
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

	// Token: 0x06014142 RID: 82242 RVA: 0x0050FD18 File Offset: 0x0050DF18
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

	// Token: 0x06014143 RID: 82243 RVA: 0x0050FD8C File Offset: 0x0050DF8C
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

	// Token: 0x06014144 RID: 82244 RVA: 0x0050FDE8 File Offset: 0x0050DFE8
	public int? GetNewTipsShowTime(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return new int?(0);
		}
		return new int?(questMainTypeConfig.Value.NewQuestTipTime);
	}

	// Token: 0x06014145 RID: 82245 RVA: 0x0050FE24 File Offset: 0x0050E024
	public int? GetQuestUpdateShowTime(int questType)
	{
		QuestMainType? questMainTypeConfig = this.GetQuestMainTypeConfig(questType);
		if (questMainTypeConfig == null)
		{
			return new int?(0);
		}
		return new int?(questMainTypeConfig.Value.QuestUpdateTipsTime);
	}

	// Token: 0x06014146 RID: 82246 RVA: 0x0050FE60 File Offset: 0x0050E060
	[NullableContext(2)]
	public unsafe List<int> GetQuestNodeAreaInfo(int questId, int nodeId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		if (!PublicUtil.Instance.UseDbConfig())
		{
			return this.AreaQuestTrackingList.GetValueOrDefault(text);
		}
		AreaQuestTracking? config = ConfigAreaQuestTrackingById.GetConfig(text, true);
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

	// Token: 0x17001995 RID: 6549
	// (get) Token: 0x06014147 RID: 82247 RVA: 0x0050FF38 File Offset: 0x0050E138
	public static QuestNewConfig Instance
	{
		get
		{
			return QuestNewConfig._Instance;
		}
	}

	// Token: 0x06014148 RID: 82248 RVA: 0x0050FF3F File Offset: 0x0050E13F
	public static QuestNewConfig GetOrCreateInstance()
	{
		if (QuestNewConfig._Instance == null)
		{
			QuestNewConfig.CreateInstance();
		}
		return QuestNewConfig._Instance;
	}

	// Token: 0x06014149 RID: 82249 RVA: 0x0050FF53 File Offset: 0x0050E153
	public static bool CreateInstance()
	{
		if (QuestNewConfig._Instance != null)
		{
			return true;
		}
		QuestNewConfig._Instance = new QuestNewConfig();
		return true;
	}

	// Token: 0x0601414A RID: 82250 RVA: 0x0050FF69 File Offset: 0x0050E169
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601414B RID: 82251 RVA: 0x0050FF6B File Offset: 0x0050E16B
	public static void ResetStaticDefaultValue()
	{
		QuestNewConfig._Instance = null;
	}

	// Token: 0x0601414C RID: 82252 RVA: 0x0050FF73 File Offset: 0x0050E173
	static QuestNewConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestNewConfig.CreateStaticDefaultValue), new Action(QuestNewConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400974B RID: 38731
	private readonly Dictionary<string, List<int>> AreaQuestTrackingList = new Dictionary<string, List<int>>();

	// Token: 0x0400974C RID: 38732
	[Nullable(2)]
	private static QuestNewConfig _Instance;
}
