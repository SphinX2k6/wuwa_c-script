using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000589 RID: 1417
	public class ConfigMotorFightBuffGateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002143 RID: 8515 RVA: 0x00115864 File Offset: 0x00113A64
		static ConfigMotorFightBuffGateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBuffGateById.CreateStaticDefaultValue), new Action(ConfigMotorFightBuffGateById.ResetStaticDefaultValue));
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00115884 File Offset: 0x00113A84
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightBuffGateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightBuffGateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightBuffGate"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightBuffGate` where Id=?")
			});
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00115903 File Offset: 0x00113B03
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBuffGateById.LogPair = null;
			ConfigMotorFightBuffGateById.HandleId = 0;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00115911 File Offset: 0x00113B11
		public static void Init()
		{
			ConfigMotorFightBuffGateById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBuffGateById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBuffGate` where Id=?");
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0011592C File Offset: 0x00113B2C
		public static MotorFightBuffGate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffGateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightBuffGate?(MotorFightBuffGate.GetRootAsMotorFightBuffGate(configBuffer));
				}
			}
			ConfigMotorFightBuffGateById.LogPair.Clear();
			ConfigMotorFightBuffGateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightBuffGateById.HandleId, 1, p0Id, ConfigMotorFightBuffGateById.LogPair) || ConfigCommon.Step(ConfigMotorFightBuffGateById.HandleId, true, ConfigMotorFightBuffGateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightBuffGateById.HandleId, 0, ConfigMotorFightBuffGateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightBuffGate rootAsMotorFightBuffGate = MotorFightBuffGate.GetRootAsMotorFightBuffGate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffGateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair);
			return new MotorFightBuffGate?(rootAsMotorFightBuffGate);
		}

		// Token: 0x040026A3 RID: 9891
		private const string DB = "db_motorfight.db";

		// Token: 0x040026A4 RID: 9892
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040026A5 RID: 9893
		private const string TABLE = "MotorFightBuffGate";

		// Token: 0x040026A6 RID: 9894
		private const string COMMAND = "select BinData from `MotorFightBuffGate` where Id=?";

		// Token: 0x040026A7 RID: 9895
		private const string KEY_PREFIX = "MotorFightBuffGateById";

		// Token: 0x040026A8 RID: 9896
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026A9 RID: 9897
		private static int HandleId;
	}
}
