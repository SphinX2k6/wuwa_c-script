using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076C RID: 1900
	public class ConfigQteInputActionMappingByQteInputActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C99 RID: 11417 RVA: 0x001554A8 File Offset: 0x001536A8
		static ConfigQteInputActionMappingByQteInputActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQteInputActionMappingByQteInputActionName.CreateStaticDefaultValue), new Action(ConfigQteInputActionMappingByQteInputActionName.ResetStaticDefaultValue));
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x001554C8 File Offset: 0x001536C8
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

		// Token: 0x06002C9B RID: 11419 RVA: 0x00155547 File Offset: 0x00153747
		public static void ResetStaticDefaultValue()
		{
			ConfigQteInputActionMappingByQteInputActionName.LogPair = null;
			ConfigQteInputActionMappingByQteInputActionName.HandleId = 0;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x00155555 File Offset: 0x00153755
		public static void Init()
		{
			ConfigQteInputActionMappingByQteInputActionName.HandleId = ConfigCommon.InitDataStatement(ConfigQteInputActionMappingByQteInputActionName.HandleId, "db_input_settings.db", "select BinData from `QteInputActionMapping` where QteInputActionName=?");
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00155570 File Offset: 0x00153770
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

		// Token: 0x040033DA RID: 13274
		private const string DB = "db_input_settings.db";

		// Token: 0x040033DB RID: 13275
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040033DC RID: 13276
		private const string TABLE = "QteInputActionMapping";

		// Token: 0x040033DD RID: 13277
		private const string COMMAND = "select BinData from `QteInputActionMapping` where QteInputActionName=?";

		// Token: 0x040033DE RID: 13278
		private const string KEY_PREFIX = "QteInputActionMappingByQteInputActionName";

		// Token: 0x040033DF RID: 13279
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033E0 RID: 13280
		private static int HandleId;
	}
}
