using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000808 RID: 2056
	public class ConfigRhythmActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003042 RID: 12354 RVA: 0x0016D830 File Offset: 0x0016BA30
		static ConfigRhythmActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigRhythmActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0016D850 File Offset: 0x0016BA50
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

		// Token: 0x06003044 RID: 12356 RVA: 0x0016D8CF File Offset: 0x0016BACF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmActivityByActivityId.LogPair = null;
			ConfigRhythmActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0016D8DD File Offset: 0x0016BADD
		public static void Init()
		{
			ConfigRhythmActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmActivityByActivityId.HandleId, "db_rhythmship.db", "select BinData from `RhythmActivity` where ActivityId=?");
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0016D8F8 File Offset: 0x0016BAF8
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

		// Token: 0x0400381E RID: 14366
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400381F RID: 14367
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003820 RID: 14368
		private const string TABLE = "RhythmActivity";

		// Token: 0x04003821 RID: 14369
		private const string COMMAND = "select BinData from `RhythmActivity` where ActivityId=?";

		// Token: 0x04003822 RID: 14370
		private const string KEY_PREFIX = "RhythmActivityByActivityId";

		// Token: 0x04003823 RID: 14371
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003824 RID: 14372
		private static int HandleId;
	}
}
