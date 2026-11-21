using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049B RID: 1179
	public class ConfigKurotatoBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BAC RID: 7084 RVA: 0x000F9574 File Offset: 0x000F7774
		static ConfigKurotatoBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoBuildAll.CreateStaticDefaultValue), new Action(ConfigKurotatoBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000F9594 File Offset: 0x000F7794
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoBuildAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoBuildAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_抽取规则.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoBuild`")
			});
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000F9613 File Offset: 0x000F7813
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoBuildAll.LogPair = null;
			ConfigKurotatoBuildAll.HandleId = 0;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000F9621 File Offset: 0x000F7821
		public static void Init()
		{
			ConfigKurotatoBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoBuildAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoBuild`");
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000F963C File Offset: 0x000F783C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoBuild> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoBuildAll.HandleId, ConfigKurotatoBuildAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoBuild> readOnlyList = (IReadOnlyList<KurotatoBuild>)ConfigCommon.GetConfig("KurotatoBuildAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoBuild> list = new List<KurotatoBuild>();
			while (ConfigCommon.Step(ConfigKurotatoBuildAll.HandleId, false, ConfigKurotatoBuildAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoBuildAll.HandleId, 0, ConfigKurotatoBuildAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoBuildAll.HandleId, ConfigKurotatoBuildAll.LogPair);
					return null;
				}
				KurotatoBuild rootAsKurotatoBuild = KurotatoBuild.GetRootAsKurotatoBuild(new ByteBuffer(item2));
				list.Add(rootAsKurotatoBuild);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoBuildAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoBuildAll.HandleId, ConfigKurotatoBuildAll.LogPair);
			return list;
		}

		// Token: 0x04002021 RID: 8225
		private const string DB = "db_kurotato.db";

		// Token: 0x04002022 RID: 8226
		private const string FILE = "t.土豆兄弟_抽取规则.xlsx";

		// Token: 0x04002023 RID: 8227
		private const string TABLE = "KurotatoBuild";

		// Token: 0x04002024 RID: 8228
		private const string COMMAND = "select BinData from `KurotatoBuild`";

		// Token: 0x04002025 RID: 8229
		private const string KEY_PREFIX = "KurotatoBuildAll";

		// Token: 0x04002026 RID: 8230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002027 RID: 8231
		private static int HandleId;
	}
}
