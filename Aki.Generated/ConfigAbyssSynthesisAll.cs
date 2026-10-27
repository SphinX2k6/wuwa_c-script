using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000030 RID: 48
	public class ConfigAbyssSynthesisAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000120 RID: 288 RVA: 0x0006024C File Offset: 0x0005E44C
		static ConfigAbyssSynthesisAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssSynthesisAll.CreateStaticDefaultValue), new Action(ConfigAbyssSynthesisAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0006026C File Offset: 0x0005E46C
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssSynthesisAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssSynthesisAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssSynthesis"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssSynthesis`")
			});
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000602EB File Offset: 0x0005E4EB
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssSynthesisAll.LogPair = null;
			ConfigAbyssSynthesisAll.HandleId = 0;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000602F9 File Offset: 0x0005E4F9
		public static void Init()
		{
			ConfigAbyssSynthesisAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssSynthesisAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssSynthesis`");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00060314 File Offset: 0x0005E514
		[NullableContext(2)]
		public static IReadOnlyList<AbyssSynthesis> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssSynthesisAll.HandleId, ConfigAbyssSynthesisAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssSynthesis> readOnlyList = (IReadOnlyList<AbyssSynthesis>)ConfigCommon.GetConfig("AbyssSynthesisAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssSynthesis> list = new List<AbyssSynthesis>();
			while (ConfigCommon.Step(ConfigAbyssSynthesisAll.HandleId, false, ConfigAbyssSynthesisAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssSynthesisAll.HandleId, 0, ConfigAbyssSynthesisAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssSynthesisAll.HandleId, ConfigAbyssSynthesisAll.LogPair);
					return null;
				}
				AbyssSynthesis rootAsAbyssSynthesis = AbyssSynthesis.GetRootAsAbyssSynthesis(new ByteBuffer(item2));
				list.Add(rootAsAbyssSynthesis);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssSynthesisAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssSynthesisAll.HandleId, ConfigAbyssSynthesisAll.LogPair);
			return list;
		}

		// Token: 0x04000134 RID: 308
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x04000135 RID: 309
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x04000136 RID: 310
		private const string TABLE = "AbyssSynthesis";

		// Token: 0x04000137 RID: 311
		private const string COMMAND = "select BinData from `AbyssSynthesis`";

		// Token: 0x04000138 RID: 312
		private const string KEY_PREFIX = "AbyssSynthesisAll";

		// Token: 0x04000139 RID: 313
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400013A RID: 314
		private static int HandleId;
	}
}
