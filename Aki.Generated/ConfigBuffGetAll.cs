using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000125 RID: 293
	public class ConfigBuffGetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x0008084F File Offset: 0x0007EA4F
		static ConfigBuffGetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffGetAll.CreateStaticDefaultValue), new Action(ConfigBuffGetAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00080870 File Offset: 0x0007EA70
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffGetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffGetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_buff.db"),
				new ValueTuple<string, object>("文件", "b.Buff.xlsx"),
				new ValueTuple<string, object>("表名", "Buff"),
				new ValueTuple<string, object>("语句", "select BinData from `Buff`")
			});
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000808EF File Offset: 0x0007EAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffGetAll.LogPair = null;
			ConfigBuffGetAll.HandleId = 0;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000808FD File Offset: 0x0007EAFD
		public static void Init()
		{
			ConfigBuffGetAll.HandleId = ConfigCommon.InitDataStatement(ConfigBuffGetAll.HandleId, "db_buff.db", "select BinData from `Buff`");
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00080918 File Offset: 0x0007EB18
		[NullableContext(2)]
		public static IReadOnlyList<Buff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffGetAll.HandleId, ConfigBuffGetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Buff> readOnlyList = (IReadOnlyList<Buff>)ConfigCommon.GetConfig("BuffGetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Buff> list = new List<Buff>();
			while (ConfigCommon.Step(ConfigBuffGetAll.HandleId, false, ConfigBuffGetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffGetAll.HandleId, 0, ConfigBuffGetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBuffGetAll.HandleId, ConfigBuffGetAll.LogPair);
					return null;
				}
				Buff rootAsBuff = Buff.GetRootAsBuff(new ByteBuffer(item2));
				list.Add(rootAsBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BuffGetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBuffGetAll.HandleId, ConfigBuffGetAll.LogPair);
			return list;
		}

		// Token: 0x040007E7 RID: 2023
		private const string DB = "db_buff.db";

		// Token: 0x040007E8 RID: 2024
		private const string FILE = "b.Buff.xlsx";

		// Token: 0x040007E9 RID: 2025
		private const string TABLE = "Buff";

		// Token: 0x040007EA RID: 2026
		private const string COMMAND = "select BinData from `Buff`";

		// Token: 0x040007EB RID: 2027
		private const string KEY_PREFIX = "BuffGetAll";

		// Token: 0x040007EC RID: 2028
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007ED RID: 2029
		private static int HandleId;
	}
}
