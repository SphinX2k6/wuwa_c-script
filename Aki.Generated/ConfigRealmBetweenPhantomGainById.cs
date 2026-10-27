using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B8 RID: 1976
	public class ConfigRealmBetweenPhantomGainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E62 RID: 11874 RVA: 0x0015F897 File Offset: 0x0015DA97
		static ConfigRealmBetweenPhantomGainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenPhantomGainById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenPhantomGainById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x0015F8B8 File Offset: 0x0015DAB8
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenPhantomGainById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenPhantomGainById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenPhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenPhantomGain` where Id=?")
			});
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x0015F937 File Offset: 0x0015DB37
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenPhantomGainById.LogPair = null;
			ConfigRealmBetweenPhantomGainById.HandleId = 0;
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x0015F945 File Offset: 0x0015DB45
		public static void Init()
		{
			ConfigRealmBetweenPhantomGainById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenPhantomGainById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenPhantomGain` where Id=?");
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x0015F960 File Offset: 0x0015DB60
		public static RealmBetweenPhantomGain? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenPhantomGainById.HandleId, ConfigRealmBetweenPhantomGainById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenPhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RealmBetweenPhantomGain?(RealmBetweenPhantomGain.GetRootAsRealmBetweenPhantomGain(configBuffer));
				}
			}
			ConfigRealmBetweenPhantomGainById.LogPair.Clear();
			ConfigRealmBetweenPhantomGainById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenPhantomGainById.HandleId, 1, p0Id, ConfigRealmBetweenPhantomGainById.LogPair) || ConfigCommon.Step(ConfigRealmBetweenPhantomGainById.HandleId, true, ConfigRealmBetweenPhantomGainById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRealmBetweenPhantomGainById.HandleId, ConfigRealmBetweenPhantomGainById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenPhantomGainById.HandleId, 0, ConfigRealmBetweenPhantomGainById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRealmBetweenPhantomGainById.HandleId, ConfigRealmBetweenPhantomGainById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RealmBetweenPhantomGain rootAsRealmBetweenPhantomGain = RealmBetweenPhantomGain.GetRootAsRealmBetweenPhantomGain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenPhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRealmBetweenPhantomGainById.HandleId, ConfigRealmBetweenPhantomGainById.LogPair);
			return new RealmBetweenPhantomGain?(rootAsRealmBetweenPhantomGain);
		}

		// Token: 0x040035EE RID: 13806
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035EF RID: 13807
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035F0 RID: 13808
		private const string TABLE = "RealmBetweenPhantomGain";

		// Token: 0x040035F1 RID: 13809
		private const string COMMAND = "select BinData from `RealmBetweenPhantomGain` where Id=?";

		// Token: 0x040035F2 RID: 13810
		private const string KEY_PREFIX = "RealmBetweenPhantomGainById";

		// Token: 0x040035F3 RID: 13811
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035F4 RID: 13812
		private static int HandleId;
	}
}
