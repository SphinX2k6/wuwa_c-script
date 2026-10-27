using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016B RID: 363
	public class ConfigCiacconaGalSubEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x000898DC File Offset: 0x00087ADC
		static ConfigCiacconaGalSubEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalSubEndingById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalSubEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000898FC File Offset: 0x00087AFC
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalSubEndingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalSubEndingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalSubEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalSubEnding` where Id=?")
			});
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0008997B File Offset: 0x00087B7B
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalSubEndingById.LogPair = null;
			ConfigCiacconaGalSubEndingById.HandleId = 0;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00089989 File Offset: 0x00087B89
		public static void Init()
		{
			ConfigCiacconaGalSubEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalSubEndingById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalSubEnding` where Id=?");
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000899A4 File Offset: 0x00087BA4
		public static CiacconaGalSubEnding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalSubEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalSubEnding?(CiacconaGalSubEnding.GetRootAsCiacconaGalSubEnding(configBuffer));
				}
			}
			ConfigCiacconaGalSubEndingById.LogPair.Clear();
			ConfigCiacconaGalSubEndingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalSubEndingById.HandleId, 1, p0Id, ConfigCiacconaGalSubEndingById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalSubEndingById.HandleId, true, ConfigCiacconaGalSubEndingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalSubEndingById.HandleId, 0, ConfigCiacconaGalSubEndingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalSubEnding rootAsCiacconaGalSubEnding = CiacconaGalSubEnding.GetRootAsCiacconaGalSubEnding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalSubEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair);
			return new CiacconaGalSubEnding?(rootAsCiacconaGalSubEnding);
		}

		// Token: 0x040009D1 RID: 2513
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009D2 RID: 2514
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009D3 RID: 2515
		private const string TABLE = "CiacconaGalSubEnding";

		// Token: 0x040009D4 RID: 2516
		private const string COMMAND = "select BinData from `CiacconaGalSubEnding` where Id=?";

		// Token: 0x040009D5 RID: 2517
		private const string KEY_PREFIX = "CiacconaGalSubEndingById";

		// Token: 0x040009D6 RID: 2518
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009D7 RID: 2519
		private static int HandleId;
	}
}
