using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E0 RID: 224
	public class ConfigBanInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x000774AC File Offset: 0x000756AC
		static ConfigBanInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBanInfoById.CreateStaticDefaultValue), new Action(ConfigBanInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000774CC File Offset: 0x000756CC
		public static void CreateStaticDefaultValue()
		{
			ConfigBanInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBanInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_report.db"),
				new ValueTuple<string, object>("文件", "f.封禁处罚.xlsx"),
				new ValueTuple<string, object>("表名", "BanInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `BanInfo` where Id=?")
			});
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0007754B File Offset: 0x0007574B
		public static void ResetStaticDefaultValue()
		{
			ConfigBanInfoById.LogPair = null;
			ConfigBanInfoById.HandleId = 0;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00077559 File Offset: 0x00075759
		public static void Init()
		{
			ConfigBanInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigBanInfoById.HandleId, "db_report.db", "select BinData from `BanInfo` where Id=?");
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00077574 File Offset: 0x00075774
		public static BanInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBanInfoById.HandleId, ConfigBanInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BanInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BanInfo?(BanInfo.GetRootAsBanInfo(configBuffer));
				}
			}
			ConfigBanInfoById.LogPair.Clear();
			ConfigBanInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBanInfoById.HandleId, 1, p0Id, ConfigBanInfoById.LogPair) || ConfigCommon.Step(ConfigBanInfoById.HandleId, true, ConfigBanInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBanInfoById.HandleId, ConfigBanInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBanInfoById.HandleId, 0, ConfigBanInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBanInfoById.HandleId, ConfigBanInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BanInfo rootAsBanInfo = BanInfo.GetRootAsBanInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BanInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBanInfoById.HandleId, ConfigBanInfoById.LogPair);
			return new BanInfo?(rootAsBanInfo);
		}

		// Token: 0x04000604 RID: 1540
		private const string DB = "db_report.db";

		// Token: 0x04000605 RID: 1541
		private const string FILE = "f.封禁处罚.xlsx";

		// Token: 0x04000606 RID: 1542
		private const string TABLE = "BanInfo";

		// Token: 0x04000607 RID: 1543
		private const string COMMAND = "select BinData from `BanInfo` where Id=?";

		// Token: 0x04000608 RID: 1544
		private const string KEY_PREFIX = "BanInfoById";

		// Token: 0x04000609 RID: 1545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400060A RID: 1546
		private static int HandleId;
	}
}
