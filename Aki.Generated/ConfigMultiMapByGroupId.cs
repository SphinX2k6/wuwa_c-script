using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D8 RID: 1496
	public class ConfigMultiMapByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600231D RID: 8989 RVA: 0x0011FF53 File Offset: 0x0011E153
		static ConfigMultiMapByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapByGroupId.CreateStaticDefaultValue), new Action(ConfigMultiMapByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0011FF74 File Offset: 0x0011E174
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

		// Token: 0x0600231F RID: 8991 RVA: 0x0011FFF3 File Offset: 0x0011E1F3
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapByGroupId.LogPair = null;
			ConfigMultiMapByGroupId.HandleId = 0;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00120001 File Offset: 0x0011E201
		public static void Init()
		{
			ConfigMultiMapByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapByGroupId.HandleId, "db_map.db", "select BinData from `MultiMap` where GroupId=?");
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0012001C File Offset: 0x0011E21C
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

		// Token: 0x040028CC RID: 10444
		private const string DB = "db_map.db";

		// Token: 0x040028CD RID: 10445
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040028CE RID: 10446
		private const string TABLE = "MultiMap";

		// Token: 0x040028CF RID: 10447
		private const string COMMAND = "select BinData from `MultiMap` where GroupId=?";

		// Token: 0x040028D0 RID: 10448
		private const string KEY_PREFIX = "MultiMapByGroupId";

		// Token: 0x040028D1 RID: 10449
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028D2 RID: 10450
		private static int HandleId;
	}
}
