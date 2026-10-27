using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B5 RID: 1973
	public class ConfigRealmBetweenLevelExpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E50 RID: 11856 RVA: 0x0015F1E0 File Offset: 0x0015D3E0
		static ConfigRealmBetweenLevelExpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenLevelExpByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenLevelExpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x0015F200 File Offset: 0x0015D400
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenLevelExpByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenLevelExpByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenLevelExp"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenLevelExp` where ActivityId=?")
			});
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x0015F27F File Offset: 0x0015D47F
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenLevelExpByActivityId.LogPair = null;
			ConfigRealmBetweenLevelExpByActivityId.HandleId = 0;
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x0015F28D File Offset: 0x0015D48D
		public static void Init()
		{
			ConfigRealmBetweenLevelExpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenLevelExpByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenLevelExp` where ActivityId=?");
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x0015F2A8 File Offset: 0x0015D4A8
		[NullableContext(2)]
		public static IReadOnlyList<RealmBetweenLevelExp> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenLevelExpByActivityId.HandleId, ConfigRealmBetweenLevelExpByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenLevelExpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RealmBetweenLevelExp> readOnlyList = (IReadOnlyList<RealmBetweenLevelExp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRealmBetweenLevelExpByActivityId.LogPair.Clear();
			ConfigRealmBetweenLevelExpByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenLevelExpByActivityId.HandleId, 1, p0ActivityId, ConfigRealmBetweenLevelExpByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRealmBetweenLevelExpByActivityId.HandleId, ConfigRealmBetweenLevelExpByActivityId.LogPair);
				return null;
			}
			List<RealmBetweenLevelExp> list = new List<RealmBetweenLevelExp>();
			while (ConfigCommon.Step(ConfigRealmBetweenLevelExpByActivityId.HandleId, false, ConfigRealmBetweenLevelExpByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenLevelExpByActivityId.HandleId, 0, ConfigRealmBetweenLevelExpByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRealmBetweenLevelExpByActivityId.HandleId, ConfigRealmBetweenLevelExpByActivityId.LogPair);
					return null;
				}
				RealmBetweenLevelExp rootAsRealmBetweenLevelExp = RealmBetweenLevelExp.GetRootAsRealmBetweenLevelExp(new ByteBuffer(item2));
				list.Add(rootAsRealmBetweenLevelExp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenLevelExpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRealmBetweenLevelExpByActivityId.HandleId, ConfigRealmBetweenLevelExpByActivityId.LogPair);
			return list;
		}

		// Token: 0x040035D9 RID: 13785
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035DA RID: 13786
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035DB RID: 13787
		private const string TABLE = "RealmBetweenLevelExp";

		// Token: 0x040035DC RID: 13788
		private const string COMMAND = "select BinData from `RealmBetweenLevelExp` where ActivityId=?";

		// Token: 0x040035DD RID: 13789
		private const string KEY_PREFIX = "RealmBetweenLevelExpByActivityId";

		// Token: 0x040035DE RID: 13790
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035DF RID: 13791
		private static int HandleId;
	}
}
