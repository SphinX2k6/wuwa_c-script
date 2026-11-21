using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000509 RID: 1289
	public class ConfigLordGymAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E41 RID: 7745 RVA: 0x00107D7F File Offset: 0x00105F7F
		static ConfigLordGymAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymAll.CreateStaticDefaultValue), new Action(ConfigLordGymAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00107DA0 File Offset: 0x00105FA0
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGym"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGym`")
			});
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00107E1F File Offset: 0x0010601F
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymAll.LogPair = null;
			ConfigLordGymAll.HandleId = 0;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00107E2D File Offset: 0x0010602D
		public static void Init()
		{
			ConfigLordGymAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymAll.HandleId, "db_lordgym.db", "select BinData from `LordGym`");
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00107E48 File Offset: 0x00106048
		[NullableContext(2)]
		public static IReadOnlyList<LordGym> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymAll.HandleId, ConfigLordGymAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LordGym> readOnlyList = (IReadOnlyList<LordGym>)ConfigCommon.GetConfig("LordGymAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LordGym> list = new List<LordGym>();
			while (ConfigCommon.Step(ConfigLordGymAll.HandleId, false, ConfigLordGymAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymAll.HandleId, 0, ConfigLordGymAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymAll.HandleId, ConfigLordGymAll.LogPair);
					return null;
				}
				LordGym rootAsLordGym = LordGym.GetRootAsLordGym(new ByteBuffer(item2));
				list.Add(rootAsLordGym);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LordGymAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymAll.HandleId, ConfigLordGymAll.LogPair);
			return list;
		}

		// Token: 0x04002323 RID: 8995
		private const string DB = "db_lordgym.db";

		// Token: 0x04002324 RID: 8996
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002325 RID: 8997
		private const string TABLE = "LordGym";

		// Token: 0x04002326 RID: 8998
		private const string COMMAND = "select BinData from `LordGym`";

		// Token: 0x04002327 RID: 8999
		private const string KEY_PREFIX = "LordGymAll";

		// Token: 0x04002328 RID: 9000
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002329 RID: 9001
		private static int HandleId;
	}
}
