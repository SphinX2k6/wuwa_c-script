using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020B RID: 523
	public class ConfigDaySelectPresetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x000A2967 File Offset: 0x000A0B67
		static ConfigDaySelectPresetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDaySelectPresetById.CreateStaticDefaultValue), new Action(ConfigDaySelectPresetById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000A2988 File Offset: 0x000A0B88
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

		// Token: 0x06000C47 RID: 3143 RVA: 0x000A2A07 File Offset: 0x000A0C07
		public static void ResetStaticDefaultValue()
		{
			ConfigDaySelectPresetById.LogPair = null;
			ConfigDaySelectPresetById.HandleId = 0;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000A2A15 File Offset: 0x000A0C15
		public static void Init()
		{
			ConfigDaySelectPresetById.HandleId = ConfigCommon.InitDataStatement(ConfigDaySelectPresetById.HandleId, "db_time_of_day.db", "select BinData from `DaySelectPreset` where Id=?");
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000A2A30 File Offset: 0x000A0C30
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

		// Token: 0x04000E31 RID: 3633
		private const string DB = "db_time_of_day.db";

		// Token: 0x04000E32 RID: 3634
		private const string FILE = "s.时间系统.xlsx";

		// Token: 0x04000E33 RID: 3635
		private const string TABLE = "DaySelectPreset";

		// Token: 0x04000E34 RID: 3636
		private const string COMMAND = "select BinData from `DaySelectPreset` where Id=?";

		// Token: 0x04000E35 RID: 3637
		private const string KEY_PREFIX = "DaySelectPresetById";

		// Token: 0x04000E36 RID: 3638
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E37 RID: 3639
		private static int HandleId;
	}
}
