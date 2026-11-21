using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1B RID: 2843
	public class ConfigTrapDefenseWaveByLevelAndWave : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042B6 RID: 17078 RVA: 0x001D6088 File Offset: 0x001D4288
		static ConfigTrapDefenseWaveByLevelAndWave()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseWaveByLevelAndWave.CreateStaticDefaultValue), new Action(ConfigTrapDefenseWaveByLevelAndWave.ResetStaticDefaultValue));
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x001D60A8 File Offset: 0x001D42A8
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

		// Token: 0x060042B8 RID: 17080 RVA: 0x001D6127 File Offset: 0x001D4327
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseWaveByLevelAndWave.LogPair = null;
			ConfigTrapDefenseWaveByLevelAndWave.HandleId = 0;
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x001D6135 File Offset: 0x001D4335
		public static void Init()
		{
			ConfigTrapDefenseWaveByLevelAndWave.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseWaveByLevelAndWave.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=? And WaveId=?");
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x001D6150 File Offset: 0x001D4350
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

		// Token: 0x04004DA3 RID: 19875
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004DA4 RID: 19876
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004DA5 RID: 19877
		private const string TABLE = "TrapDefenseWave";

		// Token: 0x04004DA6 RID: 19878
		private const string COMMAND = "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=? And WaveId=?";

		// Token: 0x04004DA7 RID: 19879
		private const string KEY_PREFIX = "TrapDefenseWaveByLevelAndWave";

		// Token: 0x04004DA8 RID: 19880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DA9 RID: 19881
		private static int HandleId;
	}
}
