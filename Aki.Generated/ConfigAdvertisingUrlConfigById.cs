using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000074 RID: 116
	public class ConfigAdvertisingUrlConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00068DFC File Offset: 0x00066FFC
		static ConfigAdvertisingUrlConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingUrlConfigById.CreateStaticDefaultValue), new Action(ConfigAdvertisingUrlConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00068E1C File Offset: 0x0006701C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingUrlConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingUrlConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingUrlConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingUrlConfig` where Id=?")
			});
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00068E9B File Offset: 0x0006709B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingUrlConfigById.LogPair = null;
			ConfigAdvertisingUrlConfigById.HandleId = 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00068EA9 File Offset: 0x000670A9
		public static void Init()
		{
			ConfigAdvertisingUrlConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingUrlConfigById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingUrlConfig` where Id=?");
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00068EC4 File Offset: 0x000670C4
		public static AdvertisingUrlConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingUrlConfigById.HandleId, ConfigAdvertisingUrlConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingUrlConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingUrlConfig?(AdvertisingUrlConfig.GetRootAsAdvertisingUrlConfig(configBuffer));
				}
			}
			ConfigAdvertisingUrlConfigById.LogPair.Clear();
			ConfigAdvertisingUrlConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingUrlConfigById.HandleId, 1, p0Id, ConfigAdvertisingUrlConfigById.LogPair) || ConfigCommon.Step(ConfigAdvertisingUrlConfigById.HandleId, true, ConfigAdvertisingUrlConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingUrlConfigById.HandleId, ConfigAdvertisingUrlConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingUrlConfigById.HandleId, 0, ConfigAdvertisingUrlConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingUrlConfigById.HandleId, ConfigAdvertisingUrlConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingUrlConfig rootAsAdvertisingUrlConfig = AdvertisingUrlConfig.GetRootAsAdvertisingUrlConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingUrlConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingUrlConfigById.HandleId, ConfigAdvertisingUrlConfigById.LogPair);
			return new AdvertisingUrlConfig?(rootAsAdvertisingUrlConfig);
		}

		// Token: 0x04000310 RID: 784
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000311 RID: 785
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000312 RID: 786
		private const string TABLE = "AdvertisingUrlConfig";

		// Token: 0x04000313 RID: 787
		private const string COMMAND = "select BinData from `AdvertisingUrlConfig` where Id=?";

		// Token: 0x04000314 RID: 788
		private const string KEY_PREFIX = "AdvertisingUrlConfigById";

		// Token: 0x04000315 RID: 789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000316 RID: 790
		private static int HandleId;
	}
}
