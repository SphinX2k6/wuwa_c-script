using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EC RID: 2028
	public class ConfigRhythmActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F9A RID: 12186 RVA: 0x00166548 File Offset: 0x00164748
		static ConfigRhythmActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigRhythmActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00166568 File Offset: 0x00164768
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmActivity` where ActivityId=?")
			});
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x001665E7 File Offset: 0x001647E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmActivityByActivityId.LogPair = null;
			ConfigRhythmActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x001665F5 File Offset: 0x001647F5
		public static void Init()
		{
			ConfigRhythmActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmActivityByActivityId.HandleId, "db_rhythmship.db", "select BinData from `RhythmActivity` where ActivityId=?");
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00166610 File Offset: 0x00164810
		public static RhythmActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmActivityByActivityId.HandleId, ConfigRhythmActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmActivity?(RhythmActivity.GetRootAsRhythmActivity(configBuffer));
				}
			}
			ConfigRhythmActivityByActivityId.LogPair.Clear();
			ConfigRhythmActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRhythmActivityByActivityId.HandleId, 1, p0ActivityId, ConfigRhythmActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigRhythmActivityByActivityId.HandleId, true, ConfigRhythmActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmActivityByActivityId.HandleId, ConfigRhythmActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmActivityByActivityId.HandleId, 0, ConfigRhythmActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmActivityByActivityId.HandleId, ConfigRhythmActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmActivity rootAsRhythmActivity = RhythmActivity.GetRootAsRhythmActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmActivityByActivityId.HandleId, ConfigRhythmActivityByActivityId.LogPair);
			return new RhythmActivity?(rootAsRhythmActivity);
		}

		// Token: 0x0400375A RID: 14170
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400375B RID: 14171
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400375C RID: 14172
		private const string TABLE = "RhythmActivity";

		// Token: 0x0400375D RID: 14173
		private const string COMMAND = "select BinData from `RhythmActivity` where ActivityId=?";

		// Token: 0x0400375E RID: 14174
		private const string KEY_PREFIX = "RhythmActivityByActivityId";

		// Token: 0x0400375F RID: 14175
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003760 RID: 14176
		private static int HandleId;
	}
}
