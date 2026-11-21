using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D1 RID: 2001
	public class ConfigRealmBetweenPhantomGainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EF8 RID: 12024 RVA: 0x0016656C File Offset: 0x0016476C
		static ConfigRealmBetweenPhantomGainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenPhantomGainByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenPhantomGainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x0016658C File Offset: 0x0016478C
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

		// Token: 0x06002EFA RID: 12026 RVA: 0x0016660B File Offset: 0x0016480B
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenPhantomGainByActivityId.LogPair = null;
			ConfigRealmBetweenPhantomGainByActivityId.HandleId = 0;
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00166619 File Offset: 0x00164819
		public static void Init()
		{
			ConfigRealmBetweenPhantomGainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenPhantomGainByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenPhantomGain` where ActivityId=?");
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00166634 File Offset: 0x00164834
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

		// Token: 0x0400369D RID: 13981
		private const string DB = "db_realmbetween.db";

		// Token: 0x0400369E RID: 13982
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x0400369F RID: 13983
		private const string TABLE = "RealmBetweenPhantomGain";

		// Token: 0x040036A0 RID: 13984
		private const string COMMAND = "select BinData from `RealmBetweenPhantomGain` where ActivityId=?";

		// Token: 0x040036A1 RID: 13985
		private const string KEY_PREFIX = "RealmBetweenPhantomGainByActivityId";

		// Token: 0x040036A2 RID: 13986
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036A3 RID: 13987
		private static int HandleId;
	}
}
