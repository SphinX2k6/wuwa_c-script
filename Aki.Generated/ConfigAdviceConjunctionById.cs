using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000076 RID: 118
	public class ConfigAdviceConjunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x000691D7 File Offset: 0x000673D7
		static ConfigAdviceConjunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceConjunctionById.CreateStaticDefaultValue), new Action(ConfigAdviceConjunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000691F8 File Offset: 0x000673F8
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

		// Token: 0x060002C6 RID: 710 RVA: 0x00069277 File Offset: 0x00067477
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceConjunctionById.LogPair = null;
			ConfigAdviceConjunctionById.HandleId = 0;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00069285 File Offset: 0x00067485
		public static void Init()
		{
			ConfigAdviceConjunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceConjunctionById.HandleId, "db_advice.db", "select BinData from `AdviceConjunction` where Id=?");
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000692A0 File Offset: 0x000674A0
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

		// Token: 0x0400031E RID: 798
		private const string DB = "db_advice.db";

		// Token: 0x0400031F RID: 799
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000320 RID: 800
		private const string TABLE = "AdviceConjunction";

		// Token: 0x04000321 RID: 801
		private const string COMMAND = "select BinData from `AdviceConjunction` where Id=?";

		// Token: 0x04000322 RID: 802
		private const string KEY_PREFIX = "AdviceConjunctionById";

		// Token: 0x04000323 RID: 803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000324 RID: 804
		private static int HandleId;
	}
}
