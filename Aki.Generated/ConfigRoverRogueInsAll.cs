using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E6 RID: 2278
	public class ConfigRoverRogueInsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003577 RID: 13687 RVA: 0x00187964 File Offset: 0x00185B64
		static ConfigRoverRogueInsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueInsAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueInsAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00187984 File Offset: 0x00185B84
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

		// Token: 0x06003579 RID: 13689 RVA: 0x00187A03 File Offset: 0x00185C03
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueInsAll.LogPair = null;
			ConfigRoverRogueInsAll.HandleId = 0;
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00187A11 File Offset: 0x00185C11
		public static void Init()
		{
			ConfigRoverRogueInsAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueInsAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueIns`");
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00187A2C File Offset: 0x00185C2C
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

		// Token: 0x04003E30 RID: 15920
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E31 RID: 15921
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04003E32 RID: 15922
		private const string TABLE = "RoverRogueIns";

		// Token: 0x04003E33 RID: 15923
		private const string COMMAND = "select BinData from `RoverRogueIns`";

		// Token: 0x04003E34 RID: 15924
		private const string KEY_PREFIX = "RoverRogueInsAll";

		// Token: 0x04003E35 RID: 15925
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E36 RID: 15926
		private static int HandleId;
	}
}
