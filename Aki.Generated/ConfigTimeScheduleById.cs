using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E6 RID: 2534
	public class ConfigTimeScheduleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B78 RID: 15224 RVA: 0x001AA184 File Offset: 0x001A8384
		static ConfigTimeScheduleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimeScheduleById.CreateStaticDefaultValue), new Action(ConfigTimeScheduleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x001AA1A4 File Offset: 0x001A83A4
		public static void CreateStaticDefaultValue()
		{
			ConfigTimeScheduleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTimeScheduleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_timeschedule.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/r.日程表/*.csv*"),
				new ValueTuple<string, object>("表名", "TimeSchedule"),
				new ValueTuple<string, object>("语句", "select BinData from `TimeSchedule` where Id = ?")
			});
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x001AA223 File Offset: 0x001A8423
		public static void ResetStaticDefaultValue()
		{
			ConfigTimeScheduleById.LogPair = null;
			ConfigTimeScheduleById.HandleId = 0;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x001AA231 File Offset: 0x001A8431
		public static void Init()
		{
			ConfigTimeScheduleById.HandleId = ConfigCommon.InitDataStatement(ConfigTimeScheduleById.HandleId, "db_timeschedule.db", "select BinData from `TimeSchedule` where Id = ?");
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x001AA24C File Offset: 0x001A844C
		public static TimeSchedule? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTimeScheduleById.HandleId, ConfigTimeScheduleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimeScheduleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TimeSchedule?(TimeSchedule.GetRootAsTimeSchedule(configBuffer));
				}
			}
			ConfigTimeScheduleById.LogPair.Clear();
			ConfigTimeScheduleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTimeScheduleById.HandleId, 1, p0Id, ConfigTimeScheduleById.LogPair) || ConfigCommon.Step(ConfigTimeScheduleById.HandleId, true, ConfigTimeScheduleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTimeScheduleById.HandleId, ConfigTimeScheduleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTimeScheduleById.HandleId, 0, ConfigTimeScheduleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTimeScheduleById.HandleId, ConfigTimeScheduleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TimeSchedule rootAsTimeSchedule = TimeSchedule.GetRootAsTimeSchedule(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimeScheduleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTimeScheduleById.HandleId, ConfigTimeScheduleById.LogPair);
			return new TimeSchedule?(rootAsTimeSchedule);
		}

		// Token: 0x04004530 RID: 17712
		private const string DB = "db_timeschedule.db";

		// Token: 0x04004531 RID: 17713
		private const string FILE = "k.可视化编辑/c.Csv/r.日程表/*.csv*";

		// Token: 0x04004532 RID: 17714
		private const string TABLE = "TimeSchedule";

		// Token: 0x04004533 RID: 17715
		private const string COMMAND = "select BinData from `TimeSchedule` where Id = ?";

		// Token: 0x04004534 RID: 17716
		private const string KEY_PREFIX = "TimeScheduleById";

		// Token: 0x04004535 RID: 17717
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004536 RID: 17718
		private static int HandleId;
	}
}
