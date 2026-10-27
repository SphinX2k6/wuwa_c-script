using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BC RID: 1468
	public class ConfigMotorParkourRecordById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002275 RID: 8821 RVA: 0x0011C5E7 File Offset: 0x0011A7E7
		static ConfigMotorParkourRecordById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRecordById.CreateStaticDefaultValue), new Action(ConfigMotorParkourRecordById.ResetStaticDefaultValue));
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0011C608 File Offset: 0x0011A808
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

		// Token: 0x06002277 RID: 8823 RVA: 0x0011C687 File Offset: 0x0011A887
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRecordById.LogPair = null;
			ConfigMotorParkourRecordById.HandleId = 0;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0011C695 File Offset: 0x0011A895
		public static void Init()
		{
			ConfigMotorParkourRecordById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRecordById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourRecord` where Id=?");
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0011C6B0 File Offset: 0x0011A8B0
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

		// Token: 0x04002808 RID: 10248
		private const string DB = "db_motorparkour.db";

		// Token: 0x04002809 RID: 10249
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x0400280A RID: 10250
		private const string TABLE = "MotorParkourRecord";

		// Token: 0x0400280B RID: 10251
		private const string COMMAND = "select BinData from `MotorParkourRecord` where Id=?";

		// Token: 0x0400280C RID: 10252
		private const string KEY_PREFIX = "MotorParkourRecordById";

		// Token: 0x0400280D RID: 10253
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400280E RID: 10254
		private static int HandleId;
	}
}
