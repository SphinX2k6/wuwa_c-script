using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000814 RID: 2068
	public class ConfigRhythmShipPlanetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600308A RID: 12426 RVA: 0x0016F0AF File Offset: 0x0016D2AF
		static ConfigRhythmShipPlanetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipPlanetById.CreateStaticDefaultValue), new Action(ConfigRhythmShipPlanetById.ResetStaticDefaultValue));
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x0016F0D0 File Offset: 0x0016D2D0
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

		// Token: 0x0600308C RID: 12428 RVA: 0x0016F14F File Offset: 0x0016D34F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipPlanetById.LogPair = null;
			ConfigRhythmShipPlanetById.HandleId = 0;
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x0016F15D File Offset: 0x0016D35D
		public static void Init()
		{
			ConfigRhythmShipPlanetById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipPlanetById.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipPlanet` where Id=?");
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x0016F178 File Offset: 0x0016D378
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

		// Token: 0x04003872 RID: 14450
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003873 RID: 14451
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003874 RID: 14452
		private const string TABLE = "RhythmShipPlanet";

		// Token: 0x04003875 RID: 14453
		private const string COMMAND = "select BinData from `RhythmShipPlanet` where Id=?";

		// Token: 0x04003876 RID: 14454
		private const string KEY_PREFIX = "RhythmShipPlanetById";

		// Token: 0x04003877 RID: 14455
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003878 RID: 14456
		private static int HandleId;
	}
}
