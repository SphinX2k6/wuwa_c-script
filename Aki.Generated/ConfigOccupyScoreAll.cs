using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063C RID: 1596
	public class ConfigOccupyScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002578 RID: 9592 RVA: 0x001310BD File Offset: 0x0012F2BD
		static ConfigOccupyScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupyScoreAll.CreateStaticDefaultValue), new Action(ConfigOccupyScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x001310DC File Offset: 0x0012F2DC
		public static void CreateStaticDefaultValue()
		{
			ConfigOccupyScoreAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOccupyScoreAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "OccupyScore"),
				new ValueTuple<string, object>("语句", "select BinData from `OccupyScore`")
			});
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0013115B File Offset: 0x0012F35B
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupyScoreAll.LogPair = null;
			ConfigOccupyScoreAll.HandleId = 0;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00131169 File Offset: 0x0012F369
		public static void Init()
		{
			ConfigOccupyScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigOccupyScoreAll.HandleId, "db_moraleplay.db", "select BinData from `OccupyScore`");
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00131184 File Offset: 0x0012F384
		[NullableContext(2)]
		public static IReadOnlyList<OccupyScore> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOccupyScoreAll.HandleId, ConfigOccupyScoreAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<OccupyScore> readOnlyList = (IReadOnlyList<OccupyScore>)ConfigCommon.GetConfig("OccupyScoreAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<OccupyScore> list = new List<OccupyScore>();
			while (ConfigCommon.Step(ConfigOccupyScoreAll.HandleId, false, ConfigOccupyScoreAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOccupyScoreAll.HandleId, 0, ConfigOccupyScoreAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOccupyScoreAll.HandleId, ConfigOccupyScoreAll.LogPair);
					return null;
				}
				OccupyScore rootAsOccupyScore = OccupyScore.GetRootAsOccupyScore(new ByteBuffer(item2));
				list.Add(rootAsOccupyScore);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OccupyScoreAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigOccupyScoreAll.HandleId, ConfigOccupyScoreAll.LogPair);
			return list;
		}

		// Token: 0x04002B8A RID: 11146
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002B8B RID: 11147
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002B8C RID: 11148
		private const string TABLE = "OccupyScore";

		// Token: 0x04002B8D RID: 11149
		private const string COMMAND = "select BinData from `OccupyScore`";

		// Token: 0x04002B8E RID: 11150
		private const string KEY_PREFIX = "OccupyScoreAll";

		// Token: 0x04002B8F RID: 11151
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B90 RID: 11152
		private static int HandleId;
	}
}
