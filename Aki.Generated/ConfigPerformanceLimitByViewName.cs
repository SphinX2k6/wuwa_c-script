using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064F RID: 1615
	public class ConfigPerformanceLimitByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025EA RID: 9706 RVA: 0x001300EA File Offset: 0x0012E2EA
		static ConfigPerformanceLimitByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPerformanceLimitByViewName.CreateStaticDefaultValue), new Action(ConfigPerformanceLimitByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0013010C File Offset: 0x0012E30C
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

		// Token: 0x060025EC RID: 9708 RVA: 0x0013018B File Offset: 0x0012E38B
		public static void ResetStaticDefaultValue()
		{
			ConfigPerformanceLimitByViewName.LogPair = null;
			ConfigPerformanceLimitByViewName.HandleId = 0;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00130199 File Offset: 0x0012E399
		public static void Init()
		{
			ConfigPerformanceLimitByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigPerformanceLimitByViewName.HandleId, "db_uiextrabehavior.db", "select BinData from `PerformanceLimit` where ViewName=?");
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x001301B4 File Offset: 0x0012E3B4
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

		// Token: 0x04002C0F RID: 11279
		private const string DB = "db_uiextrabehavior.db";

		// Token: 0x04002C10 RID: 11280
		private const string FILE = "u.Ui额外行为.xlsx";

		// Token: 0x04002C11 RID: 11281
		private const string TABLE = "PerformanceLimit";

		// Token: 0x04002C12 RID: 11282
		private const string COMMAND = "select BinData from `PerformanceLimit` where ViewName=?";

		// Token: 0x04002C13 RID: 11283
		private const string KEY_PREFIX = "PerformanceLimitByViewName";

		// Token: 0x04002C14 RID: 11284
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C15 RID: 11285
		private static int HandleId;
	}
}
