using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000931 RID: 2353
	public class ConfigRoverRogueInsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003739 RID: 14137 RVA: 0x00194B84 File Offset: 0x00192D84
		static ConfigRoverRogueInsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueInsAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueInsAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00194BA4 File Offset: 0x00192DA4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueInsAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueInsAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueIns"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueIns`")
			});
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00194C23 File Offset: 0x00192E23
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueInsAll.LogPair = null;
			ConfigRoverRogueInsAll.HandleId = 0;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00194C31 File Offset: 0x00192E31
		public static void Init()
		{
			ConfigRoverRogueInsAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueInsAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueIns`");
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00194C4C File Offset: 0x00192E4C
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueIns> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueInsAll.HandleId, ConfigRoverRogueInsAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueIns> readOnlyList = (IReadOnlyList<RoverRogueIns>)ConfigCommon.GetConfig("RoverRogueInsAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueIns> list = new List<RoverRogueIns>();
			while (ConfigCommon.Step(ConfigRoverRogueInsAll.HandleId, false, ConfigRoverRogueInsAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueInsAll.HandleId, 0, ConfigRoverRogueInsAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueInsAll.HandleId, ConfigRoverRogueInsAll.LogPair);
					return null;
				}
				RoverRogueIns rootAsRoverRogueIns = RoverRogueIns.GetRootAsRoverRogueIns(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueIns);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueInsAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueInsAll.HandleId, ConfigRoverRogueInsAll.LogPair);
			return list;
		}

		// Token: 0x0400403D RID: 16445
		private const string DB = "db_roverlike.db";

		// Token: 0x0400403E RID: 16446
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x0400403F RID: 16447
		private const string TABLE = "RoverRogueIns";

		// Token: 0x04004040 RID: 16448
		private const string COMMAND = "select BinData from `RoverRogueIns`";

		// Token: 0x04004041 RID: 16449
		private const string KEY_PREFIX = "RoverRogueInsAll";

		// Token: 0x04004042 RID: 16450
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004043 RID: 16451
		private static int HandleId;
	}
}
