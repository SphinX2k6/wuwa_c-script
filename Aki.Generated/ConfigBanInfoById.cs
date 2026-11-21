using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EF RID: 239
	public class ConfigBanInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x0007CE10 File Offset: 0x0007B010
		static ConfigBanInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBanInfoById.CreateStaticDefaultValue), new Action(ConfigBanInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0007CE30 File Offset: 0x0007B030
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

		// Token: 0x0600059D RID: 1437 RVA: 0x0007CEAF File Offset: 0x0007B0AF
		public static void ResetStaticDefaultValue()
		{
			ConfigBanInfoById.LogPair = null;
			ConfigBanInfoById.HandleId = 0;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0007CEBD File Offset: 0x0007B0BD
		public static void Init()
		{
			ConfigBanInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigBanInfoById.HandleId, "db_report.db", "select BinData from `BanInfo` where Id=?");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0007CED8 File Offset: 0x0007B0D8
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

		// Token: 0x0400066D RID: 1645
		private const string DB = "db_report.db";

		// Token: 0x0400066E RID: 1646
		private const string FILE = "f.封禁处罚.xlsx";

		// Token: 0x0400066F RID: 1647
		private const string TABLE = "BanInfo";

		// Token: 0x04000670 RID: 1648
		private const string COMMAND = "select BinData from `BanInfo` where Id=?";

		// Token: 0x04000671 RID: 1649
		private const string KEY_PREFIX = "BanInfoById";

		// Token: 0x04000672 RID: 1650
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000673 RID: 1651
		private static int HandleId;
	}
}
