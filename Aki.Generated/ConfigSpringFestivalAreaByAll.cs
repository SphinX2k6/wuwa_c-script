using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4A RID: 2634
	public class ConfigSpringFestivalAreaByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DD0 RID: 15824 RVA: 0x001BA0C7 File Offset: 0x001B82C7
		static ConfigSpringFestivalAreaByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaByAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x001BA0E8 File Offset: 0x001B82E8
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAreaByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalArea"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalArea`")
			});
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x001BA167 File Offset: 0x001B8367
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByAll.LogPair = null;
			ConfigSpringFestivalAreaByAll.HandleId = 0;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x001BA175 File Offset: 0x001B8375
		public static void Init()
		{
			ConfigSpringFestivalAreaByAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaByAll.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea`");
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x001BA190 File Offset: 0x001B8390
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAreaByAll.HandleId, ConfigSpringFestivalAreaByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringFestivalArea> readOnlyList = (IReadOnlyList<SpringFestivalArea>)ConfigCommon.GetConfig("SpringFestivalAreaByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringFestivalArea> list = new List<SpringFestivalArea>();
			while (ConfigCommon.Step(ConfigSpringFestivalAreaByAll.HandleId, false, ConfigSpringFestivalAreaByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAreaByAll.HandleId, 0, ConfigSpringFestivalAreaByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalAreaByAll.HandleId, ConfigSpringFestivalAreaByAll.LogPair);
					return null;
				}
				SpringFestivalArea rootAsSpringFestivalArea = SpringFestivalArea.GetRootAsSpringFestivalArea(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringFestivalAreaByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAreaByAll.HandleId, ConfigSpringFestivalAreaByAll.LogPair);
			return list;
		}

		// Token: 0x040047EC RID: 18412
		private const string DB = "db_spring26.db";

		// Token: 0x040047ED RID: 18413
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040047EE RID: 18414
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x040047EF RID: 18415
		private const string COMMAND = "select BinData from `SpringFestivalArea`";

		// Token: 0x040047F0 RID: 18416
		private const string KEY_PREFIX = "SpringFestivalAreaByAll";

		// Token: 0x040047F1 RID: 18417
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047F2 RID: 18418
		private static int HandleId;
	}
}
