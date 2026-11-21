using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A9 RID: 1193
	public class ConfigKurotatoFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C01 RID: 7169 RVA: 0x000FB3E7 File Offset: 0x000F95E7
		static ConfigKurotatoFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoFormulaById.CreateStaticDefaultValue), new Action(ConfigKurotatoFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000FB408 File Offset: 0x000F9608
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

		// Token: 0x06001C03 RID: 7171 RVA: 0x000FB487 File Offset: 0x000F9687
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoFormulaById.LogPair = null;
			ConfigKurotatoFormulaById.HandleId = 0;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000FB495 File Offset: 0x000F9695
		public static void Init()
		{
			ConfigKurotatoFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoFormulaById.HandleId, "db_kurotato.db", "select BinData from `KurotatoFormula` where Id=?");
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000FB4B0 File Offset: 0x000F96B0
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

		// Token: 0x04002083 RID: 8323
		private const string DB = "db_kurotato.db";

		// Token: 0x04002084 RID: 8324
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04002085 RID: 8325
		private const string TABLE = "KurotatoFormula";

		// Token: 0x04002086 RID: 8326
		private const string COMMAND = "select BinData from `KurotatoFormula` where Id=?";

		// Token: 0x04002087 RID: 8327
		private const string KEY_PREFIX = "KurotatoFormulaById";

		// Token: 0x04002088 RID: 8328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002089 RID: 8329
		private static int HandleId;
	}
}
