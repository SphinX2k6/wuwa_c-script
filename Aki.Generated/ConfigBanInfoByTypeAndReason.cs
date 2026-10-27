using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E1 RID: 225
	public class ConfigBanInfoByTypeAndReason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x000776F4 File Offset: 0x000758F4
		static ConfigBanInfoByTypeAndReason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBanInfoByTypeAndReason.CreateStaticDefaultValue), new Action(ConfigBanInfoByTypeAndReason.ResetStaticDefaultValue));
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00077714 File Offset: 0x00075914
		public static void CreateStaticDefaultValue()
		{
			ConfigBanInfoByTypeAndReason.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBanInfoByTypeAndReason.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_report.db"),
				new ValueTuple<string, object>("文件", "f.封禁处罚.xlsx"),
				new ValueTuple<string, object>("表名", "BanInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `BanInfo` where BanType=? AND BanReason=?")
			});
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00077793 File Offset: 0x00075993
		public static void ResetStaticDefaultValue()
		{
			ConfigBanInfoByTypeAndReason.LogPair = null;
			ConfigBanInfoByTypeAndReason.HandleId = 0;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000777A1 File Offset: 0x000759A1
		public static void Init()
		{
			ConfigBanInfoByTypeAndReason.HandleId = ConfigCommon.InitDataStatement(ConfigBanInfoByTypeAndReason.HandleId, "db_report.db", "select BinData from `BanInfo` where BanType=? AND BanReason=?");
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000777BC File Offset: 0x000759BC
		public static BanInfo? GetConfig(int p0BanType, int p1BanReason, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBanInfoByTypeAndReason.HandleId, ConfigBanInfoByTypeAndReason.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BanInfoByTypeAndReason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BanType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BanReason);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BanInfo?(BanInfo.GetRootAsBanInfo(configBuffer));
				}
			}
			ConfigBanInfoByTypeAndReason.LogPair.Clear();
			ConfigBanInfoByTypeAndReason.LogPair.Add(new ValueTuple<string, object>("BanType", p0BanType));
			ConfigBanInfoByTypeAndReason.LogPair.Add(new ValueTuple<string, object>("BanReason", p1BanReason));
			if (!ConfigCommon.BindInt(ConfigBanInfoByTypeAndReason.HandleId, 1, p0BanType, ConfigBanInfoByTypeAndReason.LogPair) || !ConfigCommon.BindInt(ConfigBanInfoByTypeAndReason.HandleId, 2, p1BanReason, ConfigBanInfoByTypeAndReason.LogPair) || ConfigCommon.Step(ConfigBanInfoByTypeAndReason.HandleId, true, ConfigBanInfoByTypeAndReason.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBanInfoByTypeAndReason.HandleId, ConfigBanInfoByTypeAndReason.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBanInfoByTypeAndReason.HandleId, 0, ConfigBanInfoByTypeAndReason.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBanInfoByTypeAndReason.HandleId, ConfigBanInfoByTypeAndReason.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BanInfo rootAsBanInfo = BanInfo.GetRootAsBanInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BanInfoByTypeAndReason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BanType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BanReason);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBanInfoByTypeAndReason.HandleId, ConfigBanInfoByTypeAndReason.LogPair);
			return new BanInfo?(rootAsBanInfo);
		}

		// Token: 0x0400060B RID: 1547
		private const string DB = "db_report.db";

		// Token: 0x0400060C RID: 1548
		private const string FILE = "f.封禁处罚.xlsx";

		// Token: 0x0400060D RID: 1549
		private const string TABLE = "BanInfo";

		// Token: 0x0400060E RID: 1550
		private const string COMMAND = "select BinData from `BanInfo` where BanType=? AND BanReason=?";

		// Token: 0x0400060F RID: 1551
		private const string KEY_PREFIX = "BanInfoByTypeAndReason";

		// Token: 0x04000610 RID: 1552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000611 RID: 1553
		private static int HandleId;
	}
}
