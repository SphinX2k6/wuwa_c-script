using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000406 RID: 1030
	public class ConfigHonamiStoryScanMachineAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600182B RID: 6187 RVA: 0x000E2700 File Offset: 0x000E0900
		static ConfigHonamiStoryScanMachineAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScanMachineAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScanMachineAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000E2720 File Offset: 0x000E0920
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

		// Token: 0x0600182D RID: 6189 RVA: 0x000E279F File Offset: 0x000E099F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScanMachineAll.LogPair = null;
			ConfigHonamiStoryScanMachineAll.HandleId = 0;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000E27AD File Offset: 0x000E09AD
		public static void Init()
		{
			ConfigHonamiStoryScanMachineAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScanMachineAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScanMachine`");
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x000E27C8 File Offset: 0x000E09C8
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

		// Token: 0x04001C0E RID: 7182
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C0F RID: 7183
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C10 RID: 7184
		private const string TABLE = "HonamiStoryScanMachine";

		// Token: 0x04001C11 RID: 7185
		private const string COMMAND = "select BinData from `HonamiStoryScanMachine`";

		// Token: 0x04001C12 RID: 7186
		private const string KEY_PREFIX = "HonamiStoryScanMachineAll";

		// Token: 0x04001C13 RID: 7187
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C14 RID: 7188
		private static int HandleId;
	}
}
