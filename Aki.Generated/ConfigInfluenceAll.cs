using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000432 RID: 1074
	public class ConfigInfluenceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x000EBC91 File Offset: 0x000E9E91
		static ConfigInfluenceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfluenceAll.CreateStaticDefaultValue), new Action(ConfigInfluenceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000EBCB0 File Offset: 0x000E9EB0
		public static void CreateStaticDefaultValue()
		{
			ConfigInfluenceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfluenceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_influence.db"),
				new ValueTuple<string, object>("文件", "s.势力.xlsx"),
				new ValueTuple<string, object>("表名", "Influence"),
				new ValueTuple<string, object>("语句", "select BinData from `Influence`")
			});
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000EBD2F File Offset: 0x000E9F2F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfluenceAll.LogPair = null;
			ConfigInfluenceAll.HandleId = 0;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x000EBD3D File Offset: 0x000E9F3D
		public static void Init()
		{
			ConfigInfluenceAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfluenceAll.HandleId, "db_influence.db", "select BinData from `Influence`");
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000EBD58 File Offset: 0x000E9F58
		[NullableContext(2)]
		public static IReadOnlyList<Influence> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfluenceAll.HandleId, ConfigInfluenceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Influence> readOnlyList = (IReadOnlyList<Influence>)ConfigCommon.GetConfig("InfluenceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Influence> list = new List<Influence>();
			while (ConfigCommon.Step(ConfigInfluenceAll.HandleId, false, ConfigInfluenceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfluenceAll.HandleId, 0, ConfigInfluenceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfluenceAll.HandleId, ConfigInfluenceAll.LogPair);
					return null;
				}
				Influence rootAsInfluence = Influence.GetRootAsInfluence(new ByteBuffer(item2));
				list.Add(rootAsInfluence);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfluenceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfluenceAll.HandleId, ConfigInfluenceAll.LogPair);
			return list;
		}

		// Token: 0x04001D42 RID: 7490
		private const string DB = "db_influence.db";

		// Token: 0x04001D43 RID: 7491
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04001D44 RID: 7492
		private const string TABLE = "Influence";

		// Token: 0x04001D45 RID: 7493
		private const string COMMAND = "select BinData from `Influence`";

		// Token: 0x04001D46 RID: 7494
		private const string KEY_PREFIX = "InfluenceAll";

		// Token: 0x04001D47 RID: 7495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D48 RID: 7496
		private static int HandleId;
	}
}
