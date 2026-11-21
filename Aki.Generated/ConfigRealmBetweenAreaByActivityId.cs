using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CA RID: 1994
	public class ConfigRealmBetweenAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ECE RID: 11982 RVA: 0x00165647 File Offset: 0x00163847
		static ConfigRealmBetweenAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00165668 File Offset: 0x00163868
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

		// Token: 0x06002ED0 RID: 11984 RVA: 0x001656E7 File Offset: 0x001638E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenAreaByActivityId.LogPair = null;
			ConfigRealmBetweenAreaByActivityId.HandleId = 0;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x001656F5 File Offset: 0x001638F5
		public static void Init()
		{
			ConfigRealmBetweenAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenAreaByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenArea` where ActivityId=?");
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00165710 File Offset: 0x00163910
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

		// Token: 0x0400366C RID: 13932
		private const string DB = "db_realmbetween.db";

		// Token: 0x0400366D RID: 13933
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x0400366E RID: 13934
		private const string TABLE = "RealmBetweenArea";

		// Token: 0x0400366F RID: 13935
		private const string COMMAND = "select BinData from `RealmBetweenArea` where ActivityId=?";

		// Token: 0x04003670 RID: 13936
		private const string KEY_PREFIX = "RealmBetweenAreaByActivityId";

		// Token: 0x04003671 RID: 13937
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003672 RID: 13938
		private static int HandleId;
	}
}
