using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030F RID: 783
	public class ConfigFloroRanchBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600125F RID: 4703 RVA: 0x000C16AC File Offset: 0x000BF8AC
		static ConfigFloroRanchBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchBuffAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000C16CC File Offset: 0x000BF8CC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchbuff.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_buff.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchBuff`")
			});
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000C174B File Offset: 0x000BF94B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchBuffAll.LogPair = null;
			ConfigFloroRanchBuffAll.HandleId = 0;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000C1759 File Offset: 0x000BF959
		public static void Init()
		{
			ConfigFloroRanchBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchBuffAll.HandleId, "db_flororanchbuff.db", "select BinData from `FloroRanchBuff`");
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000C1774 File Offset: 0x000BF974
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchBuffAll.HandleId, ConfigFloroRanchBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchBuff> readOnlyList = (IReadOnlyList<FloroRanchBuff>)ConfigCommon.GetConfig("FloroRanchBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchBuff> list = new List<FloroRanchBuff>();
			while (ConfigCommon.Step(ConfigFloroRanchBuffAll.HandleId, false, ConfigFloroRanchBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchBuffAll.HandleId, 0, ConfigFloroRanchBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchBuffAll.HandleId, ConfigFloroRanchBuffAll.LogPair);
					return null;
				}
				FloroRanchBuff rootAsFloroRanchBuff = FloroRanchBuff.GetRootAsFloroRanchBuff(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchBuffAll.HandleId, ConfigFloroRanchBuffAll.LogPair);
			return list;
		}

		// Token: 0x0400154D RID: 5453
		private const string DB = "db_flororanchbuff.db";

		// Token: 0x0400154E RID: 5454
		private const string FILE = "f.弗洛洛牧场_buff.xlsx";

		// Token: 0x0400154F RID: 5455
		private const string TABLE = "FloroRanchBuff";

		// Token: 0x04001550 RID: 5456
		private const string COMMAND = "select BinData from `FloroRanchBuff`";

		// Token: 0x04001551 RID: 5457
		private const string KEY_PREFIX = "FloroRanchBuffAll";

		// Token: 0x04001552 RID: 5458
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001553 RID: 5459
		private static int HandleId;
	}
}
