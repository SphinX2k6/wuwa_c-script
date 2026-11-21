using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CC RID: 1484
	public class ConfigMotorParkourAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022D5 RID: 8917 RVA: 0x00122050 File Offset: 0x00120250
		static ConfigMotorParkourAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourAll.CreateStaticDefaultValue), new Action(ConfigMotorParkourAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00122070 File Offset: 0x00120270
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkour"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkour`")
			});
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x001220EF File Offset: 0x001202EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourAll.LogPair = null;
			ConfigMotorParkourAll.HandleId = 0;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x001220FD File Offset: 0x001202FD
		public static void Init()
		{
			ConfigMotorParkourAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourAll.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour`");
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00122118 File Offset: 0x00120318
		[NullableContext(2)]
		public static IReadOnlyList<MotorParkour> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourAll.HandleId, ConfigMotorParkourAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorParkour> readOnlyList = (IReadOnlyList<MotorParkour>)ConfigCommon.GetConfig("MotorParkourAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorParkour> list = new List<MotorParkour>();
			while (ConfigCommon.Step(ConfigMotorParkourAll.HandleId, false, ConfigMotorParkourAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourAll.HandleId, 0, ConfigMotorParkourAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorParkourAll.HandleId, ConfigMotorParkourAll.LogPair);
					return null;
				}
				MotorParkour rootAsMotorParkour = MotorParkour.GetRootAsMotorParkour(new ByteBuffer(item2));
				list.Add(rootAsMotorParkour);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorParkourAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorParkourAll.HandleId, ConfigMotorParkourAll.LogPair);
			return list;
		}

		// Token: 0x04002878 RID: 10360
		private const string DB = "db_motorparkour.db";

		// Token: 0x04002879 RID: 10361
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x0400287A RID: 10362
		private const string TABLE = "MotorParkour";

		// Token: 0x0400287B RID: 10363
		private const string COMMAND = "select BinData from `MotorParkour`";

		// Token: 0x0400287C RID: 10364
		private const string KEY_PREFIX = "MotorParkourAll";

		// Token: 0x0400287D RID: 10365
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400287E RID: 10366
		private static int HandleId;
	}
}
