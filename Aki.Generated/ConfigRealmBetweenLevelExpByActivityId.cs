using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CF RID: 1999
	public class ConfigRealmBetweenLevelExpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EEC RID: 12012 RVA: 0x001660EC File Offset: 0x001642EC
		static ConfigRealmBetweenLevelExpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenLevelExpByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenLevelExpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x0016610C File Offset: 0x0016430C
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

		// Token: 0x06002EEE RID: 12014 RVA: 0x0016618B File Offset: 0x0016438B
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenLevelExpByActivityId.LogPair = null;
			ConfigRealmBetweenLevelExpByActivityId.HandleId = 0;
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00166199 File Offset: 0x00164399
		public static void Init()
		{
			ConfigRealmBetweenLevelExpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenLevelExpByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenLevelExp` where ActivityId=?");
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x001661B4 File Offset: 0x001643B4
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

		// Token: 0x0400368F RID: 13967
		private const string DB = "db_realmbetween.db";

		// Token: 0x04003690 RID: 13968
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x04003691 RID: 13969
		private const string TABLE = "RealmBetweenLevelExp";

		// Token: 0x04003692 RID: 13970
		private const string COMMAND = "select BinData from `RealmBetweenLevelExp` where ActivityId=?";

		// Token: 0x04003693 RID: 13971
		private const string KEY_PREFIX = "RealmBetweenLevelExpByActivityId";

		// Token: 0x04003694 RID: 13972
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003695 RID: 13973
		private static int HandleId;
	}
}
