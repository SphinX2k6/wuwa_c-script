using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000786 RID: 1926
	public class ConfigQteInputActionMappingByQteInputActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D35 RID: 11573 RVA: 0x0015C3B4 File Offset: 0x0015A5B4
		static ConfigQteInputActionMappingByQteInputActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQteInputActionMappingByQteInputActionName.CreateStaticDefaultValue), new Action(ConfigQteInputActionMappingByQteInputActionName.ResetStaticDefaultValue));
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0015C3D4 File Offset: 0x0015A5D4
		public static void CreateStaticDefaultValue()
		{
			ConfigQteInputActionMappingByQteInputActionName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQteInputActionMappingByQteInputActionName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "QteInputActionMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `QteInputActionMapping` where QteInputActionName=?")
			});
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x0015C453 File Offset: 0x0015A653
		public static void ResetStaticDefaultValue()
		{
			ConfigQteInputActionMappingByQteInputActionName.LogPair = null;
			ConfigQteInputActionMappingByQteInputActionName.HandleId = 0;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0015C461 File Offset: 0x0015A661
		public static void Init()
		{
			ConfigQteInputActionMappingByQteInputActionName.HandleId = ConfigCommon.InitDataStatement(ConfigQteInputActionMappingByQteInputActionName.HandleId, "db_input_settings.db", "select BinData from `QteInputActionMapping` where QteInputActionName=?");
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x0015C47C File Offset: 0x0015A67C
		[return: Nullable(2)]
		public static IReadOnlyList<QteInputActionMapping> GetConfigList(string p0QteInputActionName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQteInputActionMappingByQteInputActionName.HandleId, ConfigQteInputActionMappingByQteInputActionName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QteInputActionMapping> readOnlyList = (IReadOnlyList<QteInputActionMapping>)ConfigCommon.GetConfig("QteInputActionMappingByQteInputActionName#" + p0QteInputActionName);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigQteInputActionMappingByQteInputActionName.LogPair.Clear();
			ConfigQteInputActionMappingByQteInputActionName.LogPair.Add(new ValueTuple<string, object>("QteInputActionName", p0QteInputActionName));
			if (!ConfigCommon.BindString(ConfigQteInputActionMappingByQteInputActionName.HandleId, 1, p0QteInputActionName, ConfigQteInputActionMappingByQteInputActionName.LogPair))
			{
				ConfigCommon.Reset(ConfigQteInputActionMappingByQteInputActionName.HandleId, ConfigQteInputActionMappingByQteInputActionName.LogPair);
				return null;
			}
			List<QteInputActionMapping> list = new List<QteInputActionMapping>();
			while (ConfigCommon.Step(ConfigQteInputActionMappingByQteInputActionName.HandleId, false, ConfigQteInputActionMappingByQteInputActionName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQteInputActionMappingByQteInputActionName.HandleId, 0, ConfigQteInputActionMappingByQteInputActionName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQteInputActionMappingByQteInputActionName.HandleId, ConfigQteInputActionMappingByQteInputActionName.LogPair);
					return null;
				}
				QteInputActionMapping rootAsQteInputActionMapping = QteInputActionMapping.GetRootAsQteInputActionMapping(new ByteBuffer(item2));
				list.Add(rootAsQteInputActionMapping);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QteInputActionMappingByQteInputActionName#" + p0QteInputActionName, list, list.Count);
			}
			ConfigCommon.Reset(ConfigQteInputActionMappingByQteInputActionName.HandleId, ConfigQteInputActionMappingByQteInputActionName.LogPair);
			return list;
		}

		// Token: 0x04003490 RID: 13456
		private const string DB = "db_input_settings.db";

		// Token: 0x04003491 RID: 13457
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04003492 RID: 13458
		private const string TABLE = "QteInputActionMapping";

		// Token: 0x04003493 RID: 13459
		private const string COMMAND = "select BinData from `QteInputActionMapping` where QteInputActionName=?";

		// Token: 0x04003494 RID: 13460
		private const string KEY_PREFIX = "QteInputActionMappingByQteInputActionName";

		// Token: 0x04003495 RID: 13461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003496 RID: 13462
		private static int HandleId;
	}
}
