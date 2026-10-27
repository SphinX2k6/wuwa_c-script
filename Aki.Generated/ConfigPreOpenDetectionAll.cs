using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075F RID: 1887
	public class ConfigPreOpenDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C4B RID: 11339 RVA: 0x00153AD4 File Offset: 0x00151CD4
		static ConfigPreOpenDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreOpenDetectionAll.CreateStaticDefaultValue), new Action(ConfigPreOpenDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00153AF4 File Offset: 0x00151CF4
		public static void CreateStaticDefaultValue()
		{
			ConfigPreOpenDetectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreOpenDetectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "PreOpenDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `PreOpenDetection`")
			});
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00153B73 File Offset: 0x00151D73
		public static void ResetStaticDefaultValue()
		{
			ConfigPreOpenDetectionAll.LogPair = null;
			ConfigPreOpenDetectionAll.HandleId = 0;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x00153B81 File Offset: 0x00151D81
		public static void Init()
		{
			ConfigPreOpenDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreOpenDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `PreOpenDetection`");
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00153B9C File Offset: 0x00151D9C
		[NullableContext(2)]
		public static IReadOnlyList<PreOpenDetection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreOpenDetectionAll.HandleId, ConfigPreOpenDetectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreOpenDetection> readOnlyList = (IReadOnlyList<PreOpenDetection>)ConfigCommon.GetConfig("PreOpenDetectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreOpenDetection> list = new List<PreOpenDetection>();
			while (ConfigCommon.Step(ConfigPreOpenDetectionAll.HandleId, false, ConfigPreOpenDetectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreOpenDetectionAll.HandleId, 0, ConfigPreOpenDetectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreOpenDetectionAll.HandleId, ConfigPreOpenDetectionAll.LogPair);
					return null;
				}
				PreOpenDetection rootAsPreOpenDetection = PreOpenDetection.GetRootAsPreOpenDetection(new ByteBuffer(item2));
				list.Add(rootAsPreOpenDetection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreOpenDetectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreOpenDetectionAll.HandleId, ConfigPreOpenDetectionAll.LogPair);
			return list;
		}

		// Token: 0x0400337F RID: 13183
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04003380 RID: 13184
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04003381 RID: 13185
		private const string TABLE = "PreOpenDetection";

		// Token: 0x04003382 RID: 13186
		private const string COMMAND = "select BinData from `PreOpenDetection`";

		// Token: 0x04003383 RID: 13187
		private const string KEY_PREFIX = "PreOpenDetectionAll";

		// Token: 0x04003384 RID: 13188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003385 RID: 13189
		private static int HandleId;
	}
}
