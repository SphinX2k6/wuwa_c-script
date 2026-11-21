using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041C RID: 1052
	public class ConfigHonamiStoryScanMachineAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x000E8E54 File Offset: 0x000E7054
		static ConfigHonamiStoryScanMachineAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScanMachineAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScanMachineAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000E8E74 File Offset: 0x000E7074
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryScanMachineAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryScanMachineAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryScanMachine"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryScanMachine`")
			});
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000E8EF3 File Offset: 0x000E70F3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScanMachineAll.LogPair = null;
			ConfigHonamiStoryScanMachineAll.HandleId = 0;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000E8F01 File Offset: 0x000E7101
		public static void Init()
		{
			ConfigHonamiStoryScanMachineAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScanMachineAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScanMachine`");
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000E8F1C File Offset: 0x000E711C
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryScanMachine> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryScanMachineAll.HandleId, ConfigHonamiStoryScanMachineAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HonamiStoryScanMachine> readOnlyList = (IReadOnlyList<HonamiStoryScanMachine>)ConfigCommon.GetConfig("HonamiStoryScanMachineAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HonamiStoryScanMachine> list = new List<HonamiStoryScanMachine>();
			while (ConfigCommon.Step(ConfigHonamiStoryScanMachineAll.HandleId, false, ConfigHonamiStoryScanMachineAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryScanMachineAll.HandleId, 0, ConfigHonamiStoryScanMachineAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryScanMachineAll.HandleId, ConfigHonamiStoryScanMachineAll.LogPair);
					return null;
				}
				HonamiStoryScanMachine rootAsHonamiStoryScanMachine = HonamiStoryScanMachine.GetRootAsHonamiStoryScanMachine(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryScanMachine);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HonamiStoryScanMachineAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryScanMachineAll.HandleId, ConfigHonamiStoryScanMachineAll.LogPair);
			return list;
		}

		// Token: 0x04001CA8 RID: 7336
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CA9 RID: 7337
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001CAA RID: 7338
		private const string TABLE = "HonamiStoryScanMachine";

		// Token: 0x04001CAB RID: 7339
		private const string COMMAND = "select BinData from `HonamiStoryScanMachine`";

		// Token: 0x04001CAC RID: 7340
		private const string KEY_PREFIX = "HonamiStoryScanMachineAll";

		// Token: 0x04001CAD RID: 7341
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CAE RID: 7342
		private static int HandleId;
	}
}
