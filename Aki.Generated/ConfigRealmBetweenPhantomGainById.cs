using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D2 RID: 2002
	public class ConfigRealmBetweenPhantomGainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EFE RID: 12030 RVA: 0x001667A3 File Offset: 0x001649A3
		static ConfigRealmBetweenPhantomGainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenPhantomGainById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenPhantomGainById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x001667C4 File Offset: 0x001649C4
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

		// Token: 0x06002F00 RID: 12032 RVA: 0x00166843 File Offset: 0x00164A43
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenPhantomGainById.LogPair = null;
			ConfigRealmBetweenPhantomGainById.HandleId = 0;
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x00166851 File Offset: 0x00164A51
		public static void Init()
		{
			ConfigRealmBetweenPhantomGainById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenPhantomGainById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenPhantomGain` where Id=?");
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x0016686C File Offset: 0x00164A6C
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

		// Token: 0x040036A4 RID: 13988
		private const string DB = "db_realmbetween.db";

		// Token: 0x040036A5 RID: 13989
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040036A6 RID: 13990
		private const string TABLE = "RealmBetweenPhantomGain";

		// Token: 0x040036A7 RID: 13991
		private const string COMMAND = "select BinData from `RealmBetweenPhantomGain` where Id=?";

		// Token: 0x040036A8 RID: 13992
		private const string KEY_PREFIX = "RealmBetweenPhantomGainById";

		// Token: 0x040036A9 RID: 13993
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036AA RID: 13994
		private static int HandleId;
	}
}
