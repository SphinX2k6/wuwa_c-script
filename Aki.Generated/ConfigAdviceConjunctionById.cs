using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007E RID: 126
	public class ConfigAdviceConjunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0006DA8B File Offset: 0x0006BC8B
		static ConfigAdviceConjunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceConjunctionById.CreateStaticDefaultValue), new Action(ConfigAdviceConjunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0006DAAC File Offset: 0x0006BCAC
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceConjunctionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceConjunctionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceConjunction"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceConjunction` where Id=?")
			});
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0006DB2B File Offset: 0x0006BD2B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceConjunctionById.LogPair = null;
			ConfigAdviceConjunctionById.HandleId = 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0006DB39 File Offset: 0x0006BD39
		public static void Init()
		{
			ConfigAdviceConjunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceConjunctionById.HandleId, "db_advice.db", "select BinData from `AdviceConjunction` where Id=?");
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0006DB54 File Offset: 0x0006BD54
		public static AdviceConjunction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceConjunctionById.HandleId, ConfigAdviceConjunctionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceConjunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdviceConjunction?(AdviceConjunction.GetRootAsAdviceConjunction(configBuffer));
				}
			}
			ConfigAdviceConjunctionById.LogPair.Clear();
			ConfigAdviceConjunctionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdviceConjunctionById.HandleId, 1, p0Id, ConfigAdviceConjunctionById.LogPair) || ConfigCommon.Step(ConfigAdviceConjunctionById.HandleId, true, ConfigAdviceConjunctionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdviceConjunctionById.HandleId, ConfigAdviceConjunctionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceConjunctionById.HandleId, 0, ConfigAdviceConjunctionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdviceConjunctionById.HandleId, ConfigAdviceConjunctionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdviceConjunction rootAsAdviceConjunction = AdviceConjunction.GetRootAsAdviceConjunction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceConjunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdviceConjunctionById.HandleId, ConfigAdviceConjunctionById.LogPair);
			return new AdviceConjunction?(rootAsAdviceConjunction);
		}

		// Token: 0x04000356 RID: 854
		private const string DB = "db_advice.db";

		// Token: 0x04000357 RID: 855
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000358 RID: 856
		private const string TABLE = "AdviceConjunction";

		// Token: 0x04000359 RID: 857
		private const string COMMAND = "select BinData from `AdviceConjunction` where Id=?";

		// Token: 0x0400035A RID: 858
		private const string KEY_PREFIX = "AdviceConjunctionById";

		// Token: 0x0400035B RID: 859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400035C RID: 860
		private static int HandleId;
	}
}
