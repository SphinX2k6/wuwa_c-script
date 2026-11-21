using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000134 RID: 308
	public class ConfigBuffGetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x000861B3 File Offset: 0x000843B3
		static ConfigBuffGetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffGetAll.CreateStaticDefaultValue), new Action(ConfigBuffGetAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000861D4 File Offset: 0x000843D4
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

		// Token: 0x0600073B RID: 1851 RVA: 0x00086253 File Offset: 0x00084453
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffGetAll.LogPair = null;
			ConfigBuffGetAll.HandleId = 0;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00086261 File Offset: 0x00084461
		public static void Init()
		{
			ConfigBuffGetAll.HandleId = ConfigCommon.InitDataStatement(ConfigBuffGetAll.HandleId, "db_buff.db", "select BinData from `Buff`");
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0008627C File Offset: 0x0008447C
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

		// Token: 0x04000850 RID: 2128
		private const string DB = "db_buff.db";

		// Token: 0x04000851 RID: 2129
		private const string FILE = "b.Buff.xlsx";

		// Token: 0x04000852 RID: 2130
		private const string TABLE = "Buff";

		// Token: 0x04000853 RID: 2131
		private const string COMMAND = "select BinData from `Buff`";

		// Token: 0x04000854 RID: 2132
		private const string KEY_PREFIX = "BuffGetAll";

		// Token: 0x04000855 RID: 2133
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000856 RID: 2134
		private static int HandleId;
	}
}
