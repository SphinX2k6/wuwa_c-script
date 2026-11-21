using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A5 RID: 2469
	public class ConfigSlashTowerShowStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039F1 RID: 14833 RVA: 0x001A4597 File Offset: 0x001A2797
		static ConfigSlashTowerShowStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerShowStageAll.CreateStaticDefaultValue), new Action(ConfigSlashTowerShowStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x001A45B8 File Offset: 0x001A27B8
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashTowerShowStageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashTowerShowStageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashTowerShowStage"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashTowerShowStage`")
			});
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x001A4637 File Offset: 0x001A2837
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerShowStageAll.LogPair = null;
			ConfigSlashTowerShowStageAll.HandleId = 0;
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x001A4645 File Offset: 0x001A2845
		public static void Init()
		{
			ConfigSlashTowerShowStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerShowStageAll.HandleId, "db_shiptower.db", "select BinData from `SlashTowerShowStage`");
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x001A4660 File Offset: 0x001A2860
		[NullableContext(2)]
		public static IReadOnlyList<SlashTowerShowStage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashTowerShowStageAll.HandleId, ConfigSlashTowerShowStageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SlashTowerShowStage> readOnlyList = (IReadOnlyList<SlashTowerShowStage>)ConfigCommon.GetConfig("SlashTowerShowStageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SlashTowerShowStage> list = new List<SlashTowerShowStage>();
			while (ConfigCommon.Step(ConfigSlashTowerShowStageAll.HandleId, false, ConfigSlashTowerShowStageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashTowerShowStageAll.HandleId, 0, ConfigSlashTowerShowStageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashTowerShowStageAll.HandleId, ConfigSlashTowerShowStageAll.LogPair);
					return null;
				}
				SlashTowerShowStage rootAsSlashTowerShowStage = SlashTowerShowStage.GetRootAsSlashTowerShowStage(new ByteBuffer(item2));
				list.Add(rootAsSlashTowerShowStage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SlashTowerShowStageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashTowerShowStageAll.HandleId, ConfigSlashTowerShowStageAll.LogPair);
			return list;
		}

		// Token: 0x04004369 RID: 17257
		private const string DB = "db_shiptower.db";

		// Token: 0x0400436A RID: 17258
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400436B RID: 17259
		private const string TABLE = "SlashTowerShowStage";

		// Token: 0x0400436C RID: 17260
		private const string COMMAND = "select BinData from `SlashTowerShowStage`";

		// Token: 0x0400436D RID: 17261
		private const string KEY_PREFIX = "SlashTowerShowStageAll";

		// Token: 0x0400436E RID: 17262
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400436F RID: 17263
		private static int HandleId;
	}
}
