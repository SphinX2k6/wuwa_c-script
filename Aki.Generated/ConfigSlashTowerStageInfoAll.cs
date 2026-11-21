using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A6 RID: 2470
	public class ConfigSlashTowerStageInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039F7 RID: 14839 RVA: 0x001A472B File Offset: 0x001A292B
		static ConfigSlashTowerStageInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerStageInfoAll.CreateStaticDefaultValue), new Action(ConfigSlashTowerStageInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x001A474C File Offset: 0x001A294C
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

		// Token: 0x060039F9 RID: 14841 RVA: 0x001A47CB File Offset: 0x001A29CB
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerStageInfoAll.LogPair = null;
			ConfigSlashTowerStageInfoAll.HandleId = 0;
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x001A47D9 File Offset: 0x001A29D9
		public static void Init()
		{
			ConfigSlashTowerStageInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerStageInfoAll.HandleId, "db_shiptower.db", "select BinData from `SlashTowerStageInfo`");
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x001A47F4 File Offset: 0x001A29F4
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

		// Token: 0x04004370 RID: 17264
		private const string DB = "db_shiptower.db";

		// Token: 0x04004371 RID: 17265
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004372 RID: 17266
		private const string TABLE = "SlashTowerStageInfo";

		// Token: 0x04004373 RID: 17267
		private const string COMMAND = "select BinData from `SlashTowerStageInfo`";

		// Token: 0x04004374 RID: 17268
		private const string KEY_PREFIX = "SlashTowerStageInfoAll";

		// Token: 0x04004375 RID: 17269
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004376 RID: 17270
		private static int HandleId;
	}
}
