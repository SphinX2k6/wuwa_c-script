using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000665 RID: 1637
	public class ConfigPerformanceConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x0013662D File Offset: 0x0013482D
		static ConfigPerformanceConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPerformanceConditionById.CreateStaticDefaultValue), new Action(ConfigPerformanceConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0013664C File Offset: 0x0013484C
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

		// Token: 0x06002670 RID: 9840 RVA: 0x001366CB File Offset: 0x001348CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPerformanceConditionById.LogPair = null;
			ConfigPerformanceConditionById.HandleId = 0;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x001366D9 File Offset: 0x001348D9
		public static void Init()
		{
			ConfigPerformanceConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigPerformanceConditionById.HandleId, "db_roleidle.db", "select BinData from `PerformanceCondition` where Id=?");
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x001366F4 File Offset: 0x001348F4
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

		// Token: 0x04002CA9 RID: 11433
		private const string DB = "db_roleidle.db";

		// Token: 0x04002CAA RID: 11434
		private const string FILE = "d.待机动作播放条件.xlsx";

		// Token: 0x04002CAB RID: 11435
		private const string TABLE = "PerformanceCondition";

		// Token: 0x04002CAC RID: 11436
		private const string COMMAND = "select BinData from `PerformanceCondition` where Id=?";

		// Token: 0x04002CAD RID: 11437
		private const string KEY_PREFIX = "PerformanceConditionById";

		// Token: 0x04002CAE RID: 11438
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CAF RID: 11439
		private static int HandleId;
	}
}
