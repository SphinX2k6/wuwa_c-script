using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D0 RID: 2000
	public class ConfigRealmBetweenLevelExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EF2 RID: 12018 RVA: 0x00166323 File Offset: 0x00164523
		static ConfigRealmBetweenLevelExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenLevelExpById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenLevelExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00166344 File Offset: 0x00164544
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

		// Token: 0x06002EF4 RID: 12020 RVA: 0x001663C3 File Offset: 0x001645C3
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenLevelExpById.LogPair = null;
			ConfigRealmBetweenLevelExpById.HandleId = 0;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x001663D1 File Offset: 0x001645D1
		public static void Init()
		{
			ConfigRealmBetweenLevelExpById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenLevelExpById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenLevelExp` where Id=?");
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x001663EC File Offset: 0x001645EC
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

		// Token: 0x04003696 RID: 13974
		private const string DB = "db_realmbetween.db";

		// Token: 0x04003697 RID: 13975
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x04003698 RID: 13976
		private const string TABLE = "RealmBetweenLevelExp";

		// Token: 0x04003699 RID: 13977
		private const string COMMAND = "select BinData from `RealmBetweenLevelExp` where Id=?";

		// Token: 0x0400369A RID: 13978
		private const string KEY_PREFIX = "RealmBetweenLevelExpById";

		// Token: 0x0400369B RID: 13979
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400369C RID: 13980
		private static int HandleId;
	}
}
