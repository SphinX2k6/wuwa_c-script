using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C2 RID: 450
	public class ConfigDangoBrawlActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x000954E4 File Offset: 0x000936E4
		static ConfigDangoBrawlActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoBrawlActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00095504 File Offset: 0x00093704
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlActivity` where ActivityId=?")
			});
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00095583 File Offset: 0x00093783
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlActivityByActivityId.LogPair = null;
			ConfigDangoBrawlActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00095591 File Offset: 0x00093791
		public static void Init()
		{
			ConfigDangoBrawlActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlActivityByActivityId.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlActivity` where ActivityId=?");
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000955AC File Offset: 0x000937AC
		public static DangoBrawlActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlActivity?(DangoBrawlActivity.GetRootAsDangoBrawlActivity(configBuffer));
				}
			}
			ConfigDangoBrawlActivityByActivityId.LogPair.Clear();
			ConfigDangoBrawlActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlActivityByActivityId.HandleId, 1, p0ActivityId, ConfigDangoBrawlActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigDangoBrawlActivityByActivityId.HandleId, true, ConfigDangoBrawlActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlActivityByActivityId.HandleId, 0, ConfigDangoBrawlActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlActivity rootAsDangoBrawlActivity = DangoBrawlActivity.GetRootAsDangoBrawlActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair);
			return new DangoBrawlActivity?(rootAsDangoBrawlActivity);
		}

		// Token: 0x04000C32 RID: 3122
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C33 RID: 3123
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C34 RID: 3124
		private const string TABLE = "DangoBrawlActivity";

		// Token: 0x04000C35 RID: 3125
		private const string COMMAND = "select BinData from `DangoBrawlActivity` where ActivityId=?";

		// Token: 0x04000C36 RID: 3126
		private const string KEY_PREFIX = "DangoBrawlActivityByActivityId";

		// Token: 0x04000C37 RID: 3127
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C38 RID: 3128
		private static int HandleId;
	}
}
