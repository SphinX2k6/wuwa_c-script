using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093C RID: 2364
	public class ConfigRoverRogueRoleEnhanceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600377B RID: 14203 RVA: 0x00196260 File Offset: 0x00194460
		static ConfigRoverRogueRoleEnhanceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleEnhanceAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleEnhanceAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00196280 File Offset: 0x00194480
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

		// Token: 0x0600377D RID: 14205 RVA: 0x001962FF File Offset: 0x001944FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleEnhanceAll.LogPair = null;
			ConfigRoverRogueRoleEnhanceAll.HandleId = 0;
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0019630D File Offset: 0x0019450D
		public static void Init()
		{
			ConfigRoverRogueRoleEnhanceAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleEnhanceAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleEnhance`");
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00196328 File Offset: 0x00194528
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

		// Token: 0x0400408A RID: 16522
		private const string DB = "db_roverlike.db";

		// Token: 0x0400408B RID: 16523
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x0400408C RID: 16524
		private const string TABLE = "RoverRogueRoleEnhance";

		// Token: 0x0400408D RID: 16525
		private const string COMMAND = "select BinData from `RoverRogueRoleEnhance`";

		// Token: 0x0400408E RID: 16526
		private const string KEY_PREFIX = "RoverRogueRoleEnhanceAll";

		// Token: 0x0400408F RID: 16527
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004090 RID: 16528
		private static int HandleId;
	}
}
