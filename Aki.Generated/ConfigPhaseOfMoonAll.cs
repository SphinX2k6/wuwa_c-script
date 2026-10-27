using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BB RID: 1723
	public class ConfigPhaseOfMoonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002872 RID: 10354 RVA: 0x0013E47C File Offset: 0x0013C67C
		static ConfigPhaseOfMoonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhaseOfMoonAll.CreateStaticDefaultValue), new Action(ConfigPhaseOfMoonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x0013E49C File Offset: 0x0013C69C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhaseOfMoonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhaseOfMoonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhaseOfMoon"),
				new ValueTuple<string, object>("语句", "select BinData from `PhaseOfMoon`")
			});
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0013E51B File Offset: 0x0013C71B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhaseOfMoonAll.LogPair = null;
			ConfigPhaseOfMoonAll.HandleId = 0;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0013E529 File Offset: 0x0013C729
		public static void Init()
		{
			ConfigPhaseOfMoonAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhaseOfMoonAll.HandleId, "db_moonsignin.db", "select BinData from `PhaseOfMoon`");
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0013E544 File Offset: 0x0013C744
		[NullableContext(2)]
		public static IReadOnlyList<PhaseOfMoon> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhaseOfMoonAll.HandleId, ConfigPhaseOfMoonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhaseOfMoon> readOnlyList = (IReadOnlyList<PhaseOfMoon>)ConfigCommon.GetConfig("PhaseOfMoonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhaseOfMoon> list = new List<PhaseOfMoon>();
			while (ConfigCommon.Step(ConfigPhaseOfMoonAll.HandleId, false, ConfigPhaseOfMoonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhaseOfMoonAll.HandleId, 0, ConfigPhaseOfMoonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhaseOfMoonAll.HandleId, ConfigPhaseOfMoonAll.LogPair);
					return null;
				}
				PhaseOfMoon rootAsPhaseOfMoon = PhaseOfMoon.GetRootAsPhaseOfMoon(new ByteBuffer(item2));
				list.Add(rootAsPhaseOfMoon);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhaseOfMoonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhaseOfMoonAll.HandleId, ConfigPhaseOfMoonAll.LogPair);
			return list;
		}

		// Token: 0x04002F03 RID: 12035
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002F04 RID: 12036
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002F05 RID: 12037
		private const string TABLE = "PhaseOfMoon";

		// Token: 0x04002F06 RID: 12038
		private const string COMMAND = "select BinData from `PhaseOfMoon`";

		// Token: 0x04002F07 RID: 12039
		private const string KEY_PREFIX = "PhaseOfMoonAll";

		// Token: 0x04002F08 RID: 12040
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F09 RID: 12041
		private static int HandleId;
	}
}
