using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076D RID: 1901
	public class ConfigPrefabTextItemByPrefabPathHash : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C9F RID: 11423 RVA: 0x00159160 File Offset: 0x00157360
		static ConfigPrefabTextItemByPrefabPathHash()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabTextItemByPrefabPathHash.CreateStaticDefaultValue), new Action(ConfigPrefabTextItemByPrefabPathHash.ResetStaticDefaultValue));
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00159180 File Offset: 0x00157380
		public static void CreateStaticDefaultValue()
		{
			ConfigPrefabTextItemByPrefabPathHash.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrefabTextItemByPrefabPathHash.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui_prefabtextitem.db"),
				new ValueTuple<string, object>("文件", "u.UiTextCollect/u.预制体文本收集.csv"),
				new ValueTuple<string, object>("表名", "PrefabTextItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PrefabTextItem` where PrefabPathHash = ?")
			});
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x001591FF File Offset: 0x001573FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabTextItemByPrefabPathHash.LogPair = null;
			ConfigPrefabTextItemByPrefabPathHash.HandleId = 0;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0015920D File Offset: 0x0015740D
		public static void Init()
		{
			ConfigPrefabTextItemByPrefabPathHash.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabTextItemByPrefabPathHash.HandleId, "db_ui_prefabtextitem.db", "select BinData from `PrefabTextItem` where PrefabPathHash = ?");
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00159228 File Offset: 0x00157428
		[NullableContext(2)]
		public static IReadOnlyList<PrefabTextItem> GetConfigList(long p0PrefabPathHash, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrefabTextItemByPrefabPathHash.HandleId, ConfigPrefabTextItemByPrefabPathHash.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrefabTextItemByPrefabPathHash");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0PrefabPathHash);
				IReadOnlyList<PrefabTextItem> readOnlyList = (IReadOnlyList<PrefabTextItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPrefabTextItemByPrefabPathHash.LogPair.Clear();
			ConfigPrefabTextItemByPrefabPathHash.LogPair.Add(new ValueTuple<string, object>("PrefabPathHash", p0PrefabPathHash));
			if (!ConfigCommon.BindBigInt(ConfigPrefabTextItemByPrefabPathHash.HandleId, 1, p0PrefabPathHash, ConfigPrefabTextItemByPrefabPathHash.LogPair))
			{
				ConfigCommon.Reset(ConfigPrefabTextItemByPrefabPathHash.HandleId, ConfigPrefabTextItemByPrefabPathHash.LogPair);
				return null;
			}
			List<PrefabTextItem> list = new List<PrefabTextItem>();
			while (ConfigCommon.Step(ConfigPrefabTextItemByPrefabPathHash.HandleId, false, ConfigPrefabTextItemByPrefabPathHash.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrefabTextItemByPrefabPathHash.HandleId, 0, ConfigPrefabTextItemByPrefabPathHash.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPrefabTextItemByPrefabPathHash.HandleId, ConfigPrefabTextItemByPrefabPathHash.LogPair);
					return null;
				}
				PrefabTextItem rootAsPrefabTextItem = PrefabTextItem.GetRootAsPrefabTextItem(new ByteBuffer(item2));
				list.Add(rootAsPrefabTextItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrefabTextItemByPrefabPathHash");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0PrefabPathHash);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPrefabTextItemByPrefabPathHash.HandleId, ConfigPrefabTextItemByPrefabPathHash.LogPair);
			return list;
		}

		// Token: 0x040033E1 RID: 13281
		private const string DB = "db_ui_prefabtextitem.db";

		// Token: 0x040033E2 RID: 13282
		private const string FILE = "u.UiTextCollect/u.预制体文本收集.csv";

		// Token: 0x040033E3 RID: 13283
		private const string TABLE = "PrefabTextItem";

		// Token: 0x040033E4 RID: 13284
		private const string COMMAND = "select BinData from `PrefabTextItem` where PrefabPathHash = ?";

		// Token: 0x040033E5 RID: 13285
		private const string KEY_PREFIX = "PrefabTextItemByPrefabPathHash";

		// Token: 0x040033E6 RID: 13286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033E7 RID: 13287
		private static int HandleId;
	}
}
