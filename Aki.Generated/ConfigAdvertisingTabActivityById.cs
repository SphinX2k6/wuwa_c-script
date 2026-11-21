using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006D RID: 109
	public class ConfigAdvertisingTabActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600028E RID: 654 RVA: 0x0006B963 File Offset: 0x00069B63
		static ConfigAdvertisingTabActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabActivityById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0006B984 File Offset: 0x00069B84
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabActivity` where Id=?")
			});
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0006BA03 File Offset: 0x00069C03
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityById.LogPair = null;
			ConfigAdvertisingTabActivityById.HandleId = 0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0006BA11 File Offset: 0x00069C11
		public static void Init()
		{
			ConfigAdvertisingTabActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabActivityById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabActivity` where Id=?");
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0006BA2C File Offset: 0x00069C2C
		public static AdvertisingTabActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabActivity?(AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(configBuffer));
				}
			}
			ConfigAdvertisingTabActivityById.LogPair.Clear();
			ConfigAdvertisingTabActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabActivityById.HandleId, 1, p0Id, ConfigAdvertisingTabActivityById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabActivityById.HandleId, true, ConfigAdvertisingTabActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabActivityById.HandleId, 0, ConfigAdvertisingTabActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabActivity rootAsAdvertisingTabActivity = AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair);
			return new AdvertisingTabActivity?(rootAsAdvertisingTabActivity);
		}

		// Token: 0x040002DF RID: 735
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002E0 RID: 736
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002E1 RID: 737
		private const string TABLE = "AdvertisingTabActivity";

		// Token: 0x040002E2 RID: 738
		private const string COMMAND = "select BinData from `AdvertisingTabActivity` where Id=?";

		// Token: 0x040002E3 RID: 739
		private const string KEY_PREFIX = "AdvertisingTabActivityById";

		// Token: 0x040002E4 RID: 740
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002E5 RID: 741
		private static int HandleId;
	}
}
