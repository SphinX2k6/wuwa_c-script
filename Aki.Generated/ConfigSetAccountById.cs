using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000906 RID: 2310
	public class ConfigSetAccountById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003637 RID: 13879 RVA: 0x0018BCE7 File Offset: 0x00189EE7
		static ConfigSetAccountById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSetAccountById.CreateStaticDefaultValue), new Action(ConfigSetAccountById.ResetStaticDefaultValue));
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0018BD08 File Offset: 0x00189F08
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

		// Token: 0x06003639 RID: 13881 RVA: 0x0018BD87 File Offset: 0x00189F87
		public static void ResetStaticDefaultValue()
		{
			ConfigSetAccountById.LogPair = null;
			ConfigSetAccountById.HandleId = 0;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0018BD95 File Offset: 0x00189F95
		public static void Init()
		{
			ConfigSetAccountById.HandleId = ConfigCommon.InitDataStatement(ConfigSetAccountById.HandleId, "db_platformchannel.db", "select BinData from `SetAccount` where Id=?");
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0018BDB0 File Offset: 0x00189FB0
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

		// Token: 0x04003F10 RID: 16144
		private const string DB = "db_platformchannel.db";

		// Token: 0x04003F11 RID: 16145
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04003F12 RID: 16146
		private const string TABLE = "SetAccount";

		// Token: 0x04003F13 RID: 16147
		private const string COMMAND = "select BinData from `SetAccount` where Id=?";

		// Token: 0x04003F14 RID: 16148
		private const string KEY_PREFIX = "SetAccountById";

		// Token: 0x04003F15 RID: 16149
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F16 RID: 16150
		private static int HandleId;
	}
}
