using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000629 RID: 1577
	public class ConfigOnlineMotorLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002506 RID: 9478 RVA: 0x0012B0E4 File Offset: 0x001292E4
		static ConfigOnlineMotorLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelAll.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x0012B104 File Offset: 0x00129304
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorLevel`")
			});
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0012B183 File Offset: 0x00129383
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelAll.LogPair = null;
			ConfigOnlineMotorLevelAll.HandleId = 0;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x0012B191 File Offset: 0x00129391
		public static void Init()
		{
			ConfigOnlineMotorLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelAll.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevel`");
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0012B1AC File Offset: 0x001293AC
		[NullableContext(2)]
		public static IReadOnlyList<OnlineMotorLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorLevelAll.HandleId, ConfigOnlineMotorLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<OnlineMotorLevel> readOnlyList = (IReadOnlyList<OnlineMotorLevel>)ConfigCommon.GetConfig("OnlineMotorLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<OnlineMotorLevel> list = new List<OnlineMotorLevel>();
			while (ConfigCommon.Step(ConfigOnlineMotorLevelAll.HandleId, false, ConfigOnlineMotorLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorLevelAll.HandleId, 0, ConfigOnlineMotorLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOnlineMotorLevelAll.HandleId, ConfigOnlineMotorLevelAll.LogPair);
					return null;
				}
				OnlineMotorLevel rootAsOnlineMotorLevel = OnlineMotorLevel.GetRootAsOnlineMotorLevel(new ByteBuffer(item2));
				list.Add(rootAsOnlineMotorLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OnlineMotorLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigOnlineMotorLevelAll.HandleId, ConfigOnlineMotorLevelAll.LogPair);
			return list;
		}

		// Token: 0x04002B05 RID: 11013
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002B06 RID: 11014
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002B07 RID: 11015
		private const string TABLE = "OnlineMotorLevel";

		// Token: 0x04002B08 RID: 11016
		private const string COMMAND = "select BinData from `OnlineMotorLevel`";

		// Token: 0x04002B09 RID: 11017
		private const string KEY_PREFIX = "OnlineMotorLevelAll";

		// Token: 0x04002B0A RID: 11018
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B0B RID: 11019
		private static int HandleId;
	}
}
