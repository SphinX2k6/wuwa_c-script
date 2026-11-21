using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066D RID: 1645
	public class ConfigPhantomBattleBadgeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600269E RID: 9886 RVA: 0x00137804 File Offset: 0x00135A04
		static ConfigPhantomBattleBadgeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00137824 File Offset: 0x00135A24
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadge`")
			});
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x001378A3 File Offset: 0x00135AA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeAll.LogPair = null;
			ConfigPhantomBattleBadgeAll.HandleId = 0;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x001378B1 File Offset: 0x00135AB1
		public static void Init()
		{
			ConfigPhantomBattleBadgeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge`");
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x001378CC File Offset: 0x00135ACC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleBadge> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeAll.HandleId, ConfigPhantomBattleBadgeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleBadge> readOnlyList = (IReadOnlyList<PhantomBattleBadge>)ConfigCommon.GetConfig("PhantomBattleBadgeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleBadge> list = new List<PhantomBattleBadge>();
			while (ConfigCommon.Step(ConfigPhantomBattleBadgeAll.HandleId, false, ConfigPhantomBattleBadgeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeAll.HandleId, 0, ConfigPhantomBattleBadgeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleBadgeAll.HandleId, ConfigPhantomBattleBadgeAll.LogPair);
					return null;
				}
				PhantomBattleBadge rootAsPhantomBattleBadge = PhantomBattleBadge.GetRootAsPhantomBattleBadge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleBadge);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleBadgeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeAll.HandleId, ConfigPhantomBattleBadgeAll.LogPair);
			return list;
		}

		// Token: 0x04002CE1 RID: 11489
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CE2 RID: 11490
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CE3 RID: 11491
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002CE4 RID: 11492
		private const string COMMAND = "select BinData from `PhantomBattleBadge`";

		// Token: 0x04002CE5 RID: 11493
		private const string KEY_PREFIX = "PhantomBattleBadgeAll";

		// Token: 0x04002CE6 RID: 11494
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CE7 RID: 11495
		private static int HandleId;
	}
}
