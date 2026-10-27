using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000493 RID: 1171
	public class ConfigKurotatoFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B7D RID: 7037 RVA: 0x000F4C93 File Offset: 0x000F2E93
		static ConfigKurotatoFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoFormulaById.CreateStaticDefaultValue), new Action(ConfigKurotatoFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000F4CB4 File Offset: 0x000F2EB4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoFormulaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoFormulaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoFormula` where Id=?")
			});
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x000F4D33 File Offset: 0x000F2F33
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoFormulaById.LogPair = null;
			ConfigKurotatoFormulaById.HandleId = 0;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000F4D41 File Offset: 0x000F2F41
		public static void Init()
		{
			ConfigKurotatoFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoFormulaById.HandleId, "db_kurotato.db", "select BinData from `KurotatoFormula` where Id=?");
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000F4D5C File Offset: 0x000F2F5C
		public static KurotatoFormula? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoFormulaById.HandleId, ConfigKurotatoFormulaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoFormula?(KurotatoFormula.GetRootAsKurotatoFormula(configBuffer));
				}
			}
			ConfigKurotatoFormulaById.LogPair.Clear();
			ConfigKurotatoFormulaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoFormulaById.HandleId, 1, p0Id, ConfigKurotatoFormulaById.LogPair) || ConfigCommon.Step(ConfigKurotatoFormulaById.HandleId, true, ConfigKurotatoFormulaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoFormulaById.HandleId, ConfigKurotatoFormulaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoFormulaById.HandleId, 0, ConfigKurotatoFormulaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoFormulaById.HandleId, ConfigKurotatoFormulaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoFormula rootAsKurotatoFormula = KurotatoFormula.GetRootAsKurotatoFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoFormulaById.HandleId, ConfigKurotatoFormulaById.LogPair);
			return new KurotatoFormula?(rootAsKurotatoFormula);
		}

		// Token: 0x04001FE9 RID: 8169
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FEA RID: 8170
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04001FEB RID: 8171
		private const string TABLE = "KurotatoFormula";

		// Token: 0x04001FEC RID: 8172
		private const string COMMAND = "select BinData from `KurotatoFormula` where Id=?";

		// Token: 0x04001FED RID: 8173
		private const string KEY_PREFIX = "KurotatoFormulaById";

		// Token: 0x04001FEE RID: 8174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FEF RID: 8175
		private static int HandleId;
	}
}
