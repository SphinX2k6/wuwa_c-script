using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000667 RID: 1639
	public class ConfigPerformanceLimitByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600267A RID: 9850 RVA: 0x00136B66 File Offset: 0x00134D66
		static ConfigPerformanceLimitByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPerformanceLimitByViewName.CreateStaticDefaultValue), new Action(ConfigPerformanceLimitByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00136B88 File Offset: 0x00134D88
		public static void CreateStaticDefaultValue()
		{
			ConfigPerformanceLimitByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPerformanceLimitByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uiextrabehavior.db"),
				new ValueTuple<string, object>("文件", "u.Ui额外行为.xlsx"),
				new ValueTuple<string, object>("表名", "PerformanceLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `PerformanceLimit` where ViewName=?")
			});
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00136C07 File Offset: 0x00134E07
		public static void ResetStaticDefaultValue()
		{
			ConfigPerformanceLimitByViewName.LogPair = null;
			ConfigPerformanceLimitByViewName.HandleId = 0;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00136C15 File Offset: 0x00134E15
		public static void Init()
		{
			ConfigPerformanceLimitByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigPerformanceLimitByViewName.HandleId, "db_uiextrabehavior.db", "select BinData from `PerformanceLimit` where ViewName=?");
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00136C30 File Offset: 0x00134E30
		public static PerformanceLimit? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPerformanceLimitByViewName.HandleId, ConfigPerformanceLimitByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PerformanceLimitByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new PerformanceLimit?(PerformanceLimit.GetRootAsPerformanceLimit(configBuffer));
				}
			}
			ConfigPerformanceLimitByViewName.LogPair.Clear();
			ConfigPerformanceLimitByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigPerformanceLimitByViewName.HandleId, 1, p0ViewName, ConfigPerformanceLimitByViewName.LogPair) || ConfigCommon.Step(ConfigPerformanceLimitByViewName.HandleId, false, ConfigPerformanceLimitByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPerformanceLimitByViewName.HandleId, ConfigPerformanceLimitByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPerformanceLimitByViewName.HandleId, 0, ConfigPerformanceLimitByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPerformanceLimitByViewName.HandleId, ConfigPerformanceLimitByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PerformanceLimit rootAsPerformanceLimit = PerformanceLimit.GetRootAsPerformanceLimit(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PerformanceLimitByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPerformanceLimitByViewName.HandleId, ConfigPerformanceLimitByViewName.LogPair);
			return new PerformanceLimit?(rootAsPerformanceLimit);
		}

		// Token: 0x04002CB7 RID: 11447
		private const string DB = "db_uiextrabehavior.db";

		// Token: 0x04002CB8 RID: 11448
		private const string FILE = "u.Ui额外行为.xlsx";

		// Token: 0x04002CB9 RID: 11449
		private const string TABLE = "PerformanceLimit";

		// Token: 0x04002CBA RID: 11450
		private const string COMMAND = "select BinData from `PerformanceLimit` where ViewName=?";

		// Token: 0x04002CBB RID: 11451
		private const string KEY_PREFIX = "PerformanceLimitByViewName";

		// Token: 0x04002CBC RID: 11452
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CBD RID: 11453
		private static int HandleId;
	}
}
