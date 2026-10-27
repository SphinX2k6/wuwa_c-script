using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FC RID: 1532
	public class ConfigNewTowerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023F8 RID: 9208 RVA: 0x00124F14 File Offset: 0x00123114
		static ConfigNewTowerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerLevelAll.CreateStaticDefaultValue), new Action(ConfigNewTowerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00124F34 File Offset: 0x00123134
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerLevel`")
			});
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00124FB3 File Offset: 0x001231B3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerLevelAll.LogPair = null;
			ConfigNewTowerLevelAll.HandleId = 0;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00124FC1 File Offset: 0x001231C1
		public static void Init()
		{
			ConfigNewTowerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerLevelAll.HandleId, "db_newtower.db", "select BinData from `NewTowerLevel`");
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00124FDC File Offset: 0x001231DC
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerLevelAll.HandleId, ConfigNewTowerLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewTowerLevel> readOnlyList = (IReadOnlyList<NewTowerLevel>)ConfigCommon.GetConfig("NewTowerLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewTowerLevel> list = new List<NewTowerLevel>();
			while (ConfigCommon.Step(ConfigNewTowerLevelAll.HandleId, false, ConfigNewTowerLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerLevelAll.HandleId, 0, ConfigNewTowerLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerLevelAll.HandleId, ConfigNewTowerLevelAll.LogPair);
					return null;
				}
				NewTowerLevel rootAsNewTowerLevel = NewTowerLevel.GetRootAsNewTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsNewTowerLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewTowerLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerLevelAll.HandleId, ConfigNewTowerLevelAll.LogPair);
			return list;
		}

		// Token: 0x040029CA RID: 10698
		private const string DB = "db_newtower.db";

		// Token: 0x040029CB RID: 10699
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029CC RID: 10700
		private const string TABLE = "NewTowerLevel";

		// Token: 0x040029CD RID: 10701
		private const string COMMAND = "select BinData from `NewTowerLevel`";

		// Token: 0x040029CE RID: 10702
		private const string KEY_PREFIX = "NewTowerLevelAll";

		// Token: 0x040029CF RID: 10703
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029D0 RID: 10704
		private static int HandleId;
	}
}
