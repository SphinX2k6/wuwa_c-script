using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B5 RID: 1461
	public class ConfigMotorParkourAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600224B RID: 8779 RVA: 0x0011B768 File Offset: 0x00119968
		static ConfigMotorParkourAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourAll.CreateStaticDefaultValue), new Action(ConfigMotorParkourAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0011B788 File Offset: 0x00119988
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

		// Token: 0x0600224D RID: 8781 RVA: 0x0011B807 File Offset: 0x00119A07
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourAll.LogPair = null;
			ConfigMotorParkourAll.HandleId = 0;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0011B815 File Offset: 0x00119A15
		public static void Init()
		{
			ConfigMotorParkourAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourAll.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour`");
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0011B830 File Offset: 0x00119A30
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

		// Token: 0x040027D7 RID: 10199
		private const string DB = "db_motorparkour.db";

		// Token: 0x040027D8 RID: 10200
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040027D9 RID: 10201
		private const string TABLE = "MotorParkour";

		// Token: 0x040027DA RID: 10202
		private const string COMMAND = "select BinData from `MotorParkour`";

		// Token: 0x040027DB RID: 10203
		private const string KEY_PREFIX = "MotorParkourAll";

		// Token: 0x040027DC RID: 10204
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027DD RID: 10205
		private static int HandleId;
	}
}
