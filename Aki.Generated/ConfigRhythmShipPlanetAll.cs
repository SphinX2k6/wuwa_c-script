using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F7 RID: 2039
	public class ConfigRhythmShipPlanetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FDC RID: 12252 RVA: 0x00167C33 File Offset: 0x00165E33
		static ConfigRhythmShipPlanetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipPlanetAll.CreateStaticDefaultValue), new Action(ConfigRhythmShipPlanetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00167C54 File Offset: 0x00165E54
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipPlanetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipPlanetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipPlanet"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipPlanet`")
			});
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00167CD3 File Offset: 0x00165ED3
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipPlanetAll.LogPair = null;
			ConfigRhythmShipPlanetAll.HandleId = 0;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00167CE1 File Offset: 0x00165EE1
		public static void Init()
		{
			ConfigRhythmShipPlanetAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipPlanetAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipPlanet`");
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00167CFC File Offset: 0x00165EFC
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipPlanet> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipPlanetAll.HandleId, ConfigRhythmShipPlanetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RhythmShipPlanet> readOnlyList = (IReadOnlyList<RhythmShipPlanet>)ConfigCommon.GetConfig("RhythmShipPlanetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RhythmShipPlanet> list = new List<RhythmShipPlanet>();
			while (ConfigCommon.Step(ConfigRhythmShipPlanetAll.HandleId, false, ConfigRhythmShipPlanetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipPlanetAll.HandleId, 0, ConfigRhythmShipPlanetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipPlanetAll.HandleId, ConfigRhythmShipPlanetAll.LogPair);
					return null;
				}
				RhythmShipPlanet rootAsRhythmShipPlanet = RhythmShipPlanet.GetRootAsRhythmShipPlanet(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipPlanet);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RhythmShipPlanetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipPlanetAll.HandleId, ConfigRhythmShipPlanetAll.LogPair);
			return list;
		}

		// Token: 0x040037A7 RID: 14247
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037A8 RID: 14248
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037A9 RID: 14249
		private const string TABLE = "RhythmShipPlanet";

		// Token: 0x040037AA RID: 14250
		private const string COMMAND = "select BinData from `RhythmShipPlanet`";

		// Token: 0x040037AB RID: 14251
		private const string KEY_PREFIX = "RhythmShipPlanetAll";

		// Token: 0x040037AC RID: 14252
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037AD RID: 14253
		private static int HandleId;
	}
}
