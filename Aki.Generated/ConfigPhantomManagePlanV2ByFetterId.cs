using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AB RID: 1707
	public class ConfigPhantomManagePlanV2ByFetterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002812 RID: 10258 RVA: 0x0013C2FB File Offset: 0x0013A4FB
		static ConfigPhantomManagePlanV2ByFetterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanV2ByFetterId.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanV2ByFetterId.ResetStaticDefaultValue));
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0013C31C File Offset: 0x0013A51C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomManagePlanV2ByFetterId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomManagePlanV2ByFetterId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantommanageplan.db"),
				new ValueTuple<string, object>("文件", "s.声骸管理方案.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomManagePlanV2"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomManagePlanV2` where FetterId=?")
			});
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0013C39B File Offset: 0x0013A59B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanV2ByFetterId.LogPair = null;
			ConfigPhantomManagePlanV2ByFetterId.HandleId = 0;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0013C3A9 File Offset: 0x0013A5A9
		public static void Init()
		{
			ConfigPhantomManagePlanV2ByFetterId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanV2ByFetterId.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanV2` where FetterId=?");
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0013C3C4 File Offset: 0x0013A5C4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomManagePlanV2> GetConfigList(int p0FetterId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomManagePlanV2ByFetterId.HandleId, ConfigPhantomManagePlanV2ByFetterId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomManagePlanV2ByFetterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FetterId);
				IReadOnlyList<PhantomManagePlanV2> readOnlyList = (IReadOnlyList<PhantomManagePlanV2>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomManagePlanV2ByFetterId.LogPair.Clear();
			ConfigPhantomManagePlanV2ByFetterId.LogPair.Add(new ValueTuple<string, object>("FetterId", p0FetterId));
			if (!ConfigCommon.BindInt(ConfigPhantomManagePlanV2ByFetterId.HandleId, 1, p0FetterId, ConfigPhantomManagePlanV2ByFetterId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomManagePlanV2ByFetterId.HandleId, ConfigPhantomManagePlanV2ByFetterId.LogPair);
				return null;
			}
			List<PhantomManagePlanV2> list = new List<PhantomManagePlanV2>();
			while (ConfigCommon.Step(ConfigPhantomManagePlanV2ByFetterId.HandleId, false, ConfigPhantomManagePlanV2ByFetterId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomManagePlanV2ByFetterId.HandleId, 0, ConfigPhantomManagePlanV2ByFetterId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomManagePlanV2ByFetterId.HandleId, ConfigPhantomManagePlanV2ByFetterId.LogPair);
					return null;
				}
				PhantomManagePlanV2 rootAsPhantomManagePlanV = PhantomManagePlanV2.GetRootAsPhantomManagePlanV2(new ByteBuffer(item2));
				list.Add(rootAsPhantomManagePlanV);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomManagePlanV2ByFetterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FetterId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomManagePlanV2ByFetterId.HandleId, ConfigPhantomManagePlanV2ByFetterId.LogPair);
			return list;
		}

		// Token: 0x04002E93 RID: 11923
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002E94 RID: 11924
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002E95 RID: 11925
		private const string TABLE = "PhantomManagePlanV2";

		// Token: 0x04002E96 RID: 11926
		private const string COMMAND = "select BinData from `PhantomManagePlanV2` where FetterId=?";

		// Token: 0x04002E97 RID: 11927
		private const string KEY_PREFIX = "PhantomManagePlanV2ByFetterId";

		// Token: 0x04002E98 RID: 11928
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E99 RID: 11929
		private static int HandleId;
	}
}
