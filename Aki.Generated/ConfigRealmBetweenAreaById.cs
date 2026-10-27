using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B1 RID: 1969
	public class ConfigRealmBetweenAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E38 RID: 11832 RVA: 0x0015E973 File Offset: 0x0015CB73
		static ConfigRealmBetweenAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenAreaById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x0015E994 File Offset: 0x0015CB94
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenArea"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenArea` where Id=?")
			});
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x0015EA13 File Offset: 0x0015CC13
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenAreaById.LogPair = null;
			ConfigRealmBetweenAreaById.HandleId = 0;
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x0015EA21 File Offset: 0x0015CC21
		public static void Init()
		{
			ConfigRealmBetweenAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenAreaById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenArea` where Id=?");
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x0015EA3C File Offset: 0x0015CC3C
		public static RealmBetweenArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenAreaById.HandleId, ConfigRealmBetweenAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RealmBetweenArea?(RealmBetweenArea.GetRootAsRealmBetweenArea(configBuffer));
				}
			}
			ConfigRealmBetweenAreaById.LogPair.Clear();
			ConfigRealmBetweenAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenAreaById.HandleId, 1, p0Id, ConfigRealmBetweenAreaById.LogPair) || ConfigCommon.Step(ConfigRealmBetweenAreaById.HandleId, true, ConfigRealmBetweenAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRealmBetweenAreaById.HandleId, ConfigRealmBetweenAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenAreaById.HandleId, 0, ConfigRealmBetweenAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRealmBetweenAreaById.HandleId, ConfigRealmBetweenAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RealmBetweenArea rootAsRealmBetweenArea = RealmBetweenArea.GetRootAsRealmBetweenArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRealmBetweenAreaById.HandleId, ConfigRealmBetweenAreaById.LogPair);
			return new RealmBetweenArea?(rootAsRealmBetweenArea);
		}

		// Token: 0x040035BD RID: 13757
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035BE RID: 13758
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035BF RID: 13759
		private const string TABLE = "RealmBetweenArea";

		// Token: 0x040035C0 RID: 13760
		private const string COMMAND = "select BinData from `RealmBetweenArea` where Id=?";

		// Token: 0x040035C1 RID: 13761
		private const string KEY_PREFIX = "RealmBetweenAreaById";

		// Token: 0x040035C2 RID: 13762
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035C3 RID: 13763
		private static int HandleId;
	}
}
