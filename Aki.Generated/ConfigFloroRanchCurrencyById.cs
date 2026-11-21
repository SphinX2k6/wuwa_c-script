using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032B RID: 811
	public class ConfigFloroRanchCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x000C88DF File Offset: 0x000C6ADF
		static ConfigFloroRanchCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCurrencyById.CreateStaticDefaultValue), new Action(ConfigFloroRanchCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000C8900 File Offset: 0x000C6B00
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

		// Token: 0x06001309 RID: 4873 RVA: 0x000C897F File Offset: 0x000C6B7F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCurrencyById.LogPair = null;
			ConfigFloroRanchCurrencyById.HandleId = 0;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000C898D File Offset: 0x000C6B8D
		public static void Init()
		{
			ConfigFloroRanchCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCurrencyById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCurrency` where Id=?");
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000C89A8 File Offset: 0x000C6BA8
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

		// Token: 0x04001611 RID: 5649
		private const string DB = "db_flororanch.db";

		// Token: 0x04001612 RID: 5650
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001613 RID: 5651
		private const string TABLE = "FloroRanchCurrency";

		// Token: 0x04001614 RID: 5652
		private const string COMMAND = "select BinData from `FloroRanchCurrency` where Id=?";

		// Token: 0x04001615 RID: 5653
		private const string KEY_PREFIX = "FloroRanchCurrencyById";

		// Token: 0x04001616 RID: 5654
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001617 RID: 5655
		private static int HandleId;
	}
}
