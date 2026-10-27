using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000755 RID: 1877
	public class ConfigPrefabTextItemByPrefabPathHash : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C0F RID: 11279 RVA: 0x001526E4 File Offset: 0x001508E4
		static ConfigPrefabTextItemByPrefabPathHash()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabTextItemByPrefabPathHash.CreateStaticDefaultValue), new Action(ConfigPrefabTextItemByPrefabPathHash.ResetStaticDefaultValue));
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00152704 File Offset: 0x00150904
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

		// Token: 0x06002C11 RID: 11281 RVA: 0x00152783 File Offset: 0x00150983
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabTextItemByPrefabPathHash.LogPair = null;
			ConfigPrefabTextItemByPrefabPathHash.HandleId = 0;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00152791 File Offset: 0x00150991
		public static void Init()
		{
			ConfigPrefabTextItemByPrefabPathHash.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabTextItemByPrefabPathHash.HandleId, "db_ui_prefabtextitem.db", "select BinData from `PrefabTextItem` where PrefabPathHash = ?");
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x001527AC File Offset: 0x001509AC
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

		// Token: 0x04003339 RID: 13113
		private const string DB = "db_ui_prefabtextitem.db";

		// Token: 0x0400333A RID: 13114
		private const string FILE = "u.UiTextCollect/u.预制体文本收集.csv";

		// Token: 0x0400333B RID: 13115
		private const string TABLE = "PrefabTextItem";

		// Token: 0x0400333C RID: 13116
		private const string COMMAND = "select BinData from `PrefabTextItem` where PrefabPathHash = ?";

		// Token: 0x0400333D RID: 13117
		private const string KEY_PREFIX = "PrefabTextItemByPrefabPathHash";

		// Token: 0x0400333E RID: 13118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400333F RID: 13119
		private static int HandleId;
	}
}
