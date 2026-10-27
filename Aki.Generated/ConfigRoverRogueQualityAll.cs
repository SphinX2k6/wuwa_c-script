using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EC RID: 2284
	public class ConfigRoverRogueQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600359B RID: 13723 RVA: 0x0018859C File Offset: 0x0018679C
		static ConfigRoverRogueQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueQualityAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x001885BC File Offset: 0x001867BC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueQualityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueQualityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueQuality`")
			});
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x0018863B File Offset: 0x0018683B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueQualityAll.LogPair = null;
			ConfigRoverRogueQualityAll.HandleId = 0;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00188649 File Offset: 0x00186849
		public static void Init()
		{
			ConfigRoverRogueQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueQualityAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueQuality`");
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00188664 File Offset: 0x00186864
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueQuality> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueQualityAll.HandleId, ConfigRoverRogueQualityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueQuality> readOnlyList = (IReadOnlyList<RoverRogueQuality>)ConfigCommon.GetConfig("RoverRogueQualityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueQuality> list = new List<RoverRogueQuality>();
			while (ConfigCommon.Step(ConfigRoverRogueQualityAll.HandleId, false, ConfigRoverRogueQualityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueQualityAll.HandleId, 0, ConfigRoverRogueQualityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueQualityAll.HandleId, ConfigRoverRogueQualityAll.LogPair);
					return null;
				}
				RoverRogueQuality rootAsRoverRogueQuality = RoverRogueQuality.GetRootAsRoverRogueQuality(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueQuality);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueQualityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueQualityAll.HandleId, ConfigRoverRogueQualityAll.LogPair);
			return list;
		}

		// Token: 0x04003E5A RID: 15962
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E5B RID: 15963
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E5C RID: 15964
		private const string TABLE = "RoverRogueQuality";

		// Token: 0x04003E5D RID: 15965
		private const string COMMAND = "select BinData from `RoverRogueQuality`";

		// Token: 0x04003E5E RID: 15966
		private const string KEY_PREFIX = "RoverRogueQualityAll";

		// Token: 0x04003E5F RID: 15967
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E60 RID: 15968
		private static int HandleId;
	}
}
