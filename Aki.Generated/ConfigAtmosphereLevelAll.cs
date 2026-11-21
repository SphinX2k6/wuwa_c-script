using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BD RID: 189
	public class ConfigAtmosphereLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x000764E4 File Offset: 0x000746E4
		static ConfigAtmosphereLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelAll.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00076504 File Offset: 0x00074704
		public static void CreateStaticDefaultValue()
		{
			ConfigAtmosphereLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAtmosphereLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "AtmosphereLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AtmosphereLevel`")
			});
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00076583 File Offset: 0x00074783
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelAll.LogPair = null;
			ConfigAtmosphereLevelAll.HandleId = 0;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00076591 File Offset: 0x00074791
		public static void Init()
		{
			ConfigAtmosphereLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelAll.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel`");
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000765AC File Offset: 0x000747AC
		[NullableContext(2)]
		public static IReadOnlyList<AtmosphereLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAtmosphereLevelAll.HandleId, ConfigAtmosphereLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AtmosphereLevel> readOnlyList = (IReadOnlyList<AtmosphereLevel>)ConfigCommon.GetConfig("AtmosphereLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AtmosphereLevel> list = new List<AtmosphereLevel>();
			while (ConfigCommon.Step(ConfigAtmosphereLevelAll.HandleId, false, ConfigAtmosphereLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAtmosphereLevelAll.HandleId, 0, ConfigAtmosphereLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAtmosphereLevelAll.HandleId, ConfigAtmosphereLevelAll.LogPair);
					return null;
				}
				AtmosphereLevel rootAsAtmosphereLevel = AtmosphereLevel.GetRootAsAtmosphereLevel(new ByteBuffer(item2));
				list.Add(rootAsAtmosphereLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AtmosphereLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAtmosphereLevelAll.HandleId, ConfigAtmosphereLevelAll.LogPair);
			return list;
		}

		// Token: 0x0400050F RID: 1295
		private const string DB = "db_spring26.db";

		// Token: 0x04000510 RID: 1296
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04000511 RID: 1297
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x04000512 RID: 1298
		private const string COMMAND = "select BinData from `AtmosphereLevel`";

		// Token: 0x04000513 RID: 1299
		private const string KEY_PREFIX = "AtmosphereLevelAll";

		// Token: 0x04000514 RID: 1300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000515 RID: 1301
		private static int HandleId;
	}
}
