using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB7 RID: 2743
	public class ConfigTimeOfDayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600405E RID: 16478 RVA: 0x001C8C09 File Offset: 0x001C6E09
		static ConfigTimeOfDayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimeOfDayById.CreateStaticDefaultValue), new Action(ConfigTimeOfDayById.ResetStaticDefaultValue));
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x001C8C28 File Offset: 0x001C6E28
		public static void CreateStaticDefaultValue()
		{
			ConfigTimeOfDayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTimeOfDayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_time_of_day.db"),
				new ValueTuple<string, object>("文件", "s.时间系统.xlsx"),
				new ValueTuple<string, object>("表名", "TimeOfDay"),
				new ValueTuple<string, object>("语句", "select BinData from `TimeOfDay` where Id = ?")
			});
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x001C8CA7 File Offset: 0x001C6EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigTimeOfDayById.LogPair = null;
			ConfigTimeOfDayById.HandleId = 0;
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x001C8CB5 File Offset: 0x001C6EB5
		public static void Init()
		{
			ConfigTimeOfDayById.HandleId = ConfigCommon.InitDataStatement(ConfigTimeOfDayById.HandleId, "db_time_of_day.db", "select BinData from `TimeOfDay` where Id = ?");
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x001C8CD0 File Offset: 0x001C6ED0
		public static TimeOfDay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTimeOfDayById.HandleId, ConfigTimeOfDayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimeOfDayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TimeOfDay?(TimeOfDay.GetRootAsTimeOfDay(configBuffer));
				}
			}
			ConfigTimeOfDayById.LogPair.Clear();
			ConfigTimeOfDayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTimeOfDayById.HandleId, 1, p0Id, ConfigTimeOfDayById.LogPair) || ConfigCommon.Step(ConfigTimeOfDayById.HandleId, true, ConfigTimeOfDayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTimeOfDayById.HandleId, ConfigTimeOfDayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTimeOfDayById.HandleId, 0, ConfigTimeOfDayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTimeOfDayById.HandleId, ConfigTimeOfDayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TimeOfDay rootAsTimeOfDay = TimeOfDay.GetRootAsTimeOfDay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimeOfDayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTimeOfDayById.HandleId, ConfigTimeOfDayById.LogPair);
			return new TimeOfDay?(rootAsTimeOfDay);
		}

		// Token: 0x04004AE7 RID: 19175
		private const string DB = "db_time_of_day.db";

		// Token: 0x04004AE8 RID: 19176
		private const string FILE = "s.时间系统.xlsx";

		// Token: 0x04004AE9 RID: 19177
		private const string TABLE = "TimeOfDay";

		// Token: 0x04004AEA RID: 19178
		private const string COMMAND = "select BinData from `TimeOfDay` where Id = ?";

		// Token: 0x04004AEB RID: 19179
		private const string KEY_PREFIX = "TimeOfDayById";

		// Token: 0x04004AEC RID: 19180
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AED RID: 19181
		private static int HandleId;
	}
}
