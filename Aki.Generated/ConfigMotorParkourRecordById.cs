using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D3 RID: 1491
	public class ConfigMotorParkourRecordById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022FF RID: 8959 RVA: 0x00122ECF File Offset: 0x001210CF
		static ConfigMotorParkourRecordById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRecordById.CreateStaticDefaultValue), new Action(ConfigMotorParkourRecordById.ResetStaticDefaultValue));
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00122EF0 File Offset: 0x001210F0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourRecordById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourRecordById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkourRecord"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkourRecord` where Id=?")
			});
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00122F6F File Offset: 0x0012116F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRecordById.LogPair = null;
			ConfigMotorParkourRecordById.HandleId = 0;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00122F7D File Offset: 0x0012117D
		public static void Init()
		{
			ConfigMotorParkourRecordById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRecordById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourRecord` where Id=?");
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00122F98 File Offset: 0x00121198
		public static MotorParkourRecord? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourRecordById.HandleId, ConfigMotorParkourRecordById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourRecordById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorParkourRecord?(MotorParkourRecord.GetRootAsMotorParkourRecord(configBuffer));
				}
			}
			ConfigMotorParkourRecordById.LogPair.Clear();
			ConfigMotorParkourRecordById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorParkourRecordById.HandleId, 1, p0Id, ConfigMotorParkourRecordById.LogPair) || ConfigCommon.Step(ConfigMotorParkourRecordById.HandleId, true, ConfigMotorParkourRecordById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorParkourRecordById.HandleId, ConfigMotorParkourRecordById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourRecordById.HandleId, 0, ConfigMotorParkourRecordById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorParkourRecordById.HandleId, ConfigMotorParkourRecordById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorParkourRecord rootAsMotorParkourRecord = MotorParkourRecord.GetRootAsMotorParkourRecord(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourRecordById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorParkourRecordById.HandleId, ConfigMotorParkourRecordById.LogPair);
			return new MotorParkourRecord?(rootAsMotorParkourRecord);
		}

		// Token: 0x040028A9 RID: 10409
		private const string DB = "db_motorparkour.db";

		// Token: 0x040028AA RID: 10410
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040028AB RID: 10411
		private const string TABLE = "MotorParkourRecord";

		// Token: 0x040028AC RID: 10412
		private const string COMMAND = "select BinData from `MotorParkourRecord` where Id=?";

		// Token: 0x040028AD RID: 10413
		private const string KEY_PREFIX = "MotorParkourRecordById";

		// Token: 0x040028AE RID: 10414
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028AF RID: 10415
		private static int HandleId;
	}
}
