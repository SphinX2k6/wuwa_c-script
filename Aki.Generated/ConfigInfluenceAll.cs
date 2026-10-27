using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041C RID: 1052
	public class ConfigInfluenceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018B1 RID: 6321 RVA: 0x000E553D File Offset: 0x000E373D
		static ConfigInfluenceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfluenceAll.CreateStaticDefaultValue), new Action(ConfigInfluenceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000E555C File Offset: 0x000E375C
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

		// Token: 0x060018B3 RID: 6323 RVA: 0x000E55DB File Offset: 0x000E37DB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfluenceAll.LogPair = null;
			ConfigInfluenceAll.HandleId = 0;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000E55E9 File Offset: 0x000E37E9
		public static void Init()
		{
			ConfigInfluenceAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfluenceAll.HandleId, "db_influence.db", "select BinData from `Influence`");
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000E5604 File Offset: 0x000E3804
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

		// Token: 0x04001CA8 RID: 7336
		private const string DB = "db_influence.db";

		// Token: 0x04001CA9 RID: 7337
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04001CAA RID: 7338
		private const string TABLE = "Influence";

		// Token: 0x04001CAB RID: 7339
		private const string COMMAND = "select BinData from `Influence`";

		// Token: 0x04001CAC RID: 7340
		private const string KEY_PREFIX = "InfluenceAll";

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
