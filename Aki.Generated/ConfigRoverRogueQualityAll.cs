using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000937 RID: 2359
	public class ConfigRoverRogueQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600375D RID: 14173 RVA: 0x001957BC File Offset: 0x001939BC
		static ConfigRoverRogueQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueQualityAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x001957DC File Offset: 0x001939DC
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

		// Token: 0x0600375F RID: 14175 RVA: 0x0019585B File Offset: 0x00193A5B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueQualityAll.LogPair = null;
			ConfigRoverRogueQualityAll.HandleId = 0;
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00195869 File Offset: 0x00193A69
		public static void Init()
		{
			ConfigRoverRogueQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueQualityAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueQuality`");
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00195884 File Offset: 0x00193A84
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

		// Token: 0x04004067 RID: 16487
		private const string DB = "db_roverlike.db";

		// Token: 0x04004068 RID: 16488
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04004069 RID: 16489
		private const string TABLE = "RoverRogueQuality";

		// Token: 0x0400406A RID: 16490
		private const string COMMAND = "select BinData from `RoverRogueQuality`";

		// Token: 0x0400406B RID: 16491
		private const string KEY_PREFIX = "RoverRogueQualityAll";

		// Token: 0x0400406C RID: 16492
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400406D RID: 16493
		private static int HandleId;
	}
}
