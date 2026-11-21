using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F0 RID: 1520
	public class ConfigMultiMapByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023AD RID: 9133 RVA: 0x001269CF File Offset: 0x00124BCF
		static ConfigMultiMapByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapByGroupId.CreateStaticDefaultValue), new Action(ConfigMultiMapByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x001269F0 File Offset: 0x00124BF0
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiMapByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiMapByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MultiMap"),
				new ValueTuple<string, object>("语句", "select BinData from `MultiMap` where GroupId=?")
			});
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00126A6F File Offset: 0x00124C6F
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapByGroupId.LogPair = null;
			ConfigMultiMapByGroupId.HandleId = 0;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00126A7D File Offset: 0x00124C7D
		public static void Init()
		{
			ConfigMultiMapByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapByGroupId.HandleId, "db_map.db", "select BinData from `MultiMap` where GroupId=?");
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00126A98 File Offset: 0x00124C98
		[NullableContext(2)]
		public static IReadOnlyList<MultiMap> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMultiMapByGroupId.HandleId, ConfigMultiMapByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiMapByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<MultiMap> readOnlyList = (IReadOnlyList<MultiMap>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMultiMapByGroupId.LogPair.Clear();
			ConfigMultiMapByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigMultiMapByGroupId.HandleId, 1, p0GroupId, ConfigMultiMapByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigMultiMapByGroupId.HandleId, ConfigMultiMapByGroupId.LogPair);
				return null;
			}
			List<MultiMap> list = new List<MultiMap>();
			while (ConfigCommon.Step(ConfigMultiMapByGroupId.HandleId, false, ConfigMultiMapByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMultiMapByGroupId.HandleId, 0, ConfigMultiMapByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMultiMapByGroupId.HandleId, ConfigMultiMapByGroupId.LogPair);
					return null;
				}
				MultiMap rootAsMultiMap = MultiMap.GetRootAsMultiMap(new ByteBuffer(item2));
				list.Add(rootAsMultiMap);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiMapByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMultiMapByGroupId.HandleId, ConfigMultiMapByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002974 RID: 10612
		private const string DB = "db_map.db";

		// Token: 0x04002975 RID: 10613
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04002976 RID: 10614
		private const string TABLE = "MultiMap";

		// Token: 0x04002977 RID: 10615
		private const string COMMAND = "select BinData from `MultiMap` where GroupId=?";

		// Token: 0x04002978 RID: 10616
		private const string KEY_PREFIX = "MultiMapByGroupId";

		// Token: 0x04002979 RID: 10617
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400297A RID: 10618
		private static int HandleId;
	}
}
