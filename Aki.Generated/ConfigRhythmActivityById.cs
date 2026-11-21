using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000809 RID: 2057
	public class ConfigRhythmActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003048 RID: 12360 RVA: 0x0016DA78 File Offset: 0x0016BC78
		static ConfigRhythmActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmActivityById.CreateStaticDefaultValue), new Action(ConfigRhythmActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0016DA98 File Offset: 0x0016BC98
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmActivity` where Id=?")
			});
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0016DB17 File Offset: 0x0016BD17
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmActivityById.LogPair = null;
			ConfigRhythmActivityById.HandleId = 0;
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0016DB25 File Offset: 0x0016BD25
		public static void Init()
		{
			ConfigRhythmActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmActivityById.HandleId, "db_rhythmship.db", "select BinData from `RhythmActivity` where Id=?");
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0016DB40 File Offset: 0x0016BD40
		public static RhythmActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmActivity?(RhythmActivity.GetRootAsRhythmActivity(configBuffer));
				}
			}
			ConfigRhythmActivityById.LogPair.Clear();
			ConfigRhythmActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmActivityById.HandleId, 1, p0Id, ConfigRhythmActivityById.LogPair) || ConfigCommon.Step(ConfigRhythmActivityById.HandleId, true, ConfigRhythmActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmActivityById.HandleId, 0, ConfigRhythmActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmActivity rootAsRhythmActivity = RhythmActivity.GetRootAsRhythmActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair);
			return new RhythmActivity?(rootAsRhythmActivity);
		}

		// Token: 0x04003825 RID: 14373
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003826 RID: 14374
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003827 RID: 14375
		private const string TABLE = "RhythmActivity";

		// Token: 0x04003828 RID: 14376
		private const string COMMAND = "select BinData from `RhythmActivity` where Id=?";

		// Token: 0x04003829 RID: 14377
		private const string KEY_PREFIX = "RhythmActivityById";

		// Token: 0x0400382A RID: 14378
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400382B RID: 14379
		private static int HandleId;
	}
}
