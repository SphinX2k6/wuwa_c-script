using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F1 RID: 2289
	public class ConfigRoverRogueRoleEnhanceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035B9 RID: 13753 RVA: 0x00189040 File Offset: 0x00187240
		static ConfigRoverRogueRoleEnhanceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleEnhanceAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleEnhanceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00189060 File Offset: 0x00187260
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoleEnhanceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoleEnhanceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoleEnhance"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoleEnhance`")
			});
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x001890DF File Offset: 0x001872DF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleEnhanceAll.LogPair = null;
			ConfigRoverRogueRoleEnhanceAll.HandleId = 0;
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x001890ED File Offset: 0x001872ED
		public static void Init()
		{
			ConfigRoverRogueRoleEnhanceAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleEnhanceAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleEnhance`");
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00189108 File Offset: 0x00187308
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueRoleEnhance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoleEnhanceAll.HandleId, ConfigRoverRogueRoleEnhanceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueRoleEnhance> readOnlyList = (IReadOnlyList<RoverRogueRoleEnhance>)ConfigCommon.GetConfig("RoverRogueRoleEnhanceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueRoleEnhance> list = new List<RoverRogueRoleEnhance>();
			while (ConfigCommon.Step(ConfigRoverRogueRoleEnhanceAll.HandleId, false, ConfigRoverRogueRoleEnhanceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoleEnhanceAll.HandleId, 0, ConfigRoverRogueRoleEnhanceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueRoleEnhanceAll.HandleId, ConfigRoverRogueRoleEnhanceAll.LogPair);
					return null;
				}
				RoverRogueRoleEnhance rootAsRoverRogueRoleEnhance = RoverRogueRoleEnhance.GetRootAsRoverRogueRoleEnhance(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueRoleEnhance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueRoleEnhanceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoleEnhanceAll.HandleId, ConfigRoverRogueRoleEnhanceAll.LogPair);
			return list;
		}

		// Token: 0x04003E7D RID: 15997
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E7E RID: 15998
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E7F RID: 15999
		private const string TABLE = "RoverRogueRoleEnhance";

		// Token: 0x04003E80 RID: 16000
		private const string COMMAND = "select BinData from `RoverRogueRoleEnhance`";

		// Token: 0x04003E81 RID: 16001
		private const string KEY_PREFIX = "RoverRogueRoleEnhanceAll";

		// Token: 0x04003E82 RID: 16002
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E83 RID: 16003
		private static int HandleId;
	}
}
