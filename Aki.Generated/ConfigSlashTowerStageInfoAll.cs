using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095B RID: 2395
	public class ConfigSlashTowerStageInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003835 RID: 14389 RVA: 0x0019750B File Offset: 0x0019570B
		static ConfigSlashTowerStageInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerStageInfoAll.CreateStaticDefaultValue), new Action(ConfigSlashTowerStageInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x0019752C File Offset: 0x0019572C
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashTowerStageInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashTowerStageInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashTowerStageInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashTowerStageInfo`")
			});
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x001975AB File Offset: 0x001957AB
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerStageInfoAll.LogPair = null;
			ConfigSlashTowerStageInfoAll.HandleId = 0;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x001975B9 File Offset: 0x001957B9
		public static void Init()
		{
			ConfigSlashTowerStageInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerStageInfoAll.HandleId, "db_shiptower.db", "select BinData from `SlashTowerStageInfo`");
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x001975D4 File Offset: 0x001957D4
		[NullableContext(2)]
		public static IReadOnlyList<SlashTowerStageInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashTowerStageInfoAll.HandleId, ConfigSlashTowerStageInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SlashTowerStageInfo> readOnlyList = (IReadOnlyList<SlashTowerStageInfo>)ConfigCommon.GetConfig("SlashTowerStageInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SlashTowerStageInfo> list = new List<SlashTowerStageInfo>();
			while (ConfigCommon.Step(ConfigSlashTowerStageInfoAll.HandleId, false, ConfigSlashTowerStageInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashTowerStageInfoAll.HandleId, 0, ConfigSlashTowerStageInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashTowerStageInfoAll.HandleId, ConfigSlashTowerStageInfoAll.LogPair);
					return null;
				}
				SlashTowerStageInfo rootAsSlashTowerStageInfo = SlashTowerStageInfo.GetRootAsSlashTowerStageInfo(new ByteBuffer(item2));
				list.Add(rootAsSlashTowerStageInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SlashTowerStageInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashTowerStageInfoAll.HandleId, ConfigSlashTowerStageInfoAll.LogPair);
			return list;
		}

		// Token: 0x04004163 RID: 16739
		private const string DB = "db_shiptower.db";

		// Token: 0x04004164 RID: 16740
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004165 RID: 16741
		private const string TABLE = "SlashTowerStageInfo";

		// Token: 0x04004166 RID: 16742
		private const string COMMAND = "select BinData from `SlashTowerStageInfo`";

		// Token: 0x04004167 RID: 16743
		private const string KEY_PREFIX = "SlashTowerStageInfoAll";

		// Token: 0x04004168 RID: 16744
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004169 RID: 16745
		private static int HandleId;
	}
}
