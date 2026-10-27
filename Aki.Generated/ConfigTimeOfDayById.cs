using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E2 RID: 2530
	public class ConfigTimeOfDayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B60 RID: 15200 RVA: 0x001A9875 File Offset: 0x001A7A75
		static ConfigTimeOfDayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimeOfDayById.CreateStaticDefaultValue), new Action(ConfigTimeOfDayById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x001A9894 File Offset: 0x001A7A94
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

		// Token: 0x06003B62 RID: 15202 RVA: 0x001A9913 File Offset: 0x001A7B13
		public static void ResetStaticDefaultValue()
		{
			ConfigTimeOfDayById.LogPair = null;
			ConfigTimeOfDayById.HandleId = 0;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x001A9921 File Offset: 0x001A7B21
		public static void Init()
		{
			ConfigTimeOfDayById.HandleId = ConfigCommon.InitDataStatement(ConfigTimeOfDayById.HandleId, "db_time_of_day.db", "select BinData from `TimeOfDay` where Id = ?");
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x001A993C File Offset: 0x001A7B3C
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

		// Token: 0x04004514 RID: 17684
		private const string DB = "db_time_of_day.db";

		// Token: 0x04004515 RID: 17685
		private const string FILE = "s.时间系统.xlsx";

		// Token: 0x04004516 RID: 17686
		private const string TABLE = "TimeOfDay";

		// Token: 0x04004517 RID: 17687
		private const string COMMAND = "select BinData from `TimeOfDay` where Id = ?";

		// Token: 0x04004518 RID: 17688
		private const string KEY_PREFIX = "TimeOfDayById";

		// Token: 0x04004519 RID: 17689
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400451A RID: 17690
		private static int HandleId;
	}
}
