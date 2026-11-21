using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E0 RID: 1248
	public class ConfigLevelCustomPrimitiveDataAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D4B RID: 7499 RVA: 0x0010243C File Offset: 0x0010063C
		static ConfigLevelCustomPrimitiveDataAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelCustomPrimitiveDataAll.CreateStaticDefaultValue), new Action(ConfigLevelCustomPrimitiveDataAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0010245C File Offset: 0x0010065C
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelCustomPrimitiveDataAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelCustomPrimitiveDataAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelcustomprimitivedata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/LevelPlay/CustomPrimitiveData_*"),
				new ValueTuple<string, object>("表名", "LevelCustomPrimitiveData"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelCustomPrimitiveData`")
			});
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x001024DB File Offset: 0x001006DB
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelCustomPrimitiveDataAll.LogPair = null;
			ConfigLevelCustomPrimitiveDataAll.HandleId = 0;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x001024E9 File Offset: 0x001006E9
		public static void Init()
		{
			ConfigLevelCustomPrimitiveDataAll.HandleId = ConfigCommon.InitDataStatement(ConfigLevelCustomPrimitiveDataAll.HandleId, "db_levelcustomprimitivedata.db", "select BinData from `LevelCustomPrimitiveData`");
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00102504 File Offset: 0x00100704
		[NullableContext(2)]
		public static IReadOnlyList<LevelCustomPrimitiveData> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelCustomPrimitiveDataAll.HandleId, ConfigLevelCustomPrimitiveDataAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LevelCustomPrimitiveData> readOnlyList = (IReadOnlyList<LevelCustomPrimitiveData>)ConfigCommon.GetConfig("LevelCustomPrimitiveDataAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LevelCustomPrimitiveData> list = new List<LevelCustomPrimitiveData>();
			while (ConfigCommon.Step(ConfigLevelCustomPrimitiveDataAll.HandleId, false, ConfigLevelCustomPrimitiveDataAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelCustomPrimitiveDataAll.HandleId, 0, ConfigLevelCustomPrimitiveDataAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLevelCustomPrimitiveDataAll.HandleId, ConfigLevelCustomPrimitiveDataAll.LogPair);
					return null;
				}
				LevelCustomPrimitiveData rootAsLevelCustomPrimitiveData = LevelCustomPrimitiveData.GetRootAsLevelCustomPrimitiveData(new ByteBuffer(item2));
				list.Add(rootAsLevelCustomPrimitiveData);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LevelCustomPrimitiveDataAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLevelCustomPrimitiveDataAll.HandleId, ConfigLevelCustomPrimitiveDataAll.LogPair);
			return list;
		}

		// Token: 0x04002204 RID: 8708
		private const string DB = "db_levelcustomprimitivedata.db";

		// Token: 0x04002205 RID: 8709
		private const string FILE = "UniverseEditor/LevelPlay/CustomPrimitiveData_*";

		// Token: 0x04002206 RID: 8710
		private const string TABLE = "LevelCustomPrimitiveData";

		// Token: 0x04002207 RID: 8711
		private const string COMMAND = "select BinData from `LevelCustomPrimitiveData`";

		// Token: 0x04002208 RID: 8712
		private const string KEY_PREFIX = "LevelCustomPrimitiveDataAll";

		// Token: 0x04002209 RID: 8713
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400220A RID: 8714
		private static int HandleId;
	}
}
