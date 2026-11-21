using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CB RID: 1995
	public class ConfigRealmBetweenAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ED4 RID: 11988 RVA: 0x0016587F File Offset: 0x00163A7F
		static ConfigRealmBetweenAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenAreaById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x001658A0 File Offset: 0x00163AA0
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

		// Token: 0x06002ED6 RID: 11990 RVA: 0x0016591F File Offset: 0x00163B1F
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenAreaById.LogPair = null;
			ConfigRealmBetweenAreaById.HandleId = 0;
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x0016592D File Offset: 0x00163B2D
		public static void Init()
		{
			ConfigRealmBetweenAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenAreaById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenArea` where Id=?");
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00165948 File Offset: 0x00163B48
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

		// Token: 0x04003673 RID: 13939
		private const string DB = "db_realmbetween.db";

		// Token: 0x04003674 RID: 13940
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x04003675 RID: 13941
		private const string TABLE = "RealmBetweenArea";

		// Token: 0x04003676 RID: 13942
		private const string COMMAND = "select BinData from `RealmBetweenArea` where Id=?";

		// Token: 0x04003677 RID: 13943
		private const string KEY_PREFIX = "RealmBetweenAreaById";

		// Token: 0x04003678 RID: 13944
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003679 RID: 13945
		private static int HandleId;
	}
}
