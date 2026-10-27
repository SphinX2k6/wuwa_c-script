using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047F RID: 1151
	public class ConfigKujiAwardsGroupByKujiId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x000F2144 File Offset: 0x000F0344
		static ConfigKujiAwardsGroupByKujiId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiAwardsGroupByKujiId.CreateStaticDefaultValue), new Action(ConfigKujiAwardsGroupByKujiId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x000F2164 File Offset: 0x000F0364
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

		// Token: 0x06001B06 RID: 6918 RVA: 0x000F21E3 File Offset: 0x000F03E3
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiAwardsGroupByKujiId.LogPair = null;
			ConfigKujiAwardsGroupByKujiId.HandleId = 0;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000F21F1 File Offset: 0x000F03F1
		public static void Init()
		{
			ConfigKujiAwardsGroupByKujiId.HandleId = ConfigCommon.InitDataStatement(ConfigKujiAwardsGroupByKujiId.HandleId, "db_wuwukuji.db", "select BinData from `KujiAwardsGroup` where KujiId=?");
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000F220C File Offset: 0x000F040C
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

		// Token: 0x04001F5D RID: 8029
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F5E RID: 8030
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F5F RID: 8031
		private const string TABLE = "KujiAwardsGroup";

		// Token: 0x04001F60 RID: 8032
		private const string COMMAND = "select BinData from `KujiAwardsGroup` where KujiId=?";

		// Token: 0x04001F61 RID: 8033
		private const string KEY_PREFIX = "KujiAwardsGroupByKujiId";

		// Token: 0x04001F62 RID: 8034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F63 RID: 8035
		private static int HandleId;
	}
}
