using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000867 RID: 2151
	public class ConfigRogueResGlobalParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600327C RID: 12924 RVA: 0x0017A650 File Offset: 0x00178850
		static ConfigRogueResGlobalParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGlobalParamAll.CreateStaticDefaultValue), new Action(ConfigRogueResGlobalParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x0017A670 File Offset: 0x00178870
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGlobalParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGlobalParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGlobalParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGlobalParam`")
			});
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x0017A6EF File Offset: 0x001788EF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGlobalParamAll.LogPair = null;
			ConfigRogueResGlobalParamAll.HandleId = 0;
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x0017A6FD File Offset: 0x001788FD
		public static void Init()
		{
			ConfigRogueResGlobalParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGlobalParamAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGlobalParam`");
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x0017A718 File Offset: 0x00178918
		[NullableContext(2)]
		public static IReadOnlyList<RogueResGlobalParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGlobalParamAll.HandleId, ConfigRogueResGlobalParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResGlobalParam> readOnlyList = (IReadOnlyList<RogueResGlobalParam>)ConfigCommon.GetConfig("RogueResGlobalParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResGlobalParam> list = new List<RogueResGlobalParam>();
			while (ConfigCommon.Step(ConfigRogueResGlobalParamAll.HandleId, false, ConfigRogueResGlobalParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGlobalParamAll.HandleId, 0, ConfigRogueResGlobalParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResGlobalParamAll.HandleId, ConfigRogueResGlobalParamAll.LogPair);
					return null;
				}
				RogueResGlobalParam rootAsRogueResGlobalParam = RogueResGlobalParam.GetRootAsRogueResGlobalParam(new ByteBuffer(item2));
				list.Add(rootAsRogueResGlobalParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResGlobalParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResGlobalParamAll.HandleId, ConfigRogueResGlobalParamAll.LogPair);
			return list;
		}

		// Token: 0x04003AB7 RID: 15031
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AB8 RID: 15032
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AB9 RID: 15033
		private const string TABLE = "RogueResGlobalParam";

		// Token: 0x04003ABA RID: 15034
		private const string COMMAND = "select BinData from `RogueResGlobalParam`";

		// Token: 0x04003ABB RID: 15035
		private const string KEY_PREFIX = "RogueResGlobalParamAll";

		// Token: 0x04003ABC RID: 15036
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ABD RID: 15037
		private static int HandleId;
	}
}
