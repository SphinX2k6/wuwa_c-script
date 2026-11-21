using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000495 RID: 1173
	public class ConfigKujiAwardsGroupByKujiId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B88 RID: 7048 RVA: 0x000F8898 File Offset: 0x000F6A98
		static ConfigKujiAwardsGroupByKujiId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiAwardsGroupByKujiId.CreateStaticDefaultValue), new Action(ConfigKujiAwardsGroupByKujiId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000F88B8 File Offset: 0x000F6AB8
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiAwardsGroupByKujiId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiAwardsGroupByKujiId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiAwardsGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiAwardsGroup` where KujiId=?")
			});
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000F8937 File Offset: 0x000F6B37
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiAwardsGroupByKujiId.LogPair = null;
			ConfigKujiAwardsGroupByKujiId.HandleId = 0;
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000F8945 File Offset: 0x000F6B45
		public static void Init()
		{
			ConfigKujiAwardsGroupByKujiId.HandleId = ConfigCommon.InitDataStatement(ConfigKujiAwardsGroupByKujiId.HandleId, "db_wuwukuji.db", "select BinData from `KujiAwardsGroup` where KujiId=?");
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000F8960 File Offset: 0x000F6B60
		[NullableContext(2)]
		public static IReadOnlyList<KujiAwardsGroup> GetConfigList(int p0KujiId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiAwardsGroupByKujiId.HandleId, ConfigKujiAwardsGroupByKujiId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiAwardsGroupByKujiId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KujiId);
				IReadOnlyList<KujiAwardsGroup> readOnlyList = (IReadOnlyList<KujiAwardsGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKujiAwardsGroupByKujiId.LogPair.Clear();
			ConfigKujiAwardsGroupByKujiId.LogPair.Add(new ValueTuple<string, object>("KujiId", p0KujiId));
			if (!ConfigCommon.BindInt(ConfigKujiAwardsGroupByKujiId.HandleId, 1, p0KujiId, ConfigKujiAwardsGroupByKujiId.LogPair))
			{
				ConfigCommon.Reset(ConfigKujiAwardsGroupByKujiId.HandleId, ConfigKujiAwardsGroupByKujiId.LogPair);
				return null;
			}
			List<KujiAwardsGroup> list = new List<KujiAwardsGroup>();
			while (ConfigCommon.Step(ConfigKujiAwardsGroupByKujiId.HandleId, false, ConfigKujiAwardsGroupByKujiId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiAwardsGroupByKujiId.HandleId, 0, ConfigKujiAwardsGroupByKujiId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKujiAwardsGroupByKujiId.HandleId, ConfigKujiAwardsGroupByKujiId.LogPair);
					return null;
				}
				KujiAwardsGroup rootAsKujiAwardsGroup = KujiAwardsGroup.GetRootAsKujiAwardsGroup(new ByteBuffer(item2));
				list.Add(rootAsKujiAwardsGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiAwardsGroupByKujiId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KujiId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKujiAwardsGroupByKujiId.HandleId, ConfigKujiAwardsGroupByKujiId.LogPair);
			return list;
		}

		// Token: 0x04001FF7 RID: 8183
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001FF8 RID: 8184
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001FF9 RID: 8185
		private const string TABLE = "KujiAwardsGroup";

		// Token: 0x04001FFA RID: 8186
		private const string COMMAND = "select BinData from `KujiAwardsGroup` where KujiId=?";

		// Token: 0x04001FFB RID: 8187
		private const string KEY_PREFIX = "KujiAwardsGroupByKujiId";

		// Token: 0x04001FFC RID: 8188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FFD RID: 8189
		private static int HandleId;
	}
}
