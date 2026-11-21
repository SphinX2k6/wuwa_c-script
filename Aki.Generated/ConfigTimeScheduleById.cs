using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABB RID: 2747
	public class ConfigTimeScheduleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004076 RID: 16502 RVA: 0x001C9518 File Offset: 0x001C7718
		static ConfigTimeScheduleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimeScheduleById.CreateStaticDefaultValue), new Action(ConfigTimeScheduleById.ResetStaticDefaultValue));
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x001C9538 File Offset: 0x001C7738
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

		// Token: 0x06004078 RID: 16504 RVA: 0x001C95B7 File Offset: 0x001C77B7
		public static void ResetStaticDefaultValue()
		{
			ConfigTimeScheduleById.LogPair = null;
			ConfigTimeScheduleById.HandleId = 0;
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x001C95C5 File Offset: 0x001C77C5
		public static void Init()
		{
			ConfigTimeScheduleById.HandleId = ConfigCommon.InitDataStatement(ConfigTimeScheduleById.HandleId, "db_timeschedule.db", "select BinData from `TimeSchedule` where Id = ?");
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x001C95E0 File Offset: 0x001C77E0
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

		// Token: 0x04004B03 RID: 19203
		private const string DB = "db_timeschedule.db";

		// Token: 0x04004B04 RID: 19204
		private const string FILE = "k.可视化编辑/c.Csv/r.日程表/*.csv*";

		// Token: 0x04004B05 RID: 19205
		private const string TABLE = "TimeSchedule";

		// Token: 0x04004B06 RID: 19206
		private const string COMMAND = "select BinData from `TimeSchedule` where Id = ?";

		// Token: 0x04004B07 RID: 19207
		private const string KEY_PREFIX = "TimeScheduleById";

		// Token: 0x04004B08 RID: 19208
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B09 RID: 19209
		private static int HandleId;
	}
}
