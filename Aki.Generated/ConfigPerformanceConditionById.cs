using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064D RID: 1613
	public class ConfigPerformanceConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x0012FBB1 File Offset: 0x0012DDB1
		static ConfigPerformanceConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPerformanceConditionById.CreateStaticDefaultValue), new Action(ConfigPerformanceConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x0012FBD0 File Offset: 0x0012DDD0
		public static void CreateStaticDefaultValue()
		{
			ConfigPerformanceConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPerformanceConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleidle.db"),
				new ValueTuple<string, object>("文件", "d.待机动作播放条件.xlsx"),
				new ValueTuple<string, object>("表名", "PerformanceCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `PerformanceCondition` where Id=?")
			});
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x0012FC4F File Offset: 0x0012DE4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPerformanceConditionById.LogPair = null;
			ConfigPerformanceConditionById.HandleId = 0;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0012FC5D File Offset: 0x0012DE5D
		public static void Init()
		{
			ConfigPerformanceConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigPerformanceConditionById.HandleId, "db_roleidle.db", "select BinData from `PerformanceCondition` where Id=?");
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x0012FC78 File Offset: 0x0012DE78
		public static PerformanceCondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPerformanceConditionById.HandleId, ConfigPerformanceConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PerformanceConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PerformanceCondition?(PerformanceCondition.GetRootAsPerformanceCondition(configBuffer));
				}
			}
			ConfigPerformanceConditionById.LogPair.Clear();
			ConfigPerformanceConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPerformanceConditionById.HandleId, 1, p0Id, ConfigPerformanceConditionById.LogPair) || ConfigCommon.Step(ConfigPerformanceConditionById.HandleId, true, ConfigPerformanceConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPerformanceConditionById.HandleId, ConfigPerformanceConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPerformanceConditionById.HandleId, 0, ConfigPerformanceConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPerformanceConditionById.HandleId, ConfigPerformanceConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PerformanceCondition rootAsPerformanceCondition = PerformanceCondition.GetRootAsPerformanceCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PerformanceConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPerformanceConditionById.HandleId, ConfigPerformanceConditionById.LogPair);
			return new PerformanceCondition?(rootAsPerformanceCondition);
		}

		// Token: 0x04002C01 RID: 11265
		private const string DB = "db_roleidle.db";

		// Token: 0x04002C02 RID: 11266
		private const string FILE = "d.待机动作播放条件.xlsx";

		// Token: 0x04002C03 RID: 11267
		private const string TABLE = "PerformanceCondition";

		// Token: 0x04002C04 RID: 11268
		private const string COMMAND = "select BinData from `PerformanceCondition` where Id=?";

		// Token: 0x04002C05 RID: 11269
		private const string KEY_PREFIX = "PerformanceConditionById";

		// Token: 0x04002C06 RID: 11270
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C07 RID: 11271
		private static int HandleId;
	}
}
