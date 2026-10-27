using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BB RID: 1467
	public class ConfigMotorParkourRecordAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600226F RID: 8815 RVA: 0x0011C454 File Offset: 0x0011A654
		static ConfigMotorParkourRecordAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRecordAll.CreateStaticDefaultValue), new Action(ConfigMotorParkourRecordAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0011C474 File Offset: 0x0011A674
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

		// Token: 0x06002271 RID: 8817 RVA: 0x0011C4F3 File Offset: 0x0011A6F3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRecordAll.LogPair = null;
			ConfigMotorParkourRecordAll.HandleId = 0;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0011C501 File Offset: 0x0011A701
		public static void Init()
		{
			ConfigMotorParkourRecordAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRecordAll.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourRecord`");
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0011C51C File Offset: 0x0011A71C
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

		// Token: 0x04002801 RID: 10241
		private const string DB = "db_motorparkour.db";

		// Token: 0x04002802 RID: 10242
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x04002803 RID: 10243
		private const string TABLE = "MotorParkourRecord";

		// Token: 0x04002804 RID: 10244
		private const string COMMAND = "select BinData from `MotorParkourRecord`";

		// Token: 0x04002805 RID: 10245
		private const string KEY_PREFIX = "MotorParkourRecordAll";

		// Token: 0x04002806 RID: 10246
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002807 RID: 10247
		private static int HandleId;
	}
}
