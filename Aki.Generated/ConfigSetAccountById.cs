using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000951 RID: 2385
	public class ConfigSetAccountById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037F9 RID: 14329 RVA: 0x00198F07 File Offset: 0x00197107
		static ConfigSetAccountById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSetAccountById.CreateStaticDefaultValue), new Action(ConfigSetAccountById.ResetStaticDefaultValue));
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00198F28 File Offset: 0x00197128
		public static void CreateStaticDefaultValue()
		{
			ConfigSetAccountById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSetAccountById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "SetAccount"),
				new ValueTuple<string, object>("语句", "select BinData from `SetAccount` where Id=?")
			});
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00198FA7 File Offset: 0x001971A7
		public static void ResetStaticDefaultValue()
		{
			ConfigSetAccountById.LogPair = null;
			ConfigSetAccountById.HandleId = 0;
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00198FB5 File Offset: 0x001971B5
		public static void Init()
		{
			ConfigSetAccountById.HandleId = ConfigCommon.InitDataStatement(ConfigSetAccountById.HandleId, "db_platformchannel.db", "select BinData from `SetAccount` where Id=?");
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00198FD0 File Offset: 0x001971D0
		public static SetAccount? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSetAccountById.HandleId, ConfigSetAccountById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SetAccountById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SetAccount?(SetAccount.GetRootAsSetAccount(configBuffer));
				}
			}
			ConfigSetAccountById.LogPair.Clear();
			ConfigSetAccountById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSetAccountById.HandleId, 1, p0Id, ConfigSetAccountById.LogPair) || ConfigCommon.Step(ConfigSetAccountById.HandleId, true, ConfigSetAccountById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSetAccountById.HandleId, ConfigSetAccountById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSetAccountById.HandleId, 0, ConfigSetAccountById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSetAccountById.HandleId, ConfigSetAccountById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SetAccount rootAsSetAccount = SetAccount.GetRootAsSetAccount(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SetAccountById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSetAccountById.HandleId, ConfigSetAccountById.LogPair);
			return new SetAccount?(rootAsSetAccount);
		}

		// Token: 0x0400411D RID: 16669
		private const string DB = "db_platformchannel.db";

		// Token: 0x0400411E RID: 16670
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x0400411F RID: 16671
		private const string TABLE = "SetAccount";

		// Token: 0x04004120 RID: 16672
		private const string COMMAND = "select BinData from `SetAccount` where Id=?";

		// Token: 0x04004121 RID: 16673
		private const string KEY_PREFIX = "SetAccountById";

		// Token: 0x04004122 RID: 16674
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004123 RID: 16675
		private static int HandleId;
	}
}
