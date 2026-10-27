using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B0 RID: 1968
	public class ConfigRealmBetweenAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E32 RID: 11826 RVA: 0x0015E73B File Offset: 0x0015C93B
		static ConfigRealmBetweenAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0015E75C File Offset: 0x0015C95C
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenAreaByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenAreaByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenArea"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenArea` where ActivityId=?")
			});
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x0015E7DB File Offset: 0x0015C9DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenAreaByActivityId.LogPair = null;
			ConfigRealmBetweenAreaByActivityId.HandleId = 0;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x0015E7E9 File Offset: 0x0015C9E9
		public static void Init()
		{
			ConfigRealmBetweenAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenAreaByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenArea` where ActivityId=?");
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x0015E804 File Offset: 0x0015CA04
		[NullableContext(2)]
		public static IReadOnlyList<RealmBetweenArea> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenAreaByActivityId.HandleId, ConfigRealmBetweenAreaByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RealmBetweenArea> readOnlyList = (IReadOnlyList<RealmBetweenArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRealmBetweenAreaByActivityId.LogPair.Clear();
			ConfigRealmBetweenAreaByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenAreaByActivityId.HandleId, 1, p0ActivityId, ConfigRealmBetweenAreaByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRealmBetweenAreaByActivityId.HandleId, ConfigRealmBetweenAreaByActivityId.LogPair);
				return null;
			}
			List<RealmBetweenArea> list = new List<RealmBetweenArea>();
			while (ConfigCommon.Step(ConfigRealmBetweenAreaByActivityId.HandleId, false, ConfigRealmBetweenAreaByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenAreaByActivityId.HandleId, 0, ConfigRealmBetweenAreaByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRealmBetweenAreaByActivityId.HandleId, ConfigRealmBetweenAreaByActivityId.LogPair);
					return null;
				}
				RealmBetweenArea rootAsRealmBetweenArea = RealmBetweenArea.GetRootAsRealmBetweenArea(new ByteBuffer(item2));
				list.Add(rootAsRealmBetweenArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRealmBetweenAreaByActivityId.HandleId, ConfigRealmBetweenAreaByActivityId.LogPair);
			return list;
		}

		// Token: 0x040035B6 RID: 13750
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035B7 RID: 13751
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035B8 RID: 13752
		private const string TABLE = "RealmBetweenArea";

		// Token: 0x040035B9 RID: 13753
		private const string COMMAND = "select BinData from `RealmBetweenArea` where ActivityId=?";

		// Token: 0x040035BA RID: 13754
		private const string KEY_PREFIX = "RealmBetweenAreaByActivityId";

		// Token: 0x040035BB RID: 13755
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035BC RID: 13756
		private static int HandleId;
	}
}
