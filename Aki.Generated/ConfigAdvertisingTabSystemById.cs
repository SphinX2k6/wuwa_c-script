using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007B RID: 123
	public class ConfigAdvertisingTabSystemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0006D467 File Offset: 0x0006B667
		static ConfigAdvertisingTabSystemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabSystemById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabSystemById.ResetStaticDefaultValue));
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0006D488 File Offset: 0x0006B688
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabSystemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabSystemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabSystem"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabSystem` where Id=?")
			});
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0006D507 File Offset: 0x0006B707
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabSystemById.LogPair = null;
			ConfigAdvertisingTabSystemById.HandleId = 0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0006D515 File Offset: 0x0006B715
		public static void Init()
		{
			ConfigAdvertisingTabSystemById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabSystemById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabSystem` where Id=?");
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0006D530 File Offset: 0x0006B730
		public static AdvertisingTabSystem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabSystemById.HandleId, ConfigAdvertisingTabSystemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabSystemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabSystem?(AdvertisingTabSystem.GetRootAsAdvertisingTabSystem(configBuffer));
				}
			}
			ConfigAdvertisingTabSystemById.LogPair.Clear();
			ConfigAdvertisingTabSystemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabSystemById.HandleId, 1, p0Id, ConfigAdvertisingTabSystemById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabSystemById.HandleId, true, ConfigAdvertisingTabSystemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabSystemById.HandleId, ConfigAdvertisingTabSystemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabSystemById.HandleId, 0, ConfigAdvertisingTabSystemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabSystemById.HandleId, ConfigAdvertisingTabSystemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabSystem rootAsAdvertisingTabSystem = AdvertisingTabSystem.GetRootAsAdvertisingTabSystem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabSystemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabSystemById.HandleId, ConfigAdvertisingTabSystemById.LogPair);
			return new AdvertisingTabSystem?(rootAsAdvertisingTabSystem);
		}

		// Token: 0x04000341 RID: 833
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000342 RID: 834
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000343 RID: 835
		private const string TABLE = "AdvertisingTabSystem";

		// Token: 0x04000344 RID: 836
		private const string COMMAND = "select BinData from `AdvertisingTabSystem` where Id=?";

		// Token: 0x04000345 RID: 837
		private const string KEY_PREFIX = "AdvertisingTabSystemById";

		// Token: 0x04000346 RID: 838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000347 RID: 839
		private static int HandleId;
	}
}
