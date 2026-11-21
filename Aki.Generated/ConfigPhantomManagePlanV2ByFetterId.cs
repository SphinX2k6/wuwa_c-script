using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C3 RID: 1731
	public class ConfigPhantomManagePlanV2ByFetterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028A2 RID: 10402 RVA: 0x00142D77 File Offset: 0x00140F77
		static ConfigPhantomManagePlanV2ByFetterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanV2ByFetterId.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanV2ByFetterId.ResetStaticDefaultValue));
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00142D98 File Offset: 0x00140F98
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

		// Token: 0x060028A4 RID: 10404 RVA: 0x00142E17 File Offset: 0x00141017
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanV2ByFetterId.LogPair = null;
			ConfigPhantomManagePlanV2ByFetterId.HandleId = 0;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00142E25 File Offset: 0x00141025
		public static void Init()
		{
			ConfigPhantomManagePlanV2ByFetterId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanV2ByFetterId.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanV2` where FetterId=?");
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00142E40 File Offset: 0x00141040
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

		// Token: 0x04002F3B RID: 12091
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002F3C RID: 12092
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002F3D RID: 12093
		private const string TABLE = "PhantomManagePlanV2";

		// Token: 0x04002F3E RID: 12094
		private const string COMMAND = "select BinData from `PhantomManagePlanV2` where FetterId=?";

		// Token: 0x04002F3F RID: 12095
		private const string KEY_PREFIX = "PhantomManagePlanV2ByFetterId";

		// Token: 0x04002F40 RID: 12096
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F41 RID: 12097
		private static int HandleId;
	}
}
