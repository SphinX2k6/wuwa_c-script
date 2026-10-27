using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F8 RID: 2040
	public class ConfigRhythmShipPlanetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FE2 RID: 12258 RVA: 0x00167DC7 File Offset: 0x00165FC7
		static ConfigRhythmShipPlanetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipPlanetById.CreateStaticDefaultValue), new Action(ConfigRhythmShipPlanetById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x00167DE8 File Offset: 0x00165FE8
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipPlanetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipPlanetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipPlanet"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipPlanet` where Id=?")
			});
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x00167E67 File Offset: 0x00166067
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipPlanetById.LogPair = null;
			ConfigRhythmShipPlanetById.HandleId = 0;
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00167E75 File Offset: 0x00166075
		public static void Init()
		{
			ConfigRhythmShipPlanetById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipPlanetById.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipPlanet` where Id=?");
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00167E90 File Offset: 0x00166090
		public static RhythmShipPlanet? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipPlanetById.HandleId, ConfigRhythmShipPlanetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipPlanetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmShipPlanet?(RhythmShipPlanet.GetRootAsRhythmShipPlanet(configBuffer));
				}
			}
			ConfigRhythmShipPlanetById.LogPair.Clear();
			ConfigRhythmShipPlanetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmShipPlanetById.HandleId, 1, p0Id, ConfigRhythmShipPlanetById.LogPair) || ConfigCommon.Step(ConfigRhythmShipPlanetById.HandleId, true, ConfigRhythmShipPlanetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmShipPlanetById.HandleId, ConfigRhythmShipPlanetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipPlanetById.HandleId, 0, ConfigRhythmShipPlanetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmShipPlanetById.HandleId, ConfigRhythmShipPlanetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmShipPlanet rootAsRhythmShipPlanet = RhythmShipPlanet.GetRootAsRhythmShipPlanet(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipPlanetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmShipPlanetById.HandleId, ConfigRhythmShipPlanetById.LogPair);
			return new RhythmShipPlanet?(rootAsRhythmShipPlanet);
		}

		// Token: 0x040037AE RID: 14254
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037AF RID: 14255
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037B0 RID: 14256
		private const string TABLE = "RhythmShipPlanet";

		// Token: 0x040037B1 RID: 14257
		private const string COMMAND = "select BinData from `RhythmShipPlanet` where Id=?";

		// Token: 0x040037B2 RID: 14258
		private const string KEY_PREFIX = "RhythmShipPlanetById";

		// Token: 0x040037B3 RID: 14259
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037B4 RID: 14260
		private static int HandleId;
	}
}
