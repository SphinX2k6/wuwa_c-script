using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A5 RID: 165
	public class ConfigAreaMapGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003DF RID: 991 RVA: 0x0006F900 File Offset: 0x0006DB00
		static ConfigAreaMapGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaMapGroupAll.CreateStaticDefaultValue), new Action(ConfigAreaMapGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0006F920 File Offset: 0x0006DB20
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaMapGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaMapGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaMapGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaMapGroup`")
			});
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0006F99F File Offset: 0x0006DB9F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaMapGroupAll.LogPair = null;
			ConfigAreaMapGroupAll.HandleId = 0;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0006F9AD File Offset: 0x0006DBAD
		public static void Init()
		{
			ConfigAreaMapGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigAreaMapGroupAll.HandleId, "db_areaterminal.db", "select BinData from `AreaMapGroup`");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
		[NullableContext(2)]
		public static IReadOnlyList<AreaMapGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaMapGroupAll.HandleId, ConfigAreaMapGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AreaMapGroup> readOnlyList = (IReadOnlyList<AreaMapGroup>)ConfigCommon.GetConfig("AreaMapGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AreaMapGroup> list = new List<AreaMapGroup>();
			while (ConfigCommon.Step(ConfigAreaMapGroupAll.HandleId, false, ConfigAreaMapGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaMapGroupAll.HandleId, 0, ConfigAreaMapGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaMapGroupAll.HandleId, ConfigAreaMapGroupAll.LogPair);
					return null;
				}
				AreaMapGroup rootAsAreaMapGroup = AreaMapGroup.GetRootAsAreaMapGroup(new ByteBuffer(item2));
				list.Add(rootAsAreaMapGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AreaMapGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaMapGroupAll.HandleId, ConfigAreaMapGroupAll.LogPair);
			return list;
		}

		// Token: 0x04000467 RID: 1127
		private const string DB = "db_areaterminal.db";

		// Token: 0x04000468 RID: 1128
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x04000469 RID: 1129
		private const string TABLE = "AreaMapGroup";

		// Token: 0x0400046A RID: 1130
		private const string COMMAND = "select BinData from `AreaMapGroup`";

		// Token: 0x0400046B RID: 1131
		private const string KEY_PREFIX = "AreaMapGroupAll";

		// Token: 0x0400046C RID: 1132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400046D RID: 1133
		private static int HandleId;
	}
}
