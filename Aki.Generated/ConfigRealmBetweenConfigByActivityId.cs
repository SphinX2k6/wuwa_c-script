using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B4 RID: 1972
	public class ConfigRealmBetweenConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E4A RID: 11850 RVA: 0x0015EF98 File Offset: 0x0015D198
		static ConfigRealmBetweenConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x0015EFB8 File Offset: 0x0015D1B8
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

		// Token: 0x06002E4C RID: 11852 RVA: 0x0015F037 File Offset: 0x0015D237
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenConfigByActivityId.LogPair = null;
			ConfigRealmBetweenConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x0015F045 File Offset: 0x0015D245
		public static void Init()
		{
			ConfigRealmBetweenConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenConfigByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenConfig` where ActivityId=?");
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x0015F060 File Offset: 0x0015D260
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

		// Token: 0x040035D2 RID: 13778
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035D3 RID: 13779
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035D4 RID: 13780
		private const string TABLE = "RealmBetweenConfig";

		// Token: 0x040035D5 RID: 13781
		private const string COMMAND = "select BinData from `RealmBetweenConfig` where ActivityId=?";

		// Token: 0x040035D6 RID: 13782
		private const string KEY_PREFIX = "RealmBetweenConfigByActivityId";

		// Token: 0x040035D7 RID: 13783
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035D8 RID: 13784
		private static int HandleId;
	}
}
