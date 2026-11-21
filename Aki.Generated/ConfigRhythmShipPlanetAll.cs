using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000813 RID: 2067
	public class ConfigRhythmShipPlanetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003084 RID: 12420 RVA: 0x0016EF1B File Offset: 0x0016D11B
		static ConfigRhythmShipPlanetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipPlanetAll.CreateStaticDefaultValue), new Action(ConfigRhythmShipPlanetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x0016EF3C File Offset: 0x0016D13C
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

		// Token: 0x06003086 RID: 12422 RVA: 0x0016EFBB File Offset: 0x0016D1BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipPlanetAll.LogPair = null;
			ConfigRhythmShipPlanetAll.HandleId = 0;
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0016EFC9 File Offset: 0x0016D1C9
		public static void Init()
		{
			ConfigRhythmShipPlanetAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipPlanetAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipPlanet`");
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x0016EFE4 File Offset: 0x0016D1E4
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

		// Token: 0x0400386B RID: 14443
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400386C RID: 14444
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400386D RID: 14445
		private const string TABLE = "RhythmShipPlanet";

		// Token: 0x0400386E RID: 14446
		private const string COMMAND = "select BinData from `RhythmShipPlanet`";

		// Token: 0x0400386F RID: 14447
		private const string KEY_PREFIX = "RhythmShipPlanetAll";

		// Token: 0x04003870 RID: 14448
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003871 RID: 14449
		private static int HandleId;
	}
}
