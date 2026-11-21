using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D2 RID: 1490
	public class ConfigMotorParkourRecordAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022F9 RID: 8953 RVA: 0x00122D3C File Offset: 0x00120F3C
		static ConfigMotorParkourRecordAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRecordAll.CreateStaticDefaultValue), new Action(ConfigMotorParkourRecordAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00122D5C File Offset: 0x00120F5C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourRecordAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourRecordAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkourRecord"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkourRecord`")
			});
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00122DDB File Offset: 0x00120FDB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRecordAll.LogPair = null;
			ConfigMotorParkourRecordAll.HandleId = 0;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00122DE9 File Offset: 0x00120FE9
		public static void Init()
		{
			ConfigMotorParkourRecordAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRecordAll.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourRecord`");
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00122E04 File Offset: 0x00121004
		[NullableContext(2)]
		public static IReadOnlyList<MotorParkourRecord> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourRecordAll.HandleId, ConfigMotorParkourRecordAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorParkourRecord> readOnlyList = (IReadOnlyList<MotorParkourRecord>)ConfigCommon.GetConfig("MotorParkourRecordAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorParkourRecord> list = new List<MotorParkourRecord>();
			while (ConfigCommon.Step(ConfigMotorParkourRecordAll.HandleId, false, ConfigMotorParkourRecordAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourRecordAll.HandleId, 0, ConfigMotorParkourRecordAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorParkourRecordAll.HandleId, ConfigMotorParkourRecordAll.LogPair);
					return null;
				}
				MotorParkourRecord rootAsMotorParkourRecord = MotorParkourRecord.GetRootAsMotorParkourRecord(new ByteBuffer(item2));
				list.Add(rootAsMotorParkourRecord);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorParkourRecordAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorParkourRecordAll.HandleId, ConfigMotorParkourRecordAll.LogPair);
			return list;
		}

		// Token: 0x040028A2 RID: 10402
		private const string DB = "db_motorparkour.db";

		// Token: 0x040028A3 RID: 10403
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040028A4 RID: 10404
		private const string TABLE = "MotorParkourRecord";

		// Token: 0x040028A5 RID: 10405
		private const string COMMAND = "select BinData from `MotorParkourRecord`";

		// Token: 0x040028A6 RID: 10406
		private const string KEY_PREFIX = "MotorParkourRecordAll";

		// Token: 0x040028A7 RID: 10407
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028A8 RID: 10408
		private static int HandleId;
	}
}
