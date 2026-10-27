using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000905 RID: 2309
	public class ConfigSetAccountAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003631 RID: 13873 RVA: 0x0018BAB1 File Offset: 0x00189CB1
		static ConfigSetAccountAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSetAccountAll.CreateStaticDefaultValue), new Action(ConfigSetAccountAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0018BAD0 File Offset: 0x00189CD0
		public static void CreateStaticDefaultValue()
		{
			ConfigSetAccountAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSetAccountAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "SetAccount"),
				new ValueTuple<string, object>("语句", "select BinData from `SetAccount` where PackageType!=?")
			});
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0018BB4F File Offset: 0x00189D4F
		public static void ResetStaticDefaultValue()
		{
			ConfigSetAccountAll.LogPair = null;
			ConfigSetAccountAll.HandleId = 0;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0018BB5D File Offset: 0x00189D5D
		public static void Init()
		{
			ConfigSetAccountAll.HandleId = ConfigCommon.InitDataStatement(ConfigSetAccountAll.HandleId, "db_platformchannel.db", "select BinData from `SetAccount` where PackageType!=?");
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0018BB78 File Offset: 0x00189D78
		[NullableContext(2)]
		public static IReadOnlyList<SetAccount> GetConfigList(int p0PackageType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSetAccountAll.HandleId, ConfigSetAccountAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SetAccountAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				IReadOnlyList<SetAccount> readOnlyList = (IReadOnlyList<SetAccount>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSetAccountAll.LogPair.Clear();
			ConfigSetAccountAll.LogPair.Add(new ValueTuple<string, object>("PackageType", p0PackageType));
			if (!ConfigCommon.BindInt(ConfigSetAccountAll.HandleId, 1, p0PackageType, ConfigSetAccountAll.LogPair))
			{
				ConfigCommon.Reset(ConfigSetAccountAll.HandleId, ConfigSetAccountAll.LogPair);
				return null;
			}
			List<SetAccount> list = new List<SetAccount>();
			while (ConfigCommon.Step(ConfigSetAccountAll.HandleId, false, ConfigSetAccountAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSetAccountAll.HandleId, 0, ConfigSetAccountAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSetAccountAll.HandleId, ConfigSetAccountAll.LogPair);
					return null;
				}
				SetAccount rootAsSetAccount = SetAccount.GetRootAsSetAccount(new ByteBuffer(item2));
				list.Add(rootAsSetAccount);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SetAccountAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSetAccountAll.HandleId, ConfigSetAccountAll.LogPair);
			return list;
		}

		// Token: 0x04003F09 RID: 16137
		private const string DB = "db_platformchannel.db";

		// Token: 0x04003F0A RID: 16138
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04003F0B RID: 16139
		private const string TABLE = "SetAccount";

		// Token: 0x04003F0C RID: 16140
		private const string COMMAND = "select BinData from `SetAccount` where PackageType!=?";

		// Token: 0x04003F0D RID: 16141
		private const string KEY_PREFIX = "SetAccountAll";

		// Token: 0x04003F0E RID: 16142
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F0F RID: 16143
		private static int HandleId;
	}
}
