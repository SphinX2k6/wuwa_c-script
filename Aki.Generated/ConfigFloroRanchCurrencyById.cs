using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000316 RID: 790
	public class ConfigFloroRanchCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x000C23D3 File Offset: 0x000C05D3
		static ConfigFloroRanchCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCurrencyById.CreateStaticDefaultValue), new Action(ConfigFloroRanchCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000C23F4 File Offset: 0x000C05F4
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCurrencyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCurrencyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCurrency` where Id=?")
			});
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000C2473 File Offset: 0x000C0673
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCurrencyById.LogPair = null;
			ConfigFloroRanchCurrencyById.HandleId = 0;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000C2481 File Offset: 0x000C0681
		public static void Init()
		{
			ConfigFloroRanchCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCurrencyById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCurrency` where Id=?");
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000C249C File Offset: 0x000C069C
		public static FloroRanchCurrency? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCurrencyById.HandleId, ConfigFloroRanchCurrencyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchCurrency?(FloroRanchCurrency.GetRootAsFloroRanchCurrency(configBuffer));
				}
			}
			ConfigFloroRanchCurrencyById.LogPair.Clear();
			ConfigFloroRanchCurrencyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchCurrencyById.HandleId, 1, p0Id, ConfigFloroRanchCurrencyById.LogPair) || ConfigCommon.Step(ConfigFloroRanchCurrencyById.HandleId, true, ConfigFloroRanchCurrencyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchCurrencyById.HandleId, ConfigFloroRanchCurrencyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCurrencyById.HandleId, 0, ConfigFloroRanchCurrencyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchCurrencyById.HandleId, ConfigFloroRanchCurrencyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchCurrency rootAsFloroRanchCurrency = FloroRanchCurrency.GetRootAsFloroRanchCurrency(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchCurrencyById.HandleId, ConfigFloroRanchCurrencyById.LogPair);
			return new FloroRanchCurrency?(rootAsFloroRanchCurrency);
		}

		// Token: 0x0400157E RID: 5502
		private const string DB = "db_flororanch.db";

		// Token: 0x0400157F RID: 5503
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001580 RID: 5504
		private const string TABLE = "FloroRanchCurrency";

		// Token: 0x04001581 RID: 5505
		private const string COMMAND = "select BinData from `FloroRanchCurrency` where Id=?";

		// Token: 0x04001582 RID: 5506
		private const string KEY_PREFIX = "FloroRanchCurrencyById";

		// Token: 0x04001583 RID: 5507
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001584 RID: 5508
		private static int HandleId;
	}
}
