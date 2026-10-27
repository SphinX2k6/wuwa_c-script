using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000973 RID: 2419
	public class ConfigSpringFestivalAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038C6 RID: 14534 RVA: 0x0019A968 File Offset: 0x00198B68
		static ConfigSpringFestivalAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0019A988 File Offset: 0x00198B88
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestival"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestival`")
			});
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0019AA07 File Offset: 0x00198C07
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAll.LogPair = null;
			ConfigSpringFestivalAll.HandleId = 0;
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x0019AA15 File Offset: 0x00198C15
		public static void Init()
		{
			ConfigSpringFestivalAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAll.HandleId, "db_spring26.db", "select BinData from `SpringFestival`");
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x0019AA30 File Offset: 0x00198C30
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestival> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAll.HandleId, ConfigSpringFestivalAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringFestival> readOnlyList = (IReadOnlyList<SpringFestival>)ConfigCommon.GetConfig("SpringFestivalAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringFestival> list = new List<SpringFestival>();
			while (ConfigCommon.Step(ConfigSpringFestivalAll.HandleId, false, ConfigSpringFestivalAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAll.HandleId, 0, ConfigSpringFestivalAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalAll.HandleId, ConfigSpringFestivalAll.LogPair);
					return null;
				}
				SpringFestival rootAsSpringFestival = SpringFestival.GetRootAsSpringFestival(new ByteBuffer(item2));
				list.Add(rootAsSpringFestival);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringFestivalAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAll.HandleId, ConfigSpringFestivalAll.LogPair);
			return list;
		}

		// Token: 0x0400420B RID: 16907
		private const string DB = "db_spring26.db";

		// Token: 0x0400420C RID: 16908
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400420D RID: 16909
		private const string TABLE = "SpringFestival";

		// Token: 0x0400420E RID: 16910
		private const string COMMAND = "select BinData from `SpringFestival`";

		// Token: 0x0400420F RID: 16911
		private const string KEY_PREFIX = "SpringFestivalAll";

		// Token: 0x04004210 RID: 16912
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004211 RID: 16913
		private static int HandleId;
	}
}
