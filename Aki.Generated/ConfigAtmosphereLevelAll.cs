using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B5 RID: 181
	public class ConfigAtmosphereLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00071C30 File Offset: 0x0006FE30
		static ConfigAtmosphereLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelAll.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00071C50 File Offset: 0x0006FE50
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

		// Token: 0x06000441 RID: 1089 RVA: 0x00071CCF File Offset: 0x0006FECF
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelAll.LogPair = null;
			ConfigAtmosphereLevelAll.HandleId = 0;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00071CDD File Offset: 0x0006FEDD
		public static void Init()
		{
			ConfigAtmosphereLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelAll.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel`");
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00071CF8 File Offset: 0x0006FEF8
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

		// Token: 0x040004D7 RID: 1239
		private const string DB = "db_spring26.db";

		// Token: 0x040004D8 RID: 1240
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040004D9 RID: 1241
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x040004DA RID: 1242
		private const string COMMAND = "select BinData from `AtmosphereLevel`";

		// Token: 0x040004DB RID: 1243
		private const string KEY_PREFIX = "AtmosphereLevelAll";

		// Token: 0x040004DC RID: 1244
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004DD RID: 1245
		private static int HandleId;
	}
}
