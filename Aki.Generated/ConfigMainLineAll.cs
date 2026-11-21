using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000519 RID: 1305
	public class ConfigMainLineAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EA1 RID: 7841 RVA: 0x00109E5C File Offset: 0x0010805C
		static ConfigMainLineAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainLineAll.CreateStaticDefaultValue), new Action(ConfigMainLineAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00109E7C File Offset: 0x0010807C
		public static void CreateStaticDefaultValue()
		{
			ConfigMainLineAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainLineAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "MainLine"),
				new ValueTuple<string, object>("语句", "select BinData from `MainLine`")
			});
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00109EFB File Offset: 0x001080FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMainLineAll.LogPair = null;
			ConfigMainLineAll.HandleId = 0;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00109F09 File Offset: 0x00108109
		public static void Init()
		{
			ConfigMainLineAll.HandleId = ConfigCommon.InitDataStatement(ConfigMainLineAll.HandleId, "db_moonchasing.db", "select BinData from `MainLine`");
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00109F24 File Offset: 0x00108124
		[NullableContext(2)]
		public static IReadOnlyList<MainLine> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainLineAll.HandleId, ConfigMainLineAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MainLine> readOnlyList = (IReadOnlyList<MainLine>)ConfigCommon.GetConfig("MainLineAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MainLine> list = new List<MainLine>();
			while (ConfigCommon.Step(ConfigMainLineAll.HandleId, false, ConfigMainLineAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainLineAll.HandleId, 0, ConfigMainLineAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMainLineAll.HandleId, ConfigMainLineAll.LogPair);
					return null;
				}
				MainLine rootAsMainLine = MainLine.GetRootAsMainLine(new ByteBuffer(item2));
				list.Add(rootAsMainLine);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MainLineAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMainLineAll.HandleId, ConfigMainLineAll.LogPair);
			return list;
		}

		// Token: 0x04002393 RID: 9107
		private const string DB = "db_moonchasing.db";

		// Token: 0x04002394 RID: 9108
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04002395 RID: 9109
		private const string TABLE = "MainLine";

		// Token: 0x04002396 RID: 9110
		private const string COMMAND = "select BinData from `MainLine`";

		// Token: 0x04002397 RID: 9111
		private const string KEY_PREFIX = "MainLineAll";

		// Token: 0x04002398 RID: 9112
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002399 RID: 9113
		private static int HandleId;
	}
}
