using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AD RID: 429
	public class ConfigCountryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x00092723 File Offset: 0x00090923
		static ConfigCountryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCountryById.CreateStaticDefaultValue), new Action(ConfigCountryById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00092744 File Offset: 0x00090944
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

		// Token: 0x06000A13 RID: 2579 RVA: 0x000927C3 File Offset: 0x000909C3
		public static void ResetStaticDefaultValue()
		{
			ConfigCountryById.LogPair = null;
			ConfigCountryById.HandleId = 0;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000927D1 File Offset: 0x000909D1
		public static void Init()
		{
			ConfigCountryById.HandleId = ConfigCommon.InitDataStatement(ConfigCountryById.HandleId, "db_influence.db", "select BinData from `Country` where Id=?");
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000927EC File Offset: 0x000909EC
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

		// Token: 0x04000B9F RID: 2975
		private const string DB = "db_influence.db";

		// Token: 0x04000BA0 RID: 2976
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04000BA1 RID: 2977
		private const string TABLE = "Country";

		// Token: 0x04000BA2 RID: 2978
		private const string COMMAND = "select BinData from `Country` where Id=?";

		// Token: 0x04000BA3 RID: 2979
		private const string KEY_PREFIX = "CountryById";

		// Token: 0x04000BA4 RID: 2980
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BA5 RID: 2981
		private static int HandleId;
	}
}
