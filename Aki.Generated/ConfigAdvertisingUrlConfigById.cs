using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007C RID: 124
	public class ConfigAdvertisingUrlConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x0006D6B0 File Offset: 0x0006B8B0
		static ConfigAdvertisingUrlConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingUrlConfigById.CreateStaticDefaultValue), new Action(ConfigAdvertisingUrlConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0006D6D0 File Offset: 0x0006B8D0
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

		// Token: 0x060002EA RID: 746 RVA: 0x0006D74F File Offset: 0x0006B94F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingUrlConfigById.LogPair = null;
			ConfigAdvertisingUrlConfigById.HandleId = 0;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0006D75D File Offset: 0x0006B95D
		public static void Init()
		{
			ConfigAdvertisingUrlConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingUrlConfigById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingUrlConfig` where Id=?");
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0006D778 File Offset: 0x0006B978
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

		// Token: 0x04000348 RID: 840
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000349 RID: 841
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x0400034A RID: 842
		private const string TABLE = "AdvertisingUrlConfig";

		// Token: 0x0400034B RID: 843
		private const string COMMAND = "select BinData from `AdvertisingUrlConfig` where Id=?";

		// Token: 0x0400034C RID: 844
		private const string KEY_PREFIX = "AdvertisingUrlConfigById";

		// Token: 0x0400034D RID: 845
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400034E RID: 846
		private static int HandleId;
	}
}
