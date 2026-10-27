using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B6 RID: 1974
	public class ConfigRealmBetweenLevelExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E56 RID: 11862 RVA: 0x0015F417 File Offset: 0x0015D617
		static ConfigRealmBetweenLevelExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenLevelExpById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenLevelExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x0015F438 File Offset: 0x0015D638
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenLevelExpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenLevelExpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenLevelExp"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenLevelExp` where Id=?")
			});
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x0015F4B7 File Offset: 0x0015D6B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenLevelExpById.LogPair = null;
			ConfigRealmBetweenLevelExpById.HandleId = 0;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x0015F4C5 File Offset: 0x0015D6C5
		public static void Init()
		{
			ConfigRealmBetweenLevelExpById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenLevelExpById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenLevelExp` where Id=?");
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0015F4E0 File Offset: 0x0015D6E0
		public static RealmBetweenLevelExp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenLevelExpById.HandleId, ConfigRealmBetweenLevelExpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenLevelExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RealmBetweenLevelExp?(RealmBetweenLevelExp.GetRootAsRealmBetweenLevelExp(configBuffer));
				}
			}
			ConfigRealmBetweenLevelExpById.LogPair.Clear();
			ConfigRealmBetweenLevelExpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenLevelExpById.HandleId, 1, p0Id, ConfigRealmBetweenLevelExpById.LogPair) || ConfigCommon.Step(ConfigRealmBetweenLevelExpById.HandleId, true, ConfigRealmBetweenLevelExpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRealmBetweenLevelExpById.HandleId, ConfigRealmBetweenLevelExpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenLevelExpById.HandleId, 0, ConfigRealmBetweenLevelExpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRealmBetweenLevelExpById.HandleId, ConfigRealmBetweenLevelExpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RealmBetweenLevelExp rootAsRealmBetweenLevelExp = RealmBetweenLevelExp.GetRootAsRealmBetweenLevelExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenLevelExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRealmBetweenLevelExpById.HandleId, ConfigRealmBetweenLevelExpById.LogPair);
			return new RealmBetweenLevelExp?(rootAsRealmBetweenLevelExp);
		}

		// Token: 0x040035E0 RID: 13792
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035E1 RID: 13793
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035E2 RID: 13794
		private const string TABLE = "RealmBetweenLevelExp";

		// Token: 0x040035E3 RID: 13795
		private const string COMMAND = "select BinData from `RealmBetweenLevelExp` where Id=?";

		// Token: 0x040035E4 RID: 13796
		private const string KEY_PREFIX = "RealmBetweenLevelExpById";

		// Token: 0x040035E5 RID: 13797
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035E6 RID: 13798
		private static int HandleId;
	}
}
