using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CA RID: 458
	public class ConfigDailyAdventurePointById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x00099F68 File Offset: 0x00098168
		static ConfigDailyAdventurePointById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyAdventurePointById.CreateStaticDefaultValue), new Action(ConfigDailyAdventurePointById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00099F88 File Offset: 0x00098188
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

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0009A007 File Offset: 0x00098207
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyAdventurePointById.LogPair = null;
			ConfigDailyAdventurePointById.HandleId = 0;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0009A015 File Offset: 0x00098215
		public static void Init()
		{
			ConfigDailyAdventurePointById.HandleId = ConfigCommon.InitDataStatement(ConfigDailyAdventurePointById.HandleId, "db_dailyadventureactivity.db", "select BinData from `DailyAdventurePoint` where Id=?");
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0009A030 File Offset: 0x00098230
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

		// Token: 0x04000C6A RID: 3178
		private const string DB = "db_dailyadventureactivity.db";

		// Token: 0x04000C6B RID: 3179
		private const string FILE = "r.日常探险活动.xlsx";

		// Token: 0x04000C6C RID: 3180
		private const string TABLE = "DailyAdventurePoint";

		// Token: 0x04000C6D RID: 3181
		private const string COMMAND = "select BinData from `DailyAdventurePoint` where Id=?";

		// Token: 0x04000C6E RID: 3182
		private const string KEY_PREFIX = "DailyAdventurePointById";

		// Token: 0x04000C6F RID: 3183
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C70 RID: 3184
		private static int HandleId;
	}
}
