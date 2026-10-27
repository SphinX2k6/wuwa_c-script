using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F3 RID: 1267
	public class ConfigLordGymAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DBD RID: 7613 RVA: 0x0010162B File Offset: 0x000FF82B
		static ConfigLordGymAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymAll.CreateStaticDefaultValue), new Action(ConfigLordGymAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0010164C File Offset: 0x000FF84C
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

		// Token: 0x06001DBF RID: 7615 RVA: 0x001016CB File Offset: 0x000FF8CB
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymAll.LogPair = null;
			ConfigLordGymAll.HandleId = 0;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x001016D9 File Offset: 0x000FF8D9
		public static void Init()
		{
			ConfigLordGymAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymAll.HandleId, "db_lordgym.db", "select BinData from `LordGym`");
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x001016F4 File Offset: 0x000FF8F4
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

		// Token: 0x04002289 RID: 8841
		private const string DB = "db_lordgym.db";

		// Token: 0x0400228A RID: 8842
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x0400228B RID: 8843
		private const string TABLE = "LordGym";

		// Token: 0x0400228C RID: 8844
		private const string COMMAND = "select BinData from `LordGym`";

		// Token: 0x0400228D RID: 8845
		private const string KEY_PREFIX = "LordGymAll";

		// Token: 0x0400228E RID: 8846
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400228F RID: 8847
		private static int HandleId;
	}
}
