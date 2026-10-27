using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083E RID: 2110
	public class ConfigRogueResCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003186 RID: 12678 RVA: 0x001716C4 File Offset: 0x0016F8C4
		static ConfigRogueResCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCurrencyById.CreateStaticDefaultValue), new Action(ConfigRogueResCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x001716E4 File Offset: 0x0016F8E4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCurrencyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCurrencyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCurrency` where Id=?")
			});
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00171763 File Offset: 0x0016F963
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCurrencyById.LogPair = null;
			ConfigRogueResCurrencyById.HandleId = 0;
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00171771 File Offset: 0x0016F971
		public static void Init()
		{
			ConfigRogueResCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCurrencyById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCurrency` where Id=?");
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x0017178C File Offset: 0x0016F98C
		public static RogueResCurrency? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCurrency?(RogueResCurrency.GetRootAsRogueResCurrency(configBuffer));
				}
			}
			ConfigRogueResCurrencyById.LogPair.Clear();
			ConfigRogueResCurrencyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCurrencyById.HandleId, 1, p0Id, ConfigRogueResCurrencyById.LogPair) || ConfigCommon.Step(ConfigRogueResCurrencyById.HandleId, true, ConfigRogueResCurrencyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCurrencyById.HandleId, 0, ConfigRogueResCurrencyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCurrency rootAsRogueResCurrency = RogueResCurrency.GetRootAsRogueResCurrency(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair);
			return new RogueResCurrency?(rootAsRogueResCurrency);
		}

		// Token: 0x04003998 RID: 14744
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003999 RID: 14745
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400399A RID: 14746
		private const string TABLE = "RogueResCurrency";

		// Token: 0x0400399B RID: 14747
		private const string COMMAND = "select BinData from `RogueResCurrency` where Id=?";

		// Token: 0x0400399C RID: 14748
		private const string KEY_PREFIX = "RogueResCurrencyById";

		// Token: 0x0400399D RID: 14749
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400399E RID: 14750
		private static int HandleId;
	}
}
