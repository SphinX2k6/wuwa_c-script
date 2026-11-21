using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E7 RID: 999
	public class ConfigHeadIconEnergyBarAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001771 RID: 6001 RVA: 0x000E1928 File Offset: 0x000DFB28
		static ConfigHeadIconEnergyBarAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHeadIconEnergyBarAll.CreateStaticDefaultValue), new Action(ConfigHeadIconEnergyBarAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000E1948 File Offset: 0x000DFB48
		public static void CreateStaticDefaultValue()
		{
			ConfigHeadIconEnergyBarAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHeadIconEnergyBarAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battleheadicon.db"),
				new ValueTuple<string, object>("文件", "j.角色战斗界面头像.xlsx"),
				new ValueTuple<string, object>("表名", "HeadIconEnergyBar"),
				new ValueTuple<string, object>("语句", "select BinData from `HeadIconEnergyBar`")
			});
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x000E19C7 File Offset: 0x000DFBC7
		public static void ResetStaticDefaultValue()
		{
			ConfigHeadIconEnergyBarAll.LogPair = null;
			ConfigHeadIconEnergyBarAll.HandleId = 0;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000E19D5 File Offset: 0x000DFBD5
		public static void Init()
		{
			ConfigHeadIconEnergyBarAll.HandleId = ConfigCommon.InitDataStatement(ConfigHeadIconEnergyBarAll.HandleId, "db_battleheadicon.db", "select BinData from `HeadIconEnergyBar`");
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000E19F0 File Offset: 0x000DFBF0
		[NullableContext(2)]
		public static IReadOnlyList<HeadIconEnergyBar> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHeadIconEnergyBarAll.HandleId, ConfigHeadIconEnergyBarAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HeadIconEnergyBar> readOnlyList = (IReadOnlyList<HeadIconEnergyBar>)ConfigCommon.GetConfig("HeadIconEnergyBarAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HeadIconEnergyBar> list = new List<HeadIconEnergyBar>();
			while (ConfigCommon.Step(ConfigHeadIconEnergyBarAll.HandleId, false, ConfigHeadIconEnergyBarAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHeadIconEnergyBarAll.HandleId, 0, ConfigHeadIconEnergyBarAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHeadIconEnergyBarAll.HandleId, ConfigHeadIconEnergyBarAll.LogPair);
					return null;
				}
				HeadIconEnergyBar rootAsHeadIconEnergyBar = HeadIconEnergyBar.GetRootAsHeadIconEnergyBar(new ByteBuffer(item2));
				list.Add(rootAsHeadIconEnergyBar);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HeadIconEnergyBarAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHeadIconEnergyBarAll.HandleId, ConfigHeadIconEnergyBarAll.LogPair);
			return list;
		}

		// Token: 0x04001B35 RID: 6965
		private const string DB = "db_battleheadicon.db";

		// Token: 0x04001B36 RID: 6966
		private const string FILE = "j.角色战斗界面头像.xlsx";

		// Token: 0x04001B37 RID: 6967
		private const string TABLE = "HeadIconEnergyBar";

		// Token: 0x04001B38 RID: 6968
		private const string COMMAND = "select BinData from `HeadIconEnergyBar`";

		// Token: 0x04001B39 RID: 6969
		private const string KEY_PREFIX = "HeadIconEnergyBarAll";

		// Token: 0x04001B3A RID: 6970
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B3B RID: 6971
		private static int HandleId;
	}
}
