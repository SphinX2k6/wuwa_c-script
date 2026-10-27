using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003B RID: 59
	public class ConfigActionMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00061928 File Offset: 0x0005FB28
		static ConfigActionMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActionMappingAll.CreateStaticDefaultValue), new Action(ConfigActionMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00061948 File Offset: 0x0005FB48
		public static void CreateStaticDefaultValue()
		{
			ConfigActionMappingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActionMappingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "ActionMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `ActionMapping`")
			});
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000619C7 File Offset: 0x0005FBC7
		public static void ResetStaticDefaultValue()
		{
			ConfigActionMappingAll.LogPair = null;
			ConfigActionMappingAll.HandleId = 0;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000619D5 File Offset: 0x0005FBD5
		public static void Init()
		{
			ConfigActionMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigActionMappingAll.HandleId, "db_input_settings.db", "select BinData from `ActionMapping`");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000619F0 File Offset: 0x0005FBF0
		[NullableContext(2)]
		public static IReadOnlyList<ActionMapping> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActionMappingAll.HandleId, ConfigActionMappingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActionMapping> readOnlyList = (IReadOnlyList<ActionMapping>)ConfigCommon.GetConfig("ActionMappingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActionMapping> list = new List<ActionMapping>();
			while (ConfigCommon.Step(ConfigActionMappingAll.HandleId, false, ConfigActionMappingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActionMappingAll.HandleId, 0, ConfigActionMappingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActionMappingAll.HandleId, ConfigActionMappingAll.LogPair);
					return null;
				}
				ActionMapping rootAsActionMapping = ActionMapping.GetRootAsActionMapping(new ByteBuffer(item2));
				list.Add(rootAsActionMapping);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActionMappingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActionMappingAll.HandleId, ConfigActionMappingAll.LogPair);
			return list;
		}

		// Token: 0x04000181 RID: 385
		private const string DB = "db_input_settings.db";

		// Token: 0x04000182 RID: 386
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000183 RID: 387
		private const string TABLE = "ActionMapping";

		// Token: 0x04000184 RID: 388
		private const string COMMAND = "select BinData from `ActionMapping`";

		// Token: 0x04000185 RID: 389
		private const string KEY_PREFIX = "ActionMappingAll";

		// Token: 0x04000186 RID: 390
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000187 RID: 391
		private static int HandleId;
	}
}
