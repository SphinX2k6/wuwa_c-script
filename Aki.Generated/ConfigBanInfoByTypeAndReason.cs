using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F0 RID: 240
	public class ConfigBanInfoByTypeAndReason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x0007D058 File Offset: 0x0007B258
		static ConfigBanInfoByTypeAndReason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBanInfoByTypeAndReason.CreateStaticDefaultValue), new Action(ConfigBanInfoByTypeAndReason.ResetStaticDefaultValue));
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0007D078 File Offset: 0x0007B278
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

		// Token: 0x060005A3 RID: 1443 RVA: 0x0007D0F7 File Offset: 0x0007B2F7
		public static void ResetStaticDefaultValue()
		{
			ConfigBanInfoByTypeAndReason.LogPair = null;
			ConfigBanInfoByTypeAndReason.HandleId = 0;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0007D105 File Offset: 0x0007B305
		public static void Init()
		{
			ConfigBanInfoByTypeAndReason.HandleId = ConfigCommon.InitDataStatement(ConfigBanInfoByTypeAndReason.HandleId, "db_report.db", "select BinData from `BanInfo` where BanType=? AND BanReason=?");
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0007D120 File Offset: 0x0007B320
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

		// Token: 0x04000674 RID: 1652
		private const string DB = "db_report.db";

		// Token: 0x04000675 RID: 1653
		private const string FILE = "f.封禁处罚.xlsx";

		// Token: 0x04000676 RID: 1654
		private const string TABLE = "BanInfo";

		// Token: 0x04000677 RID: 1655
		private const string COMMAND = "select BinData from `BanInfo` where BanType=? AND BanReason=?";

		// Token: 0x04000678 RID: 1656
		private const string KEY_PREFIX = "BanInfoByTypeAndReason";

		// Token: 0x04000679 RID: 1657
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400067A RID: 1658
		private static int HandleId;
	}
}
