using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B7 RID: 1975
	public class ConfigRealmBetweenPhantomGainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E5C RID: 11868 RVA: 0x0015F660 File Offset: 0x0015D860
		static ConfigRealmBetweenPhantomGainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenPhantomGainByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenPhantomGainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x0015F680 File Offset: 0x0015D880
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenPhantomGainByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenPhantomGainByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenPhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenPhantomGain` where ActivityId=?")
			});
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x0015F6FF File Offset: 0x0015D8FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenPhantomGainByActivityId.LogPair = null;
			ConfigRealmBetweenPhantomGainByActivityId.HandleId = 0;
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0015F70D File Offset: 0x0015D90D
		public static void Init()
		{
			ConfigRealmBetweenPhantomGainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenPhantomGainByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenPhantomGain` where ActivityId=?");
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x0015F728 File Offset: 0x0015D928
		[NullableContext(2)]
		public static IReadOnlyList<RealmBetweenPhantomGain> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenPhantomGainByActivityId.HandleId, ConfigRealmBetweenPhantomGainByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenPhantomGainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RealmBetweenPhantomGain> readOnlyList = (IReadOnlyList<RealmBetweenPhantomGain>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRealmBetweenPhantomGainByActivityId.LogPair.Clear();
			ConfigRealmBetweenPhantomGainByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenPhantomGainByActivityId.HandleId, 1, p0ActivityId, ConfigRealmBetweenPhantomGainByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRealmBetweenPhantomGainByActivityId.HandleId, ConfigRealmBetweenPhantomGainByActivityId.LogPair);
				return null;
			}
			List<RealmBetweenPhantomGain> list = new List<RealmBetweenPhantomGain>();
			while (ConfigCommon.Step(ConfigRealmBetweenPhantomGainByActivityId.HandleId, false, ConfigRealmBetweenPhantomGainByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenPhantomGainByActivityId.HandleId, 0, ConfigRealmBetweenPhantomGainByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRealmBetweenPhantomGainByActivityId.HandleId, ConfigRealmBetweenPhantomGainByActivityId.LogPair);
					return null;
				}
				RealmBetweenPhantomGain rootAsRealmBetweenPhantomGain = RealmBetweenPhantomGain.GetRootAsRealmBetweenPhantomGain(new ByteBuffer(item2));
				list.Add(rootAsRealmBetweenPhantomGain);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenPhantomGainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRealmBetweenPhantomGainByActivityId.HandleId, ConfigRealmBetweenPhantomGainByActivityId.LogPair);
			return list;
		}

		// Token: 0x040035E7 RID: 13799
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035E8 RID: 13800
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035E9 RID: 13801
		private const string TABLE = "RealmBetweenPhantomGain";

		// Token: 0x040035EA RID: 13802
		private const string COMMAND = "select BinData from `RealmBetweenPhantomGain` where ActivityId=?";

		// Token: 0x040035EB RID: 13803
		private const string KEY_PREFIX = "RealmBetweenPhantomGainByActivityId";

		// Token: 0x040035EC RID: 13804
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035ED RID: 13805
		private static int HandleId;
	}
}
