using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000666 RID: 1638
	public class ConfigPerformanceConditionByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002674 RID: 9844 RVA: 0x00136874 File Offset: 0x00134A74
		static ConfigPerformanceConditionByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPerformanceConditionByIdWithZero.CreateStaticDefaultValue), new Action(ConfigPerformanceConditionByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00136894 File Offset: 0x00134A94
		public static void CreateStaticDefaultValue()
		{
			ConfigPerformanceConditionByIdWithZero.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPerformanceConditionByIdWithZero.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleidle.db"),
				new ValueTuple<string, object>("文件", "d.待机动作播放条件.xlsx"),
				new ValueTuple<string, object>("表名", "PerformanceCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `PerformanceCondition` where id=0 AND (SELECT count(0) from `PerformanceCondition` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `PerformanceCondition` WHERE id = ?) >0;")
			});
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00136913 File Offset: 0x00134B13
		public static void ResetStaticDefaultValue()
		{
			ConfigPerformanceConditionByIdWithZero.LogPair = null;
			ConfigPerformanceConditionByIdWithZero.HandleId = 0;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00136921 File Offset: 0x00134B21
		public static void Init()
		{
			ConfigPerformanceConditionByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigPerformanceConditionByIdWithZero.HandleId, "db_roleidle.db", "select BinData from `PerformanceCondition` where id=0 AND (SELECT count(0) from `PerformanceCondition` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `PerformanceCondition` WHERE id = ?) >0;");
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x0013693C File Offset: 0x00134B3C
		public static PerformanceCondition? GetConfig(int p0Id, int p1Id, int p2Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPerformanceConditionByIdWithZero.HandleId, ConfigPerformanceConditionByIdWithZero.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("PerformanceConditionByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PerformanceCondition?(PerformanceCondition.GetRootAsPerformanceCondition(configBuffer));
				}
			}
			ConfigPerformanceConditionByIdWithZero.LogPair.Clear();
			ConfigPerformanceConditionByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigPerformanceConditionByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigPerformanceConditionByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			if (!ConfigCommon.BindInt(ConfigPerformanceConditionByIdWithZero.HandleId, 1, p0Id, ConfigPerformanceConditionByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigPerformanceConditionByIdWithZero.HandleId, 2, p1Id, ConfigPerformanceConditionByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigPerformanceConditionByIdWithZero.HandleId, 3, p2Id, ConfigPerformanceConditionByIdWithZero.LogPair) || ConfigCommon.Step(ConfigPerformanceConditionByIdWithZero.HandleId, true, ConfigPerformanceConditionByIdWithZero.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPerformanceConditionByIdWithZero.HandleId, ConfigPerformanceConditionByIdWithZero.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPerformanceConditionByIdWithZero.HandleId, 0, ConfigPerformanceConditionByIdWithZero.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPerformanceConditionByIdWithZero.HandleId, ConfigPerformanceConditionByIdWithZero.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PerformanceCondition rootAsPerformanceCondition = PerformanceCondition.GetRootAsPerformanceCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("PerformanceConditionByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPerformanceConditionByIdWithZero.HandleId, ConfigPerformanceConditionByIdWithZero.LogPair);
			return new PerformanceCondition?(rootAsPerformanceCondition);
		}

		// Token: 0x04002CB0 RID: 11440
		private const string DB = "db_roleidle.db";

		// Token: 0x04002CB1 RID: 11441
		private const string FILE = "d.待机动作播放条件.xlsx";

		// Token: 0x04002CB2 RID: 11442
		private const string TABLE = "PerformanceCondition";

		// Token: 0x04002CB3 RID: 11443
		private const string COMMAND = "select BinData from `PerformanceCondition` where id=0 AND (SELECT count(0) from `PerformanceCondition` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `PerformanceCondition` WHERE id = ?) >0;";

		// Token: 0x04002CB4 RID: 11444
		private const string KEY_PREFIX = "PerformanceConditionByIdWithZero";

		// Token: 0x04002CB5 RID: 11445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CB6 RID: 11446
		private static int HandleId;
	}
}
