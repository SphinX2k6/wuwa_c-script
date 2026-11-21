using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D3 RID: 1747
	public class ConfigPhaseOfMoonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002902 RID: 10498 RVA: 0x00144EF8 File Offset: 0x001430F8
		static ConfigPhaseOfMoonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhaseOfMoonAll.CreateStaticDefaultValue), new Action(ConfigPhaseOfMoonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00144F18 File Offset: 0x00143118
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

		// Token: 0x06002904 RID: 10500 RVA: 0x00144F97 File Offset: 0x00143197
		public static void ResetStaticDefaultValue()
		{
			ConfigPhaseOfMoonAll.LogPair = null;
			ConfigPhaseOfMoonAll.HandleId = 0;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00144FA5 File Offset: 0x001431A5
		public static void Init()
		{
			ConfigPhaseOfMoonAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhaseOfMoonAll.HandleId, "db_moonsignin.db", "select BinData from `PhaseOfMoon`");
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00144FC0 File Offset: 0x001431C0
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

		// Token: 0x04002FAB RID: 12203
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002FAC RID: 12204
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002FAD RID: 12205
		private const string TABLE = "PhaseOfMoon";

		// Token: 0x04002FAE RID: 12206
		private const string COMMAND = "select BinData from `PhaseOfMoon`";

		// Token: 0x04002FAF RID: 12207
		private const string KEY_PREFIX = "PhaseOfMoonAll";

		// Token: 0x04002FB0 RID: 12208
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FB1 RID: 12209
		private static int HandleId;
	}
}
