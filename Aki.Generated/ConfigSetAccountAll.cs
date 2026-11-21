using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000950 RID: 2384
	public class ConfigSetAccountAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037F3 RID: 14323 RVA: 0x00198CD1 File Offset: 0x00196ED1
		static ConfigSetAccountAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSetAccountAll.CreateStaticDefaultValue), new Action(ConfigSetAccountAll.ResetStaticDefaultValue));
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00198CF0 File Offset: 0x00196EF0
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

		// Token: 0x060037F5 RID: 14325 RVA: 0x00198D6F File Offset: 0x00196F6F
		public static void ResetStaticDefaultValue()
		{
			ConfigSetAccountAll.LogPair = null;
			ConfigSetAccountAll.HandleId = 0;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00198D7D File Offset: 0x00196F7D
		public static void Init()
		{
			ConfigSetAccountAll.HandleId = ConfigCommon.InitDataStatement(ConfigSetAccountAll.HandleId, "db_platformchannel.db", "select BinData from `SetAccount` where PackageType!=?");
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00198D98 File Offset: 0x00196F98
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

		// Token: 0x04004116 RID: 16662
		private const string DB = "db_platformchannel.db";

		// Token: 0x04004117 RID: 16663
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04004118 RID: 16664
		private const string TABLE = "SetAccount";

		// Token: 0x04004119 RID: 16665
		private const string COMMAND = "select BinData from `SetAccount` where PackageType!=?";

		// Token: 0x0400411A RID: 16666
		private const string KEY_PREFIX = "SetAccountAll";

		// Token: 0x0400411B RID: 16667
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400411C RID: 16668
		private static int HandleId;
	}
}
