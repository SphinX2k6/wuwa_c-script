using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000821 RID: 2081
	public class ConfigRogueCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030D8 RID: 12504 RVA: 0x0016D718 File Offset: 0x0016B918
		static ConfigRogueCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueCurrencyById.CreateStaticDefaultValue), new Action(ConfigRogueCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0016D738 File Offset: 0x0016B938
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueCurrencyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueCurrencyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueCurrency` where Id=?")
			});
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x0016D7B7 File Offset: 0x0016B9B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueCurrencyById.LogPair = null;
			ConfigRogueCurrencyById.HandleId = 0;
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x0016D7C5 File Offset: 0x0016B9C5
		public static void Init()
		{
			ConfigRogueCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueCurrencyById.HandleId, "db_rogue.db", "select BinData from `RogueCurrency` where Id=?");
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0016D7E0 File Offset: 0x0016B9E0
		public static RogueCurrency? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueCurrency?(RogueCurrency.GetRootAsRogueCurrency(configBuffer));
				}
			}
			ConfigRogueCurrencyById.LogPair.Clear();
			ConfigRogueCurrencyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueCurrencyById.HandleId, 1, p0Id, ConfigRogueCurrencyById.LogPair) || ConfigCommon.Step(ConfigRogueCurrencyById.HandleId, true, ConfigRogueCurrencyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueCurrencyById.HandleId, 0, ConfigRogueCurrencyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueCurrency rootAsRogueCurrency = RogueCurrency.GetRootAsRogueCurrency(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair);
			return new RogueCurrency?(rootAsRogueCurrency);
		}

		// Token: 0x040038CD RID: 14541
		private const string DB = "db_rogue.db";

		// Token: 0x040038CE RID: 14542
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038CF RID: 14543
		private const string TABLE = "RogueCurrency";

		// Token: 0x040038D0 RID: 14544
		private const string COMMAND = "select BinData from `RogueCurrency` where Id=?";

		// Token: 0x040038D1 RID: 14545
		private const string KEY_PREFIX = "RogueCurrencyById";

		// Token: 0x040038D2 RID: 14546
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038D3 RID: 14547
		private static int HandleId;
	}
}
