using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F9 RID: 505
	public class ConfigDaySelectPresetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x0009CA2F File Offset: 0x0009AC2F
		static ConfigDaySelectPresetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDaySelectPresetById.CreateStaticDefaultValue), new Action(ConfigDaySelectPresetById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0009CA50 File Offset: 0x0009AC50
		public static void CreateStaticDefaultValue()
		{
			ConfigDaySelectPresetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDaySelectPresetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_time_of_day.db"),
				new ValueTuple<string, object>("文件", "s.时间系统.xlsx"),
				new ValueTuple<string, object>("表名", "DaySelectPreset"),
				new ValueTuple<string, object>("语句", "select BinData from `DaySelectPreset` where Id=?")
			});
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0009CACF File Offset: 0x0009ACCF
		public static void ResetStaticDefaultValue()
		{
			ConfigDaySelectPresetById.LogPair = null;
			ConfigDaySelectPresetById.HandleId = 0;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0009CADD File Offset: 0x0009ACDD
		public static void Init()
		{
			ConfigDaySelectPresetById.HandleId = ConfigCommon.InitDataStatement(ConfigDaySelectPresetById.HandleId, "db_time_of_day.db", "select BinData from `DaySelectPreset` where Id=?");
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0009CAF8 File Offset: 0x0009ACF8
		public static DaySelectPreset? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDaySelectPresetById.HandleId, ConfigDaySelectPresetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DaySelectPresetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DaySelectPreset?(DaySelectPreset.GetRootAsDaySelectPreset(configBuffer));
				}
			}
			ConfigDaySelectPresetById.LogPair.Clear();
			ConfigDaySelectPresetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDaySelectPresetById.HandleId, 1, p0Id, ConfigDaySelectPresetById.LogPair) || ConfigCommon.Step(ConfigDaySelectPresetById.HandleId, true, ConfigDaySelectPresetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDaySelectPresetById.HandleId, ConfigDaySelectPresetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDaySelectPresetById.HandleId, 0, ConfigDaySelectPresetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDaySelectPresetById.HandleId, ConfigDaySelectPresetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DaySelectPreset rootAsDaySelectPreset = DaySelectPreset.GetRootAsDaySelectPreset(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DaySelectPresetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDaySelectPresetById.HandleId, ConfigDaySelectPresetById.LogPair);
			return new DaySelectPreset?(rootAsDaySelectPreset);
		}

		// Token: 0x04000DB3 RID: 3507
		private const string DB = "db_time_of_day.db";

		// Token: 0x04000DB4 RID: 3508
		private const string FILE = "s.时间系统.xlsx";

		// Token: 0x04000DB5 RID: 3509
		private const string TABLE = "DaySelectPreset";

		// Token: 0x04000DB6 RID: 3510
		private const string COMMAND = "select BinData from `DaySelectPreset` where Id=?";

		// Token: 0x04000DB7 RID: 3511
		private const string KEY_PREFIX = "DaySelectPresetById";

		// Token: 0x04000DB8 RID: 3512
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DB9 RID: 3513
		private static int HandleId;
	}
}
