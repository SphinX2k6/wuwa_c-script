using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000815 RID: 2069
	public class ConfigRhythmShipPlanetByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x0016F2F8 File Offset: 0x0016D4F8
		static ConfigRhythmShipPlanetByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipPlanetByType.CreateStaticDefaultValue), new Action(ConfigRhythmShipPlanetByType.ResetStaticDefaultValue));
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x0016F318 File Offset: 0x0016D518
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipPlanetByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipPlanetByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipPlanet"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipPlanet` where Type=?")
			});
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0016F397 File Offset: 0x0016D597
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipPlanetByType.LogPair = null;
			ConfigRhythmShipPlanetByType.HandleId = 0;
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x0016F3A5 File Offset: 0x0016D5A5
		public static void Init()
		{
			ConfigRhythmShipPlanetByType.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipPlanetByType.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipPlanet` where Type=?");
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x0016F3C0 File Offset: 0x0016D5C0
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipPlanet> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipPlanetByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<RhythmShipPlanet> readOnlyList = (IReadOnlyList<RhythmShipPlanet>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRhythmShipPlanetByType.LogPair.Clear();
			ConfigRhythmShipPlanetByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigRhythmShipPlanetByType.HandleId, 1, p0Type, ConfigRhythmShipPlanetByType.LogPair))
			{
				ConfigCommon.Reset(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair);
				return null;
			}
			List<RhythmShipPlanet> list = new List<RhythmShipPlanet>();
			while (ConfigCommon.Step(ConfigRhythmShipPlanetByType.HandleId, false, ConfigRhythmShipPlanetByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipPlanetByType.HandleId, 0, ConfigRhythmShipPlanetByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair);
					return null;
				}
				RhythmShipPlanet rootAsRhythmShipPlanet = RhythmShipPlanet.GetRootAsRhythmShipPlanet(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipPlanet);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipPlanetByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair);
			return list;
		}

		// Token: 0x04003879 RID: 14457
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400387A RID: 14458
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400387B RID: 14459
		private const string TABLE = "RhythmShipPlanet";

		// Token: 0x0400387C RID: 14460
		private const string COMMAND = "select BinData from `RhythmShipPlanet` where Type=?";

		// Token: 0x0400387D RID: 14461
		private const string KEY_PREFIX = "RhythmShipPlanetByType";

		// Token: 0x0400387E RID: 14462
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400387F RID: 14463
		private static int HandleId;
	}
}
