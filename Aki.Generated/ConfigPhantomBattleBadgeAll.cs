using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000655 RID: 1621
	public class ConfigPhantomBattleBadgeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600260E RID: 9742 RVA: 0x00130D88 File Offset: 0x0012EF88
		static ConfigPhantomBattleBadgeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00130DA8 File Offset: 0x0012EFA8
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

		// Token: 0x06002610 RID: 9744 RVA: 0x00130E27 File Offset: 0x0012F027
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeAll.LogPair = null;
			ConfigPhantomBattleBadgeAll.HandleId = 0;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00130E35 File Offset: 0x0012F035
		public static void Init()
		{
			ConfigPhantomBattleBadgeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge`");
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00130E50 File Offset: 0x0012F050
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

		// Token: 0x04002C39 RID: 11321
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C3A RID: 11322
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C3B RID: 11323
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002C3C RID: 11324
		private const string COMMAND = "select BinData from `PhantomBattleBadge`";

		// Token: 0x04002C3D RID: 11325
		private const string KEY_PREFIX = "PhantomBattleBadgeAll";

		// Token: 0x04002C3E RID: 11326
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C3F RID: 11327
		private static int HandleId;
	}
}
