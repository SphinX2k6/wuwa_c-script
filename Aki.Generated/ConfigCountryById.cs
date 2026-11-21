using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BF RID: 447
	public class ConfigCountryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A7D RID: 2685 RVA: 0x0009865B File Offset: 0x0009685B
		static ConfigCountryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCountryById.CreateStaticDefaultValue), new Action(ConfigCountryById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0009867C File Offset: 0x0009687C
		public static void CreateStaticDefaultValue()
		{
			ConfigCountryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCountryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_influence.db"),
				new ValueTuple<string, object>("文件", "s.势力.xlsx"),
				new ValueTuple<string, object>("表名", "Country"),
				new ValueTuple<string, object>("语句", "select BinData from `Country` where Id=?")
			});
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000986FB File Offset: 0x000968FB
		public static void ResetStaticDefaultValue()
		{
			ConfigCountryById.LogPair = null;
			ConfigCountryById.HandleId = 0;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00098709 File Offset: 0x00096909
		public static void Init()
		{
			ConfigCountryById.HandleId = ConfigCommon.InitDataStatement(ConfigCountryById.HandleId, "db_influence.db", "select BinData from `Country` where Id=?");
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00098724 File Offset: 0x00096924
		public static Country? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCountryById.HandleId, ConfigCountryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CountryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Country?(Country.GetRootAsCountry(configBuffer));
				}
			}
			ConfigCountryById.LogPair.Clear();
			ConfigCountryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCountryById.HandleId, 1, p0Id, ConfigCountryById.LogPair) || ConfigCommon.Step(ConfigCountryById.HandleId, true, ConfigCountryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCountryById.HandleId, ConfigCountryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCountryById.HandleId, 0, ConfigCountryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCountryById.HandleId, ConfigCountryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Country rootAsCountry = Country.GetRootAsCountry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CountryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCountryById.HandleId, ConfigCountryById.LogPair);
			return new Country?(rootAsCountry);
		}

		// Token: 0x04000C1D RID: 3101
		private const string DB = "db_influence.db";

		// Token: 0x04000C1E RID: 3102
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04000C1F RID: 3103
		private const string TABLE = "Country";

		// Token: 0x04000C20 RID: 3104
		private const string COMMAND = "select BinData from `Country` where Id=?";

		// Token: 0x04000C21 RID: 3105
		private const string KEY_PREFIX = "CountryById";

		// Token: 0x04000C22 RID: 3106
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C23 RID: 3107
		private static int HandleId;
	}
}
