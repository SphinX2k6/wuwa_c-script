using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B8 RID: 1464
	public class ConfigMotorFightWaveByWaveId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600225D RID: 8797 RVA: 0x0011F644 File Offset: 0x0011D844
		static ConfigMotorFightWaveByWaveId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightWaveByWaveId.CreateStaticDefaultValue), new Action(ConfigMotorFightWaveByWaveId.ResetStaticDefaultValue));
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0011F664 File Offset: 0x0011D864
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightWaveByWaveId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightWaveByWaveId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightWave"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightWave` where WaveId=?")
			});
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0011F6E3 File Offset: 0x0011D8E3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightWaveByWaveId.LogPair = null;
			ConfigMotorFightWaveByWaveId.HandleId = 0;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0011F6F1 File Offset: 0x0011D8F1
		public static void Init()
		{
			ConfigMotorFightWaveByWaveId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightWaveByWaveId.HandleId, "db_motorfight.db", "select BinData from `MotorFightWave` where WaveId=?");
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0011F70C File Offset: 0x0011D90C
		public static MotorFightWave? GetConfig(int p0WaveId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightWaveByWaveId.HandleId, ConfigMotorFightWaveByWaveId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightWaveByWaveId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WaveId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightWave?(MotorFightWave.GetRootAsMotorFightWave(configBuffer));
				}
			}
			ConfigMotorFightWaveByWaveId.LogPair.Clear();
			ConfigMotorFightWaveByWaveId.LogPair.Add(new ValueTuple<string, object>("WaveId", p0WaveId));
			if (!ConfigCommon.BindInt(ConfigMotorFightWaveByWaveId.HandleId, 1, p0WaveId, ConfigMotorFightWaveByWaveId.LogPair) || ConfigCommon.Step(ConfigMotorFightWaveByWaveId.HandleId, true, ConfigMotorFightWaveByWaveId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightWaveByWaveId.HandleId, ConfigMotorFightWaveByWaveId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightWaveByWaveId.HandleId, 0, ConfigMotorFightWaveByWaveId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightWaveByWaveId.HandleId, ConfigMotorFightWaveByWaveId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightWave rootAsMotorFightWave = MotorFightWave.GetRootAsMotorFightWave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightWaveByWaveId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WaveId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightWaveByWaveId.HandleId, ConfigMotorFightWaveByWaveId.LogPair);
			return new MotorFightWave?(rootAsMotorFightWave);
		}

		// Token: 0x040027EC RID: 10220
		private const string DB = "db_motorfight.db";

		// Token: 0x040027ED RID: 10221
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040027EE RID: 10222
		private const string TABLE = "MotorFightWave";

		// Token: 0x040027EF RID: 10223
		private const string COMMAND = "select BinData from `MotorFightWave` where WaveId=?";

		// Token: 0x040027F0 RID: 10224
		private const string KEY_PREFIX = "MotorFightWaveByWaveId";

		// Token: 0x040027F1 RID: 10225
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027F2 RID: 10226
		private static int HandleId;
	}
}
