using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095A RID: 2394
	public class ConfigSlashTowerShowStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600382F RID: 14383 RVA: 0x00197377 File Offset: 0x00195577
		static ConfigSlashTowerShowStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerShowStageAll.CreateStaticDefaultValue), new Action(ConfigSlashTowerShowStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00197398 File Offset: 0x00195598
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

		// Token: 0x06003831 RID: 14385 RVA: 0x00197417 File Offset: 0x00195617
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerShowStageAll.LogPair = null;
			ConfigSlashTowerShowStageAll.HandleId = 0;
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00197425 File Offset: 0x00195625
		public static void Init()
		{
			ConfigSlashTowerShowStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerShowStageAll.HandleId, "db_shiptower.db", "select BinData from `SlashTowerShowStage`");
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x00197440 File Offset: 0x00195640
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

		// Token: 0x0400415C RID: 16732
		private const string DB = "db_shiptower.db";

		// Token: 0x0400415D RID: 16733
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400415E RID: 16734
		private const string TABLE = "SlashTowerShowStage";

		// Token: 0x0400415F RID: 16735
		private const string COMMAND = "select BinData from `SlashTowerShowStage`";

		// Token: 0x04004160 RID: 16736
		private const string KEY_PREFIX = "SlashTowerShowStageAll";

		// Token: 0x04004161 RID: 16737
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004162 RID: 16738
		private static int HandleId;
	}
}
