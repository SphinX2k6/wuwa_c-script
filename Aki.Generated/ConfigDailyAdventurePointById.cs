using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B8 RID: 440
	public class ConfigDailyAdventurePointById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A53 RID: 2643 RVA: 0x00094030 File Offset: 0x00092230
		static ConfigDailyAdventurePointById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyAdventurePointById.CreateStaticDefaultValue), new Action(ConfigDailyAdventurePointById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00094050 File Offset: 0x00092250
		public static void CreateStaticDefaultValue()
		{
			ConfigDailyAdventurePointById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDailyAdventurePointById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dailyadventureactivity.db"),
				new ValueTuple<string, object>("文件", "r.日常探险活动.xlsx"),
				new ValueTuple<string, object>("表名", "DailyAdventurePoint"),
				new ValueTuple<string, object>("语句", "select BinData from `DailyAdventurePoint` where Id=?")
			});
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000940CF File Offset: 0x000922CF
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyAdventurePointById.LogPair = null;
			ConfigDailyAdventurePointById.HandleId = 0;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000940DD File Offset: 0x000922DD
		public static void Init()
		{
			ConfigDailyAdventurePointById.HandleId = ConfigCommon.InitDataStatement(ConfigDailyAdventurePointById.HandleId, "db_dailyadventureactivity.db", "select BinData from `DailyAdventurePoint` where Id=?");
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000940F8 File Offset: 0x000922F8
		public static DailyAdventurePoint? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDailyAdventurePointById.HandleId, ConfigDailyAdventurePointById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyAdventurePointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DailyAdventurePoint?(DailyAdventurePoint.GetRootAsDailyAdventurePoint(configBuffer));
				}
			}
			ConfigDailyAdventurePointById.LogPair.Clear();
			ConfigDailyAdventurePointById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDailyAdventurePointById.HandleId, 1, p0Id, ConfigDailyAdventurePointById.LogPair) || ConfigCommon.Step(ConfigDailyAdventurePointById.HandleId, true, ConfigDailyAdventurePointById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDailyAdventurePointById.HandleId, ConfigDailyAdventurePointById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDailyAdventurePointById.HandleId, 0, ConfigDailyAdventurePointById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDailyAdventurePointById.HandleId, ConfigDailyAdventurePointById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DailyAdventurePoint rootAsDailyAdventurePoint = DailyAdventurePoint.GetRootAsDailyAdventurePoint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyAdventurePointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDailyAdventurePointById.HandleId, ConfigDailyAdventurePointById.LogPair);
			return new DailyAdventurePoint?(rootAsDailyAdventurePoint);
		}

		// Token: 0x04000BEC RID: 3052
		private const string DB = "db_dailyadventureactivity.db";

		// Token: 0x04000BED RID: 3053
		private const string FILE = "r.日常探险活动.xlsx";

		// Token: 0x04000BEE RID: 3054
		private const string TABLE = "DailyAdventurePoint";

		// Token: 0x04000BEF RID: 3055
		private const string COMMAND = "select BinData from `DailyAdventurePoint` where Id=?";

		// Token: 0x04000BF0 RID: 3056
		private const string KEY_PREFIX = "DailyAdventurePointById";

		// Token: 0x04000BF1 RID: 3057
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BF2 RID: 3058
		private static int HandleId;
	}
}
