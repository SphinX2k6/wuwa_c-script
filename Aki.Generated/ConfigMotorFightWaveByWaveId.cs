using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A1 RID: 1441
	public class ConfigMotorFightWaveByWaveId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x00118D5C File Offset: 0x00116F5C
		static ConfigMotorFightWaveByWaveId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightWaveByWaveId.CreateStaticDefaultValue), new Action(ConfigMotorFightWaveByWaveId.ResetStaticDefaultValue));
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00118D7C File Offset: 0x00116F7C
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

		// Token: 0x060021D5 RID: 8661 RVA: 0x00118DFB File Offset: 0x00116FFB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightWaveByWaveId.LogPair = null;
			ConfigMotorFightWaveByWaveId.HandleId = 0;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00118E09 File Offset: 0x00117009
		public static void Init()
		{
			ConfigMotorFightWaveByWaveId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightWaveByWaveId.HandleId, "db_motorfight.db", "select BinData from `MotorFightWave` where WaveId=?");
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00118E24 File Offset: 0x00117024
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

		// Token: 0x0400274B RID: 10059
		private const string DB = "db_motorfight.db";

		// Token: 0x0400274C RID: 10060
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x0400274D RID: 10061
		private const string TABLE = "MotorFightWave";

		// Token: 0x0400274E RID: 10062
		private const string COMMAND = "select BinData from `MotorFightWave` where WaveId=?";

		// Token: 0x0400274F RID: 10063
		private const string KEY_PREFIX = "MotorFightWaveByWaveId";

		// Token: 0x04002750 RID: 10064
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002751 RID: 10065
		private static int HandleId;
	}
}
