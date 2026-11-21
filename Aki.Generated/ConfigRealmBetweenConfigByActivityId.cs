using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CE RID: 1998
	public class ConfigRealmBetweenConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EE6 RID: 12006 RVA: 0x00165EA4 File Offset: 0x001640A4
		static ConfigRealmBetweenConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00165EC4 File Offset: 0x001640C4
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenConfig` where ActivityId=?")
			});
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00165F43 File Offset: 0x00164143
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenConfigByActivityId.LogPair = null;
			ConfigRealmBetweenConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00165F51 File Offset: 0x00164151
		public static void Init()
		{
			ConfigRealmBetweenConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenConfigByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenConfig` where ActivityId=?");
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00165F6C File Offset: 0x0016416C
		public static RealmBetweenConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenConfigByActivityId.HandleId, ConfigRealmBetweenConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RealmBetweenConfig?(RealmBetweenConfig.GetRootAsRealmBetweenConfig(configBuffer));
				}
			}
			ConfigRealmBetweenConfigByActivityId.LogPair.Clear();
			ConfigRealmBetweenConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenConfigByActivityId.HandleId, 1, p0ActivityId, ConfigRealmBetweenConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigRealmBetweenConfigByActivityId.HandleId, true, ConfigRealmBetweenConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRealmBetweenConfigByActivityId.HandleId, ConfigRealmBetweenConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenConfigByActivityId.HandleId, 0, ConfigRealmBetweenConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRealmBetweenConfigByActivityId.HandleId, ConfigRealmBetweenConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RealmBetweenConfig rootAsRealmBetweenConfig = RealmBetweenConfig.GetRootAsRealmBetweenConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRealmBetweenConfigByActivityId.HandleId, ConfigRealmBetweenConfigByActivityId.LogPair);
			return new RealmBetweenConfig?(rootAsRealmBetweenConfig);
		}

		// Token: 0x04003688 RID: 13960
		private const string DB = "db_realmbetween.db";

		// Token: 0x04003689 RID: 13961
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x0400368A RID: 13962
		private const string TABLE = "RealmBetweenConfig";

		// Token: 0x0400368B RID: 13963
		private const string COMMAND = "select BinData from `RealmBetweenConfig` where ActivityId=?";

		// Token: 0x0400368C RID: 13964
		private const string KEY_PREFIX = "RealmBetweenConfigByActivityId";

		// Token: 0x0400368D RID: 13965
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400368E RID: 13966
		private static int HandleId;
	}
}
