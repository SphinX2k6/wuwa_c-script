using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A97 RID: 2711
	public class ConfigWeeklyFrameAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F9F RID: 16287 RVA: 0x001C2257 File Offset: 0x001C0457
		static ConfigWeeklyFrameAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameAwardById.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x001C2278 File Offset: 0x001C0478
		public static void CreateStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeeklyFrameAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "WeeklyFrameAward"),
				new ValueTuple<string, object>("语句", "select BinData from `WeeklyFrameAward` where Id = ?")
			});
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x001C22F7 File Offset: 0x001C04F7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardById.LogPair = null;
			ConfigWeeklyFrameAwardById.HandleId = 0;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x001C2305 File Offset: 0x001C0505
		public static void Init()
		{
			ConfigWeeklyFrameAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameAwardById.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameAward` where Id = ?");
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x001C2320 File Offset: 0x001C0520
		public static WeeklyFrameAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeeklyFrameAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeeklyFrameAward?(WeeklyFrameAward.GetRootAsWeeklyFrameAward(configBuffer));
				}
			}
			ConfigWeeklyFrameAwardById.LogPair.Clear();
			ConfigWeeklyFrameAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeeklyFrameAwardById.HandleId, 1, p0Id, ConfigWeeklyFrameAwardById.LogPair) || ConfigCommon.Step(ConfigWeeklyFrameAwardById.HandleId, true, ConfigWeeklyFrameAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeeklyFrameAwardById.HandleId, 0, ConfigWeeklyFrameAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeeklyFrameAward rootAsWeeklyFrameAward = WeeklyFrameAward.GetRootAsWeeklyFrameAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeeklyFrameAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair);
			return new WeeklyFrameAward?(rootAsWeeklyFrameAward);
		}

		// Token: 0x04004A07 RID: 18951
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004A08 RID: 18952
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004A09 RID: 18953
		private const string TABLE = "WeeklyFrameAward";

		// Token: 0x04004A0A RID: 18954
		private const string COMMAND = "select BinData from `WeeklyFrameAward` where Id = ?";

		// Token: 0x04004A0B RID: 18955
		private const string KEY_PREFIX = "WeeklyFrameAwardById";

		// Token: 0x04004A0C RID: 18956
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A0D RID: 18957
		private static int HandleId;
	}
}
