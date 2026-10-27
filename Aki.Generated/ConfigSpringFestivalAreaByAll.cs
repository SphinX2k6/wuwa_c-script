using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000975 RID: 2421
	public class ConfigSpringFestivalAreaByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038D2 RID: 14546 RVA: 0x0019AD33 File Offset: 0x00198F33
		static ConfigSpringFestivalAreaByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaByAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaByAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0019AD54 File Offset: 0x00198F54
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

		// Token: 0x060038D4 RID: 14548 RVA: 0x0019ADD3 File Offset: 0x00198FD3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByAll.LogPair = null;
			ConfigSpringFestivalAreaByAll.HandleId = 0;
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0019ADE1 File Offset: 0x00198FE1
		public static void Init()
		{
			ConfigSpringFestivalAreaByAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaByAll.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea`");
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0019ADFC File Offset: 0x00198FFC
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

		// Token: 0x04004219 RID: 16921
		private const string DB = "db_spring26.db";

		// Token: 0x0400421A RID: 16922
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400421B RID: 16923
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x0400421C RID: 16924
		private const string COMMAND = "select BinData from `SpringFestivalArea`";

		// Token: 0x0400421D RID: 16925
		private const string KEY_PREFIX = "SpringFestivalAreaByAll";

		// Token: 0x0400421E RID: 16926
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400421F RID: 16927
		private static int HandleId;
	}
}
