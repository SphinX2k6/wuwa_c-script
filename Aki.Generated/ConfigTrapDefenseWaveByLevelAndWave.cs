using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A46 RID: 2630
	public class ConfigTrapDefenseWaveByLevelAndWave : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DB8 RID: 15800 RVA: 0x001B6CF4 File Offset: 0x001B4EF4
		static ConfigTrapDefenseWaveByLevelAndWave()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseWaveByLevelAndWave.CreateStaticDefaultValue), new Action(ConfigTrapDefenseWaveByLevelAndWave.ResetStaticDefaultValue));
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001B6D14 File Offset: 0x001B4F14
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseWaveByLevelAndWave.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseWaveByLevelAndWave.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseWave"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=? And WaveId=?")
			});
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x001B6D93 File Offset: 0x001B4F93
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseWaveByLevelAndWave.LogPair = null;
			ConfigTrapDefenseWaveByLevelAndWave.HandleId = 0;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x001B6DA1 File Offset: 0x001B4FA1
		public static void Init()
		{
			ConfigTrapDefenseWaveByLevelAndWave.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseWaveByLevelAndWave.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=? And WaveId=?");
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x001B6DBC File Offset: 0x001B4FBC
		public static TrapDefenseWave? GetConfig(int p0TrapDefenseLevelId, int p1WaveId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseWaveByLevelAndWave.HandleId, ConfigTrapDefenseWaveByLevelAndWave.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseWaveByLevelAndWave");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrapDefenseLevelId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1WaveId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseWave?(TrapDefenseWave.GetRootAsTrapDefenseWave(configBuffer));
				}
			}
			ConfigTrapDefenseWaveByLevelAndWave.LogPair.Clear();
			ConfigTrapDefenseWaveByLevelAndWave.LogPair.Add(new ValueTuple<string, object>("TrapDefenseLevelId", p0TrapDefenseLevelId));
			ConfigTrapDefenseWaveByLevelAndWave.LogPair.Add(new ValueTuple<string, object>("WaveId", p1WaveId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseWaveByLevelAndWave.HandleId, 1, p0TrapDefenseLevelId, ConfigTrapDefenseWaveByLevelAndWave.LogPair) || !ConfigCommon.BindInt(ConfigTrapDefenseWaveByLevelAndWave.HandleId, 2, p1WaveId, ConfigTrapDefenseWaveByLevelAndWave.LogPair) || ConfigCommon.Step(ConfigTrapDefenseWaveByLevelAndWave.HandleId, true, ConfigTrapDefenseWaveByLevelAndWave.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseWaveByLevelAndWave.HandleId, ConfigTrapDefenseWaveByLevelAndWave.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseWaveByLevelAndWave.HandleId, 0, ConfigTrapDefenseWaveByLevelAndWave.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseWaveByLevelAndWave.HandleId, ConfigTrapDefenseWaveByLevelAndWave.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseWave rootAsTrapDefenseWave = TrapDefenseWave.GetRootAsTrapDefenseWave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseWaveByLevelAndWave");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrapDefenseLevelId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1WaveId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseWaveByLevelAndWave.HandleId, ConfigTrapDefenseWaveByLevelAndWave.LogPair);
			return new TrapDefenseWave?(rootAsTrapDefenseWave);
		}

		// Token: 0x040047D0 RID: 18384
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047D1 RID: 18385
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047D2 RID: 18386
		private const string TABLE = "TrapDefenseWave";

		// Token: 0x040047D3 RID: 18387
		private const string COMMAND = "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=? And WaveId=?";

		// Token: 0x040047D4 RID: 18388
		private const string KEY_PREFIX = "TrapDefenseWaveByLevelAndWave";

		// Token: 0x040047D5 RID: 18389
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047D6 RID: 18390
		private static int HandleId;
	}
}
